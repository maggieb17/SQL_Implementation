namespace SQL_Implementation
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.townComboBox = new System.Windows.Forms.ComboBox();
            this.townListBox = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.townTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(197, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Town:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(214, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(378, 55);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 15);
            this.label3.TabIndex = 2;
            // 
            // townComboBox
            // 
            this.townComboBox.FormattingEnabled = true;
            this.townComboBox.Location = new System.Drawing.Point(68, 131);
            this.townComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.townComboBox.Name = "townComboBox";
            this.townComboBox.Size = new System.Drawing.Size(129, 23);
            this.townComboBox.TabIndex = 3;
            this.townComboBox.SelectedIndexChanged += new System.EventHandler(this.townComboBox_SelectedIndexChanged);
            // 
            // townListBox
            // 
            this.townListBox.FormattingEnabled = true;
            this.townListBox.ItemHeight = 15;
            this.townListBox.Location = new System.Drawing.Point(230, 131);
            this.townListBox.Margin = new System.Windows.Forms.Padding(2);
            this.townListBox.Name = "townListBox";
            this.townListBox.Size = new System.Drawing.Size(127, 79);
            this.townListBox.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(125, 97);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 20);
            this.button1.TabIndex = 5;
            this.button1.Text = "Add town";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(242, 97);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 20);
            this.button2.TabIndex = 6;
            this.button2.Text = "Update town";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(370, 97);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 20);
            this.button3.TabIndex = 7;
            this.button3.Text = "Delete town";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(242, 28);
            this.idTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(106, 23);
            this.idTextBox.TabIndex = 8;
            // 
            // townTextBox
            // 
            this.townTextBox.Location = new System.Drawing.Point(242, 55);
            this.townTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.townTextBox.Name = "townTextBox";
            this.townTextBox.Size = new System.Drawing.Size(106, 23);
            this.townTextBox.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(560, 270);
            this.Controls.Add(this.townTextBox);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.townListBox);
            this.Controls.Add(this.townComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_2);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox townComboBox;
        private ListBox townListBox;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox idTextBox;
        private TextBox townTextBox;
    }
}