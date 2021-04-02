using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MW_2021
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void главнаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            
        }

        private void вставкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
            pictureBox1.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() != System.Windows.Forms.DialogResult.Cancel)
                richTextBox1.SelectionColor = colorDialog1.Color;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Regular);
        }


       

       

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {

            pictureBox1.Visible = false;

            panel1.Visible = true;

            panel2.Visible = false;
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            {
                FontDialog myFontDialog = new FontDialog();
                if (myFontDialog.ShowDialog() == DialogResult.OK)
                    richTextBox1.Font = myFontDialog.Font;
                {

                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
           

            pictureBox1.Visible = !pictureBox1.Visible;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            pictureBox1.Visible = !pictureBox1.Visible;
        }
    }   
}
