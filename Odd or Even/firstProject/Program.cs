using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace printOddOrEven
{
    class Program
    {
        static void Main(string[] args)
        {
          Console.WriteLine("Type in a number");
          int x = Convert.ToInt32(Console.ReadLine());
          if (x%2 == 1)
            {
                Console.WriteLine("Odd");
            } else {
                Console.WriteLine("Even");
            };
        }
    }
}
