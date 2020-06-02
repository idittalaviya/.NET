using System;
using System.Collections.Generic;
using System.Text;

namespace Conversions
{
    interface IConvert
    {
       public string BinaryToDecimal(string Binary);
        public string DecimalToBinary(int Decimal);
        public string DecimalToOctal(int Decimal);
        public string DecimalToHexadecimal(int Decimal);
    }
}
