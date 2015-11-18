using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toegangscontrole.Classes
{
    class Betaling
    {
        public int Event { get; set; }
        public int ID { get; set; }
        public int PlaceID { get; set; }
        public int Placenumber { get; set; }
        public int Amount { get; set; }
        public string Description { get; set; }
        public DateTime PaymentDate { get; set; }
    }
}
