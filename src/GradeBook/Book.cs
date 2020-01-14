using System.Collections.Generic;

namespace GradeBook
{
    class GradeBook
    {
        List<double> grades;

        public GradeBook()
        {
            grades = new List<double>();
        }

        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

    }
}
