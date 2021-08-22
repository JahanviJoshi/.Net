using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace multipleinheritance
{
    public partial class Form1 : Form
    {
        int area;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            rec a = new rec(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
            area = a.getarea();
            label3.Text = "Area is :" + area;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            rec a = new rec(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
            area = a.getarea();
            int cost = a.getcost(area);
            label3.Text += "\n Cost is:" + cost;
        }
    }
}
