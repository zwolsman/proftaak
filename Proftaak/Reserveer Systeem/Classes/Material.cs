using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserveer_Systeem
{
    public class Material
    {
        public int ID { get; set; } = -1;
        public int Event { get; set; }
        public string Product { get; set; }
        public string Description { get; set; }
        public int PricePD { get; set; }
        public int PricePW { get; set; }
    }
}
