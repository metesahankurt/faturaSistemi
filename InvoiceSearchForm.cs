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
                if (dataGridView1.Columns["invoice_no"] != null) dataGridView1.Columns["invoice_no"].HeaderText = "Fatura No";
                if (dataGridView1.Columns["customer_name"] != null) dataGridView1.Columns["customer_name"].HeaderText = "Müşteri";
                if (dataGridView1.Columns["invoice_date"] != null) dataGridView1.Columns["invoice_date"].HeaderText = "Tarih";
                if (dataGridView1.Columns["subtotal"] != null) dataGridView1.Columns["subtotal"].HeaderText = "Ara Toplam";
                if (dataGridView1.Columns["vat"] != null) dataGridView1.Columns["vat"].HeaderText = "KDV";
                if (dataGridView1.Columns["total"] != null) dataGridView1.Columns["total"].HeaderText = "Genel Toplam";
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

        private void btnDeleteInvoice_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen silmek için bir fatura seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var row = dataGridView1.SelectedRows[0];
            string invoiceNo = row.Cells["invoice_no"].Value?.ToString();
            if (string.IsNullOrEmpty(invoiceNo))
            {
                MessageBox.Show("Fatura numarası alınamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var result = MessageBox.Show($"{invoiceNo} numaralı faturayı silmek istediğinize emin misiniz?\nBu işleme ait tüm satırlar da silinecek!", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                string connectionString = "server=localhost;database=faturakasa;user=root;password=199419033Mm.;";
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        // Önce invoice_items'tan sil
                        string delItems = "DELETE ii FROM invoice_items ii JOIN invoices f ON ii.invoice_id = f.id WHERE f.invoice_no = @invoiceNo";
                        using (MySqlCommand cmd1 = new MySqlCommand(delItems, conn))
                        {
                            cmd1.Parameters.AddWithValue("@invoiceNo", invoiceNo);
                            cmd1.ExecuteNonQuery();
                        }
                        // Sonra faturayı sil
                        string delInvoice = "DELETE FROM invoices WHERE invoice_no = @invoiceNo";
                        using (MySqlCommand cmd2 = new MySqlCommand(delInvoice, conn))
                        {
                            cmd2.Parameters.AddWithValue("@invoiceNo", invoiceNo);
                            cmd2.ExecuteNonQuery();
                        }
                        MessageBox.Show("Fatura ve satırları başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnSearch_Click(null, null); // Listeyi güncelle
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Veritabanı hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
} 