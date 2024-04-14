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

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "admin" && textBox2.Text == "Admin123!")
            {
                data = "Admin";
                ConditionMet = true;
                Form2 form2 = new Form2(this, ConditionMet);
                DialogResult answer = form2.ShowDialog();

            }
            else if (textBox2.Text == textBox3.Text)
            {
                data = "User";
                ConditionMet = false;
                Form2 form2 = new Form2(this, ConditionMet);
                DialogResult answer = form2.ShowDialog();
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

        private void button2_Click(object sender, EventArgs e)
        {
            //string salt = "";
            //{
            //    salt = DateTime.Now.ToString();
            //    textBox3.Text = salt;
            //}
            //string password = textBox1.Text;
            //hashPassword($"{password}{salt}");
            //textBox3.Text = hashPassword(password); 
            MessageBox.Show("Done");
            
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
