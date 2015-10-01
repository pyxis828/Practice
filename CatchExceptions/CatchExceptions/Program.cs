using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CatchExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = "..\\..\\text.txt";
            try
            {
                StreamReader reader = new StreamReader(filename);
                Console.WriteLine("File " + filename + " successfully opened");
                Console.WriteLine("File contents:");
                using (reader)
                {
                    Console.WriteLine(reader.ReadLine());
                    
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Cannot find file " + filename);
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("Cannot find directory in the file path");
            }
            catch (IOException)
            {
                Console.WriteLine("Cannot open the file " + filename);
            }
        }
    }
}
