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

        public static Boolean Rent(Material m)
        {
            if (!tag.Equals(string.Empty))
            {
                RFIDPerson rp = new RFIDPerson();
                rp.RFID = tag;
                if (DatabaseManager.ContainsItem(rp, "RFID").RFID.Equals(rp.RFID))
                {
                    //TODO: execute rent need item number for that
                    //DatabaseManager.InsertItem(LeaseMaterial);//
                    return true;
                }
            }
            return false;
        }
    }
}
