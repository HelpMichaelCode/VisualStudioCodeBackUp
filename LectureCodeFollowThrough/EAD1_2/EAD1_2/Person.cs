// person
using System;
namespace EAD1_2
{
    public class Person
    {
        private string name;
        private DateTime dob;
        private int age;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public DateTime Dob
        {
            get
            {
                return dob;
            }
            set
            {
                dob = value;
            }

        }

        public int Age
        {
            get
            {
                return DateTime.Now.Year - dob.Year;
            }
        }

        public Person(string name, DateTime dob)
        {
            Name = name;
            Dob = dob;
        }

        public Person(String name) : this(name, DateTime.Now)
        { }

        public Person() : this("", DateTime.Now)
        {
        }

        public override string ToString() => $"Name: {Name}\nAge: {Age}";
    }
}



