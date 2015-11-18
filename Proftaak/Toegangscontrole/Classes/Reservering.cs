using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toegangscontrole.Classes
{
    public class Reservering
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Affix { get; set; }
        public string Surname { get; set; }
        public string Bankaccount { get; set; }
        public int ID_LP { get; set; }
        public int Place { get; set; }
        public DateTime Arrival { get; set; }
        public DateTime Departure { get; set; }
        public int Event { get; set; }
    }
}
