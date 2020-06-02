using System;
using System.Globalization;

namespace CurrencyConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter amount in Rupee:");
            decimal Rupee, Dollar, Franc, Euro;
            Rupee = decimal.Parse(Console.ReadLine());
            Dollar = Rupee * 0.0135107M;
            Franc = Rupee * 0.0126123M;
            Euro = Rupee * 0.0119623M;
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine($"Dollar:{Dollar.ToString("C", new CultureInfo("en-US"))}");
            Console.WriteLine($"Frank: {Franc.ToString("C", new CultureInfo("de-CH"))}");
            Console.WriteLine($"Euro: {Euro.ToString("C", new CultureInfo("es-ES"))}");
        }
    }
}
