using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.CompilerServices;
using System.Linq;

namespace Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Player> players = new List<Player>
            {
                new Player("John", 100),
                new Player("Bill", 150),
                new Player("Kalem", 110),
                new Player("Abacaber", 50)
            };

            List<Player> players2 = new List<Player>
            {
                new Player("John2", 250),
                new Player("Bill2", 120),
            };

            var filteredPlayers = from Player player in players where player.Level > 100 select player;
            foreach (var player in filteredPlayers)
            {
                Console.WriteLine(player.Login);
            }
            Console.WriteLine("\n");
            var filteredPlayers2 = players.Where(player => player.Level > 100).Select(player => player.Login);
            foreach (var i in filteredPlayers2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("\n");
            var filteredPlayers3 = players.Where(playe => playe.Login.ToUpper().StartsWith("K"));
            foreach (var i in filteredPlayers3)
            {
                Console.WriteLine(i.Login);
            }
            Console.WriteLine("\n");
            var orderedPlayersLevel = players.Where(player => player.Level > 40).OrderBy(Player => Player.Level);
            foreach (var i in orderedPlayersLevel)
            {
                Console.WriteLine(i.Login);
            }
            Console.WriteLine("\n");
            List<int> numbers = new List<int> { 1, 5, 100, 0, 2, 1, 3, 4, 85, 9, 6, 4, 7 };
            int maxNumber = numbers.Max();
            int mixNumber = numbers.Min();
            Console.WriteLine($"{maxNumber}, {mixNumber}\n");

            var newPlayer = from Player player in players select new{Login = player.Login, dateOfBirth = DateTime.Now};

            foreach (var player in newPlayer)
            {
                Console.WriteLine($"{player.Login} - {player.dateOfBirth}");
            }
            Console.WriteLine("\n");
            var newPlayer2 = players.Select(player => new {Name = player.Login, dateOfBirth = "Понедельник"});
            foreach (var player in newPlayer2)
            {
                Console.WriteLine($"{player.Name} - {player.dateOfBirth}");
            }
            Console.WriteLine("\n");

            var unitedTeam = players.Union(players2);
            foreach (var player in unitedTeam)
            {
                Console.WriteLine(player.Login);
            }
            Console.WriteLine("\n");

            var filteredPlayers4 = players.Skip(2);
            foreach (var player in filteredPlayers4)
            {
                Console.WriteLine(player.Login);
            }
            Console.WriteLine("\n");
            var filteredPlayers5 = players.Take(1);
            foreach (var player in filteredPlayers5)
            {
                Console.WriteLine(player.Login);
            }
            Console.WriteLine("\n");
            var filteredPlayers6 = players.TakeWhile(player => player.Login.ToUpper().StartsWith("J"));
            foreach (var player in filteredPlayers6)
            {
                Console.WriteLine(player.Login);
            }
            Console.WriteLine("\n");
        }
    }

    class Player
    {
        public string Login { get; private set; }

        public int Level { get; private set; }

        public Player(string login, int level)
        {
            Login = login;
            Level = level;
        }
    }
}

