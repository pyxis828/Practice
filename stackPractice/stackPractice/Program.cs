using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stackPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> names = new Stack<string>();
            names.Push("Kirstin");
            names.Push("Amy");
            names.Push("Sean");
            names.Push("Guyver");
            names.Push("Alicia");
            names.Pop();
            foreach(string name in names)
            {
                Console.WriteLine(name);
            }
            Stack<int> ages = new Stack<int>();
            ages.Push(35);
            ages.Push(24);
            ages.Push(30);
            ages.Push(26);
            ages.Push(40);
            Console.WriteLine(ages.Peek());
            Stack<int> years = new Stack<int>();
            years.Push(1978);
            years.Push(2001);
            years.Push(2015);
            years.Push(1980);
            years.Push(1995);
            Console.WriteLine(years.Count);
            Stack<string> sentence = new Stack<string>();
            sentence.Push("I");
            sentence.Push("am");
            sentence.Push("tired");
            sentence.Push("of");
            sentence.Push("making");
            sentence.Push("new");
            sentence.Push("stacks");
            sentence.Clear();
            Stack<string> another = new Stack<string>();
            another.Push("Only");
            another.Push("two");
            another.Push("more");
            another.Push("to");
            another.Push("go");
            Console.WriteLine(another.Contains("to"));
            Stack<string> final = new Stack<string>();
            final.Push("This");
            final.Push("is");
            final.Push("the");
            final.Push("last");
            final.Push("one");
            string[] words = new string[final.Count];
            words = final.ToArray();
            Array.Reverse(words);
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
