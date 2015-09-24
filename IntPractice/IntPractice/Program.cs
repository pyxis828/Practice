using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int x = a = 5;  //declare two variables of type int
            int y = b = 10; //assign to them values 5 and 10 respectively
            x = b; y = a;   //Exchange (swap) their values 
            Console.WriteLine("x = " + x);  //print them
            Console.WriteLine("y = " + y);            
        }
    }
}
