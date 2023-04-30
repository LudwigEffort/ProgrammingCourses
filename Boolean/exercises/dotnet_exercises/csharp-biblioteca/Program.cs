using csharp_biblioteca;

var db_user = new List<User>
{
    new User("Werner", "Heisenberg", "wernerheisenberg@gmail.com", "password", "555222321"),
    new User("Albert", "Einstein", "alberteinstein@gmail.com", "password", "5559912333")
};

var db_item = new List<Item>
{
    new Book("1234512345", "The lord of rings", "1955", "fantasy", "5B", "J. R. R. Tolkien", 1000),
    new Book("5432154321", "A dance with Dragons", "2011", "fantasy", "5B", "G. R. R. Martin", 1000),
    new DVD("1234554321", "From Dusk Till Down", "1997", "horror", "8G", "Robert Rodriguez", 108),
    new Item("5432101234", "Quantum Computing: Principles and Applications", "2020", "quantum physics", "12A", "Yoshito Kanamori & Seong-Moo Yoo"),
};

Console.WriteLine("Municipal Library");

while(true){
    Console.WriteLine("read | search | put");

    var instruction = Console.ReadLine();

    switch (instruction) {
        case "read":
            foreach (var item in db_item)
            {
               Console.WriteLine(item);
            }
            break;
        case "search":
            break;
        case "put":
            break;
        default:
            break;
    }
}