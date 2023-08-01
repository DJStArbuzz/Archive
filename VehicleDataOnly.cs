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
            Console.WriteLine("Введите информацию о машине.");
            Console.WriteLine("Неправильная информация будет изменяться автоматически.");
            // Создаем экземпляр
            Vehicle my_car = new Vehicle();
            // Вносим данные для экземляра my_car
            int num_of_doors, num_of_wheels;
            string model_name, manufacturer;

            Console.Write("Модель - ");
            model_name = Console.ReadLine();

            Console.Write("Производитель - ");
            manufacturer = Console.ReadLine();

            Console.Write("Количество дверей - ");
            try {
                num_of_doors = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Вы вписали не число");
                num_of_doors = 4;
            }

            Console.Write("Количество колес - ");
            try
            {
                num_of_wheels = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Вы вписали не число");
                num_of_wheels = 4;
            }

            my_car.model = model_name;
            my_car.manufacturer = manufacturer;
            my_car.numOfDoors = num_of_doors;
            my_car.numOfWheels = num_of_wheels;
            // Вывод информации
            Console.WriteLine("\nВаша машина:");
            Console.WriteLine($"{my_car.manufacturer} {my_car.model}");
            Console.WriteLine($"С {my_car.numOfDoors} дверями на {my_car.numOfWheels} колесах");
            Console.WriteLine("Конец программы.");
            
        }
    }

}
