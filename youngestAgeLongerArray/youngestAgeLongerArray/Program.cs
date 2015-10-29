using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace youngestAgeLongerArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ages = { 22, 28, 20, 35, 27, 19, 33, 37, 31 };
            bool youngest;
            
            for (int i = 0; i < ages.Length; i++)
            {
                int young = ages[i];
                for (int i2 = 1; i2 < ages.Length; i2++)
                {
                    int compare = ages[i2];
                    if (young > compare)
                    {
                        youngest = false;
                        continue;
                    }
                    else if (young <= compare)
                    {
                        Console.WriteLine(young);
                    }
                }
            }
            int finalLow = int.Parse(Console.ReadLine());
            Console.WriteLine("The youngest age is :" + finalLow);
        }
    }
}
