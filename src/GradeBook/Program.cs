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

            var high = book.findHighestGrade();
            var low = book.findLowestGrade();
            var ave = book.calcAverageGrade();

            Console.WriteLine($"The highest grade is {high:N2}.");
            Console.WriteLine($"The lowest grade is {low:N2}.");
            Console.WriteLine($"The average grade is {ave:N2}.");
            
        }
    }


}
