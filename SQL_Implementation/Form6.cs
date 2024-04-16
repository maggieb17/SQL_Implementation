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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SQL_Implementation
{
    public partial class Form6 : Form
    {
        private int userID;

        private Form2 form2Instance;
        public Form6(Form2 form2Instance)
        {
            InitializeComponent();
            this.form2Instance = form2Instance;
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
            button1.Enabled = firstBox1.Text != "" && lastBox2.Text != "" && buttonWasClicked == true && (radioButton1.Checked || radioButton2.Checked);
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }






        private void DisplayImageFromDatabase()
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=LAB108PC19\SQLEXPRESS;Initial Catalog=Magdalena;Integrated Security=True"))
            {
                con.Open();

                // Fetch the image bytes from the database
                SqlCommand cmdd = new SqlCommand("SELECT ID from Users", con);
                int userID = Convert.ToInt32(cmdd.ExecuteScalar());
                SqlCommand selectCmd = new SqlCommand("SELECT Picture FROM User_Profiles WHERE UserID = @userID", con);
                selectCmd.Parameters.AddWithValue("@userID", userID); // Assuming you have userID defined somewhere
                byte[] imageBytes = (byte[])selectCmd.ExecuteScalar();

                // Convert byte array back to image
                Image image = ByteArrayToImage(imageBytes);

                // Set the image to the PictureBox control
                pictureBox1.Image = image;

                con.Close();
            }
        }

        private Image ByteArrayToImage(byte[] byteArrayIn)
        {
            using (MemoryStream ms = new MemoryStream(byteArrayIn))
            {
                Image returnImage = Image.FromStream(ms);
                return returnImage;
            }
        }
        private byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Png); // You can change the format as needed
                return ms.ToArray();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(openFile.FileName);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            using SqlConnection con = new SqlConnection(@"Data Source=LAB108PC19\SQLEXPRESS;Initial Catalog=Magdalena;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Picture VALUES (@photo)", con);
            con.Close();
            MessageBox.Show("Photo was saved");
            buttonWasClicked = true;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=LAB108PC19\SQLEXPRESS;Initial Catalog=Magdalena;Integrated Security=True"))
            {
                con.Open();

                // Convert image to byte array
                byte[] imageBytes = ImageToByteArray(pictureBox1.Image);

                SqlCommand insertCmd = new SqlCommand("INSERT INTO User_Profiles (UserID, Picture, FirstName, LastName, Country, Gender) VALUES (@userID, @picture, @fname, @lname, @country, @gender)", con);
                SqlCommand cmdd = new SqlCommand("SELECT ID from Users", con);
                int userID = Convert.ToInt32(cmdd.ExecuteScalar());
                insertCmd.Parameters.AddWithValue("@userID", userID);
                insertCmd.Parameters.AddWithValue("@picture", imageBytes);
                insertCmd.Parameters.AddWithValue("@fname", firstBox1.Text);
                insertCmd.Parameters.AddWithValue("@lname", lastBox2.Text);
                insertCmd.Parameters.AddWithValue("@country", textBox1.Text);
                insertCmd.Parameters.AddWithValue("@gender", radioButton1.Checked ? "Male" : "Female"); // Assuming you want to store the gender as string
                int rowsAffected = insertCmd.ExecuteNonQuery();

                con.Close();


            }
        }
    }
}
