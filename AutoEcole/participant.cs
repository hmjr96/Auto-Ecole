using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoEcole
{
    public partial class participant : Form
    {
        public participant()
        {
            InitializeComponent();
        }

        private void gunaSeparator2_Click(object sender, EventArgs e)
        {

        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            AM_Participant d = new AM_Participant();
            d.Show();
        }
    }
}
