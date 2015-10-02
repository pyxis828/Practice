using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moreStackPractice         //write a program that reads from the console any number of integers (N)  
{                                   //and prints them in reverse order
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter some numbers seperated by a space");   //ask user to input numbers
            string line = Console.ReadLine();                               //read and store user input
            string[] nums = line.Split(' ');                                //split input along spaces and store in an array
            Stack<string> numList = new Stack<string>();                    //create new stack
            foreach (string num in nums)                          //loop through array and push each element to the stack
            {
                numList.Push(num);
            }
            foreach (string num in numList)                      //loop through the stack and print out each number
            {
                Console.Write(num + " ");
            }
        }
    }
}
