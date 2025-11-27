using kuafor.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Windows.Forms;

namespace kuafor
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKullaniciAdi.Text.Trim();
            string sifre = txtSifre.Text.Trim();

            if (string.IsNullOrEmpty(kullaniciAdi) || string.IsNullOrEmpty(sifre))
            {
                MessageBox.Show("Lütfen kullanıcı adı ve şifre giriniz!");
                return;
            }

            using (var db = new AppDbContext())
            {
                var kullanici = db.Kullanicilar
                    .FirstOrDefault(u => u.KullaniciAdi == kullaniciAdi && u.SifreHash == sifre);

                if (kullanici == null)
                {
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı!");
                    return;
                }

                MessageBox.Show($"Hoş geldin {kullanici.KullaniciAdi}! ({kullanici.RolAdi})");

                // 🔹 Rol'e göre yönlendirme
                Form targetForm = null;
                // ------------------------
                //  ADMIN PANELİ
                // ------------------------
                if (kullanici is Admin)
                {
                    targetForm = new FormAdminPanel();
                }
                else if (kullanici is Calisan)
                {
                    var calisan = db.Calisanlar
                       .Include(c => c.Salon)
                       .Include(c => c.Islemler)
                       .Include(c => c.Uygunluklar)
                       .FirstOrDefault(c => c.Id == kullanici.Id);

                    if (calisan == null)
                    {
                        MessageBox.Show("Çalışan bilgisi yüklenemedi!");
                        return;
                    }

                    if (calisan.Salon == null)
                    {
                        MessageBox.Show("Bu çalışanın bağlı olduğu salon bilgisi bulunamadı!");
                        return;
                    }

                    targetForm = new FormCalisanPanel(calisan);
                }
                // ------------------------
                //  MÜŞTERİ PANELİ 
                // ------------------------
                else if (kullanici is Musteri musteri)
                {
                    targetForm = new FormMusteriPanel(musteri);  
                }



                // ------------------------
                //  PANELİ AÇ
                // ------------------------

                if (targetForm != null)
                {
                    // 🔹 Login formunu gizle, yeni formu göster
                    this.Hide();
                    targetForm.ShowDialog();

                    // 🔹 Kapatıldığında tekrar login ekranını göster
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Tanımlı bir rol bulunamadı!");
                }
            }
        }

        private void linkKayit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormKayit kayitFormu = new FormKayit();
            kayitFormu.ShowDialog();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            // Form açıldığında yapılacak işlemler
        }
    }
}
