using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarytoDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            string binary = "1010";
            int num = Convert.ToInt32(binary, 2);
            Console.WriteLine(num);
        }              
    }
}
