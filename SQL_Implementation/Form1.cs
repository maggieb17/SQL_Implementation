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

        private void Form1_Load_2(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Pavel Bonev\Documents\Magdalena.mdf"";Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT ID, CountryName from Countries", con);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();

            adapter.Fill(dt);
            townComboBox.DataSource = dt;
            townComboBox.DisplayMember = "CountryName";
            townComboBox.ValueMember = "ID";
            con.Close();


            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Pavel Bonev\Documents\Magdalena.mdf"";Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand cmdd = new SqlCommand("SELECT ID, townName from Towns", conn);
            SqlDataAdapter adapterr = new SqlDataAdapter();
            adapter.SelectCommand = cmdd;
            DataTable dtt = new DataTable();

            adapter.Fill(dtt);
            townListBox.DataSource = dtt;
            townListBox.DisplayMember = "townName";
            townListBox.ValueMember = "ID";
            conn.Close();
        }

        private void LoadData()
        {
            // Reload data into ComboBox
            townComboBox_SelectedIndexChanged(null, EventArgs.Empty);

            // Reload data into ListBox
            Form1_Load_2(null, EventArgs.Empty);
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void LoadTownsForCountry(int countryId)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Pavel Bonev\Documents\Magdalena.mdf"";Integrated Security=True;Connect Timeout=30";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT ID, townName FROM Towns WHERE CountryID = @CountryID";

            }
        }



        private void countriesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void townComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Pavel Bonev\Documents\Magdalena.mdf"";Integrated Security=True;Connect Timeout=30");
            string query = "SELECT ID, townName FROM Towns WHERE CountryID = @CountryID";
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@CountryID", townComboBox.SelectedIndex + 1);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                adapter.Fill(dt);
                townListBox.DisplayMember = "townName";
                townListBox.ValueMember = "ID";
                townListBox.DataSource = dt;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Manually specified ID
                int id = int.Parse(idTextBox.Text);

                using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Pavel Bonev\Documents\Magdalena.mdf"";Integrated Security=True;Connect Timeout=30"))
                {
                    conn.Open();

                    // Insert the new town into the database with the specified ID
                    SqlCommand insertCmd = new SqlCommand("INSERT INTO Towns (ID, townName) VALUES (@id, @town)", conn);
                    insertCmd.Parameters.AddWithValue("@id", id);
                    insertCmd.Parameters.AddWithValue("@town", townTextBox.Text);
                    int rowsAffected = insertCmd.ExecuteNonQuery(); // Execute the insert command

                    conn.Close();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("New town with ID " + id + " was inserted!");
                    }
                    else
                    {
                        MessageBox.Show("Failed to insert the new town.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            LoadData();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Manually specified ID
                int id = int.Parse(idTextBox.Text);

                using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Pavel Bonev\Documents\Magdalena.mdf"";Integrated Security=True;Connect Timeout=30"))
                {
                    con.Open();

                    // Update the town in the database with the specified ID
                    SqlCommand updateCmd = new SqlCommand("UPDATE Towns SET townName = @town WHERE ID = @id", con);
                    updateCmd.Parameters.AddWithValue("@town", townTextBox.Text);
                    updateCmd.Parameters.AddWithValue("@id", id);
                    int rowsAffected = updateCmd.ExecuteNonQuery(); // Execute the update command

                    con.Close();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Town with ID " + id + " was updated!");
                    }
                    else
                    {
                        MessageBox.Show("No town with the specified ID was found.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            LoadData();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            

            

            // Check if an item is selected in the ListBox
            
                using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Pavel Bonev\Documents\Magdalena.mdf"";Integrated Security=True;Connect Timeout=30"))
                {
                    con.Open();
                    int id = int.Parse(idTextBox.Text);
                    SqlCommand deleteCmd = new SqlCommand("DELETE FROM Towns WHERE ID = @id", con);
                    deleteCmd.Parameters.AddWithValue("@id", id);
                    int rowsAffected = deleteCmd.ExecuteNonQuery();

                    con.Close();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Town with ID " + id + " was deleted!");
                    }
                    else
                    {
                        MessageBox.Show("No town with the specified ID was found to delete.");
                    }
                    LoadData();
                }
            
        }

            private void townListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //private void DeleteTown(int townId)
        //{
        //    try
        //    {

        //        using (SqlConnection con = new SqlConnection(@"Data Source=LAB108PC19\SQLEXPRESS;Initial Catalog=Magdalena;Integrated Security=True"))
        //        {
        //            con.Open();
        //            SqlCommand deleteCmd = new SqlCommand("DELETE FROM Towns WHERE ID = @id", con);
        //            deleteCmd.Parameters.AddWithValue("@id", townId);
        //            int rowsAffected = deleteCmd.ExecuteNonQuery();

        //            if (rowsAffected > 0)
        //            {
        //                MessageBox.Show("Town with ID " + townId + " was deleted!");
        //            }
        //            else
        //            {
        //                MessageBox.Show("No town with the specified ID was found to delete.");
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("An error occurred: " + ex.Message);
        //    }
        //}
    } 
}


