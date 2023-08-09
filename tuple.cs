using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace CSharpLight
{
    class P
    {
        static Tuple<string, int, bool>[] getTuple()
        {
            Tuple<string, int, bool> [] aTuple =
            { 
            new Tuple<string, int, bool>( "One", 1, true ) , 
            new Tuple<string, int, bool>( "Two" , 2, false) , 
            new Tuple<string, int, bool>( "Three", 3, true )}; 
            // Возврат списка значений с использованием кортежа . 
            return aTuple; 
        }

        static void Main(string[] args)
        {
            // Получение набора кортежей . 
            Tuple<string, int, bool>[] myTuple = getTuple();
            // Вывод значений . 
            foreach (var Item in myTuple)
            {
                Console.WriteLine(Item.Item1 + "\t" + Item.Item2);
            } 
            // Ожидаем подтверждения пользователя 
            Console.WriteLine("Нажмите <Enter> для " +
                               "завершения программы ... ");
            Console.Read(); 
        }
    }
}
