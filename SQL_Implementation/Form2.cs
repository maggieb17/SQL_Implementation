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

namespace SQL_Implementation
{
    public partial class Form2 : Form
    {
        private string answer = "";
        private Form3 parent;
        public string Answer
        {
            get
            {
                return answer;
            }
        }


        public Form2(Form3 parent)
        {
            InitializeComponent();
            this.parent = parent;
            button1.Text = this.parent.Data;
        }
        private void Form2_Load_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-U7IUME5;Initial Catalog=Magdalena;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT ID, CountryName from Countries", con);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();

            adapter.Fill(dt);
            countriesComboBox.DataSource = dt;
            countriesComboBox.DisplayMember = "CountryName";
            countriesComboBox.ValueMember = "ID";
            con.Close();


            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-U7IUME5;Initial Catalog=Magdalena;Integrated Security=True");
            conn.Open();
            SqlCommand cmdd = new SqlCommand("SELECT ID, townName from Towns", conn);
            SqlDataAdapter adapterr = new SqlDataAdapter();
            adapter.SelectCommand = cmdd;
            DataTable dtt = new DataTable();

            adapter.Fill(dtt);
            townComboBox.DataSource = dtt;
            townComboBox.DisplayMember = "townName";
            townComboBox.ValueMember = "ID";
            conn.Close();
        }

        public Form2(Form3 parent, bool conditionMet)
        {
            InitializeComponent();
            this.parent = parent;
            button1.Text = this.parent.Data;

            if (conditionMet)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void LoadTownsForCountry(int countryId)
        {
            string connectionString = @"Data Source=DESKTOP-U7IUME5;Initial Catalog=Magdalena;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT ID, CityName FROM Cities WHERE CountryID = @CountryID";
                
            }
        }


        private void townComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }



        private void countriesComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-U7IUME5;Initial Catalog=Magdalena;Integrated Security=True");
            string query = "SELECT ID, townName FROM Towns WHERE CountryID = @CountryID";
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@CountryID", countriesComboBox.SelectedIndex + 1);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                adapter.Fill(dt);
                townComboBox.DisplayMember = "townName";
                townComboBox.ValueMember = "ID";
                townComboBox.DataSource = dt;
            }
        }

        private void townComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6(this);
            form6.Show();
            this.Hide();
        }
    }
}
