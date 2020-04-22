namespace Stock
{
    partial class EditMerek
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
            this.mrkName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.process = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mrkName
            // 
            this.mrkName.Location = new System.Drawing.Point(102, 94);
            this.mrkName.Name = "mrkName";
            this.mrkName.Size = new System.Drawing.Size(116, 20);
            this.mrkName.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 43;
            this.label3.Text = "Nama : ";
            // 
            // process
            // 
            this.process.Location = new System.Drawing.Point(75, 148);
            this.process.Name = "process";
            this.process.Size = new System.Drawing.Size(101, 48);
            this.process.TabIndex = 45;
            this.process.Text = "SAVE TO DATABASE";
            this.process.UseVisualStyleBackColor = true;
            this.process.Click += new System.EventHandler(this.process_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 24);
            this.label1.TabIndex = 46;
            this.label1.Text = "EDIT MEREK";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // EditMerek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 234);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.process);
            this.Controls.Add(this.mrkName);
            this.Controls.Add(this.label3);
            this.Name = "EditMerek";
            this.Text = "EditMerek";
            this.Load += new System.EventHandler(this.EditMerek_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox mrkName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button process;
        private System.Windows.Forms.Label label1;
    }
}