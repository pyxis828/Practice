using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace areaOfATrapezoid
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter length of Base one");
            int base1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter length of Base two");
            int base2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Height");
            int height = int.Parse(Console.ReadLine());
            int area = ((base1 + base1) / 2) * height;
            Console.WriteLine("The area of the trapezoid is " + area);

        }
    }
}
