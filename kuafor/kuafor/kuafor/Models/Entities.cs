using System;
using System.Collections.Generic;

namespace kuafor.Models
{
    public class Rol
    {
        public int Id { get; set; }
        public string Ad { get; set; }
    }

    // 🔹 Temel sınıf (Abstract Base Class)
    public abstract class Kullanici
    {
        public int Id { get; protected set; }
        public string KullaniciAdi { get; protected set; }
        public string SifreHash { get; protected set; }
        public int RolId { get; protected set; }

        public abstract string RolAdi { get; }

        public virtual void GuncelleSifre(string yeniSifre)
        {
            SifreHash = yeniSifre;
        }
    }

    // 🔹 Alt sınıf: Admin
    public class Admin : Kullanici
    {
        public override string RolAdi => "Admin";
    }

    // 🔹 Alt sınıf: Çalışan
    public class Calisan : Kullanici
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Uzmanlik { get; set; }
        public int SalonId { get; set; }

        public override string RolAdi => "Çalışan";

        public virtual Salon Salon { get; set; }
        public virtual ICollection<Islem> Islemler { get; set; }
        public virtual ICollection<CalisanUygunluk> Uygunluklar { get; set; }
    }

    // 🔹 Alt sınıf: Müşteri
    public class Musteri : Kullanici
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Telefon { get; set; }

        public override string RolAdi => "Müşteri";
    }

    // Diğer entity'ler
    public class Salon
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public TimeSpan CalismaBaslangic { get; set; }
        public TimeSpan CalismaBitis { get; set; }
        public virtual ICollection<Islem> Islemler { get; set; }
        public virtual ICollection<Calisan> Calisanlar { get; set; }
    }

    public class Islem
    {
        public int Id { get; set; }
        public int SalonId { get; set; }
        public string Ad { get; set; }
        public int SureDakika { get; set; }
        public decimal Ucret { get; set; }

        public virtual Salon Salon { get; set; }
        public virtual ICollection<Calisan> Calisanlar { get; set; }
    }

    public class CalisanUygunluk
    {
        public int Id { get; set; }
        public int CalisanId { get; set; }
        public byte Gun { get; set; } // 1..7
        public TimeSpan Baslangic { get; set; }
        public TimeSpan Bitis { get; set; }

        public virtual Calisan Calisan { get; set; }
    }

    public class Randevu
    {
        public int Id { get; set; }
        public int MusteriId { get; set; }
        public int CalisanId { get; set; }
        public int IslemId { get; set; }
        public DateTime Baslangic { get; set; }
        public DateTime Bitis { get; set; }
        public byte OnayDurumu { get; set; } // 0 bekliyor, 1 onay, 2 red

        public virtual Musteri Musteri { get; set; }
        public virtual Calisan Calisan { get; set; }
        public virtual Islem Islem { get; set; }
    }
}
