using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumOfIntegers
{
    class Program
    {
        static void Main(string[] args)
        {                                           
            string line = "5";                      //Print out the sum of integers 
            string allNums= " ";                    //read from a file. The first argument 
            if (line != null)                       //to the program will be a path to 
            {                                       //a filename containing a positive              
                allNums += (line + " ");            //integer, one per line 
            }
            char[] splitters = new char[] { ' ' };
            string[] nums = allNums.Split(splitters);                   //removed code, thought maybe something
            //char[] splitters = new char[] { '\\', 'n', 'r', ' '};     //like this was needed at first but 
            //string[] nums = line.Split(splitters, StringSplitOptions.RemoveEmptyEntries);       changed it.
            int sum = 0;
            for (int i=0; i < nums.Length; i++)
            {
                int current = int.Parse(nums[i]);    //this is the area where the code eval
                sum += current;                      //rejects or hangs at.  I've tried
            }                                        //Convert.ToInt32 and Convert.ToDouble
            Console.WriteLine(sum);                  //(changed variable type). All throw
        }                                            //format exception.
    }
}
