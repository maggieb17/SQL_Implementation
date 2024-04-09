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

        private void Form2_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-U7IUME5;Initial Catalog=Magdalena;Integrated Security=True");
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


            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-U7IUME5;Initial Catalog=Magdalena;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT ID, townName from Towns", con);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();

            adapter.Fill(dt);
            townComboBox.DataSource = dt;
            townComboBox.DisplayMember = "townName";
            townComboBox.ValueMember = "ID";
            con.Close();




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
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
        }

        private void townComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void countriesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-U7IUME5;Initial Catalog=Magdalena;Integrated Security=True");
            string query = "SELECT ID, townName FROM Towns WHERE CountryID = @CountryID";
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@CountryID", countriesComboBox.SelectedIndex + 1);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                adapter.Fill(dt);
                townComboBox.DisplayMember = "CityName";
                townComboBox.ValueMember = "ID";
                townComboBox.DataSource = dt;
            }
        }
    }
}
