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
    public partial class fiyatRapor : formlar
    {
        public fiyatRapor()
        {
            InitializeComponent();
        }

        private void fiyatRapor_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = mssql.sqlTablo("select fiyatID as 'Fiyat Numarası',tip as 'Fiyat Tipi',ucret as 'Fiyat' from fiyat");
        }
        public void dtgfiltrele()
        {
            string tipsql = " like '%" + tipAdıTxt.Text + "%'", fiyatsql = " like '%" + fiyatTxt.Text.Replace(',', '.') + "%'";
            dataGridView1.DataSource = mssql.sqlTablo("select fiyatID as 'Fiyat Numarası',tip as 'Fiyat Tipi',ucret as 'Fiyat' " +
                "from fiyat " +
                "where tip" + tipsql + " and ucret" + fiyatsql + "");
        }

        private void tipAdıTxt_TextChanged(object sender, EventArgs e)
        {
            dtgfiltrele();
        }

        private void fiyatTxt_TextChanged(object sender, EventArgs e)
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
