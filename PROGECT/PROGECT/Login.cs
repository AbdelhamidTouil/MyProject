using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROGECT
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int c = 0;
            string req = string.Format(" select * from USERS where USERNAME='{0}'and PSW='{1}' ",TextBox1.Text,TextBox2.Text);
            SqlCommand cmd = new SqlCommand(req,Class1.cnx);
            Class1.ouvrire();
            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                if(TextBox1.Text==dr[0].ToString() && TextBox2.Text==dr[1].ToString())
                {
                    c = 1;
                    break;
                 
                }
                else
                {
                    c = 0;
                }
                
            }
            dr.Close();
            if(c==1)
            {
                this.Hide();
                MENU f = new MENU();
                f.Show();
            }
            else
            {
                MessageBox.Show("your login or password false");
            }
            Class1.fermer();

        }
    }
}
