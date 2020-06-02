using System;

namespace InfixToPostfix
{
    class Program
    {
        static char[] stack = new char[100];
        static int top = -1;
        static void push(char temp)
        {
            top++;
            stack[top] = temp;
        }

        static char pop()
        {
            return stack[top--];
        }

        static int getPriority(char op)
        {
            switch (op){
                case '+': case '-': return 1; 
                case '*': case '/': return 2; 
                case '^': return 3;
            }
            return 0;
        }

        static void Main(string[] args)
        {
            int i;
            char[] infix = new char[100];
            Console.WriteLine("Enter infix: ");
            infix = Console.ReadLine().ToCharArray();
            int length = infix.Length;
            for (i = 0; infix[i] != '\0'; i++)
            {
                switch (infix[i])
                {
                    case '(':
                        push(infix[i]);
                        break;
                    case ')':
                        while (stack[top] != '(')
                        {
                            char temp = pop();
                            Console.WriteLine(temp);
                        }
                        pop();
                        break;
                    case '+': case '-': case '*': case '/':case '^':
                        //check priority
                        //push if stackPriority is > infix priority
                        //printf("P1 : %d ",getPriority(stack[top]));
                        //printf("P2 : %d\n",getPriority(infix[i]));
                        if (top == -1 || stack[top] == '(')
                            push(infix[i]);
                        else if (getPriority(stack[top]) < getPriority(infix[i]))
                            push(infix[i]);
                        else
                        {
                            //pop the whole stack until lower priority
                            while (getPriority(stack[top]) >= getPriority(infix[i]) && stack[top] != '(')
                            {
                                char temp = pop();
                                Console.Write(temp);
                            }
                            push(infix[i]);
                        }
                        break;
                    default: Console.WriteLine(infix[i]); break;
                }
            }
            //pop the remaining stack
            while (top >= 0)
            {
                char temp = pop();
                Console.WriteLine(temp);
            }
        }
    }
}
