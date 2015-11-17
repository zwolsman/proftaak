﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            foreach (MessageInstance message in e.NewItems)
            {
                MessageControl control = new MessageControl(message);
                control.AutoSize = true;
                control.Dock = DockStyle.Top;
                flowLayoutPosts.Controls.Add(control);
               
            }
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
            MessageInstance message = new MessageInstance
            {
                Datum = DateTime.Now,
                Report = txtMessage.Text,
                Title = txtTitle.Text,
                MediaAccount = Globals.Account.ID,
                Category = ((CategoryInstance)comboTreeBox1.SelectedNode.Tag).ID
            };

            if (DatabaseManager.InsertItem(message))
            {
                Messages.Add(message);
            }

        }
    }
}