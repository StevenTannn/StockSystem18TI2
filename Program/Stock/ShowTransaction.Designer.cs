namespace Stock
{
    partial class ShowTransaction
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listViewSM = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.productName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.prdMerek = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.supplierName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.qty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tgl = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.totalHarga = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewSK = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listViewSM
            // 
            this.listViewSM.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.productName,
            this.prdMerek,
            this.supplierName,
            this.qty,
            this.tgl,
            this.totalHarga});
            this.listViewSM.HideSelection = false;
            this.listViewSM.Location = new System.Drawing.Point(25, 124);
            this.listViewSM.Name = "listViewSM";
            this.listViewSM.Size = new System.Drawing.Size(757, 124);
            this.listViewSM.TabIndex = 45;
            this.listViewSM.UseCompatibleStateImageBehavior = false;
            this.listViewSM.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID TRANKSASI";
            this.ID.Width = 90;
            // 
            // productName
            // 
            this.productName.Text = "NAMA PRODUK";
            this.productName.Width = 121;
            // 
            // prdMerek
            // 
            this.prdMerek.Text = "MEREK";
            this.prdMerek.Width = 87;
            // 
            // supplierName
            // 
            this.supplierName.Text = "NAMA SUPPLIER";
            this.supplierName.Width = 110;
            // 
            // qty
            // 
            this.qty.Text = "QTY";
            this.qty.Width = 77;
            // 
            // tgl
            // 
            this.tgl.Text = "TANGGAL TRANSAKSI";
            this.tgl.Width = 133;
            // 
            // totalHarga
            // 
            this.totalHarga.Text = "TOTAL HARGA";
            this.totalHarga.Width = 132;
            // 
            // listViewSK
            // 
            this.listViewSK.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listViewSK.HideSelection = false;
            this.listViewSK.Location = new System.Drawing.Point(25, 317);
            this.listViewSK.Name = "listViewSK";
            this.listViewSK.Size = new System.Drawing.Size(757, 124);
            this.listViewSK.TabIndex = 46;
            this.listViewSK.UseCompatibleStateImageBehavior = false;
            this.listViewSK.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID TRANKSASI";
            this.columnHeader1.Width = 90;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "NAMA PRODUK";
            this.columnHeader2.Width = 121;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "MEREK";
            this.columnHeader3.Width = 87;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "NAMA CUSTOMER";
            this.columnHeader4.Width = 110;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "QTY";
            this.columnHeader5.Width = 77;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "TANGGAL TRANSAKSI";
            this.columnHeader6.Width = 133;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "TOTAL HARGA";
            this.columnHeader7.Width = 132;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 24);
            this.label1.TabIndex = 47;
            this.label1.Text = "STOK MASUK";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 24);
            this.label2.TabIndex = 48;
            this.label2.Text = "STOK KELUAR";
            // 
            // ShowTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 503);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewSK);
            this.Controls.Add(this.listViewSM);
            this.Name = "ShowTransaction";
            this.Text = "ShowTransaction";
            this.Load += new System.EventHandler(this.ShowTransaction_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewSM;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader productName;
        private System.Windows.Forms.ColumnHeader prdMerek;
        private System.Windows.Forms.ColumnHeader supplierName;
        private System.Windows.Forms.ColumnHeader qty;
        private System.Windows.Forms.ColumnHeader tgl;
        private System.Windows.Forms.ColumnHeader totalHarga;
        private System.Windows.Forms.ListView listViewSK;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}