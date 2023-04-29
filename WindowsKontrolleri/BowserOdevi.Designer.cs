namespace WindowsKontrolleri
{
    partial class BowserOdevi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BowserOdevi));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.TSB_Geri = new System.Windows.Forms.ToolStripButton();
            this.TSB_Ileri = new System.Windows.Forms.ToolStripButton();
            this.TSB_Yenile = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TSTB_Adres = new System.Windows.Forms.ToolStripTextBox();
            this.TSB_Git = new System.Windows.Forms.ToolStripButton();
            this.TSB_Anasayfa = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSB_Geri,
            this.TSB_Ileri,
            this.TSB_Yenile,
            this.toolStripSeparator1,
            this.TSTB_Adres,
            this.TSB_Git,
            this.toolStripSeparator2,
            this.TSB_Anasayfa});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 25);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(800, 425);
            this.webBrowser1.TabIndex = 1;
            this.webBrowser1.Url = new System.Uri("https://www.google.com", System.UriKind.Absolute);
            // 
            // TSB_Geri
            // 
            this.TSB_Geri.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TSB_Geri.Image = ((System.Drawing.Image)(resources.GetObject("TSB_Geri.Image")));
            this.TSB_Geri.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_Geri.Name = "TSB_Geri";
            this.TSB_Geri.Size = new System.Drawing.Size(32, 22);
            this.TSB_Geri.Text = "Geri";
            this.TSB_Geri.Click += new System.EventHandler(this.TSB_Geri_Click);
            // 
            // TSB_Ileri
            // 
            this.TSB_Ileri.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TSB_Ileri.Image = ((System.Drawing.Image)(resources.GetObject("TSB_Ileri.Image")));
            this.TSB_Ileri.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_Ileri.Name = "TSB_Ileri";
            this.TSB_Ileri.Size = new System.Drawing.Size(30, 22);
            this.TSB_Ileri.Text = "İleri";
            this.TSB_Ileri.Click += new System.EventHandler(this.TSB_Ileri_Click);
            // 
            // TSB_Yenile
            // 
            this.TSB_Yenile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TSB_Yenile.Image = ((System.Drawing.Image)(resources.GetObject("TSB_Yenile.Image")));
            this.TSB_Yenile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_Yenile.Name = "TSB_Yenile";
            this.TSB_Yenile.Size = new System.Drawing.Size(42, 22);
            this.TSB_Yenile.Text = "Yenile";
            this.TSB_Yenile.Click += new System.EventHandler(this.TSB_Yenile_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // TSTB_Adres
            // 
            this.TSTB_Adres.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TSTB_Adres.Name = "TSTB_Adres";
            this.TSTB_Adres.Size = new System.Drawing.Size(350, 25);
            // 
            // TSB_Git
            // 
            this.TSB_Git.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TSB_Git.Image = ((System.Drawing.Image)(resources.GetObject("TSB_Git.Image")));
            this.TSB_Git.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_Git.Name = "TSB_Git";
            this.TSB_Git.Size = new System.Drawing.Size(26, 22);
            this.TSB_Git.Text = "Git";
            this.TSB_Git.Click += new System.EventHandler(this.TSB_Git_Click);
            // 
            // TSB_Anasayfa
            // 
            this.TSB_Anasayfa.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TSB_Anasayfa.Image = ((System.Drawing.Image)(resources.GetObject("TSB_Anasayfa.Image")));
            this.TSB_Anasayfa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_Anasayfa.Name = "TSB_Anasayfa";
            this.TSB_Anasayfa.Size = new System.Drawing.Size(59, 22);
            this.TSB_Anasayfa.Text = "Anasayfa";
            this.TSB_Anasayfa.Click += new System.EventHandler(this.TSB_Anasayfa_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // BowserOdevi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "BowserOdevi";
            this.Text = "BowserOdevi";
            this.Load += new System.EventHandler(this.BowserOdevi_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton TSB_Geri;
        private System.Windows.Forms.ToolStripButton TSB_Ileri;
        private System.Windows.Forms.ToolStripButton TSB_Yenile;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox TSTB_Adres;
        private System.Windows.Forms.ToolStripButton TSB_Git;
        private System.Windows.Forms.ToolStripButton TSB_Anasayfa;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}