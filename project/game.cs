using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Net.NetworkInformation;

namespace Game
{
    internal class Program
    {
        public static void PrintResult(ConsoleColor defaultColor)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(35, 0);

            Console.Write("Сумка:");
            Console.ForegroundColor = defaultColor;
        }
        static void Main(string[] args)
        {

            Console.CursorVisible = false;

            int treasureN = 17;
            char[] walls = { '#', '|', '/', '\\', '_', '-', '.', '='};
            char[] hashTreasure = {'X', '0', '$', '*'};
            char[] bag = new char[1];
            char[,] map =
            {
                { '.', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_','_', '_', '_', '_', '_', '.'},
                { '|', '$', '#', ' ', 'X', '#', ' ', 'X', ' ', ' ', ' ', ' ', '*', '#', ' ', ' ', ' ', '#', '0', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ','|'},
                { '|', ' ', '#', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', '#', '#', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ','|'},
                { '|', ' ', '#', ' ', '#', '#', ' ', ' ', ' ', '#', '#', '#', '#', ' ', ' ', ' ', ' ', '#', '#', '#', '|', ' ', ' ', '.', '_', '_', '_', '_', '_', '.','|'},
                { '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|', ' ', ' ', '|', ' ', ' ', ' ', ' ', ' ', '|','|'},
                { '|', ' ', '|', ' ', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', '#', '#', '#', ' ', ' ', ' ', ' ', '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '|','|'},
                { '|', ' ', '|', ' ', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', '|', ' ', ' ', '|', '$', ' ', ' ', ' ', '*', '|','|'},
                { '|', ' ', '|', ' ', '#', '#', ' ', '#', '#', ' ', ' ', ' ', ' ', '#', 'X', ' ', ' ', ' ', ' ', ' ', '|', ' ', ' ', '.', '_', '_', '_', '_', '_', '.','|'},
                { '|', ' ', '|', ' ', ' ', '#', ' ', ' ', ' ', ' ', '|', '#', '#', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ','|'},
                { '|', ' ', '|', ' ', ' ', '#', ' ', ' ', ' ', ' ', '|', '*', ' ', '#', '#', '#', '#', '#', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#', ' ','|'},
                { '|', ' ', '|', ' ', ' ', '#', '#', '#', ' ', ' ', '|', ' ', ' ', ' ', ' ', ' ', '|', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#', '#', '#','|'},
                { '|', ' ', '|', ' ', ' ', ' ', '0', '#', ' ', '#', '|', ' ', ' ', ' ', ' ', ' ', '|', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', '#', ' ', ' ','|'},
                { '|', ' ', '#', ' ', ' ', ' ', ' ', '#', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', '|', ' ', '#', '#', '#', ' ', ' ', ' ', ' ', ' ', ' ', '#', ' ', ' ','|'},
                { '|', ' ', '#', ' ', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', '#', ' ', ' ', '|', ' ', '#', '$', ' ', ' ', '0', ' ', ' ', '#', ' ', ' ', ' ', ' ','|'},
                { '|', ' ', '#', '#', '#', '#', ' ', ' ', ' ', ' ', ' ', ' ', '#', '#', ' ', ' ', '|', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ','|'},
                { '|', ' ', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#', ' ', ' ', '|', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ','|'},
                { '|', ' ', ' ', '|', ' ', '#', '#', '#', ' ', ' ', '|', ' ', ' ', '#', ' ', ' ', ' ', ' ', '#', ' ', '#', ' ', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ','|'},
                { '|', ' ', ' ', '|', ' ', '#', ' ', '#', ' ', ' ', '|', ' ', ' ', '#', ' ', ' ', ' ', ' ', '#', '#', '#', ' ', ' ', '#', '#', '#', '#', ' ', ' ', ' ','|'},
                { '|', ' ', '#', '|', ' ', '#', ' ', '#', '#', ' ', '|', ' ', ' ', '#', ' ', ' ', ' ', ' ', '#', '*', ' ', ' ', '#', '#', ' ', ' ', '#', '#', ' ', ' ','|'},
                { '|', ' ', '#', '|', ' ', '#', ' ', ' ', ' ', ' ', '|', ' ', '#', '#', '#', '#', ' ', ' ', '#', '#', '#', '#', '#', ' ', ' ', ' ', '#', ' ', ' ', ' ','|'},
                { '|', ' ', '#', '|', ' ', '#', ' ', ' ', ' ', ' ', '|', ' ', ' ', '#', ' ', ' ', ' ', ' ', '#', ' ', ' ', ' ', '#', ' ', ' ', ' ', '#', ' ', ' ', ' ','|'},
                { '|', ' ', ' ', '|', ' ', '#', ' ', ' ', ' ', ' ', '#', '#', ' ', '#', ' ', ' ', ' ', ' ', '#', '$', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ','|'},
                { '|', '#', '*', '|', ' ', '#', '$', ' ', ' ', '#', '#', '$', ' ', '#', ' ', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ','|'},
                { '\\','=', '=', '=', '=', '=', '=', '=', '=', '=', '=', '=', '=', '=', '=', '=', '=', '=', '=', '=', '=', '=', '=', '=', '=', '=', '=', '=', '=', '=','/'}
            };

            int userX = 6, userY = 6;
            ConsoleColor defaultColor = Console.ForegroundColor;
            while (true)
            {
                PrintResult(defaultColor);

                for (int i = 0; i  < bag.Length; i++)
                {
                    Console.Write(bag[i] + " ");
                }
                Console.SetCursorPosition(0, 0);
                for (int i = 0; i < map.GetLength(0); i++)
                {
                    for (int j = 0; j < map.GetLength(1); j++)
                    {
                        if (walls.Contains(map[i, j]))
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                        }
                        else if (hashTreasure.Contains(map[i, j]))
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                        }
                        Console.Write(map[i, j]);
                        Console.ForegroundColor = defaultColor;
                    }
                    Console.WriteLine();
                }

                Console.SetCursorPosition(userY, userX);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write('@');
                Console.ForegroundColor = defaultColor;

                ConsoleKeyInfo charKey = Console.ReadKey();
                switch (charKey.Key)
                {
                    case ConsoleKey.UpArrow:
                        if (!walls.Contains(map[userX - 1, userY]))
                        {
                            userX--;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        if (!walls.Contains(map[userX + 1, userY]))
                        {
                            userX++;
                        }
                        break;
                    case ConsoleKey.LeftArrow:
                        if (!walls.Contains(map[userX, userY - 1]))
                        {
                            userY--;
                        }
                        break;
                    case ConsoleKey.RightArrow:
                        if (!walls.Contains(map[userX, userY + 1]))
                        {
                            userY++;
                        }
                        break;
                }

                if (hashTreasure.Contains(map[userX, userY]))
                {
                    char treasureChar = map[userX, userY];
                    map[userX, userY] = 'O';
                    char[] tempBag = new char[bag.Length + 1];
                    for (int i = 0; i < bag.Length; i++)
                    {
                        tempBag[i] = bag[i];
                    }
                    tempBag[tempBag.Length - 1] = treasureChar;
                    bag = tempBag;
                }
                Console.Clear();
            }
        }
    }
}
