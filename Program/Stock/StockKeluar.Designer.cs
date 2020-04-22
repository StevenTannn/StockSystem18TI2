namespace Stock
{
    partial class StockKeluar
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
            this.label9 = new System.Windows.Forms.Label();
            this.genCus = new System.Windows.Forms.Button();
            this.process = new System.Windows.Forms.Button();
            this.genTrans = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.tgl = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.qty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.customerName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.idCustomer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.prdMerek = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.productName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.idProduct = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.date = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.totalHarga = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.prdSpecs = new System.Windows.Forms.Label();
            this.cusName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.searchCUS = new System.Windows.Forms.Button();
            this.cusInput = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.genPrd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.prdName = new System.Windows.Forms.Label();
            this.prdIdInput = new System.Windows.Forms.TextBox();
            this.prdPicture = new System.Windows.Forms.PictureBox();
            this.searchPrd = new System.Windows.Forms.Button();
            this.prdID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.prdHargaEceran = new System.Windows.Forms.Label();
            this.prdQty = new System.Windows.Forms.NumericUpDown();
            this.prdHarga = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.stok = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.prdPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prdQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prdHarga)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(73, 396);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 16);
            this.label9.TabIndex = 50;
            this.label9.Text = "TANGGAL :";
            // 
            // genCus
            // 
            this.genCus.Location = new System.Drawing.Point(211, 252);
            this.genCus.Name = "genCus";
            this.genCus.Size = new System.Drawing.Size(142, 23);
            this.genCus.TabIndex = 49;
            this.genCus.Text = "GENERATE CUSTOMER";
            this.genCus.UseVisualStyleBackColor = true;
            this.genCus.Click += new System.EventHandler(this.genCus_Click);
            // 
            // process
            // 
            this.process.Location = new System.Drawing.Point(317, 650);
            this.process.Name = "process";
            this.process.Size = new System.Drawing.Size(174, 23);
            this.process.TabIndex = 48;
            this.process.Text = "PROCESS TO DATABASE";
            this.process.UseVisualStyleBackColor = true;
            this.process.Click += new System.EventHandler(this.process_Click);
            // 
            // genTrans
            // 
            this.genTrans.Location = new System.Drawing.Point(79, 441);
            this.genTrans.Name = "genTrans";
            this.genTrans.Size = new System.Drawing.Size(651, 23);
            this.genTrans.TabIndex = 47;
            this.genTrans.Text = "GENERATE";
            this.genTrans.UseVisualStyleBackColor = true;
            this.genTrans.Click += new System.EventHandler(this.genTrans_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(58, 361);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 16);
            this.label10.TabIndex = 45;
            this.label10.Text = "KUANTITAS  :";
            // 
            // tgl
            // 
            this.tgl.Text = "TANGGAL TRANSAKSI";
            this.tgl.Width = 114;
            // 
            // qty
            // 
            this.qty.Text = "QTY";
            this.qty.Width = 43;
            // 
            // customerName
            // 
            this.customerName.Text = "NAMA CUSTOMER";
            this.customerName.Width = 110;
            // 
            // idCustomer
            // 
            this.idCustomer.Text = "CUSTOMER ID";
            this.idCustomer.Width = 92;
            // 
            // prdMerek
            // 
            this.prdMerek.Text = "MEREK";
            this.prdMerek.Width = 87;
            // 
            // productName
            // 
            this.productName.Text = "PRODUCT NAME";
            this.productName.Width = 121;
            // 
            // idProduct
            // 
            this.idProduct.Text = "PRODUCT ID";
            this.idProduct.Width = 90;
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(165, 395);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(91, 20);
            this.date.TabIndex = 51;
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
            this.listView1.Location = new System.Drawing.Point(12, 483);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(800, 150);
            this.listView1.TabIndex = 44;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // totalHarga
            // 
            this.totalHarga.Text = "TOTAL HARGA";
            this.totalHarga.Width = 102;
            // 
            // prdSpecs
            // 
            this.prdSpecs.AutoSize = true;
            this.prdSpecs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prdSpecs.Location = new System.Drawing.Point(581, 110);
            this.prdSpecs.Name = "prdSpecs";
            this.prdSpecs.Size = new System.Drawing.Size(120, 16);
            this.prdSpecs.TabIndex = 43;
            this.prdSpecs.Text = "Spesifikasi Produk";
            // 
            // cusName
            // 
            this.cusName.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cusName.Enabled = false;
            this.cusName.Location = new System.Drawing.Point(165, 287);
            this.cusName.Name = "cusName";
            this.cusName.Size = new System.Drawing.Size(190, 20);
            this.cusName.TabIndex = 42;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 287);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 16);
            this.label8.TabIndex = 41;
            this.label8.Text = "NAMA CUSTOMER  :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(282, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 16);
            this.label7.TabIndex = 40;
            this.label7.Text = "or";
            // 
            // searchCUS
            // 
            this.searchCUS.Location = new System.Drawing.Point(317, 201);
            this.searchCUS.Name = "searchCUS";
            this.searchCUS.Size = new System.Drawing.Size(134, 23);
            this.searchCUS.TabIndex = 39;
            this.searchCUS.Text = "SEARCH CUSTOMER";
            this.searchCUS.UseVisualStyleBackColor = true;
            this.searchCUS.Click += new System.EventHandler(this.searchCUS_Click);
            // 
            // cusInput
            // 
            this.cusInput.Location = new System.Drawing.Point(165, 201);
            this.cusInput.Name = "cusInput";
            this.cusInput.Size = new System.Drawing.Size(100, 20);
            this.cusInput.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(41, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 16);
            this.label6.TabIndex = 37;
            this.label6.Text = "ID CUSTOMER  :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(51, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 36;
            this.label5.Text = "TRANKSASI";
            // 
            // genPrd
            // 
            this.genPrd.Location = new System.Drawing.Point(211, 128);
            this.genPrd.Name = "genPrd";
            this.genPrd.Size = new System.Drawing.Size(142, 23);
            this.genPrd.TabIndex = 35;
            this.genPrd.Text = "GENERATE PRODUK";
            this.genPrd.UseVisualStyleBackColor = true;
            this.genPrd.Click += new System.EventHandler(this.genPrd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(282, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 16);
            this.label4.TabIndex = 34;
            this.label4.Text = "or";
            // 
            // prdName
            // 
            this.prdName.AutoSize = true;
            this.prdName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prdName.Location = new System.Drawing.Point(581, 85);
            this.prdName.Name = "prdName";
            this.prdName.Size = new System.Drawing.Size(91, 16);
            this.prdName.TabIndex = 33;
            this.prdName.Text = "Nama Produk";
            // 
            // prdIdInput
            // 
            this.prdIdInput.Location = new System.Drawing.Point(165, 84);
            this.prdIdInput.Name = "prdIdInput";
            this.prdIdInput.Size = new System.Drawing.Size(100, 20);
            this.prdIdInput.TabIndex = 32;
            // 
            // prdPicture
            // 
            this.prdPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prdPicture.Location = new System.Drawing.Point(488, 54);
            this.prdPicture.Name = "prdPicture";
            this.prdPicture.Size = new System.Drawing.Size(87, 115);
            this.prdPicture.TabIndex = 31;
            this.prdPicture.TabStop = false;
            // 
            // searchPrd
            // 
            this.searchPrd.Location = new System.Drawing.Point(317, 82);
            this.searchPrd.Name = "searchPrd";
            this.searchPrd.Size = new System.Drawing.Size(134, 23);
            this.searchPrd.TabIndex = 30;
            this.searchPrd.Text = "SEARCH PRODUCT";
            this.searchPrd.UseVisualStyleBackColor = true;
            this.searchPrd.Click += new System.EventHandler(this.searchPrd_Click);
            // 
            // prdID
            // 
            this.prdID.AutoSize = true;
            this.prdID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prdID.Location = new System.Drawing.Point(581, 58);
            this.prdID.Name = "prdID";
            this.prdID.Size = new System.Drawing.Size(67, 16);
            this.prdID.TabIndex = 29;
            this.prdID.Text = "ID Produk";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 28;
            this.label3.Text = "ID PRODUK :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "PRODUK";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(297, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 24);
            this.label1.TabIndex = 26;
            this.label1.Text = "BARANG KELUAR";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // prdHargaEceran
            // 
            this.prdHargaEceran.AutoSize = true;
            this.prdHargaEceran.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prdHargaEceran.Location = new System.Drawing.Point(581, 135);
            this.prdHargaEceran.Name = "prdHargaEceran";
            this.prdHargaEceran.Size = new System.Drawing.Size(92, 16);
            this.prdHargaEceran.TabIndex = 52;
            this.prdHargaEceran.Text = "Harga Eceran";
            // 
            // prdQty
            // 
            this.prdQty.Location = new System.Drawing.Point(166, 357);
            this.prdQty.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.prdQty.Name = "prdQty";
            this.prdQty.Size = new System.Drawing.Size(57, 20);
            this.prdQty.TabIndex = 53;
            // 
            // prdHarga
            // 
            this.prdHarga.Location = new System.Drawing.Point(166, 325);
            this.prdHarga.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.prdHarga.Name = "prdHarga";
            this.prdHarga.Size = new System.Drawing.Size(99, 20);
            this.prdHarga.TabIndex = 54;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(53, 325);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 16);
            this.label11.TabIndex = 55;
            this.label11.Text = "HARGA JUAL :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(485, 184);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 16);
            this.label12.TabIndex = 56;
            this.label12.Text = "STOK : ";
            // 
            // stok
            // 
            this.stok.Location = new System.Drawing.Point(544, 183);
            this.stok.Name = "stok";
            this.stok.ReadOnly = true;
            this.stok.Size = new System.Drawing.Size(55, 20);
            this.stok.TabIndex = 57;
            // 
            // StockKeluar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 702);
            this.Controls.Add(this.stok);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.prdHarga);
            this.Controls.Add(this.date);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.prdQty);
            this.Controls.Add(this.prdHargaEceran);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.genCus);
            this.Controls.Add(this.process);
            this.Controls.Add(this.genTrans);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.prdSpecs);
            this.Controls.Add(this.cusName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.searchCUS);
            this.Controls.Add(this.cusInput);
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
            this.Name = "StockKeluar";
            this.Text = "STOCK KELUAR";
            this.Load += new System.EventHandler(this.StockKeluar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.prdPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prdQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prdHarga)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button genCus;
        private System.Windows.Forms.Button process;
        private System.Windows.Forms.Button genTrans;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ColumnHeader tgl;
        private System.Windows.Forms.ColumnHeader qty;
        private System.Windows.Forms.ColumnHeader customerName;
        private System.Windows.Forms.ColumnHeader idCustomer;
        private System.Windows.Forms.ColumnHeader prdMerek;
        private System.Windows.Forms.ColumnHeader productName;
        private System.Windows.Forms.ColumnHeader idProduct;
        private System.Windows.Forms.TextBox date;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label prdSpecs;
        private System.Windows.Forms.TextBox cusName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button searchCUS;
        private System.Windows.Forms.TextBox cusInput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button genPrd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label prdName;
        private System.Windows.Forms.TextBox prdIdInput;
        private System.Windows.Forms.PictureBox prdPicture;
        private System.Windows.Forms.Button searchPrd;
        private System.Windows.Forms.Label prdID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label prdHargaEceran;
        private System.Windows.Forms.ColumnHeader totalHarga;
        private System.Windows.Forms.NumericUpDown prdQty;
        private System.Windows.Forms.NumericUpDown prdHarga;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox stok;
    }
}