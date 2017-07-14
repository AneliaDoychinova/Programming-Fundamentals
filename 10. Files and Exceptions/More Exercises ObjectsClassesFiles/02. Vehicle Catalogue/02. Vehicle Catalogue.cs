using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            var cars = new List<Car>();
            var trucks = new List<Truck>();

            ReadVehicles(cars, trucks);
            PrintVehicles(cars, trucks);
            PrintAverage(cars, trucks);

        }

        private static void PrintAverage(List<Car> cars, List<Truck> trucks)
        {
            var sumCars = 0.0;
            var sumTrucks = 0.0;

            foreach (var car in cars)
            {
                sumCars += car.HorsePower;
            }
            var avgCars = sumCars / cars.Count;
            if (cars.Count==0)
            {
                avgCars = 0;
            }
            Console.WriteLine("Cars have average horsepower of: {0:F2}.",avgCars);

            foreach (var truck in trucks)
            {
                sumTrucks += truck.HorsePower;
            }
            var avgTrucks = sumTrucks / trucks.Count;
            if (trucks.Count == 0)
            {
                avgTrucks = 0;
            }
            Console.WriteLine("Trucks have average horsepower of: {0:F2}.", avgTrucks);

        }

        private static void PrintVehicles(List<Car> cars, List<Truck> trucks)
        {
            var model = Console.ReadLine();
            while (model != "Close the Catalogue")
            {
                if (cars.Select(x => x.Model).Contains(model))
            {
                foreach (var car in cars)
                {
                    if (car.Model == model)
                    {
                        Console.WriteLine("Type: {0}", car.Type);
                        Console.WriteLine("Model: {0}", car.Model);
                        Console.WriteLine("Color: {0}", car.Color);
                        Console.WriteLine("Horsepower: {0}", car.HorsePower);

                    }
                }
            }

            else if (trucks.Select(x => x.Model).Contains(model))
            {
                foreach (var truck in trucks)
                {
                    if (truck.Model == model)
                    {
                        Console.WriteLine("Type: {0}", truck.Type);
                        Console.WriteLine("Model: {0}", truck.Model);
                        Console.WriteLine("Color: {0}", truck.Color);
                        Console.WriteLine("Horsepower: {0}", truck.HorsePower);

                    }
                }
            }
                model = Console.ReadLine();
            }
            
        }

        private static void ReadVehicles(List<Car> cars, List<Truck> trucks)
        {
            var input = Console.ReadLine().Split(' ');

            while (input[0] != "End")
            {
                var type = input[0].ToLower();
                var model = input[1];
                var color = input[2];
                var horsePower = int.Parse(input[3]);

                if (type == "car")
                {
                    var car = new Car
                    {
                        Model = model,
                        Color = color,
                        HorsePower = horsePower
                    };

                    cars.Add(car);
                }
                else
                {
                    var truck = new Truck
                    {
                        Model = model,
                        Color = color,
                        HorsePower = horsePower
                    };

                    trucks.Add(truck);
                }
                input = Console.ReadLine().Split(' ');
            }
        }

        class Car
        {
            public string Type { get; set; }

            public string Model { get; set; }

            public string Color { get; set; }

            public int HorsePower { get; set; }

            public Car()
            {
                Type = "Car";
            }

        }
        class Truck
        {
            public string Type { get; set; }

            public string Model { get; set; }

            public string Color { get; set; }

            public int HorsePower { get; set; }

            public Truck()
            {
                Type = "Truck";
            }
        }
    }
}
