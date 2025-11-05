using BCrypt.Net;
using System;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class KullaniciEkle : Form
    {
        private aileEntities aileEntities;

        public KullaniciEkle()
        {
            InitializeComponent();
            aileEntities = new aileEntities();
            LoadRoles();
        }

        private void LoadRoles()
        {
            cmbRol.Items.Clear();
            cmbRol.Items.Add("admin");
            cmbRol.Items.Add("editor");
            cmbRol.Items.Add("reader");
            cmbRol.SelectedIndex = -1;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKullaniciAdi.Text) ||
                string.IsNullOrWhiteSpace(txtSifre.Text) ||
                cmbRol.SelectedIndex == -1)
            {
                MessageBox.Show("Tüm alanlar doldurulmalıdır!", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Uzunluk kontrolü
            if (txtKullaniciAdi.Text.Length > 45)
            {
                MessageBox.Show("Kullanıcı adı en fazla 45 karakter olabilir.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbRol.SelectedItem.ToString().Length > 45)
            {
                MessageBox.Show("Rol en fazla 45 karakter olabilir.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (aileEntities.kullanici.Any(u => u.KullaniciAdi == txtKullaniciAdi.Text))
                {
                    MessageBox.Show("Bu kullanıcı adı zaten mevcut!", "Uyarı",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var yeniKullanici = new kullanici
                {
                    KullaniciAdi = txtKullaniciAdi.Text,
                    Sifre = BCrypt.Net.BCrypt.HashPassword(txtSifre.Text),
                    KullaniciRol = cmbRol.SelectedItem.ToString()
                };

                aileEntities.kullanici.Add(yeniKullanici);
                aileEntities.SaveChanges();

                MessageBox.Show("Kullanıcı eklendi.", "Başarılı",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                string errorMessage = $"Hata: {ex.Message}\n\n";
                if (ex.InnerException != null)
                {
                    errorMessage += $"İç Hata: {ex.InnerException.Message}\n";
                    if (ex.InnerException.InnerException != null)
                        errorMessage += $"İç İçe Hata: {ex.InnerException.InnerException.Message}\n";
                }
                MessageBox.Show(errorMessage, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }
    }
}