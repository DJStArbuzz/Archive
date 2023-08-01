using System;

namespace VehicleDataOnly
{
    public class Vehicle
    {
        public string model;        // Название модели 
        public string manufacturer; // Производитель 
        public int numOfDoors;      // Количество дверей 
        public int numOfWheels;     // Количество колес 
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите информацию о машине");
            // Создаем экземпляр
            Vehicle my_car = new Vehicle();
            // Вносим данные для экземляра my_car
            Console.Write("Модель - ");
            string model_name = Console.ReadLine();

            Console.Write("Производитель - ");
            string manufacturer = Console.ReadLine();

            Console.Write("Количество дверей - ");
            string num_of_doors = Console.ReadLine();

            Console.Write("Количество колес - ");
            string num_of_wheels = Console.ReadLine();

            my_car.model = model_name;
            my_car.manufacturer = manufacturer;
            my_car.numOfDoors = Convert.ToInt32(num_of_doors);
            my_car.numOfWheels = Convert.ToInt32(num_of_wheels);
            // Вывод информации
            Console.WriteLine("\nВаша машина:");
            Console.WriteLine($"{my_car.manufacturer} {my_car.model}");
            Console.WriteLine($"С {my_car.numOfDoors} дверями на {my_car.numOfWheels} колесах");
            Console.WriteLine("Конец программы.");
            
        }
    }

}
