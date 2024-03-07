using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_CSharp
{
    class Vehicle
    {
        public String make { set; get; }

        public String model { set; get; }

        public Int16 year { set; get; }
        public Double price { set; get; }

        public Vehicle(string make, string model, short year, double price)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.price = price;
        }

        public virtual void DisplayInfo()
        {
            Console.Write($"Make: {make}, Model: {model}, Year: {year}, Price: {price}");
        }
    }
}
