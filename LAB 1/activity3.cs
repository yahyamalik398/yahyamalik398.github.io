using System;

namespace activity
{
    class activity
    {
        static void Main(String[] args)
        {
            int a, b;
            char op;

            Console.Write("Enter Operator : ");
            op = Convert.ToChar(Console.ReadLine());

            Console.Write("Enter First Number :");
            a = Convert.ToInt32(Console.ReadLine());


            Console.Write("Enter Second Number : ");
            b = Convert.ToInt32(Console.ReadLine());

            int r = 0;

            if(op == '+')
            {
                r = a + b;
            }
            else if (op == '-')
            {
                r = a - b;
            }
            else if (op == '*')
            {
                r = a * b;
            }
            else if (op == '/')
            {
                r = a / b;
            }

            Console.Write("Result is : " + r);
            Console.Read();



        }
    }
}