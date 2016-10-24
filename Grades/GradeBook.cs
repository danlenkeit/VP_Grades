using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class GradeBook
    {

        private List<float> grades = new List<float>(); //List to hold grades

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
    }
}
