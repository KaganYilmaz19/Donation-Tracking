using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Guncelle : Form
    {
        aileEntities aileEntities;
        private int currentAileId;

        public Guncelle(int aileId)
        {
            InitializeComponent();
            aileEntities = new aileEntities();
            currentAileId = aileId;
            InitializeCmbDurum();
            LoadAileData();
            LoadFertGrid();
        }

        private void InitializeCmbDurum()
        {
            var items = new[]
            {
                new { Text = "YAPILMADI", Value = (short)0 },
                new { Text = "YAPILDI", Value = (short)1 }
            };


        }

        private void LoadAileData()
        {
            try
            {
                var aile = aileEntities.aile.FirstOrDefault(a => a.AileId == currentAileId);
                if (aile != null)
                {
                    txtAileTc.Text = aile.TC.ToString();
                    txtAileSoyad.Text = aile.AileAd;
                    txtTel.Text = aile.Telefon;
                    txtAdres.Text = aile.Adres;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Aile verisi yüklenemedi: " + ex.Message);
            }
        }

        private void LoadFertGrid()
        {
            try
            {
                var ferts = aileEntities.ailefert
                    .Where(f => f.key_AileId == currentAileId)
                    .ToList();

                grdFert.DataSource = ferts;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fert listesi yüklenemedi: " + ex.Message);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (!ValidateAileInputs()) return;

            try
            {
                var aile = aileEntities.aile.FirstOrDefault(a => a.AileId == currentAileId);
                if (aile != null)
                {
                    aile.TC = int.Parse(txtAileTc.Text);
                    aile.AileAd = txtAileSoyad.Text;
                    aile.Telefon = txtTel.Text;
                    aile.Adres = txtAdres.Text;
                    aile.Guncelleme = DateTime.Today;

                    aileEntities.SaveChanges();
                    MessageBox.Show("Aile bilgileri güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void grdFert_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var selectedRow = (ailefert)grdFert.Rows[e.RowIndex].DataBoundItem;

            txtFertTc.Text = selectedRow.TC.ToString();
            txtAdSoyadFert.Text = selectedRow.AdSoyad;
        }

        private void btnFertGuncelle_Click(object sender, EventArgs e)
        {
            if (grdFert.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen bir fert seçin.");
                return;
            }

            var selectedFert = (ailefert)grdFert.SelectedRows[0].DataBoundItem;

            try
            {
                selectedFert.TC = int.Parse(txtFertTc.Text);
                selectedFert.AdSoyad = txtAdSoyadFert.Text;
                selectedFert.Guncelleme = DateTime.Today;

                aileEntities.Entry(selectedFert).State = EntityState.Modified;
                aileEntities.SaveChanges();

                MessageBox.Show("Fert bilgileri güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadFertGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}