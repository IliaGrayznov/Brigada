using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Drawing.Text;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConfigForm config = new ConfigForm();
            config.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PingForm pin = new PingForm();
            pin.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TracertForm tracert = new TracertForm();
            tracert.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {   
            ARPForm arp = new ARPForm();
            arp.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            RouteForm route = new RouteForm();
            route.Show();
        }
    }
}
