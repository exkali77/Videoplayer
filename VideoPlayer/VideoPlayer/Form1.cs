using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace VideoPlayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Media player";
            openFileDialog1.Filter = "Mediaoynatıcısı(* .mp4)|*.mp4";
            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                axWindowsMediaPlayer3.URL = openFileDialog1.FileName;
               
            }
        }
     
    }
}
