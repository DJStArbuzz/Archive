using System;
using System.Globalization;
using System.IO;
using System.Threading;

namespace Cafe
{
   internal class Program
    {
        static void Main(string[] args)
        {

            bool isOpen = true;
            Table[] table = { new Table(1, 4),
                              new Table(2, 8), 
                              new Table(3, 10)};
            while( isOpen )
            {
                Console.WriteLine("Администрирование кафе\n");
                for (int i = 0; i < table.Length; i++)
                {
                    table[i].ShowInfo();
                }

                Console.Write("\nВведите номер стола: ");
                int wishTable = Convert.ToInt32(Console.ReadLine()) - 1;


                Console.Write("\nВведите количество мест для брони: ");
                int desiredPlaces = Convert.ToInt32(Console.ReadLine());

                bool isReservationIsCompleted = table[wishTable].Reserve(desiredPlaces);
                if (isReservationIsCompleted )
                {
                    Console.WriteLine("Бронь прошла успешно");
                }
                else
                {
                    Console.WriteLine("Недостаточно мест");
                }

                Console.ReadKey();
                Console.Clear();
            }
        }
    }

    class Table
    {
        public int Number;
        public int MaxPlace;
        public int FreePlace;

        public Table(int number, int maxPlace)
        {
            Number = number;
            MaxPlace = maxPlace;
            FreePlace = maxPlace;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Стол: {Number}. Свободно мест: {FreePlace} из {MaxPlace}");
        }

        public bool Reserve(int places)
        {
            if (FreePlace >= places)
            {
                FreePlace -= places;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
