using kuafor.Models;
using Microsoft.EntityFrameworkCore;
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
    public partial class FormMusteriPanel : Form
    {
        private Musteri _aktifMusteri;

        public FormMusteriPanel(Musteri musteri)
        {
            _aktifMusteri = musteri;
            InitializeComponent();

            lblHosgeldin.Text = $"Hoş geldin {_aktifMusteri.KullaniciAdi}";
            LoadRandevular();
        }

        private void LoadRandevular()
        {
            lstRandevular.Items.Clear();

            using (var db = new AppDbContext())
            {
                var randevular = db.Randevular
                    .Where(r => r.MusteriId == _aktifMusteri.Id)
                    .ToList();

                if (randevular.Count == 0)
                {
                    lstRandevular.Items.Add("Randevu bulunmuyor.");
                    return;
                }

                foreach (var r in randevular)
                {
                    string durum = r.OnayDurumu switch
                    {
                        0 => "Bekliyor",
                        1 => "Onaylandı",
                        2 => "Reddedildi",
                        _ => "Bilinmiyor"
                    };
                    lstRandevular.Items.Add($"{r.Baslangic:dd.MM.yyyy HH:mm} - {r.Islem.Ad}");

                }
            }
        }

        private void BtnYeniRandevu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Randevu oluşturma ekranı daha sonra eklenecek.");
        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BtnRandevuIptal_Click(object sender, EventArgs e)
        {
            if (lstRandevular.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen iptal etmek istediğiniz randevuyu seçin.");
                return;
            }

            // Seçilen randevuyu al
            var secilen = lstRandevular.SelectedItem.ToString();

            using (var db = new AppDbContext())
            {
                // Tarih ve işlem adı bilgisine göre randevuyu buluyoruz
                var randevu = db.Randevular
                    .Include(r => r.Islem)
                    .FirstOrDefault(r =>
                        $"{r.Baslangic:dd.MM.yyyy HH:mm} - {r.Islem.Ad}" == secilen &&
                        r.MusteriId == _aktifMusteri.Id);

                if (randevu != null)
                {
                    db.Randevular.Remove(randevu); // Randevuyu sil
                    db.SaveChanges();
                    MessageBox.Show("Randevu iptal edildi.");
                    LoadRandevular(); // listeyi yenile
                }
                else
                {
                    MessageBox.Show("Randevu bulunamadı!");
                }
            }
        }

    }
}
