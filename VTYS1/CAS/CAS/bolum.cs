using System;
using System.Windows.Forms;

namespace CAS
{
    public partial class bolum : formlar
    {

        public string bolumID;          //veri işlemleri için id nesnesi

        public bolum()
        {
            InitializeComponent();
        }

        private void bolumEkle_Load(object sender, EventArgs e)     //başlangıçtaki tüm ayarların sıfırlanması
        {
            bolumID = "0";
            bolumAdıTxt.Text = string.Empty;
            ekleRadio.Checked = false;
            silRadio.Checked = false;
            guncelleRadio.Checked = false;
            dataGridView1.DataSource = mssql.sqlTablo("select bolumID as 'Bölüm Numarası',bolumAdi as 'Bölüm Adı' ,yetkiTipi as 'Yetki Seviyesi'from bolum ");        //datagridview içini veritabanından dolduran kod
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)        //datagridview üzerinde bir satır seçildiğinde ilgili alanları satırdaki verilerle dolduran kod
        {
            bolumID = dataGridView1.SelectedRows[0].Cells["Bölüm Numarası"].Value.ToString();
            bolumAdıTxt.Text = dataGridView1.SelectedRows[0].Cells["Bölüm Adı"].Value.ToString();
            comboBox1.SelectedIndex= comboBox1.Items.IndexOf(dataGridView1.SelectedRows[0].Cells["Yetki Seviyesi"].Value.ToString());
        }
        public string yetki = string.Empty;
        private void turKaydetBtn_Click(object sender, EventArgs e)       //kaydet butonunda ekle,güncelle,sil işlemleri
        {
            int check = -1;         //check değeri ile seçilen işlem kontrolü
            if (ekleRadio.Checked) check = 0;
            else if (guncelleRadio.Checked) check = 1;
            else if (silRadio.Checked) check = 2;
            switch (check)
            {
                case 0:     //ekleme işlemi 
                    if (!(bolumAdıTxt.Text == ""))     //eklenecek veriler boş bırakılmadıysa ekleme işlemi yap
                    {
                        mssql.sqlIslem("insert into bolum values('"+bolumAdıTxt.Text+"','"+yetki+"')");
                        MessageBox.Show("Yeni Kayıt Başarıyla Eklendi!");
                    }
                    else
                        MessageBox.Show("Lütfen Alanları Boş Bırakmayın!");
                    break;
                case 1:     //güncelleme işlemi
                    if (bolumID != "0")
                    {
                        if (mssql.sqlString("select count(*) from bolum where bolumID=" + bolumID).Equals("1"))      //güncellenecek kayıt bulunuyorsa ilgili verilerle güncelleme yap
                        {
                            mssql.sqlIslem("update bolum set bolumAdi='" + bolumAdıTxt.Text + "','"+yetki+"' where bolumID=" + bolumID);
                            MessageBox.Show(bolumID + " Numaralı Kayıt Başarıyla Güncellendi!");
                        }
                        else
                            MessageBox.Show(bolumID + " Numaralı Kayıt Bulunamadı!");
                    }
                    else
                        MessageBox.Show("Lütfen Bir Kayıt Seçin!");
                    break;
                case 2:     //silme işlemi
                    if (bolumID != "0")
                    {
                        if (mssql.sqlString("select count(*) from bolum where bolumID=" + bolumID).Equals("1"))        //ilgili kayıt varsa silme işlemi yap
                        {
                            mssql.sqlIslem("delete bolum where bolumID=" + bolumID);
                            MessageBox.Show(bolumID + " Numaralı Kayıt Başarıyla Silindi!");
                        }
                        else
                            MessageBox.Show(bolumID + " Numaralı Kayıt Bulunamadı!");
                    }
                    else
                        MessageBox.Show("Lütfen Bir Kayıt Seçin!");
                    break;
                default:
                    MessageBox.Show("Lütfen Bir Seçenek Seçin!");
                    break;
            }
            if (check != -1)        //eğer bir işlem yapılmışsa sayfayı yeniden yükle
                bolumEkle_Load(sender, e);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex==0)
            {
                yetki = "1";
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                yetki = "2";
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                yetki = "3";
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                yetki = "4";
            }
        }
    }
}
