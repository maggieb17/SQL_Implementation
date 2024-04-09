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

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "s" && textBox2.Text == "D")
            {
                data = "User";
                ConditionMet = false;
                Form2 form2 = new Form2(this, ConditionMet);
                DialogResult answer = form2.ShowDialog();
            }

            if (textBox1.Text == "kris1234" && textBox2.Text == "D123#")
            {
                data = "Admin";
                ConditionMet = true;
                Form2 form2 = new Form2(this, ConditionMet);
                DialogResult answer = form2.ShowDialog();

            }
        }
    }
}
