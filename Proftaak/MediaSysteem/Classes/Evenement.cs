using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaSysteem
{
    public class Evenement
    {
        public int ID { get; set; } = -1;
        public string Name { get; set; }
        public string Location { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Description { get; set; }
        public string Logo { get; set; }
        public string Campingmap { get; set; }

        public Bitmap LoadedLogo { get; set; }
    }
}
