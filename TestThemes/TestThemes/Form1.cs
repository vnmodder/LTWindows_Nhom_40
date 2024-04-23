using MaterialSkin;
using MaterialSkin.Controls;
using System.Windows.Forms;

namespace TestThemes
{
    public partial class Form1 : Form
    {
        private List<UserControl1> customControls = new List<UserControl1>();

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                var item = new UserControl1();
                item.SetText($"{i + 1:00}");
                customControls.Add(item);
                flowLayoutPanel1.Controls.Add(item);
            }

            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.FlowDirection = FlowDirection.LeftToRight; // Hiển thị từ trái phải
            flowLayoutPanel1.WrapContents = true;
            flowLayoutPanel1.Padding = new Padding(10); // Khoảng cách giữa các custom control
            flowLayoutPanel1.AutoSize = false;

            comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (customControls.Count() < 1)
            {
                return;
            }

            var selectText = comboBox1.SelectedItem.ToString();
            if (selectText == "Tất cả")
            {
                flowLayoutPanel1.Controls.Clear();
                foreach (var item in customControls)
                {
                    flowLayoutPanel1.Controls.Add(item);
                }
            }
            else if (selectText == "Online")
            {
                flowLayoutPanel1.Controls.Clear();
                foreach (var item in customControls.Where(x => x.IsActive))
                {
                    flowLayoutPanel1.Controls.Add(item);
                }
            }
            else
            {
                flowLayoutPanel1.Controls.Clear();
                foreach (var item in customControls.Where(x => !x.IsActive))
                {
                    flowLayoutPanel1.Controls.Add(item);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {


            var item = new UserControl1();
            item.SetText($"{customControls.Count() + 1:00}");
            customControls.Add(item);
            flowLayoutPanel1.Controls.Add(item);
        }
    }
}
