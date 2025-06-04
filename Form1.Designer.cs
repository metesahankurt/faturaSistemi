namespace FaturaKasaSistemi;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    private System.Windows.Forms.Button btnProductForm;
    private System.Windows.Forms.Button btnInvoiceForm;
    private System.Windows.Forms.Button btnCustomerForm;
    private System.Windows.Forms.Button btnKasaRaporu;
    private System.Windows.Forms.Button btnInvoiceSearch;
    private System.Windows.Forms.Button btnCustomerList;
    private System.Windows.Forms.Panel pnlRight;
    private System.Windows.Forms.Label lblWelcome;
    private System.Windows.Forms.Label lblDateTime;
    private System.Windows.Forms.Panel pnlCounterMusteri;
    private System.Windows.Forms.Panel pnlCounterUrun;
    private System.Windows.Forms.Panel pnlCounterFatura;
    private System.Windows.Forms.Panel pnlCounterSatis;
    private System.Windows.Forms.Label lblCounterMusteri;
    private System.Windows.Forms.Label lblCounterUrun;
    private System.Windows.Forms.Label lblCounterFatura;
    private System.Windows.Forms.Label lblCounterSatis;
    private System.Windows.Forms.Panel pnlInfo;
    private System.Windows.Forms.Label lblInfo;
    private System.Windows.Forms.Button btnClose;
    private System.Windows.Forms.Button btnMinimize;
    private System.Windows.Forms.Panel pnlLeft;
    private System.Windows.Forms.Timer clockTimer;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
        btnProductForm = new Button();
        btnInvoiceForm = new Button();
        btnCustomerForm = new Button();
        btnKasaRaporu = new Button();
        btnInvoiceSearch = new Button();
        btnCustomerList = new Button();
        pnlRight = new Panel();
        lblWelcome = new Label();
        lblDateTime = new Label();
        pnlCounterMusteri = new Panel();
        lblCounterMusteri = new Label();
        lblMusteri = new Label();
        pnlCounterUrun = new Panel();
        lblCounterUrun = new Label();
        lblUrun = new Label();
        pnlCounterFatura = new Panel();
        lblCounterFatura = new Label();
        lblFatura = new Label();
        pnlCounterSatis = new Panel();
        lblCounterSatis = new Label();
        lblSatis = new Label();
        pnlInfo = new Panel();
        lblInfo = new Label();
        btnClose = new Button();
        btnMinimize = new Button();
        pnlLeft = new Panel();
        clockTimer = new System.Windows.Forms.Timer(components);
        pnlRight.SuspendLayout();
        pnlCounterMusteri.SuspendLayout();
        pnlCounterUrun.SuspendLayout();
        pnlCounterFatura.SuspendLayout();
        pnlCounterSatis.SuspendLayout();
        pnlInfo.SuspendLayout();
        pnlLeft.SuspendLayout();
        SuspendLayout();
        // 
        // btnProductForm
        // 
        btnProductForm.Location = new Point(21, 57);
        btnProductForm.Name = "btnProductForm";
        btnProductForm.Size = new Size(150, 40);
        btnProductForm.TabIndex = 0;
        btnProductForm.Text = "Ürün Tanımlama";
        btnProductForm.UseVisualStyleBackColor = true;
        btnProductForm.Click += btnProductForm_Click;
        // 
        // btnInvoiceForm
        // 
        btnInvoiceForm.Location = new Point(21, 117);
        btnInvoiceForm.Name = "btnInvoiceForm";
        btnInvoiceForm.Size = new Size(150, 40);
        btnInvoiceForm.TabIndex = 1;
        btnInvoiceForm.Text = "Fatura Oluştur";
        btnInvoiceForm.UseVisualStyleBackColor = true;
        btnInvoiceForm.Click += btnInvoiceForm_Click;
        // 
        // btnCustomerForm
        // 
        btnCustomerForm.Location = new Point(21, 177);
        btnCustomerForm.Name = "btnCustomerForm";
        btnCustomerForm.Size = new Size(150, 40);
        btnCustomerForm.TabIndex = 2;
        btnCustomerForm.Text = "Müşteri Ekle";
        btnCustomerForm.UseVisualStyleBackColor = true;
        btnCustomerForm.Click += btnCustomerForm_Click;
        // 
        // btnKasaRaporu
        // 
        btnKasaRaporu.Location = new Point(21, 297);
        btnKasaRaporu.Name = "btnKasaRaporu";
        btnKasaRaporu.Size = new Size(150, 40);
        btnKasaRaporu.TabIndex = 4;
        btnKasaRaporu.Text = "Kasa Raporu";
        btnKasaRaporu.UseVisualStyleBackColor = true;
        btnKasaRaporu.Click += btnKasaRaporu_Click;
        // 
        // btnInvoiceSearch
        // 
        btnInvoiceSearch.Location = new Point(21, 237);
        btnInvoiceSearch.Name = "btnInvoiceSearch";
        btnInvoiceSearch.Size = new Size(150, 40);
        btnInvoiceSearch.TabIndex = 3;
        btnInvoiceSearch.Text = "Fatura Ara/Listele";
        btnInvoiceSearch.UseVisualStyleBackColor = true;
        btnInvoiceSearch.Click += btnInvoiceSearch_Click;
        // 
        // btnCustomerList
        // 
        btnCustomerList.Location = new Point(21, 357);
        btnCustomerList.Name = "btnCustomerList";
        btnCustomerList.Size = new Size(150, 40);
        btnCustomerList.TabIndex = 5;
        btnCustomerList.Text = "Müşteriler";
        btnCustomerList.UseVisualStyleBackColor = true;
        btnCustomerList.Click += btnCustomerList_Click;
        // 
        // pnlRight
        // 
        pnlRight.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
        pnlRight.BackColor = Color.WhiteSmoke;
        pnlRight.Controls.Add(lblWelcome);
        pnlRight.Controls.Add(lblDateTime);
        pnlRight.Controls.Add(pnlCounterMusteri);
        pnlRight.Controls.Add(pnlCounterUrun);
        pnlRight.Controls.Add(pnlCounterFatura);
        pnlRight.Controls.Add(pnlCounterSatis);
        pnlRight.Controls.Add(pnlInfo);
        pnlRight.Location = new Point(223, 0);
        pnlRight.Name = "pnlRight";
        pnlRight.Size = new Size(577, 464);
        pnlRight.TabIndex = 1;
        // 
        // lblWelcome
        // 
        lblWelcome.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
        lblWelcome.ForeColor = Color.RoyalBlue;
        lblWelcome.Location = new Point(30, 30);
        lblWelcome.Name = "lblWelcome";
        lblWelcome.Size = new Size(400, 35);
        lblWelcome.TabIndex = 0;
        lblWelcome.Text = "Hoşgeldiniz, [Kullanıcı]!";
        // 
        // lblDateTime
        // 
        lblDateTime.Font = new Font("Segoe UI", 10F);
        lblDateTime.ForeColor = Color.Gray;
        lblDateTime.Location = new Point(30, 70);
        lblDateTime.Name = "lblDateTime";
        lblDateTime.Size = new Size(400, 30);
        lblDateTime.TabIndex = 1;
        lblDateTime.Text = "Tarih: 00.00.0000 00:00";
        // 
        // pnlCounterMusteri
        // 
        pnlCounterMusteri.BackColor = Color.White;
        pnlCounterMusteri.BorderStyle = BorderStyle.FixedSingle;
        pnlCounterMusteri.Controls.Add(lblCounterMusteri);
        pnlCounterMusteri.Controls.Add(lblMusteri);
        pnlCounterMusteri.Location = new Point(30, 110);
        pnlCounterMusteri.Name = "pnlCounterMusteri";
        pnlCounterMusteri.Size = new Size(120, 70);
        pnlCounterMusteri.TabIndex = 2;
        // 
        // lblCounterMusteri
        // 
        lblCounterMusteri.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        lblCounterMusteri.ForeColor = Color.RoyalBlue;
        lblCounterMusteri.Location = new Point(30, 10);
        lblCounterMusteri.Name = "lblCounterMusteri";
        lblCounterMusteri.Size = new Size(60, 30);
        lblCounterMusteri.TabIndex = 0;
        lblCounterMusteri.Text = "0";
        lblCounterMusteri.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // lblMusteri
        // 
        lblMusteri.Font = new Font("Segoe UI", 10F);
        lblMusteri.Location = new Point(30, 40);
        lblMusteri.Name = "lblMusteri";
        lblMusteri.Size = new Size(80, 25);
        lblMusteri.TabIndex = 1;
        lblMusteri.Text = "Müşteri";
        // 
        // pnlCounterUrun
        // 
        pnlCounterUrun.BackColor = Color.White;
        pnlCounterUrun.BorderStyle = BorderStyle.FixedSingle;
        pnlCounterUrun.Controls.Add(lblCounterUrun);
        pnlCounterUrun.Controls.Add(lblUrun);
        pnlCounterUrun.Location = new Point(170, 110);
        pnlCounterUrun.Name = "pnlCounterUrun";
        pnlCounterUrun.Size = new Size(120, 70);
        pnlCounterUrun.TabIndex = 3;
        // 
        // lblCounterUrun
        // 
        lblCounterUrun.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        lblCounterUrun.ForeColor = Color.RoyalBlue;
        lblCounterUrun.Location = new Point(30, 10);
        lblCounterUrun.Name = "lblCounterUrun";
        lblCounterUrun.Size = new Size(60, 30);
        lblCounterUrun.TabIndex = 0;
        lblCounterUrun.Text = "0";
        lblCounterUrun.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // lblUrun
        // 
        lblUrun.Font = new Font("Segoe UI", 10F);
        lblUrun.Location = new Point(30, 40);
        lblUrun.Name = "lblUrun";
        lblUrun.Size = new Size(80, 25);
        lblUrun.TabIndex = 1;
        lblUrun.Text = "Ürün";
        // 
        // pnlCounterFatura
        // 
        pnlCounterFatura.BackColor = Color.White;
        pnlCounterFatura.BorderStyle = BorderStyle.FixedSingle;
        pnlCounterFatura.Controls.Add(lblCounterFatura);
        pnlCounterFatura.Controls.Add(lblFatura);
        pnlCounterFatura.Location = new Point(310, 110);
        pnlCounterFatura.Name = "pnlCounterFatura";
        pnlCounterFatura.Size = new Size(120, 70);
        pnlCounterFatura.TabIndex = 4;
        // 
        // lblCounterFatura
        // 
        lblCounterFatura.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        lblCounterFatura.ForeColor = Color.RoyalBlue;
        lblCounterFatura.Location = new Point(30, 10);
        lblCounterFatura.Name = "lblCounterFatura";
        lblCounterFatura.Size = new Size(60, 30);
        lblCounterFatura.TabIndex = 0;
        lblCounterFatura.Text = "0";
        lblCounterFatura.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // lblFatura
        // 
        lblFatura.Font = new Font("Segoe UI", 10F);
        lblFatura.Location = new Point(30, 40);
        lblFatura.Name = "lblFatura";
        lblFatura.Size = new Size(80, 25);
        lblFatura.TabIndex = 1;
        lblFatura.Text = "Fatura";
        // 
        // pnlCounterSatis
        // 
        pnlCounterSatis.BackColor = Color.White;
        pnlCounterSatis.BorderStyle = BorderStyle.FixedSingle;
        pnlCounterSatis.Controls.Add(lblCounterSatis);
        pnlCounterSatis.Controls.Add(lblSatis);
        pnlCounterSatis.Location = new Point(450, 110);
        pnlCounterSatis.Name = "pnlCounterSatis";
        pnlCounterSatis.Size = new Size(120, 70);
        pnlCounterSatis.TabIndex = 5;
        // 
        // lblCounterSatis
        // 
        lblCounterSatis.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        lblCounterSatis.ForeColor = Color.RoyalBlue;
        lblCounterSatis.Location = new Point(30, 10);
        lblCounterSatis.Name = "lblCounterSatis";
        lblCounterSatis.Size = new Size(90, 30);
        lblCounterSatis.TabIndex = 0;
        lblCounterSatis.Text = "0";
        lblCounterSatis.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // lblSatis
        // 
        lblSatis.Font = new Font("Segoe UI", 10F);
        lblSatis.Location = new Point(10, 40);
        lblSatis.Name = "lblSatis";
        lblSatis.Size = new Size(110, 25);
        lblSatis.TabIndex = 1;
        lblSatis.Text = "Bugünkü Satış";
        // 
        // pnlInfo
        // 
        pnlInfo.BackColor = Color.White;
        pnlInfo.BorderStyle = BorderStyle.FixedSingle;
        pnlInfo.Controls.Add(lblInfo);
        pnlInfo.Location = new Point(20, 217);
        pnlInfo.Name = "pnlInfo";
        pnlInfo.Size = new Size(550, 60);
        pnlInfo.TabIndex = 6;
        // 
        // lblInfo
        // 
        lblInfo.Font = new Font("Segoe UI", 10F);
        lblInfo.ForeColor = Color.Gray;
        lblInfo.Location = new Point(10, 10);
        lblInfo.Name = "lblInfo";
        lblInfo.Size = new Size(530, 40);
        lblInfo.TabIndex = 0;
        lblInfo.Text = "Bu proje Nesne Yönelimli Programlama prensipleriyle hazırlanmıştır.\nTüm işlemler sol menüden erişilebilir.";
        // 
        // btnClose
        // 
        btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnClose.BackColor = Color.White;
        btnClose.FlatStyle = FlatStyle.Flat;
        btnClose.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        btnClose.ForeColor = Color.RoyalBlue;
        btnClose.Location = new Point(21, 0);
        btnClose.Name = "btnClose";
        btnClose.Size = new Size(36, 36);
        btnClose.TabIndex = 2;
        btnClose.Text = "X";
        btnClose.UseVisualStyleBackColor = false;
        btnClose.Click += btnClose_Click;
        // 
        // btnMinimize
        // 
        btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnMinimize.BackColor = Color.White;
        btnMinimize.FlatAppearance.BorderColor = Color.White;
        btnMinimize.FlatAppearance.BorderSize = 0;
        btnMinimize.FlatAppearance.MouseDownBackColor = Color.White;
        btnMinimize.FlatAppearance.MouseOverBackColor = Color.White;
        btnMinimize.FlatStyle = FlatStyle.Flat;
        btnMinimize.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
        btnMinimize.ForeColor = Color.RoyalBlue;
        btnMinimize.Location = new Point(21, 0);
        btnMinimize.Name = "btnMinimize";
        btnMinimize.Size = new Size(36, 36);
        btnMinimize.TabIndex = 3;
        btnMinimize.TabStop = false;
        btnMinimize.UseVisualStyleBackColor = false;
        btnMinimize.Click += btnMinimize_Click;
        btnMinimize.Paint += btnMinimize_Paint;
        // 
        // pnlLeft
        // 
        pnlLeft.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
        pnlLeft.BackColor = Color.FromArgb(30, 80, 180);
        pnlLeft.Controls.Add(btnProductForm);
        pnlLeft.Controls.Add(btnInvoiceForm);
        pnlLeft.Controls.Add(btnCustomerForm);
        pnlLeft.Controls.Add(btnInvoiceSearch);
        pnlLeft.Controls.Add(btnKasaRaporu);
        pnlLeft.Controls.Add(btnCustomerList);
        pnlLeft.Location = new Point(0, 0);
        pnlLeft.Name = "pnlLeft";
        pnlLeft.Size = new Size(200, 464);
        pnlLeft.TabIndex = 0;
        // 
        // clockTimer
        // 
        clockTimer.Enabled = true;
        clockTimer.Interval = 1000;
        clockTimer.Tick += clockTimer_Tick;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(821, 464);
        Controls.Add(pnlLeft);
        Controls.Add(pnlRight);
        Controls.Add(btnClose);
        Controls.Add(btnMinimize);
        FormBorderStyle = FormBorderStyle.None;
        Icon = (Icon)resources.GetObject("$this.Icon");
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Dashboard";
        pnlRight.ResumeLayout(false);
        pnlCounterMusteri.ResumeLayout(false);
        pnlCounterUrun.ResumeLayout(false);
        pnlCounterFatura.ResumeLayout(false);
        pnlCounterSatis.ResumeLayout(false);
        pnlInfo.ResumeLayout(false);
        pnlLeft.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private Label lblMusteri;
    private Label lblUrun;
    private Label lblFatura;
    private Label lblSatis;
}
