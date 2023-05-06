using System;
//? method = performs a section of code; whenever it's called "invoked".
//?          benefit = Let's us reuse code w/p writing it multiple times.

/*
string name = "Ludwig";
int age = 25;

singHappyBirthday(name, age);

static void singHappyBirthday(string name, int age)
{
    Console.WriteLine("Happy birthday to you!");
    Console.WriteLine("Happy birthday to you!");
    Console.WriteLine("Happy birthday dear " + name + "!");
    Console.WriteLine("You are " + age + " years old!");
    Console.WriteLine("Happy birthday to you!");
    Console.WriteLine();
}
*/


//? return = returns data back to the place where a mthod is invoked

/*
double x;
double y;
double result;

Console.WriteLine("Enter in number 1: ");
x = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter in number 2: ");
y = Convert.ToDouble(Console.ReadLine());

result = multiply(x, y);

Console.WriteLine(result);

static double multiply(double x, double y)
{
    double z = x * y;
    return z;
}
*/

//? method overloading = methods share name but different parameters
//?                      name + parameters = signature 
//?                      methods must have a unique signature 

/*
class Program
{
    static void Main(string[] args)
    {
        int a = 5;
        int b = 8;
        double c = 3.14;
        double d = 2.71;

        int result1 = multiply(a, b);
        double result2 = multiply(c, d);

        Console.WriteLine(result1);
        Console.WriteLine(result2);
    }

    static int multiply(int x, int y)
    {
        int z = x * y;
        return z;
    }

    static double multiply(double x, double y)
    {
        return x * y;
    }
}
*/

//? params keyword = a method parameter that takes a variable of argumetns.
//?                  The parameter type must be a single - dimensional array

class Program
{
    static void Main(string[] args)
    {
        double total = checkout(3.99, 5.75, 15, 1.00, 10.25);

        Console.WriteLine(total);
    }

    static double checkout(params double[] prices)
    {
        double total = 0;

        foreach (double price in prices)
        {
            total += price; //? equivale a total = total + price; 
        }

        return total;
    }
}