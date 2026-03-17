namespace FINAL_KINJO
{
    partial class FrmMasterlist
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
            button1 = new Button();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            textBox1 = new TextBox();
            button2 = new Button();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            button3 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 63);
            label1.Name = "label1";
            label1.Size = new Size(276, 32);
            label1.TabIndex = 0;
            label1.Text = "STUDENT MASTER LIST";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(310, 69);
            button1.Name = "button1";
            button1.Size = new Size(127, 28);
            button1.TabIndex = 1;
            button1.Text = "REFRESH";
            button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 187);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(425, 436);
            dataGridView1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(577, 76);
            label2.Name = "label2";
            label2.Size = new Size(264, 21);
            label2.TabIndex = 0;
            label2.Text = "UPDATE STUDENT INFORMATION";
            label2.Click += label2_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(12, 141);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(258, 27);
            textBox1.TabIndex = 3;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(276, 136);
            button2.Name = "button2";
            button2.Size = new Size(95, 37);
            button2.TabIndex = 4;
            button2.Text = "SEARCH";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(577, 119);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(250, 23);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(577, 148);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(250, 23);
            textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(577, 177);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(250, 23);
            textBox4.TabIndex = 7;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(577, 264);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(250, 23);
            textBox5.TabIndex = 8;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "HM", "BSOA", "ACT", "PULIS" });
            comboBox1.Location = new Point(577, 206);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(250, 23);
            comboBox1.TabIndex = 9;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "ACT -1A", "ACT - 1B", "ACT - 1C", "ACT - 1D", "ACT - 1E", "ACT - 1F\t" });
            comboBox2.Location = new Point(577, 235);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(250, 23);
            comboBox2.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold | FontStyle.Italic);
            label3.Location = new Point(539, 122);
            label3.Name = "label3";
            label3.Size = new Size(29, 20);
            label3.TabIndex = 11;
            label3.Text = "ID:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold | FontStyle.Italic);
            label4.Location = new Point(467, 148);
            label4.Name = "label4";
            label4.Size = new Size(101, 20);
            label4.TabIndex = 12;
            label4.Text = "FIRST NAME:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold | FontStyle.Italic);
            label5.Location = new Point(467, 177);
            label5.Name = "label5";
            label5.Size = new Size(97, 20);
            label5.TabIndex = 13;
            label5.Text = "LAST NAME:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold | FontStyle.Italic);
            label6.Location = new Point(484, 206);
            label6.Name = "label6";
            label6.Size = new Size(71, 20);
            label6.TabIndex = 14;
            label6.Text = "COURSE:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold | FontStyle.Italic);
            label7.Location = new Point(480, 235);
            label7.Name = "label7";
            label7.Size = new Size(76, 20);
            label7.TabIndex = 15;
            label7.Text = "SECTION:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold | FontStyle.Italic);
            label8.Location = new Point(512, 264);
            label8.Name = "label8";
            label8.Size = new Size(43, 20);
            label8.TabIndex = 16;
            label8.Text = "AGE:";
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(577, 302);
            button3.Name = "button3";
            button3.Size = new Size(250, 45);
            button3.TabIndex = 17;
            button3.Text = "SAVE RECORD";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(577, 353);
            button4.Name = "button4";
            button4.Size = new Size(250, 55);
            button4.TabIndex = 18;
            button4.Text = "DELETE RECORD";
            button4.UseVisualStyleBackColor = true;
            // 
            // FrmMasterlist
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(864, 649);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "FrmMasterlist";
            Text = "FrmMasterlist";
            Load += FrmMasterlist_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private DataGridView dataGridView1;
        private Label label2;
        private TextBox textBox1;
        private Button button2;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button button3;
        private Button button4;
    }
}