using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manipulate4DigitNum
{ 
    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Enter a four digit number");
        string num = Console.ReadLine();
        int a = Convert.ToInt32(num[0]);
        char b = num[1];
        char c = num[2];
        char d = num[3];
        Console.WriteLine("The sum of the digits is: " + (a + b + c + d));
        }
    }
}
