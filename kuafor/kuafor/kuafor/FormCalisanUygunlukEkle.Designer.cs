namespace kuafor
{
    partial class FormCalisanUygunlukEkle
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelCalendar;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.ComboBox cmbBaslangic;
        private System.Windows.Forms.ComboBox cmbBitis;
        private System.Windows.Forms.Button btnKaydet;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelCalendar = new System.Windows.Forms.Panel();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.cmbBaslangic = new System.Windows.Forms.ComboBox();
            this.cmbBitis = new System.Windows.Forms.ComboBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // PANEL (Takvim büyük görünsün)
            this.panelCalendar.Location = new System.Drawing.Point(10, 10);
            this.panelCalendar.Size = new System.Drawing.Size(250, 220);   // 🔥 BÜYÜTÜLDÜ
            this.panelCalendar.AutoScroll = false;                         // 🔥 Scroll kapatıldı
            this.panelCalendar.BorderStyle = System.Windows.Forms.BorderStyle.None;

            // MONTH CALENDAR (Büyük görünüm)
            this.monthCalendar1.Location = new System.Drawing.Point(0, 0);
            this.monthCalendar1.Size = new System.Drawing.Size(230, 200);   // 🔥 Takvim daha büyük
            this.monthCalendar1.MaxSelectionCount = 1;

            // Takvimi panele ekliyoruz
            this.panelCalendar.Controls.Add(this.monthCalendar1);

            // Başlangıç Saati Combo
            this.cmbBaslangic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBaslangic.Location = new System.Drawing.Point(20, 240);  // 🔽 Aşağı alındı
            this.cmbBaslangic.Size = new System.Drawing.Size(100, 30);

            // Bitiş Saati Combo
            this.cmbBitis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBitis.Location = new System.Drawing.Point(140, 240);
            this.cmbBitis.Size = new System.Drawing.Size(100, 30);

            // Kaydet Butonu
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Location = new System.Drawing.Point(70, 290);
            this.btnKaydet.Size = new System.Drawing.Size(120, 40);
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);

            // FORM
            this.ClientSize = new System.Drawing.Size(280, 350);  // 🔥 Form boyutu büyütüldü
            this.Controls.Add(this.panelCalendar);
            this.Controls.Add(this.cmbBaslangic);
            this.Controls.Add(this.cmbBitis);
            this.Controls.Add(this.btnKaydet);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Uygunluk Ekle";
            this.ResumeLayout(false);
        }
    }
}
