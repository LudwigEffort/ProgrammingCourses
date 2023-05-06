/*
string fullName = "Bro code";
string phoneNumber = "123-456-789";

//fullName = fullName.ToUpper();
//fullName = fullName.ToLower();

phoneNumber = phoneNumber.Replace("-", "");

string userName = fullName.Insert(0, "Dr. ");

string firstName = fullName.Substring(0, 3);
string lastName = fullName.Substring(4, 4);

Console.WriteLine(phoneNumber);
Console.WriteLine(userName);
Console.WriteLine(fullName.Length);
Console.WriteLine(firstName);
Console.WriteLine(lastName);
*/

//? string interpolation = allows us to insert variables into a string litteral
//?                        precede a string literal with $
//?                        {} are placeholders

string firstName = "Ludwig";
string lastName = "Effort";
int age = 25;

/*
Console.WriteLine("Hello " + firstName + "" + lastName + "."); //? classic way
Console.WriteLine("You are " + age + " years old.");
*/

Console.WriteLine($"Hello {firstName} {lastName}");
Console.WriteLine($"You are {age} years old.");