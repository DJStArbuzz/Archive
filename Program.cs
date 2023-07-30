using System;
using System.Net.NetworkInformation;

namespace BuildASentence
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            dict.Add("dsada", 1);
            dict.Add("asdsa", 2);
            Dictionary<string, int>.KeyCollection keys = dict.Keys;
            Console.WriteLine(dict["dsada"]);
            List<int> numList = new List<int> { 1, 2, 3 };
            for (int i = 0; i < numList.Count; i++)
            {
                Console.WriteLine(numList[i]);
            }
            List<string> sp = new List<string> { "red", "orange", "yellow" };
            string[] sp_2 = { "red", "green", "yellow"};
            HashSet<string> combo = new HashSet<string>(sp_2);
            combo.SymmetricExceptWith(sp);
            foreach (string s in combo)
            {
                Console.WriteLine(s);
            }

        }
    }
}
