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
    public partial class RichTextBoxKontrolu : Form
    {
        public RichTextBoxKontrolu()
        {
            InitializeComponent();
        }

        private void RichTextBoxKontrolu_Load(object sender, EventArgs e)
        {
            richTextBox1.LoadFile("C://Nikola1.rtf");
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            richTextBox1.SaveFile("C://Kaydedilen/Nikola_Kopya.rtf");
        }
    }
}
