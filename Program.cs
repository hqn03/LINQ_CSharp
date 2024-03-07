using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //Tao list car
            List<Car> cars = new List<Car>()
            {
                new Car("Toyota", "Camry", 2022, 25000, "Midsize"),
                new Car("Honda", "Civic", 2023, 22000, "Compact"),
                new Car("Maserati", "GranTurismo", 2020, 150000, "Luxury"),
                new Car("BMW", "3 Series", 2022, 40000, "Luxury"),
                new Car("Toyota", "Supra", 2020, 50000, "Sports"),
                new Car("Toyota", "MR2", 1988, 10000, "Sports"),
                new Car("Honda", "Prelude", 1985, 10000, "Sports"),
                new Car("Lamborghino", "Huracan", 2020, 200000, "Supercar"),
                new Car("Ferrari", "488GTB", 2020, 245000, "Supercar"),
            };

            //Tao list truck
            List<Truck> trucks = new List<Truck>()
            {
                new Truck("Kenworth", "T680", 2022, 150000, 80000,"PACCAR"),
                new Truck("Peterbilt", "579", 2023, 155000, 75000,"PACCAR"),
                new Truck("Volvo", "VNL", 2021, 160000, 80000,"Volvo"),
                new Truck("Freightliner", "Cascadia", 2024, 165000, 85000,"Daimler"),
                new Truck("International", "LT Series", 2022, 55000, 18500,"Navistar"),
                new Truck("Mack", "Anthem", 2023, 155000, 80000,"Volvo"),
                new Truck("Western Star", "5700XE", 2022, 170000, 90000,"Daimler"),
                new Truck("Himo", "XLSeries", 2024, 145000, 70000, "Toyota")
            };

            Console.WriteLine("2a. Hiển thị các xe có giá trong khoảng 100.000 đến 250.000");
            Console.WriteLine("+---------------+---------------+----------+----------+----------+");
            Console.WriteLine("|      Make     |     Model     |   Year   |  Price   |  Segment |");
            Console.WriteLine("+---------------+---------------+----------+----------+----------+");
            var filterdPrice = cars.Where(c => c.price > 100000 && c.price < 250000);
            foreach(Car car in filterdPrice)
                Console.WriteLine("|{0,-15}|{1,-15}|{2,-10}|{3,10}|{4,-10}|",car.make,car.model,car.year,car.price+" $",car.segment);
            Console.WriteLine("+---------------+---------------+----------+----------+----------+\n");

            Console.WriteLine("2b. Các xe có năm sản xuất > 1990");
            Console.WriteLine("+---------------+---------------+----------+----------+----------+");
            Console.WriteLine("+---------------+---------------+----------+----------+----------+");
            Console.WriteLine("|      Make     |     Model     |   Year   |  Price   |  Segment |");
            Console.WriteLine("+---------------+---------------+----------+----------+----------+");
            var filteredYear = cars.Where(c => c.year > 1990);
            foreach (Car car in filteredYear)
                Console.WriteLine("|{0,-15}|{1,-15}|{2,-10}|{3,10}|{4,-10}|", car.make, car.model, car.year, car.price + " $", car.segment);
            Console.WriteLine("+---------------+---------------+----------+----------+----------+\n");


            Console.WriteLine("2c. Gom các xe theo hãng sản xuất, tính tổng giá trị theo nhóm");
            var groupsMake = cars.GroupBy(c => c.make);
            foreach(var group in groupsMake)
            {
                Console.WriteLine($"Make: {group.Key}");
                Double total = 0;
                Console.WriteLine("\t+---------------+----------+----------+");
                Console.WriteLine("\t|     Model     |   Year   |  Price   |");
                Console.WriteLine("\t+---------------+----------+----------+");
                foreach (Car car in group)
                {
                    Console.WriteLine("\t|{0,-15}|{1,-10}|{2,10}|", car.model, car.year, car.price + " $");
                    total += car.price;
                }
                Console.WriteLine("\t+---------------+----------+----------+");
                Console.WriteLine("\t|{0,-26}|{1,10}|", "Total".PadLeft(15), total + " $");
                Console.WriteLine("\t+---------------+----------+----------+\n");
            }

            Console.WriteLine("3a. Hiển thị danh sách Truck theo thứ tự năm sản xuất mới nhất");
            var filteredTruckYear = trucks.OrderByDescending(t => t.year);
            Console.WriteLine("+---------------+----------+----------+----------+----------+----------+");
            Console.WriteLine("|      Make     |  Model   |   Year   |  Price   |  Towing  |  Parent  |");
            Console.WriteLine("+---------------+----------+----------+----------+----------+----------+");
            foreach (Truck truck in filteredTruckYear)
                Console.WriteLine("|{0,-15}|{1,-10}|{2,10}|{3,10}|{4,10}|{5,-10}|", truck.make, truck.model, truck.year, truck.price + " $",truck.towingCapacity+" lb",truck.parent);
            Console.WriteLine("+---------------+----------+----------+----------+----------+----------+\n");

            Console.WriteLine("3c. Hiển thị tên cty chủ quản của Truck");
            var groupsParent = trucks.GroupBy(t => t.parent);
            foreach(var group in groupsParent)
            {
                Console.WriteLine($"Parent : {group.Key }");
                Console.WriteLine("\t+---------------+----------+----------+----------+----------+");
                Console.WriteLine("\t|      Make     |  Model   |   Year   |  Price   |  Towing  |");
                Console.WriteLine("\t+---------------+----------+----------+----------+----------+");
                foreach (Truck truck in group)
                    Console.WriteLine("\t|{0,-15}|{1,-10}|{2,10}|{3,10}|{4,10}|", truck.make, truck.model, truck.year, truck.price + " $", truck.towingCapacity + " lb");
                Console.WriteLine("\t+---------------+----------+----------+----------+----------+\n");
            }
            Console.ReadKey();
        }
    }
}
