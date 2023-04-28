using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dars_4
{
    internal class Program
    {
        static void Main(string[] args)

        { 
            TeslaX tesla = new TeslaX("Tesla Y",12.500m,23,4,7);
            tesla.drive();
        }
        class Car
        {
            public string Model { get; set; }
            public decimal Price { get; set; }
            public Car (string model, decimal price)
            {
                this.Model = model;
                this.Price = price;
            }
            public void drive()
            {
                Console.WriteLine(Model + " is driving...");
            }
        }
        class ExpensiveCar : Car
        {
            public double Battery { get; set; }
            public ExpensiveCar(string name, decimal price, double battery)
                :base (name,price)
            {
                Battery = battery;
            }           
        }
        class Tesla : ExpensiveCar
        {
            public double Version { get; set; }
            public Tesla(string model,decimal price, double battery, double version)
             : base(model,price, battery)
            {
                Version = version;
            }
        }
        class TeslaY : Tesla
        {
            public int YNumber { get; set; }
            public TeslaY(string model, decimal price, double battery,double version, int yNumber)
            : base(model, price, battery, version)
            {
                YNumber = yNumber;
            }
        }
        class TeslaX : Tesla
        {
            public int XNumber { get; set; }
            public TeslaX(string model, decimal price, double battery, double version, int xNumber)
           : base(model, price, battery, version)
            {
                XNumber = xNumber;
            }
        }       
    }
}
