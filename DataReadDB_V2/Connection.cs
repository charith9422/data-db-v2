using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataReadDB_V2
{
    class Connection
    {



        public void OpenConnection(SqlConnection conn) {
            //SqlConnection con = new SqlConnection(conStr);
            conn.Open();
        }

        public void CloseConnection(SqlConnection conn) {
            conn.Close();
            
        }

        public void CreateConnection(string connectionString) {

            SqlConnection cnn;
            cnn = new SqlConnection(connectionString);
            try
            {

                OpenConnection(cnn);
                MessageBox.Show("Connection Open ! ");
                //CloseConnection(cnn);
            }
            catch(Exception ex) {
                MessageBox.Show("Can not open connection ! ");
                Console.WriteLine(ex);
            }
        }
        public void ExecuteQuery(string query)
        {

            
        }





    }
}
