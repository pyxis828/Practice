using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1              // Each row is divided into 2 parts by pipe char (|).
{                                          // The first part has a writer's name.
    class Program                           // The second part is a "key" to generate a name.
    {                                       //Print results in the following way:
        static void Main(string[] args)     //Stephen King 1947
        {
            NumberFor
            string line = "osSE5Gu0Vi8WRq93UvkYZCjaOKeNJfTyH6tzDQbxFm4M1ndXIPh27wBA rLclpg|" +
                            " 3 35 27 62 51 27 46 57 26 10 46 63 57 45 15 43 53";
            string[] split = line.Split('|');   //divide the line into 2 arrays at the character of "|"
            string code = split[0];             //first string where name and date are to be found named code
            string key = split[1];             //2nd string with decryption key named key; 
            string[] nums = key.Split(' ');     //split key into an array called nums
            int length = nums.Length;           //determine length of nums array
            int[] decoders = new int[length];   //create empty int array of same length as nums array
          //for (int i = 0; i < length; i++)
         // {
            // decoders[i] = int.Parse(nums[i]);     //this for loop with either of
            // decoders[i] = Convert.ToInt32(nums[i]);   //the center lines in 
         // }                                        //the body fails.
            foreach (string num in nums)
            {
                for (int i = 0; i < length; i++)        //this fails too.  
                {
                   // decoders[i] = int.Parse(num);
                    decoders[i] = Convert.ToInt32(num);
                }
            }
            StringBuilder author = new StringBuilder();
           
        }                                    
    }                                   
}
