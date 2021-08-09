using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Car car;
            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

                string token = data[0];
                string brand = data[1];
                string model = data[2];
                string horsepower = data[3];
                decimal price = decimal.Parse(data[4]);

                car = new Car(brand, model, horsepower, price);

                if (token?.ToLower() == "add")
                {
                    cars.Add(car);
                }
                else if(token?.ToLower() == "remove")
                {
                    cars.Remove(car);
                }            

            }

            foreach (Car item in cars)
            {
                Console.WriteLine($"{item.Brand},{item.Model},{item.Horsepower},{item.Price}");
            }
        }
    }
}
