using System;
using System.Text.RegularExpressions;

namespace practical3
{
    class Program
    {
        static void Main(string[] args)
        {
            int decimalNumber;

            #region Binary To Decimal
            bool flag = true;
            string binaryString;


            Console.WriteLine("Enter a binary number");
            do
            {
                if (!flag)
                    Console.WriteLine("Please enter a valid binary value");
                binaryString = Console.ReadLine();
                flag = false;
            } while (!Regex.IsMatch(binaryString, @"^[01]+$"));

            ConvertBinaryToDecimal(binaryString, out decimalNumber);
            Console.WriteLine("Answer: " + decimalNumber);

            #endregion

            #region Decimal To Octal and Binary


            int number, newBase;

            TakeDecimalInput(out decimalNumber);

            Console.WriteLine("In which base you want to convert? (2 or 8)");
            newBase = int.Parse(Console.ReadLine());

            ConvertDecimalToBinaryOrOctal(decimalNumber, out number, newBase);
            Console.WriteLine(number);

            #endregion

            #region Decimal To HexaDecimal
            string hex;
            TakeDecimalInput(out decimalNumber);
            ConvertDecimalToHex(decimalNumber, out hex);
            Console.WriteLine($"Hexadecimal equivalent of {decimalNumber} is {hex}");
            #endregion

            Console.Read();
        }

        #region Conversion Methods


        private static void ConvertDecimalToHex(int decimalNumber, out string hex)
        {
            char[] modulo = new char[31];
            int i = 0, temp;
            hex = "";

            while (decimalNumber > 0)
            {
                temp = (char)(decimalNumber % 16);
                if (temp > 9)
                    modulo[i] = (char)(temp + 55);
                else
                    modulo[i] = (char)(temp + 48);
                decimalNumber /= 16;
                i++;
            }

            i--;


            for (; i >= 0; i--)
            {
                hex += modulo[i];
            }
        }



        private static void ConvertDecimalToBinaryOrOctal(int decimalNumber, out int number, int newBase)
        {
            number = 0;
            int[] modulo = new int[31];
            int i = 0;
            string numberString = "";


            while (decimalNumber > 0)
            {
                modulo[i++] = decimalNumber % newBase;
                decimalNumber /= newBase;
            }

            i--;
            for (; i >= 0; i--)
            {
                numberString += modulo[i].ToString();
            }
            number = int.Parse(numberString);
        }


        private static void ConvertBinaryToDecimal(string binaryString, out int decimalNumber)
        {

            decimalNumber = 0;
            int bit;
            int powerCounter = 0;

            //Convertion of Binary to Decimal
            for (int i = binaryString.Length - 1; i >= 0; i--)
            {
                bit = int.Parse(binaryString[i].ToString());
                decimalNumber += bit * (int)Math.Pow(2, powerCounter++);
            }
        }
        #endregion



        private static void TakeDecimalInput(out int decimalNumber)
        {
            string numberString;
            bool flag = true;


            Console.Write("Enter Decimal Number: ");
            do
            {
                if (!flag)
                    Console.WriteLine("Please enter a valid decimal number");
                numberString = Console.ReadLine();
                flag = false;
            } while (!int.TryParse(numberString, out decimalNumber));
        }
    }
}