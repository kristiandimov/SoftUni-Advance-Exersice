using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class DateModifier
    {
        private int diffrence;

        public DateModifier(string firstDate,string secoundDate)
        {
            DateTime first = DateTime.Parse(firstDate);
            DateTime secound = DateTime.Parse(secoundDate);

            string result = (first - secound).Days.ToString();

            diffrence = Math.Abs(int.Parse(result));

        }

        public override string ToString()
        {
            return $"{diffrence}";
        }

    }
}
