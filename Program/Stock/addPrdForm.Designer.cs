namespace Stock
{
    partial class addPrdForm
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
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nama = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.merek = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ram = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.inter = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.harga = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteData = new System.Windows.Forms.ToolStripMenuItem();
            this.process = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.prdMerek = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.prdName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.prdImg = new System.Windows.Forms.PictureBox();
            this.browseImg = new System.Windows.Forms.Button();
            this.browseMerek = new System.Windows.Forms.Button();
            this.prdPrice = new System.Windows.Forms.NumericUpDown();
            this.prdRam = new System.Windows.Forms.NumericUpDown();
            this.prdInternal = new System.Windows.Forms.NumericUpDown();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prdImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prdPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prdRam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prdInternal)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(97, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 49;
            this.label6.Text = "RAM :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(371, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 31);
            this.button1.TabIndex = 46;
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
            this.id,
            this.nama,
            this.merek,
            this.ram,
            this.inter,
            this.harga});
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(36, 213);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(563, 216);
            this.listView1.TabIndex = 45;
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
            this.merek.Text = "ID MEREK";
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
            this.deleteData});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(113, 26);
            // 
            // deleteData
            // 
            this.deleteData.Name = "deleteData";
            this.deleteData.Size = new System.Drawing.Size(112, 22);
            this.deleteData.Text = "DELETE";
            this.deleteData.Click += new System.EventHandler(this.deleteData_Click);
            // 
            // process
            // 
            this.process.Location = new System.Drawing.Point(245, 453);
            this.process.Name = "process";
            this.process.Size = new System.Drawing.Size(101, 48);
            this.process.TabIndex = 48;
            this.process.Text = "SAVE TO DATABASE";
            this.process.UseVisualStyleBackColor = true;
            this.process.Click += new System.EventHandler(this.process_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(227, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 24);
            this.label1.TabIndex = 50;
            this.label1.Text = "TAMBAH PRODUK";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // prdMerek
            // 
            this.prdMerek.Location = new System.Drawing.Point(159, 83);
            this.prdMerek.Name = "prdMerek";
            this.prdMerek.ReadOnly = true;
            this.prdMerek.Size = new System.Drawing.Size(80, 20);
            this.prdMerek.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(94, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 43;
            this.label4.Text = "Merek : ";
            // 
            // prdName
            // 
            this.prdName.Location = new System.Drawing.Point(159, 55);
            this.prdName.Name = "prdName";
            this.prdName.Size = new System.Drawing.Size(148, 20);
            this.prdName.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(97, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 41;
            this.label3.Text = "Nama : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 16);
            this.label2.TabIndex = 52;
            this.label2.Text = "Internal Storage :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(89, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 53;
            this.label5.Text = "Harga :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(368, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 16);
            this.label7.TabIndex = 55;
            this.label7.Text = "Image : ";
            // 
            // prdImg
            // 
            this.prdImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prdImg.Image = global::Stock.Properties.Resources._161179_WAHYU_ALLAH;
            this.prdImg.Location = new System.Drawing.Point(460, 43);
            this.prdImg.Name = "prdImg";
            this.prdImg.Size = new System.Drawing.Size(95, 104);
            this.prdImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.prdImg.TabIndex = 56;
            this.prdImg.TabStop = false;
            this.prdImg.Click += new System.EventHandler(this.prdImg_Click);
            // 
            // browseImg
            // 
            this.browseImg.Location = new System.Drawing.Point(371, 83);
            this.browseImg.Name = "browseImg";
            this.browseImg.Size = new System.Drawing.Size(71, 24);
            this.browseImg.TabIndex = 57;
            this.browseImg.Text = "BROWSE";
            this.browseImg.UseVisualStyleBackColor = true;
            this.browseImg.Click += new System.EventHandler(this.browseImg_Click);
            // 
            // browseMerek
            // 
            this.browseMerek.Location = new System.Drawing.Point(245, 81);
            this.browseMerek.Name = "browseMerek";
            this.browseMerek.Size = new System.Drawing.Size(69, 24);
            this.browseMerek.TabIndex = 58;
            this.browseMerek.Text = "BROWSE";
            this.browseMerek.UseVisualStyleBackColor = true;
            this.browseMerek.Click += new System.EventHandler(this.browseMerek_Click);
            // 
            // prdPrice
            // 
            this.prdPrice.Location = new System.Drawing.Point(159, 171);
            this.prdPrice.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.prdPrice.Name = "prdPrice";
            this.prdPrice.Size = new System.Drawing.Size(120, 20);
            this.prdPrice.TabIndex = 59;
            // 
            // prdRam
            // 
            this.prdRam.Location = new System.Drawing.Point(159, 114);
            this.prdRam.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.prdRam.Name = "prdRam";
            this.prdRam.Size = new System.Drawing.Size(59, 20);
            this.prdRam.TabIndex = 61;
            // 
            // prdInternal
            // 
            this.prdInternal.Location = new System.Drawing.Point(159, 140);
            this.prdInternal.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.prdInternal.Name = "prdInternal";
            this.prdInternal.Size = new System.Drawing.Size(59, 20);
            this.prdInternal.TabIndex = 62;
            // 
            // addPrdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 529);
            this.Controls.Add(this.prdInternal);
            this.Controls.Add(this.prdRam);
            this.Controls.Add(this.prdPrice);
            this.Controls.Add(this.browseMerek);
            this.Controls.Add(this.browseImg);
            this.Controls.Add(this.prdImg);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.process);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prdMerek);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.prdName);
            this.Controls.Add(this.label3);
            this.Name = "addPrdForm";
            this.Text = "addPrdForm";
            this.Load += new System.EventHandler(this.addPrdForm_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.prdImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prdPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prdRam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prdInternal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader nama;
        private System.Windows.Forms.ColumnHeader merek;
        private System.Windows.Forms.ColumnHeader ram;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteData;
        private System.Windows.Forms.Button process;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox prdMerek;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox prdName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox prdImg;
        private System.Windows.Forms.ColumnHeader inter;
        private System.Windows.Forms.ColumnHeader harga;
        private System.Windows.Forms.Button browseImg;
        private System.Windows.Forms.Button browseMerek;
        private System.Windows.Forms.NumericUpDown prdPrice;
        private System.Windows.Forms.NumericUpDown prdRam;
        private System.Windows.Forms.NumericUpDown prdInternal;
    }
}