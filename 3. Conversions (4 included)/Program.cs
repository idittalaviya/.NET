using System;

namespace Conversions
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Convert obj = new Convert();

            Console.WriteLine(obj.BinaryToDecimal("1000"));
            Console.WriteLine(obj.DecimalToBinary(8));
            Console.WriteLine(obj.DecimalToOctal(16));
            Console.WriteLine(obj.DecimalToHexadecimal(16));
        }
    }
}
