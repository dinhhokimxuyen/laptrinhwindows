using System;
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
    public partial class Form5 : Form
    {
        decimal workingMemory = 0;
        string opr = "";
        public Form5()
        {
            InitializeComponent();
        }


        private void bt0_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += bt0.Text;
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += bt1.Text;
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += bt2.Text;
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += bt3.Text;
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            opr = btnCong.Text;
            workingMemory = decimal.Parse(txtDisplay.Text);
            txtDisplay.Clear();
        }

        private void btnBang_Click(object sender, EventArgs e)
        {
            decimal sencondValue = decimal.Parse(txtDisplay.Text);
            if (opr == "+")
                txtDisplay.Text = (workingMemory + sencondValue).ToString();
            if (opr == "*")
                txtDisplay.Text = (workingMemory * sencondValue).ToString();
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            opr = btnNhan.Text;
            workingMemory = decimal.Parse(txtDisplay.Text);
            txtDisplay.Clear();
        }

    }
}
