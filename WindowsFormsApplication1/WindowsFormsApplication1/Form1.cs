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
    public partial class Form1 : Form
    {
        public int f;
        public Form1()
        {
            InitializeComponent();
            Controls.Remove(button6);
            Controls.Remove(button7);
            Controls.Remove(button8);
            Controls.Remove(pictureBox1);
        }

        public void button10_Click(object sender, EventArgs e)
        {
            Controls.Add(pictureBox1);
            Controls.Remove(button10);
            f = 1;
            System.Diagnostics.Process.Start("explorer", "https://mrmarl.wixsite.com/mrmarl");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a , b;
            a = 0;
            b = 0;
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Ошибка");
            }
            else
            {
                a = Convert.ToInt32(textBox1.Text);
                b = Convert.ToInt32(textBox2.Text);
            }
            label1.Text = Arifm.sum(a, b).ToString();
            label2.Text = ("+");
            label3.Text = ("=");
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {         
            int a, b;
            a = 0;
            b = 0;
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Ошибка");
            }
            else
            {
                a = Convert.ToInt32(textBox1.Text);
                b = Convert.ToInt32(textBox2.Text);
            }
            label1.Text = Arifm.ymn(a, b).ToString();
            label2.Text = ("*");
            label3.Text = ("=");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a, b;
            a = 0;
            b = 0;
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Ошибка");
            }
            else
            {
                a = Convert.ToInt32(textBox1.Text);
                b = Convert.ToInt32(textBox2.Text);
            }
            label1.Text = Arifm.min(a, b).ToString();
            label2.Text = ("-");
            label3.Text = ("=");
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 45) // цифры, клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 45) // цифры, клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a, b;
            a = 0;
            b = 1;
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Ошибка");
            }
            else
            {
                a = Convert.ToInt32(textBox1.Text);
                b = Convert.ToInt32(textBox2.Text);
            }
            if (b == 0)
            {
                MessageBox.Show("Ошибка");
            }
            else
            {
                label1.Text = Arifm.del(a, b).ToString();
                label2.Text = ("/");
                label3.Text = ("=");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button5_Click_1(object sender, EventArgs e)
        {
            Controls.Remove(pictureBox1);
            Controls.Remove(textBox1);
            Controls.Remove(button1);
            Controls.Remove(button2);
            Controls.Remove(button3);
            Controls.Remove(button4);
            Controls.Remove(button5);
            Controls.Add(button6);
            Controls.Add(button7);
            Controls.Add(button8);
            label2.Text = "";
            label3.Text = "";
            label1.Text = "";
            if (f == 1)
            {
                Controls.Add(pictureBox1);
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            Controls.Remove(pictureBox1);
            Controls.Remove(button6);
            Controls.Remove(button7);
            Controls.Remove(button8);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(textBox1);
            label2.Text = "";
            label3.Text = "";
            label1.Text = "";
            if (f == 1)
            {
                Controls.Add(pictureBox1);
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            int a;
            a = 0;
            label2.Text = "√";
            label3.Text = ("=");
            if (textBox2.Text == "")
            {
                MessageBox.Show("Ошибка");
            }
            else
            {
                a = Convert.ToInt32(textBox2.Text);
                if (a < 0)
                    MessageBox.Show("Ошибка");
                else
                {
                    label1.Text = Arifm.koren(a).ToString();
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int a;
            a = 0;
            label2.Text = "";
            label3.Text = ("=");
            if (textBox2.Text == "")
            {
                MessageBox.Show("Ошибка");
            }
            else
            {
                a = Convert.ToInt32(textBox2.Text);
                label1.Text = Arifm.kvad(a).ToString();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Random rnd = new Random(DateTime.Now.Millisecond);
            this.BackColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
        }
        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
