using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROGECT
{
    public partial class MENU : Form
    {
        public MENU()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login f = new Login();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
           Add_a_new_client a = new Add_a_new_client();
            a.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
                this.Hide();
             Add_a_new_product a = new Add_a_new_product();
            a.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_a_new_salle a = new Add_a_new_salle();
            a.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_a_new_user a = new Add_a_new_user();
            a.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
           Product_management a = new Product_management();
            a.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Client_management c = new Client_management();
            c.Show();
        }

        private void MENU_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }
    }
}
