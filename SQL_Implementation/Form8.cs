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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace SQL_Implementation
{
    public partial class Form8 : Form
    {
        private string filters = "";
        private int count;
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
            using (SqlConnection con = new SqlConnection(@"Data Source=LAB108PC19\SQLEXPRESS;Initial Catalog=Magdalena;Integrated Security=True"))
            {
                con.Open();

                string query = "SELECT * FROM User_Profiles";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                resultTable.DataSource = dt;
                con.Close();

            }
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            andButton.Enabled = true;
            orButton.Enabled = true;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            textBox2.Text = string.Empty;
            filters = string.Empty;
            textBox2.Enabled = false;
            andButton.Enabled = false;
            orButton.Enabled = false;
            columnsComboBox.Enabled = true;
        }

        private void andButton_Click(object sender, EventArgs e)
        {
            if (!filters.Equals(""))
            {
                filters += " Like '%" + textBox2.Text + "%'";
                MessageBox.Show(filters);
                filters += " AND ";
                textBox2.Text = "";
                textBox2.Enabled = false;
                andButton.Enabled = false;
                orButton.Enabled = false;
                columnsComboBox.Enabled = true;
            }
        }

        private void orButton_Click(object sender, EventArgs e)
        {
            if (!filters.Equals(""))
            {
                filters += " Like '%" + textBox2.Text + "%'";
                MessageBox.Show(filters);
                filters += " OR ";
                textBox2.Text = "";
                textBox2.Enabled = false;
                andButton.Enabled = false;
                orButton.Enabled = false;
                columnsComboBox.Enabled = true;
            }
        }
        //private void columnsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        private void columnsComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            filters += columnsComboBox.GetItemText(columnsComboBox.SelectedItem).Trim();
            columnsComboBox.Enabled = false;
            textBox2.Enabled = true;
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            if (!filters.Equals(string.Empty))
            {
                filters += " Like '%" + textBox2.Text + "%'";
                MessageBox.Show(filters);
                //DataView dv = resultTable.DefaultView;
                //dv.RowFilter = filters;

                textBox2.Text = string.Empty;
                //filters = string.Empty;
                textBox2.Enabled = false;
                andButton.Enabled = false;
                orButton.Enabled = false;
                columnsComboBox.Enabled = true;
            }
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void filterTextBox_TextChanged(object sender, EventArgs e)
        {
            
                //if (count == 1 && !columnTextBox.Text.Equals("id"))
                //{
                //    DataView dv = resultTable.DefaultView;
                //    dv.RowFilter = columnTextBox.Text + " Like '%" + filterTextBox.Text + "%'";
                //    //dv.RowFilter = textBox1.Text + " Like '%" + textBox2.Text + "%' AND " + "last_name Like '%At%'"; //dataGridView1.DataSource = dv;//no need
                //}
            
        }
    }
}
