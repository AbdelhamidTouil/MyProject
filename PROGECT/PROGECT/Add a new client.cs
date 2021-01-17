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
    public partial class Add_a_new_client : Form
    {
        DataSet ds = new DataSet();
        SqlDataAdapter da;
        public Add_a_new_client()
        {
            InitializeComponent();
        }

        private void Add_a_new_client_Load(object sender, EventArgs e)
        {
            string req = string.Format("select CITY_ID from CITY");
            da = new SqlDataAdapter(req, Class1.cnx);
            da.Fill(ds, "CITY");
            comboBox1.DisplayMember = "CITY_ID";
            comboBox1.ValueMember = "CITY_ID";
            comboBox1.DataSource = ds.Tables["CITY"];


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string req = string.Format("insert into CLIENT values({0},'{1}','{2}',{3},'{4}','{5}') ", comboBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text);
            SqlCommand cmd = new SqlCommand(req, Class1.cnx);
            Class1.ouvrire();
            cmd.ExecuteNonQuery();
            MessageBox.Show("ajouter avec succes");
            Class1.fermer();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MENU m = new MENU();
            m.Show();
        }
    }
}
