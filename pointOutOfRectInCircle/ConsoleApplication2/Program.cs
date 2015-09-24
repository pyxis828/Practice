using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Designate a value for x:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Designate a value for y:");
            int y = int.Parse(Console.ReadLine());
            int r = 5;
            if((x>=-1 && x<=5) && (y>=1 && y <= 5))
            {
                Console.WriteLine("The point is in the rectangle.");
            }
            else if ((x*x + y*y) <= r*r)
            {
                Console.WriteLine("The point IS inside the circle and outside the rectangle.");
            }
            else
            {
                Console.WriteLine("The point is outside both the circle and the rectangle.");
            }
        }
    }
}
