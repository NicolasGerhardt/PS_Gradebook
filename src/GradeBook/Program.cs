using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args )
        {
            var book = new Book("Nic's Gradebook");

            book.getUserInput();


            var stats = book.GetStatistics();

            Console.WriteLine($"The highest grade is {stats.High:N2}.");
            Console.WriteLine($"The lowest grade is {stats.Low:N2}.");
            Console.WriteLine($"The average grade is {stats.Average:N2}.");
            Console.WriteLine($"The Letter grade is {stats.Letter}.");
            
        }
    }


}
