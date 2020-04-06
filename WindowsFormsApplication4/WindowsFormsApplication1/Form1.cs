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
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
                double ygol = Convert.ToDouble(textBox1.Text);
                if (radioButton1.Checked)
                    ygol *= Math.PI / 180;
                double z1, z2;
                z1 = (Math.Pow((Math.Cos(3.0 / 8 * Math.PI - ygol / 4)), 2)) - (Math.Pow((Math.Cos(11.0 / 8 * Math.PI + ygol / 4)), 2));
                z2 = (Math.Sqrt(2) / 2) * Math.Sin(ygol/2);
                label2.Text = "z1=" + z1.ToString() + Environment.NewLine + "z2=" + z2.ToString();
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label2.BackColor = Color.Red;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.BackColor = Color.White;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        { 
            if (Char.IsDigit(e.KeyChar) || (e.KeyChar == ',' && textBox1.Text.IndexOf(',') == -1) || e.KeyChar == (char)Keys.Back)
                return;
            e.KeyChar = '\0';
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
                button1.Enabled = true;
            else
                button1.Enabled = false;
        }
    }
}
