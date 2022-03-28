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
    public partial class abone : formlar
    {
        public string aboneID;
        public abone()
        {
            InitializeComponent();
        }
        private void abone_Load(object sender, EventArgs e)
        {
            aboneTelTxt.MaxLength = 10;
            aboneID = "0";                                       //id varsayılan olarak 0 
            ekleRadio.Checked = false;
            silRadio.Checked = false;
            guncelleRadio.Checked = false;
            aboneDate.Value = DateTime.Today;
            dataGridView1.DataSource = mssql.sqlTablo("select " +
                "aboneID as 'Abone Numarası'," +     //datagridview içini veritabanından dolduran kod
                "ad as 'Abone Adı'," +
                "soyad as 'Abone Soyadı'," +
                "tel as 'Telefon'," +
                "adres as 'Adres'," +
                "kayitTarih as 'Kayıt Tarihi'," +
                "eMail as 'E-Mail'" +
                "from abone");
        }
        private void aboneKytButon_Click(object sender, EventArgs e)
        {

            int check = -1;         //check değeri ile seçilen işlem kontrolü
            if (ekleRadio.Checked) check = 0;
            else if (guncelleRadio.Checked) check = 1;
            else if (silRadio.Checked) check = 2;
            switch (check)
            {
                case 0:     //ekleme işlemi 
                    if (!(aboneAdıTxt.Text==""||aboneSoyadTxt.Text==""|| aboneTelTxt.Text == ""|| aboneMailTxt.Text == ""|| aboneAdresTxt.Text == ""))     //eklenecek veriler boş bırakılmadıysa ekleme işlemi yap
                    {
                        mssql.sqlIslem("insert into abone values('" + aboneAdıTxt.Text + "','" + aboneSoyadTxt.Text + "','" + aboneTelTxt.Text + "','" + aboneAdresTxt.Text + "','" + aboneDate.Value.ToString("yyyy-MM-dd") + "' , '" + aboneMailTxt.Text + "')");
                        MessageBox.Show("Yeni Kayıt Başarıyla Eklendi!");
                    }
                    else
                        MessageBox.Show("Lütfen Alanları Boş Bırakmayın!");
                    break;
                case 1:     //güncelleme işlemi
                    if (aboneID != "0")
                    {
                        if (mssql.sqlString("select count(*) from abone where aboneID=" + aboneID).Equals("1"))      //güncellenecek kayıt bulunuyorsa ilgili verilerle güncelleme yap
                        {
                            mssql.sqlIslem("update abone set ad='" + aboneAdıTxt.Text + "', soyad='" + aboneSoyadTxt.Text + "', tel='" + aboneTelTxt.Text + "' , adres='" + aboneAdresTxt.Text + "' , kayitTarih='" + aboneDate.Value.ToString("yyyy-MM-dd") + "' , eMail='" + aboneMailTxt.Text + "' where aboneID=" + aboneID);
                            MessageBox.Show(aboneID + " Numaralı Kayıt Başarıyla Güncellendi!");
                        }
                        else
                            MessageBox.Show(aboneID + " Numaralı Kayıt Bulunamadı!");
                    }
                    else
                        MessageBox.Show("Lütfen Bir Kayıt Seçin!");
                    break;
                case 2:     //silme işlemi
                    if (aboneID != "0")
                    {
                        if (mssql.sqlString("select count(*) from abone where aboneID=" + aboneID).Equals("1"))        //ilgili kayıt varsa silme işlemi yap
                        {
                            mssql.sqlIslem("delete abone where aboneID=" + aboneID);
                            MessageBox.Show(aboneID + " Numaralı Kayıt Başarıyla Silindi!");
                        }
                        else
                            MessageBox.Show(aboneID + " Numaralı Kayıt Bulunamadı!");
                    }
                    else
                        MessageBox.Show("Lütfen Bir Kayıt Seçin!");
                    break;
                default:
                    MessageBox.Show("Lütfen Bir Seçenek Seçin!");
                    break;
            }
            if (check != -1)        //eğer bir işlem yapılmışsa sayfayı yeniden yükle
                abone_Load(sender, e);
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            aboneID= dataGridView1.SelectedRows[0].Cells["Abone Numarası"].Value.ToString();
            aboneAdıTxt.Text= dataGridView1.SelectedRows[0].Cells["Abone Adı"].Value.ToString();
            aboneSoyadTxt.Text= dataGridView1.SelectedRows[0].Cells["Abone Soyadı"].Value.ToString();
            aboneTelTxt.Text= dataGridView1.SelectedRows[0].Cells["Telefon"].Value.ToString();
            aboneAdresTxt.Text= dataGridView1.SelectedRows[0].Cells["Adres"].Value.ToString();
            aboneDate.Value = DateTime.Parse(dataGridView1.SelectedRows[0].Cells["Kayıt Tarihi"].Value.ToString());
            aboneMailTxt.Text= dataGridView1.SelectedRows[0].Cells["E-Mail"].Value.ToString();
        }

        private void ekleRadio_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Abone Kayıt İşlemi Kurralları\n" +
                        "1-) Lütfen hiçbir alanı boş bırakmayınız.\n" +
                        "2-) Telefon Numarası 11 hane ve rakamlardan oluşmak zorundadır.\n" +
                        "3-) Adres '....Mahalle ....Sokak ....Cadde' şeklinde olmalıdır.\n" +
                        "4-) E-Mail adresi '.......@...'.'...' şeklinde olmalıdır.\n" +
                        "5-) Kayıt Tarihi, mevcut sistemin tarihinden ileri bir tarihte olamak zorundadır.");
        }

        private void guncelleRadio_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Abone Güncelleme İşlemi Kurralları\n" +
                        "1-) Lütfen hiçbir alanı boş bırakmayınız.\n" +
                        "2-) Telefon Numarası 11 hane ve rakamlardan oluşmak zorundadır.\n" +
                        "3-) Adres '....Mahalle ....Sokak ....Cadde' şeklinde olmalıdır.\n" +
                        "4-) E-Mail adresi '.......@...'.'...' şeklinde olmalıdır.\n" +
                        "5-) Kayıt Tarihi, mevcut sistemin tarihinden ileri bir tarihte olamak zorundadır.");
        }

        private void aboneTelTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
