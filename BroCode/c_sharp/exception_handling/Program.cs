using System;

namespace MyFirstProgram
{
    class Program
    {
        public static void Main(string[] args)
        {
            //? exception = errors that occur during execution

            //? try = try some code that is considered "dangerous"
            //? catch = catches and handles exceptions when they occur
            //? finally = always executes regardless if exception is caught or not

            double x;
            double y;
            //double result;

            Console.WriteLine("Enter number 1: ");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter number 2: ");
            y = Convert.ToDouble(Console.ReadLine());

            double result = x / y;

            Console.WriteLine("Resutl: " + result);

        }
    }
}