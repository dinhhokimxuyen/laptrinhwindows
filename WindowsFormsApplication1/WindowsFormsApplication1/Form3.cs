﻿using System;
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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            long kq = int.Parse(txtx.Text) + int.Parse(txty.Text);
            txtkq.Text = kq.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            long kq = int.Parse(txtx.Text) * int.Parse(txty.Text);
            txtkq.Text = kq.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
