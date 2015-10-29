using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace StreamReaderPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("..\\..\\Sample.txt");
            using (reader)
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    Console.WriteLine(line);
                    line = reader.ReadLine();
                }
            }
            StreamWriter writer = new StreamWriter("anotherFile.txt");
            using (writer)
            {
                string words = "Write out some text";
                writer.WriteLine(words);
            }            
        }
    }
}
