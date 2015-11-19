using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserveer_Systeem.Classes
{
    class LeasePlace
    {
        public int ID { get; set; } = -1;
        public int Event { get; set; }

        public int? Account { get; set; }

        public int? Lease { get; set; }

        public int Place { get; set; }

        //public int Lease { get; set; }//Dont need this only causes errors with insertions

        public DateTime Arrival { get; set; }

        public DateTime Departure { get; set; }

    }
}
