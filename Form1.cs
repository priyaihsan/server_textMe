using ServiceTextMe;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerTextMe
{
    public partial class Form1 : Form
    {
        private ServiceHost Host;
        public Form1()
        {
            InitializeComponent();
        }

        private void btOn_Click(object sender, EventArgs e)
        {
            Host = new ServiceHost(typeof(Service1));
            txOnOff.Text = "Server ON";
            txDes.Text = "Klik OFF untuk Mematikan Server";
            Host.Open();
            btOn.Enabled = false;
            btOff.Enabled = true;
        }

        private void btOff_Click(object sender, EventArgs e)
        {
            btOn.Enabled = true;
            btOff.Enabled = false;
            Host.Close();
            txOnOff.Text = "Server OFF";
            txDes.Text = "klik ON untuk menjalankan Server";
        }
    }
}
