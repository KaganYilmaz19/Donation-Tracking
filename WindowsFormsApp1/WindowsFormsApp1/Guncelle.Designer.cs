namespace WindowsFormsApp1
{
    partial class Guncelle
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
            this.btnEkleAile = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grdFert = new System.Windows.Forms.DataGridView();
            this.btnFertEkle = new System.Windows.Forms.Button();
            this.txtAdSoyadFert = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFertTc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtAileSoyad = new System.Windows.Forms.TextBox();
            this.txtAileTc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdFert)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEkleAile
            // 
            this.btnEkleAile.Location = new System.Drawing.Point(110, 263);
            this.btnEkleAile.Name = "btnEkleAile";
            this.btnEkleAile.Size = new System.Drawing.Size(172, 53);
            this.btnEkleAile.TabIndex = 27;
            this.btnEkleAile.Text = "EKLE";
            this.btnEkleAile.UseVisualStyleBackColor = true;
            this.btnEkleAile.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grdFert);
            this.groupBox1.Controls.Add(this.btnFertEkle);
            this.groupBox1.Controls.Add(this.txtAdSoyadFert);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtFertTc);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(442, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(790, 426);
            this.groupBox1.TabIndex = 26;
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
            this.grdFert.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdFert_CellClick);
            // 
            // btnFertEkle
            // 
            this.btnFertEkle.Location = new System.Drawing.Point(350, 44);
            this.btnFertEkle.Name = "btnFertEkle";
            this.btnFertEkle.Size = new System.Drawing.Size(75, 62);
            this.btnFertEkle.TabIndex = 18;
            this.btnFertEkle.Text = "EKLE";
            this.btnFertEkle.UseVisualStyleBackColor = true;
            this.btnFertEkle.Click += new System.EventHandler(this.btnFertGuncelle_Click);
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
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(140, 180);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(225, 22);
            this.txtAdres.TabIndex = 25;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(140, 131);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(225, 22);
            this.txtTel.TabIndex = 22;
            // 
            // txtAileSoyad
            // 
            this.txtAileSoyad.Location = new System.Drawing.Point(140, 91);
            this.txtAileSoyad.Name = "txtAileSoyad";
            this.txtAileSoyad.Size = new System.Drawing.Size(225, 22);
            this.txtAileSoyad.TabIndex = 21;
            // 
            // txtAileTc
            // 
            this.txtAileTc.Location = new System.Drawing.Point(140, 44);
            this.txtAileTc.Name = "txtAileTc";
            this.txtAileTc.Size = new System.Drawing.Size(225, 22);
            this.txtAileTc.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(91, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "Adres";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Telefon No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Baba Soyad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "TC Kimlik No(ANNE):";
            // 
            // Guncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 499);
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
            this.Name = "Guncelle";
            this.Text = "Guncelle";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdFert)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEkleAile;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView grdFert;
        private System.Windows.Forms.Button btnFertEkle;
        private System.Windows.Forms.TextBox txtAdSoyadFert;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtFertTc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtAileSoyad;
        private System.Windows.Forms.TextBox txtAileTc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}