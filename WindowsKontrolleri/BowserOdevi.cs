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
    public partial class BowserOdevi : Form
    {
        string home = "http://www.google.com";
        List<string> adresler = new List<string>();
        public BowserOdevi()
        {
            InitializeComponent();
        }

        private void BowserOdevi_Load(object sender, EventArgs e)
        {
            webBrowser1.Url = new Uri(home);
            TSTB_Adres.Text = home;
            adresler.Add(home);
        }

        private void TSB_Git_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TSTB_Adres.Text))
            {
                TSTB_Adres.Focus();
                MessageBox.Show("Uygun URL Giriniz...");
            }
            else
            {
                UrlAc(TSTB_Adres.Text);
            }
        }

        private void UrlAc(string url)
        {
            if(!url.StartsWith("http://") && !url.StartsWith("https://"))
            {
                url = "http://" + url;
            }
            try
            {
                adresler.Add(url);
                webBrowser1.Navigate(new Uri(url));
                TSTB_Adres.Text = url;
            }
            catch(System.UriFormatException ex)
            {
                MessageBox.Show(ex.Message, "Format Hatalı");
            }
        }

        private void TSB_Anasayfa_Click(object sender, EventArgs e)
        {
            UrlAc(home);
        }

        private void TSB_Geri_Click(object sender, EventArgs e)
        {
            //int index = adresler.IndexOf(TSTB_Adres.Text);
            //UrlAc(adresler[index - 1]);
            if (webBrowser1.CanGoBack)
            {
                webBrowser1.GoBack();
            }
        }

        private void TSB_Ileri_Click(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoForward)
            {
                webBrowser1.GoForward();
            }
        }

        private void TSB_Yenile_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }
    }
}
