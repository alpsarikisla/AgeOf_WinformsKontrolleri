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
    public partial class ComboBoxKontrolu : Form
    {
        bool tamamlandi = false;
        public ComboBoxKontrolu()
        {
            InitializeComponent();
        }
        private void ComboBoxKontrolu_Load(object sender, EventArgs e)
        {
            cb_departmanlar.Items.Add("Muhasebe");
            cb_departmanlar.Items.Add("Satış/Pazarlama");
            cb_departmanlar.Items.Add("Satın Alma");
            cb_departmanlar.Items.Add("İnsan Kaynakları");
            
            List<Marka> Markalar = new List<Marka>();
            Markalar.Add(new Marka() { ID = 11, Isim = "Audi" });
            Markalar.Add(new Marka() { ID = 12, Isim = "Volvo" });
            Markalar.Add(new Marka() { ID = 13, Isim = "Mercedes" });
            Markalar.Add(new Marka() { ID = 14, Isim = "BMW" });

            cb_markalar.DisplayMember = "Isim";
            cb_markalar.ValueMember = "ID";
            cb_markalar.DataSource = Markalar;

            cb_markalar.Text = "Seçiniz...";
            tamamlandi = true;

        }

        private void btn_sehirSec_Click(object sender, EventArgs e)
        {
            string sehir = cb_sehir.SelectedItem.ToString();
            MessageBox.Show("Seçilen Şehir = " + sehir);
        }

        private void cb_sehir_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sehir = cb_sehir.SelectedItem.ToString();
            MessageBox.Show("Seçilen Şehir = " + sehir);
        }

        private void cb_markalar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tamamlandi == true)
            {
                string isim = cb_markalar.Text;
                string id = cb_markalar.SelectedValue.ToString();
                string index = cb_markalar.SelectedIndex.ToString();
                MessageBox.Show("İsim = " + isim + "\nID = " + id + "\nIndex = " + index);
            }
        }
    }
}
