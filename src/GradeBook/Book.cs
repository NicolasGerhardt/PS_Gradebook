using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
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

        public void ShowStatistics()
        {
            var high = this.findHighestGrade();
            var low = this.findLowestGrade();
            var ave = this.calcAverageGrade();

            Console.WriteLine($"The highest grade is {high:N2}.");
            Console.WriteLine($"The lowest grade is {low:N2}.");
            Console.WriteLine($"The average grade is {ave:N2}.");
        }

        private double calcAverageGrade()
        {
            var TotalOfGrades = 0.0;

            foreach (var grade in grades)
            {
                TotalOfGrades += grade;
            }

            return TotalOfGrades / grades.Count;
        }

        private double  findHighestGrade()
        {
            var highGrade = double.MinValue;
            foreach (var grade in grades)
            {
                highGrade = Math.Max(grade, highGrade);
            } 


            return highGrade;
        }

        private double  findLowestGrade()
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
