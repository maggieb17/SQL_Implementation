namespace SQL_Implementation
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            countriesComboBox = new ComboBox();
            townComboBox = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(255, 41);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Hobbies";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(122, 95);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 1;
            // 
            // countriesComboBox
            // 
            countriesComboBox.FormattingEnabled = true;
            countriesComboBox.Location = new Point(68, 90);
            countriesComboBox.Margin = new Padding(2);
            countriesComboBox.Name = "countriesComboBox";
            countriesComboBox.Size = new Size(129, 23);
            countriesComboBox.TabIndex = 2;
            countriesComboBox.SelectedIndexChanged += countriesComboBox_SelectedIndexChanged_1;
            // 
            // townComboBox
            // 
            townComboBox.FormattingEnabled = true;
            townComboBox.Location = new Point(378, 90);
            townComboBox.Margin = new Padding(2);
            townComboBox.Name = "townComboBox";
            townComboBox.Size = new Size(129, 23);
            townComboBox.TabIndex = 3;
            townComboBox.SelectedIndexChanged += townComboBox_SelectedIndexChanged_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(68, 73);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 4;
            label3.Text = "Countries";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(378, 73);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 5;
            label4.Text = "Towns";
            // 
            // button1
            // 
            button1.Location = new Point(238, 160);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(78, 22);
            button1.TabIndex = 6;
            button1.Text = "Admin";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(140, 159);
            button2.Name = "button2";
            button2.Size = new Size(78, 23);
            button2.TabIndex = 7;
            button2.Text = "Edit Profile";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(346, 159);
            button3.Name = "button3";
            button3.Size = new Size(91, 23);
            button3.TabIndex = 8;
            button3.Text = "Users Profiles";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(560, 270);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(townComboBox);
            Controls.Add(countriesComboBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox countriesComboBox;
        private ComboBox townComboBox;
        private Label label3;
        private Label label4;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}