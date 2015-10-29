using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumofPrimes
{
    class Program                                 //Write a program which determines the sum of the first 1000 prime numbers.
    {
        static void Main(string[] args)
        {
            int sum = 2;                     //2 is the first prime number, but my first loop will not work for prime 2 
            int counter = 1;                 //set variable to count until we hit the 1000th prime; has  1 value in it already (2) 
            int num;
            bool prime = false;
            if (counter <= 1000)
            {
                for (num = 3; num < Int32.MaxValue; num++)
                    prime = primeNum(num);
                if (prime)
                {
                    sum += num;
                    counter++;
                }                
            }     
                Console.WriteLine(sum);           
        }
        static bool primeNum(int num)
        {
            bool prime = true;
            int divisor = 2;
            int maxDivide = (int)Math.Sqrt(num);
            while (prime && (divisor <= maxDivide))
            {
                if (num % divisor == 0)
                {
                    prime = false;
                }
                else
                {
                    divisor++;
                }
            }
            return prime;
            //print out the result                                              
        }
    }
}

    
 