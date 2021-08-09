using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    


    public class Car
    {

        public Car(string brand, string model, string horsepower, decimal price)
        {
            this.Brand = brand;
            this.Model = model;
            this.Horsepower = horsepower;
            this.Price = price;
        }

        public string Brand { get; set; }
        public string Model { get; set; }
        public string Horsepower { get; set; }
        public decimal Price { get; set; }


    }
}
