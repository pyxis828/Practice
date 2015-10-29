using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace longestWord
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "some line with text";      //find the longest word in a sentence. 
            int index = line.IndexOf(" ");              //If the sentence has more than one word
            StringBuilder wordLength = new StringBuilder();  //of the same length you should 
            while (index != -1)                         //pick the first one.
            {
                wordLength.Append(index + " ");
                index = line.IndexOf(" ", index + 1);
            }
            Console.WriteLine(wordLength.ToString());
            
            
        }
    }
}
