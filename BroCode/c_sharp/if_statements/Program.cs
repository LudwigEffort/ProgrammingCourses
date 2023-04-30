//? if statement = a basic form of decision making

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Please enter your age:");
        int age = Convert.ToInt32(Console.ReadLine());

        if (age >= 18)
        {
            Console.WriteLine("You're now signed up!");
        }
        else if (age > 100)
        {
            Console.WriteLine("You are too old to sign up!");
        }
        else if (age <= 0)
        {
            Console.WriteLine("You haven't been born yet!");
        }
        else
        {
            Console.WriteLine("You must be 18+ to sing up!");
        }

        Console.ReadKey();
    }
}