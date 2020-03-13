using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pratical1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rectangle");
            Pattern1();

            Console.WriteLine("\nLeft aligned triangle");
            Pattern2();

            Console.WriteLine("\nLeft aligned inverse triangle");
            Pattern3();

            Console.WriteLine("\nRight aligned triangle");
            Pattern4();

            Console.WriteLine("\nRight aligned inverse triangle");
            Pattern5();

            Console.WriteLine("\nCenter aligned triangle");
            Pattern6();

            Console.WriteLine("\nDiamond");
            Pattern7();

            Console.Read();
        }
       
        private static void Pattern7()
        {
            for (int i = 1; i <= 11; i += 2)
            {
                for (int k = 0; k < 5 - i / 2; k++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int i = 11; i > 0; i -= 2)
            {
                for (int k = 0; k < 5 - i / 2; k++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

      
        private static void Pattern6()
        {
            for (int i = 1; i <= 11; i += 2)
            {
                for (int k = 0; k < 5 - i / 2; k++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

       
        private static void Pattern5()
        {
            for (int i = 5; i > 0; i--)
            {
                for (int k = 0; k < 5 - i; k++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

       
        private static void Pattern4()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int k = 0; k < 5 - i; k++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        private static void Pattern3()
        {
            for (int i = 5; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        
        private static void Pattern2()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
      
        private static void Pattern1()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}