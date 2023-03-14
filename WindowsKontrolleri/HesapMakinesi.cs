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
    public partial class HesapMakinesi : Form
    {
        public HesapMakinesi()
        {
            InitializeComponent();
            btn_kok.Text = "\u221b";
            btn_kare.Text = "x\u02e3";
        }

        private void btn_sayi_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
           
            if (tb_ekran.Text != "0")
            {
                tb_ekran.Text += btn.Text;
            }
            else
            {
                tb_ekran.Text = "";
                tb_ekran.Text += btn.Text;
            }
        }
    }
}
