using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace EmailValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "good123@bad.com";
            bool email;
            Match result = Regex.Match(line, @"\w+[@]\w+[\.][a-z][a-z][a-z]");
            if (result.Success)
            {
                email = true;
            }
            else
            {
                email = false;
            }
            Console.WriteLine(email);
        }
    }
}
