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
    public partial class dergiGazateRapor : formlar
    {
        public dergiGazateRapor()
        {
            InitializeComponent();
        }

        private void dergiGazateRapor_Load(object sender, EventArgs e)
        {
            turCombo.Items.Add(""); 
            foreach (DataRow row in mssql.sqlTablo("select turAdi from tur").Rows)       //comboBox daki elemanları veritabanından çeken kod
                turCombo.Items.Add(row.ItemArray[0].ToString());
            dataGridView1.DataSource = mssql.sqlTablo("select icerikID as 'İçerik Numarası',icerikAdi as 'İçerik Adı',turAdi as 'Tür Adı' from icerik,tur where icerik.turID = tur.turID");        //datagridview içini veritabanından dolduran kod

        }

        public void dtgfiltrele()
        {
            string tursql = " like '%' ", iceriksql = " like '%"+icerikAdıTxt.Text+"%' ";
            if (turCombo.SelectedItem != "" && turCombo.SelectedItem != null)
                tursql = " ='" + mssql.sqlString("select turID from tur where turAdi = '" + turCombo.SelectedItem + "'") + "' ";
            dataGridView1.DataSource = mssql.sqlTablo("select icerikID as 'İçerik Numarası',icerikAdi as 'İçerik Adı',tur.turAdi as 'Tür Adı' " +
                "from icerik,tur " +
                "where icerik.turID = tur.turID and " +
                "icerikAdi " + iceriksql + " and " +
                "icerik.turID " + tursql + "");
        }

        private void icerikAdıTxt_TextChanged(object sender, EventArgs e)
        {
            dtgfiltrele();
        }

        private void turCombo_SelectedIndexChanged(object sender, EventArgs e)
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
