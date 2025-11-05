using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class YeniKayit : Form
    {
        aileEntities aileEntities;
        private int currentAileId = -1;

        public YeniKayit()
        {
            InitializeComponent();
            aileEntities = new aileEntities();
            InitializeCmbDurum();
            LoadKurumCombo();
        }

        private void InitializeCmbDurum()
        {
            var items = new[]
            {
                new { Text = "YAPILMADI", Value = (short)0 },
                new { Text = "YAPILDI", Value = (short)1 }
            };


        }

        private void LoadKurumCombo()
        {
            var kurumlar = aileEntities.bagisyapan_kurum.ToList();
            var items = kurumlar.Select(k => new { Display = k.KurumAdi, Value = k.KurumId }).ToList();
            items.Insert(0, new { Display = "Bireysel", Value = -1 });
            items.Insert(0, new { Display = "Anonim", Value = 0 });

            cmbKurum.DataSource = items;
            cmbKurum.DisplayMember = "Display";
            cmbKurum.ValueMember = "Value";
        }

        private void btnEkleAile_Click(object sender, EventArgs e)
        {
            if (!ValidateAileInputs()) return;

            int tc;
            if (!int.TryParse(txtAileTc.Text, out tc))
            {
                MessageBox.Show("TC Kimlik No geçersiz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var existingAile = aileEntities.aile.FirstOrDefault(a => a.TC == tc);
            if (existingAile != null)
            {
                MessageBox.Show("Bu TC numarası zaten kayıtlı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var yeniAile = new aile
                {
                    TC = tc,
                    AileAd = txtAileSoyad.Text,
                    Telefon = txtTel.Text,

                    Adres = txtAdres.Text,
                    KayitTarihi = DateTime.Today,
                    Guncelleme = DateTime.Today
                };

                aileEntities.aile.Add(yeniAile);
                aileEntities.SaveChanges();

                currentAileId = yeniAile.AileId;
                MessageBox.Show($"Aile kaydedildi. ID: {currentAileId}", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFertEkle_Click(object sender, EventArgs e)
        {
            if (currentAileId == -1)
            {
                MessageBox.Show("Önce bir aile ekleyin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtFertTc.Text) || string.IsNullOrWhiteSpace(txtAdSoyadFert.Text))
            {
                MessageBox.Show("TC ve Ad-Soyad boş olamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int tc;
            if (!int.TryParse(txtFertTc.Text, out tc))
            {
                MessageBox.Show("Fert TC Kimlik No geçersiz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var existingFert = aileEntities.ailefert.FirstOrDefault(f => f.TC == tc);
            if (existingFert != null)
            {
                MessageBox.Show("Bu TC numarası zaten kayıtlı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var yeniFert = new ailefert
                {
                    TC = tc,
                    AdSoyad = txtAdSoyadFert.Text,
                    Kayıt = DateTime.Today,
                    Guncelleme = DateTime.Today,
                    key_AileId = currentAileId
                };

                aileEntities.ailefert.Add(yeniFert);
                aileEntities.SaveChanges();

                MessageBox.Show("Fert eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadFertGrid();
                ClearFertFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadFertGrid()
        {
            if (currentAileId == -1) return;

            try
            {
                var ferts = aileEntities.ailefert
                    .Where(f => f.key_AileId == currentAileId)
                    .ToList();

                grdFert.DataSource = null;
                grdFert.DataSource = ferts;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fert listesi yüklenemedi: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearFertFields()
        {
            txtFertTc.Clear();
            txtAdSoyadFert.Clear();
            txtFertTc.Focus();
        }

        private bool ValidateAileInputs()
        {
            if (string.IsNullOrWhiteSpace(txtAileTc.Text) ||
                string.IsNullOrWhiteSpace(txtAileSoyad.Text) ||
                string.IsNullOrWhiteSpace(txtTel.Text) ||
                string.IsNullOrWhiteSpace(txtAdres.Text))
            {
                MessageBox.Show("Tüm alanlar doldurulmalıdır!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!int.TryParse(txtAileTc.Text, out _))
            {
                MessageBox.Show("TC Kimlik No sayı olmalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }



            return true;
        }
    }
}