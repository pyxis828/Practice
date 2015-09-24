using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace removeHTMLTags
{
    class Program
    {
        static void Main(string[] args)
        {
            string html = "<p>This is remaining <a href=\"#\">text</a>. I'd like to keep it.</p> ";
            string final = "";
            int totalLength = html.Length;
            int indexOpen = html.IndexOf("<");
            int indexClose = html.IndexOf(">");
            int length = (indexClose + 1) - indexOpen;
            while ( indexOpen != -1)
            {              
                final = html.Remove(indexOpen, length);
                indexOpen = html.IndexOf("<", indexOpen + 1);
                indexClose = html.IndexOf(">", indexClose + 1);
            }
            Console.WriteLine(final);
        }
    }
}
