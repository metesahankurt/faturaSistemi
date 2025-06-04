using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace FaturaKasaSistemi
{
    public partial class CustomerForm : Form
    {
        private Dictionary<string, List<string>> ilIlceDict = new Dictionary<string, List<string>>();

        public CustomerForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            LoadIlIlceData();
            LoadIller();
            cmbIl.SelectedIndexChanged += cmbIl_SelectedIndexChanged;
        }

        private void LoadIlIlceData()
        {
            try
            {
                string basePath = AppDomain.CurrentDomain.BaseDirectory;
                string ilceJsonPath = Path.Combine(basePath, "turkiye_ilce.json");
                string ilceJson = File.ReadAllText(ilceJsonPath);
                ilIlceDict = JsonConvert.DeserializeObject<Dictionary<string, List<string>>>(ilceJson);
            }
            catch (Exception ex)
            {
                MessageBox.Show("İl-İlçe verisi yüklenirken hata oluştu: " + ex.Message);
            }
        }

        private void LoadIller()
        {
            try
            {
                string basePath = AppDomain.CurrentDomain.BaseDirectory;
                string ilJsonPath = Path.Combine(basePath, "turkiye_il.json");
                string ilJson = File.ReadAllText(ilJsonPath);
                var iller = JsonConvert.DeserializeObject<List<IlModel>>(ilJson);
                cmbIl.DataSource = iller.Select(x => x.sehir_title).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("İl verisi yüklenirken hata oluştu: " + ex.Message);
            }
        }

        private void cmbIl_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbIlce.Items.Clear();
            if (cmbIl.SelectedItem != null && ilIlceDict != null)
            {
                string seciliIl = cmbIl.SelectedItem.ToString();
                if (ilIlceDict.ContainsKey(seciliIl))
                {
                    cmbIlce.Items.AddRange(ilIlceDict[seciliIl].ToArray());
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFirstName.Text) || string.IsNullOrEmpty(txtLastName.Text) || 
                cmbIl.SelectedItem == null || cmbIlce.SelectedItem == null || string.IsNullOrEmpty(txtAddress.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Customer yeniMusteri = new Customer
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                City = cmbIl.SelectedItem.ToString(),
                District = cmbIlce.SelectedItem.ToString(),
                Address = txtAddress.Text,
                CreatedAt = DateTime.Now
            };

            string connectionString = "server=localhost;database=faturakasa;user=root;password=199419033Mm.;";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"INSERT INTO customers (first_name, last_name, card_number, card_type, city, district, address_line, created_at) 
                               VALUES (@first, @last, '', '', @city, @district, @address, @created_at)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@first", yeniMusteri.FirstName);
                        cmd.Parameters.AddWithValue("@last", yeniMusteri.LastName);
                        cmd.Parameters.AddWithValue("@city", yeniMusteri.City);
                        cmd.Parameters.AddWithValue("@district", yeniMusteri.District);
                        cmd.Parameters.AddWithValue("@address", yeniMusteri.Address);
                        cmd.Parameters.AddWithValue("@created_at", yeniMusteri.CreatedAt);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Müşteri başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veritabanı hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public class IlModel
        {
            public string sehir_key { get; set; }
            public string sehir_title { get; set; }
        }
    }
} 