using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Phidgets;
using Phidgets.Events;
using DatabaseLibrary;

namespace MateriaalBeheer.Classes
{
    public static class Rfid
    {
        private static RFID rfid;
        private static string tag;
        private static bool started = false;

        public static void Start()
        {
            try
            {
                rfid = new RFID();
                tag = string.Empty;
                rfid.Error += new ErrorEventHandler(rfid_Error);
                rfid.Tag += new TagEventHandler(rfid_Tag);
                rfid.TagLost += new TagEventHandler(rfid_TagLost);
                rfid.open();
                rfid.waitForAttachment();
                rfid.Antenna = true;
                rfid.LED = true;
                started = true;
            }
            catch (PhidgetException ex)
            {
                Console.WriteLine(ex.Description);
            }
        }

        static void rfid_Error(object sender, ErrorEventArgs e)
        {
            Console.WriteLine(e.Description);
        }

        static void rfid_Tag(object sender, TagEventArgs e)
        {
            tag = e.Tag;
        }

        static void rfid_TagLost(object sender, TagEventArgs e)
        {
            tag = string.Empty;
        }

        public static Boolean Rent(Item i, Boolean beschikbaarMateriaalWeergeven)
        {
            if (!started)
                Start();
            if (!tag.Equals(string.Empty))
            {
                RFIDPerson rp = new RFIDPerson();
                rp.RFID = tag;
                if (DatabaseManager.ContainsItem(rp, new [] {"RFID"}).RFID.Equals(rp.RFID))
                {
                    //Niet geheel veilig maar oke
                    if (!beschikbaarMateriaalWeergeven)
                    {
                        ReservationMaterial rm = new ReservationMaterial()
                        {
                            RFID = rp.RFID,
                            Item = i.ID
                        };
                        DatabaseManager.DeleteDate(rm);
                    }
                    LeaseMaterial lm = new LeaseMaterial()
                    {
                        RFID = rp.RFID,
                        Item = i.ID
                    };
                    DatabaseManager.InsertItem<LeaseMaterial>(lm);
                    return true;
                }
            }
            return false;
        }
    }
}
