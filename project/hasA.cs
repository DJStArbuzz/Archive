using System;
using System.Globalization;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace Cafe
{
   internal class Program
    {
        static void Main(string[] args)
        {
            Performer worker1 = new Performer("Вениамин");

            Task[] tasks = { new Task(worker1, "мяукать") };

            Board schedule = new Board(tasks);

            schedule.ShowAllTasks();
        }

    }

    class Performer
    {
        public string Name;
        public Performer(string name)
        {
            Name = name;
        }
    }
    class Board
    {
        public Task[] Tasks;

        public Board(Task[] tasks)
        {
            Tasks = tasks;  
        }

        public void ShowAllTasks()
        {
            for(int i = 0; i < Tasks.Length; i++)
            {
                Tasks[i].ShowInfo();
            }
        }
    }
    class Task
    {
        public Performer Worker;
        public string Description;
        public Task(Performer worker,  string description)
        {
            Worker = worker;
            Description = description;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Ответственный: {Worker.Name}\nОписание задачи: {Description}.\n");
        }
    }
}
