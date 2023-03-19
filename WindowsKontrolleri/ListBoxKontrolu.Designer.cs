
namespace WindowsKontrolleri
{
    partial class ListBoxKontrolu
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_goster = new System.Windows.Forms.Button();
            this.lbl_secilen = new System.Windows.Forms.Label();
            this.tb_eklenecek = new System.Windows.Forms.TextBox();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_sil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Biber",
            "Domates",
            "Patlıcan"});
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox1.Size = new System.Drawing.Size(120, 186);
            this.listBox1.TabIndex = 0;
            // 
            // btn_goster
            // 
            this.btn_goster.Location = new System.Drawing.Point(12, 204);
            this.btn_goster.Name = "btn_goster";
            this.btn_goster.Size = new System.Drawing.Size(120, 23);
            this.btn_goster.TabIndex = 1;
            this.btn_goster.Text = "Göster";
            this.btn_goster.UseVisualStyleBackColor = true;
            this.btn_goster.Click += new System.EventHandler(this.btn_goster_Click);
            // 
            // lbl_secilen
            // 
            this.lbl_secilen.AutoSize = true;
            this.lbl_secilen.Location = new System.Drawing.Point(12, 241);
            this.lbl_secilen.Name = "lbl_secilen";
            this.lbl_secilen.Size = new System.Drawing.Size(35, 13);
            this.lbl_secilen.TabIndex = 2;
            this.lbl_secilen.Text = "label1";
            // 
            // tb_eklenecek
            // 
            this.tb_eklenecek.Location = new System.Drawing.Point(138, 40);
            this.tb_eklenecek.Name = "tb_eklenecek";
            this.tb_eklenecek.Size = new System.Drawing.Size(143, 20);
            this.tb_eklenecek.TabIndex = 3;
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(138, 66);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(85, 23);
            this.btn_ekle.TabIndex = 4;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 9);
            this.label1.TabIndex = 5;
            this.label1.Text = "Veri:";
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(138, 95);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(85, 23);
            this.btn_sil.TabIndex = 6;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // ListBoxKontrolu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.tb_eklenecek);
            this.Controls.Add(this.lbl_secilen);
            this.Controls.Add(this.btn_goster);
            this.Controls.Add(this.listBox1);
            this.Name = "ListBoxKontrolu";
            this.Text = "ListBoxKontrolu";
            this.Load += new System.EventHandler(this.ListBoxKontrolu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_goster;
        private System.Windows.Forms.Label lbl_secilen;
        private System.Windows.Forms.TextBox tb_eklenecek;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_sil;
    }
}