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
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimize;

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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KasaRaporuForm));
            lblTarih = new Label();
            dtpTarih = new DateTimePicker();
            lblToplamSatis = new Label();
            lblToplamKDV = new Label();
            lblGenelToplam = new Label();
            dataGridView1 = new DataGridView();
            btnClose = new Button();
            btnMinimize = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblTarih
            // 
            lblTarih.AutoSize = true;
            lblTarih.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTarih.ForeColor = Color.RoyalBlue;
            lblTarih.Location = new Point(20, 20);
            lblTarih.Name = "lblTarih";
            lblTarih.Size = new Size(48, 20);
            lblTarih.TabIndex = 0;
            lblTarih.Text = "Tarih:";
            // 
            // dtpTarih
            // 
            dtpTarih.Font = new Font("Segoe UI", 11F);
            dtpTarih.Location = new Point(70, 15);
            dtpTarih.Name = "dtpTarih";
            dtpTarih.Size = new Size(200, 27);
            dtpTarih.TabIndex = 1;
            dtpTarih.ValueChanged += dtpTarih_ValueChanged;
            // 
            // lblToplamSatis
            // 
            lblToplamSatis.AutoSize = true;
            lblToplamSatis.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblToplamSatis.ForeColor = Color.RoyalBlue;
            lblToplamSatis.Location = new Point(20, 55);
            lblToplamSatis.Name = "lblToplamSatis";
            lblToplamSatis.Size = new Size(115, 20);
            lblToplamSatis.TabIndex = 2;
            lblToplamSatis.Text = "Toplam Satış: 0";
            // 
            // lblToplamKDV
            // 
            lblToplamKDV.AutoSize = true;
            lblToplamKDV.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblToplamKDV.ForeColor = Color.RoyalBlue;
            lblToplamKDV.Location = new Point(180, 55);
            lblToplamKDV.Name = "lblToplamKDV";
            lblToplamKDV.Size = new Size(113, 20);
            lblToplamKDV.TabIndex = 3;
            lblToplamKDV.Text = "Toplam KDV: 0";
            // 
            // lblGenelToplam
            // 
            lblGenelToplam.AutoSize = true;
            lblGenelToplam.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblGenelToplam.ForeColor = Color.RoyalBlue;
            lblGenelToplam.Location = new Point(340, 55);
            lblGenelToplam.Name = "lblGenelToplam";
            lblGenelToplam.Size = new Size(122, 20);
            lblGenelToplam.TabIndex = 4;
            lblGenelToplam.Text = "Genel Toplam: 0";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.RoyalBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(20, 90);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(500, 250);
            dataGridView1.TabIndex = 5;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.BackColor = Color.White;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnClose.ForeColor = Color.RoyalBlue;
            btnClose.Location = new Point(510, 10);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(30, 30);
            btnClose.TabIndex = 6;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimize.BackColor = Color.White;
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btnMinimize.ForeColor = Color.RoyalBlue;
            btnMinimize.Location = new Point(470, 10);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(30, 30);
            btnMinimize.TabIndex = 7;
            btnMinimize.UseVisualStyleBackColor = false;
            btnMinimize.Click += btnMinimize_Click;
            btnMinimize.Paint += btnMinimize_Paint;
            // 
            // KasaRaporuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(550, 370);
            Controls.Add(dataGridView1);
            Controls.Add(lblGenelToplam);
            Controls.Add(lblToplamKDV);
            Controls.Add(lblToplamSatis);
            Controls.Add(dtpTarih);
            Controls.Add(lblTarih);
            Controls.Add(btnClose);
            Controls.Add(btnMinimize);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "KasaRaporuForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kasa Raporu";
            MouseDown += KasaRaporuForm_MouseDown;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
} 