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
    public partial class FormIcindenFormCagirma : Form
    {
        public FormIcindenFormCagirma()
        {
            InitializeComponent();
        }

        private void btn_hesapMakinesi_Click(object sender, EventArgs e)
        {
            HesapMakinesi frm = new HesapMakinesi();
            frm.Show();
        }

        private void btn_formAc_Click(object sender, EventArgs e)
        {
            ListBoxKontrolu frm = new ListBoxKontrolu();
            //frm.Show();
            frm.ShowDialog();
        }
    }
}
