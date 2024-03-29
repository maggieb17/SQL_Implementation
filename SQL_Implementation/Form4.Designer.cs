namespace SQL_Implementation
{
    partial class Form4
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
            nextButton = new Button();
            SuspendLayout();
            // 
            // datatextBox
            // 
            datatextBox.Location = new Point(154, 127);
            datatextBox.Name = "datatextBox";
            datatextBox.Size = new Size(150, 31);
            datatextBox.TabIndex = 0;
            // 
            // nextButton
            // 
            nextButton.Location = new Point(170, 217);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(112, 34);
            nextButton.TabIndex = 1;
            nextButton.Text = "next";
            nextButton.UseVisualStyleBackColor = true;
            nextButton.Click += nextButton_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(509, 398);
            Controls.Add(nextButton);
            Controls.Add(datatextBox);
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox datatextBox;
        private Button nextButton;
    }
}