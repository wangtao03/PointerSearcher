using System.Globalization;
using System.Text.RegularExpressions;

namespace PointerSearcher
{
    internal class Pointer
    {
        private uint _address;                  //地址
        private uint _offset;                   //偏移量
        private uint _value;                    //地址对应的值
        private bool _negative;                 //偏移量是否为负

        public uint Address => _address;
        public uint Offset => _offset;
        public uint Value => _value;
        public bool Negative => _negative;

        /// <summary>
        /// 解析函数
        /// </summary>
        /// <param name="address">地址</param>
        /// <param name="offset">偏移量</param>
        /// <param name="value">地址对应的值</param>
        /// <param name="negative">偏移量是否为负</param>
        /// <param name="memory_start">内存起始地址</param>
        public Pointer(uint address, uint offset, uint value, bool negative, uint memory_start)
        {
            _address = address;
            _offset = offset;
            _value = value;
            _negative = negative;
            if (_address < memory_start)
            {
                _address += memory_start;
            }
        }

        /// <summary>
        /// 解析函数
        /// </summary>
        /// <param name="s">指定格式的文本</param>
        /// <param name="memory_start">内存起始地址</param>
        public Pointer(string s, uint memory_start)
        {
            var regex = new Regex("Address:\\s*0x(.*);\\s*Offset:\\s*(-?)0x(.*);\\s*Value:\\s*0x(.*);");
            var match = regex.Match(s);
            _address = uint.Parse(match.Groups[1].Value, NumberStyles.AllowHexSpecifier);
            _negative = (match.Groups[2].Value == "-");
            _offset = uint.Parse(match.Groups[3].Value, NumberStyles.AllowHexSpecifier);
            _value = uint.Parse(match.Groups[4].Value, NumberStyles.AllowHexSpecifier);

            if (_address < memory_start)
            {
                _address += memory_start;
            }
        }

        /// <summary>
        /// 返回该对象的字符串表示
        /// </summary>
        /// <returns>字符串</returns>
        public override string ToString() => ToString(0x0);

        /// <summary>
        /// 返回该对象的字符串表示
        /// </summary>
        /// <param name="address_base">内存基址</param>
        /// <returns>字符串</returns>
        public string ToString(uint address_base) => string.Format("Address: 0x{0:X08}; Offset: {1}0x{2:X}; Value: 0x{3:X08};", new object[]
            {
                _address - address_base,
                _negative ? "-" : "",
                _offset,
                _value - address_base
            });
    }
}