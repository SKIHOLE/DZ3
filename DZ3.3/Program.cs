using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            var plane = new Plane(5, 10, 1000000, 800, 2020, 10000, 200);
            Console.WriteLine($"Plane: price={plane.Price}, speed={plane.Speed}, releaseDate={plane.ReleaseDate}, height={plane.Height}, passengerCount={plane.PassengerCount}");

            var ship = new Ship(100, 40, 500000, 50, 2015, "Odessa", 500);
            Console.WriteLine($"Ship: price={ship.Price}, speed={ship.Speed}, releaseDate={ship.ReleaseDate}, homePort={ship.HomePort}, passengerCount={ship.PassengerCount}");

            var car = new Car(700, 10, 20000, 120, 2022, 0, 5);
            Console.WriteLine($"Car: price={car.Price}, speed={car.Speed}, releaseDate={car.ReleaseDate}");
            Console.ReadKey();
        }
    }
    class Vehicle
    {
        public int[,] coordinates = new int[0, 0];
        public int Price { get; set; }
        public int Speed { get; set; }
        public int ReleaseDate { get; set; }
        public Vehicle(int CoordinateX,int CoordinateY, int Price,int Speed ,int ReleaseDate)
        {
            coordinates = new int[CoordinateX, CoordinateY];
            this.Price = Price;
            this.Speed = Speed;
            this.ReleaseDate = ReleaseDate;
        }
    }
    class Plane: Vehicle
    {
        public int Height { get; set; }
        public int PassengerCount { get; set; }

        public Plane(int CoordinateX, int CoordinateY, int Price, int Speed, int ReleaseDate, int Height, int PassengerCount)
            : base(CoordinateX, CoordinateY, Price, Speed, ReleaseDate)
        {
            this.Height = Height;
            this.PassengerCount = PassengerCount;
        }
    }
    class Ship : Vehicle
    {
        public string HomePort { get; set; }
        public int PassengerCount { get; set; }

        public Ship(int CoordinateX, int CoordinateY, int Price, int Speed, int ReleaseDate, string HomePort, int PassengerCount)
            : base(CoordinateX, CoordinateY, Price, Speed, ReleaseDate)
        {
            this.HomePort = HomePort;
            this.PassengerCount = PassengerCount;
        }
    }
    class Car : Vehicle
    {

        public Car(int CoordinateX, int CoordinateY, int Price, int Speed, int ReleaseDate, int Height, int PassengerCount)
            : base(CoordinateX, CoordinateY, Price, Speed, ReleaseDate)
        {
        }
    }
        
}
