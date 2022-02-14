﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace AutoEcole
{
    public partial class Login : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );
        public Login()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Btn_login_Click(object sender, EventArgs e)
        {
            var user = (from i in Program.autoEcole.users
                        where i.username == txt_user.Text && i.password_ == txt_password.Text
                        select i).ToList();
            if (user.Count == 0)
            {
                MessageBox.Show("user name or password uncorrect!");
            }
            else
            {
                this.Enabled = false;
                Form form = new Dashboard();
                form.Show();
            }
        }
    }
}
