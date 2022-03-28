using System;
using System.Windows.Forms;

namespace CAS
{
    public partial class fiyatTipi : formlar
    {

        public string fiyatID;          //veri işlemleri için id nesnesi
        public fiyatTipi()
        {
            InitializeComponent();
        }

        private void fiyatTipiEkle_Load(object sender, EventArgs e)     //başlangıçtaki tüm ayarların sıfırlanması
        {
            fiyatID = "0";
            ekleRadio.Checked = false;
            silRadio.Checked = false;
            guncelleRadio.Checked = false;
            tipAdıTxt.Text = string.Empty;
            fiyatTxt.Text = string.Empty;
            dataGridView1.DataSource = mssql.sqlTablo("select fiyatID as 'Fiyat Numarası',tip as 'Fiyat Tipi',ucret as 'Fiyat' from fiyat");        //datagridview içini veritabanından dolduran kod
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)        //datagridview üzerinde bir satır seçildiğinde ilgili alanları satırdaki verilerle dolduran kod
        {
            fiyatID = dataGridView1.SelectedRows[0].Cells["Fiyat Numarası"].Value.ToString();
            tipAdıTxt.Text = dataGridView1.SelectedRows[0].Cells["Fiyat Tipi"].Value.ToString();
            fiyatTxt.Text= dataGridView1.SelectedRows[0].Cells["Fiyat"].Value.ToString();
        }

        private void turKaydetBtn_Click(object sender, EventArgs e)       //kaydet butonunda ekle,güncelle,sil işlemleri
        {
            int check = -1;         //check değeri ile seçilen işlem kontrolü
            if (ekleRadio.Checked) check = 0;
            else if (guncelleRadio.Checked) check = 1;
            else if (silRadio.Checked) check = 2;
            switch (check)
            {
                case 0:     //ekleme işlemi 
                    if (!(tipAdıTxt.Text == "" || fiyatTxt.Text == ""))     //eklenecek veriler boş bırakılmadıysa ekleme işlemi yap
                    {
                        mssql.sqlIslem("insert into fiyat values('"+tipAdıTxt.Text+"','"+fiyatTxt.Text.Replace(',','.') +"')");
                        MessageBox.Show("Yeni Kayıt Başarıyla Eklendi!");
                    }
                    else
                        MessageBox.Show("Lütfen Alanları Boş Bırakmayın!");
                    break;
                case 1:     //güncelleme işlemi
                    if (fiyatID != "0")
                    {
                        if (mssql.sqlString("select count(*) from fiyat where fiyatID=" + fiyatID).Equals("1"))      //güncellenecek kayıt bulunuyorsa ilgili verilerle güncelleme yap
                        {
                            mssql.sqlIslem("update fiyat set tip='" + tipAdıTxt.Text + "', ucret='" + fiyatTxt.Text.Replace(',', '.') + "' where fiyatID=" + fiyatID);
                            MessageBox.Show(fiyatID + " Numaralı Kayıt Başarıyla Güncellendi!");
                        }
                        else
                            MessageBox.Show(fiyatID + " Numaralı Kayıt Bulunamadı!");
                    }
                    else
                        MessageBox.Show("Lütfen Bir Kayıt Seçin!");
                    break;
                case 2:     //silme işlemi    
                    if (fiyatID != "0")
                    {
                        if (mssql.sqlString("select count(*) from fiyat where fiyatID=" + fiyatID).Equals("1"))        //ilgili kayıt varsa silme işlemi yap
                        {
                            mssql.sqlIslem("delete fiyat where fiyatID=" + fiyatID);
                            MessageBox.Show(fiyatID + " Numaralı Kayıt Başarıyla Silindi!");
                        }
                        else
                            MessageBox.Show(fiyatID + " Numaralı Kayıt Bulunamadı!");
                    }
                    else
                        MessageBox.Show("Lütfen Bir Kayıt Seçin!");
                    break;
                default:
                    MessageBox.Show("Lütfen Bir Seçenek Seçin!");
                    break;
            }
            if (check != -1)        //eğer bir işlem yapılmışsa sayfayı yeniden yükle
                fiyatTipiEkle_Load(sender, e);
        }
    }
}
