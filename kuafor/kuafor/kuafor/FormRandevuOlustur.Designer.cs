namespace kuafor
{
    partial class FormRandevuOlustur
    {
    
            private System.ComponentModel.IContainer components = null;
            private System.Windows.Forms.Label lblBaslik;
            private System.Windows.Forms.Label lblIslem;
            private System.Windows.Forms.ComboBox cmbIslem;
            private System.Windows.Forms.Label lblTarih;
            private System.Windows.Forms.DateTimePicker dtTarih;
            private System.Windows.Forms.Button btnKaydet;
            private System.Windows.Forms.Button btnIptal;

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
                this.lblBaslik = new System.Windows.Forms.Label();
                this.lblIslem = new System.Windows.Forms.Label();
                this.cmbIslem = new System.Windows.Forms.ComboBox();
                this.lblTarih = new System.Windows.Forms.Label();
                this.dtTarih = new System.Windows.Forms.DateTimePicker();
                this.btnKaydet = new System.Windows.Forms.Button();
                this.btnIptal = new System.Windows.Forms.Button();
                this.SuspendLayout();

                // FORM
                this.Text = "Yeni Randevu Oluştur";
                this.ClientSize = new System.Drawing.Size(400, 300);
                this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

                // BAŞLIK
                lblBaslik.Text = "Yeni Randevu Oluştur";
                lblBaslik.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
                lblBaslik.AutoSize = true;
                lblBaslik.Location = new System.Drawing.Point(90, 20);

                // İŞLEM LABEL
                lblIslem.Text = "Hizmet Seç:";
                lblIslem.Font = new System.Drawing.Font("Segoe UI", 12F);
                lblIslem.AutoSize = true;
                lblIslem.Location = new System.Drawing.Point(40, 90);

                // İŞLEM COMBOBOX
                cmbIslem.Font = new System.Drawing.Font("Segoe UI", 12F);
                cmbIslem.Location = new System.Drawing.Point(150, 85);
                cmbIslem.Size = new System.Drawing.Size(180, 30);

                // TARİH LABEL
                lblTarih.Text = "Tarih - Saat:";
                lblTarih.Font = new System.Drawing.Font("Segoe UI", 12F);
                lblTarih.AutoSize = true;
                lblTarih.Location = new System.Drawing.Point(40, 140);

                // TARİH PICKER
                dtTarih.Font = new System.Drawing.Font("Segoe UI", 12F);
                dtTarih.Location = new System.Drawing.Point(150, 135);
                dtTarih.Size = new System.Drawing.Size(180, 30);
                dtTarih.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
                dtTarih.CustomFormat = "dd.MM.yyyy HH:mm";

                // KAYDET
                btnKaydet.Text = "Kaydet";
                btnKaydet.Font = new System.Drawing.Font("Segoe UI", 12F);
                btnKaydet.Location = new System.Drawing.Point(70, 210);
                btnKaydet.Size = new System.Drawing.Size(120, 40);
                btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);

                // İPTAL
                btnIptal.Text = "İptal";
                btnIptal.Font = new System.Drawing.Font("Segoe UI", 12F);
                btnIptal.Location = new System.Drawing.Point(210, 210);
                btnIptal.Size = new System.Drawing.Size(120, 40);
                btnIptal.Click += new System.EventHandler(this.btnIptal_Click);

                // FORM KONTROLLERİ
                this.Controls.Add(lblBaslik);
                this.Controls.Add(lblIslem);
                this.Controls.Add(cmbIslem);
                this.Controls.Add(lblTarih);
                this.Controls.Add(dtTarih);
                this.Controls.Add(btnKaydet);
                this.Controls.Add(btnIptal);

                this.ResumeLayout(false);
                this.PerformLayout();
            }
        



}
}