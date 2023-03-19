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
    public partial class ListBoxKontrolu : Form
    {
        public ListBoxKontrolu()
        {
            InitializeComponent();
        }
        private void ListBoxKontrolu_Load(object sender, EventArgs e)
        {
            List<Marka> Markalar = new List<Marka>();
            Markalar.Add(new Marka() { ID = 11, Isim = "Audi" });
            Markalar.Add(new Marka() { ID = 12, Isim = "Volvo" });
            Markalar.Add(new Marka() { ID = 13, Isim = "Mercedes" });
            Markalar.Add(new Marka() { ID = 14, Isim = "BMW" });
            for (int i = 0; i < Markalar.Count; i++)
            {
                listBox1.Items.Add(Markalar[i].Isim);
            }
            //listBox1.DisplayMember = "Isim";
            //listBox1.ValueMember = "ID";
            //listBox1.DataSource = Markalar;
        }
        private void btn_goster_Click(object sender, EventArgs e)
        {
            //lbl_secilen.Text = listBox1.Text.ToString();
            lbl_secilen.Text = "";
            for (int i = 0; i < listBox1.SelectedItems.Count; i++)
            {
                lbl_secilen.Text += listBox1.SelectedItems[i] + " ";
            }
            
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            bool aynisivar = false;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                if (listBox1.Items[i].ToString() == tb_eklenecek.Text)
                {
                    aynisivar = true;
                }
            }
            if (aynisivar == false)
            {
                listBox1.Items.Add(tb_eklenecek.Text);
            }
            else
            {
                MessageBox.Show("Bu veri daha önce eklenmiş", "Eşleşme var");
            }
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                List<string> veriler = new List<string>();
                for (int i = 0; i < listBox1.SelectedItems.Count; i++)
                {
                    veriler.Add(listBox1.SelectedItems[i].ToString());
                }

                foreach (string item in veriler)
                {
                    listBox1.Items.Remove(item);
                }
            }
        }
    }
}
