using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.CompilerServices;

namespace Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // upcasting and downcasting
            Person person;
            Mentor mentor = new Mentor("Tom", 0);
            person = mentor;
            person.ShowName();

            Person person2 = new Student("Джим", 5); ;
            Student student;
            student = (Student)person;
            student.ShowName();
        }
    }

    class Person
    {
        public string Name { get; private set; }
        public Person(string name)
        {
            Name = name;
        }    

        public void ShowName()
        {
            Console.WriteLine("Я - " + Name);
        }
    }
    class Mentor : Person
    {
        public int NumberOfStudent { get; private set; }

        public Mentor(string name, int numberOfStudents) : base(name)
        {
            NumberOfStudent = numberOfStudents;
        }
    }
    class Student : Person
    {
        public int AverageScore { get; private set; }

        public Student(string name, int averageScore) : base(name)
        {
            AverageScore = averageScore;
        }
    }
}

