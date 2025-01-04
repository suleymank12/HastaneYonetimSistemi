using System;

namespace VeritabaniÖdev
{
    partial class FrmHastaKayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHastaKayit));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtSifre = new System.Windows.Forms.TextBox();
            this.MskTC = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.TxtSoyad = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnKayit = new System.Windows.Forms.Button();
            this.MskTlf = new System.Windows.Forms.MaskedTextBox();
            this.CmbCnsyt = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(149, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 29);
            this.label3.TabIndex = 10;
            this.label3.Text = "Şifre :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(3, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 29);
            this.label2.TabIndex = 9;
            this.label2.Text = "TC Kimlik Numarası :";
            // 
            // TxtSifre
            // 
            this.TxtSifre.Location = new System.Drawing.Point(223, 211);
            this.TxtSifre.Multiline = true;
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.Size = new System.Drawing.Size(162, 27);
            this.TxtSifre.TabIndex = 4;
            this.TxtSifre.UseSystemPasswordChar = true;
            // 
            // MskTC
            // 
            this.MskTC.Location = new System.Drawing.Point(223, 180);
            this.MskTC.Mask = "00000000000";
            this.MskTC.Name = "MskTC";
            this.MskTC.Size = new System.Drawing.Size(162, 20);
            this.MskTC.TabIndex = 3;
            this.MskTC.ValidatingType = typeof(int);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(133, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = "Soyad :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(115, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 29);
            this.label4.TabIndex = 11;
            this.label4.Text = "Cinsiyet :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(166, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 29);
            this.label6.TabIndex = 13;
            this.label6.Text = "Ad :";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(125, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(282, 78);
            this.label7.TabIndex = 15;
            this.label7.Text = "KAYIT OL ";
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(223, 105);
            this.TxtAd.Multiline = true;
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(162, 31);
            this.TxtAd.TabIndex = 1;
            // 
            // TxtSoyad
            // 
            this.TxtSoyad.Location = new System.Drawing.Point(223, 142);
            this.TxtSoyad.Multiline = true;
            this.TxtSoyad.Name = "TxtSoyad";
            this.TxtSoyad.Size = new System.Drawing.Size(162, 31);
            this.TxtSoyad.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(121, 242);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 29);
            this.label8.TabIndex = 19;
            this.label8.Text = "Telefon :";
            // 
            // BtnKayit
            // 
            this.BtnKayit.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKayit.Location = new System.Drawing.Point(171, 338);
            this.BtnKayit.Name = "BtnKayit";
            this.BtnKayit.Size = new System.Drawing.Size(144, 60);
            this.BtnKayit.TabIndex = 22;
            this.BtnKayit.Text = "Kayıt Ol";
            this.BtnKayit.UseVisualStyleBackColor = true;
            this.BtnKayit.Click += new System.EventHandler(this.BtnKayit_Click);
            // 
            // MskTlf
            // 
            this.MskTlf.Location = new System.Drawing.Point(223, 251);
            this.MskTlf.Mask = "0000000000";
            this.MskTlf.Name = "MskTlf";
            this.MskTlf.Size = new System.Drawing.Size(162, 20);
            this.MskTlf.TabIndex = 5;
            this.MskTlf.ValidatingType = typeof(int);
            // 
            // CmbCnsyt
            // 
            this.CmbCnsyt.FormattingEnabled = true;
            this.CmbCnsyt.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.CmbCnsyt.Location = new System.Drawing.Point(223, 288);
            this.CmbCnsyt.Name = "CmbCnsyt";
            this.CmbCnsyt.Size = new System.Drawing.Size(162, 21);
            this.CmbCnsyt.TabIndex = 6;
            // 
            // FrmHastaKayit
            // 
            this.AcceptButton = this.BtnKayit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(458, 428);
            this.Controls.Add(this.CmbCnsyt);
            this.Controls.Add(this.MskTlf);
            this.Controls.Add(this.BtnKayit);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxtSoyad);
            this.Controls.Add(this.TxtAd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtSifre);
            this.Controls.Add(this.MskTC);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmHastaKayit";
            this.Text = "Hasta Kayıt Sayfası";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label6_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtSifre;
        private System.Windows.Forms.MaskedTextBox MskTC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.TextBox TxtSoyad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtnKayit;
        private System.Windows.Forms.MaskedTextBox MskTlf;
        private System.Windows.Forms.ComboBox CmbCnsyt;
    }
}