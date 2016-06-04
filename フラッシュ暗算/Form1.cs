using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace フラッシュ暗算
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 開始ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Start();
            count = 0;
            total = 0;
        }
        int total;
        int count;
        Random rand = new Random();
        int max;

        private void timer1_Tick(object sender, EventArgs e)
        {
            int x = rand.Next(1, max);
            label1.Text = x.ToString();
            total += x;
            count++;
            if (count == 10)
            {
                timer1.Stop();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(total==int.Parse(textBox1.Text))
                MessageBox.Show("正解");
            else
                MessageBox.Show("正解は"+total);
        }

        private void 初級ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1000;//一秒
        }

        private void 中級ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Interval = 500;
        }

        private void 上級ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Interval = 200;
        }

        private void 桁ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            max = 10;
        }

        private void ケタToolStripMenuItem_Click(object sender, EventArgs e)
        {
            max = 100;
        }

        private void ケタToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            max = 1000;
        }

        private void ケタToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            max = 10000;
        }
    }
}
