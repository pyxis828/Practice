using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace usingClassesPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomNumber = new Random();
            for(int i = 1; i <=10; i++)
            {
                int number = randomNumber.Next(100, 201);
                Console.WriteLine(number);
            }
            Console.WriteLine(DateTime.Today.DayOfWeek);
        }
    }
}
