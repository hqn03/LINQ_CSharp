using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_CSharp
{
    class Car : Vehicle
    {
        public String segment { set; get; }
        public Car(string make, string model, short year, double price, string segment) 
            : base(make, model, year, price)
        {
            this.segment = segment;
        }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($" Segment: {segment}");
        }
    }
}
