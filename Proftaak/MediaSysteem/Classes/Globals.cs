using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaSysteem
{
    static class Globals
    {
        private static Evenement _evenement;
        public static Evenement SelectedEvenement
        {
            get
            {
                return _evenement;
            }
            set
            {
                _evenement = value;
                OnEvenementChanged(value);
            }
        }

        public static event EventHandler<Evenement> EvenementChanged;

        private static void OnEvenementChanged(Evenement e)
        {
            EvenementChanged?.Invoke(null, e);
        }
    }
}
