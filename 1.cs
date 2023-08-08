// SortInterface - демонстрационная программа Sort interface 
// иллюстрирует концепцию интерфейса 
using System;
using System.Diagnostics;
using System.Xml.Linq;

namespace SortInterface
{
    // IDisplayable - объект, который может представить 
    // информацию о себе в строковом формате 
    interface IDisplayable
    {
        // Display - возврат строки , предоставляющей 
        // информацию об объекте 
        string Display();
    }
    class Program
    {
        public static void Main(string[] args)
        {
            // Сортировка студентов по успеваемости ... 
            Console.WriteLine("Сортировка списка студентов");

            // Получаем неотсортированным список студентов 
            Student[] students = Student.CreateStudentList();

            // Используем интерфейс IComparable<T> дпя сортировки 
            // массива 
            Array.Sort(students);

            // Теперь интерфейс IDisplayable выводит результат 
            DisplayArray(students);

            // Теперь отсортируем массив птиц по имени с 
            // использованием той же процедуры, хотя классы Bird 
            // и Student не имеют общего базового класса 
            Console.WriteLine("\nСортировка списка птиц");
            Bird[] birds = Bird.CreateBirdList();

            // Обратите внимание на отсутствие необходимости 
            // явного преобразования типа объектов ... 
            Array.Sort(birds);
            DisplayArray(birds);

            // Ожидаем подтверждения пользователя 
            Console.WriteLine("Нажмите <Enter> для " +
            "завершения программы ... ");

            Console.Read();
        }

        // DisplayArray - вывод массива объектов , реализующих 
        // интерфейс IDisplayable 
        public static void DisplayArray(IDisplayable[] displayables)
        {
            foreach (IDisplayable displayable in displayables)
            {
                Console.WriteLine("{0}", displayable.Display());
            }
        }
    }

    // ----------- Students - сортировка по успеваемости ---­
    // Student - описание студента с использованием имени и 
    // успеваемости 
    class Student : IComparable<Student>, IDisplayable
    {
        // Конструктор - инициализация нового объекта
        public Student(string name, double grade)
        {
            Name = name;
            Grade = grade;
        }

        // CreateStudentList - для простоты создаем 
        // фиксированный список студентов 
        static string[] names = { "Homer", "Marge ", "Bart", "Lisa", "Maggie" };
        static double[] grades = { 0, 85, 50, 100, 30 };

        public static Student[] CreateStudentList()
        {
            Student[] students = new Student[names.Length];
            for (int i = 0; i < names.Length; i++)
            {
                students[i] = new Student(names[i], grades[i]);
            }
            return students;
        }

        // Методы доступа только для чтения 
        public string Name { get; private set; }
        public double Grade { get; private set; }

        // Реализация интерфейса IComparable: 
        // CompareTo - сравнение двух объектов (в нашем случае 
        // объектов типа Student ) и выяснение , какой из 
        // них должен идти раньше в отсортированном списке 
        public int CompareTo(Student rightStudent)
        {
            // Сравнение текущего Student (назовем его левым) и 
            // другого (назовем его правым) 
            Student leftStudent = this;

            // Генерируем -1, О или 1 на основании критерия 
            // сортировки 
            if (rightStudent.Grade < leftStudent.Grade)
            {
                return -1;
            }
            if (rightStudent.Grade > leftStudent.Grade)
            {
                return 1;
            }
            return 0;
        }

        // Реализация интерфейса IDisplayaЬle : 
        public string Display()
        {
            string padName = Name.PadRight(9);
            return String.Format("{0} : {1:N0}", padName, Grade);
        }
    }

    // -----------Birds - сортировка птиц по именам-------­
    // Массив имен птиц 
    class Bird : IComparable<Bird>, IDisplayable
    {
        // Конструктор - инициализация объекта Bird 
        public Bird(string name)
        {
            Name = name;
        }

        // CreateBirdList - возвращает список птиц; для простоты 
        // используем фиксированный список 
        static string[] birdNames =
            { "Oriole", "Hawk", "RoЬin", "Cardinal",
              "Bluejay", "Finch", "Sparrow" };
        public static Bird[] CreateBirdList()
        {
            Bird[] birds = new Bird[birdNames.Length];

            for (int i = 0; i < birds.Length; i++)
            {
                birds[i] = new Bird(birdNames[i]);
            }
            return birds;
        }

        public string Name { get; private set; }
        // Реализация интерфейса IComparable: 
        // CompareTo - сравнение имен птиц; используется 
        // встроенный метод сравнения класса String 
        public int CompareTo(Bird rightBird)
        {
            // Сравнение текущего Bird (назовем его левым) и 
            // другого ( назовем его правым) 
            Bird leftBird = this;
            return String.Compare(leftBird.Name, rightBird.Name);
        }

        // Реализация интерфейса IDisplayable: 
        // Di splay - возвращает строку с именем птицы 
        public string Display()
        {
            return Name;
        } 
    } 
}
