using kuafor.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kuafor
{
    public partial class FormRandevuOlustur : Form
    {
        private Musteri _musteri;
        private AppDbContext _db;

        public FormRandevuOlustur(Musteri musteri)
        {
            InitializeComponent();
            _musteri = musteri;
            _db = new AppDbContext();
        }

        private void FormRandevuOlustur_Load(object sender, EventArgs e)
        {
            cmbIslem.DataSource = _db.Islemler.ToList();
            cmbIslem.DisplayMember = "Ad";
            cmbIslem.ValueMember = "Id";
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            int islemId = (int)cmbIslem.SelectedValue;
            DateTime secilenTarih = dtTarih.Value;

            // Randevu çakışma kontrolü
            bool cakisma = _db.Randevular
                .Any(r => r.Baslangic == secilenTarih);

            if (cakisma)
            {
                MessageBox.Show("Bu tarihte zaten bir randevu var!", "Hata");
                return;
            }

            Randevu r = new Randevu
            {
                MusteriId = _musteri.Id,
                IslemId = islemId,
                Baslangic = secilenTarih
            };

            _db.Randevular.Add(r);
            _db.SaveChanges();

            MessageBox.Show("Randevu başarıyla oluşturuldu!", "Bilgi");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
