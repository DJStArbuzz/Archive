// BankAccount - создание банковского счета с использованием 
// переменной типа douЬle для хранения баланса счета (она 
// объявлена как private , чтобы скрыть баланс от внешнего 
// мира ) 
// Примечание : пока в программу не будут внесены 
// исправления, она не будет компилироваться, так как 
// метод Main () обращается к private-члену класса 
// BankAccount . 
using System;

namespace BankAccount
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("B текущем состоянии эта " +
                              "программа не компилируется . ");
            // Открытие банковского счета 
            Console.WriteLine("Создание объекта " +
                              "банковского счета ");
            BankAccount ba = new BankAccount();
            ba.InitBankAccount();
            // Обращение к балансу при помощи метода Deposit () 
            // вполне корректно ; Deposit () имеет право доступа ко 
            // всем членам-данным 
            ba.Deposit(10);
            // Непосредственное обращение к члену-данным вызывает 
            // ошибку компиляции 
            Console.WriteLine("Здесь вы получите " +
                              "ошибку компиляции");
            // Ожидаем подтверждения пользователя 
            Console.WriteLine("Нажмите <Enter> для " +
            "завершения программы ... ");
            Console.Read();
        }
    }
    // BankAccount - определение класса , представляющего 
    // простейший банковский счет 
    public class BankAccount
    {
        private static int _nextAccountNumЬer = 1000;
        private int _accountNumber;

        // Хранение баланса в виде одной переменной типа douЬle 
        private double _balance;

        // Init - инициализация банковского счета с нулевым 
        // балансом и с использованием очередного глобального 
        // номера 
        public void InitBankAccount()
        {
            _accountNumber = ++_nextAccountNumЬer;
            _balance = 0.0;
        }

        // GetBalance - получение текущего баланса 
        public double GetBalance()
        {
            return _balance;
        }

        // Номер счета 
        public int GetAccountNumЬer()
        {
            return _accountNumber;
        }

        public void SetAccountNumЬer(int accountNumЬer)
        {
            this._accountNumber = accountNumЬer;
        }

        // Deposit - позволен любой положительный вклад 
        public void Deposit(double amount)
        {
            if (amount > 0.0)
            {
                _balance += amount;
            }
        }

        // Withdraw - вы можете снять со счета любую сумму, не 
        // превышающую баланс; метод возвращает реально снятую 
        // сумму 
        public double Withdraw(double withdrawal)
        {
            if (_balance <= withdrawal)
            {
                withdrawal = _balance;
            }
            _balance -= withdrawal;
            return withdrawal;
        }

        // GetString - возвращает информацию о состоянии счета в 
        // виде строки 
        public string GetString()
        {
            string s = String.Format("#{0} = { 1 : С}",
                                     GetAccountNumЬer(),
                                     GetBalance());

            return s;
        }
    }
}
