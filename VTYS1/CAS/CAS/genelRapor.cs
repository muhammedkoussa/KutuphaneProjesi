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
    public partial class genelRapor : formlar
    {
        public genelRapor()
        {
            InitializeComponent();
        }

        private void genelRapor_Load(object sender, EventArgs e)
        {

        }

        private void kalanKullanim_rb_CheckedChanged(object sender, EventArgs e)
        {
            if (kalanKullanim_rb.Checked)
                dataGridView.DataSource = mssql.sqlTablo("exec kalan_kullanim");
        }

        private void turHasilat_rb_CheckedChanged(object sender, EventArgs e)
        {
            if (turHasilat_rb.Checked)
            {
                dataGridView.DataSource = mssql.sqlTablo("exec tur_hasilat");
                foreach (DataGridViewRow dgvrow in dataGridView.Rows)
                    dgvrow.Cells["Tür"].Value = mssql.sqlString("select turAdi from tur where turID='" + dgvrow.Cells["Tür"].Value.ToString() + "'");
            }
        }

        private void export_Click(object sender, EventArgs e)
        {
            formlar fm = new formlar();
            fm.raporla(dataGridView);
        }
    }
}
