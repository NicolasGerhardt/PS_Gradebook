using System.Collections.Generic;

namespace GradeBook
{
    class GradeBook
    {
        private List<double> grades;
        private string name;

        public GradeBook(string name)
        {
            grades = new List<double>();
            this.name = name;
        }

        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        public double getAverageGrades()
        {
            return 0.0;
        }

    }
}
