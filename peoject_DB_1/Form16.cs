using System;
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
    public partial class Form16 : Form
    {
        public Form16()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenForm1("button1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenForm1("button2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenForm1("button3");
        }
        private void OpenForm1(string buttonName)
        {
            Form1 form1 = new Form1(buttonName);
            form1.Show();
            // Optionally, hide Form1
            // this.Hide();
        }
    }
}
