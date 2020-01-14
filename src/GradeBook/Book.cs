using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Book
    {
        private List<double> grades;
        private string name;

        public Book(string name)
        {
            grades = new List<double>();
            this.name = name;
        }

        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        public double calcAverageGrade()
        {
            var TotalOfGrades = 0.0;

            foreach (var grade in grades)
            {
                TotalOfGrades += grade;
            }

            return TotalOfGrades / grades.Count;
        }

        public double  findHighestGrade()
        {
            var highGrade = double.MinValue;
            foreach (var grade in grades)
            {
                highGrade = Math.Max(grade, highGrade);
            } 


            return highGrade;
        }

        public double  findLowestGrade()
        {
            var lowGrade = double.MaxValue;
            foreach (var grade in grades)
            {
                lowGrade = Math.Min(grade, lowGrade);
            } 


            return lowGrade;
        }

    }
}
