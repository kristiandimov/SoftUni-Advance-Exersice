using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string firstDate = Console.ReadLine();

            string secoundDate = Console.ReadLine();

            DateModifier date = new DateModifier(firstDate,secoundDate);

            Console.WriteLine(date);

        }
    }
}
