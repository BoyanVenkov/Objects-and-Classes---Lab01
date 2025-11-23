class Program
{
    class Car
    {
        public Car(string brand, string model, int horsePower)
        {
            Brand = brand;
            Model = model;
            HorsePower = horsePower;
        }

        public string Brand { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }

    }
    class Truck
    {
        public Truck(string brand, string model, int weigth)
        {
            Brand = brand;
            Model = model;
            Weigth = weigth;
        }

        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weigth { get; set; }


    }
    class Catalog
    {
        List<Catalog> Cars { get; set; }
        List<Catalog> Trucks { get; set; }

    }

    static void Main()
    {
        string[] input = Console.ReadLine().Split("/").ToArray();
        List<Car> cars = new List<Car>();
        List<Truck> trucks = new List<Truck>();
        while (true)
        {
            if (input[0] == "end")
            {
                break;
            }
            if (input[0] == "Car")
            {
                string brand = input[1];
                string model = input[2];
                int horsePower = int.Parse(input[3]);
                Car car = new Car(brand, model, horsePower);
                cars.Add(car);
            }
            else if (input[0] == "Truck")
            {
                string brand = input[1];
                string model = input[2];
                int weigth = int.Parse(input[3]);
                Truck truck = new Truck(brand, model, weigth);
                trucks.Add(truck);
            }
            input = Console.ReadLine().Split("/").ToArray();
        }
        cars = cars.OrderBy(c => c.Brand).ToList();
        trucks = trucks.OrderBy(t => t.Brand).ToList();

        Console.WriteLine("Cars:");
        foreach (var car in cars)
        {
            Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");

        }
        if (trucks.Count > 0)
        {
            Console.WriteLine("Trucks:");
            foreach (var truck in trucks)
            {
                Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weigth}kg");
            }
        }
    }
}