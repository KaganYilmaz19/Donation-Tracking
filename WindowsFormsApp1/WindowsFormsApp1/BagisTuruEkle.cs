using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class BagisTuruEkle : Form
    {
        aileEntities aileEntities;

        public BagisTuruEkle()
        {
            InitializeComponent();
            aileEntities = new aileEntities(); // Initialize the context
        }

        public void BilgileriListele()
        {
            try
            {
                var bagisTurleri = aileEntities.bagisturu.ToList();
                dataGridView1.DataSource = bagisTurleri;
                // Set column headers to readable names
                dataGridView1.Columns["Id"].HeaderText = "ID";
                dataGridView1.Columns["BagisTuru1"].HeaderText = "Bağış Türü";
                dataGridView1.Columns["Aciklama"].HeaderText = "Açıklama";
                dataGridView1.Columns["Durum"].HeaderText = "Durum";
                dataGridView1.Columns["Miktar"].HeaderText = "Miktar";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBagisEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) ||
                cmbDurum.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen tüm alanları doldurun!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var existingBagisTuru = aileEntities.bagisturu.FirstOrDefault(b => b.BagisTuru1 == textBox1.Text);
                if (existingBagisTuru != null)
                {
                    MessageBox.Show("Bu bağış türü zaten kayıtlı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                decimal miktarValue = 0;
                if (!string.IsNullOrWhiteSpace(txtMiktar.Text))
                {
                    if (!decimal.TryParse(txtMiktar.Text, out miktarValue))
                    {
                        MessageBox.Show("Lütfen geçerli bir miktar girin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                var yeniBagisTuru = new bagisturu
                {
                    BagisTuru1 = textBox1.Text,
                    Aciklama = textBox2.Text,
                    Durum = cmbDurum.SelectedItem?.ToString(),
                    Miktar = miktarValue > 0 ? miktarValue : (decimal?)null
                };

                aileEntities.bagisturu.Add(yeniBagisTuru);
                aileEntities.SaveChanges();

                MessageBox.Show("Bağış türü eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Refresh the list after adding
                BilgileriListele();

                // Clear the textboxes after successful addition
                textBox1.Clear();
                textBox2.Clear();
                cmbDurum.SelectedIndex = -1;
                txtMiktar.Clear();
                textBox1.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void grdClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                textBox1.Text = row.Cells["BagisTuru1"].Value?.ToString();
                textBox2.Text = row.Cells["Aciklama"].Value?.ToString();

                // Set combo box value
                string durum = row.Cells["Durum"].Value?.ToString();
                if (!string.IsNullOrEmpty(durum))
                {
                    cmbDurum.SelectedItem = durum;
                }
                else
                {
                    cmbDurum.SelectedIndex = -1;
                }

                // Set amount
                var miktar = row.Cells["Miktar"].Value;
                if (miktar != null && miktar != DBNull.Value)
                {
                    txtMiktar.Text = miktar.ToString();
                }
                else
                {
                    txtMiktar.Clear();
                }
            }
        }

        private void BagisTuruEkle_Load(object sender, EventArgs e)
        {
            BilgileriListele();
        }
    }
}