using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            off();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString(Class1.rast(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text), Convert.ToDouble(textBox3.Text), Convert.ToDouble(textBox4.Text)));
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox btn = sender as TextBox;
            if (Char.IsDigit(e.KeyChar) || (e.KeyChar == ',' && btn.Text.IndexOf(',') == -1) || (e.KeyChar == '-' && btn.Text.IndexOf('-') == -1) || e.KeyChar == (char)Keys.Back)
                return;
            e.KeyChar = '\0';
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != ""&& textBox4.Text != "")
                button1.Enabled = true;
            else
                button1.Enabled = false;
            if (textBox6.Text != "" && textBox7.Text != "" && textBox8.Text != "" && textBox9.Text != "" && textBox10.Text != "" && textBox11.Text != "" && textBox12.Text != "" && textBox13.Text != "" && textBox14.Text != "" && textBox15.Text != "" && textBox16.Text != "" && textBox17.Text != "")
                button2.Enabled = true;
            else
                button2.Enabled = false;
        }
        public void off()
        {
            textBox6.Enabled = false;
            textBox7.Enabled = false;
            textBox8.Enabled = false;
            textBox9.Enabled = false;
            textBox10.Enabled = false;
            textBox11.Enabled = false;
            textBox12.Enabled = false;
            textBox13.Enabled = false;
            textBox14.Enabled = false;
            textBox15.Enabled = false;
            textBox16.Enabled = false;
            textBox17.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                Random rand = new Random();
                int r = Convert.ToInt32(textBox5.Text);
                double[] x = new double[r];
                double[] y = new double[r];
                for (int i = 0; i < r; i++)
                {
                    x[i] = rand.Next(-100, 100);
                    y[i] = rand.Next(-100, 100);
                }
                label6.Text = Class1.Min(x, y);
                label22.Text = "Минимальное расстояние между точками: ";
            }
            else if (radioButton2.Checked == true)
            {
                int r = Convert.ToInt32(textBox5.Text);
                double[] x = new double[r];
                double[] y = new double[r];
                x[0] = Convert.ToDouble(textBox9.Text);
                y[0] = Convert.ToDouble(textBox8.Text);
                x[1] = Convert.ToDouble(textBox7.Text);
                y[1] = Convert.ToDouble(textBox6.Text);
                if (r>=3)
                {
                    x[2] = Convert.ToDouble(textBox13.Text);
                    y[2] = Convert.ToDouble(textBox12.Text);
                    if (r >= 4)
                    {
                        x[3] = Convert.ToDouble(textBox11.Text);
                        y[3] = Convert.ToDouble(textBox10.Text);
                        if (r >= 5)
                        {
                            x[4] = Convert.ToDouble(textBox17.Text);
                            y[4] = Convert.ToDouble(textBox16.Text);
                            if (r >= 6)
                            {
                                x[5] = Convert.ToDouble(textBox15.Text);
                                y[5] = Convert.ToDouble(textBox14.Text);
                            }
                        }
                    }
                }
                label6.Text = Class1.Min(x, y);
                label22.Text = "Минимальное расстояние между точками: ";
            }
        }

        public void textBox5_TextChanged(object sender, EventArgs e)
        {
            off();
            if (textBox5.Text != "" && Convert.ToInt32(textBox5.Text) > 1)
            {
                button2.Enabled = true;
                int r = Convert.ToInt32(textBox5.Text);
                {
                    if (radioButton2.Checked)
                        if (r >= 2)
                        {
                            textBox6.Enabled = true;
                            textBox7.Enabled = true;
                            textBox8.Enabled = true;
                            textBox9.Enabled = true;
                            if (r >= 3)
                            {
                                textBox13.Enabled = true;
                                textBox12.Enabled = true;
                                if (r >= 4)
                                {
                                    textBox11.Enabled = true;
                                    textBox10.Enabled = true;
                                    if (r >= 5)
                                    {
                                        textBox16.Enabled = true;
                                        textBox17.Enabled = true;
                                        if (r >= 6)
                                        {
                                            on();
                                        }
                                    }
                                }
                            }
                        }
                        else
                        {
                            off();
                        }
                }
            }
            else
                button2.Enabled = false;
            
        }
        private void textBox_KeyPress1(object sender, KeyPressEventArgs e)
        {
            TextBox btn = sender as TextBox;
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back)
                return;
            e.KeyChar = '\0';
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            off();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox5.Text == "")
                textBox5.Text = "2";
            int r = Convert.ToInt32(textBox5.Text);
            {
                if (radioButton2.Checked)
                    if (r >= 2)
                    {
                        textBox6.Enabled = true;
                        textBox7.Enabled = true;
                        textBox8.Enabled = true;
                        textBox9.Enabled = true;
                        if (r >= 3)
                        {
                            textBox13.Enabled = true;
                            textBox12.Enabled = true;
                            if (r >= 4)
                            {
                                textBox11.Enabled = true;
                                textBox10.Enabled = true;
                                if (r >= 5)
                                {
                                    textBox16.Enabled = true;
                                    textBox17.Enabled = true;
                                    if (r >= 6)
                                    {
                                        on();
                                    }
                                }
                            }
                        }
                    }
            }
        }
        public void on()
        {
            textBox6.Enabled = true;
            textBox7.Enabled = true;
            textBox8.Enabled = true;
            textBox9.Enabled = true;
            textBox10.Enabled = true;
            textBox11.Enabled = true;
            textBox12.Enabled = true;
            textBox13.Enabled = true;
            textBox14.Enabled = true;
            textBox15.Enabled = true;
            textBox16.Enabled = true;
            textBox17.Enabled = true;
        }
    }
}