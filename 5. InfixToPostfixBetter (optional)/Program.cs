using System;
using InfixToPostfixBetter;
namespace InfixToPostfixBetter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter infix: ");
            string infix = Console.ReadLine();
            Console.WriteLine("Postfix: ");
            string postfix = Postfix.infixToPostfixConverter(infix);
            Console.Write(postfix);
        }
    }
}
