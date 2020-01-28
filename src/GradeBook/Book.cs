using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {
        private List<double> grades;
        public string Name;

        public Book(string name)
        {
            grades = new List<double>();
            Name = name;
        }

        public void AddGrade(double grade)
        {
            if (grade <= 100 && grade >= 0)
            {
                grades.Add(grade);    
            }
            else
            {
                System.Console.WriteLine("invalid value");
            }
        }

        public Statistics GetStatistics()
        {
            var result = new Statistics();
            result.High = this.findHighestGrade();
            result.Low = this.findLowestGrade();
            result.Average = this.calcAverageGrade();
            result.Letter = this.calcLetterGrade(result.Average);
            

            return result;
        }

        private char calcLetterGrade(double average)
        {
            switch (average)
            {
                case var x when x >= 90.0:
                    return 'A';
                case var x when x >= 80.0:
                    return 'B';
                case var x when x >= 70.0:
                    return 'C';
                case var x when x >= 60.0:
                    return 'D';
                default:
                    return 'F';
            }
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

        public void addLetterGrade(char letter)
        {
            switch (letter)
            {
                case 'A':
                    AddGrade(90);
                    break;

                case 'B':
                    AddGrade(80);
                    break;

                case 'C':
                    AddGrade(70);
                    break;

                case 'D':
                    AddGrade(60);
                    break;

                default:
                    AddGrade(0);
                    break;
            }
        }

    }
}
