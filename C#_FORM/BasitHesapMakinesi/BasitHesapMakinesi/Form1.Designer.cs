namespace hesapmakinesi
{
    partial class frmhesapmak
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
            this.btntoplam = new System.Windows.Forms.Button();
            this.btncikar = new System.Windows.Forms.Button();
            this.btncarp = new System.Windows.Forms.Button();
            this.btnbol = new System.Windows.Forms.Button();
            this.lblsayi1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblsayi2 = new System.Windows.Forms.Label();
            this.btncikis = new System.Windows.Forms.Button();
            this.lblsonuc = new System.Windows.Forms.Label();
            this.lblsnc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btntoplam
            // 
            this.btntoplam.Location = new System.Drawing.Point(196, 31);
            this.btntoplam.Name = "btntoplam";
            this.btntoplam.Size = new System.Drawing.Size(75, 23);
            this.btntoplam.TabIndex = 0;
            this.btntoplam.Text = "Toplama";
            this.btntoplam.UseVisualStyleBackColor = true;
            this.btntoplam.Click += new System.EventHandler(this.btntoplam_Click);
            // 
            // btncikar
            // 
            this.btncikar.Location = new System.Drawing.Point(196, 71);
            this.btncikar.Name = "btncikar";
            this.btncikar.Size = new System.Drawing.Size(75, 23);
            this.btncikar.TabIndex = 1;
            this.btncikar.Text = "Çıkarma";
            this.btncikar.UseVisualStyleBackColor = true;
            this.btncikar.Click += new System.EventHandler(this.btncikar_Click);
            // 
            // btncarp
            // 
            this.btncarp.Location = new System.Drawing.Point(197, 118);
            this.btncarp.Name = "btncarp";
            this.btncarp.Size = new System.Drawing.Size(75, 23);
            this.btncarp.TabIndex = 2;
            this.btncarp.Text = "Çarpma";
            this.btncarp.UseVisualStyleBackColor = true;
            this.btncarp.Click += new System.EventHandler(this.btncarp_Click);
            // 
            // btnbol
            // 
            this.btnbol.Location = new System.Drawing.Point(197, 164);
            this.btnbol.Name = "btnbol";
            this.btnbol.Size = new System.Drawing.Size(75, 23);
            this.btnbol.TabIndex = 3;
            this.btnbol.Text = "Bölme";
            this.btnbol.UseVisualStyleBackColor = true;
            this.btnbol.Click += new System.EventHandler(this.btnbol_Click);
            // 
            // lblsayi1
            // 
            this.lblsayi1.AutoSize = true;
            this.lblsayi1.Location = new System.Drawing.Point(12, 36);
            this.lblsayi1.Name = "lblsayi1";
            this.lblsayi1.Size = new System.Drawing.Size(33, 13);
            this.lblsayi1.TabIndex = 4;
            this.lblsayi1.Text = "Sayi1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(53, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(53, 73);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 6;
            // 
            // lblsayi2
            // 
            this.lblsayi2.AutoSize = true;
            this.lblsayi2.Location = new System.Drawing.Point(12, 76);
            this.lblsayi2.Name = "lblsayi2";
            this.lblsayi2.Size = new System.Drawing.Size(33, 13);
            this.lblsayi2.TabIndex = 7;
            this.lblsayi2.Text = "Sayi2";
            // 
            // btncikis
            // 
            this.btncikis.Location = new System.Drawing.Point(53, 164);
            this.btncikis.Name = "btncikis";
            this.btncikis.Size = new System.Drawing.Size(75, 23);
            this.btncikis.TabIndex = 8;
            this.btncikis.Text = "Çıkış";
            this.btncikis.UseVisualStyleBackColor = true;
            this.btncikis.Click += new System.EventHandler(this.btncikis_Click);
            // 
            // lblsonuc
            // 
            this.lblsonuc.AutoSize = true;
            this.lblsonuc.Location = new System.Drawing.Point(12, 118);
            this.lblsonuc.Name = "lblsonuc";
            this.lblsonuc.Size = new System.Drawing.Size(38, 13);
            this.lblsonuc.TabIndex = 9;
            this.lblsonuc.Text = "Sonuç";
            // 
            // lblsnc
            // 
            this.lblsnc.AutoSize = true;
            this.lblsnc.Location = new System.Drawing.Point(71, 118);
            this.lblsnc.Name = "lblsnc";
            this.lblsnc.Size = new System.Drawing.Size(25, 13);
            this.lblsnc.TabIndex = 10;
            this.lblsnc.Text = "___";
            // 
            // frmhesapmak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblsnc);
            this.Controls.Add(this.lblsonuc);
            this.Controls.Add(this.btncikis);
            this.Controls.Add(this.lblsayi2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblsayi1);
            this.Controls.Add(this.btnbol);
            this.Controls.Add(this.btncarp);
            this.Controls.Add(this.btncikar);
            this.Controls.Add(this.btntoplam);
            this.Name = "frmhesapmak";
            this.Text = "**Hesap Makinesi**";
            this.Load += new System.EventHandler(this.frmhesapmak_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btntoplam;
        private System.Windows.Forms.Button btncikar;
        private System.Windows.Forms.Button btncarp;
        private System.Windows.Forms.Button btnbol;
        private System.Windows.Forms.Label lblsayi1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblsayi2;
        private System.Windows.Forms.Button btncikis;
        private System.Windows.Forms.Label lblsonuc;
        private System.Windows.Forms.Label lblsnc;
    }
}

