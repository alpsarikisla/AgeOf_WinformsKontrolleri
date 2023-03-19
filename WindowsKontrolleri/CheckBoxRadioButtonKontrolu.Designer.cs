
namespace WindowsKontrolleri
{
    partial class CheckBoxRadioButtonKontrolu
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
            this.rb_erkek = new System.Windows.Forms.RadioButton();
            this.rb_kadin = new System.Windows.Forms.RadioButton();
            this.btn_goruntule = new System.Windows.Forms.Button();
            this.rb_evli = new System.Windows.Forms.RadioButton();
            this.rb_bekar = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cb_sozlesme = new System.Windows.Forms.CheckBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_tumu = new System.Windows.Forms.Button();
            this.btn_temizle = new System.Windows.Forms.Button();
            this.btn_aktar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // rb_erkek
            // 
            this.rb_erkek.AutoSize = true;
            this.rb_erkek.Location = new System.Drawing.Point(17, 23);
            this.rb_erkek.Name = "rb_erkek";
            this.rb_erkek.Size = new System.Drawing.Size(53, 17);
            this.rb_erkek.TabIndex = 0;
            this.rb_erkek.TabStop = true;
            this.rb_erkek.Text = "Erkek";
            this.rb_erkek.UseVisualStyleBackColor = true;
            // 
            // rb_kadin
            // 
            this.rb_kadin.AutoSize = true;
            this.rb_kadin.Location = new System.Drawing.Point(92, 23);
            this.rb_kadin.Name = "rb_kadin";
            this.rb_kadin.Size = new System.Drawing.Size(52, 17);
            this.rb_kadin.TabIndex = 0;
            this.rb_kadin.TabStop = true;
            this.rb_kadin.Text = "Kadın";
            this.rb_kadin.UseVisualStyleBackColor = true;
            // 
            // btn_goruntule
            // 
            this.btn_goruntule.Location = new System.Drawing.Point(502, 250);
            this.btn_goruntule.Name = "btn_goruntule";
            this.btn_goruntule.Size = new System.Drawing.Size(184, 23);
            this.btn_goruntule.TabIndex = 2;
            this.btn_goruntule.Text = "Getir";
            this.btn_goruntule.UseVisualStyleBackColor = true;
            this.btn_goruntule.Click += new System.EventHandler(this.btn_goruntule_Click);
            // 
            // rb_evli
            // 
            this.rb_evli.AutoSize = true;
            this.rb_evli.Location = new System.Drawing.Point(17, 26);
            this.rb_evli.Name = "rb_evli";
            this.rb_evli.Size = new System.Drawing.Size(42, 17);
            this.rb_evli.TabIndex = 0;
            this.rb_evli.TabStop = true;
            this.rb_evli.Text = "Evli";
            this.rb_evli.UseVisualStyleBackColor = true;
            // 
            // rb_bekar
            // 
            this.rb_bekar.AutoSize = true;
            this.rb_bekar.Location = new System.Drawing.Point(76, 26);
            this.rb_bekar.Name = "rb_bekar";
            this.rb_bekar.Size = new System.Drawing.Size(53, 17);
            this.rb_bekar.TabIndex = 0;
            this.rb_bekar.TabStop = true;
            this.rb_bekar.Text = "Bekar";
            this.rb_bekar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_kadin);
            this.groupBox1.Controls.Add(this.rb_erkek);
            this.groupBox1.Location = new System.Drawing.Point(25, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 60);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cinsiyet";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb_evli);
            this.groupBox2.Controls.Add(this.rb_bekar);
            this.groupBox2.Location = new System.Drawing.Point(25, 97);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 62);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Medeni Hal";
            // 
            // cb_sozlesme
            // 
            this.cb_sozlesme.AutoSize = true;
            this.cb_sozlesme.Location = new System.Drawing.Point(502, 227);
            this.cb_sozlesme.Name = "cb_sozlesme";
            this.cb_sozlesme.Size = new System.Drawing.Size(184, 17);
            this.cb_sozlesme.TabIndex = 5;
            this.cb_sozlesme.Text = "Sözleşmeyi Okudum Onaylıyorum.";
            this.cb_sozlesme.UseVisualStyleBackColor = true;
            this.cb_sozlesme.CheckedChanged += new System.EventHandler(this.cb_sozlesme_CheckedChanged);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Türkçe",
            "İngilizce",
            "Almanca",
            "Fransızca",
            "Flemenkçe",
            "Japonca",
            "Çince",
            "Hintçe"});
            this.checkedListBox1.Location = new System.Drawing.Point(6, 24);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(188, 154);
            this.checkedListBox1.TabIndex = 6;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkedListBox1);
            this.groupBox3.Location = new System.Drawing.Point(231, 22);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 193);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bilinen Diller";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 19);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(188, 160);
            this.listBox1.TabIndex = 8;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.listBox1);
            this.groupBox4.Location = new System.Drawing.Point(496, 22);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 193);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Seçilenler";
            // 
            // btn_tumu
            // 
            this.btn_tumu.Location = new System.Drawing.Point(231, 221);
            this.btn_tumu.Name = "btn_tumu";
            this.btn_tumu.Size = new System.Drawing.Size(94, 23);
            this.btn_tumu.TabIndex = 10;
            this.btn_tumu.Text = "Tümünü Seç";
            this.btn_tumu.UseVisualStyleBackColor = true;
            this.btn_tumu.Click += new System.EventHandler(this.btn_tumu_Click);
            // 
            // btn_temizle
            // 
            this.btn_temizle.Location = new System.Drawing.Point(331, 221);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(100, 23);
            this.btn_temizle.TabIndex = 10;
            this.btn_temizle.Text = "Seçimi Temizle";
            this.btn_temizle.UseVisualStyleBackColor = true;
            this.btn_temizle.Click += new System.EventHandler(this.btn_temizle_Click);
            // 
            // btn_aktar
            // 
            this.btn_aktar.Location = new System.Drawing.Point(437, 97);
            this.btn_aktar.Name = "btn_aktar";
            this.btn_aktar.Size = new System.Drawing.Size(53, 23);
            this.btn_aktar.TabIndex = 10;
            this.btn_aktar.Text = ">>";
            this.btn_aktar.UseVisualStyleBackColor = true;
            this.btn_aktar.Click += new System.EventHandler(this.btn_aktar_Click);
            // 
            // CheckBoxRadioButtonKontrolu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 312);
            this.Controls.Add(this.btn_aktar);
            this.Controls.Add(this.btn_temizle);
            this.Controls.Add(this.btn_tumu);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.cb_sozlesme);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_goruntule);
            this.Name = "CheckBoxRadioButtonKontrolu";
            this.Text = "CheckBoxRadioButtonKontrolu";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rb_erkek;
        private System.Windows.Forms.RadioButton rb_kadin;
        private System.Windows.Forms.Button btn_goruntule;
        private System.Windows.Forms.RadioButton rb_evli;
        private System.Windows.Forms.RadioButton rb_bekar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cb_sozlesme;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_tumu;
        private System.Windows.Forms.Button btn_temizle;
        private System.Windows.Forms.Button btn_aktar;
    }
}