using System;

namespace ConsoleApp
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select once snack!");
            string snack = Console.ReadLine();

            switch (snack)
            {
                case "1":
                    Console.WriteLine("Snack 1");
                    Snack1();
                    break;
                case "2":
                    Console.WriteLine("Snack 2");
                    Snack2();
                    break;
                case "3":
                    Console.WriteLine("Snack 3");
                    break;
                case "4":
                    Console.WriteLine("Snack 4");
                    break;
                case "5":
                    Console.WriteLine("Snack 5");
                    break;
                case "6":
                    Console.WriteLine("Snack 6");
                    break;
                case "7":
                    Console.WriteLine("Snack 7");
                    break;
                case "8":
                    Console.WriteLine("Snack 8");
                    break;
                case "9":
                    Console.WriteLine("Snack 9");
                    break;
                case "10":
                    Console.WriteLine("Snack 10");
                    break;
                case "11":
                    Console.WriteLine("Snack 11");
                    break;
                case "12":
                    Console.WriteLine("Snack 12");
                    break;

                default:
                    Console.WriteLine(snack + " is not a valid snack!");
                    break;
            }

            static void Snack1()
            {
                Console.WriteLine("Choose two numbers!");
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());
                if (a > b)
                {
                    Console.WriteLine(a + " is max");
                }
                else if (a == b)
                {
                    Console.WriteLine(a + " is equals " + b);
                }
                else
                {
                    Console.WriteLine(b + " is max");
                }
            }

            static void Snack2()
            {
                Console.WriteLine("Choose two word!");
                string word1 = Console.ReadLine().ToLower();
                string word2 = Console.ReadLine().ToLower();
                if (word1.Length > word2.Length)
                {
                    Console.WriteLine(word1 + " is longer than " + word2);
                }
                else if (word1.Length == word2.Length)
                {
                    Console.WriteLine(word1 + " is equals " + word2);
                }
                else
                {
                    Console.WriteLine(word2 + " is longer than " + word1);
                }
            }
        }
    }
}