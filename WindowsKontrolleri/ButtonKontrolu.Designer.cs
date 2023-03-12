namespace WindowsKontrolleri
{
    partial class ButtonKontrolu
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
            this.btn_tikla = new System.Windows.Forms.Button();
            this.btn_baskaButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_tikla
            // 
            this.btn_tikla.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_tikla.Location = new System.Drawing.Point(12, 12);
            this.btn_tikla.Name = "btn_tikla";
            this.btn_tikla.Size = new System.Drawing.Size(156, 51);
            this.btn_tikla.TabIndex = 0;
            this.btn_tikla.Text = "Tıkla";
            this.btn_tikla.UseVisualStyleBackColor = true;
            this.btn_tikla.Click += new System.EventHandler(this.btn_tikla_Click);
            this.btn_tikla.MouseHover += new System.EventHandler(this.btn_tikla_MouseHover);
            // 
            // btn_baskaButton
            // 
            this.btn_baskaButton.Location = new System.Drawing.Point(12, 69);
            this.btn_baskaButton.Name = "btn_baskaButton";
            this.btn_baskaButton.Size = new System.Drawing.Size(156, 23);
            this.btn_baskaButton.TabIndex = 1;
            this.btn_baskaButton.Text = "Başka Button";
            this.btn_baskaButton.UseVisualStyleBackColor = true;
            // 
            // ButtonKontrolu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_baskaButton);
            this.Controls.Add(this.btn_tikla);
            this.Name = "ButtonKontrolu";
            this.Text = "ButtonKontrolu";
            this.Load += new System.EventHandler(this.ButtonKontrolu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_tikla;
        private System.Windows.Forms.Button btn_baskaButton;
    }
}