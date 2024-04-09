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
            try
            {
                // Manually specified ID
                int id = int.Parse(idTextBox.Text);

                using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-U7IUME5;Initial Catalog=Magdalena;Integrated Security=True"))
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
        }





        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // Manually specified ID
                int id = int.Parse(idTextBox.Text);

                using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-U7IUME5;Initial Catalog=Magdalena;Integrated Security=True"))
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

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                // Manually specified ID for deletion
                int id = int.Parse(idTextBox.Text); // Assuming 'idTextBox' is where the ID to be deleted is entered

                using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-U7IUME5;Initial Catalog=Magdalena;Integrated Security=True"))
                {
                    con.Open();

                    // Delete the town from the database with the specified ID
                    SqlCommand deleteCmd = new SqlCommand("DELETE FROM Towns WHERE ID = @id", con);
                    deleteCmd.Parameters.AddWithValue("@id", id);
                    int rowsAffected = deleteCmd.ExecuteNonQuery(); // Execute the delete command

                    con.Close();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Town with ID " + id + " was deleted!");
                    }
                    else
                    {
                        MessageBox.Show("No town with the specified ID was found to delete.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }


}