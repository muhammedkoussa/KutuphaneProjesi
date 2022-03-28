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
    public partial class bolumRapor : formlar
    {
        public bolumRapor()
        {
            InitializeComponent();
        }

        private void bolumRapor_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = mssql.sqlTablo("select bolumID as 'Bölüm Numarası',bolumAdi as 'Bölüm Adı', yetkiTipi as 'Yetki Seviyesi' from bolum ");
        }

        private void bolumAdıTxt_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = mssql.sqlTablo("select bolumID as 'Bölüm Numarası',bolumAdi as 'Bölüm Adı', yetkiTipi as 'Yetki Seviyesi' from bolum where bolumAdi like '%" + bolumAdıTxt.Text+ "%' and yetkiTipi like '%" + (comboBox1.SelectedIndex + 1).ToString() + "%'");
        }

        private void export_Click(object sender, EventArgs e)
        {
            formlar fm = new formlar();
            fm.raporla(dataGridView1);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = mssql.sqlTablo("select bolumID as 'Bölüm Numarası',bolumAdi as 'Bölüm Adı', yetkiTipi as 'Yetki Seviyesi' from bolum where bolumAdi like '%" + bolumAdıTxt.Text + "%' and yetkiTipi like '%" + (comboBox1.SelectedIndex + 1).ToString() + "%'");
        }
    }
}
