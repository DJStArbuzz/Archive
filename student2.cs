// StudentClassWithMethods - демонстрация методов, 
// работающих с данными внутри класса . Класс отвечает 
// за свои данные и за работу с ними 
using System;
namespace StudentClassWithMethods
{
    // Методы OutputName и SetName являются членами 
    // класса Student , а не класса Program 
    public class Student
    {
        public string name;
        // OutputName - вывод имени
        public static void OutputName(Student student)
        {
            // Выводим имя 
            Console.WriteLine("Имя студента - { О}", student.name);
        }
        // SetName - модификация имени студента 
        public static void SetName(Student student, string name)
        {
            student.name = name;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Student student = new Student();
            // Непосредственная установка имени 
            Console.WriteLine("Сначала:");
            student.name = "Madeleine";
            Student.OutputName(student); // Метод класса Student 
            Console.WriteLine("После:");
            // Изменение имени при помощи метода 
            Student.SetName(student, "Willa");
            Student.OutputName(student);
            // Ожидаем подтверждения пользователя 
            Console.WriteLine("Нажмите <Enter> для " +
                              "завершения программы ... ");
            Console.Read(); 
        } 
    } 
}
