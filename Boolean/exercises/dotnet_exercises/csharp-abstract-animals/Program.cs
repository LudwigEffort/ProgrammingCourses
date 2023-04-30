using csharp_abstract_animals;

var ghost = new Dog("Ghost");

Console.WriteLine(ghost.GetName() +":");
ghost.Sleep();
ghost.AnimalCall();
ghost.Eat();
Console.WriteLine();

var flipper = new Dolphin("flipper");

Console.WriteLine(flipper.GetName() +":");
flipper.Sleep();
flipper.AnimalCall();
flipper.Eat();
flipper.Swim();
Console.WriteLine();

var tweety = new Bird("Tweety");

Console.WriteLine(tweety.GetName() +":");
tweety.Sleep();
tweety.AnimalCall();
tweety.Eat();
tweety.Fly();
Console.WriteLine();

var serse = new Eagle("Serse");

Console.WriteLine(serse.GetName() +":");
serse.Sleep();
serse.AnimalCall();
serse.Eat();
serse.Fly();
Console.WriteLine();

var gigi = new Puffin("Gigi");

Console.WriteLine(gigi.GetName() +":");
gigi.Sleep();
gigi.AnimalCall();
gigi.Eat();
gigi.Fly();
gigi.Swim();
Console.WriteLine();