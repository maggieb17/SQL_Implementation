namespace SQL_Implementation
{
    partial class Form5
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
            datatextBox = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // datatextBox
            // 
            datatextBox.Location = new Point(308, 150);
            datatextBox.Name = "datatextBox";
            datatextBox.Size = new Size(150, 31);
            datatextBox.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(323, 308);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 1;
            button1.Text = "cancel";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(323, 248);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 2;
            button2.Text = "back";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(datatextBox);
            Name = "Form5";
            Text = "Form5";
            Load += Form5_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox datatextBox;
        private Button button1;
        private Button button2;
    }
}