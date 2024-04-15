using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SQL_Implementation
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
            UsersTable();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //using (SqlConnection con = new SqlConnection(@"Data Source=PIB-Desktop;Initial Catalog=Magdalena;Integrated Security=True"))
            //{
            //    con.Open();

            //    string query = "SELECT (*) FROM User_Profiles";
            //    SqlDataAdapter da = new SqlDataAdapter(query, con);
            //    DataTable dt = new DataTable();
            //    da.Fill(dt);
            //    dataGridView1.DataSource = dt;
            //    con.Close();

            //}
        }

        private void UsersTable()
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=PIB-Desktop;Initial Catalog=Magdalena;Integrated Security=True"))
            {
                con.Open();

                string query = "SELECT * FROM User_Profiles";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();

            }
        }
    }
}
