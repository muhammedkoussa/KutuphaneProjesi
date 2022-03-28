using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAS
{
    internal class fonksiyon
    {
        public void nav(formlar f)
        {
            MainForm main = Application.OpenForms["MainForm"] as MainForm;
            main.mainPanel.Controls.Clear();
            f.Dock = DockStyle.None;
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            main.mainPanel.Width = f.Width;
            main.mainPanel.Height = f.Height;
            main.mainPanel.Controls.Add(f);
            main.Width = f.Width + 40;
            main.Height = f.Height + 83;
            f.Show();
        } 
        public string kulAdi = string.Empty, kulSifre = string.Empty;
        public void yetki(string a,string b)
        {
            kulAdi = a;
            kulSifre = b;
        }

    }
    
}
