using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Family family = new Family();
            Person person;

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string name = input[0];
                int age = int.Parse(input[1]);

                person = new Person(name, age);

                family.AddMember(person);
            }


            //Console.WriteLine(family.GetOldest());
            Console.WriteLine(string.Join("\n",family.GetOlderThan()));
        }
    }
}
