using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toegangscontrole.Classes
{
    class Person
    {
        public int ID { get; set; } = -1;
        public int? Account { get; set; } = null;
        public int? Lease { get; set; } = null;
        public string Name { get; set; }
        public string Affix { get; set; }
        public string Surname { get; set; }
        public string MainTenant { get; set; } = "N";
        public string Present { get; set; } = "N";

        /// <summary>
        /// Function to change presence.
        /// Returns true is RFID holder enters the complex and false if he leaves the complex
        /// </summary>
        /// <returns>True if entering complex (changed Present to Yes)</returns>
        public bool ChangePresence()
        {
            if (Present.Equals("N"))
                Present = "Y";
            else
                Present = "N";
            return Present.Equals("Y");
        }

        public override string ToString()
        {
            if(Affix.Equals(""))
                return $"Name:{Name} {Surname}.";
            return $"Name:{Name} {Affix} {Surname}.";
        }
    }
}
