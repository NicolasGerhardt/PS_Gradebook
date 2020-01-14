using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args )
        {
            var book = new Book("Nic's Gradebook");

            book.AddGrade(89.1);
            book.AddGrade(98.5);
            book.AddGrade(77.5);
            book.ShowStatistics();
            
        }
    }


}
