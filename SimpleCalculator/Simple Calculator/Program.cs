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
            Console.WriteLine("Enter the first number");                //a simple calculator which will perform basic
            double one = double.Parse(Console.ReadLine());              //operation +, -, *, / on two numbers
            Console.WriteLine("Enter the second number");
            double two = double.Parse(Console.ReadLine());                              //request 2 numbers and operation to 
            Console.WriteLine("What operation do you want to perform(+, - , * , /)?");  //perform from user
            char operation = char.Parse(Console.ReadLine());
            if (operation == '+')
            {                                                       //determine which operation was chosen, pass the numbers
                SimpleAdd(one, two);                                //to the appropriate method
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
        static void SimpleAdd(double one, double two)                       //add method
        {
            double result = one + two;
            Console.WriteLine(result);
        }
        static void SimpleSubtract(double one, double two)                  //subtract method
        {
            double result = one - two;
            Console.WriteLine(result);
        }
        static void SimpleMultiply(double one, double two)                  //multiply method
        {
            double result = one * two;
            Console.WriteLine(result);
        }
        static void SimpleDivide(double one, double two)                    //divide method
        {
            double result = one / two;
            Console.WriteLine(result);
        }
    }
}
