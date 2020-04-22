namespace Stock
{
    partial class StockMasuk
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.prdID = new System.Windows.Forms.Label();
            this.searchPrd = new System.Windows.Forms.Button();
            this.prdPicture = new System.Windows.Forms.PictureBox();
            this.prdIdInput = new System.Windows.Forms.TextBox();
            this.prdName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.genPrd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.splInput = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.searchSPL = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.splName = new System.Windows.Forms.TextBox();
            this.prdSpecs = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.genTrans = new System.Windows.Forms.Button();
            this.process = new System.Windows.Forms.Button();
            this.genSpl = new System.Windows.Forms.Button();
            this.date = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.prdHargaEceran = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.idProduct = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.productName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.prdMerek = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.idCustomer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.customerName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.qty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tgl = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.totalHarga = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.prdQty = new System.Windows.Forms.NumericUpDown();
            this.prdHarga = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.prdPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prdQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prdHarga)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(313, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "BARANG MASUK";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "PRODUK";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(84, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "ID PRODUK :";
            // 
            // prdID
            // 
            this.prdID.AutoSize = true;
            this.prdID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prdID.Location = new System.Drawing.Point(595, 70);
            this.prdID.Name = "prdID";
            this.prdID.Size = new System.Drawing.Size(67, 16);
            this.prdID.TabIndex = 3;
            this.prdID.Text = "ID Produk";
            // 
            // searchPrd
            // 
            this.searchPrd.Location = new System.Drawing.Point(351, 88);
            this.searchPrd.Name = "searchPrd";
            this.searchPrd.Size = new System.Drawing.Size(134, 23);
            this.searchPrd.TabIndex = 4;
            this.searchPrd.Text = "SEARCH PRODUCT";
            this.searchPrd.UseVisualStyleBackColor = true;
            this.searchPrd.Click += new System.EventHandler(this.searchPrd_Click);
            // 
            // prdPicture
            // 
            this.prdPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prdPicture.Location = new System.Drawing.Point(502, 51);
            this.prdPicture.Name = "prdPicture";
            this.prdPicture.Size = new System.Drawing.Size(87, 115);
            this.prdPicture.TabIndex = 5;
            this.prdPicture.TabStop = false;
            // 
            // prdIdInput
            // 
            this.prdIdInput.Location = new System.Drawing.Point(177, 90);
            this.prdIdInput.Name = "prdIdInput";
            this.prdIdInput.Size = new System.Drawing.Size(100, 20);
            this.prdIdInput.TabIndex = 6;
            // 
            // prdName
            // 
            this.prdName.AutoSize = true;
            this.prdName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prdName.Location = new System.Drawing.Point(595, 94);
            this.prdName.Name = "prdName";
            this.prdName.Size = new System.Drawing.Size(91, 16);
            this.prdName.TabIndex = 7;
            this.prdName.Text = "Nama Produk";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(307, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "or";
            // 
            // genPrd
            // 
            this.genPrd.Location = new System.Drawing.Point(196, 130);
            this.genPrd.Name = "genPrd";
            this.genPrd.Size = new System.Drawing.Size(215, 23);
            this.genPrd.TabIndex = 9;
            this.genPrd.Text = "GENERATE PRODUK";
            this.genPrd.UseVisualStyleBackColor = true;
            this.genPrd.Click += new System.EventHandler(this.genPrd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(73, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "TRANKSASI";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(74, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "ID SUPPLIER :";
            // 
            // splInput
            // 
            this.splInput.Location = new System.Drawing.Point(177, 223);
            this.splInput.Name = "splInput";
            this.splInput.Size = new System.Drawing.Size(100, 20);
            this.splInput.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(307, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "or";
            // 
            // searchSPL
            // 
            this.searchSPL.Location = new System.Drawing.Point(351, 221);
            this.searchSPL.Name = "searchSPL";
            this.searchSPL.Size = new System.Drawing.Size(134, 23);
            this.searchSPL.TabIndex = 13;
            this.searchSPL.Text = "SEARCH SUPPLIER";
            this.searchSPL.UseVisualStyleBackColor = true;
            this.searchSPL.Click += new System.EventHandler(this.searchSPL_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(45, 304);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "NAMA SUPPLIER  :";
            // 
            // splName
            // 
            this.splName.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.splName.Enabled = false;
            this.splName.Location = new System.Drawing.Point(177, 303);
            this.splName.Name = "splName";
            this.splName.Size = new System.Drawing.Size(190, 20);
            this.splName.TabIndex = 16;
            // 
            // prdSpecs
            // 
            this.prdSpecs.AutoSize = true;
            this.prdSpecs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prdSpecs.Location = new System.Drawing.Point(595, 120);
            this.prdSpecs.Name = "prdSpecs";
            this.prdSpecs.Size = new System.Drawing.Size(120, 16);
            this.prdSpecs.TabIndex = 17;
            this.prdSpecs.Text = "Spesifikasi Produk";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(80, 377);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 16);
            this.label10.TabIndex = 19;
            this.label10.Text = "KUANTITAS :";
            // 
            // genTrans
            // 
            this.genTrans.Location = new System.Drawing.Point(48, 438);
            this.genTrans.Name = "genTrans";
            this.genTrans.Size = new System.Drawing.Size(730, 23);
            this.genTrans.TabIndex = 21;
            this.genTrans.Text = "GENERATE";
            this.genTrans.UseVisualStyleBackColor = true;
            this.genTrans.Click += new System.EventHandler(this.genTrans_Click);
            // 
            // process
            // 
            this.process.Location = new System.Drawing.Point(311, 638);
            this.process.Name = "process";
            this.process.Size = new System.Drawing.Size(174, 23);
            this.process.TabIndex = 22;
            this.process.Text = "PROCESS TO DATABASE";
            this.process.UseVisualStyleBackColor = true;
            this.process.Click += new System.EventHandler(this.process_Click);
            // 
            // genSpl
            // 
            this.genSpl.Location = new System.Drawing.Point(196, 263);
            this.genSpl.Name = "genSpl";
            this.genSpl.Size = new System.Drawing.Size(215, 23);
            this.genSpl.TabIndex = 23;
            this.genSpl.Text = "GENERATE SUPPLIER";
            this.genSpl.UseVisualStyleBackColor = true;
            this.genSpl.Click += new System.EventHandler(this.genSpl_Click);
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(177, 406);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(91, 20);
            this.date.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(92, 407);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 16);
            this.label9.TabIndex = 24;
            this.label9.Text = "TANGGAL :";
            // 
            // prdHargaEceran
            // 
            this.prdHargaEceran.AutoSize = true;
            this.prdHargaEceran.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prdHargaEceran.Location = new System.Drawing.Point(595, 150);
            this.prdHargaEceran.Name = "prdHargaEceran";
            this.prdHargaEceran.Size = new System.Drawing.Size(92, 16);
            this.prdHargaEceran.TabIndex = 53;
            this.prdHargaEceran.Text = "Harga Produk";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idProduct,
            this.productName,
            this.prdMerek,
            this.idCustomer,
            this.customerName,
            this.qty,
            this.tgl,
            this.totalHarga});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(17, 488);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(786, 124);
            this.listView1.TabIndex = 54;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // idProduct
            // 
            this.idProduct.Text = "ID PRODUK";
            this.idProduct.Width = 90;
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
            // idCustomer
            // 
            this.idCustomer.Text = "ID SUPPLIER";
            this.idCustomer.Width = 92;
            // 
            // customerName
            // 
            this.customerName.Text = "NAMA SUPPLIER";
            this.customerName.Width = 110;
            // 
            // qty
            // 
            this.qty.Text = "QTY";
            this.qty.Width = 43;
            // 
            // tgl
            // 
            this.tgl.Text = "TANGGAL TRANSAKSI";
            this.tgl.Width = 134;
            // 
            // totalHarga
            // 
            this.totalHarga.Text = "TOTAL HARGA";
            this.totalHarga.Width = 102;
            // 
            // prdQty
            // 
            this.prdQty.Location = new System.Drawing.Point(177, 373);
            this.prdQty.Name = "prdQty";
            this.prdQty.Size = new System.Drawing.Size(57, 20);
            this.prdQty.TabIndex = 55;
            // 
            // prdHarga
            // 
            this.prdHarga.Location = new System.Drawing.Point(177, 342);
            this.prdHarga.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.prdHarga.Name = "prdHarga";
            this.prdHarga.Size = new System.Drawing.Size(99, 20);
            this.prdHarga.TabIndex = 56;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(74, 342);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 16);
            this.label11.TabIndex = 57;
            this.label11.Text = "HARGA BELI :";
            // 
            // StockMasuk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 700);
            this.Controls.Add(this.prdHarga);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.prdQty);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.prdHargaEceran);
            this.Controls.Add(this.date);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.genSpl);
            this.Controls.Add(this.process);
            this.Controls.Add(this.genTrans);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.prdSpecs);
            this.Controls.Add(this.splName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.searchSPL);
            this.Controls.Add(this.splInput);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.genPrd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.prdName);
            this.Controls.Add(this.prdIdInput);
            this.Controls.Add(this.prdPicture);
            this.Controls.Add(this.searchPrd);
            this.Controls.Add(this.prdID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "StockMasuk";
            this.Text = "STOCK MASUK";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.prdPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prdQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prdHarga)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label prdID;
        private System.Windows.Forms.Button searchPrd;
        private System.Windows.Forms.PictureBox prdPicture;
        private System.Windows.Forms.TextBox prdIdInput;
        private System.Windows.Forms.Label prdName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button genPrd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox splInput;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button searchSPL;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox splName;
        private System.Windows.Forms.Label prdSpecs;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button genTrans;
        private System.Windows.Forms.Button process;
        private System.Windows.Forms.Button genSpl;
        private System.Windows.Forms.TextBox date;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label prdHargaEceran;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader idProduct;
        private System.Windows.Forms.ColumnHeader productName;
        private System.Windows.Forms.ColumnHeader prdMerek;
        private System.Windows.Forms.ColumnHeader idCustomer;
        private System.Windows.Forms.ColumnHeader customerName;
        private System.Windows.Forms.ColumnHeader qty;
        private System.Windows.Forms.ColumnHeader tgl;
        private System.Windows.Forms.ColumnHeader totalHarga;
        private System.Windows.Forms.NumericUpDown prdQty;
        private System.Windows.Forms.NumericUpDown prdHarga;
        private System.Windows.Forms.Label label11;
    }
}