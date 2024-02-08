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
    public partial class Form2 : Form
    {
        private string buttonName;

        public Form2(string buttonName)
        {
            InitializeComponent();
            this.buttonName = buttonName;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Successfully Register..");

            switch (buttonName)
            {
                case "button1":
                    {

                    Form1 form1 = new Form1(buttonName);
                    form1.Show();
                    // Optionally, hide Form2
                     this.Hide();
                    break;
                    }

                case "button2":
                    {

                        Form1 form1 = new Form1(buttonName);
                        form1.Show();
                        // Optionally, hide Form2
                         this.Hide();
                        break;
                    }

                case "button3":
                    {

                        Form1 form1 = new Form1(buttonName);
                        form1.Show();
                        // Optionally, hide Form2
                         this.Hide();
                        break;
                    }
            }
                    this.Close();
            
        }
    }
}
