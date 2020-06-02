using System;
using System.Collections.Generic;
using System.Text;

namespace InfixToPostfixBetter
{
    class Postfix
    { 
        static Stack<char> stack = new Stack<char>();
        static int getPriority(char op)
        {
            switch (op)
            {
                case '+': case '-': return 1;
                case '*': case '/': return 2;
                case '^': return 3;
            }
            return 0;
        }
        public static string infixToPostfixConverter(string infix) {
            string postfix = "";
            for (int i = 0; i < infix.Length; i++) {
                switch (infix[i]) {
                    case '(': 
                        stack.Push(infix[i]); break;
                    case ')':
                        while (stack.Peek() != '(') {
                            postfix += stack.Pop(); 
                        }
                        stack.Pop();
                        break;
                    case '+': case '-': case '*': case '/': case '^':
                        if (stack.Count == 0)
                            stack.Push(infix[i]);
                        else if (getPriority(stack.Peek()) < getPriority(infix[i]))
                            stack.Push(infix[i]);
                        else {
                            try {
                                while (getPriority(stack.Peek()) >= getPriority(infix[i]))
                                {
                                    postfix += stack.Pop();
                                }
                            }
                            catch (InvalidOperationException e) {
                            }                           
                            stack.Push(infix[i]);
                        }
                        break;

                    default: postfix += infix[i]; break;
                }
            }

            //empty stack
            while (stack.Count != 0)
            {
                postfix += stack.Pop();
            }

            return postfix;
        }
    }
}
