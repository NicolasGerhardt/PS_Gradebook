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

            var numbers = new double[3];
            numbers[0] = 456.4;
            numbers[1] = 398.33;
            numbers[2] = 654.9;

            result = numbers[0] + numbers[1] + numbers[2];

            System.Console.WriteLine($"The sum of 3 numbers = {result}");
            

        }
    }
}
