using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.CompilerServices;

namespace Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Game> games = new List<Game>();


            games.Add(new Game("g1", Genre.Strategy));
            games.Add(new Game("g2", Genre.RPG));
            games.Add(new Game("g3", Genre.Action));

            foreach (var game in games)
            {
                game.ShowInfo();
            }
            Console.WriteLine((Genre)12);
        }
    }
    // enum - тип значения, определенный набором именованных констант
    enum Genre
    {
        Strategy,
        RPG,
        Action,
        Op = 12
    }

    class Game
    {
        private string _title;
        private Genre _genre;
        
        public Game(string title, Genre genre)
        {
            _title = title;
            _genre = genre;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Это игра {_title}, ее жанр {_genre}.");
        }
    }
}

