﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace peoject_DB_1
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form8 f8=new Form8();
            f8.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form7 f7=new Form7();
            f7.Show();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form15 form15=new Form15();
            form15.Show();  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deleted successfully..");
        }
    }
}
