using System;

namespace list_of_objects
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Player> players = new List<Player>();

            Player player1 = new Player("Chad");
            Player player2 = new Player("Steve");
            Player player3 = new Player("Karen");

            players.Add(player1);
            players.Add(player2);
            players.Add(player3);

            foreach (Player player in players)
            {
                Console.WriteLine(player);
            }

            Console.WriteLine("--------------------");

            foreach (Player player in players)
            {
                Console.WriteLine(player.username);
            }

            Console.ReadKey();
        }
    }

    class Player
    {
        public string username;
        public Player(string username)
        {
            this.username = username;
        }
        public override string ToString()
        {
            return "The username is: " + username;
        }
    }
}