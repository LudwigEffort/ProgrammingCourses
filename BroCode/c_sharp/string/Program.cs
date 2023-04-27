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