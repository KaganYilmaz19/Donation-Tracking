using System.Windows.Forms;

namespace WindowsFormsApp1
{
    partial class Kurum
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtKurumAdi;
        private TextBox txtYetkiliAdSoyad;
        private TextBox txtTelefon;
        private TextBox txtEmail;
        private TextBox txtAdres;
        private DataGridView grdKurumlar;
        private Button btnEkle;
        private Button btnGuncelle;
        private Button btnSil;
        private Label lblKurumAdi;
        private Label lblYetkiliAdSoyad;
        private Label lblTelefon;
        private Label lblEmail;
        private Label lblAdres;

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
            this.txtKurumAdi = new System.Windows.Forms.TextBox();
            this.txtYetkiliAdSoyad = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.grdKurumlar = new System.Windows.Forms.DataGridView();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.lblKurumAdi = new System.Windows.Forms.Label();
            this.lblYetkiliAdSoyad = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblAdres = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdKurumlar)).BeginInit();
            this.SuspendLayout();
            // 
            // txtKurumAdi
            // 
            this.txtKurumAdi.Location = new System.Drawing.Point(90, 12);
            this.txtKurumAdi.Name = "txtKurumAdi";
            this.txtKurumAdi.Size = new System.Drawing.Size(200, 22);
            this.txtKurumAdi.TabIndex = 0;
            // 
            // txtYetkiliAdSoyad
            // 
            this.txtYetkiliAdSoyad.Location = new System.Drawing.Point(90, 40);
            this.txtYetkiliAdSoyad.Name = "txtYetkiliAdSoyad";
            this.txtYetkiliAdSoyad.Size = new System.Drawing.Size(200, 22);
            this.txtYetkiliAdSoyad.TabIndex = 1;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(90, 68);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(200, 22);
            this.txtTelefon.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(90, 96);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 22);
            this.txtEmail.TabIndex = 3;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(90, 124);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(200, 80);
            this.txtAdres.TabIndex = 4;
            // 
            // grdKurumlar
            // 
            this.grdKurumlar.AllowUserToAddRows = false;
            this.grdKurumlar.AllowUserToDeleteRows = false;
            this.grdKurumlar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdKurumlar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdKurumlar.ColumnHeadersHeight = 29;
            this.grdKurumlar.Location = new System.Drawing.Point(300, 12);
            this.grdKurumlar.Name = "grdKurumlar";
            this.grdKurumlar.ReadOnly = true;
            this.grdKurumlar.RowHeadersWidth = 51;
            this.grdKurumlar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdKurumlar.Size = new System.Drawing.Size(780, 420);
            this.grdKurumlar.TabIndex = 5;
            this.grdKurumlar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdKurumlar_CellClick);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(90, 210);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(60, 30);
            this.btnEkle.TabIndex = 6;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(136, 246);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(97, 30);
            this.btnGuncelle.TabIndex = 7;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(222, 210);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(60, 30);
            this.btnSil.TabIndex = 8;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // lblKurumAdi
            // 
            this.lblKurumAdi.AutoSize = true;
            this.lblKurumAdi.Location = new System.Drawing.Point(12, 12);
            this.lblKurumAdi.Name = "lblKurumAdi";
            this.lblKurumAdi.Size = new System.Drawing.Size(70, 16);
            this.lblKurumAdi.TabIndex = 13;
            this.lblKurumAdi.Text = "Kurum Adı:";
            // 
            // lblYetkiliAdSoyad
            // 
            this.lblYetkiliAdSoyad.AutoSize = true;
            this.lblYetkiliAdSoyad.Location = new System.Drawing.Point(12, 40);
            this.lblYetkiliAdSoyad.Name = "lblYetkiliAdSoyad";
            this.lblYetkiliAdSoyad.Size = new System.Drawing.Size(46, 16);
            this.lblYetkiliAdSoyad.TabIndex = 12;
            this.lblYetkiliAdSoyad.Text = "Yetkili:";
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(12, 68);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(56, 16);
            this.lblTelefon.TabIndex = 11;
            this.lblTelefon.Text = "Telefon:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(12, 96);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(44, 16);
            this.lblEmail.TabIndex = 10;
            this.lblEmail.Text = "Email:";
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Location = new System.Drawing.Point(12, 124);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(46, 16);
            this.lblAdres.TabIndex = 9;
            this.lblAdres.Text = "Adres:";
            // 
            // Kurum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 450);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.grdKurumlar);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.lblAdres);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.txtYetkiliAdSoyad);
            this.Controls.Add(this.lblYetkiliAdSoyad);
            this.Controls.Add(this.txtKurumAdi);
            this.Controls.Add(this.lblKurumAdi);
            this.Name = "Kurum";
            this.Text = "Kurum";
            ((System.ComponentModel.ISupportInitialize)(this.grdKurumlar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

    }
    
}