namespace VeritabaniÖdev
{
    partial class FrmGirisler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGirisler));
            this.BtnHastaGiris = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnDoktorGiris = new System.Windows.Forms.Button();
            this.BtnSekreterGiris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnHastaGiris
            // 
            this.BtnHastaGiris.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnHastaGiris.BackgroundImage")));
            this.BtnHastaGiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnHastaGiris.Location = new System.Drawing.Point(60, 166);
            this.BtnHastaGiris.Name = "BtnHastaGiris";
            this.BtnHastaGiris.Size = new System.Drawing.Size(162, 90);
            this.BtnHastaGiris.TabIndex = 0;
            this.BtnHastaGiris.UseVisualStyleBackColor = true;
            this.BtnHastaGiris.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(59, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(785, 78);
            this.label1.TabIndex = 1;
            this.label1.Text = "HASTANEMİZE HOŞ GELDİNİZ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(266, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hastaysanız aşağıdaki butona tıklayınız.";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(322, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(264, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Doktorsanız aşağıdaki butona tıklayınız.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(635, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(274, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Sekreterseniz aşağıdaki butona tıklayınız.";
            // 
            // BtnDoktorGiris
            // 
            this.BtnDoktorGiris.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnDoktorGiris.BackgroundImage")));
            this.BtnDoktorGiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnDoktorGiris.Location = new System.Drawing.Point(363, 166);
            this.BtnDoktorGiris.Name = "BtnDoktorGiris";
            this.BtnDoktorGiris.Size = new System.Drawing.Size(162, 90);
            this.BtnDoktorGiris.TabIndex = 5;
            this.BtnDoktorGiris.UseVisualStyleBackColor = true;
            this.BtnDoktorGiris.Click += new System.EventHandler(this.BtnDoktorGiris_Click);
            // 
            // BtnSekreterGiris
            // 
            this.BtnSekreterGiris.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSekreterGiris.BackgroundImage")));
            this.BtnSekreterGiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnSekreterGiris.Location = new System.Drawing.Point(682, 166);
            this.BtnSekreterGiris.Name = "BtnSekreterGiris";
            this.BtnSekreterGiris.Size = new System.Drawing.Size(162, 90);
            this.BtnSekreterGiris.TabIndex = 6;
            this.BtnSekreterGiris.UseVisualStyleBackColor = true;
            this.BtnSekreterGiris.Click += new System.EventHandler(this.BtnSekreterGiris_Click);
            // 
            // FrmGirisler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(921, 326);
            this.Controls.Add(this.BtnSekreterGiris);
            this.Controls.Add(this.BtnDoktorGiris);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnHastaGiris);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmGirisler";
            this.Text = "Hastane Sistemi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnHastaGiris;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnDoktorGiris;
        private System.Windows.Forms.Button BtnSekreterGiris;
    }
}

