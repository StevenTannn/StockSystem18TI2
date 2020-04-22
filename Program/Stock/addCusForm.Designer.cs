namespace Stock
{
    partial class addCusForm
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
            this.cusAlamat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cusName = new System.Windows.Forms.TextBox();
            this.deleteData = new System.Windows.Forms.ToolStripMenuItem();
            this.editData = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.noTelp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.namaSupplier = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.idSupplier = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cusPhone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.alamat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.process = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(191, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 24);
            this.label1.TabIndex = 40;
            this.label1.Text = "TAMBAH CUSTOMER";
            // 
            // cusAlamat
            // 
            this.cusAlamat.Location = new System.Drawing.Point(211, 100);
            this.cusAlamat.Name = "cusAlamat";
            this.cusAlamat.Size = new System.Drawing.Size(148, 20);
            this.cusAlamat.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(129, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 33;
            this.label4.Text = "Alamat :";
            // 
            // cusName
            // 
            this.cusName.Location = new System.Drawing.Point(211, 71);
            this.cusName.Name = "cusName";
            this.cusName.Size = new System.Drawing.Size(148, 20);
            this.cusName.TabIndex = 32;
            // 
            // deleteData
            // 
            this.deleteData.Name = "deleteData";
            this.deleteData.Size = new System.Drawing.Size(112, 22);
            this.deleteData.Text = "DELETE";
            this.deleteData.Click += new System.EventHandler(this.deleteData_Click);
            // 
            // editData
            // 
            this.editData.Name = "editData";
            this.editData.Size = new System.Drawing.Size(112, 22);
            this.editData.Text = "EDIT";
            this.editData.Click += new System.EventHandler(this.editData_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editData,
            this.deleteData});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(113, 48);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(74, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 16);
            this.label3.TabIndex = 31;
            this.label3.Text = "Nama Customer :";
            // 
            // noTelp
            // 
            this.noTelp.Text = "NO TELP";
            this.noTelp.Width = 121;
            // 
            // namaSupplier
            // 
            this.namaSupplier.Text = "NAMA CUSTOMER";
            this.namaSupplier.Width = 165;
            // 
            // idSupplier
            // 
            this.idSupplier.Text = "ID CUSTOMER";
            this.idSupplier.Width = 95;
            // 
            // cusPhone
            // 
            this.cusPhone.Location = new System.Drawing.Point(211, 130);
            this.cusPhone.Name = "cusPhone";
            this.cusPhone.Size = new System.Drawing.Size(148, 20);
            this.cusPhone.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(122, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 16);
            this.label6.TabIndex = 39;
            this.label6.Text = "No Telp :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(408, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 48);
            this.button1.TabIndex = 36;
            this.button1.Text = "ADD TO LIST";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.listView1.BackgroundImageTiled = true;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idSupplier,
            this.namaSupplier,
            this.alamat,
            this.noTelp});
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(25, 174);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(551, 216);
            this.listView1.TabIndex = 35;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // alamat
            // 
            this.alamat.Text = "ALAMAT";
            this.alamat.Width = 170;
            // 
            // process
            // 
            this.process.Location = new System.Drawing.Point(248, 412);
            this.process.Name = "process";
            this.process.Size = new System.Drawing.Size(101, 48);
            this.process.TabIndex = 38;
            this.process.Text = "SAVE TO DATABASE";
            this.process.UseVisualStyleBackColor = true;
            this.process.Click += new System.EventHandler(this.process_Click);
            // 
            // addCusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 472);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cusAlamat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cusName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cusPhone);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.process);
            this.Name = "addCusForm";
            this.Text = "addCusForm";
            this.Load += new System.EventHandler(this.addCusForm_Load_1);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cusAlamat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox cusName;
        private System.Windows.Forms.ToolStripMenuItem deleteData;
        private System.Windows.Forms.ToolStripMenuItem editData;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader noTelp;
        private System.Windows.Forms.ColumnHeader namaSupplier;
        private System.Windows.Forms.ColumnHeader idSupplier;
        private System.Windows.Forms.TextBox cusPhone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader alamat;
        private System.Windows.Forms.Button process;
    }
}