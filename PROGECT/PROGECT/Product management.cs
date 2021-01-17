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
    public partial class Product_management : Form
    {
        DataSet ds = new DataSet();
        SqlDataAdapter da;
        SqlCommandBuilder bc = new SqlCommandBuilder();
        public Product_management()
        {
            InitializeComponent();
        }
     
          public void RemplireGrid()

        {
            string req = string.Format("select * from PRODUIT");
            da = new SqlDataAdapter(req, Class1.cnx);
            da.Fill(ds, "PRODUIT");
            dataGridView1.DataSource = ds.Tables["PRODUIT"];
        }
      


        private void Product_management_Load(object sender, EventArgs e)
        {
            string req = string.Format("select * FROM PRODUIT");
            da = new SqlDataAdapter(req, Class1.cnx);
            da.Fill(ds,"PRO");
            comboBox1.DisplayMember = "ID_PRODUIT";
            comboBox1.ValueMember = "ID_PRODUIT";
            comboBox1.DataSource = ds.Tables["PRO"];
          
            RemplireGrid();
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Add_a_new_product a = new Add_a_new_product();
            this.Hide();
            a.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           foreach(DataGridViewRow  r in dataGridView1.Rows)
            {
                if(dataGridView1.CurrentRow.Selected==true)
                {
                    ds.Tables["PRODUIT"].Rows[dataGridView1.CurrentRow.Index].Delete();
                    bc = new SqlCommandBuilder(da);
                    da.Update(ds, "PRODUIT");
                }
            }
            MessageBox.Show(" information Deleted");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string req = string.Format("select * from PRODUIT where ID_PRODUIT={0}",comboBox1.Text);
            SqlCommand cmd = new SqlCommand(req, Class1.cnx);
            Class1.ouvrire();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            comboBox1.Text = "";
            dr.Close();
            Class1.fermer();
             

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void button4_Click(object sender, EventArgs e)

        {
        //    if (ds.Tables["PRODUIT"] != null)
        //    {
        //        dataGridView1.Rows.Clear();
        //    }
            if (ds.Tables["PRODUIT"].GetChanges()== null)
            {
                MessageBox.Show("veuiller selectionner la colone  que tu  veut modifier");
                return;
            }
            bc = new SqlCommandBuilder(da);
            da.Update(ds, "PRODUIT");

            MessageBox.Show("updeted");
            
           // RemplireGrid();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            MENU m = new MENU();
            m.Show();

        }
    }
}
