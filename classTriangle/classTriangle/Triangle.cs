using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classTriangle
{
    class Triangle
    {
        private double sideOne = 0;
        private double sideTwo = 0;
        private double angle = 0;
        private double height = 0;
        private double bottom = 0;
        public Triangle(double sideOne, double sideTwo, double angle)
        {
            this.sideOne = sideOne;
            this.sideTwo = sideTwo;
            this.angle = angle;
        }
        public Triangle (double height, double bottom)
        {
            this.height = height;
            this.bottom = bottom;
        }
        public double GetArea()
        {
            return (this.bottom * this.height) / 2;
        }
        public double GetAreaTwoSides()
        {
            return (this.sideOne * this.sideTwo * (Math.Sin(this.angle * Math.PI / 180))) / 2;           
        }
    }   
}
