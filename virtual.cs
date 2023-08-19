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
            NonePlayerCharacter[] characters =
            {
                new NonePlayerCharacter(),
                new Farmer(),
                new Knight(),
                new Child()
            };
            foreach (NonePlayerCharacter character in characters) 
            { 
                character.ShowDescription();
                Console.WriteLine(new string('-', 40));
            }
        }
    }

    class NonePlayerCharacter
    {
        public virtual void ShowDescription()
        {
            Console.WriteLine("Я простой NPC. Я просто гуляю.");
        }
    }

    class Farmer : NonePlayerCharacter
    {
        public override void ShowDescription()
        {
            base.ShowDescription();
            Console.WriteLine("А еще я фермер, который работает с полем.");
        }
    }

    class Knight : NonePlayerCharacter
    {
        public override void ShowDescription()
        {
            Console.WriteLine("Я рыцарь, мое дело только сражение.");
        }
    }

    class Child : NonePlayerCharacter
    {

    }
}
