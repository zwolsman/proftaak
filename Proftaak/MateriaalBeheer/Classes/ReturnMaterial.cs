using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MateriaalBeheer.Classes
{
    class ReturnMaterial
    {
        public string RFID { get; set; }
        public int Item { get; set; }
        public DateTime ReturnDate { get; set; } = DateTime.Now;

        internal bool EqualsPrimairy(ReturnMaterial rm)
        {
            if (rm == null)
                return false;
            if (this.RFID.Equals(rm.RFID) && this.Item == rm.Item)
                return true;
            return false;
        }
    }
}
