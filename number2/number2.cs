namespace number2;
using Car;

class Program
{
    static void Main()
    {
        Car supra = new Car();
        supra.Name = "Supra";
        supra.ProductionYear = 2000;
        supra.MaxSpeed = 300;
        Car rs5 = new Car();
        rs5.Name = "Audi Rs5";
        rs5.ProductionYear = 2021;
        rs5.MaxSpeed = 250;
        Car sl63 = new Car();
        sl63.Name = "Mercedes sl63";
        sl63.ProductionYear = 2020;
        sl63.MaxSpeed = 270;
        Car[] shop = new[] { supra, rs5, sl63 };
        foreach (var car in shop)
        {
            Console.WriteLine($"{car.Name}, {car.MaxSpeed}, {car.ProductionYear}");
        }
        CarComperer.mode = "year";
        Array.Sort(shop, new CarComperer());
        foreach (var car in shop)
        {
            Console.WriteLine($"{car.Name}, {car.MaxSpeed}, {car.ProductionYear}");
        }
    }
}
