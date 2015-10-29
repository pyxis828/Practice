using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> studentScores = new Dictionary<string, int>();
            studentScores.Add("StudentA", 89);
            studentScores.Add("StudentB", 75);
            studentScores.Add("StudentC", 94);
            studentScores.Add("StudentD", 98);
            // Console.WriteLine(studentScores["StudentC"]);
            // foreach(KeyValuePair<string, int> student in studentScores)
            // {
            //     Console.WriteLine(student);
            // }
            Dictionary<int, string> coats = new Dictionary<int, string>();
            coats.Add(1, "blazer");
            coats.Add(2, "fur");
            coats.Add(3, "tux");
            coats.Add(4, "shrug");
            coats.Add(5, "stole");
            coats.Add(6, "peacoat");
            coats.Add(7, "raincoat");
            coats.Add(8, "trenchcoat");
            coats.Add(9, "jacket");
            coats.Add(10, "leather");
            //  foreach (KeyValuePair<int, string> coat in coats)
            //  {
            //     Console.WriteLine(coat);
            //  }
            Dictionary<string, string> cars = new Dictionary<string, string>();
            cars.Add("Smith", "Ford");
            cars.Add("Jones", "Lincoln");
            cars.Add("Walsh", "Mercury");
            cars.Add("Adams", "Toyota");
            cars.Add("Tobin", "Honda");
            cars.Add("Jordan", "Lexus");
            cars.Add("Lee", "Mazda");
            cars.Add("Chin", "Hyundai");
            cars.Add("Wong", "Chevrolet");
            cars.Add("Patel", "Tesla");
            // foreach(KeyValuePair<string, string> car in cars)
            //{
            //    Console.WriteLine(car);
            //}
        }
    }
}
