namespace SQL_Implementation
{
    partial class Form8
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
            resultTable = new DataGridView();
            orButton = new Button();
            label1 = new Label();
            filterTextBox = new TextBox();
            andButton = new Button();
            clearButton = new Button();
            button1 = new Button();
            columnsComboBox = new ComboBox();
            textBox2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)resultTable).BeginInit();
            SuspendLayout();
            // 
            // resultTable
            // 
            resultTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resultTable.Location = new Point(38, 301);
            resultTable.Margin = new Padding(4, 5, 4, 5);
            resultTable.Name = "resultTable";
            resultTable.RowHeadersWidth = 62;
            resultTable.RowTemplate.Height = 25;
            resultTable.Size = new Size(1060, 399);
            resultTable.TabIndex = 0;
            resultTable.CellContentClick += dataGridView1_CellContentClick;
            // 
            // orButton
            // 
            orButton.Location = new Point(381, 201);
            orButton.Name = "orButton";
            orButton.Size = new Size(112, 34);
            orButton.TabIndex = 1;
            orButton.Text = "OR";
            orButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(742, 67);
            label1.Name = "label1";
            label1.Size = new Size(65, 25);
            label1.TabIndex = 3;
            label1.Text = "Filter 2";
            // 
            // filterTextBox
            // 
            filterTextBox.Location = new Point(481, 95);
            filterTextBox.Name = "filterTextBox";
            filterTextBox.Size = new Size(150, 31);
            filterTextBox.TabIndex = 4;
            filterTextBox.TextChanged += filterTextBox_TextChanged;
            // 
            // andButton
            // 
            andButton.Location = new Point(167, 201);
            andButton.Name = "andButton";
            andButton.Size = new Size(112, 34);
            andButton.TabIndex = 5;
            andButton.Text = "AND";
            andButton.UseVisualStyleBackColor = true;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(609, 201);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(112, 34);
            clearButton.TabIndex = 6;
            clearButton.Text = "Clear Filter";
            clearButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(797, 201);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 7;
            button1.Text = "Filter";
            button1.UseVisualStyleBackColor = true;
            // 
            // columnsComboBox
            // 
            columnsComboBox.FormattingEnabled = true;
            columnsComboBox.Location = new Point(196, 93);
            columnsComboBox.Name = "columnsComboBox";
            columnsComboBox.Size = new Size(182, 33);
            columnsComboBox.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(742, 95);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 9;
            textBox2.TextChanged += textBox2_TextChanged_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(481, 67);
            label2.Name = "label2";
            label2.Size = new Size(65, 25);
            label2.TabIndex = 10;
            label2.Text = "Filter 1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(196, 65);
            label3.Name = "label3";
            label3.Size = new Size(74, 25);
            label3.TabIndex = 11;
            label3.Text = "Column";
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(columnsComboBox);
            Controls.Add(button1);
            Controls.Add(clearButton);
            Controls.Add(andButton);
            Controls.Add(filterTextBox);
            Controls.Add(label1);
            Controls.Add(orButton);
            Controls.Add(resultTable);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form8";
            Text = "Form8";
            Load += Form8_Load;
            ((System.ComponentModel.ISupportInitialize)resultTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView resultTable;
        private Button orButton;
        private Label label1;
        private TextBox filterTextBox;
        private Button andButton;
        private Button clearButton;
        private Button button1;
        private ComboBox columnsComboBox;
        private TextBox textBox2;
        private Label label2;
        private Label label3;
    }
}