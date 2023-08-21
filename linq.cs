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

            var filteredPlayers = from Player player in players where player.Level > 100 select player;
            //List<Player> filteredPlayers = new List<Player>();
            //foreach (var player in players)
            //{
            //    if(player.Level > 100)
            //    {
            //        filteredPlayers.Add(player);
            //    }
            //}
            foreach (var player in filteredPlayers) 
            {
                Console.WriteLine(player.Login);
            }
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

