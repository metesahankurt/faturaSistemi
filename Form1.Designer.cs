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
        btnProductForm = new Button();
        btnInvoiceForm = new Button();
        btnCustomerForm = new Button();
        btnKasaRaporu = new Button();
        SuspendLayout();
        // 
        // btnProductForm
        // 
        btnProductForm.Location = new Point(30, 30);
        btnProductForm.Name = "btnProductForm";
        btnProductForm.Size = new Size(150, 40);
        btnProductForm.TabIndex = 0;
        btnProductForm.Text = "Ürün Tanımlama";
        btnProductForm.UseVisualStyleBackColor = true;
        btnProductForm.Click += btnProductForm_Click;
        // 
        // btnInvoiceForm
        // 
        btnInvoiceForm.Location = new Point(30, 90);
        btnInvoiceForm.Name = "btnInvoiceForm";
        btnInvoiceForm.Size = new Size(150, 40);
        btnInvoiceForm.TabIndex = 1;
        btnInvoiceForm.Text = "Fatura Oluştur";
        btnInvoiceForm.UseVisualStyleBackColor = true;
        btnInvoiceForm.Click += btnInvoiceForm_Click;
        // 
        // btnCustomerForm
        // 
        btnCustomerForm.Location = new Point(30, 150);
        btnCustomerForm.Name = "btnCustomerForm";
        btnCustomerForm.Size = new Size(150, 40);
        btnCustomerForm.TabIndex = 2;
        btnCustomerForm.Text = "Müşteri Ekle";
        btnCustomerForm.UseVisualStyleBackColor = true;
        btnCustomerForm.Click += btnCustomerForm_Click;
        // 
        // btnKasaRaporu
        // 
        btnKasaRaporu.Location = new Point(30, 210);
        btnKasaRaporu.Name = "btnKasaRaporu";
        btnKasaRaporu.Size = new Size(150, 40);
        btnKasaRaporu.TabIndex = 3;
        btnKasaRaporu.Text = "Kasa Raporu";
        btnKasaRaporu.UseVisualStyleBackColor = true;
        btnKasaRaporu.Click += btnKasaRaporu_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(btnProductForm);
        Controls.Add(btnInvoiceForm);
        Controls.Add(btnCustomerForm);
        Controls.Add(btnKasaRaporu);
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Dashboard";
        ResumeLayout(false);
    }

    #endregion
}
