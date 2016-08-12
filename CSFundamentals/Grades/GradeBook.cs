using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public class GradeBook
    {
        public GradeBook()
        {
            _name = "Empty";
            grades = new List<float>();
        }

        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                grades.Add(grade); 
            }
        }

        public GradeStatistics ComputeStatistics()
        {
            GradeStatistics stats = new GradeStatistics();
            float sum = 0f;

            foreach(float grade in grades)
            {
                stats.LowestGrade = Math.Min(grade, stats.LowestGrade);
                stats.HighestGrade = Math.Max(grade, stats.HighestGrade);
                sum += grade;
            }
            stats.AverageGrade = sum / grades.Count;
            
            return stats;
        }

        private List<float> grades;
        private string _name;

        public string Name
        {
            get { return _name; }

            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    if(_name != value)
                    {
                        NameChangedEventArgs args = new NameChangedEventArgs();
                        args.ExistingName = _name;
                        args.NewName = value;

                        NameChanged(this, args);
                    }
                    _name = value;
                }
            }
        }

        // This is the event of type NameChangedDelegate
        public event NameChangedDelegate NameChanged;

        
    }
}
