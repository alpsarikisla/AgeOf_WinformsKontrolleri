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
    public partial class ProgressBarKontrolu : Form
    {
        public ProgressBarKontrolu()
        {
            InitializeComponent();
        }
        private void ProgressBarKontrolu_Load(object sender, EventArgs e)
        {
            DateTime simdi = DateTime.Now;
            lbl_tarih.Text = simdi.ToShortDateString();
            lbl_saat.Text = simdi.ToShortTimeString();
            progressBar1.Value = simdi.Hour;
            progressBar2.Value = simdi.Minute;
            progressBar3.Value = simdi.Second;
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime simdi = DateTime.Now;
            lbl_saat.Text = simdi.ToLongTimeString();
            progressBar1.Value = simdi.Hour;
            progressBar2.Value = simdi.Minute;
            progressBar3.Value = simdi.Second;
        }

       
    }
}
