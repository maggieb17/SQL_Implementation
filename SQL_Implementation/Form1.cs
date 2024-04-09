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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAB108PC21\SQLEXPRESS;Initial Catalog=Magdalena;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT ID, townName from Towns", con);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();

            adapter.Fill(dt);
            townComboBox.DataSource = dt;
            townComboBox.DisplayMember = "townName";
            townComboBox.ValueMember = "ID";
            townListBox.DataSource = dt;
            townListBox.DisplayMember = "townName";
            townListBox.ValueMember = "ID";
            con.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAB108PC21\SQLEXPRESS;Initial Catalog=Magdalena;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Towns (townName) VALUES (@city)", con);
            cmd.Parameters.AddWithValue("@city", townTextBox.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record was inserted!");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAB108PC21\SQLEXPRESS;Initial Catalog=Magdalena;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Towns SET townName = @city WHERE ID = @id", con);
            cmd.Parameters.AddWithValue("@city", townTextBox.Text);
            cmd.Parameters.AddWithValue("@id", int.Parse(idTextBox.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record was updated!");
        }

        private void townListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}