namespace NesneyeDayaliProgramlama
{
    partial class FrmOgretmen
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
            this.BtnOgrenciIslemleri = new System.Windows.Forms.Button();
            this.BtnSoruIslemleri = new System.Windows.Forms.Button();
            this.BtnSinavIslemleri = new System.Windows.Forms.Button();
            this.BtnSinavNotlari = new System.Windows.Forms.Button();
            this.BtnSinavTarihleri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnOgrenciIslemleri
            // 
            this.BtnOgrenciIslemleri.Location = new System.Drawing.Point(62, 27);
            this.BtnOgrenciIslemleri.Name = "BtnOgrenciIslemleri";
            this.BtnOgrenciIslemleri.Size = new System.Drawing.Size(345, 53);
            this.BtnOgrenciIslemleri.TabIndex = 0;
            this.BtnOgrenciIslemleri.Text = "ÖĞRENCİ İŞLEMLERİ";
            this.BtnOgrenciIslemleri.UseVisualStyleBackColor = true;
            this.BtnOgrenciIslemleri.Click += new System.EventHandler(this.BtnOgrenciIslemleri_Click);
            // 
            // BtnSoruIslemleri
            // 
            this.BtnSoruIslemleri.Location = new System.Drawing.Point(62, 100);
            this.BtnSoruIslemleri.Name = "BtnSoruIslemleri";
            this.BtnSoruIslemleri.Size = new System.Drawing.Size(345, 53);
            this.BtnSoruIslemleri.TabIndex = 1;
            this.BtnSoruIslemleri.Text = "SORU İŞLEMLERİ";
            this.BtnSoruIslemleri.UseVisualStyleBackColor = true;
            this.BtnSoruIslemleri.Click += new System.EventHandler(this.BtnSoruIslemleri_Click);
            // 
            // BtnSinavIslemleri
            // 
            this.BtnSinavIslemleri.Location = new System.Drawing.Point(62, 174);
            this.BtnSinavIslemleri.Name = "BtnSinavIslemleri";
            this.BtnSinavIslemleri.Size = new System.Drawing.Size(345, 53);
            this.BtnSinavIslemleri.TabIndex = 2;
            this.BtnSinavIslemleri.Text = "SINAV OLUŞTUR";
            this.BtnSinavIslemleri.UseVisualStyleBackColor = true;
            this.BtnSinavIslemleri.Click += new System.EventHandler(this.BtnSinavIslemleri_Click);
            // 
            // BtnSinavNotlari
            // 
            this.BtnSinavNotlari.Location = new System.Drawing.Point(62, 311);
            this.BtnSinavNotlari.Name = "BtnSinavNotlari";
            this.BtnSinavNotlari.Size = new System.Drawing.Size(345, 53);
            this.BtnSinavNotlari.TabIndex = 4;
            this.BtnSinavNotlari.Text = "SINAV NOTLARI";
            this.BtnSinavNotlari.UseVisualStyleBackColor = true;
            this.BtnSinavNotlari.Click += new System.EventHandler(this.BtnSinavNotlari_Click);
            // 
            // BtnSinavTarihleri
            // 
            this.BtnSinavTarihleri.Location = new System.Drawing.Point(62, 243);
            this.BtnSinavTarihleri.Name = "BtnSinavTarihleri";
            this.BtnSinavTarihleri.Size = new System.Drawing.Size(345, 53);
            this.BtnSinavTarihleri.TabIndex = 3;
            this.BtnSinavTarihleri.Text = "SINAV İŞLEMLERİ";
            this.BtnSinavTarihleri.UseVisualStyleBackColor = true;
            this.BtnSinavTarihleri.Click += new System.EventHandler(this.BtnSinavTarihleri_Click);
            // 
            // FrmOgretmen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 411);
            this.Controls.Add(this.BtnSinavTarihleri);
            this.Controls.Add(this.BtnSinavNotlari);
            this.Controls.Add(this.BtnSinavIslemleri);
            this.Controls.Add(this.BtnSoruIslemleri);
            this.Controls.Add(this.BtnOgrenciIslemleri);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmOgretmen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğretmen Paneli";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnOgrenciIslemleri;
        private System.Windows.Forms.Button BtnSoruIslemleri;
        private System.Windows.Forms.Button BtnSinavIslemleri;
        private System.Windows.Forms.Button BtnSinavNotlari;
        private System.Windows.Forms.Button BtnSinavTarihleri;
    }
}