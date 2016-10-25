using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Grades
{
    public class GradeBook
    {
        List<float> grades = new List<float>();
        private string _name;

        public GradeBook()
        {
            grades = new List<float>();
        }

        //Add grade to grade list
        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }

        public GradeStatistics ComputeStatistics()
        {
            GradeStatistics stats = new GradeStatistics();
            stats.HighestGrade = 0;

            //determine average grade
            float sum = 0;
            foreach (float grade in grades)
            {
                stats.HighestGrade = Math.Max(grade, stats.HighestGrade);
                stats.LowestGrade = Math.Min(grade, stats.LowestGrade);
                sum += grade;
            }

            stats.AverageGrade = sum / grades.Count;

            return stats;
        }

        public void WriteGrades(TextWriter writer)
        {
            foreach (float g in grades)
            {
                writer.WriteLine(g);
            }
        }

        /*public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be null or empty");
                }

                if (_name != value)
                {

                }

                _name = value;
            }
        }*/
    }
}
