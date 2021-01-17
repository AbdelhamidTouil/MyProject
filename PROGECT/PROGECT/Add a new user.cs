using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace PROGECT
{
    public partial class Add_a_new_user : Form
    {
        public Add_a_new_user()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string req = string.Format("insert into USERS values('{0}','{1}','{2}') ", textBox1.Text, textBox2.Text, textBox3.Text);
            SqlCommand cmd = new SqlCommand(req, Class1.cnx);
            Class1.ouvrire();
            cmd.ExecuteNonQuery();
            MessageBox.Show("ajouter avec succes");
            Class1.fermer();
        }
    }
}
