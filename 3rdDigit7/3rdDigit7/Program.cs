using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3rdDigit7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());
            num /= 100;
            if (num % 10 == 7)
            {
                Console.WriteLine("True");
            }
            
        }
    }
}
