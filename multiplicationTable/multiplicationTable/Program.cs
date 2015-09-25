using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
          
            int rows = 5;
            int col = 5;
            for(int i = 1; i <= rows; i++ )
            {
                for(int n = 1; n <= col; n++)
                {
                    Console.Write((n* i) + " ");
                  
                }
                Console.WriteLine();
            
            }
        }
    }
}
