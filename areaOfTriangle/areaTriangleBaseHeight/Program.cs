using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace areaOfTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CalculateAreaofTriangleBaseHeight(4, 5));
            Console.WriteLine(CalculateAreaofTriangleSideAngleSide(21.2, 31.6, 37));            
        }
        static double CalculateAreaofTriangleBaseHeight (double bottom, double height)
        {
            return (bottom* height)/2; 
        }
        static double CalculateAreaofTriangleSideAngleSide(double sideA, double sideB, double angle)
        {
            double answer = (sideA * sideB * (Math.Sin(angle * Math.PI / 180))) / 2;
            return answer;
        }
    }
}
