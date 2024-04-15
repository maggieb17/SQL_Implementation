using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace SQL_Implementation
{
    public partial class Form3 : Form
    {
        private string data = "";
        public string Data
        {
            get
            {
                return data;
            }
        }
        public bool ConditionMet { get; private set; }
        public Form3()
        {
            InitializeComponent();

        }
        private string salt = "";

                
    private void button2_Click(object sender, EventArgs e)
        {
            salt = DateTime.Now.ToString();
            string password = textBox1.Text;
            hashPassword($"{password}{salt}");
            MessageBox.Show("Done");


            //SqlConnection con2 = new SqlConnection(@"Data Source=DESKTOP-U7IUME5;Initial Catalog=Magdalena;Integrated Security=True");
            //con2.Open();
            //SqlCommand insertCmd2 = new SqlCommand("INSERT INTO Users (DateTime) VALUES (@datetime)", con2);
            //insertCmd2.Parameters.AddWithValue("@datetime", salt);
            //int rowsAffected2 = insertCmd2.ExecuteNonQuery();
            //con2.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "admin" && textBox2.Text == "Admin123!")
            {
                data = "Admin";
                ConditionMet = true;
                Form2 form2 = new Form2(this, ConditionMet);
                DialogResult answer = form2.ShowDialog();
            }
            else if (textBox2.Text == textBox3.Text && textBox1.Text != "@username")
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-U7IUME5;Initial Catalog=Magdalena;Integrated Security=True"))
                {
                    con.Open();

                    SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM Users WHERE Username = @username", con);
                    checkCmd.Parameters.AddWithValue("@username", textBox1.Text);
                    int existingUserCount = (int)checkCmd.ExecuteScalar();
                    SqlCommand checkCmd2 = new SqlCommand("SELECT COUNT(*) FROM Users WHERE Password = @password", con);
                    checkCmd2.Parameters.AddWithValue("@password", textBox2.Text);
                    int existingUserCount2 = (int)checkCmd2.ExecuteScalar();

                    if (existingUserCount > 0 && existingUserCount2 == 0)
                    {
                        MessageBox.Show("This username is taken");
                    }

                    else if (existingUserCount > 0 && existingUserCount2>0)
                    {
                        ConditionMet = false;
                        Form2 form2 = new Form2(this, ConditionMet);
                        DialogResult answer = form2.ShowDialog();
                    }
                    else
                    {
                        SqlCommand insertCmd = new SqlCommand("INSERT INTO Users (Username, DateTime, Password) VALUES (@username, @datetime, @password)", con);
                        insertCmd.Parameters.AddWithValue("@username", textBox1.Text);
                        insertCmd.Parameters.AddWithValue("@datetime", salt); 
                        insertCmd.Parameters.AddWithValue("@password", textBox3.Text);
                        int userID = Convert.ToInt32(insertCmd.ExecuteScalar()); // Retrieve the generated UserID


                        // Execute the insert command
                        int rowsAffected = insertCmd.ExecuteNonQuery();

                        ConditionMet = false;
                        Form2 form2 = new Form2(this, ConditionMet);

                        DialogResult answer = form2.ShowDialog();
                    }
                }
            }

            else
            {
                MessageBox.Show("Passwords don't match!");
            }

        }




        string hashPassword(string password)
        {
            SHA256 hashAlgorithm = SHA256.Create();
            var bytes = Encoding.Default.GetBytes(password);
            var hash = hashAlgorithm.ComputeHash(bytes);
            return Convert.ToBase64String(hash);
        }


        private void button3_Click(object sender, EventArgs e)
        {
            string password = textBox2.Text;
            string Pattern = "^(?=.*[A-Z])(?=.*[a-z])(?=.*[0-9])(?=.*[!@#$%_&*?])[A-Za-z0-9!@#$%_&*?]{8,}$";
            if (Regex.IsMatch(password, Pattern))
            {
                MessageBox.Show("Valid");

                button1.Enabled = true;

            }

            else
            {
                MessageBox.Show("Invalid");
            }


        }



        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
