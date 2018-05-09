using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Intro_C_Sharp_Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Testing all functions
            int result = Sum(20, 40);
            Console.WriteLine($"Calling Sum() with two arguments, result is {result}");

            //Three argument sum- Overloaded
            int result3 = Sum(60, 70, 80);
            Console.WriteLine($"Calling Sum() with three arguments, result is {result3}");

            //Double parameter
            double result2 = Sum(20.6, 40.2);
            Console.WriteLine($"Calling Sum() with double arguments, result id {result2}");
        }

        static int Sum(int first, int second)
        {
            int sum = first + second;
            return sum; 
        }

        static int Sum(int first, int second, int third)
        {
            int sum = first + second + third;
            return sum;
        }

        static double Sum(double first, double second)
        {
            double result = first + second;
            return result;
        }
    }
}
