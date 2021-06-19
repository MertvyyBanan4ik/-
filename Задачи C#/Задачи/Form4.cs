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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        double T, A, S;

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            A = Convert.ToDouble(textBox2.Text);
             S = Convert.ToDouble(textBox3.Text);


            T = A / S;
            textBox4.Text = Convert.ToString(T);
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
