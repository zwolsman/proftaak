using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MateriaalBeheer.Classes
{
    class LeaseMaterial
    {
        public string RFID { get; set; }
        public int Item { get; set; }
        public DateTime LeaseDate { get; set; } = DateTime.Now;
    }
}
