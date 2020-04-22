namespace Stock
{
    partial class EditSplListview
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
            this.splPhone = new System.Windows.Forms.TextBox();
            this.process = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.splAlamat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.splName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // splPhone
            // 
            this.splPhone.Location = new System.Drawing.Point(130, 163);
            this.splPhone.Name = "splPhone";
            this.splPhone.Size = new System.Drawing.Size(148, 20);
            this.splPhone.TabIndex = 31;
            this.splPhone.TextChanged += new System.EventHandler(this.splPhone_TextChanged);
            // 
            // process
            // 
            this.process.Location = new System.Drawing.Point(103, 208);
            this.process.Name = "process";
            this.process.Size = new System.Drawing.Size(101, 48);
            this.process.TabIndex = 30;
            this.process.Text = "EDIT LIST";
            this.process.UseVisualStyleBackColor = true;
            this.process.Click += new System.EventHandler(this.process_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(50, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 29;
            this.label5.Text = "No Telp :";
            this.label5.UseWaitCursor = true;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // splAlamat
            // 
            this.splAlamat.Location = new System.Drawing.Point(130, 133);
            this.splAlamat.Name = "splAlamat";
            this.splAlamat.Size = new System.Drawing.Size(148, 20);
            this.splAlamat.TabIndex = 28;
            this.splAlamat.TextChanged += new System.EventHandler(this.splAlamat_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(57, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 27;
            this.label4.Text = "Alamat :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // splName
            // 
            this.splName.Location = new System.Drawing.Point(130, 104);
            this.splName.Name = "splName";
            this.splName.Size = new System.Drawing.Size(148, 20);
            this.splName.TabIndex = 26;
            this.splName.TextChanged += new System.EventHandler(this.splName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 16);
            this.label3.TabIndex = 25;
            this.label3.Text = "Nama Supplier :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 24);
            this.label1.TabIndex = 32;
            this.label1.Text = "EDIT SUPPLIER";
            // 
            // EditSplListview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 297);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.splPhone);
            this.Controls.Add(this.process);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.splAlamat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.splName);
            this.Controls.Add(this.label3);
            this.Name = "EditSplListview";
            this.Text = "Form5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox splPhone;
        private System.Windows.Forms.Button process;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox splAlamat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox splName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}