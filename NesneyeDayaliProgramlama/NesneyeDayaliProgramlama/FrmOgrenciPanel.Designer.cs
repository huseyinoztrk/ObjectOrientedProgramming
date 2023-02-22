namespace NesneyeDayaliProgramlama
{
    partial class FrmOgrenciPanel
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
            this.BtnSinavGiris = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.LblTC = new System.Windows.Forms.Label();
            this.LblAdSoyad = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSinavGiris
            // 
            this.BtnSinavGiris.Location = new System.Drawing.Point(12, 263);
            this.BtnSinavGiris.Name = "BtnSinavGiris";
            this.BtnSinavGiris.Size = new System.Drawing.Size(355, 47);
            this.BtnSinavGiris.TabIndex = 0;
            this.BtnSinavGiris.Text = "SINAV GİRİŞİ";
            this.BtnSinavGiris.UseVisualStyleBackColor = true;
            this.BtnSinavGiris.Click += new System.EventHandler(this.BtnSinavGiris_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(355, 184);
            this.dataGridView1.TabIndex = 1;
            // 
            // LblTC
            // 
            this.LblTC.AutoSize = true;
            this.LblTC.Location = new System.Drawing.Point(13, 4);
            this.LblTC.Name = "LblTC";
            this.LblTC.Size = new System.Drawing.Size(133, 25);
            this.LblTC.TabIndex = 2;
            this.LblTC.Text = "00000000000";
            // 
            // LblAdSoyad
            // 
            this.LblAdSoyad.AutoSize = true;
            this.LblAdSoyad.Location = new System.Drawing.Point(13, 36);
            this.LblAdSoyad.Name = "LblAdSoyad";
            this.LblAdSoyad.Size = new System.Drawing.Size(83, 25);
            this.LblAdSoyad.TabIndex = 3;
            this.LblAdSoyad.Text = "Null Null";
            // 
            // FrmOgrenciPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 326);
            this.Controls.Add(this.LblAdSoyad);
            this.Controls.Add(this.LblTC);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnSinavGiris);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmOgrenciPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğrenci Paneli";
            this.Load += new System.EventHandler(this.FrmOgrenciPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSinavGiris;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label LblTC;
        private System.Windows.Forms.Label LblAdSoyad;
    }
}