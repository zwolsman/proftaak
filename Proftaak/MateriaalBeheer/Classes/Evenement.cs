using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MateriaalBeheer.Classes
{
    public class Evenement
    {
        public int ID { get; set; } = -1;
        public string Name { get; set; }
        public List<Material> material { get; set; }

        public Evenement()
        {
            material = new List<Material>();
        }

        public void AddMaterial(Material m)
        {
            material.Add(m);
        }
    }
}
