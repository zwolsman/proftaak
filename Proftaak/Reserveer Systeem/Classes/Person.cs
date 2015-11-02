using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserveer_Systeem
{
    class Person : IEquatable<Person>
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public Person() { }

        public Person(string firstname, string lastname)
        {
            Firstname = firstname;
            Lastname = lastname;
        }

        public bool Equals(Person other)
        {
            return this.ToString() == other.ToString();
        }

        public override string ToString()
        {
            return $"{Firstname} {Lastname}";
        }
    }
}
