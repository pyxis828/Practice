using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQpractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 8, 2, 4, 10, 2, 99, 77, 6, 3 };
            IEnumerable<int> results = from n in nums where n > 6 select n;
            foreach (int result in results)
            {
                Console.WriteLine(result);
            }
            string[] names = { "Kirstin", "Sean", "Amy", "Raquel", "Rae", "Katie", "Guyver", "Stephanie", "Bishop" };
            var newResults  = from n in nums join name in names on n equals name.Length select name;
            foreach (var result in newResults)
            {
                Console.WriteLine(result);
            }
            var nameGroup = from name in newResults group name by name.Length;
            foreach (var group in nameGroup)
            {
                Console.WriteLine(group.Key);
                foreach (var name in group)
                {
                    Console.WriteLine("{0}'s name has {1} letters.", name, group.Key);
                }
            }
        }
    }
}
