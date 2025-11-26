using kuafor.Models;
using System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;

namespace kuafor
{
    public partial class FormCalisanUygunlukEkle : Form
    {
        private readonly Calisan _calisan;
        private readonly AppDbContext db = new AppDbContext();

        public FormCalisanUygunlukEkle(Calisan calisan)
        {
            InitializeComponent();
            _calisan = calisan;

            LoadSaatler();
        }

        private void LoadSaatler()
        {
            for (int i = 8; i <= 20; i++)
            {
                cmbBaslangic.Items.Add($"{i}:00");
                cmbBitis.Items.Add($"{i}:00");
            }

            cmbBaslangic.SelectedIndex = 0;
            cmbBitis.SelectedIndex = 1;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (cmbBaslangic.SelectedItem == null || cmbBitis.SelectedItem == null)
            {
                MessageBox.Show("Saat seç!");
                return;
            }

            var secilenGun = monthCalendar1.SelectionStart.DayOfWeek;
            byte gun = (byte)(((int)secilenGun + 6) % 7 + 1);

            TimeSpan bas = TimeSpan.Parse(cmbBaslangic.Text);
            TimeSpan bit = TimeSpan.Parse(cmbBitis.Text);

            if (bit <= bas)
            {
                MessageBox.Show("Bitiş saati başlangıçtan büyük olmalı!");
                return;
            }

            CalisanUygunluk yeni = new CalisanUygunluk
            {
                CalisanId = _calisan.Id,
                Gun = gun,
                Baslangic = bas,
                Bitis = bit
            };

            db.CalisanUygunluklar.Add(yeni);
            db.SaveChanges();

            MessageBox.Show("Uygunluk eklendi!");
            this.Close();
        }
    }
}

