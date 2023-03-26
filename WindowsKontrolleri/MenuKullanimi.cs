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
    public partial class MenuKullanimi : Form
    {
        public MenuKullanimi()
        {
            InitializeComponent();
            
        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void yeniPersonelFormuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonelKayitForm frm = new PersonelKayitForm();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
