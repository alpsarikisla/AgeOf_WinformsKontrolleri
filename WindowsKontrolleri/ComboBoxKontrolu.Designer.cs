
namespace WindowsKontrolleri
{
    partial class ComboBoxKontrolu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cb_sehir = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_sehirSec = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_departmanlar = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_markalar = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cb_sehir
            // 
            this.cb_sehir.FormattingEnabled = true;
            this.cb_sehir.Items.AddRange(new object[] {
            "Ankara",
            "İstanbul",
            "Eskişehir",
            "Adana",
            "İzmir",
            "Bursa"});
            this.cb_sehir.Location = new System.Drawing.Point(132, 63);
            this.cb_sehir.Name = "cb_sehir";
            this.cb_sehir.Size = new System.Drawing.Size(143, 21);
            this.cb_sehir.TabIndex = 0;
            this.cb_sehir.Text = "Seçiniz...";
            this.cb_sehir.SelectedIndexChanged += new System.EventHandler(this.cb_sehir_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Birden çok seçenek arasından sadece 1 tanesini\r\nSeçtirmeye yarayan araçtır.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 9);
            this.label2.TabIndex = 2;
            this.label2.Text = "Şehirler:";
            // 
            // btn_sehirSec
            // 
            this.btn_sehirSec.Location = new System.Drawing.Point(281, 61);
            this.btn_sehirSec.Name = "btn_sehirSec";
            this.btn_sehirSec.Size = new System.Drawing.Size(75, 23);
            this.btn_sehirSec.TabIndex = 3;
            this.btn_sehirSec.Text = "Seç";
            this.btn_sehirSec.UseVisualStyleBackColor = true;
            this.btn_sehirSec.Click += new System.EventHandler(this.btn_sehirSec_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Departmanlar:";
            // 
            // cb_departmanlar
            // 
            this.cb_departmanlar.FormattingEnabled = true;
            this.cb_departmanlar.Location = new System.Drawing.Point(132, 90);
            this.cb_departmanlar.Name = "cb_departmanlar";
            this.cb_departmanlar.Size = new System.Drawing.Size(143, 21);
            this.cb_departmanlar.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 9);
            this.label4.TabIndex = 6;
            this.label4.Text = "Markalar:";
            // 
            // cb_markalar
            // 
            this.cb_markalar.FormattingEnabled = true;
            this.cb_markalar.Location = new System.Drawing.Point(132, 117);
            this.cb_markalar.Name = "cb_markalar";
            this.cb_markalar.Size = new System.Drawing.Size(143, 21);
            this.cb_markalar.TabIndex = 7;
            this.cb_markalar.SelectedIndexChanged += new System.EventHandler(this.cb_markalar_SelectedIndexChanged);
            // 
            // ComboBoxKontrolu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cb_markalar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_departmanlar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_sehirSec);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_sehir);
            this.Name = "ComboBoxKontrolu";
            this.Text = "ComboBoxKontrolu";
            this.Load += new System.EventHandler(this.ComboBoxKontrolu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_sehir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_sehirSec;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_departmanlar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_markalar;
    }
}