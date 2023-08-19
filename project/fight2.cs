using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string line = "\n**" + new string('-', 40) + " **";

            Fighter[] fighters = 
            {    
                new Fighter("Джон", 500, 50, 0),
                new Fighter("Марк", 250, 25, 20), 
                new Fighter("Алекс", 100, 100, 25),     
                new Fighter("Джек", 300, 75, 5)
            };

            for (int i = 0; i < fighters.Length; i++)
            {
                Console.Write(i + 1 + " ");
                fighters[i].ShowStats();
            }

            Console.WriteLine(line);

            int fighterNumber;
            Console.Write("\nВыберите номер первого бойца: ");
            fighterNumber = Convert.ToInt32(Console.ReadLine()) - 1;
            Fighter firstFighter = fighters[fighterNumber];

            Console.Write("Выберите номер второго бойца: ");
            fighterNumber = Convert.ToInt32(Console.ReadLine()) - 1;
            Fighter secondFighter = fighters[fighterNumber];

            Console.WriteLine(line);

            int round = 1;

            while(firstFighter.Health > 0 && secondFighter.Health > 0)
            {
                Console.WriteLine("\nБой №" + round);
                firstFighter.TakeDamage(secondFighter.Damage);
                secondFighter.TakeDamage(firstFighter.Damage);
                firstFighter.ShowCurrentHealth();
                secondFighter.ShowCurrentHealth();
                round++;
            }

            Console.WriteLine(line);

            if(firstFighter.Health <= 0 && secondFighter.Health <= 0)
            {
                Console.WriteLine("Ничья");
            }
            else
            {
                Fighter winner = (secondFighter.Health > firstFighter.Health) ? secondFighter : firstFighter;
                Fighter loser = (secondFighter.Health < firstFighter.Health) ? secondFighter : firstFighter;

                Console.WriteLine($"\nПобедитель - {winner.Name}!");
                Console.WriteLine($"Проигравший - {loser.Name}...");
            }

            Console.WriteLine(line);
        }
    }

    class Fighter
    {
        private string _name;
        private int _health;
        private int _damage;
        private int _armor;

        public Fighter(string name, int health, int damage, int armor )
        {
            _name = name;
            _health = health;
            _damage = damage;
            _armor = armor;
        }

        public int Health { get { return _health; } }

        public int Damage { get { return _damage; } }

        public string Name { get { return _name; } }

        public void ShowStats()
        {
            Console.WriteLine($"Боец - {_health}, здоровье: {_health}, " +
                $"наносимый урон: {_damage}, броня: {_armor}.");
        }

        public void ShowCurrentHealth()
        {
            Console.WriteLine($"{_name}. Здоровье: {_health}");
        }
        public void TakeDamage(int damage)
        {
            _health -= damage - _armor;
        }
    }
}
