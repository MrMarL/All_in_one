using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Random rnd = new Random();

            int value = rnd.Next(0, 10);
        }
        int y = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = 150;
            do
            {
                y = y + 1;
                this.button1.Location = new Point(0, y);
                i--;
                System.Threading.Thread.Sleep(2);
            }
            while (i > 0);
        }
    }
}
