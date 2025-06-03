namespace FaturaKasaSistemi
{
    partial class InvoiceForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblProduct = new Label();
            cmbProducts = new ComboBox();
            lblQuantity = new Label();
            numQuantity = new NumericUpDown();
            btnAddItem = new Button();
            dataGridView1 = new DataGridView();
            lblSubtotal = new Label();
            lblVat = new Label();
            lblTotal = new Label();
            lblSelectCustomer = new Label();
            cmbCustomers = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblProduct
            // 
            lblProduct.AutoSize = true;
            lblProduct.Location = new Point(20, 60);
            lblProduct.Name = "lblProduct";
            lblProduct.Size = new Size(36, 15);
            lblProduct.TabIndex = 2;
            lblProduct.Text = "Ürün:";
            // 
            // cmbProducts
            // 
            cmbProducts.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProducts.Location = new Point(110, 57);
            cmbProducts.Name = "cmbProducts";
            cmbProducts.Size = new Size(200, 23);
            cmbProducts.TabIndex = 3;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(20, 100);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(44, 15);
            lblQuantity.TabIndex = 4;
            lblQuantity.Text = "Miktar:";
            // 
            // numQuantity
            // 
            numQuantity.Location = new Point(110, 97);
            numQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(200, 23);
            numQuantity.TabIndex = 5;
            numQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnAddItem
            // 
            btnAddItem.Location = new Point(110, 135);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(200, 30);
            btnAddItem.TabIndex = 6;
            btnAddItem.Text = "Faturaya Ekle";
            btnAddItem.UseVisualStyleBackColor = true;
            btnAddItem.Click += btnAddItem_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(20, 180);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(500, 200);
            dataGridView1.TabIndex = 7;
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.Location = new Point(20, 400);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(80, 15);
            lblSubtotal.TabIndex = 8;
            lblSubtotal.Text = "Ara Toplam: 0";
            // 
            // lblVat
            // 
            lblVat.AutoSize = true;
            lblVat.Location = new Point(200, 400);
            lblVat.Name = "lblVat";
            lblVat.Size = new Size(41, 15);
            lblVat.TabIndex = 9;
            lblVat.Text = "KDV: 0";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(350, 400);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(92, 15);
            lblTotal.TabIndex = 10;
            lblTotal.Text = "Genel Toplam: 0";
            // 
            // lblSelectCustomer
            // 
            lblSelectCustomer.AutoSize = true;
            lblSelectCustomer.Location = new Point(20, 15);
            lblSelectCustomer.Name = "lblSelectCustomer";
            lblSelectCustomer.Size = new Size(71, 15);
            lblSelectCustomer.TabIndex = 0;
            lblSelectCustomer.Text = "Müşteri Seç:";
            // 
            // cmbCustomers
            // 
            cmbCustomers.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCustomers.Location = new Point(110, 12);
            cmbCustomers.Name = "cmbCustomers";
            cmbCustomers.Size = new Size(200, 23);
            cmbCustomers.TabIndex = 1;
            // 
            // InvoiceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(550, 450);
            Controls.Add(lblTotal);
            Controls.Add(lblVat);
            Controls.Add(lblSubtotal);
            Controls.Add(dataGridView1);
            Controls.Add(btnAddItem);
            Controls.Add(numQuantity);
            Controls.Add(lblQuantity);
            Controls.Add(cmbProducts);
            Controls.Add(lblProduct);
            Controls.Add(lblSelectCustomer);
            Controls.Add(cmbCustomers);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "InvoiceForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fatura Oluştur";
            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.ComboBox cmbProducts;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblVat;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblSelectCustomer;
        private System.Windows.Forms.ComboBox cmbCustomers;
    }
} 