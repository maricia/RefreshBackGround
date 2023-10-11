using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.Drawing.Imaging;

namespace RefreshBackGround
{
    public partial class SataliteImages : Form
    {
        private readonly string myPath = @"C:\BackGroundImage\10000x6000.jpg";

        public SataliteImages()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void fillInLabels()
        {
            
            label12.Text = File.GetLastWriteTime(myPath).ToString();
            Rootobject rootobject = new Rootobject();
            var name = rootobject.sources.ToString();
        }

        
    }
}
