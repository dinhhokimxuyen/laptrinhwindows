using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        public ArrayList GetData(){
            ArrayList lst = new ArrayList();

            Faculty f = new Faculty();
            f.Id = "K01";
            f.Name = "Công nghệ thông tin";
            f.Quantity = 1200;
            lst.Add(f);

            f = new Faculty();
            f.Id = "K02";
            f.Name = "Quản trị kinh doanh";
            f.Quantity = 4200;
            lst.Add(f);

            f = new Faculty();
            f.Id = "K03";
            f.Name = "Kế toán tài chính";
            f.Quantity = 5200;
            lst.Add(f);
            return lst;
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            ArrayList lst = GetData();
            comboBox1.DataSource = lst;
            comboBox1.DisplayMember = "Name";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.ValueMember = "Id";
            string id = comboBox1.SelectedValue.ToString();
            richTextBox1.Text = "Bạn đã chọn khoa có mã:" + id;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.ValueMember = "Name";
            string name = comboBox1.SelectedValue.ToString();
            richTextBox1.Text = "Bạn đã chọn khoa có tên :" + name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

    }
}
