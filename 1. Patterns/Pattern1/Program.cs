using System;

namespace Pattern1
{
    class Program
    {
        // This function creates the following pattern:
        // *****
        // *****
        // *****
        // *****
        // *****
        static void Pattern1() {
            int i = 0, j = 0;
            while (i < 5)
            {
                while (j < 5)
                {
                    Console.Write("*");
                    j++;
                }
                Console.Write("\n");
                j = 0;
                i++;
            }
        }

        // This function creates the following pattern:
        //    *
        //   * *
        //  * * *
        // * * * *
        //* * * * *
        static void Pattern2()
        {
            for(int i = 0; i < 5; i++)
            {
                for (int k = 0; k < 4 - i; k++)
                    Console.Write(" ");
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }

        // This function creates the following pattern:
        //*
        //**
        //***
        //****
        //*****
        static void Pattern3() {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            
        }

        // This function creates the following pattern:
        //*****
        //****
        //***
        //**
        //*
        static void Pattern4()
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

        static void Main(string[] args)
        {
            Console.WriteLine("Pattern 1 : ");
            Pattern1();
            Console.WriteLine();
            Console.WriteLine("Pattern 2 : ");
            Pattern2();
            Console.WriteLine();
            Console.WriteLine("Pattern 3 : ");
            Pattern3();
            Console.WriteLine();
            Console.WriteLine("Pattern 4 : ");
            Pattern4();
            Console.WriteLine();
        }
    }
}
