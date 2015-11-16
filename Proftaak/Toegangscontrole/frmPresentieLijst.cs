using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Toegangscontrole.Classes;
using DatabaseLibrary;
using System.Drawing.Printing;

namespace Toegangscontrole
{
    public partial class frmPresentieLijst : Form
    {
        private Evenement evenement;
        private List<Person> persons = new List<Person>();
        private string file = string.Empty;
        private StreamReader fileToPrint;
        private Font printFont;

        public frmPresentieLijst(Evenement e)
        {
            InitializeComponent();
            evenement = e;
            LoadList();
        }

        private void LoadList()
        {
            persons.Clear();
            /*IEnumerable<Person> ip = DatabaseManager.GetPersons<Person>(true, evenement);
            if (ip == null)
                return;
            persons.AddRange(ip);*/
            persons.AddRange(DatabaseManager.GetItems<Person>());
            foreach (Person p in persons)
            {
                listPresence.Items.Add(new ListViewItem(new[]
                {
                    p.Name,
                    p.Affix,
                    p.Surname
                }));
            }
        }

        private void btPrint_Click(object sender, EventArgs e)
        {
            try
            {
                file = Path.GetTempFileName();
                Console.WriteLine(file);
                FileInfo info = new FileInfo(file);
                info.Attributes = FileAttributes.Temporary;
                Console.WriteLine("Attributes set");
                StreamWriter stream = File.AppendText(file);
                Console.WriteLine("Opened streamwriter");
                foreach (Person p in persons)
                {
                    string s = $"{p.Surname}, {p.Name} {p.Affix}";
                    stream.WriteLine(s);
                }
                Console.WriteLine("Finished writing");
                stream.Flush();
                stream.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while making temp file: " + ex.Message);
            }
            printDialog1.AllowSomePages = true;
            printDialog1.ShowHelp = true;
            printDialog1.Document = printDocument1;
            DialogResult result = printDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                fileToPrint = new StreamReader(file);
                printFont = new Font("Arial", 10);
                printDocument1.PrintPage += new PrintPageEventHandler(PrintPage);
                printDocument1.Print();
                fileToPrint.Close();
            }

            try
            {
                if (File.Exists(file))
                {
                    File.Delete(file);
                    Console.WriteLine("Temporary file deleted.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error deleteing Temporary file: " + ex.Message);
            }
        }

        private void PrintPage(object sender, PrintPageEventArgs ev)
        {
            float linesPerPage = 0;
            float yPos = 0;
            int count = 0;
            float leftMargin = ev.MarginBounds.Left;
            float topMargin = ev.MarginBounds.Top;
            string line = null;
            linesPerPage = ev.MarginBounds.Height / printFont.GetHeight(ev.Graphics);
            while (count < linesPerPage && ((line = fileToPrint.ReadLine()) != null))
            {
                yPos = topMargin + (count * printFont.GetHeight(ev.Graphics));
                ev.Graphics.DrawString(line, printFont, Brushes.Black, leftMargin, yPos, new StringFormat());
                count++;
            }
            if (line != null)
                ev.HasMorePages = true;
            else
                ev.HasMorePages = false;
        }

        private void btSave_Click(object sender, EventArgs e)
        {

        }
    }
}
