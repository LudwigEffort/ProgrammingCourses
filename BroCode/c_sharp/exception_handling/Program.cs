using System.Linq.Expressions;
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

            try
            {
                int x;
                int y;
                //double result;

                Console.WriteLine("Enter number 1: ");
                x = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter number 2: ");
                y = Convert.ToInt32(Console.ReadLine());

                double result = x / y;

                Console.WriteLine("Resutl: " + result);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Enter ONLY numbers PLEASE!");
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("You can't divide by zero! IDIOT");
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong!");
            }
            finally
            {
                Console.WriteLine("Thanks for visiting!");
            }
        }
    }
}