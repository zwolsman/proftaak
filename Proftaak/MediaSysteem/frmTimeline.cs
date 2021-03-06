﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseLibrary;

namespace MediaSysteem
{
    public partial class frmTimeline : frmBase
    {
        readonly ObservableCollection<MessageInstance> Messages = new ObservableCollection<MessageInstance>(); 
        public frmTimeline()
        {
            InitializeComponent();
            if (!string.IsNullOrEmpty(Globals.Account.Picture))
                picProfile.ImageLocation = Globals.Account.Picture;
            Messages.CollectionChanged += Messages_CollectionChanged;
            
            
            InitTimeline();
            InitCategories();

            if (comboTreeBox1.Nodes.Count > 0)
                comboTreeBox1.SelectedNode = comboTreeBox1.AllNodes.First();
        }

        private void InitCategories()
        {
            foreach (CategoryInstance category in DatabaseManager.GetItems<CategoryInstance>())
            {
                if (category.Category != null)
                {
                    foreach (var node in comboTreeBox1.AllNodes)
                    {
                        CategoryInstance tag = node.Tag as CategoryInstance;
                        if (tag.ID == category.Category) { 
                            node.Nodes.Add(new ComboTreeNode(category.Name) { Tag = category });
                            break;
                        }
                    }
                    continue;
                }
                comboTreeBox1.Nodes.Add(new ComboTreeNode(category.Name) {Tag = category});
            }
/*
            ComboTreeNode node = new ComboTreeNode("Wijven");
            node.Nodes.Add(new ComboTreeNode("Naakt"));
            node.Nodes.Add(new ComboTreeNode("Bikini"));
            comboTreeBox1.Nodes.Add(node);*/
        }

        private void Messages_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            if(e.NewItems != null)
                foreach (MessageInstance message in e.NewItems)
                {
                    MessageControl control = new MessageControl(message)
                    {
                        AutoSize = true,
                        Dock = DockStyle.Top
                    };

                    control.CommentPostedHandler += CommentPostedHandler;
                    control.MessageDeleteHandler += MessageDeleteHandler;
                    flowLayoutPosts.Controls.Add(control);
                }

          
        }

        private void MessageDeleteHandler(object sender, MessageInstance messageInstance)
        {
            Messages.Remove(messageInstance);
            foreach (MessageControl control in flowLayoutPosts.Controls)
            {
                if (control.Message.ID == messageInstance.ID)
                    flowLayoutPosts.Controls.Remove(control);
            }
        }

        private void CommentPostedHandler(object sender, MessageInstance messageInstance)
        {
            DatabaseManager.InsertItem(messageInstance);
            messageInstance = DatabaseManager.ContainsItem(messageInstance, new[] {"MediaAccount", "Category", "Title", "Report"});
            Messages.Add(messageInstance);
        }

        private void InitTimeline()
        {
            var messages = DatabaseManager.GetItems<MessageInstance>().ToList();
            messages.Sort((a, b) => b.Datum < a.Datum ? -1 : (b.Datum > a.Datum ? 1 : 0));
            foreach (MessageInstance m in messages)
            {
                if (!Messages.Contains(m))
                {
                    Messages.Add(m);
                }
            }
        }
        private void btnPost_Click(object sender, EventArgs e)
        {
            if (File.Exists("filter.txt"))
            {
                string[] filter =  File.ReadAllLines("filter.txt");
                string[] words = txtMessage.Text.Split(' ');

                StringBuilder msg = new StringBuilder();

                foreach (string word in words)
                {

                    if (filter.Contains(word.ToUpper()))
                        msg.Append("*** ");
                    else
                        msg.Append(word + " ");
                }

                txtMessage.Text = msg.ToString();
            }

            MessageInstance message = new MessageInstance
            {
                Datum = DateTime.Now,
                Report = txtMessage.Text,
                Title = txtTitle.Text,
                MediaAccount = Globals.Account.ID,
                Category = ((CategoryInstance)comboTreeBox1.SelectedNode.Tag).ID
            };
            if (AttachedPicture)
            {
                
                Media media = new Media() {Url = lblPath.Text};
                if (DatabaseManager.ContainsItem(media, new[] {"Url"}) == null)
                {
                    DatabaseManager.InsertItem(media);
                }
                media = DatabaseManager.ContainsItem(media, new[] { "Url" });
                message.Media = media.ID;
            }

         

            if (DatabaseManager.InsertItem(message))
            {
                message = DatabaseManager.ContainsItem(message, new[] { "MediaAccount", "Category", "Title", "Report" });
                Messages.Add(message);
                txtMessage.Clear();
                txtTitle.Clear();
                AttachedPicture = false;
            }

        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            new frmProfile().ShowDialog(this);
            if (!string.IsNullOrEmpty(Globals.Account.Picture))
                picProfile.ImageLocation = Globals.Account.Picture;
            foreach(MessageControl control in flowLayoutPosts.Controls)
                control.Reload();
        }

        private bool AttachedPicture = false;
        private void btnAddImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "";

                ImageCodecInfo[] codecs = ImageCodecInfo.GetImageEncoders();
                string sep = string.Empty;

                foreach (var c in codecs)
                {
                    string codecName = c.CodecName.Substring(8).Replace("Codec", "Files").Trim();
                    ofd.Filter = string.Format("{0}{1}{2} ({3})|{3}", ofd.Filter, sep, codecName, c.FilenameExtension);
                    sep = "|";
                }

                ofd.Filter = string.Format("{0}{1}{2} ({3})|{3}", ofd.Filter, sep, "All Files", "*.*");

                ofd.DefaultExt = ".png";
                ofd.Multiselect = false;
                if (ofd.ShowDialog(this) == DialogResult.OK)
                {
                    lblPath.Text = ofd.FileName;
                    AttachedPicture = true;
                }
                else
                {
                    AttachedPicture = false;
                }
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Close();
            Globals.Account = null;
        }
    }
}
