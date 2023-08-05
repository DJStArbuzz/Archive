using System;

namespace PassObject
{
    public class Student
    {
        public string name;
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Student student = new Student();
            // Присваиваем имя путем непосредственного
            // обращения к полю объекта
            Console.WriteLine("Сначала:");
            student.name = "Madeleine";
            OutputName(student);
            SetName(student, "Willa");
            OutputName(student);
            // Ожидаем подтверждения пользователя
            Console.WriteLine("Нажмите <Enter> для " +
                              "завершения программы ... ");
            Console.Read();
        }

        // OutputName - вывод имени студента
        public static void OutputName(Student student)
        {
            // Вывод текущего имени студента
            Console.WriteLine("Student.name = {0}", student.name);
        }

        // SetName - изменение имени студента
        public static void SetName(Student student, string name)
        {
            student.name = name;
        }
    }
}
