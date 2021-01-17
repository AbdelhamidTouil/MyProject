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
    public partial class Client_management : Form
    {
        DataSet ds = new DataSet();
        SqlDataAdapter da;
        SqlCommandBuilder cb = new SqlCommandBuilder();
        public Client_management()
        {
            InitializeComponent();
        }
        public void RemplireGrid()

        {
            string req = string.Format("select * from CLIENT");
            da = new SqlDataAdapter(req, Class1.cnx);
            da.Fill(ds, "CLIENT");
            dataGridView1.DataSource = ds.Tables["CLIENT"];
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string req = string.Format("select * from CLIENT where NOM_CLIENT='{0}'",textBox1.Text);
            SqlCommand cmd = new SqlCommand(req, Class1.cnx);
            Class1.ouvrire();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            textBox1.Text = "";
            dr.Close();
            Class1.fermer();
        }

        private void Client_management_Load(object sender, EventArgs e)
        {
            RemplireGrid();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MENU m = new MENU();
            m.Show();
            this.Hide();
        }
    }
}
