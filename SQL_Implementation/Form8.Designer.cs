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
            andButton = new Button();
            clearButton = new Button();
            button1 = new Button();
            columnsComboBox = new ComboBox();
            textBox2 = new TextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)resultTable).BeginInit();
            SuspendLayout();
            // 
            // resultTable
            // 
            resultTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resultTable.Location = new Point(27, 181);
            resultTable.Name = "resultTable";
            resultTable.RowHeadersWidth = 62;
            resultTable.RowTemplate.Height = 25;
            resultTable.Size = new Size(742, 239);
            resultTable.TabIndex = 0;
            resultTable.CellContentClick += dataGridView1_CellContentClick;
            // 
            // orButton
            // 
            orButton.Enabled = false;
            orButton.Location = new Point(267, 121);
            orButton.Margin = new Padding(2);
            orButton.Name = "orButton";
            orButton.Size = new Size(78, 20);
            orButton.TabIndex = 1;
            orButton.Text = "OR";
            orButton.UseVisualStyleBackColor = true;
            orButton.Click += orButton_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(348, 39);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 3;
            label1.Text = "Filter";
            // 
            // andButton
            // 
            andButton.Enabled = false;
            andButton.Location = new Point(117, 121);
            andButton.Margin = new Padding(2);
            andButton.Name = "andButton";
            andButton.Size = new Size(78, 20);
            andButton.TabIndex = 5;
            andButton.Text = "AND";
            andButton.UseVisualStyleBackColor = true;
            andButton.Click += andButton_Click_1;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(426, 121);
            clearButton.Margin = new Padding(2);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(78, 20);
            clearButton.TabIndex = 6;
            clearButton.Text = "Clear Filter";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click_1;
            // 
            // button1
            // 
            button1.Location = new Point(558, 121);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(78, 20);
            button1.TabIndex = 7;
            button1.Text = "Filter";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // columnsComboBox
            // 
            columnsComboBox.FormattingEnabled = true;
            columnsComboBox.Location = new Point(137, 56);
            columnsComboBox.Margin = new Padding(2);
            columnsComboBox.Name = "columnsComboBox";
            columnsComboBox.Size = new Size(129, 23);
            columnsComboBox.TabIndex = 8;
            columnsComboBox.SelectedIndexChanged += columnsComboBox_SelectedIndexChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(348, 56);
            textBox2.Margin = new Padding(2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(106, 23);
            textBox2.TabIndex = 9;
            textBox2.TextChanged += textBox2_TextChanged_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(137, 39);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 11;
            label3.Text = "Column";
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(columnsComboBox);
            Controls.Add(button1);
            Controls.Add(clearButton);
            Controls.Add(andButton);
            Controls.Add(label1);
            Controls.Add(orButton);
            Controls.Add(resultTable);
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
        private Button andButton;
        private Button clearButton;
        private Button button1;
        private ComboBox columnsComboBox;
        private TextBox textBox2;
        private Label label3;
    }
}