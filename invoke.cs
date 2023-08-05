using System;

namespace InvokeMethod
{
    class Student
    {
        // Информация об имени студента
        public string firstName;
        public string lastName;
    
        // SetName - сохранение информации об имени
        public void SetName(string fname, string lname)
        {
            firstName = fname;
            lastName = lname;
        }

        // ToNameString преобразует объект класса Student 
        // в строку для вывода
        public string ToNameString()
        {
            string word = firstName + " " + lastName;
            return word;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Student student = new Student();
            student.SetName("Stephen", "Davis");
            Console.WriteLine("Имя студента - "
                              + student.ToNameString());
            // Ожидаем подтверждения пользователя 
            Console.WriteLine("Нажмите <Enter> для " +
                              "завершения программы ... ");
            Console.Read();
        }
    }
}
