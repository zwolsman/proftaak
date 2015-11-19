using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MateriaalBeheer.Classes
{
    public class LeaseMaterial
    {
        public string RFID { get; set; }
        public int Item { get; set; }
        public DateTime LeaseDate { get; set; } = DateTime.Now;

        public bool EqualsPrimairy(LeaseMaterial lm)
        {
            if (lm == null)
                return false;
            if (this.RFID.Equals(lm.RFID) && this.Item == lm.Item)
                return true;
            return false;
        }
    }
}
