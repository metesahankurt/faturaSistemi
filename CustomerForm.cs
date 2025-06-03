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
        }

        private void LoadIlIlceData()
        {
            try
            {
                string basePath = AppDomain.CurrentDomain.BaseDirectory;
                string ilceJsonPath = Path.Combine(basePath, "turkiye_ilce.json");
                string ilceJson = File.ReadAllText(ilceJsonPath);
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("İl verisi yüklenirken hata oluştu: " + ex.Message);
            }
        }

        private void cmbIl_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbIlce.Items.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFirstName.Text) || string.IsNullOrEmpty(txtLastName.Text) || 
                cmbIl.SelectedItem == null || cmbIlce.SelectedItem == null || string.IsNullOrEmpty(txtAddress.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectionString = "server=localhost;database=faturakasa;user=root;password=199419033Mm.;";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"INSERT INTO customers (first_name, last_name, card_number, card_type, 
                                   city, district, address_line) 
                                   VALUES (@first, @last, '', '', @city, @district, @address)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@first", txtFirstName.Text);
                        cmd.Parameters.AddWithValue("@last", txtLastName.Text);
                        cmd.Parameters.AddWithValue("@city", cmbIl.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@district", cmbIlce.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@address", txtAddress.Text);
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
    }
} 