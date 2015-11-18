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
            string filename = "..\\..\\text.txt";                                   //practice with exceptions.  These are IO 
            try                                                                     //exceptions.  Move from more specific to 
            {                                                                       //less specific.
                StreamReader reader = new StreamReader(filename);
                Console.WriteLine("File " + filename + " successfully opened");     
                Console.WriteLine("File contents:");
                using (reader)                                                      //this is the code block that could throw an 
                {                                                                   //an exception.  It gets wrapped in a try block
                    Console.WriteLine(reader.ReadLine());                           
                    
                }
            }
            catch (FileNotFoundException)                                           //the catch blocks catch possible exceptions that     
            {                                                                       //could be thrown and should return a   
                Console.WriteLine("Cannot find file " + filename);                  //helpful message to the user.
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
