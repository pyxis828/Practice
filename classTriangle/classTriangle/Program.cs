using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle(2,4,90);
            Console.WriteLine(triangle.GetAreaTwoSides());
            //instantiate a triangle
            //get area of triangle with a method
        }
    }
    //create class triangle
    //create method to get area of triangle
}   
