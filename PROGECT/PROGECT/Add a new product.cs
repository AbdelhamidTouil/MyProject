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
    public partial class Add_a_new_product : Form
    {
        public Add_a_new_product()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string req = string.Format("insert into PRODUIT(ID_PRODUIT,ID_CAT,NOM_PRODUIT,QTE_STOCK,PRIX) values({0},{1},'{2}',{3},{4}) ", textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
            SqlCommand cmd = new SqlCommand(req, Class1.cnx);
            Class1.ouvrire();
            cmd.ExecuteNonQuery();
            MessageBox.Show("ajouter avec succes");
            Class1.fermer();
            
        }

      
        private void Add_a_new_product_Load(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string req = string.Format("delete from PRODUIT where ID_PRODUIT = {0}",textBox1.Text);
            SqlCommand cmd = new SqlCommand(req, Class1.cnx);
            Class1.ouvrire();
            cmd.ExecuteNonQuery();
            MessageBox.Show(" supprimer avec succes");
            Class1.fermer();
        }
    }
}
