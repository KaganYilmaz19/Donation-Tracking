using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Kurum : Form
    {
        aileEntities aileEntities;

        public Kurum()
        {
            InitializeComponent();
            aileEntities = new aileEntities();
            LoadKurumData();
        }

        private void LoadKurumData()
        {
            try
            {
                var kurumList = aileEntities.bagisyapan_kurum.ToList();
                grdKurumlar.DataSource = kurumList;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri yüklenemedi: " + ex.Message);
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            try
            {
                var yeniKurum = new bagisyapan_kurum
                {
                    KurumAdi = txtKurumAdi.Text,
                    YetkiliAdSoyad = txtYetkiliAdSoyad.Text,
                    Telefon = txtTelefon.Text,
                    Email = txtEmail.Text,
                    Adres = txtAdres.Text,
                    KayitTarihi = DateTime.Today,
                    Guncelleme = DateTime.Today
                };

                aileEntities.bagisyapan_kurum.Add(yeniKurum);
                aileEntities.SaveChanges();

                MessageBox.Show("Kurum eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadKurumData();
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (grdKurumlar.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen bir kurum seçin.");
                return;
            }

            var selectedRow = grdKurumlar.SelectedRows[0];
            var originalKurum = (bagisyapan_kurum)selectedRow.DataBoundItem;

            try
            {
                originalKurum.KurumAdi = txtKurumAdi.Text;
                originalKurum.YetkiliAdSoyad = txtYetkiliAdSoyad.Text;
                originalKurum.Telefon = txtTelefon.Text;
                originalKurum.Email = txtEmail.Text;
                originalKurum.Adres = txtAdres.Text;
                originalKurum.Guncelleme = DateTime.Today;

                aileEntities.Entry(originalKurum).State = EntityState.Modified;
                aileEntities.SaveChanges();

                MessageBox.Show("Kurum bilgileri güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadKurumData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (grdKurumlar.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen bir kurum seçin.");
                return;
            }

            var selectedRow = grdKurumlar.SelectedRows[0];
            var originalKurum = (bagisyapan_kurum)selectedRow.DataBoundItem;

            var result = MessageBox.Show($"'{originalKurum.KurumAdi}' kurumunu silmek istediğinizden emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    aileEntities.bagisyapan_kurum.Remove(originalKurum);
                    aileEntities.SaveChanges();

                    MessageBox.Show("Kurum silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadKurumData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void grdKurumlar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var selectedRow = (bagisyapan_kurum)grdKurumlar.Rows[e.RowIndex].DataBoundItem;

            txtKurumAdi.Text = selectedRow.KurumAdi;
            txtYetkiliAdSoyad.Text = selectedRow.YetkiliAdSoyad;
            txtTelefon.Text = selectedRow.Telefon;
            txtEmail.Text = selectedRow.Email;
            txtAdres.Text = selectedRow.Adres;
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtKurumAdi.Text) ||
                string.IsNullOrWhiteSpace(txtYetkiliAdSoyad.Text))
            {
                MessageBox.Show("Kurum Adı ve Yetkili Ad Soyad boş olamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void ClearInputs()
        {
            txtKurumAdi.Clear();
            txtYetkiliAdSoyad.Clear();
            txtTelefon.Clear();
            txtEmail.Clear();
            txtAdres.Clear();
        }
    }
}