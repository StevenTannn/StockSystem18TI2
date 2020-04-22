namespace Stock
{
    partial class EditProduk
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
            this.prdInternal = new System.Windows.Forms.NumericUpDown();
            this.prdRam = new System.Windows.Forms.NumericUpDown();
            this.prdPrice = new System.Windows.Forms.NumericUpDown();
            this.browseMerek = new System.Windows.Forms.Button();
            this.browseImg = new System.Windows.Forms.Button();
            this.prdImg = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.process = new System.Windows.Forms.Button();
            this.prdMerek = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.prdName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.prdInternal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prdRam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prdPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prdImg)).BeginInit();
            this.SuspendLayout();
            // 
            // prdInternal
            // 
            this.prdInternal.Location = new System.Drawing.Point(167, 152);
            this.prdInternal.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.prdInternal.Name = "prdInternal";
            this.prdInternal.Size = new System.Drawing.Size(59, 20);
            this.prdInternal.TabIndex = 79;
            // 
            // prdRam
            // 
            this.prdRam.Location = new System.Drawing.Point(167, 121);
            this.prdRam.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.prdRam.Name = "prdRam";
            this.prdRam.Size = new System.Drawing.Size(59, 20);
            this.prdRam.TabIndex = 78;
            // 
            // prdPrice
            // 
            this.prdPrice.Location = new System.Drawing.Point(167, 178);
            this.prdPrice.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.prdPrice.Name = "prdPrice";
            this.prdPrice.Size = new System.Drawing.Size(120, 20);
            this.prdPrice.TabIndex = 77;
            // 
            // browseMerek
            // 
            this.browseMerek.Location = new System.Drawing.Point(266, 91);
            this.browseMerek.Name = "browseMerek";
            this.browseMerek.Size = new System.Drawing.Size(72, 22);
            this.browseMerek.TabIndex = 76;
            this.browseMerek.Text = "BROWSE";
            this.browseMerek.UseVisualStyleBackColor = true;
            this.browseMerek.Click += new System.EventHandler(this.browseMerek_Click);
            // 
            // browseImg
            // 
            this.browseImg.Location = new System.Drawing.Point(394, 202);
            this.browseImg.Name = "browseImg";
            this.browseImg.Size = new System.Drawing.Size(71, 24);
            this.browseImg.TabIndex = 75;
            this.browseImg.Text = "BROWSE";
            this.browseImg.UseVisualStyleBackColor = true;
            this.browseImg.Click += new System.EventHandler(this.browseImg_Click);
            // 
            // prdImg
            // 
            this.prdImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prdImg.Location = new System.Drawing.Point(382, 61);
            this.prdImg.Name = "prdImg";
            this.prdImg.Size = new System.Drawing.Size(95, 104);
            this.prdImg.TabIndex = 74;
            this.prdImg.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(338, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 16);
            this.label7.TabIndex = 73;
            this.label7.Text = "Image : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(82, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 72;
            this.label5.Text = "Harga :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 16);
            this.label2.TabIndex = 71;
            this.label2.Text = "Internal Storage :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(91, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 69;
            this.label6.Text = "RAM :";
            // 
            // process
            // 
            this.process.Location = new System.Drawing.Point(214, 266);
            this.process.Name = "process";
            this.process.Size = new System.Drawing.Size(101, 48);
            this.process.TabIndex = 68;
            this.process.Text = "SAVE TO DATABASE";
            this.process.UseVisualStyleBackColor = true;
            this.process.Click += new System.EventHandler(this.process_Click);
            // 
            // prdMerek
            // 
            this.prdMerek.Location = new System.Drawing.Point(167, 91);
            this.prdMerek.Name = "prdMerek";
            this.prdMerek.ReadOnly = true;
            this.prdMerek.Size = new System.Drawing.Size(80, 20);
            this.prdMerek.TabIndex = 66;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(80, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 65;
            this.label4.Text = "Merek : ";
            // 
            // prdName
            // 
            this.prdName.Location = new System.Drawing.Point(167, 61);
            this.prdName.Name = "prdName";
            this.prdName.Size = new System.Drawing.Size(148, 20);
            this.prdName.TabIndex = 64;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(80, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 63;
            this.label3.Text = "Nama : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(192, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 24);
            this.label1.TabIndex = 80;
            this.label1.Text = "EDIT PRODUK";
            // 
            // EditProduk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 344);
            this.Controls.Add(this.label1);
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
            this.Controls.Add(this.process);
            this.Controls.Add(this.prdMerek);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.prdName);
            this.Controls.Add(this.label3);
            this.Name = "EditProduk";
            this.Text = "EditProduk";
            this.Load += new System.EventHandler(this.EditProduk_Load);
            ((System.ComponentModel.ISupportInitialize)(this.prdInternal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prdRam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prdPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prdImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown prdInternal;
        private System.Windows.Forms.NumericUpDown prdRam;
        private System.Windows.Forms.NumericUpDown prdPrice;
        private System.Windows.Forms.Button browseMerek;
        private System.Windows.Forms.Button browseImg;
        private System.Windows.Forms.PictureBox prdImg;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button process;
        private System.Windows.Forms.TextBox prdMerek;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox prdName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}