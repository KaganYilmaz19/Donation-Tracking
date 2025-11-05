using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Tablo : Form
    {
        aileEntities aileEntities;
        private int selectedAileId = -1;

        public Tablo()
        {
            InitializeComponent();
            aileEntities = new aileEntities();
            LoadAileData();
        }

        private void LoadAileData()
        {
            try
            {
                var aileList = aileEntities.aile.ToList();

                var formattedList = aileList.Select(a => new
                {
                    a.AileId,
                    a.TC,
                    a.AileAd,
                    a.Telefon,
                    a.Adres,
                    a.KayitTarihi,
                    a.Guncelleme,
                }).ToList();

                grdTablo.DataSource = formattedList;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri yüklenemedi: " + ex.Message);
            }
        }

        private void cellclick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var selectedRow = grdTablo.Rows[e.RowIndex];
            selectedAileId = (int)selectedRow.Cells["AileId"].Value;
        }

        private void guncelle_click(object sender, EventArgs e)
        {
            if (selectedAileId != -1)
            {
                var guncelleForm = new Guncelle(selectedAileId);
                guncelleForm.ShowDialog();
                LoadAileData();
                selectedAileId = -1;
            }
            else
            {
                MessageBox.Show("Lütfen bir satır seçin.");
            }
        }

        private void btnYeniKayıt_Click(object sender, EventArgs e)
        {
            YeniKayit kayıt = new YeniKayit();
            DialogResult result = kayıt.ShowDialog();
            if (result == DialogResult.OK)
            {
                LoadAileData();
            }
        }

        private void btnKayıtSil_Click(object sender, EventArgs e)
        {
            int aileId = -1;

            if (selectedAileId != -1)
            {
                aileId = selectedAileId;
            }
            else if (grdTablo.SelectedRows.Count > 0)
            {
                aileId = (int)grdTablo.SelectedRows[0].Cells["AileId"].Value;
            }

            if (aileId != -1)
            {
                var result = MessageBox.Show("Bu kaydı silmek istediğinizden emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        var aile = aileEntities.aile.FirstOrDefault(a => a.AileId == aileId);
                        if (aile != null)
                        {
                            aileEntities.aile.Remove(aile);
                            aileEntities.SaveChanges();
                            MessageBox.Show("Kayıt silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadAileData();
                            selectedAileId = -1;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Silme işlemi başarısız: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir satır seçin.");
            }
        }

        private void btnKurumEkle_Click(object sender, EventArgs e)
        {
            Kurum form = new Kurum();
            DialogResult result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                // Kurum eklendiğinde başka bir işlem yoksa sadece form açılır
            }
        }

        private void txtFiltre_TextChanged(object sender, EventArgs e)
        {
            string filterText = textBox1.Text.ToLower();

            try
            {
                var aileList = aileEntities.aile.ToList();

                var filteredList = aileList.Where(a =>
                    a.TC.ToString().Contains(filterText) ||
                    a.AileAd.ToLower().Contains(filterText) ||
                    a.Telefon.ToLower().Contains(filterText) ||
                    a.Adres.ToLower().Contains(filterText)
                ).ToList();

                var formattedList = filteredList.Select(a => new
                {
                    a.AileId,
                    a.TC,
                    a.AileAd,
                    a.Telefon,
                    a.Adres,
                    a.KayitTarihi,
                    a.Guncelleme,
                }).ToList();

                grdTablo.DataSource = formattedList;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Filtreleme hatası: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            KullaniciEkle form =  new KullaniciEkle();
            form.ShowDialog();
        }

        private void btnBagisTuruEkle(object sender, EventArgs e)
        {
            BagisTuruEkle form = new BagisTuruEkle();
            form.ShowDialog();
        }

        private void Tablo_Load(object sender, EventArgs e)
        {
           
        }
    }
    
}