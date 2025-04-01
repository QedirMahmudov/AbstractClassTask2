using AbstractClass2.Models;

namespace AbstractClass2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.FactoryName = "Deneme";
            car.Model = "Bmw";
            car.Color = "Black";
            car.DriveTime = 2;
            car.DrivePath = 100;
            car.DoorCount = 5;
            car.IsElectricCar = false;
            car.GetInfo();

            Console.WriteLine("----------------");


            car.DefineNatureHarmness();
            Console.WriteLine("---------------");

            Console.WriteLine(car.ToString());

            Bicycle bicycle = new Bicycle();
            bicycle.DefineNatureHarmness();
        }
    }
}
