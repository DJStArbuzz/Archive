using System;
using System.Collections.Generic;

namespace DifferentialEquationSolver
{
    class Program
    {
        static void Main(string[] args)
        {
            // Параметры задачи
            double t0 = 0.0;
            double T = 2.0;

            Console.Write("Введите количество шагов для аналитического решения n: ");
            int n_analytic = int.Parse(Console.ReadLine());

            Console.Write("Введите количество шагов для метода Эйлера: ");
            int n_euler = int.Parse(Console.ReadLine());

            double h_analytic = (T - t0) / n_analytic;
            double h_euler = (T - t0) / n_euler;

            // Решение для x(0) = 1/2
            Console.WriteLine("\nРешение для x(0) = 1/2:");
            Console.WriteLine("t\t\tx(t)");
            Console.WriteLine("-----------------------");

            for (int i = 0; i <= n_analytic; i++)
            {
                double t = t0 + i * h_analytic;
                double x = SolveForXHalf(t);
                Console.WriteLine($"{t:F6}\t{x:F6}");
            }

            // Решение для x(0) = 1
            Console.WriteLine("\nРешение для x(0) = 1:");
            Console.WriteLine("t\t\tx(t)");
            Console.WriteLine("-----------------------");

            for (int i = 0; i <= n_analytic; i++)
            {
                double t = t0 + i * h_analytic;
                double x = SolveForXOne(t);
                Console.WriteLine($"{t:F6}\t{x:F6}");
            }

            // Сравнение с численным методом Эйлера для x(0) = 1/2
            Console.WriteLine("\n\nСравнение с методом Эйлера для x(0) = 1/2:");
            Console.WriteLine("t\t\tАналитическое\tЭйлер\t\tПогрешность");
            Console.WriteLine("---------------------------------------------------");

            List<double> eulerResults = EulerMethod(t0, T, n_euler, 0.5);
            
            // Интерполяция результатов Эйлера для сравнения в тех же точках, что и аналитическое решение
            for (int i = 0; i <= n_analytic; i++)
            {
                double t = t0 + i * h_analytic;
                double analytic = SolveForXHalf(t);
                
                // Находим соответствующий результат метода Эйлера для времени t
                int euler_index = (int)Math.Round(t / h_euler);
                if (euler_index >= eulerResults.Count) euler_index = eulerResults.Count - 1;
                double euler = eulerResults[euler_index];
                
                double error = Math.Abs(analytic - euler);
                Console.WriteLine($"{t:F6}\t{analytic:F6}\t{euler:F6}\t{error:F6}");
            }

            // Дополнительно: улучшенный метод Эйлера (модифицированный)
            Console.WriteLine("\n\nСравнение с методом Эйлера для x(0) = 1/2:");
            Console.WriteLine("t\t\tАналитическое\tЭйлер\t\tПогрешность");
            Console.WriteLine("----------------------------------------------------------------");

            List<double> improvedEulerResults = ImprovedEulerMethod(t0, T, n_euler, 0.5);
            
            for (int i = 0; i <= n_analytic; i++)
            {
                double t = t0 + i * h_analytic;
                double analytic = SolveForXHalf(t);
                
                int euler_index = (int)Math.Round(t / h_euler);
                if (euler_index >= improvedEulerResults.Count) euler_index = improvedEulerResults.Count - 1;
                double improvedEuler = improvedEulerResults[euler_index];
                
                double error = Math.Abs(analytic - improvedEuler);
                Console.WriteLine($"{t:F6}\t{analytic:F6}\t{improvedEuler:F6}\t{error:F6}");
            }
        }

        // Аналитическое решение для x(0) = 1/2
        static double SolveForXHalf(double t)
        {
            double exponent = Math.Exp(-3 * t);
            double denominator = Math.Pow(1 + 7 * exponent, 1.0 / 3.0);
            return 1.0 / denominator;
        }

        // Аналитическое решение для x(0) = 1
        static double SolveForXOne(double t)
        {
            return 1.0;
        }

        // Численное решение методом Эйлера
        static List<double> EulerMethod(double t0, double T, int n, double x0)
        {
            List<double> results = new List<double>();
            double h = (T - t0) / n;
            double x = x0;
            double t = t0;

            results.Add(x);

            for (int i = 1; i <= n; i++)
            {
                // x' = x - x^4
                double derivative = x - Math.Pow(x, 4);
                x = x + h * derivative;
                t = t + h;
                results.Add(x);
            }

            return results;
        }

        // Улучшенный метод Эйлера (модифицированный)
        static List<double> ImprovedEulerMethod(double t0, double T, int n, double x0)
        {
            List<double> results = new List<double>();
            double h = (T - t0) / n;
            double x = x0;
            double t = t0;

            results.Add(x);

            for (int i = 1; i <= n; i++)
            {
                // Первый шаг Эйлера (предсказание)
                double derivative1 = x - Math.Pow(x, 4);
                double x_predicted = x + h * derivative1;
                
                // Второй шаг (коррекция)
                double derivative2 = x_predicted - Math.Pow(x_predicted, 4);
                x = x + h * 0.5 * (derivative1 + derivative2);
                
                t = t + h;
                results.Add(x);
            }

            return results;
        }
    }
}
