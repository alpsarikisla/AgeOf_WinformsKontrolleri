using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsKontrolleri
{
    public partial class BasitHesapMakinesi : Form
    {
        public BasitHesapMakinesi()
        {
            InitializeComponent();
        }

        private void btn_topla_Click(object sender, EventArgs e)
        {
            double s1 = Convert.ToDouble(tb_sayi1.Text);
            double s2 = Convert.ToDouble(tb_sayi2.Text);
            tb_sonuc.Text = (s1 + s2).ToString();
        }

        private void btn_cikar_Click(object sender, EventArgs e)
        {
            double s1 = Convert.ToDouble(tb_sayi1.Text);
            double s2 = Convert.ToDouble(tb_sayi2.Text);
            tb_sonuc.Text = (s1 - s2).ToString();
        }

        private void btn_carp_Click(object sender, EventArgs e)
        {
            double s1 = Convert.ToDouble(tb_sayi1.Text);
            double s2 = Convert.ToDouble(tb_sayi2.Text);
            tb_sonuc.Text = (s1 * s2).ToString();
        }

        private void btn_bol_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(tb_sayi2.Text) != 0)
            {
                double s1 = Convert.ToDouble(tb_sayi1.Text);
                double s2 = Convert.ToDouble(tb_sayi2.Text);
                tb_sonuc.Text = (s1 / s2).ToString();
            }
            else
            {
                MessageBox.Show("sıfır'a bölme tanımsızdır");
            }
        }
    }
}
