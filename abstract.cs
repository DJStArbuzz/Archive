// AbstractInheritance - класс BankAccount является 
// абстрактным, поскольку в нем не существует реализации 
// метода Withdraw () 
using System;
namespace AbstractInheritance
{
    // AbstractBaseClass - создадим абстрактный класс, в 
    // котором имеется только единственный метод Output () 
    abstract public class AbstractBaseClass
    {
        // Output - абстрактный метод, который выводит строку, 
        // но только в подклассах , которые перекрывают этот 
        // метод 
        abstract public void Output(string outputString);
    }

    // SubClass1 - первая конкретная реализация класса 
    // AbstractBaseClass 
    public class SuЬClass1 : AbstractBaseClass
    {
        override public void Output(string source)
        {
            string s = source.ToUpper();
            Console.WriteLine("Вызов SubClass1.Output() из {0}", s);
        }
    }

    // SubClass2 - еще одна конкретная реализация класса 
    // AbstractBaseClass 
    public class SuЬClass2 : AbstractBaseClass
    {
        override public void Output(string source)
        {
            string s = source.ToLower();
            Console.WriteLine("Вызов SuЬClass2 . Output () из {0}", s);
        }
    }

    class Program
    {
        public static void Test(AbstractBaseClass Ьа)
        {
            Ьа.Output("Test ");
        }

        public static void Main(string[] strings)
        {
            // Нельзя создать объект класса AbstractBaseClass, 
            // поскольку он - абстрактный . Если вы снимете 
            // комментарий со следующей строки , то С# сгенерирует 
            // сообщение об ошибке компиляции 
            // AbstractBaseClass Ьа = new AbstractBaseClass(); 

            // Теперь повторим наш эксперимент с классом Subclass1 
            Console.WriteLine("Создание объекта SubClass1");
            SuЬClass1 scl = new SuЬClass1();
            Test(scl);

            // и классом Subclass2 
            Console.WriteLine("Создание объекта SubClass2");
            SuЬClass2 sc2 = new SuЬClass2();
            Test(sc2);

            // Ожидаем подтверждения пользователя 
            Console.WriteLine("Нажмите <Enter> для " +
                              "завершения программы..."); 
            Console.Read();
        }
    }
}
            
