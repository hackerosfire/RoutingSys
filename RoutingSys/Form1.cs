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

namespace RoutingSys
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "localhost";
                builder.UserID = "sa";
                builder.Password = "test";
                builder.InitialCatalog = "master";
                MessageBox.Show("Connecting to SQL Server ... ");
                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    connection.Open();
                    MessageBox.Show("Done.");
                }

            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                throw;
            }
            MessageBox.Show("All done. Press any key to finish...");

        }
    }
}
