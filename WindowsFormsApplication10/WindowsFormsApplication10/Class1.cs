using System;

namespace WindowsFormsApplication10
{
    class Class1
    {
        public static void Redact()
        {
            Form1.Ns[0] = "Россия";
            Form1.Ns[1] = "Великобритания";
            Form1.Ns[2] = "Украина";
            Form1.Ns[3] = "Польша";
            Form1.Ns[4] = "США";
            int sum = 0;
            for (int i = 0; i < Form1.Ns.Length; i++)
            {
                if (Form1.comboB.Text == Form1.Ns[i] && Form1.textB.Text != "")
                    Form1.strana[i] = Convert.ToInt32(Form1.textB.Text);
                sum += Form1.strana[i];
                Form1.dataG.Rows[i].Cells[0].Value = Form1.Ns[i];
                Form1.dataG.Rows[i].Cells[1].Value = Form1.strana[i];
            }
            for (int i = 0; i < Form1.Ns.Length; i++)
            {
                if (Form1.strana[i] != 0)
                    Form1.dataG.Rows[i].Cells[2].Value = (Convert.ToInt32(Convert.ToDouble(Form1.strana[i]) / sum * 100)).ToString() + "%";
                else
                    Form1.dataG.Rows[i].Cells[2].Value = "0%";
            }
        }
    }
}