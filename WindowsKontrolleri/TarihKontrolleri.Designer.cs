
namespace WindowsKontrolleri
{
    partial class TarihKontrolleri
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_guncel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_tarih = new System.Windows.Forms.DateTimePicker();
            this.lbl_ekran = new System.Windows.Forms.Label();
            this.btn_tarihGetir = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_tarihgetir2 = new System.Windows.Forms.Button();
            this.lbl_ekran2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nud_saat = new System.Windows.Forms.NumericUpDown();
            this.nud_dakika = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nud_saat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_dakika)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Güncel Tarih:";
            // 
            // lbl_guncel
            // 
            this.lbl_guncel.AutoSize = true;
            this.lbl_guncel.Location = new System.Drawing.Point(95, 9);
            this.lbl_guncel.Name = "lbl_guncel";
            this.lbl_guncel.Size = new System.Drawing.Size(35, 13);
            this.lbl_guncel.TabIndex = 1;
            this.lbl_guncel.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tarih Seçiniz:";
            // 
            // dtp_tarih
            // 
            this.dtp_tarih.Location = new System.Drawing.Point(98, 43);
            this.dtp_tarih.Name = "dtp_tarih";
            this.dtp_tarih.Size = new System.Drawing.Size(200, 20);
            this.dtp_tarih.TabIndex = 3;
            // 
            // lbl_ekran
            // 
            this.lbl_ekran.AutoSize = true;
            this.lbl_ekran.Location = new System.Drawing.Point(100, 100);
            this.lbl_ekran.Name = "lbl_ekran";
            this.lbl_ekran.Size = new System.Drawing.Size(0, 9);
            this.lbl_ekran.TabIndex = 4;
            // 
            // btn_tarihGetir
            // 
            this.btn_tarihGetir.Location = new System.Drawing.Point(98, 69);
            this.btn_tarihGetir.Name = "btn_tarihGetir";
            this.btn_tarihGetir.Size = new System.Drawing.Size(75, 23);
            this.btn_tarihGetir.TabIndex = 5;
            this.btn_tarihGetir.Text = "Tarih Getir";
            this.btn_tarihGetir.UseVisualStyleBackColor = true;
            this.btn_tarihGetir.Click += new System.EventHandler(this.btn_tarihGetir_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(98, 118);
            this.monthCalendar1.MaxSelectionCount = 20;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.ShowToday = false;
            this.monthCalendar1.ShowWeekNumbers = true;
            this.monthCalendar1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tarih Seçiniz:";
            // 
            // btn_tarihgetir2
            // 
            this.btn_tarihgetir2.Location = new System.Drawing.Point(98, 292);
            this.btn_tarihgetir2.Name = "btn_tarihgetir2";
            this.btn_tarihgetir2.Size = new System.Drawing.Size(75, 23);
            this.btn_tarihgetir2.TabIndex = 7;
            this.btn_tarihgetir2.Text = "Tarih Getir";
            this.btn_tarihgetir2.UseVisualStyleBackColor = true;
            this.btn_tarihgetir2.Click += new System.EventHandler(this.btn_tarihgetir2_Click);
            // 
            // lbl_ekran2
            // 
            this.lbl_ekran2.AutoSize = true;
            this.lbl_ekran2.Location = new System.Drawing.Point(95, 327);
            this.lbl_ekran2.Name = "lbl_ekran2";
            this.lbl_ekran2.Size = new System.Drawing.Size(0, 9);
            this.lbl_ekran2.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 344);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Saat";
            // 
            // nud_saat
            // 
            this.nud_saat.Location = new System.Drawing.Point(98, 342);
            this.nud_saat.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.nud_saat.Name = "nud_saat";
            this.nud_saat.Size = new System.Drawing.Size(48, 20);
            this.nud_saat.TabIndex = 10;
            // 
            // nud_dakika
            // 
            this.nud_dakika.Location = new System.Drawing.Point(170, 342);
            this.nud_dakika.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nud_dakika.Name = "nud_dakika";
            this.nud_dakika.Size = new System.Drawing.Size(48, 20);
            this.nud_dakika.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(152, 348);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = ":";
            // 
            // TarihKontrolleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nud_dakika);
            this.Controls.Add(this.nud_saat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_ekran2);
            this.Controls.Add(this.btn_tarihgetir2);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.btn_tarihGetir);
            this.Controls.Add(this.lbl_ekran);
            this.Controls.Add(this.dtp_tarih);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_guncel);
            this.Controls.Add(this.label1);
            this.Name = "TarihKontrolleri";
            this.Text = "TarihKontrolleri";
            this.Load += new System.EventHandler(this.TarihKontrolleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_saat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_dakika)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_guncel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_tarih;
        private System.Windows.Forms.Label lbl_ekran;
        private System.Windows.Forms.Button btn_tarihGetir;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_tarihgetir2;
        private System.Windows.Forms.Label lbl_ekran2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nud_saat;
        private System.Windows.Forms.NumericUpDown nud_dakika;
        private System.Windows.Forms.Label label5;
    }
}