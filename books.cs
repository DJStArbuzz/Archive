using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace CSharpLight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isOpen = true;
            string[,] books = {{"Александр Пушкин", "Михаил Лермонтов", "Сергей Есенин"},
                {"Роберт Мартин", "Джесси Шелл", "Сергей Тепляков"},
                {"Стивен Кинг", "Говард Лавкрафт", "Врем Стокер"}};

            while (isOpen)
            {
                Console.SetCursorPosition(0, 20);
                Console.WriteLine("Весь список авторов:");

                for (int i = 0; i < books.GetLength(0); i++)
                {
                    for (int j = 0; j < books.GetLength(1); j++)
                    {
                        Console.Write(books[i, j] + " | ");
                    }
                    Console.WriteLine();
                }

                Console.SetCursorPosition(0, 0);
                Console.WriteLine("Библиотека");
                Console.WriteLine("1 - узнать имя автора по индексу книги.\n\n" +
                    "2 - найти книгу по автору.\n\n" +
                    "3 - выход.");
                Console.Write("Выберите пункт меню: ");
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        int line, column;

                        Console.Write("Введите номер полки: ");
                        line = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Введите номер столбца: ");
                        column = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Это автор: " + books[line, column]);
                        break;
                    case 2:
                        string author;
                        bool authorIsFound = false;

                        Console.Write("Введите автора: ");
                        author = Console.ReadLine();
                        for (int i = 0; i < books.GetLength(0); i++)
                        {
                            for (int j = 0; j < books.GetLength(1); j++)
                            {
                                if (author.ToLower() == books[i, j].ToLower())

                                {
                                    authorIsFound = true;
                                    Console.Write($"Автор {books[i, j]} находится по адресу " +
                                        $"полка {i + 1}, место {j + 1}");

                                }
                            }
                        }
                        if (authorIsFound == false)
                        {
                            Console.Write("Такого автора нет.");
                        }
                        break;
                    case 3:
                        isOpen = false;
                        break;
                    default:
                        Console.WriteLine("Неверная команда.");
                        break;
                }
                if (isOpen)
                {
                    Console.WriteLine("\nНажмите любу клавишу для продолжения.");
                }
                Console.ReadKey();
            }
        }
    }
}
