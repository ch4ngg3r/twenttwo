using System;

namespace twenttwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 4 задание

            IVehicle[] vehicles = new IVehicle[]
            {
                new Car("BMW ", "M4 "),
                new Bicycle("какой то ", "велик")
            };


            foreach (var vehicle in vehicles)
            {
                vehicle.Start();  
                vehicle.Stop();  
                vehicle.Fuel();   
                Console.WriteLine("--------------------------------");  
            }
        }

        // 1 задание
        public interface IVehicle
        {
            void Start();
            void Stop();
            void Fuel();
        }

        // 2 задание
        public abstract class Vehicle : IVehicle
        {
            public string Brand { get; set; }
            public string Model { get; set; }
            public int FuelLevel { get; set; }

            public virtual void Fuel()
            {
                FuelLevel += 52; 
                Console.WriteLine(FuelLevel + " столько уровень топлива");
            }

            public abstract void Start();
            public abstract void Stop();
        }

        // 3 задание
        public class Car : Vehicle
        {
            public Car(string brand, string model)
            {
                Brand = brand;
                Model = model;
                FuelLevel = 0;
            }

            public override void Start()
            {
                Console.WriteLine(Brand + Model + "машина готова");
            }

            public override void Stop()
            {
                Console.WriteLine(Brand + Model + "машина стоит");
            }
        }

        public class Bicycle : Vehicle
        {
            public Bicycle(string brand, string model)
            {
                Brand = brand;
                Model = model;
                FuelLevel = 0;
            }

   
            public override void Fuel()
            {
                Console.WriteLine("заправка для велика не нужна :D");
            }

            public override void Start()
            {
                Console.WriteLine(Brand + Model + " велик готов");
            }

            public override void Stop()
            {
                Console.WriteLine(Brand + Model + " велик стоит");
            }
          
        }
      
    }

}
