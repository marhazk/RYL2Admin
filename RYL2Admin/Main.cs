using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RYL2Admin
{
    public partial class Main : Form
    {
        //DNS Aera
        DNSAera dns = new DNSAera();

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

            dns.start();
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            dns.DisposeAll();
            dns.Dispose();
            Application.Exit();
        }

    }
}
