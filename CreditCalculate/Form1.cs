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
    public partial class Form1 : Form
    {
        public Form1()
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
            var day = tb_ZimInDay.Text;
            int d = Convert.ToInt32(day);
            var zim = tb_PrProcent.Text;
            string[] newZim = zim.Split(';');
            int procent = 0;
            for (int i = 0; i <= d; i++)
            {
                string a = newZim[i];
                int ZimN = Convert.ToInt32(a);
                if (ZimN == 1)
                {
                     procent = ZimN * 100;
                }
                else
                {
                     procent = ZimN * 100 * d;
                }
            }
            MessageBox.Show(Convert.ToString(procent));
        }
        private void tb_ZimInDay_TextChanged(object sender, EventArgs e)
        {
            var day = tb_ZimInDay.Text;
        }
        private void tb_PrProcent_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
