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
    public partial class aboneRapor : formlar
    {
        public aboneRapor()
        {
            InitializeComponent();
        }

        private void aboneRapor_Load(object sender, EventArgs e)
        {
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

        public void dtgfiltrele()
        {
            string sql = "";
            if (date_cb.Checked)
                sql = aboneDate.Value.ToString("yyyy-MM-dd");
            dataGridView1.DataSource = mssql.sqlTablo("select " +
                "aboneID as 'Abone Numarası'," +     //datagridview içini veritabanından dolduran kod
                "ad as 'Abone Adı'," +
                "soyad as 'Abone Soyadı'," +
                "tel as 'Telefon'," +
                "adres as 'Adres'," +
                "kayitTarih as 'Kayıt Tarihi'," +
                "eMail as 'E-Mail'" +
                "from abone where " +
                "ad like '%" + aboneAdıTxt.Text + "%' and " +
                "soyad like '%" + aboneSoyadTxt.Text + "%' and " +
                "tel like '%" + aboneTelTxt.Text + "%' and " +
                "adres like '%" + aboneAdresTxt.Text + "%' and " +
                "kayitTarih like '%" + sql + "%' and " +
                "eMail like '%" + aboneMailTxt.Text + "%' ");
        }

        private void aboneAdıTxt_TextChanged(object sender, EventArgs e)
        {
            dtgfiltrele();
        }

        private void aboneSoyadTxt_TextChanged(object sender, EventArgs e)
        {
            dtgfiltrele();
        }

        private void aboneTelTxt_TextChanged(object sender, EventArgs e)
        {
            dtgfiltrele();
        }

        private void aboneMailTxt_TextChanged(object sender, EventArgs e)
        {
            dtgfiltrele();
        }

        private void aboneAdresTxt_TextChanged(object sender, EventArgs e)
        {
            dtgfiltrele();
        }

        private void aboneDate_ValueChanged(object sender, EventArgs e)
        {
            dtgfiltrele();
        }

        private void date_cb_CheckedChanged(object sender, EventArgs e)
        {
            dtgfiltrele();
        }

        private void export_Click(object sender, EventArgs e)
        {
            formlar fm = new formlar();
            fm.raporla(dataGridView1);
        }
    }
}
