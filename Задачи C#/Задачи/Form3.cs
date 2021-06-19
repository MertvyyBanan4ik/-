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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        Double A, P,  h;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            P = Convert.ToDouble(textBox2.Text);
            h = Convert.ToDouble(textBox3.Text);
            
            
            A = P * h;
            textBox1.Text = Convert.ToString(A);
        }
    }
}
