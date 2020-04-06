using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView1.RowCount = 1;
            rando();
            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
        }
        /// <summary>
        /// Заполнение массива случайными значениями.
        /// </summary>
        public void rando()
        {
            Random rand = new Random();
            int r = Convert.ToInt32(textBox1.Text);
            dataGridView1.ColumnCount = r;
            int[] mas = new int[r];
            for (int i = 0; i < r; i++)
            {
                dataGridView1.Columns[i].Name = "Ячейка " + i.ToString();
                mas[i] = rand.Next() % 10;
                dataGridView1.Rows[0].Cells[i].Value = mas[i];
            }
        }
        /// <summary>
        /// Заполнение массива 0.
        /// </summary>
        public void zero()
        {
            int r = Convert.ToInt32(textBox1.Text);
            dataGridView1.ColumnCount = r;
            int[] mas = new int[r];
            for (int i = 0; i < r; i++)
            {
                dataGridView1.Columns[i].Name = "Ячейка " + i.ToString();
                mas[i] = 0;
                dataGridView1.Rows[0].Cells[i].Value = mas[i];
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int r = dataGridView1.ColumnCount; 
            int[] mas = new int[r];
            for (int i = 0; i < r; i++)
            {
                mas[i] = Convert.ToInt32(dataGridView1.Rows[0].Cells[i].Value);
            }
            int min = mas[0], max = mas[0];
            for (int i = 0; i < r; i++)
            {
                if (min > mas[i])
                    min = mas[i];
                if (max < mas[i])
                    max = mas[i];
            }
            for (int i = 0, q = 0, w = 0; i < r; i++)
            {
                if ((q == 1 && w == 0) || (q == 0 && w == 1))
                {
                    dataGridView1.Rows[0].Cells[i].Value = mas[i] * 2;
                }
                if (min == mas[i] && q == 0)
                {
                    dataGridView1.Rows[0].Cells[i].Value = max;
                    q++;
                }
                if (max == mas[i] && w == 0)
                {
                    dataGridView1.Rows[0].Cells[i].Value = min;
                    w++;
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if ((textBox1.Text != "") && (Convert.ToInt32(textBox1.Text) <= 400) && (Convert.ToInt32(textBox1.Text) >= 2))
            {
                button2.Enabled = true;
                if (radioButton1.Checked)
                    rando();
            }
            else
                button2.Enabled = false;
            if (button2.Enabled)
            {
                dataGridView1.ColumnCount = Convert.ToInt32(textBox1.Text);
            }
            if (radioButton2.Checked)
                zero();
        }

        private void KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back))
                return;
            e.KeyChar = '\0';
        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress += new KeyPressEventHandler(KeyPress);
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            rando();
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            dataGridView1.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // Получаем выбранный файл.
            string filename = openFileDialog1.FileName;
            // Читаем файл в строку.
            string fileText = System.IO.File.ReadAllText(filename);
            // Разделяем строку на переменные. 
            string[] list = fileText.Split(' ');
            int r = list.Length;
            textBox1.Text = r.ToString();
            int[] mas = new int[r];
            dataGridView1.ColumnCount = r;
            for (int i = 0; i < r; i++)
            {
                dataGridView1.Columns[i].Name = "Ячейка " + i.ToString();
                mas[i] = Convert.ToInt32(list[i]);
                dataGridView1.Rows[0].Cells[i].Value = mas[i];
            }
            MessageBox.Show("Файл: "+ filename+ " открыт!");
        }
    }
}