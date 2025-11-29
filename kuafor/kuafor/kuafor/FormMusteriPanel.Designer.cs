namespace kuafor
{
    partial class FormMusteriPanel
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblHosgeldin;
        private System.Windows.Forms.ListBox lstRandevular;
        private System.Windows.Forms.Button BtnYeniRandevu;
        private System.Windows.Forms.Button BtnCikis;
        private System.Windows.Forms.Button BtnRandevuIptal; // üstte diğer buttonlarla birlikte
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            // --- FORM ---
            this.Text = "Müşteri Paneli";
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            // --- HOŞGELDİN LABEL ---
            lblHosgeldin = new System.Windows.Forms.Label();
            lblHosgeldin.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            lblHosgeldin.Text = "Hoş geldin";
            lblHosgeldin.AutoSize = true;
            lblHosgeldin.Location = new System.Drawing.Point(200, 20);

            // --- RANDEVULAR LISTBOX ---
            lstRandevular = new System.Windows.Forms.ListBox();
            lstRandevular.Font = new System.Drawing.Font("Segoe UI", 12F);
            lstRandevular.Size = new System.Drawing.Size(400, 200);
            lstRandevular.Location = new System.Drawing.Point(100, 80);

            // --- YENİ RANDEVU BUTONU ---
            BtnYeniRandevu = new System.Windows.Forms.Button();
            BtnYeniRandevu.Text = "Yeni Randevu Oluştur";
            BtnYeniRandevu.Font = new System.Drawing.Font("Segoe UI", 12F);
            BtnYeniRandevu.Size = new System.Drawing.Size(200, 40);
            BtnYeniRandevu.Location = new System.Drawing.Point(200, 300);
            BtnYeniRandevu.Click += new System.EventHandler(this.BtnYeniRandevu_Click);

            // --- ÇIKIŞ BUTONU ---
            BtnCikis = new System.Windows.Forms.Button();
            BtnCikis.Text = "Çıkış Yap";
            BtnCikis.Font = new System.Drawing.Font("Segoe UI", 12F);
            BtnCikis.Size = new System.Drawing.Size(200, 40);
            BtnCikis.Location = new System.Drawing.Point(200, 350);
            BtnCikis.Click += new System.EventHandler(this.BtnCikis_Click);

            // --- KONTROLLERİ FORMA EKLE ---
            this.Controls.Add(lblHosgeldin);
            this.Controls.Add(lstRandevular);
            this.Controls.Add(BtnYeniRandevu);
            this.Controls.Add(BtnCikis);

            this.ResumeLayout(false);
            this.PerformLayout();
            

        // InitializeComponent içinde:
        BtnRandevuIptal = new System.Windows.Forms.Button();
        BtnRandevuIptal.Text = "Seçili Randevuyu İptal Et";
        BtnRandevuIptal.Font = new System.Drawing.Font("Segoe UI", 12F);
        BtnRandevuIptal.Size = new System.Drawing.Size(200, 40);
        BtnRandevuIptal.Location = new System.Drawing.Point(320, 300); // konumu ayarla
        BtnRandevuIptal.Click += new System.EventHandler(this.BtnRandevuIptal_Click);

           this.Controls.Add(BtnRandevuIptal);

        }
}
}
