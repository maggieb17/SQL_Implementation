﻿namespace SQL_Implementation
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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(364, 68);
            label1.Name = "label1";
            label1.Size = new Size(79, 25);
            label1.TabIndex = 0;
            label1.Text = "Hobbies";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(174, 158);
            label2.Name = "label2";
            label2.Size = new Size(0, 25);
            label2.TabIndex = 1;
            // 
            // countriesComboBox
            // 
            countriesComboBox.FormattingEnabled = true;
            countriesComboBox.Location = new Point(97, 150);
            countriesComboBox.Name = "countriesComboBox";
            countriesComboBox.Size = new Size(182, 33);
            countriesComboBox.TabIndex = 2;
            // 
            // townComboBox
            // 
            townComboBox.FormattingEnabled = true;
            townComboBox.Location = new Point(540, 150);
            townComboBox.Name = "townComboBox";
            townComboBox.Size = new Size(182, 33);
            townComboBox.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(97, 122);
            label3.Name = "label3";
            label3.Size = new Size(87, 25);
            label3.TabIndex = 4;
            label3.Text = "Countries";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(540, 122);
            label4.Name = "label4";
            label4.Size = new Size(61, 25);
            label4.TabIndex = 5;
            label4.Text = "Towns";
            // 
            // button1
            // 
            button1.Location = new Point(344, 304);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 6;
            button1.Text = "Admin";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(townComboBox);
            Controls.Add(countriesComboBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
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
    }
}