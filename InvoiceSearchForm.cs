using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FaturaKasaSistemi
{
    public partial class InvoiceSearchForm : Form
    {
        public InvoiceSearchForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string customerName = txtCustomerName.Text.Trim();
            string invoiceNo = txtInvoiceNo.Text.Trim();
            DateTime startDate = dtpStart.Value.Date;
            DateTime endDate = dtpEnd.Value.Date;
            string connectionString = "server=localhost;database=faturakasa;user=root;password=199419033Mm.;";
            string query = "SELECT invoice_no, customer_name, invoice_date, subtotal, vat, total FROM invoices WHERE 1=1";
            if (!string.IsNullOrEmpty(customerName))
                query += " AND customer_name LIKE @customerName";
            if (!string.IsNullOrEmpty(invoiceNo))
                query += " AND invoice_no LIKE @invoiceNo";
            query += " AND DATE(invoice_date) >= @startDate AND DATE(invoice_date) <= @endDate";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
            {
                if (!string.IsNullOrEmpty(customerName))
                    adapter.SelectCommand.Parameters.AddWithValue("@customerName", "%" + customerName + "%");
                if (!string.IsNullOrEmpty(invoiceNo))
                    adapter.SelectCommand.Parameters.AddWithValue("@invoiceNo", "%" + invoiceNo + "%");
                adapter.SelectCommand.Parameters.AddWithValue("@startDate", startDate);
                adapter.SelectCommand.Parameters.AddWithValue("@endDate", endDate);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void InvoiceSearchForm_Load(object sender, EventArgs e)
        {
            // Varsayılan olarak son 30 günü göster
            dtpEnd.Value = DateTime.Today;
            dtpStart.Value = DateTime.Today.AddDays(-30);
            btnSearch_Click(sender, e);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridView1.Rows[e.RowIndex];
                string invoiceNo = row.Cells["invoice_no"].Value?.ToString();
                if (!string.IsNullOrEmpty(invoiceNo))
                {
                    InvoiceDetailForm detailForm = new InvoiceDetailForm(invoiceNo);
                    detailForm.ShowDialog();
                }
            }
        }
    }
} 