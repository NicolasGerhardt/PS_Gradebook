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
            } else {
                output = args[0];
            }

            Console.WriteLine($"Hello, {output}!");
        }
    }
}
