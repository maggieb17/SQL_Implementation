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

namespace SQL_Implementation
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAB108PC21\SQLEXPRESS;Initial Catalog=Magdalena;Integrated Security=True");
            conn.Open();
            SqlCommand cmdd = new SqlCommand("SELECT ID, CountryName from Countries", conn);
            SqlDataAdapter adapterr = new SqlDataAdapter();
            adapterr.SelectCommand = cmdd;
            DataTable dtt = new DataTable();

            adapterr.Fill(dtt);
            countriesComboBox.DataSource = dtt;
            countriesComboBox.DisplayMember = "CountryName";
            countriesComboBox.ValueMember = "ID";
            conn.Close();



            if ("CountryName" == "Bulgaria")
            {
                SqlConnection con = new SqlConnection(@"Data Source=LAB108PC21\SQLEXPRESS;Initial Catalog=Magdalena;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT ID, townName from Towns WHERE ID = 1,3,6", con);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;
                DataTable dt = new DataTable();

                adapter.Fill(dt);
                townComboBox.DataSource = dt;
                townComboBox.DisplayMember = "townName";
                townComboBox.ValueMember = "ID";
                con.Close();
            }
            

            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
        }
    }
}
