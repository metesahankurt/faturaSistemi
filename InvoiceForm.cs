MessageBox.Show($"Fatura başarıyla kaydedildi. Fatura No: {invoiceNo}");
foreach (Form frm in Application.OpenForms)
{
    if (frm is Form1 mainForm)
    {
        mainForm.UpdateBugunkuSatis();
        break;
    }
} 