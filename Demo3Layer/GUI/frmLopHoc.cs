using Demo3Layer.BUS;
using Demo3Layer.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo3Layer.GUI
{
    public partial class frmLopHoc : Form
    {
        private List<Class> classes;
        private readonly ClassBUS _classBUS = new ClassBUS();
        private int selectionId = 0;


        public frmLopHoc()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLopHoc_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            classes = _classBUS.GetAllClass();
            dataGridView1.Columns.Clear();

            DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
            imgCol.HeaderText = "Ảnh";
            imgCol.Name = "ImgUrl";
            dataGridView1.Columns.Add(imgCol);

            dataGridView1.Columns.Add("Mã", "Id");

            dataGridView1.Columns.Add("Tên", "ClassName");

            DataGridViewCheckBoxColumn dataGridViewCheck = new DataGridViewCheckBoxColumn(); ;
            dataGridViewCheck.HeaderText = "Check";
            dataGridViewCheck.Name = "check";
            dataGridView1.Columns.Add(dataGridViewCheck);

            foreach (Class c in classes)
            {
                if (string.IsNullOrEmpty(c.ImgUrl))
                {
                    continue;
                }

                var img = new Bitmap(c.ImgUrl);

                dataGridView1.Rows.Add(img, c.Id, c.ClassName,true);
            }
;
        }


        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            selectionId = dataGridView1.CurrentCell.RowIndex;
            if (selectionId >= classes.Count)
            {
                selectionId = classes.Count - 1;
            }
            textBox1.Text = classes[selectionId].Id?.ToString();
            textBox2.Text = classes[selectionId].ClassName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var lop = new Class(null, textBox2.Text, null);
            if (_classBUS.Add(lop))
            {
                loadData();
                return;
            }

            MessageBox.Show($"Không thể thêm lớp {textBox2.Text}!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_classBUS.Update(new(int.Parse(textBox1.Text), textBox2.Text, null)))
            {
                loadData();
                return;
            }

            MessageBox.Show("Không thể cập nhật lớp này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(int.TryParse(textBox1.Text, out int value) && _classBUS.Delete(value))
            {
                loadData();
                return;
            }

            MessageBox.Show("Không thể xóa lớp này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
