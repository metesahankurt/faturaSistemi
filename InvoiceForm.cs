using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FaturaKasaSistemi
{
    public partial class InvoiceForm : Form
    {
        private List<InvoiceItem> invoiceItems = new List<InvoiceItem>();

        public InvoiceForm()
        {
            InitializeComponent();
            LoadCustomers();
            LoadProducts();
        }

        private void LoadCustomers()
        {
            string connectionString = "server=localhost;database=faturakasa;user=root;password=199419033Mm.;";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT id, CONCAT(first_name, ' ', last_name, ' - ', city, '/', district) as display FROM customers";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        cmbCustomers.DataSource = dt;
                        cmbCustomers.DisplayMember = "display";
                        cmbCustomers.ValueMember = "id";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Müşteri listesi yüklenemedi: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadProducts()
        {
            string connectionString = "server=localhost;database=faturakasa;user=root;password=199419033Mm.;";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT id, name, price, vat_rate FROM products";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        cmbProducts.DataSource = dt;
                        cmbProducts.DisplayMember = "name";
                        cmbProducts.ValueMember = "id";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veritabanı hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if (cmbProducts.SelectedItem == null) return;
            DataRowView selectedProduct = (DataRowView)cmbProducts.SelectedItem;
            int productId = Convert.ToInt32(selectedProduct["id"]);
            string name = selectedProduct["name"].ToString();
            decimal price = Convert.ToDecimal(selectedProduct["price"]);
            decimal vat = Convert.ToDecimal(selectedProduct["vat_rate"]);
            int quantity = (int)numQuantity.Value;

            invoiceItems.Add(new InvoiceItem
            {
                ProductId = productId,
                ProductName = name,
                UnitPrice = price,
                VatRate = vat,
                Quantity = quantity
            });
            RefreshInvoiceItems();
        }

        private void RefreshInvoiceItems()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = invoiceItems;
            CalculateTotals();
        }

        private void CalculateTotals()
        {
            decimal subtotal = 0, totalVat = 0, total = 0;
            foreach (var item in invoiceItems)
            {
                decimal lineTotal = item.UnitPrice * item.Quantity;
                decimal lineVat = lineTotal * item.VatRate / 100;
                subtotal += lineTotal;
                totalVat += lineVat;
            }
            total = subtotal + totalVat;
            lblSubtotal.Text = $"Ara Toplam: {subtotal:C2}";
            lblVat.Text = $"KDV: {totalVat:C2}";
            lblTotal.Text = $"Genel Toplam: {total:C2}";
        }

        private class InvoiceItem
        {
            public int ProductId { get; set; }
            public string ProductName { get; set; }
            public decimal UnitPrice { get; set; }
            public decimal VatRate { get; set; }
            public int Quantity { get; set; }
            public decimal LineTotal => UnitPrice * Quantity * (1 + VatRate / 100);
        }
    }
} 