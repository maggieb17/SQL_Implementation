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

    public partial class Form5 : Form
    {
        private string answer = "";
        private Form4 parent;

        public string Answer
        {
            get
            {
                return answer;
            }
        }
        public Form5(Form4 parent)
        {
            InitializeComponent();
            this.parent = parent;
            datatextBox.Text = this.parent.Data;

        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            answer = datatextBox.Text;
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            datatextBox.Text = "";
            answer = datatextBox.Text;
            this.Hide();

        }
    }
}
