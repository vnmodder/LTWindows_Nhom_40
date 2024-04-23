using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace TestThemes
{
    public partial class UserControl1 : UserControl
    {

        private bool isActive;
        public UserControl1()
        {
            InitializeComponent();
            BackColor = Color.Aqua;
        }

        public bool IsActive { get; set; }

        public void SetText(string title)
        {
            this.label1.Text = title;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private Form2 form2;
        private void button1_Click(object sender, EventArgs e)
        {
            if(button1.Text == "Bật máy")
            {
                button1.Text = "Tắt máy";
                BackColor = Color.Green;
                IsActive = true;
                form2 = new Form2();
                form2.SetTitle(label1.Text);
                form2.Show();
            }
            else
            {
                button1.Text = "Bật máy";
                BackColor = Color.Aqua;
                IsActive = false;
                form2?.Close();
            }
        }
    }
}
