using MySql.Data.MySqlClient;

public void UpdateBugunkuSatis()
{
    if (InvokeRequired)
    {
        Invoke(new Action(UpdateBugunkuSatis));
        return;
    }
    string connStr = "server=localhost;database=faturakasa;user=root;password=199419033Mm.;";
    using (var conn = new MySqlConnection(connStr))
    {
        conn.Open();
        using (var cmd = new MySqlCommand("SELECT IFNULL(SUM(total),0) FROM invoices WHERE DATE(invoice_date) = CURDATE()", conn))
        {
            var satis = cmd.ExecuteScalar();
            decimal satisDecimal = 0;
            decimal.TryParse(satis.ToString(), out satisDecimal);
            lblCounterSatis.Text = (Math.Floor(satisDecimal)).ToString("0") + " ₺";
            lblCounterSatis.Refresh();
        }
    }
}

private void btnSatisYenile_Click(object sender, EventArgs e)
{
    UpdateBugunkuSatis();
} 