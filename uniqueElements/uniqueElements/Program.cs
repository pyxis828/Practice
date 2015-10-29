using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uniqueElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "1,1,1,2,2,3,3,4,4";    //You are given a sorted list of numbers with duplicates.
            string[] numList = line.Split(',');    //input sample list of sorted integers, comma delimited,
            int highestNum = int.Parse(numList[numList.Length - 1]);      //one per line. E.g. 1,1,1,2,2,3,3,4,4       
            int[] intList = new int[numList.Length];
            intList = IntArrayConvert(numList);    
            StringBuilder result = new StringBuilder();
            foreach (int num in intList)         //check against each element of string
            {
                for (int i =1; i < intList.Length; i++)
                {
                    if (num == intList[i])
                    {
                        intList.Remove(i, 1);
                    }
                }
                
            }
            Console.WriteLine(result);
        }
        static int[] IntArrayConvert (params string[] numList)
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