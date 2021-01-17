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
    public partial class Add_a_new_salle : Form
    {
      
        DataSet ds = new DataSet();
        SqlDataAdapter da;
        public Add_a_new_salle()
        {
            
            InitializeComponent();
        }
        public void RemplireGrid()
        {
            string req = string.Format("select ID_CMD, NOM_PRODUIT,QTE_STOCK,PRIX,IMG_PRODUIT,AMOUNT from PRODUIT inner join DETAIL_CMD  on DETAIL_CMD.ID_PRODUIT= PRODUIT.ID_PRODUIT");
            da = new SqlDataAdapter(req, Class1.cnx);
            da.Fill(ds,"PRODUI");
            dataGridView1.DataSource = ds.Tables["PRODUI"];
        }
       
        private void Add_a_new_salle_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MENU m = new MENU();
            m.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RemplireGrid();
          
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            string req = string.Format("select ID_CMD, NOM_PRODUIT,QTE_STOCK,PRIX,IMG_PRODUIT,AMOUNT from PRODUIT inner join DETAIL_CMD  on DETAIL_CMD.ID_PRODUIT= PRODUIT.ID_PRODUIT where ID_CMD={0}", dataGridView1.CurrentRow.Cells[0].Value.ToString());
            SqlCommand cmd = new SqlCommand(req, Class1.cnx);     
            Class1.ouvrire();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dataGridView2.Rows.Add(dr[0], dr[1], dr[2], dr[3], dr[4], dr[5]);
            }
            dr.Close();
            Class1.fermer();
           
            


        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}

