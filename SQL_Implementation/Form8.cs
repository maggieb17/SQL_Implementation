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
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Pavel Bonev\Documents\Magdalena.mdf"";Integrated Security=True;Connect Timeout=30";
        private string filters = "";
        private int count;
        public Form8()
        {
            InitializeComponent();
            UsersTable();


        }

        private void Form8_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'User_Profiles' AND COLUMN_NAME != 'UserID'", con);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        columnsComboBox.Items.Add(reader["COLUMN_NAME"].ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UsersTable()
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Pavel Bonev\Documents\Magdalena.mdf"";Integrated Security=True;Connect Timeout=30"))
            {
                con.Open();

                string query = "SELECT ProfileID, Picture, FirstName, LastName, Country, Gender FROM User_Profiles";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                resultTable.DataSource = dt;
                con.Close();
            }
        }



        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            andButton.Enabled = true;
            orButton.Enabled = true;
        }





        //private void columnsComboBox_SelectedIndexChanged(object sender, EventArgs e)




        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            andButton.Enabled = true;
            orButton.Enabled = true;
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

        private void columnsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            filters += columnsComboBox.SelectedItem.ToString().Trim();
            columnsComboBox.Enabled = false;
            textBox2.Enabled = true;
        }

        private void andButton_Click_1(object sender, EventArgs e)
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

        private void orButton_Click_1(object sender, EventArgs e)
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

        private void clearButton_Click_1(object sender, EventArgs e)
        {
            textBox2.Text = string.Empty;
            filters = string.Empty;
            textBox2.Enabled = false;
            andButton.Enabled = false;
            orButton.Enabled = false;
            columnsComboBox.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!filters.Equals(string.Empty))
            {
                    if (resultTable.DataSource is DataTable dataTable)
                    {
                        DataView dv = dataTable.DefaultView;
                        string filterExpression = string.Empty;
                        foreach (DataColumn column in dataTable.Columns)
                        {
                            if (column.DataType == typeof(string))
                            {
                                if (filterExpression.Length > 0)
                                {
                                    filterExpression += " OR ";
                                }
                                filterExpression += "[" + column.ColumnName + "] Like '%" + textBox2.Text + "%'";
                            }
                        }
                        dv.RowFilter = filterExpression;


                        MessageBox.Show("Filter applied: " + dv.RowFilter);
                        textBox2.Text = string.Empty;
                        textBox2.Enabled = false;
                        andButton.Enabled = false;
                        orButton.Enabled = false;
                        columnsComboBox.Enabled = true;
                    }
                
            }
        }
    }
}
