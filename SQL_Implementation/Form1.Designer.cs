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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            townComboBox = new ComboBox();
            townListBox = new ListBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            idTextBox = new TextBox();
            townTextBox = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(197, 55);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "Town:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(214, 29);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(21, 15);
            label2.TabIndex = 1;
            label2.Text = "ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(378, 55);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 2;
            // 
            // townComboBox
            // 
            townComboBox.FormattingEnabled = true;
            townComboBox.Location = new Point(69, 153);
            townComboBox.Margin = new Padding(2);
            townComboBox.Name = "townComboBox";
            townComboBox.Size = new Size(129, 23);
            townComboBox.TabIndex = 3;
            townComboBox.SelectedIndexChanged += townComboBox_SelectedIndexChanged;
            // 
            // townListBox
            // 
            townListBox.FormattingEnabled = true;
            townListBox.ItemHeight = 15;
            townListBox.Location = new Point(231, 153);
            townListBox.Margin = new Padding(2);
            townListBox.Name = "townListBox";
            townListBox.Size = new Size(127, 79);
            townListBox.TabIndex = 4;
            townListBox.SelectedIndexChanged += townListBox_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(125, 97);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(78, 30);
            button1.TabIndex = 5;
            button1.Text = "Add town";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(242, 97);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(90, 30);
            button2.TabIndex = 6;
            button2.Text = "Update town";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // button3
            // 
            button3.Location = new Point(370, 97);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(98, 30);
            button3.TabIndex = 7;
            button3.Text = "Delete town";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // idTextBox
            // 
            idTextBox.Location = new Point(242, 28);
            idTextBox.Margin = new Padding(2);
            idTextBox.Name = "idTextBox";
            idTextBox.Size = new Size(106, 23);
            idTextBox.TabIndex = 8;
            // 
            // townTextBox
            // 
            townTextBox.Location = new Point(242, 55);
            townTextBox.Margin = new Padding(2);
            townTextBox.Name = "townTextBox";
            townTextBox.Size = new Size(106, 23);
            townTextBox.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(560, 270);
            Controls.Add(townTextBox);
            Controls.Add(idTextBox);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(townListBox);
            Controls.Add(townComboBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load_2;
            ResumeLayout(false);
            PerformLayout();
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