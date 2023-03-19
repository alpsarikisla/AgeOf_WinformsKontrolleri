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
    public partial class TarihKontrolleri : Form
    {
        public TarihKontrolleri()
        {
            InitializeComponent();
        }

        private void TarihKontrolleri_Load(object sender, EventArgs e)
        {
            DateTime simdi = DateTime.Now;
            lbl_guncel.Text = simdi.ToString();
            //monthCalendar1.MaxDate = DateTime.Now;
            nud_saat.Value = simdi.Hour;
            nud_dakika.Value = simdi.Minute;
        }

        private void btn_tarihGetir_Click(object sender, EventArgs e)
        {
            lbl_ekran.Text = dtp_tarih.Text;//Metinsel olarak gelir
            DateTime secilen = dtp_tarih.Value;
            lbl_ekran.Text = secilen.ToShortDateString();
        }

        private void btn_tarihgetir2_Click(object sender, EventArgs e)
        {
            //lbl_ekran2.Text = monthCalendar1.SelectionStart.ToShortDateString() + " - " + monthCalendar1.SelectionEnd.ToShortDateString();
            SelectionRange sr = monthCalendar1.SelectionRange;
            //lbl_ekran2.Text = sr.Start.ToShortDateString();
            TimeSpan ts = monthCalendar1.SelectionStart - monthCalendar1.SelectionEnd;
            lbl_ekran2.Text = Convert.ToInt32(ts.TotalDays).ToString();
        }
    }
}
