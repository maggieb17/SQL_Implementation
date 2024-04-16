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
    public partial class Form7 : Form
    {
        private Form3 form3Instance;
        public Form7(Form3 form3Instance)
        {
            InitializeComponent();
            this.form3Instance = form3Instance;
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Pavel Bonev\Documents\Magdalena.mdf"";Integrated Security=True;Connect Timeout=30"))
            {
                con.Open();

                SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM Users WHERE Username = @username", con);
                checkCmd.Parameters.AddWithValue("@username", textBox1.Text);
                int existingUserCount = (int)checkCmd.ExecuteScalar();
                SqlCommand checkCmd2 = new SqlCommand("SELECT COUNT(*) FROM Users WHERE Password = @password", con);
                if (textBox2.Text == ""||textBox1.Text=="")
                {
                    MessageBox.Show("Don't leave empty boxes!");
                }

                con.Close();
            }
        }
    }
}
