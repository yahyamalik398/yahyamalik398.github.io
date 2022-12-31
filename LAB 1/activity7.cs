using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace activity7
{
    class activtiy7
    {
        static void Main(string[] args)
        {
            int a, b;

            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());

            int r = DivideWithoutOperator(a, b);
            Console.WriteLine("Answer is : " + r);

            Console.ReadLine();
        }

        static int DivideWithoutOperator(int value1, int value2)
        {
            // checking if the divisor is 0
            if (value2 == 0)
            {
                Console.WriteLine("Can not be divided 0");
                return -1;
            }

            // initializing variable for storing the result
            int quotient = 0;

            // Calculating the result using loop
            while (value1 >= value2)
            {
                value1 = value1 - value2;
                quotient++;   
            }

            // printing the value 
            Console.WriteLine("The remainder is : " +  value1);

            // returning output
            return quotient;
        }

     }
            
}