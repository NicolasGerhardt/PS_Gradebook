using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args )
        {
            string output;
            if (args.Length == 0)
            {
                output = "Nobody";
            }
            else
            {
                output = args[0];
            }

            Console.WriteLine($"Hello, {output}!");

            double x = 42.1;
            double y = 10.3;
            var result = x + y;

            Console.WriteLine($"x + y = {result}");

            var numbers = new[] {56.4, 98.33, 24.9};
            result = 0.0;

            foreach (var number in numbers)
            {
                result += number;
            }

            System.Console.WriteLine($"The sum of {numbers.Length} numbers = {result}");
            


        }
    }
}
