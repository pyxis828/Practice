using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forLoopstring_to_int_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nums = { "13", "25", "4", "6", "9", "66" };
            int length = nums.Length;
            int[] values = new int[length];
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(values[i] = int.Parse(nums[i]));
            }
        }
    }
}
