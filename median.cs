// Average Display
using System;

namespace Example
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Обращение к методу-члену
            AverageAndDisplay("оценки 1", 3.5, "оценки 2", 4.0);

            // Ожидаем подтверждения пользователя
            Console.WriteLine("Нажмите <Enter> для завершения программы... ");
            Console.Read();
        }

        // AverageAndDisplay усредняет два числа и выводит 
        // результат с использованием переданных меток 
        public static void AverageAndDisplay(string s1, double dl,
                                             string s2, double d2)
        {
            double average = (dl + d2) / 2;
            Console.WriteLine("Среднее " + s1
                           + ", равной " + dl
                           + " и"        + s2
                           + " равной "  + d2
                           + " , равно " + average);
        }
    }
}
