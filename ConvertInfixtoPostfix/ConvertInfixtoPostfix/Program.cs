using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ConvertInfixtoPostfix
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "(4+3)*-1/2";
        }
        static bool CheckForNumber(char check)      //method to check for a number
        {
            string line = check.ToString();
            bool num = Regex.IsMatch(line, "\\d");
            return num;
        }
    }
}
