﻿namespace WindowsKontrolleri
{
    partial class TextBoxKontrolu
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_gizli = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_goster = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.mtb_telefon = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.nud_numara = new System.Windows.Forms.NumericUpDown();
            this.nud_label = new System.Windows.Forms.Label();
            this.btn_telefongoster = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nud_numara)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(159, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(166, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Standart TextBox:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Multiline Text:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(159, 81);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(166, 45);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(159, 132);
            this.textBox3.MaxLength = 5;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(166, 20);
            this.textBox3.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Sınırlı TextBox:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(159, 158);
            this.textBox4.Name = "textBox4";
            this.textBox4.PasswordChar = '?';
            this.textBox4.Size = new System.Drawing.Size(166, 20);
            this.textBox4.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Password Char:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(159, 184);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(166, 20);
            this.textBox5.TabIndex = 4;
            this.textBox5.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "System Password Char:";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(159, 210);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(166, 20);
            this.textBox6.TabIndex = 0;
            this.textBox6.Text = "Ben Bir Yazıyım";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Readonly TextBox:";
            // 
            // textBox7
            // 
            this.textBox7.Enabled = false;
            this.textBox7.Location = new System.Drawing.Point(159, 236);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(166, 20);
            this.textBox7.TabIndex = 0;
            this.textBox7.Text = "Bende Bir Yazıyım";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Enabled TextBox:";
            // 
            // tb_gizli
            // 
            this.tb_gizli.Location = new System.Drawing.Point(159, 262);
            this.tb_gizli.Name = "tb_gizli";
            this.tb_gizli.Size = new System.Drawing.Size(166, 20);
            this.tb_gizli.TabIndex = 0;
            this.tb_gizli.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 265);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Visible TextBox:";
            // 
            // btn_goster
            // 
            this.btn_goster.Location = new System.Drawing.Point(331, 260);
            this.btn_goster.Name = "btn_goster";
            this.btn_goster.Size = new System.Drawing.Size(97, 23);
            this.btn_goster.TabIndex = 5;
            this.btn_goster.Text = "Göster";
            this.btn_goster.UseVisualStyleBackColor = true;
            this.btn_goster.Click += new System.EventHandler(this.btn_goster_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 291);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Telefon No:";
            // 
            // mtb_telefon
            // 
            this.mtb_telefon.Location = new System.Drawing.Point(159, 288);
            this.mtb_telefon.Mask = "(999) 000-0000";
            this.mtb_telefon.Name = "mtb_telefon";
            this.mtb_telefon.Size = new System.Drawing.Size(166, 20);
            this.mtb_telefon.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 317);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Kimlik No:";
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(159, 314);
            this.maskedTextBox2.Mask = "99999999999";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(166, 20);
            this.maskedTextBox2.TabIndex = 7;
            // 
            // nud_numara
            // 
            this.nud_numara.Location = new System.Drawing.Point(159, 340);
            this.nud_numara.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nud_numara.Name = "nud_numara";
            this.nud_numara.Size = new System.Drawing.Size(166, 20);
            this.nud_numara.TabIndex = 8;
            this.nud_numara.ThousandsSeparator = true;
            // 
            // nud_label
            // 
            this.nud_label.AutoSize = true;
            this.nud_label.Location = new System.Drawing.Point(24, 342);
            this.nud_label.Name = "nud_label";
            this.nud_label.Size = new System.Drawing.Size(47, 13);
            this.nud_label.TabIndex = 9;
            this.nud_label.Text = "Numara:";
            // 
            // btn_telefongoster
            // 
            this.btn_telefongoster.Location = new System.Drawing.Point(331, 288);
            this.btn_telefongoster.Name = "btn_telefongoster";
            this.btn_telefongoster.Size = new System.Drawing.Size(97, 23);
            this.btn_telefongoster.TabIndex = 10;
            this.btn_telefongoster.Text = "Göster";
            this.btn_telefongoster.UseVisualStyleBackColor = true;
            this.btn_telefongoster.Click += new System.EventHandler(this.btn_telefongoster_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(331, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Numara Göster";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TextBoxKontrolu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_telefongoster);
            this.Controls.Add(this.nud_label);
            this.Controls.Add(this.nud_numara);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.mtb_telefon);
            this.Controls.Add(this.btn_goster);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.tb_gizli);
            this.Controls.Add(this.textBox1);
            this.Name = "TextBoxKontrolu";
            this.Text = "TextBoxKontrolu";
            ((System.ComponentModel.ISupportInitialize)(this.nud_numara)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_gizli;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_goster;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox mtb_telefon;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.NumericUpDown nud_numara;
        private System.Windows.Forms.Label nud_label;
        private System.Windows.Forms.Button btn_telefongoster;
        private System.Windows.Forms.Button button1;
    }
}