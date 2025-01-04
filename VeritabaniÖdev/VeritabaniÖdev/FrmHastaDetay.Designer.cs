namespace VeritabaniÖdev
{
    partial class FrmHastaDetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHastaDetay));
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LblAdSoyad = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblTC = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Txtid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LnkBilgiDüzenle = new System.Windows.Forms.LinkLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnRandevuAl = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.RchÖnBilgi = new System.Windows.Forms.RichTextBox();
            this.CmbDoktor = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CmbBrans = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(4, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 29);
            this.label6.TabIndex = 14;
            this.label6.Text = "TC No :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LblAdSoyad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.LblTC);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 210);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kişi Bilgi";
            // 
            // LblAdSoyad
            // 
            this.LblAdSoyad.AutoSize = true;
            this.LblAdSoyad.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblAdSoyad.Location = new System.Drawing.Point(117, 72);
            this.LblAdSoyad.Name = "LblAdSoyad";
            this.LblAdSoyad.Size = new System.Drawing.Size(87, 26);
            this.LblAdSoyad.TabIndex = 17;
            this.LblAdSoyad.Text = "Null Null";
            this.LblAdSoyad.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(6, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 29);
            this.label3.TabIndex = 16;
            this.label3.Text = "Ad Soyad :";
            // 
            // LblTC
            // 
            this.LblTC.AutoSize = true;
            this.LblTC.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblTC.Location = new System.Drawing.Point(82, 27);
            this.LblTC.Name = "LblTC";
            this.LblTC.Size = new System.Drawing.Size(145, 29);
            this.LblTC.TabIndex = 15;
            this.LblTC.Text = "00000000000";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Txtid);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.LnkBilgiDüzenle);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.BtnRandevuAl);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.RchÖnBilgi);
            this.groupBox2.Controls.Add(this.CmbDoktor);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.CmbBrans);
            this.groupBox2.Location = new System.Drawing.Point(12, 228);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(297, 330);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Randevu Alım Kısmı ";
            // 
            // Txtid
            // 
            this.Txtid.Enabled = false;
            this.Txtid.Location = new System.Drawing.Point(101, 27);
            this.Txtid.Name = "Txtid";
            this.Txtid.Size = new System.Drawing.Size(161, 31);
            this.Txtid.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 23);
            this.label1.TabIndex = 23;
            this.label1.Text = "id :";
            // 
            // LnkBilgiDüzenle
            // 
            this.LnkBilgiDüzenle.AutoSize = true;
            this.LnkBilgiDüzenle.Location = new System.Drawing.Point(72, 298);
            this.LnkBilgiDüzenle.Name = "LnkBilgiDüzenle";
            this.LnkBilgiDüzenle.Size = new System.Drawing.Size(145, 23);
            this.LnkBilgiDüzenle.TabIndex = 22;
            this.LnkBilgiDüzenle.TabStop = true;
            this.LnkBilgiDüzenle.Text = "Bilgilerini Düzenle";
            this.LnkBilgiDüzenle.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkBilgiDüzenle_LinkClicked);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 46);
            this.label7.TabIndex = 21;
            this.label7.Text = "  Hasta \r\nÖn Bilgi :";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // BtnRandevuAl
            // 
            this.BtnRandevuAl.Location = new System.Drawing.Point(106, 246);
            this.BtnRandevuAl.Name = "BtnRandevuAl";
            this.BtnRandevuAl.Size = new System.Drawing.Size(141, 42);
            this.BtnRandevuAl.TabIndex = 20;
            this.BtnRandevuAl.Text = "Randevu Al";
            this.BtnRandevuAl.UseVisualStyleBackColor = true;
            this.BtnRandevuAl.Click += new System.EventHandler(this.BtnRandevuAl_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 23);
            this.label5.TabIndex = 20;
            this.label5.Text = "Doktorlar :";
            // 
            // RchÖnBilgi
            // 
            this.RchÖnBilgi.Location = new System.Drawing.Point(101, 131);
            this.RchÖnBilgi.Name = "RchÖnBilgi";
            this.RchÖnBilgi.Size = new System.Drawing.Size(161, 109);
            this.RchÖnBilgi.TabIndex = 19;
            this.RchÖnBilgi.Text = "";
            // 
            // CmbDoktor
            // 
            this.CmbDoktor.FormattingEnabled = true;
            this.CmbDoktor.Location = new System.Drawing.Point(101, 98);
            this.CmbDoktor.Name = "CmbDoktor";
            this.CmbDoktor.Size = new System.Drawing.Size(161, 31);
            this.CmbDoktor.TabIndex = 19;
            this.CmbDoktor.SelectedIndexChanged += new System.EventHandler(this.CmbDoktor_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 23);
            this.label4.TabIndex = 18;
            this.label4.Text = "Bölümler :";
            // 
            // CmbBrans
            // 
            this.CmbBrans.FormattingEnabled = true;
            this.CmbBrans.Location = new System.Drawing.Point(101, 61);
            this.CmbBrans.Name = "CmbBrans";
            this.CmbBrans.Size = new System.Drawing.Size(161, 31);
            this.CmbBrans.TabIndex = 17;
            this.CmbBrans.SelectedIndexChanged += new System.EventHandler(this.CmbBrans_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView2);
            this.groupBox3.Location = new System.Drawing.Point(315, 308);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(564, 238);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Randevu Geçmişi";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 27);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(558, 208);
            this.dataGridView2.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Location = new System.Drawing.Point(315, 21);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(564, 281);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Aktif Randevular";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(558, 251);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // FrmHastaDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(891, 558);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FrmHastaDetay";
            this.Text = "Hasta Detay";
            this.Load += new System.EventHandler(this.FrmHastaDetay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LblAdSoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblTC;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox CmbBrans;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox RchÖnBilgi;
        private System.Windows.Forms.Button BtnRandevuAl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CmbDoktor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.LinkLabel LnkBilgiDüzenle;
        private System.Windows.Forms.TextBox Txtid;
        private System.Windows.Forms.Label label1;
    }
}