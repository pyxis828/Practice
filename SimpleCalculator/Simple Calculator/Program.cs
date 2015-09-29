using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number");
            double one = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            double two = double.Parse(Console.ReadLine());
            Console.WriteLine("What operation do you want to perform(+, - , * , /)?");
            char operation = char.Parse(Console.ReadLine());
            if (operation == '+')
            {
                SimpleAdd(one, two);
            }
            if (operation == '-')
            {
                SimpleSubtract(one, two);
            }
            if (operation == '*')
            {
                SimpleMultiply(one, two);
            }
            if (operation == '/')
            {
                SimpleDivide(one, two);
            }
            else
            {
                Console.WriteLine("Invalid entry");
            }
        }
        static void SimpleAdd(double one, double two)
        {
            double result = one + two;
            Console.WriteLine(result);
        }
        static void SimpleSubtract(double one, double two)
        {
            double result = one - two;
            Console.WriteLine(result);
        }
        static void SimpleMultiply(double one, double two)
        {
            double result = one * two;
            Console.WriteLine(result);
        }
        static void SimpleDivide(double one, double two)
        {
            double result = one / two;
            Console.WriteLine(result);
        }
    }
}
