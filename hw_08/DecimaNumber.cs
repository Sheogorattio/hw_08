using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimaNumberClass
{
    struct DecimaNumber
    {
        public int number;
        public DecimaNumber(int num)
        {
            number = num;
        }
        public string ToBinary()
        {
            return Convert.ToString(number,2);
        }
        public string ToOct()
        {
            return Convert.ToString(number, 8);
        }
        public string ToHex()
        {
            return Convert.ToString(number, 16);
        }
    }
}
