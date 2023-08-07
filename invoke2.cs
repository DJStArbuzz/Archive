// InvokeBaseConstructor - демонстрация того , как подкласс 
// может вызвать конструктор базового класса по своему 
// выбору с использованием ключевого слова base 
using System;
namespace InvokeBaseConstructor
{
    public class BaseClass
    {
        public BaseClass()
        {
            Console.WriteLine("Конструктор BaseClass " +
                              "(по умолчанию)");
        }
        public BaseClass(int i)
        {
            Console.WriteLine("Конструктор BaseClass ({0}) ", i);
        }
    }
    public class SuЬClass : BaseClass
    {
        public SuЬClass()
        {
            Console.WriteLine("Конструктор SuЬClass " +
                              "(по умолчанию) ");
        }
        public SuЬClass(int i1, int i2) : base(i1)
        {
            Console.WriteLine("Конструктор SuЬClass ( {0}, {1}) ",
            i1, i2);
        }
    }

    public class Program
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("Вызов SubClass ()");
            SuЬClass scl = new SuЬClass();
            Console.WriteLine("\nВызов SubClass (1, 2 ) ");
            SuЬClass sc2 = new SuЬClass(1, 2);
            // Ожидаем подтверждения пользователя 
            Console.WriteLine("Нажмите <Enter> для " +
                " завершения программы ... ");
        }
    }
}
