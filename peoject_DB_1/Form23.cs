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
    public partial class Form23 : Form
    {
        public Form23()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Order conformed");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form22 form22 = new Form22();   
            form22.Show();
            this.Close();
        }
    }
}
