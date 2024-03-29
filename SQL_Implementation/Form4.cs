using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQL_Implementation
{
    public partial class Form4 : Form
    {
        private string data = "";
        public string Data
        {
            get
            {
                return data;
            }
        }
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            data = datatextBox.Text;
            Form5 form5 = new Form5(this);
            DialogResult answer = form5.ShowDialog();

            datatextBox.Text = form5.Answer;
            
        }
    }
}
