// ReferencingThisExplicitly - программа с использованием this
using System;

namespace ReferencingThisExplicitly
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Создание объекта студента
            Student student = new Student();
            student.Init("Stephen Davis", 1234);
            // Внесение курса в список
            Console.WriteLine("Внесение в список " +
                              "Stephen Davis " +
                              "курса Biology 101");
            student.Enroll("Biology 101");
            // Вывод прослушиваемого курса
            Console.WriteLine("Информация о студенте : ");
            student.DisplayCourse();
            // Ожидаем подтверждения пользователя 
            Console.WriteLine("Нажмите <Enter> для " +
                              "завершения программы...");
            Console.Read();
        }
    }

    // Student - класс, описывающий студента
    public class Student
    {
        // Все студенты имеют имена и идетификаторы
        public string   _name;
        public int      _id;

        // Курс, прослушиваемый студентом
        CourseInstance _courseInstance;

        // Init - инициализация объекта
        public void Init(string name, int id)
        {
            this._name = name;
            this._id = id;
            _courseInstance = null;
        }

        // Enroll - добавление в список
        public void Enroll(string sCourseID)
        {
            _courseInstance = new CourseInstance();
            _courseInstance.Init(this, sCourseID);
        }

        // Вывод имени студента и прослушиваемых курсов
        public void DisplayCourse()
        {
            Console.WriteLine(_name);
            _courseInstance.Display();
        }
    }

    // CourseInstance - объединение информации
    // о студенте и прослушиваемом курсе
    public class CourseInstance
    {
        public Student  _student;
        public string   _courseID;

        // Init - связь студента и курса
        public void Init(Student student, string courseID) 
        {
            this._student = student;
            this._courseID = courseID;

        }

        // Display - вывод имени курса
        public void Display()
        {
            Console.WriteLine(_courseID);
        }
    }
}
