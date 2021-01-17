using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace PROGECT
{
    class Class1
    {
       
      public static  SqlConnection cnx = new SqlConnection(@"Data Source=ACER-PC\SQLEXPRESS;Initial Catalog=Gestion_Vente_DB;Integrated Security=True");
        public static void  ouvrire()
        {
            if(cnx.State==ConnectionState.Closed)
            {
                cnx.Open();
            }

        }
        public static void fermer()
        {
            if (cnx.State == ConnectionState.Open)
            {
                cnx.Close();
            }

        }
    }
}
