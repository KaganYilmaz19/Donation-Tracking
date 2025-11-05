namespace WindowsFormsApp1
{
    partial class Tablo
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
            this.btnYeniKayıt = new System.Windows.Forms.Button();
            this.btnKayıtSil = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.grdTablo = new System.Windows.Forms.DataGridView();
            this.BtnGunc = new System.Windows.Forms.Button();
            this.btnKurumEkle = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdTablo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnYeniKayıt
            // 
            this.btnYeniKayıt.Location = new System.Drawing.Point(6, 30);
            this.btnYeniKayıt.Name = "btnYeniKayıt";
            this.btnYeniKayıt.Size = new System.Drawing.Size(159, 40);
            this.btnYeniKayıt.TabIndex = 0;
            this.btnYeniKayıt.Text = "Yeni Kayıt Yap";
            this.btnYeniKayıt.UseVisualStyleBackColor = true;
            this.btnYeniKayıt.Click += new System.EventHandler(this.btnYeniKayıt_Click);
            // 
            // btnKayıtSil
            // 
            this.btnKayıtSil.Location = new System.Drawing.Point(188, 30);
            this.btnKayıtSil.Name = "btnKayıtSil";
            this.btnKayıtSil.Size = new System.Drawing.Size(159, 40);
            this.btnKayıtSil.TabIndex = 1;
            this.btnKayıtSil.Text = "Kayıt Sil";
            this.btnKayıtSil.UseVisualStyleBackColor = true;
            this.btnKayıtSil.Click += new System.EventHandler(this.btnKayıtSil_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1174, 30);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(159, 40);
            this.button3.TabIndex = 2;
            this.button3.Text = "Yeni Kullanıcı Ekle";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // grdTablo
            // 
            this.grdTablo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTablo.Location = new System.Drawing.Point(12, 155);
            this.grdTablo.Name = "grdTablo";
            this.grdTablo.RowHeadersWidth = 51;
            this.grdTablo.RowTemplate.Height = 24;
            this.grdTablo.Size = new System.Drawing.Size(1321, 328);
            this.grdTablo.TabIndex = 3;
            this.grdTablo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cellclick);
            // 
            // BtnGunc
            // 
            this.BtnGunc.Location = new System.Drawing.Point(379, 30);
            this.BtnGunc.Name = "BtnGunc";
            this.BtnGunc.Size = new System.Drawing.Size(142, 40);
            this.BtnGunc.TabIndex = 4;
            this.BtnGunc.Text = "Kayıt Güncelle";
            this.BtnGunc.UseVisualStyleBackColor = true;
            this.BtnGunc.Click += new System.EventHandler(this.guncelle_click);
            // 
            // btnKurumEkle
            // 
            this.btnKurumEkle.Location = new System.Drawing.Point(553, 30);
            this.btnKurumEkle.Name = "btnKurumEkle";
            this.btnKurumEkle.Size = new System.Drawing.Size(164, 40);
            this.btnKurumEkle.TabIndex = 5;
            this.btnKurumEkle.Text = "Kurum Ekle";
            this.btnKurumEkle.UseVisualStyleBackColor = true;
            this.btnKurumEkle.Click += new System.EventHandler(this.btnKurumEkle_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 109);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(214, 22);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.txtFiltre_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(745, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 40);
            this.button1.TabIndex = 7;
            this.button1.Text = "Bağış Türü Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnBagisTuruEkle);
            // 
            // Tablo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1357, 495);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnKurumEkle);
            this.Controls.Add(this.BtnGunc);
            this.Controls.Add(this.grdTablo);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnKayıtSil);
            this.Controls.Add(this.btnYeniKayıt);
            this.Name = "Tablo";
            this.Text = "Tablo";
            this.Load += new System.EventHandler(this.Tablo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdTablo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnYeniKayıt;
        private System.Windows.Forms.Button btnKayıtSil;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView grdTablo;
        private System.Windows.Forms.Button BtnGunc;
        private System.Windows.Forms.Button btnKurumEkle;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}