using System;
using System.Collections.Generic;
using System.Linq;

namespace practical4
{
    class Program
    {
        static void Main(string[] args)
        {
            string infix;
            string postfix;
            infix = "a+b/c*d";
            infixToPostfix(infix, out postfix);
            Console.WriteLine($"Infix Expression {infix}\nPostfix Expression {postfix}");
            Console.Read();

        }
      
        private static void infixToPostfix(string infix, out string postfix)
        {
            postfix = "";
            char ch;
            Stack<char> operators = new Stack<char>();

           
            for (int i = 0; i < infix.Length; i++)
            {
                ch = infix[i];
                if ("^()+-*/%".Any(c => c == ch)) 
                {
                    if (operators.Count == 0)
                    {
                       
                        operators.Push(ch);
                    }
                    else
                    {
                        if (ch == '(')
                        {
                            operators.Push(ch);
                        }
                        else if (ch == ')')
                        {
                          
                            while (operators.Peek() != '(')
                            {
                                postfix += operators.Pop();
                            }
                            operators.Pop(); 
                        }
                        else if (priority(ch) > priority(operators.Peek()))
                        {
                          
                            operators.Push(ch);
                        }
                        else
                        {
                            
                            postfix += operators.Pop();
                            i--;
                        }
                    }
                }
                else
                {
                   
                    postfix += ch;
                }
            }

            
            foreach (var item in operators)
            {
                postfix += item;
            }
        }

       
        private static int priority(char ch)
        {
            switch (ch)
            {
                case '(':
                    return 0; 
                case '+':
                case '-':
                    return 1;
                case '*':
                case '/':
                    return 2;
                case '^':
                    return 3; 
                default:
                    return 4; 
            }
        }
    }
}