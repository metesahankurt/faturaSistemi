using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FaturaKasaSistemi
{
    public partial class KasaRaporuForm : Form
    {
        public KasaRaporuForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            LoadKasaRaporu();
        }

        private void LoadKasaRaporu()
        {
            string connectionString = "server=localhost;database=faturakasa;user=root;password=199419033Mm.;";
            DateTime seciliTarih = dtpTarih.Value.Date;
            string query = "SELECT invoice_no, customer_name, invoice_date, subtotal, vat, total FROM invoices WHERE DATE(invoice_date) = @tarih";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
            {
                adapter.SelectCommand.Parameters.AddWithValue("@tarih", seciliTarih);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;

                // Sütun başlıklarını Türkçeleştir
                if (dataGridView1.Columns["invoice_no"] != null) dataGridView1.Columns["invoice_no"].HeaderText = "Fatura No";
                if (dataGridView1.Columns["customer_name"] != null) dataGridView1.Columns["customer_name"].HeaderText = "Müşteri";
                if (dataGridView1.Columns["invoice_date"] != null) dataGridView1.Columns["invoice_date"].HeaderText = "Tarih";
                if (dataGridView1.Columns["subtotal"] != null) dataGridView1.Columns["subtotal"].HeaderText = "Ara Toplam";
                if (dataGridView1.Columns["vat"] != null) dataGridView1.Columns["vat"].HeaderText = "KDV";
                if (dataGridView1.Columns["total"] != null) dataGridView1.Columns["total"].HeaderText = "Genel Toplam";

                decimal toplamSatis = 0, toplamKdv = 0, genelToplam = 0;
                foreach (DataRow row in dt.Rows)
                {
                    toplamSatis += row["subtotal"] != DBNull.Value ? Convert.ToDecimal(row["subtotal"]) : 0;
                    toplamKdv += row["vat"] != DBNull.Value ? Convert.ToDecimal(row["vat"]) : 0;
                    genelToplam += row["total"] != DBNull.Value ? Convert.ToDecimal(row["total"]) : 0;
                }
                lblToplamSatis.Text = $"Toplam Satış: {toplamSatis:C2}";
                lblToplamKDV.Text = $"Toplam KDV: {toplamKdv:C2}";
                lblGenelToplam.Text = $"Genel Toplam: {genelToplam:C2}";
            }
        }

        private void dtpTarih_ValueChanged(object sender, EventArgs e)
        {
            LoadKasaRaporu();
        }
    }
} 