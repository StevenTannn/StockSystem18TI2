namespace Stock
{
    partial class EditPrdForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nama = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.merek = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ram = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.inter = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.harga = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editData = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteData = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(258, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 24);
            this.label1.TabIndex = 16;
            this.label1.Text = "EDIT PRODUK";
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
            this.harga});
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(50, 85);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(563, 216);
            this.listView1.TabIndex = 46;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "ID";
            this.id.Width = 36;
            // 
            // nama
            // 
            this.nama.Text = "NAMA PRODUK";
            this.nama.Width = 119;
            // 
            // merek
            // 
            this.merek.Text = "MEREK";
            this.merek.Width = 119;
            // 
            // ram
            // 
            this.ram.Text = "RAM";
            this.ram.Width = 74;
            // 
            // inter
            // 
            this.inter.Text = "INTERNAL";
            this.inter.Width = 75;
            // 
            // harga
            // 
            this.harga.Text = "HARGA";
            this.harga.Width = 138;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editData,
            this.deleteData});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(113, 48);
            // 
            // editData
            // 
            this.editData.Name = "editData";
            this.editData.Size = new System.Drawing.Size(112, 22);
            this.editData.Text = "EDIT ";
            this.editData.Click += new System.EventHandler(this.editData_Click);
            // 
            // deleteData
            // 
            this.deleteData.Name = "deleteData";
            this.deleteData.Size = new System.Drawing.Size(112, 22);
            this.deleteData.Text = "DELETE";
            this.deleteData.Click += new System.EventHandler(this.deleteData_Click);
            // 
            // EditPrdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 337);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Name = "EditPrdForm";
            this.Text = "EditPrdForm";
            this.Load += new System.EventHandler(this.EditPrdForm_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader nama;
        private System.Windows.Forms.ColumnHeader merek;
        private System.Windows.Forms.ColumnHeader ram;
        private System.Windows.Forms.ColumnHeader inter;
        private System.Windows.Forms.ColumnHeader harga;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editData;
        private System.Windows.Forms.ToolStripMenuItem deleteData;
    }
}