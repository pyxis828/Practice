using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueuePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> firstQ = new Queue<string>();
            firstQ.Enqueue("first element");
            firstQ.Enqueue("second element");
            firstQ.Enqueue("third element");
            foreach (string element in firstQ)
            {
                Console.WriteLine(element);
            }
            Queue<int> nums = new Queue<int>();
            nums.Enqueue(1);
            nums.Enqueue(2);
            nums.Enqueue(3);
            nums.Enqueue(4);
            nums.Enqueue(5);
            nums.Dequeue();
            foreach(int num in nums)
            {
                Console.WriteLine(num);
            }
            nums.Clear();
            foreach (int num in nums)
            {
                Console.WriteLine(num);
            }
            nums.Enqueue(6);
            nums.Enqueue(7);
            nums.Enqueue(8);
            nums.Enqueue(9);
            Console.WriteLine(nums.Contains(6));
            Console.WriteLine(nums.Contains(3));
        }
    }
}
