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
    public partial class TextBoxKontrolu : Form
    {
        public TextBoxKontrolu()
        {
            InitializeComponent();
        }

        private void btn_goster_Click(object sender, EventArgs e)
        {
            if (tb_gizli.Visible)
            {
                tb_gizli.Visible = false;
                btn_goster.Text = "Göster";
            }
            else
            {
                tb_gizli.Visible = true;
                btn_goster.Text = "Gizle";
            }
        }
    }
}
