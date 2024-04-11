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
using System.Net;
using System.Drawing;
using System.Windows.Forms;

namespace SQL_Implementation
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            firstBox1.TextChanged += (sender, e) => UpdateButtonState();
            lastBox2.TextChanged += (sender, e) => UpdateButtonState();
            radioButton1.CheckedChanged += (sender, e) => UpdateButtonState();
            radioButton2.CheckedChanged += (sender, e) => UpdateButtonState();
            // This initial call is to set the correct initial state of button1 based on existing conditions
            UpdateButtonState();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private bool buttonWasClicked = false;
        private byte[] savePhoto()
        {
            buttonWasClicked = true;
            MemoryStream stream = new MemoryStream();
            pictureBox1.Image.Save(stream, pictureBox1.Image.RawFormat);
            return stream.GetBuffer();
        }


        private void UpdateButtonState()
        {
            button1.Enabled = firstBox1.Text != "" && lastBox2.Text != "" && buttonWasClicked==true && (radioButton1.Checked || radioButton2.Checked);
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void browseButton_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(openFile.FileName);
            }
        }

        private void saveButton_Click_1(object sender, EventArgs e)
        {
            using SqlConnection con = new SqlConnection(@"Data Source=PIB-Desktop;Initial Catalog=Magdalena;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Picture VALUES (@photo)", con);
            con.Close();
            MessageBox.Show("Photo was saved");
            buttonWasClicked = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }
    }
}
