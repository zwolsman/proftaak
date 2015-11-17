using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaSysteem
{
    public class MessageInstance
    {
        public int ID { get; set; } = -1;

        public int MediaAccount { get; set; }
        public int? Media { get; set; }

        public int? Message { get; set; }

        public int Category { get; set; } = 0;
        public DateTime Datum { get; set; }
        public string Report { get; set; }
        public string Title { get; set; }
    }
}
