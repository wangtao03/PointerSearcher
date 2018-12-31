using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace PointerSearcher
{
    public partial class frmMain : Form
    {
        public static string OpenFile(string defaultfile, string filter, string title)
        {
            using (var openFileDialog = new OpenFileDialog
            {
                FileName = ((defaultfile.Length > 0) ? defaultfile : null),
                InitialDirectory = ((defaultfile.Length > 0) ? defaultfile : Directory.GetCurrentDirectory()),
                Filter = filter,
                Title = title
            })
            {
                var dialogResult = openFileDialog.ShowDialog();
                if (dialogResult == DialogResult.OK)
                {
                    return openFileDialog.FileName;
                }
                return defaultfile;
            }
        }

        public static uint ParseNum(string s)
        {
            return ParseNum(s, NumberStyles.None);
        }

        public static uint ParseNum(string s, NumberStyles numstyle)
        {
            if (s.Trim().Length == 0)
            {
                return 0u;
            }
            if (s.StartsWith("0x"))
            {
                return uint.Parse(s.Remove(0, 2), NumberStyles.AllowHexSpecifier);
            }
            return uint.Parse(s, numstyle);
        }

        public static void SortList<T>(List<T> dataSource, string fieldName, bool asc)
        {
            var propInfo = typeof(T).GetProperty(fieldName);
            Comparison<T> comparison = delegate (T a, T b)
            {
                var obj = asc ? propInfo.GetValue(a, null) : propInfo.GetValue(b, null);
                var obj2 = asc ? propInfo.GetValue(b, null) : propInfo.GetValue(a, null);
                if (!(obj is IComparable))
                {
                    return 0;
                }
                return ((IComparable)obj).CompareTo(obj2);
            };
            dataSource.Sort(comparison);
        }

        private TreeNodeCollection GetParentEqualTree(TreeNodeCollection nodes, int level)
        {
            using (var treeView = new TreeView())
            {
                foreach (object obj in nodes)
                {
                    var treeNode = (TreeNode)obj;
                    if (treeNode.Level <= level)
                    {
                        treeView.Nodes.Add(treeNode.Text);
                        var parentEqualTree = GetParentEqualTree(treeNode.Nodes, level);
                        foreach (object obj2 in parentEqualTree)
                        {
                            var treeNode2 = (TreeNode)obj2;
                            treeView.Nodes.Add(treeNode2.Text);
                        }
                    }
                }
                return treeView.Nodes;
            }
        }

        /// <summary>
        /// 从Tree中移除与父节点相同的节点
        /// </summary>
        /// <param name="pointers"></param>
        /// <returns></returns>
        private List<Pointer> RemoveParentEqualTree(List<Pointer> pointers)
        {
            var list = new List<Pointer>();
            if (tvwPointers.Nodes.Count > 0)
            {
                var parentEqualTree = GetParentEqualTree(tvwPointers.Nodes, (tvwPointers.SelectedNode == null) ? 0 : tvwPointers.SelectedNode.Level);
                for (int i = 0; i < parentEqualTree.Count; i++)
                {
                    list.Add(new Pointer(parentEqualTree[i].Text, memory_start));
                }
            }

            for (int j = 0; j < list.Count; j++)
            {
                for (int k = 0; k < pointers.Count; k++)
                {
                    if (list[j].Address == pointers[k].Address)
                    {
                        pointers.RemoveAt(k);
                    }
                }
            }

            return pointers;
        }

        /// <summary>
        /// 测试指针与地址是否匹配
        /// </summary>
        /// <param name="array"></param>
        /// <param name="address"></param>
        /// <param name="memdump"></param>
        /// <returns></returns>
        private bool TestPoint(string[] array, string address, Searcher memdump)
        {
            var num = ParseNum(address, NumberStyles.AllowHexSpecifier);

            if (num < memory_start) num += memory_start;

            uint num2 = 0;

            for (int m = 0; m < array.Length; m++)
            {
                var pointer = new Pointer(array[array.Length - 1 - m], memory_start);
                if (m == 0)
                {
                    num2 = pointer.Address;
                }
                num2 = memdump.GetPointerAddress(num2, pointer.Offset, pointer.Negative);
            }
            return (num == num2) ? true : false;
        }

        /// <summary>
        /// 添加指针到Tree
        /// </summary>
        /// <param name="pointers"></param>
        /// <param name="parent"></param>
        private void AddPointerTree(List<Pointer> pointers, TreeNode parent)
        {
            if (pointers == null) return;

            var foreColor = Color.Black;

            //按地址排序
            SortList<Pointer>(pointers, "Address", true);

            //剔除子节点中与父节点地址相同的节点
            if (chkOptimizePointerPaths.Checked) pointers = RemoveParentEqualTree(pointers);

            //用来记录匹配成功的次数
            var hit = 0;
            var hitMax = 0;
            //枚举指针
            for (int l = 0; l < pointers.Count; l++)
            {
                hit = 0;
                if (memdump2 != null)
                {
                    hitMax = 1;
                    var array = (((tvwPointers.SelectedNode == null) ? "" : (tvwPointers.SelectedNode.FullPath + "\\")) + pointers[l]).Split(new char[] { '\\' });

                    //与转储2测试
                    if (TestPoint(array, txtAddress2.Text, memdump2)) hit++;
                    //与转储3测试
                    if (chkMemDump3.Checked && memdump3 != null)
                    {
                        hitMax++;
                        if (TestPoint(array, txtAddress3.Text, memdump3)) hit++;
                    }

                    //与转储4测试
                    if (chkMemDump4.Checked && memdump4 != null)
                    {
                        hitMax++;
                        if (TestPoint(array, txtAddress4.Text, memdump4)) hit++;
                    }

                    //根据hit 匹配颜色
                    switch (hit)
                    {
                        default:
                        case 0:
                            foreColor = Color.Black;
                            break;

                        case 1:
                            foreColor = Color.Green;
                            break;

                        case 2:
                            foreColor = Color.Blue;
                            break;

                        case 3:
                            foreColor = Color.Red;
                            break;
                    }

                    if (!pointers[l].Negative || chkIncludeNegatives.Checked)
                    {
                        var treeNode = new TreeNode
                        {
                            Text = pointers[l].ToString(chkRealAddresses.Checked ? 0 : memory_start),
                            ForeColor = foreColor
                        };
                        if (chkFilteringInvalid.Checked && hit != hitMax)
                        {
                            continue;
                        }
                        if (parent == null)
                        {
                            tvwPointers.Nodes.Add(treeNode);
                        }
                        else
                        {
                            parent.Nodes.Add(treeNode);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// 生成CWCheat代码
        /// </summary>
        /// <param name="pointers"></param>
        /// <param name="bittype"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        private string GetCWCheatPointerCode(List<Pointer> pointers, int bittype)
        {
            if (bittype != 0 && bittype != 1 && bittype != 2)
            {
                bittype = 2;
            }
            if (pointers[0].Negative)
            {
                bittype += 3;
            }
            var text = "";
            var builder = new System.Text.StringBuilder();
            builder.Append(text);
            for (int i = 0; i < pointers.Count - 1; i++)
            {
                if (i % 2 == 0)
                {
                    builder.Append($"{(this.chkRAWCode.Checked ? "" : "_L ")}0x{(pointers[i].Negative ? 3 : 2):X01}{pointers[i].Offset:X07}");
                }
                else
                {
                    builder.Append($" 0x{(pointers[i].Negative ? 3 : 2):X01}{pointers[i].Offset:X07}\n");
                }
            }
            text = builder.ToString();
            if (pointers.Count % 2 == 0)
            {
                text += string.Format(" 0x00000000", new object[0]);
            }
            text = string.Format("{0}0x6{1:X07} 0x{2:X08}\n{0}0x000{3:X01}{4:X04} 0x{5:X08}\n", new object[]
            {
            this.chkRAWCode.Checked ? "" : "_L ",
            pointers[0].Address - this.memory_start,
            "XXXXXXXX",
            bittype,
            pointers.Count,
            pointers[pointers.Count - 1].Offset
            }) + text;
            return (this.chkRAWCode.Checked ? "" : "_C0 Generated Code\n") + text;
        }

        /// <summary>
        /// 生成AR代码
        /// </summary>
        /// <param name="pointers"></param>
        /// <param name="bittype"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        private string GetARPointerCode(List<Pointer> pointers, int bittype)
        {
            switch (bittype)
            {
                case 0:
                    bittype = 2;
                    break;

                case 1:
                    bittype = 1;
                    break;

                case 2:
                    bittype = 0;
                    break;

                default:
                    bittype = 0;
                    break;
            }
            string text = "";
            for (int i = 0; i < pointers.Count; i++)
            {
                if (pointers[i].Negative)
                {
                    text += string.Format("DC000000 {0:X08}\n{1:X01}0000000 {2}\n", (long)(0x100000000UL - (ulong)pointers[i].Offset), (i == pointers.Count - 1) ? bittype : 11, (i == pointers.Count - 1) ? "XXXXXXXX" : "00000000");
                }
                else
                {
                    text += string.Format("{0:X01}{1:X07} {2}\n", (i == pointers.Count - 1) ? bittype : 11, pointers[i].Offset, (i == pointers.Count - 1) ? "XXXXXXXX" : "00000000");
                }
            }
            text = string.Format("6{0:X07} 00000000\nB{0:X07} 00000000\n{1}D2000000 00000000", pointers[0].Address, text);
            return (this.chkRAWCode.Checked ? "" : "::Generated Code\n") + text;
        }

        private string GetPsvCheatPointerCode(List<Pointer> pointers, int bittype)
        {
            var key = 3;
            var text = string.Empty;
            var endText = string.Empty;

            switch (cmbPsvCheatCodeType.SelectedIndex)
            {
                default:
                case 0:
                    key = 3;
                    endText = "$3300 00000000 XXXXXXXX";
                    break;

                case 1:
                    key = 8;
                    endText = "$8800 00000000 00000000\n ...\n$8900 00000000 00000000";
                    break;

                case 2:
                    key = 7;
                    endText = "$77XX 00000000 YYYYYYYY\n$ZZZZ AAAAAAAA BBBBBBBB";
                    break;
            }
            var builder = new System.Text.StringBuilder();
            builder.Append(text);
            for (int i = 0; i < pointers.Count - 1; i++)
            {
                builder.Append(string.Format("{0}{1:X08} {2:X08}\n", new object[] {
                    this.chkRAWCode.Checked ? "" : $"${key}{bittype}00 ",
                    0,
                    pointers[i + 1].Offset }));
            }
            text = builder.ToString();

            text = string.Format("{0}{1:X08} {2:X08}\n", new object[] {
                this.chkRAWCode.Checked ? "" : $"${key}{bittype}{pointers.Count:X02} ",
                pointers[0].Address,
                pointers[0].Offset
            }) + text;

            text += endText;
            return (this.chkRAWCode.Checked ? "" : "_V0 Generated Code\n") + text;
        }
    }
}