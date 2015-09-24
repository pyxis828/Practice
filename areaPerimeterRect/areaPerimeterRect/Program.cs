using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace areaPerimeterRect
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the length?");
            int length = int.Parse(Console.ReadLine());
            Console.WriteLine("What is the height?");
            int height = int.Parse(Console.ReadLine());
            int area = length * height;
            int perimeter = (length * 2) + (height * 2);
            Console.WriteLine("The perimeter of the rectangle is " + perimeter + " and the area is " + area); 

        }
    }
}
