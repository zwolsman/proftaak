﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MateriaalBeheer.Classes
{
    class ReservationMaterial
    {
        public string RFID { get; set; }
        public int Item { get; set; }
        public DateTime ReservationDate { get; set; } = DateTime.Now;
    }
}
