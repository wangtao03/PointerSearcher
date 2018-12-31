using System;
using System.Collections.Generic;
using System.IO;

namespace PointerSearcher
{
    internal class Searcher
    {
        private string _memdump_path;
        private uint[] _memdump;
        private uint _memory_start;
        private uint _memory_end;
        private string _msg_error = string.Empty;

        public uint[] MemoryDump => _memdump;
        public string Msg_Error => _msg_error;

        /// <summary>
        /// 解析函数
        /// </summary>
        /// <param name="memdump_path">内存转储文件路径</param>
        /// <param name="memory_start">内存起始地址</param>
        public Searcher(string memdump_path, uint memory_start)
        {
            _memdump_path = memdump_path;
            _memory_start = memory_start;
        }

        private bool LoadMemoryDump()
        {
            _msg_error = string.Empty;
            if (_memdump == null)
            {
                if (File.Exists(_memdump_path))
                {
                    var array = File.ReadAllBytes(_memdump_path);
                    _memory_end = _memory_start + (uint)array.Length;

                    if (array.Length % 4 == 0)
                    {
                        _memdump = new uint[array.Length / 4];
                        Buffer.BlockCopy(array, 0, _memdump, 0, array.Length);
                    }
                }
            }
            _msg_error = "内存转储可能已损坏.";
            return (_memdump != null);
        }

        public uint GetPointerAddress(uint address, uint offset, bool negative)
        {
            if (!LoadMemoryDump()) return 0;

            address -= _memory_start;
            address /= 4;
            if ((ulong)address > (ulong)((long)_memdump.Length))
            {
                return 0;
            }
            if (_memdump[(int)((UIntPtr)address)] < _memory_start || _memdump[(int)((UIntPtr)address)] > _memory_end)
            {
                return 0;
            }
            if (!negative)
            {
                return _memdump[(int)((UIntPtr)address)] + offset;
            }
            return _memdump[(int)((UIntPtr)address)] - offset;
        }

        public List<Pointer> FindPointers(uint address, uint max_offset)
        {
            if (!LoadMemoryDump()) return null;

            var pointers = new List<Pointer>();

            //地址小于内存起始值则将地址与内存起始值相加
            address += (address < _memory_start) ? _memory_start : 0;

            if (address > _memory_end)
            {
                _msg_error = "地址值过大,请从检查后重新输入.";
                return pointers;
            }
            for (int i = 0; i < _memdump.Length; i++)
            {
                if (_memdump[i] >= _memory_start && _memdump[i] <= _memory_end)
                {
                    if (_memdump[i] <= address && _memdump[i] >= address - max_offset)
                    {
                        pointers.Add(new Pointer((uint)(i * 4 + (int)_memory_start), (uint)(0x100000000UL - (ulong)(_memdump[i] - address)), _memdump[i], false, _memory_start));
                    }
                    else if (_memdump[i] >= address && _memdump[i] <= address + max_offset)
                    {
                        pointers.Add(new Pointer((uint)(i * 4 + (int)_memory_start), _memdump[i] - address, _memdump[i], true, _memory_start));
                    }
                }
            }
            return pointers;
        }
    }
}