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
    public partial class WebBrowserKontrolu : Form
    {
        public WebBrowserKontrolu()
        {
            InitializeComponent();
        }

        private void WebBrowserKontrolu_Load(object sender, EventArgs e)
        {
            webBrowser1.Url = new Uri("C:/Users/303/Documents/GitHub/FrontendMaterials/JQuery/Slide.htm");
        }
    }
}
