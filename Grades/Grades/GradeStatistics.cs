using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public class GradeStatistics
    {

        public GradeStatistics()
        {
            LowestGrade = float.MaxValue;
            HighestGrade = 0;
        }

        public string LetterGrade
        {
            get
            {
                string result;
                switch (AverageGrade)
                {
                    case float grade when grade >= 90:
                        result = "A";
                        break;
                    case float grade when grade >= 80:
                        result = "B";
                        break;
                    case float grade when grade >= 70:
                        result = "C";
                        break;
                    case float grade when grade >= 60:
                        result = "D";
                        break;
                    default:
                        result = "F";
                        break;
                }
                return result;
            }
        }

        public float AverageGrade;
        public float HighestGrade;
        public float LowestGrade;   
    }
}
