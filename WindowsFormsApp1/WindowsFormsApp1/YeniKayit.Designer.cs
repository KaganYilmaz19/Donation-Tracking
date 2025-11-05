namespace WindowsFormsApp1
{
    partial class YeniKayit
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAileTc;
        private System.Windows.Forms.TextBox txtAileSoyad;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEkleAile;
        private System.Windows.Forms.DataGridView grdFert;
        private System.Windows.Forms.Button btnFertEkle;
        private System.Windows.Forms.TextBox txtAdSoyadFert;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtFertTc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbKurum;
        private System.Windows.Forms.Label label9;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAileTc = new System.Windows.Forms.TextBox();
            this.txtAileSoyad = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grdFert = new System.Windows.Forms.DataGridView();
            this.btnFertEkle = new System.Windows.Forms.Button();
            this.txtAdSoyadFert = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFertTc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnEkleAile = new System.Windows.Forms.Button();
            this.cmbKurum = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdFert)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC Kimlik No(ANNE):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Baba Soyad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefon No:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(112, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Adres";
            // 
            // txtAileTc
            // 
            this.txtAileTc.Location = new System.Drawing.Point(160, 31);
            this.txtAileTc.Name = "txtAileTc";
            this.txtAileTc.Size = new System.Drawing.Size(225, 22);
            this.txtAileTc.TabIndex = 6;
            // 
            // txtAileSoyad
            // 
            this.txtAileSoyad.Location = new System.Drawing.Point(160, 78);
            this.txtAileSoyad.Name = "txtAileSoyad";
            this.txtAileSoyad.Size = new System.Drawing.Size(225, 22);
            this.txtAileSoyad.TabIndex = 7;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(160, 118);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(225, 22);
            this.txtTel.TabIndex = 8;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(161, 168);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(225, 22);
            this.txtAdres.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grdFert);
            this.groupBox1.Controls.Add(this.btnFertEkle);
            this.groupBox1.Controls.Add(this.txtAdSoyadFert);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtFertTc);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(462, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(790, 426);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detaylar(Gerekli)";
            // 
            // grdFert
            // 
            this.grdFert.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdFert.Location = new System.Drawing.Point(27, 145);
            this.grdFert.Name = "grdFert";
            this.grdFert.RowHeadersWidth = 51;
            this.grdFert.RowTemplate.Height = 24;
            this.grdFert.Size = new System.Drawing.Size(744, 275);
            this.grdFert.TabIndex = 19;
            // 
            // btnFertEkle
            // 
            this.btnFertEkle.Location = new System.Drawing.Point(350, 44);
            this.btnFertEkle.Name = "btnFertEkle";
            this.btnFertEkle.Size = new System.Drawing.Size(75, 62);
            this.btnFertEkle.TabIndex = 18;
            this.btnFertEkle.Text = "EKLE";
            this.btnFertEkle.UseVisualStyleBackColor = true;
            this.btnFertEkle.Click += new System.EventHandler(this.btnFertEkle_Click);
            // 
            // txtAdSoyadFert
            // 
            this.txtAdSoyadFert.Location = new System.Drawing.Point(106, 84);
            this.txtAdSoyadFert.Name = "txtAdSoyadFert";
            this.txtAdSoyadFert.Size = new System.Drawing.Size(225, 22);
            this.txtAdSoyadFert.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Ad Soyad";
            // 
            // txtFertTc
            // 
            this.txtFertTc.Location = new System.Drawing.Point(106, 47);
            this.txtFertTc.Name = "txtFertTc";
            this.txtFertTc.Size = new System.Drawing.Size(225, 22);
            this.txtFertTc.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(66, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "TC";
            // 
            // btnEkleAile
            // 
            this.btnEkleAile.Location = new System.Drawing.Point(131, 251);
            this.btnEkleAile.Name = "btnEkleAile";
            this.btnEkleAile.Size = new System.Drawing.Size(172, 53);
            this.btnEkleAile.TabIndex = 13;
            this.btnEkleAile.Text = "EKLE";
            this.btnEkleAile.UseVisualStyleBackColor = true;
            this.btnEkleAile.Click += new System.EventHandler(this.btnEkleAile_Click);
            // 
            // cmbKurum
            // 
            this.cmbKurum.FormattingEnabled = true;
            this.cmbKurum.Location = new System.Drawing.Point(161, 206);
            this.cmbKurum.Name = "cmbKurum";
            this.cmbKurum.Size = new System.Drawing.Size(225, 24);
            this.cmbKurum.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(101, 209);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 16);
            this.label9.TabIndex = 30;
            this.label9.Text = "Kurum:";
            // 
            // YeniKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbKurum);
            this.Controls.Add(this.btnEkleAile);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.txtAileSoyad);
            this.Controls.Add(this.txtAileTc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "YeniKayit";
            this.Text = "YeniKayit";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdFert)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}