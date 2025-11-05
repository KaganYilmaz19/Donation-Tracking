using BCrypt.Net;
using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        aileEntities aileEntities;

        public Form1()
        {
            InitializeComponent();
            aileEntities = new aileEntities();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtUser.Text;
            string sifre = txtPass.Text;

            if (string.IsNullOrWhiteSpace(kullaniciAdi) || string.IsNullOrWhiteSpace(sifre))
            {
                MessageBox.Show("Lütfen kullanıcı adı ve şifre girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Sadece kullanıcı adı ile kullanıcıyı bul (şifre doğrulaması için hash gerekli)
                var kullanici = aileEntities.kullanici.FirstOrDefault(k => k.KullaniciAdi == kullaniciAdi);

                if (kullanici == null)
                {
                    // Kullanıcı adı bulunamadı
                    MessageBox.Show("Geçersiz kullanıcı adı veya şifre!", "Giriş Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Veritabanındaki hashlenmiş şifre
                string hashliSifre = kullanici.Sifre;

                // Kullanıcının girdiği ham şifre ile veritabanındaki hash karşılaştırılır
                bool sifreDogruMu = BCrypt.Net.BCrypt.Verify(sifre, hashliSifre);

                if (sifreDogruMu)
                {
                    // Şifre doğru, giriş başarılı
                    string token = Guid.NewGuid().ToString();
                    DateTime expiry = DateTime.Now.AddHours(1);

                    CurrentUser.Instance.SetUser(kullanici.KullaniciAdi, kullanici.KullaniciRol, token, expiry);

                    Tablo form = new Tablo();
                    form.ShowDialog();
                }
                else
                {
                    // Şifre yanlış
                    MessageBox.Show("Geçersiz kullanıcı adı veya şifre!", "Giriş Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Giriş yapılırken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}