
namespace CAS
{
    partial class MainForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.navBar = new System.Windows.Forms.MenuStrip();
            this.nvbrAbone = new System.Windows.Forms.ToolStripMenuItem();
            this.aboneDuzenle = new System.Windows.Forms.ToolStripMenuItem();
            this.raporToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nvbrAbonelik = new System.Windows.Forms.ToolStripMenuItem();
            this.abonelikDuzenle = new System.Windows.Forms.ToolStripMenuItem();
            this.raporlaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nvbrIcerik = new System.Windows.Forms.ToolStripMenuItem();
            this.navbarDergi = new System.Windows.Forms.ToolStripMenuItem();
            this.dergiDuzenle = new System.Windows.Forms.ToolStripMenuItem();
            this.dergiRapor = new System.Windows.Forms.ToolStripMenuItem();
            this.navbarTur = new System.Windows.Forms.ToolStripMenuItem();
            this.turDuzenle = new System.Windows.Forms.ToolStripMenuItem();
            this.turRapor = new System.Windows.Forms.ToolStripMenuItem();
            this.navbarFiyat = new System.Windows.Forms.ToolStripMenuItem();
            this.fiyatDuzenle = new System.Windows.Forms.ToolStripMenuItem();
            this.fiyatRapor = new System.Windows.Forms.ToolStripMenuItem();
            this.nvbrYtki = new System.Windows.Forms.ToolStripMenuItem();
            this.navbarPersonel = new System.Windows.Forms.ToolStripMenuItem();
            this.personelDuzenle = new System.Windows.Forms.ToolStripMenuItem();
            this.personelRapor = new System.Windows.Forms.ToolStripMenuItem();
            this.navbarBolum = new System.Windows.Forms.ToolStripMenuItem();
            this.bolumDuzenle = new System.Windows.Forms.ToolStripMenuItem();
            this.bolumRapor = new System.Windows.Forms.ToolStripMenuItem();
            this.nvbrGenelRaporlar = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yedekleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geriYükleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nvbrCıkıs = new System.Windows.Forms.ToolStripMenuItem();
            this.zıbınToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.navBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // navBar
            // 
            this.navBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.navBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nvbrAbone,
            this.nvbrAbonelik,
            this.nvbrIcerik,
            this.nvbrYtki,
            this.nvbrGenelRaporlar,
            this.databaseToolStripMenuItem,
            this.nvbrCıkıs,
            this.zıbınToolStripMenuItem});
            this.navBar.Location = new System.Drawing.Point(0, 0);
            this.navBar.Name = "navBar";
            this.navBar.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.navBar.ShowItemToolTips = true;
            this.navBar.Size = new System.Drawing.Size(800, 28);
            this.navBar.TabIndex = 0;
            this.navBar.Text = "Navbar";
            // 
            // nvbrAbone
            // 
            this.nvbrAbone.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboneDuzenle,
            this.raporToolStripMenuItem});
            this.nvbrAbone.Name = "nvbrAbone";
            this.nvbrAbone.Size = new System.Drawing.Size(67, 24);
            this.nvbrAbone.Text = "Abone";
            // 
            // aboneDuzenle
            // 
            this.aboneDuzenle.Name = "aboneDuzenle";
            this.aboneDuzenle.Size = new System.Drawing.Size(146, 26);
            this.aboneDuzenle.Text = "Düzenle";
            this.aboneDuzenle.Click += new System.EventHandler(this.ekleToolStripMenuItem_Click);
            // 
            // raporToolStripMenuItem
            // 
            this.raporToolStripMenuItem.Name = "raporToolStripMenuItem";
            this.raporToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.raporToolStripMenuItem.Text = "Raporla";
            this.raporToolStripMenuItem.Click += new System.EventHandler(this.raporToolStripMenuItem_Click);
            // 
            // nvbrAbonelik
            // 
            this.nvbrAbonelik.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abonelikDuzenle,
            this.raporlaToolStripMenuItem});
            this.nvbrAbonelik.Name = "nvbrAbonelik";
            this.nvbrAbonelik.Size = new System.Drawing.Size(82, 24);
            this.nvbrAbonelik.Text = "Abonelik";
            // 
            // abonelikDuzenle
            // 
            this.abonelikDuzenle.Name = "abonelikDuzenle";
            this.abonelikDuzenle.Size = new System.Drawing.Size(146, 26);
            this.abonelikDuzenle.Text = "Düzenle";
            this.abonelikDuzenle.Click += new System.EventHandler(this.ekleToolStripMenuItem1_Click);
            // 
            // raporlaToolStripMenuItem
            // 
            this.raporlaToolStripMenuItem.Name = "raporlaToolStripMenuItem";
            this.raporlaToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.raporlaToolStripMenuItem.Text = "Raporla";
            this.raporlaToolStripMenuItem.Click += new System.EventHandler(this.raporlaToolStripMenuItem_Click);
            // 
            // nvbrIcerik
            // 
            this.nvbrIcerik.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.navbarDergi,
            this.navbarTur,
            this.navbarFiyat});
            this.nvbrIcerik.Name = "nvbrIcerik";
            this.nvbrIcerik.Size = new System.Drawing.Size(75, 24);
            this.nvbrIcerik.Text = "İçerikler";
            // 
            // navbarDergi
            // 
            this.navbarDergi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dergiDuzenle,
            this.dergiRapor});
            this.navbarDergi.Name = "navbarDergi";
            this.navbarDergi.Size = new System.Drawing.Size(181, 26);
            this.navbarDergi.Text = "Dergi/Gazete";
            // 
            // dergiDuzenle
            // 
            this.dergiDuzenle.Name = "dergiDuzenle";
            this.dergiDuzenle.Size = new System.Drawing.Size(146, 26);
            this.dergiDuzenle.Text = "Düzenle";
            this.dergiDuzenle.Click += new System.EventHandler(this.ekleToolStripMenuItem2_Click);
            // 
            // dergiRapor
            // 
            this.dergiRapor.Name = "dergiRapor";
            this.dergiRapor.Size = new System.Drawing.Size(146, 26);
            this.dergiRapor.Text = "Raporla";
            this.dergiRapor.Click += new System.EventHandler(this.raporlaToolStripMenuItem1_Click);
            // 
            // navbarTur
            // 
            this.navbarTur.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.turDuzenle,
            this.turRapor});
            this.navbarTur.Name = "navbarTur";
            this.navbarTur.Size = new System.Drawing.Size(181, 26);
            this.navbarTur.Text = "Tür";
            // 
            // turDuzenle
            // 
            this.turDuzenle.Name = "turDuzenle";
            this.turDuzenle.Size = new System.Drawing.Size(146, 26);
            this.turDuzenle.Text = "Düzenle";
            this.turDuzenle.Click += new System.EventHandler(this.ekleToolStripMenuItem3_Click);
            // 
            // turRapor
            // 
            this.turRapor.Name = "turRapor";
            this.turRapor.Size = new System.Drawing.Size(146, 26);
            this.turRapor.Text = "Raporla";
            this.turRapor.Click += new System.EventHandler(this.raporlaToolStripMenuItem2_Click);
            // 
            // navbarFiyat
            // 
            this.navbarFiyat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fiyatDuzenle,
            this.fiyatRapor});
            this.navbarFiyat.Name = "navbarFiyat";
            this.navbarFiyat.Size = new System.Drawing.Size(181, 26);
            this.navbarFiyat.Text = "Fiyat";
            // 
            // fiyatDuzenle
            // 
            this.fiyatDuzenle.Name = "fiyatDuzenle";
            this.fiyatDuzenle.Size = new System.Drawing.Size(146, 26);
            this.fiyatDuzenle.Text = "Düzenle";
            this.fiyatDuzenle.Click += new System.EventHandler(this.ekleToolStripMenuItem4_Click);
            // 
            // fiyatRapor
            // 
            this.fiyatRapor.Name = "fiyatRapor";
            this.fiyatRapor.Size = new System.Drawing.Size(146, 26);
            this.fiyatRapor.Text = "Raporla";
            this.fiyatRapor.Click += new System.EventHandler(this.raporlaToolStripMenuItem3_Click);
            // 
            // nvbrYtki
            // 
            this.nvbrYtki.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.navbarPersonel,
            this.navbarBolum});
            this.nvbrYtki.Name = "nvbrYtki";
            this.nvbrYtki.Size = new System.Drawing.Size(54, 24);
            this.nvbrYtki.Text = "Yetki";
            // 
            // navbarPersonel
            // 
            this.navbarPersonel.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personelDuzenle,
            this.personelRapor});
            this.navbarPersonel.Name = "navbarPersonel";
            this.navbarPersonel.Size = new System.Drawing.Size(147, 26);
            this.navbarPersonel.Text = "Personel";
            // 
            // personelDuzenle
            // 
            this.personelDuzenle.Name = "personelDuzenle";
            this.personelDuzenle.Size = new System.Drawing.Size(146, 26);
            this.personelDuzenle.Text = "Düzenle";
            this.personelDuzenle.Click += new System.EventHandler(this.ekleToolStripMenuItem5_Click);
            // 
            // personelRapor
            // 
            this.personelRapor.Name = "personelRapor";
            this.personelRapor.Size = new System.Drawing.Size(146, 26);
            this.personelRapor.Text = "Raporla";
            this.personelRapor.Click += new System.EventHandler(this.raporToolStripMenuItem1_Click);
            // 
            // navbarBolum
            // 
            this.navbarBolum.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bolumDuzenle,
            this.bolumRapor});
            this.navbarBolum.Name = "navbarBolum";
            this.navbarBolum.Size = new System.Drawing.Size(147, 26);
            this.navbarBolum.Text = "Bölüm";
            // 
            // bolumDuzenle
            // 
            this.bolumDuzenle.Name = "bolumDuzenle";
            this.bolumDuzenle.Size = new System.Drawing.Size(146, 26);
            this.bolumDuzenle.Text = "Düzenle";
            this.bolumDuzenle.Click += new System.EventHandler(this.ekleToolStripMenuItem6_Click);
            // 
            // bolumRapor
            // 
            this.bolumRapor.Name = "bolumRapor";
            this.bolumRapor.Size = new System.Drawing.Size(146, 26);
            this.bolumRapor.Text = "Raporla";
            this.bolumRapor.Click += new System.EventHandler(this.raporlaToolStripMenuItem4_Click);
            // 
            // nvbrGenelRaporlar
            // 
            this.nvbrGenelRaporlar.Name = "nvbrGenelRaporlar";
            this.nvbrGenelRaporlar.Size = new System.Drawing.Size(122, 24);
            this.nvbrGenelRaporlar.Text = "Genel Raporlar";
            this.nvbrGenelRaporlar.Click += new System.EventHandler(this.nvbrGenelRaporlar_Click);
            // 
            // databaseToolStripMenuItem
            // 
            this.databaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yedekleToolStripMenuItem,
            this.geriYükleToolStripMenuItem});
            this.databaseToolStripMenuItem.Name = "databaseToolStripMenuItem";
            this.databaseToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.databaseToolStripMenuItem.Text = "Database";
            // 
            // yedekleToolStripMenuItem
            // 
            this.yedekleToolStripMenuItem.Name = "yedekleToolStripMenuItem";
            this.yedekleToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.yedekleToolStripMenuItem.Text = "Yedekle";
            this.yedekleToolStripMenuItem.Click += new System.EventHandler(this.yedekleToolStripMenuItem_Click);
            // 
            // geriYükleToolStripMenuItem
            // 
            this.geriYükleToolStripMenuItem.Name = "geriYükleToolStripMenuItem";
            this.geriYükleToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.geriYükleToolStripMenuItem.Text = "Geri Yükle";
            this.geriYükleToolStripMenuItem.Click += new System.EventHandler(this.geriYükleToolStripMenuItem_Click);
            // 
            // nvbrCıkıs
            // 
            this.nvbrCıkıs.Name = "nvbrCıkıs";
            this.nvbrCıkıs.Size = new System.Drawing.Size(53, 24);
            this.nvbrCıkıs.Text = "Çıkış";
            this.nvbrCıkıs.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // zıbınToolStripMenuItem
            // 
            this.zıbınToolStripMenuItem.Name = "zıbınToolStripMenuItem";
            this.zıbınToolStripMenuItem.Size = new System.Drawing.Size(14, 24);
            // 
            // mainPanel
            // 
            this.mainPanel.Location = new System.Drawing.Point(12, 32);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(776, 406);
            this.mainPanel.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.navBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.navBar;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C# Abonelik Sistemi";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.navBar.ResumeLayout(false);
            this.navBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem nvbrAbone;
        public System.Windows.Forms.MenuStrip navBar;
        public System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.ToolStripMenuItem aboneDuzenle;
        private System.Windows.Forms.ToolStripMenuItem raporToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nvbrAbonelik;
        private System.Windows.Forms.ToolStripMenuItem nvbrIcerik;
        private System.Windows.Forms.ToolStripMenuItem abonelikDuzenle;
        private System.Windows.Forms.ToolStripMenuItem navbarDergi;
        private System.Windows.Forms.ToolStripMenuItem navbarTur;
        private System.Windows.Forms.ToolStripMenuItem navbarFiyat;
        private System.Windows.Forms.ToolStripMenuItem nvbrYtki;
        private System.Windows.Forms.ToolStripMenuItem navbarPersonel;
        private System.Windows.Forms.ToolStripMenuItem navbarBolum;
        private System.Windows.Forms.ToolStripMenuItem raporlaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nvbrCıkıs;
        private System.Windows.Forms.ToolStripMenuItem dergiDuzenle;
        private System.Windows.Forms.ToolStripMenuItem turDuzenle;
        private System.Windows.Forms.ToolStripMenuItem fiyatDuzenle;
        private System.Windows.Forms.ToolStripMenuItem personelDuzenle;
        private System.Windows.Forms.ToolStripMenuItem bolumDuzenle;
        private System.Windows.Forms.ToolStripMenuItem nvbrGenelRaporlar;
        private System.Windows.Forms.ToolStripMenuItem dergiRapor;
        private System.Windows.Forms.ToolStripMenuItem turRapor;
        private System.Windows.Forms.ToolStripMenuItem fiyatRapor;
        private System.Windows.Forms.ToolStripMenuItem personelRapor;
        private System.Windows.Forms.ToolStripMenuItem bolumRapor;
        private System.Windows.Forms.ToolStripMenuItem databaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yedekleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem geriYükleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zıbınToolStripMenuItem;
    }
}

