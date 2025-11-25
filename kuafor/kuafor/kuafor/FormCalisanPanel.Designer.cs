namespace kuafor
{
    partial class FormCalisanPanel
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblCalisan;
        private Panel panelTakvim;
        private Panel panelMain;
        private GroupBox groupBoxIslemler;
        private ListBox lstIslemler;
        private Button btnUygunlukEkle;
        private Button btnRandevularim;
        private Button btnTakvimeDon;

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
            this.lblCalisan = new System.Windows.Forms.Label();
            this.panelTakvim = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.groupBoxIslemler = new System.Windows.Forms.GroupBox();
            this.lstIslemler = new System.Windows.Forms.ListBox();
            this.btnRandevularim = new System.Windows.Forms.Button();
            this.btnTakvimeDon = new System.Windows.Forms.Button();
            this.btnUygunlukEkle = new System.Windows.Forms.Button();
            this.groupBoxIslemler.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCalisan
            // 
            this.lblCalisan.AutoSize = true;
            this.lblCalisan.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCalisan.Location = new System.Drawing.Point(20, 20);
            this.lblCalisan.Name = "lblCalisan";
            this.lblCalisan.Size = new System.Drawing.Size(224, 32);
            this.lblCalisan.TabIndex = 0;
            this.lblCalisan.Text = "Çalışan Adı Soyadı";
            // 
            // panelTakvim
            // 
            this.panelTakvim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTakvim.Location = new System.Drawing.Point(250, 70);
            this.panelTakvim.Name = "panelTakvim";
            this.panelTakvim.Size = new System.Drawing.Size(850, 650);
            this.panelTakvim.TabIndex = 1;
            // 
            // panelMain
            // 
            this.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMain.Location = new System.Drawing.Point(250, 70);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(850, 650);
            this.panelMain.TabIndex = 4;
            this.panelMain.Visible = false;
            // 
            // groupBoxIslemler
            // 
            this.groupBoxIslemler.Controls.Add(this.lstIslemler);
            this.groupBoxIslemler.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBoxIslemler.Location = new System.Drawing.Point(20, 70);
            this.groupBoxIslemler.Name = "groupBoxIslemler";
            this.groupBoxIslemler.Size = new System.Drawing.Size(220, 600);
            this.groupBoxIslemler.TabIndex = 2;
            this.groupBoxIslemler.TabStop = false;
            this.groupBoxIslemler.Text = "Yapabildiğim İşlemler";
            // 
            // lstIslemler
            // 
            this.lstIslemler.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstIslemler.FormattingEnabled = true;
            this.lstIslemler.ItemHeight = 23;
            this.lstIslemler.Location = new System.Drawing.Point(10, 25);
            this.lstIslemler.Name = "lstIslemler";
            this.lstIslemler.Size = new System.Drawing.Size(200, 556);
            this.lstIslemler.TabIndex = 0;
            // 
            // btnRandevularim
            // 
            this.btnRandevularim.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRandevularim.Location = new System.Drawing.Point(20, 680);
            this.btnRandevularim.Name = "btnRandevularim";
            this.btnRandevularim.Size = new System.Drawing.Size(220, 40);
            this.btnRandevularim.TabIndex = 5;
            this.btnRandevularim.Text = "Randevularım";
            this.btnRandevularim.UseVisualStyleBackColor = true;
            this.btnRandevularim.Click += new System.EventHandler(this.btnRandevularim_Click);
            // 
            // btnTakvimeDon
            // 
            this.btnTakvimeDon.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTakvimeDon.Location = new System.Drawing.Point(20, 725);
            this.btnTakvimeDon.Name = "btnTakvimeDon";
            this.btnTakvimeDon.Size = new System.Drawing.Size(220, 40);
            this.btnTakvimeDon.TabIndex = 6;
            this.btnTakvimeDon.Text = "Takvime Dön";
            this.btnTakvimeDon.UseVisualStyleBackColor = true;
            this.btnTakvimeDon.Click += new System.EventHandler(this.btnTakvimeDon_Click);
            // 
            // btnUygunlukEkle
            // 
            this.btnUygunlukEkle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUygunlukEkle.Location = new System.Drawing.Point(20, 770);
            this.btnUygunlukEkle.Name = "btnUygunlukEkle";
            this.btnUygunlukEkle.Size = new System.Drawing.Size(220, 40);
            this.btnUygunlukEkle.TabIndex = 3;
            this.btnUygunlukEkle.Text = "Uygunluk Ekle";
            this.btnUygunlukEkle.UseVisualStyleBackColor = true;
            this.btnUygunlukEkle.Click += new System.EventHandler(this.btnUygunlukEkle_Click);
            // 
            // FormCalisanPanel
            // 
            this.ClientSize = new System.Drawing.Size(1130, 830);
            this.Controls.Add(this.btnTakvimeDon);
            this.Controls.Add(this.btnRandevularim);
            this.Controls.Add(this.btnUygunlukEkle);
            this.Controls.Add(this.groupBoxIslemler);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelTakvim);
            this.Controls.Add(this.lblCalisan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormCalisanPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Çalışan Paneli";
            this.Load += new System.EventHandler(this.FormCalisanPanel_Load_1);
            this.groupBoxIslemler.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        
    }
}