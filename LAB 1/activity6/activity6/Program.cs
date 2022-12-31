using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace activity6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            int result = 0;
            char op;

            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            op = Convert.ToChar(Console.ReadLine());

            switch (op)
            {
                case '+':
                    {
                        result = a + b;
                        break;
                    }

                case '-':
                    {
                        result = a - b;
                        break;
                    }
                case '*':
                    {
                        result = a * b;
                        break;
                    }

                case '/':
                    {
                        if (b != 0)
                        {
                            result = a / b;
                        }
                        else
                        {
                            Console.WriteLine("Can not be divided by 0");
                        }
                        break;
                    }

                case '%':
                    {
                        if (a >= b)
                        {
                            result = a % b;
                        }
                        break;
                    }

            }

            Console.WriteLine("so the result is : " + result);
            Console.ReadLine();

        }
        
    }
}
