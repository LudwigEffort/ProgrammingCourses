//? if statement = a basic form of decision making

/*
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
*/

/*
Console.WriteLine("Please enter your name:");
string name = Console.ReadLine();

if (name != "")
{
    Console.WriteLine("You didn't enter your name!");
}
else
{
    Console.WriteLine("Hello " + name);
}
*/

//? switch = an efficient alternative to many else if statements

Console.WriteLine("What day is it today?");
string day = Console.ReadLine();

switch (day)
{
    case "Monday":
        Console.WriteLine("It's Monday!");
        break;
    case "Tuesday":
        Console.WriteLine("It's Tuesday!");
        break;
    case "Wednesday":
        Console.WriteLine("It's Wednesday!");
        break;
    case "Thursday":
        Console.WriteLine("It's Thursday!");
        break;
    case "Friday":
        Console.WriteLine("It's Friday!");
        break;
    case "Saturday":
        Console.WriteLine("It's Saturday!");
        break;
    case "Sunday":
        Console.WriteLine("It's Sunday!");
        break;
    default:
        Console.WriteLine(day + " is not a day!");
        break;
}

Console.ReadKey();
