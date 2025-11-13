using Microsoft.EntityFrameworkCore;
using kuafor.Models;

namespace kuafor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (var db = new AppDbContext())
            {
                try
                {
                    // 🔹 1. SQL bağlantısını test et
                    db.Database.OpenConnection();
                    MessageBox.Show("SQL bağlantısı başarılı");
                    db.Database.CloseConnection();

                    // 🔹 2. Tabloları oluştur (yoksa otomatik oluşturur)
                    db.Database.EnsureCreated();
                    MessageBox.Show("Veritabanı ve tablolar başarıyla oluşturuldu");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(" Hata: " + ex.Message);
                }
            }
        }
    }
}
