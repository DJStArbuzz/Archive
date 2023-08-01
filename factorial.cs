using System;

namespace FactorialException
{
    public class MyMathFunctions
    {
        public static int Factorial(int value)
        {
            if (value < 0)
            {
                string s = String.Format ( "Отрицательный аргумент в вызове Factorial {0}", value);
                throw new ArgumentException(s);
            }
            int factorial = 1;
            do
            {
                factorial *= value;
            }
            while (--value > 1);
            return factorial;
        }
        public static int Square(int value)
        {
            if (value < 0)
            {
                string s = String.Format("Да лень дальше писать");
                throw new ArgumentException(s);
            }
            int square = value;
            return square * square;
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                for (int i = 6; i > -6; i--)
                {
                    int factorial = MyMathFunctions.Factorial(i);
                    Console.WriteLine("i = {0}, факториал = {1}", i, factorial);
                }
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Фатальная ошибка");
                Console.WriteLine(e.ToString());
            }
            Console.WriteLine("Конец 1-ой функции\n");
            try
            {
                for (int i = 10; i > -10; i--)
                {
                    int square = MyMathFunctions.Square(i);
                    Console.WriteLine($"{i} - {square}");
                }
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Не ошибка, а лень");
                Console.WriteLine(e.ToString);
            }
            Console.WriteLine("Конец 2-ой функции");
        }
    }
}
