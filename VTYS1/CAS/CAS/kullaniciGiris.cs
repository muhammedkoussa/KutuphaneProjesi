using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAS
{
    public partial class kullaniciGiris : formlar
    {
        public kullaniciGiris()
        {
            InitializeComponent();
        }
        public string kulAdi { get; set; }
        public string kulSifre { get; set; }
        public string blm { get; set; }
        private void girisButon_Click(object sender, EventArgs e)
        {
            if(mssql.sqlString("select count(*) from personel where kullaniciAdi='"+kullaniciText.Text+"'").Equals("1"))
            {
                if(mssql.sqlString("select count(*) from personel where kullaniciAdi='" + kullaniciText.Text + "' and sifre='" + sifreText.Text + "'").Equals("1"))
                {
                    MessageBox.Show("Kullanıcı Girişi Başarılı!");
                    MainForm mf =new MainForm();
                    mf.navBar.Enabled = true;
                    kulAdi = kullaniciText.Text; //kullanıcı giriş formundan kullanıcı adı şifreyi main forma gönderen kod
                    kulSifre = sifreText.Text;
                    string a = string.Empty;
                    a= mssql.sqlString("select bolumID from personel where kullaniciAdi='" + kullaniciText.Text + "' and sifre='" + sifreText.Text + "'");
                    blm = mssql.sqlString("select yetkiTipi from bolum where bolumID='"+a+"'");
                    this.Hide();
                    mf.Show();
                }
                else
                    MessageBox.Show("Kullanıcı Şifre Yanlış!");
            }
            else
                MessageBox.Show("Kullanıcı Bulunmamakta!");
        }

        private void kullaniciGiris_Load(object sender, EventArgs e)
        {
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
