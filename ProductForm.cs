using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FaturaKasaSistemi
{
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            LoadProducts();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;database=faturakasa;user=root;password=199419033Mm.;";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO products (name, price, vat_rate) VALUES (@name, @price, @vat_rate)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", txtName.Text);
                        cmd.Parameters.AddWithValue("@price", numPrice.Value);
                        cmd.Parameters.AddWithValue("@vat_rate", numVat.Value);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Ürün başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadProducts();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veritabanı hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridView1.DataSource = dt;
                        if (dataGridView1.Columns["id"] != null) dataGridView1.Columns["id"].HeaderText = "ID";
                        if (dataGridView1.Columns["name"] != null) dataGridView1.Columns["name"].HeaderText = "Ürün Adı";
                        if (dataGridView1.Columns["price"] != null) dataGridView1.Columns["price"].HeaderText = "Fiyat";
                        if (dataGridView1.Columns["vat_rate"] != null) dataGridView1.Columns["vat_rate"].HeaderText = "KDV (%)";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veritabanı hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen silmek için bir ürün seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var row = dataGridView1.SelectedRows[0];
            int productId = Convert.ToInt32(row.Cells["id"].Value);

            string connectionString = "server=localhost;database=faturakasa;user=root;password=199419033Mm.;";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string checkQuery = "SELECT COUNT(*) FROM invoice_items WHERE product_id = @id";
                    using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@id", productId);
                        int kullanilmaSayisi = Convert.ToInt32(checkCmd.ExecuteScalar());
                        if (kullanilmaSayisi > 0)
                        {
                            var result = MessageBox.Show(
                                "Bu ürün bir faturada kullanıldığı için silinemez.\nYine de silmek ister misiniz? (Bu ürünle ilgili tüm fatura satırları da silinecek!)",
                                "Uyarı",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Warning);
                            if (result == DialogResult.Yes)
                            {
                                // Önce invoice_items'tan sil
                                string deleteItemsQuery = "DELETE FROM invoice_items WHERE product_id = @id";
                                using (MySqlCommand delItemsCmd = new MySqlCommand(deleteItemsQuery, conn))
                                {
                                    delItemsCmd.Parameters.AddWithValue("@id", productId);
                                    delItemsCmd.ExecuteNonQuery();
                                }
                                // Sonra ürünü sil
                                string deleteProductQuery = "DELETE FROM products WHERE id = @id";
                                using (MySqlCommand delProdCmd = new MySqlCommand(deleteProductQuery, conn))
                                {
                                    delProdCmd.Parameters.AddWithValue("@id", productId);
                                    delProdCmd.ExecuteNonQuery();
                                }
                                MessageBox.Show("Ürün ve ilgili fatura satırları başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadProducts();
                            }
                            return;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veritabanı hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            var result2 = MessageBox.Show("Seçili ürünü silmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result2 == DialogResult.Yes)
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "DELETE FROM products WHERE id = @id";
                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", productId);
                            cmd.ExecuteNonQuery();
                        }
                        MessageBox.Show("Ürün başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadProducts();
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