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
            label1.Location = new Point(282, 91);
            label1.Name = "label1";
            label1.Size = new Size(57, 25);
            label1.TabIndex = 0;
            label1.Text = "Town:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(305, 49);
            label2.Name = "label2";
            label2.Size = new Size(34, 25);
            label2.TabIndex = 1;
            label2.Text = "ID:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(540, 91);
            label3.Name = "label3";
            label3.Size = new Size(0, 25);
            label3.TabIndex = 2;
            // 
            // townComboBox
            // 
            townComboBox.FormattingEnabled = true;
            townComboBox.Location = new Point(97, 219);
            townComboBox.Name = "townComboBox";
            townComboBox.Size = new Size(182, 33);
            townComboBox.TabIndex = 3;
            // 
            // townListBox
            // 
            townListBox.FormattingEnabled = true;
            townListBox.ItemHeight = 25;
            townListBox.Location = new Point(329, 219);
            townListBox.Name = "townListBox";
            townListBox.Size = new Size(180, 129);
            townListBox.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(179, 162);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 5;
            button1.Text = "Add town";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(345, 162);
            button2.Name = "button2";
            button2.Size = new Size(128, 34);
            button2.TabIndex = 6;
            button2.Text = "Update town";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(528, 162);
            button3.Name = "button3";
            button3.Size = new Size(140, 34);
            button3.TabIndex = 7;
            button3.Text = "Delete town";
            button3.UseVisualStyleBackColor = true;
            // 
            // idTextBox
            // 
            idTextBox.Location = new Point(345, 46);
            idTextBox.Name = "idTextBox";
            idTextBox.Size = new Size(150, 31);
            idTextBox.TabIndex = 8;
            // 
            // townTextBox
            // 
            townTextBox.Location = new Point(345, 91);
            townTextBox.Name = "townTextBox";
            townTextBox.Size = new Size(150, 31);
            townTextBox.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
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