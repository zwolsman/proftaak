using System;

namespace EvenementBeheerSysteem
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
    }
}