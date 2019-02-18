using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public class GradeBook : GradeTracker
    {
        public GradeBook()
        {
            _name = "Empty";
            grades = new List<float>();
        }

         public override void writeGrades(TextWriter destination)
        {
            for (int i = 0; i < grades.Count; i++)
            {
                destination.WriteLine(grades[i]);
            }
        }

        public override void AddGrade(float grade)
        {
            grades.Add(grade);
        }

       
        public override GradeStatistics ComputeStatistics()
        {
            Console.WriteLine("Base called");
            GradeStatistics stats =  new GradeStatistics();
            float sum = 0;
            foreach(float grade in grades)
            {
                Console.WriteLine(grade);
                sum += grade;
            }
            stats.AverageGrade = sum / grades.Count;
            stats.LowestGrade = grades.Min();
            stats.HighestGrade = grades.Max();
            return stats;
        }

    }
}
