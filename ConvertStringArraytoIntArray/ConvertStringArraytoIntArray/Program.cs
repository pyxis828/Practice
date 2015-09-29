using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertStringArraytoIntArray
{
    class Program
    {
        static void Main(string[] args)
        {

        }
        static int[] IntArrayConvert(params string[] numList)
        {
            int[] intList = new int[numList.Length];
            foreach (string num in numList)
            {
                for (int i = 0; i < intList.Length; i++)
                {
                    intList[i] = int.Parse(num);
                }

            }
            return intList;
        }
    }
}
