﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Daraz_V_Convert.BL;
using Daraz_V_Convert.DL;
namespace Daraz_V_Convert.Forms
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.PasswordChar = '*';
                textBox2.PasswordChar = '*';
            }
            else if (!checkBox1.Checked)
            {
                textBox2.PasswordChar = '\0';
                textBox2.PasswordChar = '\0';
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.PasswordChar = '*';
                textBox3.PasswordChar = '*';
            }
            else if (!checkBox1.Checked)
            {
                textBox2.PasswordChar = '\0';
                textBox3.PasswordChar = '\0';
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text!="")
            {
                MessageBox.Show("Please add Username...");
            }
            else if(textBox2.Text!=textBox3.Text)
            {
                MessageBox.Show("Password does not match...");
            }
            else
            {
                User u = new User(textBox1.Text, textBox2.Text);
                UserDL.add_list(u);
                Sign_In.user = u;
                this.Hide();
                UserMenu m = new UserMenu();
                m.Show();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Sign_In a = new Sign_In();
            this.Hide();
            a.Show();
        }
    }
}