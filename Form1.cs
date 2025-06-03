namespace FaturaKasaSistemi;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void btnProductForm_Click(object sender, EventArgs e)
    {
        ProductForm productForm = new ProductForm();
        productForm.ShowDialog();
    }

    private void btnInvoiceForm_Click(object sender, EventArgs e)
    {
        InvoiceForm invoiceForm = new InvoiceForm();
        invoiceForm.ShowDialog();
    }

    private void btnCustomerForm_Click(object sender, EventArgs e)
    {
        CustomerForm customerForm = new CustomerForm();
        customerForm.ShowDialog();
    }

    private void btnKasaRaporu_Click(object sender, EventArgs e)
    {
        KasaRaporuForm kasaRaporuForm = new KasaRaporuForm();
        kasaRaporuForm.ShowDialog();
    }
}
