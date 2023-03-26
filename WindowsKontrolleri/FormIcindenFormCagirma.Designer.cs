namespace WindowsKontrolleri
{
    partial class FormIcindenFormCagirma
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
            this.btn_hesapMakinesi = new System.Windows.Forms.Button();
            this.btn_formAc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_hesapMakinesi
            // 
            this.btn_hesapMakinesi.Location = new System.Drawing.Point(12, 29);
            this.btn_hesapMakinesi.Name = "btn_hesapMakinesi";
            this.btn_hesapMakinesi.Size = new System.Drawing.Size(198, 23);
            this.btn_hesapMakinesi.TabIndex = 0;
            this.btn_hesapMakinesi.Text = "Hesap Makinesi";
            this.btn_hesapMakinesi.UseVisualStyleBackColor = true;
            this.btn_hesapMakinesi.Click += new System.EventHandler(this.btn_hesapMakinesi_Click);
            // 
            // btn_formAc
            // 
            this.btn_formAc.Location = new System.Drawing.Point(12, 58);
            this.btn_formAc.Name = "btn_formAc";
            this.btn_formAc.Size = new System.Drawing.Size(198, 23);
            this.btn_formAc.TabIndex = 1;
            this.btn_formAc.Text = "ListBox Kontrolu Formu Aç";
            this.btn_formAc.UseVisualStyleBackColor = true;
            this.btn_formAc.Click += new System.EventHandler(this.btn_formAc_Click);
            // 
            // FormIcindenFormCagirma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 450);
            this.Controls.Add(this.btn_formAc);
            this.Controls.Add(this.btn_hesapMakinesi);
            this.Name = "FormIcindenFormCagirma";
            this.Text = "FormIcindenFormCagirma";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_hesapMakinesi;
        private System.Windows.Forms.Button btn_formAc;
    }
}