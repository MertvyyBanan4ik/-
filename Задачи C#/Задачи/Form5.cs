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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        double A, m, g, h;

        private void button1_Click(object sender, EventArgs e)
        {
            m = Convert.ToDouble(textBox2.Text);
            g = Convert.ToDouble(textBox1.Text);
            h = Convert.ToDouble(textBox4.Text);
            A = m * g * h;

            textBox3.Text = Convert.ToString(A);
        }

        private double y(double v)
        {
            throw new NotImplementedException();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            
        }
    }
}
