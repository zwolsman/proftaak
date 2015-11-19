using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
                rfid.Error += rfid_Error;
                rfid.Tag += rfid_Tag;
                rfid.TagLost += rfid_TagLost;
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

        public static bool Rent(Item i, bool beschikbaarMateriaalWeergeven)
        {
            if (!started)
                Start();
            if (!string.IsNullOrEmpty(tag))
            {
                RFIDPerson rp = new RFIDPerson
            {
                    RFID = tag
                };
                try
                {
                    if (DatabaseManager.ContainsItem(rp, new[] {"RFID"}).RFID.Equals(rp.RFID))
                    {
                        //Niet geheel veilig maar oke
                        if (!beschikbaarMateriaalWeergeven)
                        {
                            ReservationMaterial rm = new ReservationMaterial()
                            {
                                RFID = rp.RFID,
                                Item = i.ID
                            };
                            DatabaseManager.DeleteItem(rm);
                        }
                        LeaseMaterial lm = new LeaseMaterial()
                        {
                            RFID = rp.RFID,
                            Item = i.ID
                        };
                        if (lm.EqualsPrimairy(DatabaseManager.ContainsItem(lm, new[] {"RFID", "Item"})))
                        {
                            DatabaseManager.UpdateItem(lm);
                            ReturnMaterial rm = new ReturnMaterial()
                            {
                                RFID = lm.RFID,
                                Item = i.ID
                            };
                            DatabaseManager.DeleteItem(rm);
                            return true;
                        }
                        DatabaseManager.InsertItem(lm);
                        return true;
                    }
                }
                catch
                {
                    MessageBox.Show("Incorrect RFID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return false;
        }
    }
}
