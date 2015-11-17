using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Phidgets;
using Phidgets.Events;
using DatabaseLibrary;
using Toegangscontrole.Classes;
using System.Timers;
using System.Diagnostics;

namespace Toegangscontrole
{
    public partial class frmToegangsControle : Form
    {
        private RFID rfid;
        private System.Timers.Timer timer;
        private Evenement evenement;

        private const string INFO = "Houd uw pas voor de lezer";
        private const string ERROR = "Er is iets fout gegaan. Probeer het opnieuw.";
        private const string WELKOM = "Welkom op het evenement terrein";
        private const string TOTZIENS = "Prettige dag en tot de volgende keer";

        public frmToegangsControle(Evenement e)
        {
            InitializeComponent();
            lblInfo.Text = INFO;
            timer = new System.Timers.Timer(2000);
            timer.Elapsed += OnTimer;
            timer.AutoReset = false;
            timer.Enabled = true;
            evenement = e;
            Start();
        }

        public void Start()
        {
            try
            {
                Console.WriteLine("Trying to connect to RFIDscanner...");
                rfid = new RFID();
                rfid.Error += new ErrorEventHandler(rfid_Error);
                rfid.Tag += new TagEventHandler(rfid_Tag);
                rfid.open();
                rfid.waitForAttachment();
                rfid.Antenna = true;
                rfid.LED = true;
                Console.WriteLine("Connected");
            }
            catch (PhidgetException ex)
            {
                Console.WriteLine(ex.Description);
            }
        }

        private void rfid_Tag(object sender, TagEventArgs e)
        {
            Debug.WriteLine("Event fired by RFID: " + e.Tag);
            string tag = e.Tag;
            //Debug.WriteLine("Last RFID: " + rfid.LastTag);
            string s = ERROR;
            //Get preson this tag belongs to and return that person with DatabaseManager
            try {
                Person p = DatabaseManager.GetPerson<Person>(tag);
                if(p.ChangePresence())
                {
                    s = WELKOM;
                }
                else
                {
                    s = TOTZIENS;
                }
                DatabaseManager.UpdateItem<Person>(p);
                pictureBox1.BackColor = Color.Green;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                pictureBox1.BackColor = Color.Red;
            }
            lblInfo.Text = s;
            timer.Start();
        }

        private void rfid_Error(object sender, ErrorEventArgs e)
        {
            Console.WriteLine("RFID error: " + e.Description);
        }

        private void OnTimer(object sender, ElapsedEventArgs e)
        {
            pictureBox1.BackColor = Control.DefaultBackColor;
            SetText(INFO);
        }

        private void SetText(string text)
        {
            if (lblInfo.InvokeRequired)
            {
                lblInfo.Invoke(new Action(() => lblInfo.Text = text));
            }
            else
            {
                lblInfo.Text = text;
            }
        }

        private void lblInfo_SizeChanged(object sender, EventArgs e)
        {
            lblInfo.Left = (this.ClientSize.Width - lblInfo.Size.Width) / 2;
        }
    }
}
