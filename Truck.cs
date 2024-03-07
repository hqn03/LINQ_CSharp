using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_CSharp
{
    class Truck : Vehicle
    {
        public Double towingCapacity { set; get; }
        public String parent { set; get; }
        public Truck(string make, string model, short year, double price, double towingCapacity, string parent) 
            : base(make, model, year, price)
        {
            this.towingCapacity = towingCapacity;
            this.parent = parent;
        }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($" Towing Capacity: {towingCapacity} lbs");
        }
    }
}
