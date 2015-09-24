using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SringPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //print the string "The "use" of quotations causes difficulties." (without outer quotes)
            string withoutQuotes = "The use of quotations causes difficulties.";   //string without quotes
            string withQoutes = "The \"use\" of quotations causes difficulties.";   //string with quotes
            Console.WriteLine(withoutQuotes);  //print both results
            Console.WriteLine(withQoutes);
        }
    }
}
