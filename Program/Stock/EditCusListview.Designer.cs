namespace Stock
{
    partial class EditCusListview
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
            this.cusPhone = new System.Windows.Forms.TextBox();
            this.process = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cusAlamat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cusName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cusPhone
            // 
            this.cusPhone.Location = new System.Drawing.Point(142, 135);
            this.cusPhone.Name = "cusPhone";
            this.cusPhone.Size = new System.Drawing.Size(148, 20);
            this.cusPhone.TabIndex = 38;
            // 
            // process
            // 
            this.process.Location = new System.Drawing.Point(98, 173);
            this.process.Name = "process";
            this.process.Size = new System.Drawing.Size(101, 48);
            this.process.TabIndex = 37;
            this.process.Text = "EDIT LIST";
            this.process.UseVisualStyleBackColor = true;
            this.process.Click += new System.EventHandler(this.process_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(60, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 36;
            this.label5.Text = "No Telp :";
            this.label5.UseWaitCursor = true;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // cusAlamat
            // 
            this.cusAlamat.Location = new System.Drawing.Point(142, 105);
            this.cusAlamat.Name = "cusAlamat";
            this.cusAlamat.Size = new System.Drawing.Size(148, 20);
            this.cusAlamat.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(67, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 34;
            this.label4.Text = "Alamat :";
            // 
            // cusName
            // 
            this.cusName.Location = new System.Drawing.Point(142, 76);
            this.cusName.Name = "cusName";
            this.cusName.Size = new System.Drawing.Size(148, 20);
            this.cusName.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 16);
            this.label3.TabIndex = 32;
            this.label3.Text = "Nama Customer :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 24);
            this.label1.TabIndex = 39;
            this.label1.Text = "EDIT CUSTOMER";
            // 
            // EditCusListview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 247);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cusPhone);
            this.Controls.Add(this.process);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cusAlamat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cusName);
            this.Controls.Add(this.label3);
            this.Name = "EditCusListview";
            this.Text = "EditCusListview";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cusPhone;
        private System.Windows.Forms.Button process;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox cusAlamat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox cusName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}