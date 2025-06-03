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
        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 450);
        this.Text = "Form1";

        this.btnProductForm = new System.Windows.Forms.Button();
        this.btnProductForm.Location = new System.Drawing.Point(30, 30);
        this.btnProductForm.Name = "btnProductForm";
        this.btnProductForm.Size = new System.Drawing.Size(150, 40);
        this.btnProductForm.TabIndex = 0;
        this.btnProductForm.Text = "Ürün Tanımlama";
        this.btnProductForm.UseVisualStyleBackColor = true;
        this.btnProductForm.Click += new System.EventHandler(this.btnProductForm_Click);
        this.Controls.Add(this.btnProductForm);

        this.btnInvoiceForm = new System.Windows.Forms.Button();
        this.btnInvoiceForm.Location = new System.Drawing.Point(30, 90);
        this.btnInvoiceForm.Name = "btnInvoiceForm";
        this.btnInvoiceForm.Size = new System.Drawing.Size(150, 40);
        this.btnInvoiceForm.TabIndex = 1;
        this.btnInvoiceForm.Text = "Fatura Oluştur";
        this.btnInvoiceForm.UseVisualStyleBackColor = true;
        this.btnInvoiceForm.Click += new System.EventHandler(this.btnInvoiceForm_Click);
        this.Controls.Add(this.btnInvoiceForm);

        this.btnCustomerForm = new System.Windows.Forms.Button();
        this.btnCustomerForm.Location = new System.Drawing.Point(30, 150);
        this.btnCustomerForm.Name = "btnCustomerForm";
        this.btnCustomerForm.Size = new System.Drawing.Size(150, 40);
        this.btnCustomerForm.TabIndex = 2;
        this.btnCustomerForm.Text = "Müşteri Ekle";
        this.btnCustomerForm.UseVisualStyleBackColor = true;
        this.btnCustomerForm.Click += new System.EventHandler(this.btnCustomerForm_Click);
        this.Controls.Add(this.btnCustomerForm);
    }

    #endregion
}
