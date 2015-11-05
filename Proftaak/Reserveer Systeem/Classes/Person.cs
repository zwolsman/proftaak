using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserveer_Systeem
{
    class Person : IEquatable<Person>
    {
        public int ID { get; set; } = -1;
        public string Name { get; set; }

        public int Account { get; set; }

        public string Surname { get; set; } = "";

        public string Affix { get; set; } = "";

        public string MainTenant { get; set; } = "N";

        public Person() { }

        public Person(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        public bool Equals(Person other)
        {
            return ToString() == other.ToString();
        }

        public override string ToString()
        {
            return $"{Name} {Surname}";
        }
    }
}
