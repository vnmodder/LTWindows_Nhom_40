namespace Demo3Layer.GUI
{
    partial class frmSinhVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSinhVien));
            groupBox1 = new GroupBox();
            txtMail = new TextBox();
            label6 = new Label();
            numericUpDown1 = new NumericUpDown();
            dateTimePicker1 = new DateTimePicker();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            checkBox1 = new CheckBox();
            label4 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            comboBox1 = new ComboBox();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtMail);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(numericUpDown1);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(23, 73);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1280, 173);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin sinh viên";
            // 
            // txtMail
            // 
            txtMail.Location = new Point(829, 49);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(358, 39);
            txtMail.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(771, 52);
            label6.Name = "label6";
            label6.Size = new Size(60, 32);
            label6.TabIndex = 8;
            label6.Text = "Mail";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(577, 105);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(240, 39);
            numericUpDown1.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(116, 105);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(336, 39);
            dateTimePicker1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(384, 53);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(358, 39);
            textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(114, 56);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 39);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(893, 105);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(131, 36);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "Gới tính";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(491, 110);
            label4.Name = "label4";
            label4.Size = new Size(71, 32);
            label4.TabIndex = 1;
            label4.Text = "Điểm";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 105);
            label5.Name = "label5";
            label5.Size = new Size(45, 32);
            label5.TabIndex = 2;
            label5.Text = "NS";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(326, 56);
            label3.Name = "label3";
            label3.Size = new Size(52, 32);
            label3.TabIndex = 0;
            label3.Text = "Tên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 56);
            label2.Name = "label2";
            label2.Size = new Size(77, 32);
            label2.TabIndex = 0;
            label2.Text = "MSSV";
            // 
            // button4
            // 
            button4.Location = new Point(566, 263);
            button4.Name = "button4";
            button4.Size = new Size(150, 46);
            button4.TabIndex = 12;
            button4.Text = "Đóng";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(387, 263);
            button3.Name = "button3";
            button3.Size = new Size(150, 46);
            button3.TabIndex = 11;
            button3.Text = "Xóa";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(208, 263);
            button2.Name = "button2";
            button2.Size = new Size(150, 46);
            button2.TabIndex = 10;
            button2.Text = "Lưu";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(29, 263);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 9;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(23, 334);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(1279, 385);
            dataGridView1.TabIndex = 13;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 19);
            label1.Name = "label1";
            label1.Size = new Size(144, 32);
            label1.TabIndex = 14;
            label1.Text = "Tên lớp học:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(182, 18);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(574, 40);
            comboBox1.TabIndex = 15;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button5
            // 
            button5.Location = new Point(745, 263);
            button5.Name = "button5";
            button5.Size = new Size(150, 46);
            button5.TabIndex = 16;
            button5.Text = "Xuất file";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(924, 263);
            button6.Name = "button6";
            button6.Size = new Size(150, 46);
            button6.TabIndex = 17;
            button6.Text = "Đọc file";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Image = (Image)resources.GetObject("button7.Image");
            button7.ImageAlign = ContentAlignment.MiddleLeft;
            button7.Location = new Point(1103, 263);
            button7.Name = "button7";
            button7.Size = new Size(200, 46);
            button7.TabIndex = 18;
            button7.Text = "Tự gửi mail";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // frmSinhVien
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1342, 744);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Name = "frmSinhVien";
            Text = "SinhVien";
            Load += frmSinhVien_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private DataGridView dataGridView1;
        private NumericUpDown numericUpDown1;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox2;
        private TextBox textBox1;
        private CheckBox checkBox1;
        private Label label4;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox comboBox1;
        private Button button5;
        private Button button6;
        private Button button7;
        private TextBox txtMail;
        private Label label6;
    }
}