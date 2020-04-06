using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1_Tick(timer1,new EventArgs());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime d;
            d = DateTime.Now;
            label1.Text = d.ToLongDateString();
            label2.Text = d.ToLongTimeString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime d_Now, d_User;
            d_Now = DateTime.Now;
            // сегодняшняя дата
            d_User = Convert.ToDateTime(maskedTextBox1.Text);  // ввод даты рождения 
            if (d_Now < d_User)
                label3.Text = "Вы ещё не родились. Введите дату правильно!";
            else
            {
                int year = (d_Now.Year - d_User.Year);
                int m = d_Now.Month - d_User.Month;
                int d = d_Now.Day - d_User.Day;
                if (m < 0)
                    year--;
                if (d < 0 && m==0)
                    year--;

                string godi = " лет";
                if (year%10 == 1)
                    godi = " год";
                if (year % 10 >= 2 && year % 10 <= 4)
                    godi = " года";
                label3.Text ="Тебе уже "+ (year).ToString() + godi;
            }
        }
    }
}
