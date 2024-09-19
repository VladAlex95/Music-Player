using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music_Player
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] cale, fisiere;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            axWindowsMediaPlayer.URL = cale[listBox1.SelectedIndex];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSelectSongs_Click(object sender, EventArgs e)
        {
           OpenFileDialog ofb =  new OpenFileDialog();
            ofb.Multiselect = true;
            if (ofb.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                fisiere = ofb.SafeFileNames;
                cale = ofb.FileNames;
                for (int i =0;i<fisiere.Length;i++)
                {
                    listBox1.Items.Add(fisiere[i]); 
                }
            }

        }
    }
}
