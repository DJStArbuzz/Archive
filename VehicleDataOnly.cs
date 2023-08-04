using System;

namespace VehicleDataOnly
{
    public class Motor
    {
        public int power;           // Мощность
        public double displacement; // Рабочий объем
    }

    public class Vehicle
    {
        public string model;        // Название модели 
        public string manufacturer; // Производитель 
        public int numOfDoors;      // Количество дверей 
        public int numOfWheels;     // Количество колес 
        public Motor motor;
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Motor largeMotor = new Motor();
            largeMotor.power = 230;
            largeMotor.displacement = 4.0;

            Vehicle sonsCar = new Vehicle();
            sonsCar.model = "Cherokee Sport";
            sonsCar.manufacturer = "Jeep";
            sonsCar.numOfDoors = 2;
            sonsCar.numOfWheels = 4;
            sonsCar.motor = largeMotor;

            Console.WriteLine("Рабочий объем равен " + sonsCar.motor.displacement); 
        }
    }

}
