using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Задачи
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        double A, m, g, l, x;

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            m = Convert.ToDouble(textBox2.Text);
            g = Convert.ToDouble(textBox3.Text);
            l = Convert.ToDouble(textBox4.Text);
            x = Convert.ToDouble(textBox5.Text);
            A = m * g * l * x;


            textBox1.Text = Convert.ToString(A);
        }
    }
}
