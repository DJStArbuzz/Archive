using System;
using System.Text;
using System.Threading.Tasks;

namespace CSLight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float health;
            int armor;
            int damage;
            int precentConverter = 100;


            Console.Write("Введите количество здоровья: ");
            health = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите количество брони: ");
            armor = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите количество урона: ");
            damage = Convert.ToInt32(Console.ReadLine());

            health -= Convert.ToSingle(damage) / precentConverter * armor;

            Console.WriteLine($"Вам нанесли {damage} урона. " +
                              $"У вас осталось {health} здоровья.");
        }
    }
}
