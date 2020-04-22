namespace Stock
{
    partial class Form3
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.idProduk = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.namaProduk = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.merekProduk = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RAM = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Memory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Harga = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnLanjut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.listView1.BackgroundImageTiled = true;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idProduk,
            this.namaProduk,
            this.merekProduk,
            this.RAM,
            this.Memory,
            this.Harga});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(38, 103);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(611, 264);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // idProduk
            // 
            this.idProduk.Text = "ID PRODUK";
            this.idProduk.Width = 64;
            // 
            // namaProduk
            // 
            this.namaProduk.Text = "NAMA PRODUK";
            this.namaProduk.Width = 122;
            // 
            // merekProduk
            // 
            this.merekProduk.Text = "MEREK PRODUK";
            this.merekProduk.Width = 133;
            // 
            // RAM
            // 
            this.RAM.Text = "RAM";
            this.RAM.Width = 55;
            // 
            // Memory
            // 
            this.Memory.Text = "INTERNAL STORAGE";
            this.Memory.Width = 124;
            // 
            // Harga
            // 
            this.Harga.Text = "HARGA";
            this.Harga.Width = 89;
            // 
            // btnLanjut
            // 
            this.btnLanjut.Location = new System.Drawing.Point(251, 388);
            this.btnLanjut.Name = "btnLanjut";
            this.btnLanjut.Size = new System.Drawing.Size(165, 67);
            this.btnLanjut.TabIndex = 1;
            this.btnLanjut.Text = "Lanjut";
            this.btnLanjut.UseVisualStyleBackColor = true;
            this.btnLanjut.Click += new System.EventHandler(this.btnLanjut_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(257, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 24);
            this.label1.TabIndex = 26;
            this.label1.Text = "CARI PRODUK";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 486);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLanjut);
            this.Controls.Add(this.listView1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader idProduk;
        private System.Windows.Forms.ColumnHeader namaProduk;
        private System.Windows.Forms.ColumnHeader merekProduk;
        private System.Windows.Forms.ColumnHeader RAM;
        private System.Windows.Forms.ColumnHeader Memory;
        private System.Windows.Forms.Button btnLanjut;
        private System.Windows.Forms.ColumnHeader Harga;
        private System.Windows.Forms.Label label1;
    }
}