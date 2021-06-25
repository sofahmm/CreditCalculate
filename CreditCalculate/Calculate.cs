using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreditCalculate
{
    public partial class Calculate : Form
    {

        public Calculate()
        {
            InitializeComponent();
        }

        private void tb_SumInRub_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tb_PrDay_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_rassch_Click(object sender, EventArgs e)
        {
            var t = tb_SumInRub.Text;
            int NewT = Convert.ToInt32(t);

            var day = tb_ZimInDay.Text;
            int d = Convert.ToInt32(day);
            var zim = tb_PrProcent.Text;
            string[] newZim = zim.Split(';');
            double procent = 0.0;

            for (int i = 0; i <= d; i++)
            {

                string a = newZim[i];
                double ZimN = Convert.ToDouble(a);
                if (ZimN == 1)
                {
                     procent = ZimN * 100.0;
                }
                else
                {
                     procent = ZimN * 100.0 * d;
                }
            }

            double y = procent + Convert.ToDouble(NewT);
            double r = (procent / Convert.ToDouble(NewT) / d)*100;
            MessageBox.Show(Convert.ToString(procent) ,"накопительные");
            MessageBox.Show(Convert.ToString(y), "Общая сумма выплаты");
            MessageBox.Show(Convert.ToString(r) + "%", "Эффективная ставка");

            try
            {
                NewT = 500001;
            }

            catch
            {
                MessageBox.Show("ВВЕДЕННАЯ СУММА НЕ ДОЛЖНА ПРЕВЫШАТЬ 500000");
            }
        }
        private void tb_ZimInDay_TextChanged(object sender, EventArgs e)
        {
            var day = tb_ZimInDay.Text;
        }
        private void tb_PrProcent_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "TXT(*.txt)|(*.TXT)";
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                
            }
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
