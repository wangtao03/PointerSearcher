using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace PointerSearcher
{
    public partial class frmMain : Form
    {
        private Searcher memdump1;
        private Searcher memdump2;
        private Searcher memdump3;
        private Searcher memdump4;

        private uint memory_start;

        public frmMain()
        {
            InitializeComponent();
        }

        private void CmbMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBaseAddress.Enabled = false;
            switch (cmbMode.SelectedIndex)
            {
                case 0:
                    memory_start = 0x08800000;
                    break;

                case 1:
                    memory_start = 0x02000000;
                    break;

                case 2:
                    memory_start = 0x81000000;
                    break;

                case 3:
                default:
                    memory_start = 0;
                    txtBaseAddress.Enabled = true;
                    break;
            }
            txtBaseAddress.Text = string.Format("0x{0:X08}", memory_start);
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            cmbMode.SelectedIndex = 2;
            cmbPsvCheatCodeType.SelectedIndex = 0;
        }

        private void TxtFile_Click(object sender, EventArgs e)
        {
            ((TextBox)sender).Text = OpenFile(((TextBox)sender).Text, null, "选择转储文件");
        }

        private void TxtFileDragDrop_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
                return;
            }
            e.Effect = DragDropEffects.None;
        }

        private void TxtFile_DragDrop(object sender, DragEventArgs e)
        {
            ((TextBox)sender).Text = ((string[])e.Data.GetData(DataFormats.FileDrop))[0];
        }

        private void ChkMemDump3_CheckedChanged(object sender, EventArgs e)
        {
            txtAddress3.Enabled = txtMemDump3.Enabled = chkMemDump3.Checked;
        }

        private void ChkMemDump4_CheckedChanged(object sender, EventArgs e)
        {
            txtAddress4.Enabled = txtMemDump4.Enabled = chkMemDump4.Checked;
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            tvwPointers.Nodes.Clear();
        }

        private void BtnFindPointers_Click(object sender, EventArgs e)
        {
            var address = 0u;
            var max_offset = 0u;
            try
            {
                address = ParseNum(txtAddress1.Text, NumberStyles.AllowHexSpecifier);
            }
            catch (Exception)
            {
                MessageBox.Show("解析地址失败,请确认输入的是十六进制数值.");
                return;
            }
            try
            {
                max_offset = ParseNum(txtMaxOffset.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("解析最大偏移量失败,请确认输入的是十六进制数值.");
                return;
            }
            try
            {
                memory_start = ParseNum(txtBaseAddress.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("解析内存基址失败,请确认输入的是十六进制数值.");
                return;
            }

            tvwPointers.Nodes.Clear();

            //锁定数据输入界面防止出错
            progressBar1.Visible = true;
            grpDump.Enabled = false;
            grpOtheOption.Enabled = false;

            memdump1 = new Searcher(txtMemDump1.Text, memory_start);
            memdump2 = new Searcher(txtMemDump2.Text, memory_start);

            if (chkMemDump3.Checked) memdump3 = new Searcher(txtMemDump3.Text, memory_start);
            if (chkMemDump4.Checked) memdump4 = new Searcher(txtMemDump4.Text, memory_start);

            var pointers = memdump1.FindPointers(address, max_offset);
            AddPointerTree(pointers, tvwPointers.SelectedNode);

            //解锁数据输入界面
            progressBar1.Visible = false;
            grpDump.Enabled = true;
            grpOtheOption.Enabled = true;

        }

        private void TvwPointers_DoubleClick(object sender, EventArgs e)
        {
            if (tvwPointers.SelectedNode != null)
            {
                uint max_offset = 0u;
                try
                {
                    max_offset = ParseNum(txtMaxOffset.Text, NumberStyles.AllowHexSpecifier);
                }
                catch (Exception)
                {
                    MessageBox.Show("解析最大偏移量失败,请确认输入的是十六进制数值.");
                    return;
                }
                tvwPointers.SelectedNode.Nodes.Clear();
                var pointer = new Pointer(tvwPointers.SelectedNode.Text, memory_start);
                var pointers = memdump1.FindPointers(pointer.Address, max_offset);
                AddPointerTree(pointers, tvwPointers.SelectedNode);
            }
        }

        private void tvwPointers_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (tvwPointers.SelectedNode != null)
            {
                var list = new List<Pointer>();
                var array = tvwPointers.SelectedNode.FullPath.ToString().Split(new char[] { '\\' });
                for (int i = 0; i < array.Length; i++)
                {
                    list.Add(new Pointer(array[array.Length - 1 - i], memory_start));
                }

                var bittype = 2;
                if (rdbPointerSearcherBitType16.Checked) bittype = 1;
                else if (rdbPointerSearcherBitType8.Checked) bittype = 0;

                var text="";

                if (rdoCpdeTypePsvCheat.Checked) text = GetPsvCheatPointerCode(list, bittype);
                else if (rdoCodeTypeCWCheat.Checked) text = GetCWCheatPointerCode(list, bittype);
                else if (rdoCodeTypeAR.Checked) text = GetARPointerCode(list, bittype);

                txtCode.Text = text.Replace("\n", "\r\n");
            }
        }
    }
}