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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.countriesComboBox = new System.Windows.Forms.ComboBox();
            this.townComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(255, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hobbies";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 1;
            // 
            // countriesComboBox
            // 
            this.countriesComboBox.FormattingEnabled = true;
            this.countriesComboBox.Location = new System.Drawing.Point(68, 90);
            this.countriesComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.countriesComboBox.Name = "countriesComboBox";
            this.countriesComboBox.Size = new System.Drawing.Size(129, 23);
            this.countriesComboBox.TabIndex = 2;
            this.countriesComboBox.SelectedIndexChanged += new System.EventHandler(this.countriesComboBox_SelectedIndexChanged_1);
            // 
            // townComboBox
            // 
            this.townComboBox.FormattingEnabled = true;
            this.townComboBox.Location = new System.Drawing.Point(378, 90);
            this.townComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.townComboBox.Name = "townComboBox";
            this.townComboBox.Size = new System.Drawing.Size(129, 23);
            this.townComboBox.TabIndex = 3;
            this.townComboBox.SelectedIndexChanged += new System.EventHandler(this.townComboBox_SelectedIndexChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 73);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Countries";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(378, 73);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Towns";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(241, 182);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 20);
            this.button1.TabIndex = 6;
            this.button1.Text = "Admin";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(560, 270);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.townComboBox);
            this.Controls.Add(this.countriesComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox countriesComboBox;
        private ComboBox townComboBox;
        private Label label3;
        private Label label4;
        private Button button1;
    }
}