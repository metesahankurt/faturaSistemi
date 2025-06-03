namespace FaturaKasaSistemi
{
    partial class KasaRaporuForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.Label lblToplamSatis;
        private System.Windows.Forms.Label lblToplamKDV;
        private System.Windows.Forms.Label lblGenelToplam;
        private System.Windows.Forms.DataGridView dataGridView1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTarih = new System.Windows.Forms.Label();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.lblToplamSatis = new System.Windows.Forms.Label();
            this.lblToplamKDV = new System.Windows.Forms.Label();
            this.lblGenelToplam = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Location = new System.Drawing.Point(20, 20);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(37, 15);
            this.lblTarih.TabIndex = 0;
            this.lblTarih.Text = "Tarih:";
            // 
            // dtpTarih
            // 
            this.dtpTarih.Location = new System.Drawing.Point(70, 15);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(200, 23);
            this.dtpTarih.TabIndex = 1;
            this.dtpTarih.ValueChanged += new System.EventHandler(this.dtpTarih_ValueChanged);
            // 
            // lblToplamSatis
            // 
            this.lblToplamSatis.AutoSize = true;
            this.lblToplamSatis.Location = new System.Drawing.Point(20, 55);
            this.lblToplamSatis.Name = "lblToplamSatis";
            this.lblToplamSatis.Size = new System.Drawing.Size(90, 15);
            this.lblToplamSatis.TabIndex = 2;
            this.lblToplamSatis.Text = "Toplam Satış: 0";
            // 
            // lblToplamKDV
            // 
            this.lblToplamKDV.AutoSize = true;
            this.lblToplamKDV.Location = new System.Drawing.Point(180, 55);
            this.lblToplamKDV.Name = "lblToplamKDV";
            this.lblToplamKDV.Size = new System.Drawing.Size(85, 15);
            this.lblToplamKDV.TabIndex = 3;
            this.lblToplamKDV.Text = "Toplam KDV: 0";
            // 
            // lblGenelToplam
            // 
            this.lblGenelToplam.AutoSize = true;
            this.lblGenelToplam.Location = new System.Drawing.Point(340, 55);
            this.lblGenelToplam.Name = "lblGenelToplam";
            this.lblGenelToplam.Size = new System.Drawing.Size(97, 15);
            this.lblGenelToplam.TabIndex = 4;
            this.lblGenelToplam.Text = "Genel Toplam: 0";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(500, 250);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            // 
            // KasaRaporuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 370);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblGenelToplam);
            this.Controls.Add(this.lblToplamKDV);
            this.Controls.Add(this.lblToplamSatis);
            this.Controls.Add(this.dtpTarih);
            this.Controls.Add(this.lblTarih);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KasaRaporuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kasa Raporu";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
} 