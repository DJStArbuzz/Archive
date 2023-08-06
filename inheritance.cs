// InheritanceExample - простейшая демонстрация наследования
using System;

namespace InheritanceExample
{
    public class BaseClass
    {
        public int _dataMember;

        public void SomeMethod()
        {
            Console.WriteLine("SomeMethod");
        }
    }

    public class SubClass : BaseClass
    {
        public void SomeOtherMethod()
        {
            Console.WriteLine("SomeOtherMethod()");
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            // Создание объекта базового класса
            Console.WriteLine("Работа с объектом базового класса: ");
            BaseClass bc = new BaseClass();
            bc._dataMember = 1;
            bc.SomeMethod();

            // Создание объекта подкласса 
            Console.WriteLine("\nPaбoтa с объектом подкласса: ");
            SubClass sc = new SubClass();
            sc._dataMember = 2;
            sc.SomeMethod();
            sc.SomeOtherMethod();
            // Ожидаем подтверждения пользователя 
            Console.WriteLine("Нажмите <Enter> для " +
            "завершения программы ... ");
            Console.Read();
        }
    }
}
