using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApplication10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            dataGridView1.RowCount = 5;
            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "Страна";
            dataGridView1.Columns[1].Name = "Кол-во медалей";
            dataGridView1.Columns[2].Name = "% медалей";
        }
        public static int[] strana = new int[5];
        public static string[] Ns=new string[5];
        public static ComboBox comboB;
        public static TextBox textB;
        public static DataGridView dataG;

        //Для теста
        public int test(int a)
        {
            if (a > 0)
                return 1;
            else
            {
                dataGridView1.ColumnCount = a;
                return 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboB = comboBox1; textB = textBox1; dataG = dataGridView1;
            Class1.Redact();
            dataGridView1 = dataG;
            Diagram();
            button2.Enabled = true;
        }

        private void Diagram()// метод рисует круговую диаграмму
        {
            chart1.Series.Clear();
            // Форматировать диаграмму
            chart1.BackColor = Color.Gray;
            chart1.BackSecondaryColor = Color.WhiteSmoke;
            chart1.BackGradientStyle = GradientStyle.DiagonalRight;

            chart1.BorderlineDashStyle = ChartDashStyle.Solid;
            chart1.BorderlineColor = Color.Gray;
            chart1.BorderSkin.SkinStyle = BorderSkinStyle.None;

            // Форматировать область диаграммы
            chart1.ChartAreas[0].BackColor = Color.Wheat;

            // Добавить и форматировать заголовок
            chart1.Titles.Clear();
            chart1.Titles.Add("Спорт");
            chart1.Titles[0].Font = new Font("Utopia", 16);

            chart1.Series.Add(new Series("ColumnSeries") { ChartType = SeriesChartType.Pie });

            string[] xValues = new string[Ns.Length];
            double[] yValues = new double[Ns.Length];
            for (int i = 0; i < Ns.Length; i++)
            {
                xValues[i] = dataGridView1.Rows[i].Cells[0].Value.ToString();
                yValues[i] = Convert.ToDouble(dataGridView1.Rows[i].Cells[1].Value);
            }
            chart1.Series["ColumnSeries"].Points.DataBindXY(xValues, yValues);
            chart1.ChartAreas[0].Area3DStyle.Enable3D = true;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back))
                return;
            e.KeyChar = '\0';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialog1.FileName;
            string save = "Олимпийские игры" + Environment.NewLine;
            for (int i = 0; i < Ns.Length; i++)
                save += dataGridView1.Rows[i].Cells[0].Value.ToString() + Environment.NewLine + dataGridView1.Rows[i].Cells[1].Value.ToString() + Environment.NewLine;
            System.IO.File.WriteAllText(filename, save);
            MessageBox.Show("Файл сохранен");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string[] txt = System.IO.File.ReadAllLines(openFileDialog1.FileName);
            for (int i = 0; i < Ns.Length; i++)
            {
                strana[i]= Convert.ToInt32(txt[2 + i * 2]);
                dataGridView1.Rows[i].Cells[0].Value = txt[1+i*2];
                dataGridView1.Rows[i].Cells[1].Value = strana[i];
            }
            int sum = 0;
            for (int i = 0; i < Ns.Length; i++)
                sum += strana[i];
            for (int i = 0; i < Ns.Length; i++)
            {
                if (strana[i] != 0)
                    dataGridView1.Rows[i].Cells[2].Value = (Convert.ToInt32(Convert.ToDouble(strana[i]) / sum * 100)).ToString() + "%";
                else
                    dataGridView1.Rows[i].Cells[2].Value = "0%";
            }
            Diagram();
            button2.Enabled = true;
        }
    }
}