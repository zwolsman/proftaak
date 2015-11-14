using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MateriaalBeheer.Classes
{
    public class Payment
    {
        public int ID { get; set; } = -1;
        public int LeasePlace { get; set; }
        public DateTime PaymentDate { get; set; } = DateTime.Now;
        public int Amount { get; set; }
        public string Description { get; set; }
    }
}
