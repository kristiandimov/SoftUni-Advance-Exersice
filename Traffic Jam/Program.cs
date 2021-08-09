using System;
using System.Collections;
using System.Collections.Generic;

namespace Traffic_Jam
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();

            Queue<string> cars = new Queue<string>();
            int count = 0;

            while (command.ToLower() != "end")
            {
                if (command.ToLower() == "green")
                {
                    for (int i = 0; i < n; i++)
                    {
                        if (cars.Count > 0)
                        {
                            Console.WriteLine($"{cars.Dequeue()} passed!");
                            count++;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                else
                {
                    cars.Enqueue(command);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"{count} cars passed the crossroads.");
        }
    }
}
