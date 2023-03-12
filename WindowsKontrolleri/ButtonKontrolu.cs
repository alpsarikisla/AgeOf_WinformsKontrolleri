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
    public partial class ButtonKontrolu : Form
    {
        public ButtonKontrolu()
        {
            InitializeComponent();
            btn_tikla.Text = "Nabünüz?";
            btn_tikla.Size = new Size(200, 50);
        }


        private void ButtonKontrolu_Load(object sender, EventArgs e)
        {
            this.Text = "Başka Bişey";
        }

        private void btn_tikla_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ben Geldiiiim", "Hehe");
        }

        private void btn_tikla_MouseHover(object sender, EventArgs e)
        {
            btn_tikla.Enabled = false;
            MessageBox.Show("Olmaaaazzz","He he");
        }
    }
}
