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
    public partial class Form1 : Form
    {
        private string buttonName1;

        public Form1(string buttonName1)
        {
            InitializeComponent();
            this.buttonName1 = buttonName1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            
            MessageBox.Show("Successfully Login...");

            switch (buttonName1)
            {
                case "button1":
                    

                        Form3 form3 = new Form3();
                        form3.Show();
                        // Optionally, hide Form2
                        this.Hide();
                        break;
                    

                case "button2":
                    

                        Form21 form21 = new Form21();
                        form21.Show();
                        // Optionally, hide Form2
                       // this.Hide();
                        break;
                    

                case "button3":
                    

                        Form7 form7 = new Form7();
                        form7.Show();
                        // Optionally, hide Form2
                       // this.Hide();
                        break;
                    
            }

        }
    }
}
