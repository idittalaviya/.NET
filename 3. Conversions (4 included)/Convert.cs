using System;
using System.Collections.Generic;
using System.Text;

namespace Conversions
{
    class Convert : IConvert
    {
        public string BinaryToDecimal(string Binary)
        {
            int Decimal = 0, temp, i = 0;
            int binaryValue = int.Parse(Binary);
            while (binaryValue > 0)
            {
                temp = (binaryValue % 10);
                Decimal = Decimal + (temp * (int)Math.Pow(2, i));
                i++;
                binaryValue = binaryValue / 10;
            }
            string Result = $"Binary: {Binary} is converted to Decimal: {Decimal}";
            return Result;
        }

        public string DecimalToBinary(int decimalValue)
        {
            string Result = $"Decimal: {decimalValue} is converted to Binary: ";
            int value = decimalValue; int i;
            int[] binaryString = new int[10];
            for (i = 0; value > 0; i++)
            {
                binaryString[i] = (value % 2);
                value = value / 2;
            }
            i--;
            for (; i >= 0; i--)
            {
                Result += binaryString[i].ToString();
            }
            return Result;
        }
        public string DecimalToOctal(int decimalValue)
        {
            string Result = $"Decimal: {decimalValue} is converted to Octal: ";
            int value = decimalValue; int i;
            int[] octalString = new int[10];
            for (i = 0; value > 0; i++)
            {
                octalString[i] = (value % 8);
                value = value / 8;
            }
            i--;
            for (; i >= 0; i--)
            {
                Result += octalString[i].ToString();
            }
            return Result;
        }
        public string DecimalToHexadecimal(int decimalValue)
        {
            string Result = $"Decimal: {decimalValue} is converted to Hexadecimal: ";
            int value = decimalValue; int i;
            int[] hexadecimalString = new int[10];
            for (i = 0; value > 0; i++)
            {
                hexadecimalString[i] = (value % 16);
                value /= 16;
            }
            i--;
            for (; i >= 0; i--)
            {
                switch (hexadecimalString[i])
                {
                    case 10: Result += "A"; break;
                    case 11: Result += "B"; break;
                    case 12: Result += "C"; break;
                    case 13: Result += "D"; break;
                    case 14: Result += "E"; break;
                    case 15: Result += "F"; break;
                    default: Result += hexadecimalString[i].ToString(); break;
                }
            }
            return Result;
        }

    }
}
