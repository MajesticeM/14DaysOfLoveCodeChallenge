using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Conditional_Statements
{
    class Loops
    {

        public static void Question1()
        {
            Console.WriteLine(" Write a program in C# Sharp to display the first 10 natural numbers.");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }

        public static void Question2() 
        {
            Console.WriteLine("Write a C# Sharp program to find the sum of first 10 natural numbers.");
            int sum;
            for (int i = 0; i < 10; i++)
            {
                sum = i++;
                Console.WriteLine(i);
                Console.WriteLine("The first 10 natural number is:"+ sum);
            }
        }

        public static void Question3() 
        {
            
    }
}
