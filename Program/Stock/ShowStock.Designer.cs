namespace Stock
{
    partial class ShowStock
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
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nama = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.merek = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ram = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.inter = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.harga = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stock = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.listView1.BackgroundImageTiled = true;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.nama,
            this.merek,
            this.ram,
            this.inter,
            this.harga,
            this.stock});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(25, 98);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(670, 296);
            this.listView1.TabIndex = 47;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "ID PRODUK";
            this.id.Width = 82;
            // 
            // nama
            // 
            this.nama.Text = "NAMA PRODUK";
            this.nama.Width = 119;
            // 
            // merek
            // 
            this.merek.Text = "MEREK";
            this.merek.Width = 92;
            // 
            // ram
            // 
            this.ram.Text = "RAM";
            this.ram.Width = 74;
            // 
            // inter
            // 
            this.inter.Text = "INTERNAL STORAGE";
            this.inter.Width = 126;
            // 
            // harga
            // 
            this.harga.Text = "HARGA";
            this.harga.Width = 91;
            // 
            // stock
            // 
            this.stock.Text = "STOK";
            this.stock.Width = 77;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(310, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 24);
            this.label1.TabIndex = 48;
            this.label1.Text = "STOK";
            // 
            // ShowStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 417);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Name = "ShowStock";
            this.Text = "ShowStock";
            this.Load += new System.EventHandler(this.ShowStock_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader nama;
        private System.Windows.Forms.ColumnHeader merek;
        private System.Windows.Forms.ColumnHeader ram;
        private System.Windows.Forms.ColumnHeader inter;
        private System.Windows.Forms.ColumnHeader harga;
        private System.Windows.Forms.ColumnHeader stock;
        private System.Windows.Forms.Label label1;
    }
}