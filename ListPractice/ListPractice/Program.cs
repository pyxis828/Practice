using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ListPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int>() { 1,4,6,9,2,3,5};
            List<int> years = new List<int>() {1978, 1982, 1974, 1985, 1980, 1987, 1977, 1979, 1983, 1988};
            foreach (int year in years)
            {
                Console.WriteLine(year);
            }
            List<int> ages = new List<int>();
            ages.Add(33);
            ages.Add(35);
            ages.Add(38);
            ages.Add(23);
            ages.Add(20);
            ages.Add(40);
            ages.Add(32);
            ages.Add(28);
            ages.Add(30);
            ages.Add(37);
            ages.Remove(23);
            ages.Sort();
            ages.Add(20);
            ages.Sort();         
            foreach (int age in ages)
            {
                Console.WriteLine(age);
            }
            Console.WriteLine(ages.Count);
            List<string> names = new List<string>() {"Kirstin", "Sean", "Amy", "Rae", "Bishop", "Guyver" };
            names.Add("Alicia");
            names.Add("Tori");
            names.Add("Marilee");
            names.Add("Stephanie");
            names.Add("Raquel");
            StreamWriter write = new StreamWriter("names.txt");
            using (write)
            {
                foreach (string name in names)
                {
                   write.WriteLine(name);
                }                
            }
            List<int> numbers = new List<int>() { 3, 7, 5, 4, 7, 8, };
            Console.WriteLine(numbers.Count);
            numbers.Clear();
            Console.WriteLine(numbers.Count);
            string[] words = { "Hello", "write", "some", "stuff", "in", "here" };
            //List<string> sentence = new List<string>(words);
            List<string> sentence = words.ToList();
            Console.WriteLine(sentence.Count());
        }
    }
}
