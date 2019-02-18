using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public abstract class GradeTracker : IGradeTracker
    {
        protected List<float> grades;
        protected string _name;
        public event NameChangeDelegate NameChanged;

        public  string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name can't be empty or null");
                }
                if (_name != value)
                {
                    NameChangedEventArgs args = new NameChangedEventArgs();
                    args.OldName = _name;
                    args.NewName = value;

                    NameChanged(this, args);
                }

                _name = value;
            }

        }

        public abstract void AddGrade(float grade);
        public abstract GradeStatistics ComputeStatistics();
        public abstract void writeGrades(TextWriter destination);
    }
}
