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

namespace DataReadDB_V2
{
    public partial class Form1 : Form
    {
        string connectionString = "Data Source=DESKTOP-3GEVC3B\\MSSQLSERVER_16;Initial Catalog=demodb;User ID=sa;Password=abc123";
        public Form1()
        {
            InitializeComponent();
            
        }

        private void connect_Click(object sender, EventArgs e)
        {
            Connection con = new Connection();
            con.CreateConnection(connectionString);
        }

        private void show_all_data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
