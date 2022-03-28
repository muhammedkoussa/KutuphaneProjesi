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
    public partial class abonelikRapor : formlar
    {
        public abonelikRapor()
        {
            InitializeComponent();
        }

        private void abonelikRapor_Load(object sender, EventArgs e)
        {
            aboneAdıCombo.Items.Add("");
            icerikAdıCombo.Items.Add("");
            foreach (DataRow row in mssql.sqlTablo("select ltrim(str(aboneID))+' - '+ad+' '+soyad from abone").Rows)       //comboBox daki elemanları veritabanından çeken kod
                aboneAdıCombo.Items.Add(row.ItemArray[0].ToString());
            foreach (DataRow row in mssql.sqlTablo("select icerikAdi from icerik").Rows)     //comboBox daki elemanları veritabanından çeken kod
                icerikAdıCombo.Items.Add(row.ItemArray[0].ToString());
            dataGridView1.DataSource = mssql.sqlTablo("select abonelikID as 'Abonelik Numarası'," +     //datagridview içini veritabanından dolduran kod
                "ltrim(str(abone.aboneID))+' - '+ad+' '+soyad as 'Abone'," +
                "icerikAdi as 'İçerik Adı'," +
                "baslangicTarih as 'Başlangıç Tarihi'," +
                "bitisTarih as 'Bitiş Tarihi' " +
                "from abonelik,icerik,abone " +
                "where icerik.icerikID=abonelik.icerikID and abone.aboneID=abonelik.aboneID");
        }

        public void dtgfiltrele()
        {
            string baslangicsql = " like '%' ", bitissql = " like '%' ",adsql= " like '%' ", iceriksql= " like '%' ";
            if (baslangic_cb.Checked)
                baslangicsql = " ='" + baslangıcDate.Value.ToString("yyyy-MM-dd") + "' ";
            if (bitis_cb.Checked)
                bitissql = " ='" + bitisDate.Value.ToString("yyyy-MM-dd") + "' ";
            if (aboneAdıCombo.SelectedItem != "" && aboneAdıCombo.SelectedItem != null)
                adsql = " ='" + aboneAdıCombo.SelectedItem.ToString().Substring(0, aboneAdıCombo.SelectedItem.ToString().IndexOf(" ")) + "' ";
            if (icerikAdıCombo.SelectedItem != "" && icerikAdıCombo.SelectedItem != null)
                iceriksql = " ='" + mssql.sqlString("select icerikID from icerik where icerikAdi = '"+ icerikAdıCombo.SelectedItem + "'") + "' ";
            dataGridView1.DataSource = mssql.sqlTablo("select abonelikID as 'Abonelik Numarası'," +     //datagridview içini veritabanından dolduran kod
                "ltrim(str(abone.aboneID))+' - '+ad+' '+soyad as 'Abone'," +
                "icerikAdi as 'İçerik Adı'," +
                "baslangicTarih as 'Başlangıç Tarihi'," +
                "bitisTarih as 'Bitiş Tarihi' " +
                "from abonelik,icerik,abone " +
                "where icerik.icerikID=abonelik.icerikID and abone.aboneID=abonelik.aboneID and " +
                "abonelik.aboneID"+ adsql +" and " +
                "icerik.icerikID"+ iceriksql +" and " +
                "baslangicTarih"+ baslangicsql +"and " +
                "bitisTarih"+ bitissql +"");
        }

        private void aboneAdıCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtgfiltrele();
        }

        private void icerikAdıCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtgfiltrele();
        }

        private void baslangıcDate_ValueChanged(object sender, EventArgs e)
        {
            dtgfiltrele();
        }

        private void bitisDate_ValueChanged(object sender, EventArgs e)
        {
            dtgfiltrele();
        }

        private void baslangic_cb_CheckedChanged(object sender, EventArgs e)
        {
            dtgfiltrele();
        }

        private void bitis_cb_CheckedChanged(object sender, EventArgs e)
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
