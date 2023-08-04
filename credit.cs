using System;

// Генерация таблицы роста вклада по тому же алгоритму, что 
// ив ранее рассматривавшихся программах, однако в этой 
// программе работа распределена между несколькими 
// методами . 
namespace CalculateinterestTaЬleWithMethods
{
    public class Program
    {
        public static void Main(string[] args)
        {

            // Раздел 1 - ввод данных для создания таблицы 
            decimal principal = 0M;
            decimal interest = 0M;
            decimal duration = 0M;
            InputInterestData(ref principal, ref interest, ref duration);

            // Раздел 2 - проверка введенных данных путем вывода 
            // их пользователю на экран 
            Console.WriteLine(); // Пропуск строки 
            Console.WriteLine("Вклад " + principal);
            Console.WriteLine("Пpoцeнтнaя ставка " + interest + "%");
            Console.WriteLine("Cpoк " + duration + " лет");
            Console.WriteLine();

            // Раздел 3 - вывод таблицы вкладов по годам 
            OutputInterestTaЬle(principal, interest, duration);

            // Ожидаем подтверждения пользователя 
            Console.WriteLine("Haжмитe <Enter> для " + "завершения программы ... ");

            Console.Read();
        }

        // Input interestData - ввод с клавиатуры вклада , 
        // процентной ставки и срока для расчета таблицы 
        // Этот метод реализует раздел 1, разбивая его на три 
        // компонента
        public static void InputInterestData(ref decimal principal, ref decimal interest, ref decimal duration)
        {
            // la Получение вклада 
            principal = InputPositiveDecimal("вклaд");

            // lб Получение процентной ставки 
            interest = InputPositiveDecimal("пpoцeнтнaя ставка");

            // lв Получение срока 
            duration = InputPositiveDecimal("срок");
        }

        // Input PositiveDecimal возвращает положительное число 
        // типа decimal, введенное с клавиатуры 
        // Выполняется только одна проверка - на 
        // неотрицательность введенного значения 
        public static decimal InputPositiveDecimal(string prompt)
        {
            // Цикл выполняется, пока не будет введено верное 
            // значение
            while (true)
            {
                // Приглашение для ввода 
                Console.Write("Введите " + prompt + ": ");

                // Получение значения типа decimal с клавиатуры 
                string input = Console.ReadLine();
                decimal value = Convert.ToDecimal(input);

                // Выход из цикла при вводе корректного значения 
                if (value >= 0)
                {
                    // Возврат введенного значения 
                    return value;
                }
                // В противном случае генерируется и выводится 
                // сообщение об ошибке
                Console.WriteLine(prompt + " не может иметь отрицательное значение ");
                Console.WriteLine("Попробуйте еще раз");
                Console.WriteLine();
            }
        }
        // OutputInterestTaЬle для заданных значений вклада , 
        // процентной ставки и срока генерирует и выводит на 
        // экран таблицу роста вклада 
        // Реализация раздела З основной программы 
        public static void OutputInterestTaЬle(decimal principal, decimal interest,
                        decimal duration)
        {
            for (int year = 1; year <= duration; year++)
            {
                // Вычисление начисленных процентов 
                decimal interestPaid;
                interestPaid = principal * (interest / 100);
                // Вычисление значения нового вклада путем 
                // добавления начисленного процентов к основному 
                // вкладу
                principal = principal + interestPaid;

                // Округление вклада до копеек 
                principal = decimal.Round(principal, 2);

                // Вывод результата 
                Console.WriteLine(year + "-" + principal);
            }
        }
    }         

}

        
