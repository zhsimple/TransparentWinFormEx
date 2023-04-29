using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using System.Reflection;

namespace Tester
{
    public partial class Form2 : Form
    {
        private void Form2_Load(object sender, EventArgs e)
        {
            //lens of username must >=2;
            bool ok = System.Windows.FormsEx.GraphicsEx.Register("hm", "RR5cqCV4M9idzhhoBuGSMw==1");
            if (!ok) Console.WriteLine("You are not registered! you can try this in a few days!");

            treeViewEx1.ExpandAll();
            try
            {
                string resourceName = "Tester.Resources.rtf1.rtf";
                using (Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resourceName))
                {
                    richTextBoxEx2.Rtf = new StreamReader(stream).ReadToEnd();
                }
                
                panelEx2.Location = new Point(panelEx2.Location.X, panelEx5.Height);
                timer1.Enabled = true;
            }
            catch (Exception ex)
            {
            }
        }

        public Form2()
        {
            InitializeComponent();
         }


        private void buttonEx1_Click(object sender, EventArgs e)
        {
            if (panelEx1.Location.X < 600)
                panelEx1.Location = new Point(panelEx1.Location.X + 10, panelEx1.Location.Y);
            else
                panelEx1.Location = new Point(10, panelEx1.Location.Y);
        }


        private void switchEx4_CheckedChanged(object sender, EventArgs e)
        {
            if (switchEx4.Checked)
            {
                treeViewEx1.ShowType = System.Windows.FormsEx.TreeViewEx.ShowTypeEnum.Triangle;
            }
            else
            {
                treeViewEx1.ShowType = System.Windows.FormsEx.TreeViewEx.ShowTypeEnum.MinusPlus;
            }
        }

        private void progressBarEx17_ValueChanged(object sender, EventArgs e)
        {
            progressBarEx11.Value = progressBarEx9.Value = progressBarEx17.Value;
            progressBarEx14.Value = progressBarEx16.Value = progressBarEx17.Value;
            progressBarEx1.Value = progressBarEx2.Value = progressBarEx17.Value;
        }

        private void buttonEx1_Click_2(object sender, EventArgs e)
        {
            listViewEx1.BeginUpdate();
            for (int i = 0; i < 500; i++)
            {
                ListViewItem item = new ListViewItem("item" + i);
                item.SubItems.Add("hello" + i);
                item.SubItems.Add("world" + i);
                listViewEx1.Items.Add(item);
            }
            listViewEx1.EndUpdate();
        }

        private void buttonEx2_Click_2(object sender, EventArgs e)
        {
            listViewEx1.Items.Clear();
        }

        private void trackBarEx1_ValueChanged(object sender, EventArgs e)
        {
            listViewEx1.HeadHeight = trackBarEx1.Value;
        }

        private void trackBarEx2_ValueChanged(object sender, EventArgs e)
        {
            listViewEx1.ItemHeight = trackBarEx2.Value;

        }

        private void trackBarEx5_ValueChanged(object sender, EventArgs e)
        {
            panelEx1.BackColor = Color.FromArgb(trackBarEx5.Value * 20, panelEx1.BackColor);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Point pt = panelEx2.Location;
            pt.Y -= 2;

            if (pt.Y + panelEx2.Height > 0)
            {
                panelEx2.Location = pt;
            }
            else
            {
                panelEx2.Location = new Point(panelEx2.Location.X, panelEx5.Height);
            }

        }

        private void tabControlEx1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlEx1.SelectedIndex == 0)
            {
                timer1.Enabled = true;
            }
            else
            {
                timer1.Enabled = false;
            }
        }

        private void buttonEx42_Click(object sender, EventArgs e)
        {
            panelEx3.BackgroundImageLayout = ImageLayout.None;
        }

        private void buttonEx41_Click(object sender, EventArgs e)
        {
            panelEx3.BackgroundImageLayout = ImageLayout.Tile;
        }

        private void buttonEx39_Click(object sender, EventArgs e)
        {
            panelEx3.BackgroundImageLayout = ImageLayout.Center;
        }

        private void buttonEx37_Click(object sender, EventArgs e)
        {
            panelEx3.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void buttonEx35_Click(object sender, EventArgs e)
        {
            panelEx3.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBoxEx1.Items.Clear();
            checkedListBoxEx1.Items.Clear();
        }

        private void linkLabelEx4_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://paypal.me/zhsimple?country.x=C2&locale.x=zh_XC");
            }
            catch (Exception ex)
            {
            }

        }
    }
}
