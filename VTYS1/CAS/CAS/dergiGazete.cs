using System;
using System.Data;
using System.Windows.Forms;

namespace CAS
{
    public partial class dergiGazete : formlar
    {

        public string icerikID;          //veri işlemleri için id nesnesi

        public dergiGazete()
        {
            InitializeComponent();
        }

        private void dergiGazeteEkle_Load(object sender, EventArgs e)     //başlangıçtaki tüm ayarların sıfırlanması
        {
            icerikID = "0";
            ekleRadio.Checked = false;
            silRadio.Checked = false;
            guncelleRadio.Checked = false;
            icerikAdıTxt.Text = "";
            turCombo.SelectedIndex = -1;
            turCombo.Text = "";
            turCombo.Items.Clear();
            foreach (DataRow row in mssql.sqlTablo("select turAdi from tur").Rows)       //comboBox daki elemanları veritabanından çeken kod
                turCombo.Items.Add(row.ItemArray[0].ToString());
            dataGridView1.DataSource = mssql.sqlTablo("select icerikID as 'İçerik Numarası',icerikAdi as 'İçerik Adı',turAdi as 'Tür Adı' from icerik,tur where icerik.turID = tur.turID");        //datagridview içini veritabanından dolduran kod
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)        //datagridview üzerinde bir satır seçildiğinde ilgili alanları satırdaki verilerle dolduran kod
        {
            icerikID = dataGridView1.SelectedRows[0].Cells["İçerik Numarası"].Value.ToString();
            icerikAdıTxt.Text = dataGridView1.SelectedRows[0].Cells["İçerik Adı"].Value.ToString();
            turCombo.SelectedIndex = turCombo.Items.IndexOf(dataGridView1.SelectedRows[0].Cells["Tür Adı"].Value.ToString());
        }

        private void icerikKaydetBtn_Click(object sender, EventArgs e)       //kaydet butonunda ekle,güncelle,sil işlemleri
        {
            int check = -1;         //check değeri ile seçilen işlem kontrolü
            if (ekleRadio.Checked) check = 0;
            else if (guncelleRadio.Checked) check = 1;
            else if (silRadio.Checked) check = 2;
            switch(check)
            {
                case 0:     //ekleme işlemi 
                    if (!(turCombo.SelectedIndex == -1 || icerikAdıTxt.Text==""))     //eklenecek veriler boş bırakılmadıysa ekleme işlemi yap
                    {
                        mssql.sqlIslem("insert into icerik values('" + mssql.sqlString("select turID from tur where turAdi='" + turCombo.SelectedItem + "'") + "','" + icerikAdıTxt.Text + "')");
                        MessageBox.Show("Yeni Kayıt Başarıyla Eklendi!");
                    }
                    else
                        MessageBox.Show("Lütfen Alanları Boş Bırakmayın!");
                    break;
                case 1:     //güncelleme işlemi
                    if (icerikID!="0")
                    {
                        if (mssql.sqlString("select count(*) from icerik where icerikID=" + icerikID).Equals("1"))      //güncellenecek kayıt bulunuyorsa ilgili verilerle güncelleme yap
                        {
                            mssql.sqlIslem("update icerik set icerikAdi='" + icerikAdıTxt.Text + "', turID='" + mssql.sqlString("select turID from tur where turAdi='" + turCombo.SelectedItem + "'") + "' where icerikID=" + icerikID);
                            MessageBox.Show(icerikID + " Numaralı Kayıt Başarıyla Güncellendi!");
                        }
                        else
                            MessageBox.Show(icerikID + " Numaralı Kayıt Bulunamadı!");
                    }
                    else
                        MessageBox.Show("Lütfen Bir Kayıt Seçin!");
                    break;
                case 2:     //silme işlemi
                    if (icerikID!="0")
                    {
                        if (mssql.sqlString("select count(*) from icerik where icerikID=" + icerikID).Equals("1"))        //ilgili kayıt varsa silme işlemi yap
                        {
                            mssql.sqlIslem("delete icerik where icerikID=" + icerikID);
                            MessageBox.Show(icerikID + " Numaralı Kayıt Başarıyla Silindi!");
                        }
                        else
                            MessageBox.Show(icerikID + " Numaralı Kayıt Bulunamadı!");
                    }
                    else
                        MessageBox.Show("Lütfen Bir Kayıt Seçin!");
                    break;
                default:
                    MessageBox.Show("Lütfen Bir Seçenek Seçin!");
                    break;
            }
            if(check!=-1)        //eğer bir işlem yapılmışsa sayfayı yeniden yükle
                dergiGazeteEkle_Load(sender, e);
        }
    }
}
