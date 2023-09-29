using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            int x = int.Parse(txtx.Text);
            int y = int.Parse(txty.Text);
            int kq = x + y;
            txtkq.Text=txtkq.Text+x.ToString()+" + " +y.ToString() +" = " + kq.ToString() + "\r\n";
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            int x = int.Parse(txtx.Text);
            int y = int.Parse(txty.Text);
            int kq = x * y;
            txtkq.Text = txtkq.Text + x.ToString() + " * " + y.ToString() + " = " + kq.ToString() + "\r\n";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("Caculator.txt", true);
            sw.Write(txtkq.Text);
            sw.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
