namespace FaturaKasaSistemi
{
    partial class InvoiceSearchForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblInvoiceNo;
        private System.Windows.Forms.TextBox txtInvoiceNo;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblDateRange;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Button btnDeleteInvoice;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Button btnExportPdf;

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
            pnlSearch = new Panel();
            lblCustomerName = new Label();
            txtCustomerName = new TextBox();
            lblInvoiceNo = new Label();
            txtInvoiceNo = new TextBox();
            lblDateRange = new Label();
            dtpStart = new DateTimePicker();
            dtpEnd = new DateTimePicker();
            btnSearch = new Button();
            lblArrow = new Label();
            dataGridView1 = new DataGridView();
            btnDeleteInvoice = new Button();
            btnClose = new Button();
            btnMinimize = new Button();
            label1 = new Label();
            btnExportPdf = new Button();
            pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pnlSearch
            // 
            pnlSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlSearch.BackColor = Color.Transparent;
            pnlSearch.Controls.Add(lblCustomerName);
            pnlSearch.Controls.Add(txtCustomerName);
            pnlSearch.Controls.Add(lblInvoiceNo);
            pnlSearch.Controls.Add(txtInvoiceNo);
            pnlSearch.Controls.Add(lblDateRange);
            pnlSearch.Controls.Add(dtpStart);
            pnlSearch.Controls.Add(dtpEnd);
            pnlSearch.Controls.Add(btnSearch);
            pnlSearch.Controls.Add(lblArrow);
            pnlSearch.Location = new Point(28, 62);
            pnlSearch.Name = "pnlSearch";
            pnlSearch.Size = new Size(760, 70);
            pnlSearch.TabIndex = 0;
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblCustomerName.ForeColor = Color.RoyalBlue;
            lblCustomerName.Location = new Point(10, 12);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(95, 20);
            lblCustomerName.TabIndex = 0;
            lblCustomerName.Text = "Müşteri Adı:";
            // 
            // txtCustomerName
            // 
            txtCustomerName.Font = new Font("Segoe UI", 11F);
            txtCustomerName.Location = new Point(114, 10);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(120, 27);
            txtCustomerName.TabIndex = 1;
            // 
            // lblInvoiceNo
            // 
            lblInvoiceNo.AutoSize = true;
            lblInvoiceNo.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblInvoiceNo.ForeColor = Color.RoyalBlue;
            lblInvoiceNo.Location = new Point(262, 12);
            lblInvoiceNo.Name = "lblInvoiceNo";
            lblInvoiceNo.Size = new Size(83, 20);
            lblInvoiceNo.TabIndex = 2;
            lblInvoiceNo.Text = "Fatura No:";
            // 
            // txtInvoiceNo
            // 
            txtInvoiceNo.Font = new Font("Segoe UI", 11F);
            txtInvoiceNo.Location = new Point(351, 10);
            txtInvoiceNo.Name = "txtInvoiceNo";
            txtInvoiceNo.Size = new Size(120, 27);
            txtInvoiceNo.TabIndex = 3;
            // 
            // lblDateRange
            // 
            lblDateRange.AutoSize = true;
            lblDateRange.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblDateRange.ForeColor = Color.RoyalBlue;
            lblDateRange.Location = new Point(10, 43);
            lblDateRange.Name = "lblDateRange";
            lblDateRange.Size = new Size(98, 20);
            lblDateRange.TabIndex = 4;
            lblDateRange.Text = "Tarih Aralığı:";
            // 
            // dtpStart
            // 
            dtpStart.CalendarFont = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpStart.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpStart.Location = new Point(114, 43);
            dtpStart.Name = "dtpStart";
            dtpStart.Size = new Size(191, 22);
            dtpStart.TabIndex = 5;
            // 
            // dtpEnd
            // 
            dtpEnd.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpEnd.Location = new Point(351, 43);
            dtpEnd.Name = "dtpEnd";
            dtpEnd.Size = new Size(185, 22);
            dtpEnd.TabIndex = 6;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearch.BackColor = Color.RoyalBlue;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(577, 15);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(90, 40);
            btnSearch.TabIndex = 7;
            btnSearch.Text = "Ara";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // lblArrow
            // 
            lblArrow.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblArrow.ForeColor = Color.RoyalBlue;
            lblArrow.Location = new Point(325, 39);
            lblArrow.Name = "lblArrow";
            lblArrow.Size = new Size(20, 28);
            lblArrow.TabIndex = 8;
            lblArrow.Text = "→";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
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
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Location = new Point(28, 152);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(760, 350);
            dataGridView1.TabIndex = 1;
            // 
            // btnDeleteInvoice
            // 
            btnDeleteInvoice.BackColor = Color.RoyalBlue;
            btnDeleteInvoice.FlatAppearance.BorderSize = 0;
            btnDeleteInvoice.FlatStyle = FlatStyle.Flat;
            btnDeleteInvoice.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnDeleteInvoice.ForeColor = Color.White;
            btnDeleteInvoice.Location = new Point(227, 525);
            btnDeleteInvoice.Name = "btnDeleteInvoice";
            btnDeleteInvoice.Size = new Size(160, 45);
            btnDeleteInvoice.TabIndex = 2;
            btnDeleteInvoice.Text = "Faturayı Sil";
            btnDeleteInvoice.UseVisualStyleBackColor = false;
            btnDeleteInvoice.Click += btnDeleteInvoice_Click;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.BackColor = Color.White;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnClose.ForeColor = Color.RoyalBlue;
            btnClose.Location = new Point(758, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(30, 30);
            btnClose.TabIndex = 4;
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
            btnMinimize.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnMinimize.ForeColor = Color.RoyalBlue;
            btnMinimize.Location = new Point(718, 12);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(30, 30);
            btnMinimize.TabIndex = 3;
            btnMinimize.UseVisualStyleBackColor = false;
            btnMinimize.Click += btnMinimize_Click;
            btnMinimize.Paint += btnMinimize_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.ForeColor = Color.RoyalBlue;
            label1.Location = new Point(290, 19);
            label1.Name = "label1";
            label1.Size = new Size(248, 20);
            label1.TabIndex = 12;
            label1.Text = "Müşteri ve Fatura Kontrol Merkezi";
            // 
            // btnExportPdf
            // 
            btnExportPdf.BackColor = Color.RoyalBlue;
            btnExportPdf.FlatAppearance.BorderSize = 0;
            btnExportPdf.FlatStyle = FlatStyle.Flat;
            btnExportPdf.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnExportPdf.ForeColor = Color.White;
            btnExportPdf.Location = new Point(427, 525);
            btnExportPdf.Name = "btnExportPdf";
            btnExportPdf.Size = new Size(160, 45);
            btnExportPdf.TabIndex = 3;
            btnExportPdf.Text = "PDF Olarak Çıkar";
            btnExportPdf.UseVisualStyleBackColor = false;
            btnExportPdf.Click += btnExportPdf_Click;
            // 
            // InvoiceSearchForm
            // 
            ClientSize = new Size(800, 600);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(btnDeleteInvoice);
            Controls.Add(btnMinimize);
            Controls.Add(btnClose);
            Controls.Add(pnlSearch);
            Controls.Add(btnExportPdf);
            FormBorderStyle = FormBorderStyle.None;
            Name = "InvoiceSearchForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fatura Arama";
            Load += InvoiceSearchForm_Load;
            MouseDown += InvoiceSearchForm_MouseDown;
            pnlSearch.ResumeLayout(false);
            pnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private Label lblArrow;
        private Label label1;
    }
} 