using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class Family
    {
        //GoodPractice
        private readonly HashSet<Person> members;

        public Family()
        {
            this.members = new HashSet<Person>();
        }
        
        public void AddMember(Person person)
        {
            this.members.Add(person);
        }

        public Person GetOldest()
            => this.members.OrderByDescending(p => p.Age).FirstOrDefault();
        //{
        //    Person oldest = this.members.OrderByDescending(p => p.Age).FirstOrDefault();          
        //    return oldest;
        //}

        public List<Person> GetOlderThan()
            => this.members.Where(p => p.Age > 30).OrderBy(n => n.Name).ToList();

    }
}
