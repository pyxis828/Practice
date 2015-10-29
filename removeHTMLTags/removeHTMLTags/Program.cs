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
            int indexOpen = html.IndexOf("<");          //find first index of  open angle bracket
            int indexClose = html.IndexOf(">");         //find first index of close angle bracket
            int length = (indexClose + 1) - indexOpen;  //calculate length of string to be removed
            while ( indexOpen != -1 )                   //continue process as long as there is an opening bracket
            {
                html = html.Remove(indexOpen, length);      //remove string of indicated length starting from opening bracket        
                indexOpen = html.IndexOf("<");              //repeat
                indexClose = html.IndexOf(">");
                length = (indexClose + 1) - indexOpen;
            }
            Console.WriteLine(html);                        //print result
        }
    }
}
