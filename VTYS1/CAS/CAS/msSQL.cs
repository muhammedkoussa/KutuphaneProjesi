using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CAS
{

    public class msSQL
    {
        public SqlConnection connection;  //programın açılmasıyla yapılan kullanıcı girişi ile kurulacak bağlantı nesnesi
        public SqlCommand command = new SqlCommand();       //sql komutlarını tutup çalıştıracak nesne
        public SqlDataAdapter adapter;                      //tablo çekmek için aracı nesne


        public msSQL(string server="JAS")
        {
            connection = new SqlConnection("Server=localhost;Database=" + server + ";Trusted_Connection=True;");
            command.Connection = connection;                //command nesnesinin bağlantısını connection olarak atıyor (komutların üzerinde çalışacağı veritabanını belirliyor)
        }

        public msSQL(string user, string password)
        {
            try
            {
                connection = new SqlConnection("Server=localhost;Database=JAS;user ID=" + user + ";password=" + password + ";Trusted_Connection=True;");
                command.Connection = connection;                //command nesnesinin bağlantısını connection olarak atıyor (komutların üzerinde çalışacağı veritabanını belirliyor)
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
                throw;
            }
        }

        public void sqlIslem(String sql)                    //veritabanından veri döndürmeden sadece sql komutlarını çalıştıran fonksiyon
        {
            try
            {
                command.CommandText = sql;
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
                throw;
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                    connection.Close();
            }
        }

        public String sqlString(String sql)                 //veritabanından sql sonucundaki tablonun ilk nesnesini string olarak çeviren fonksiyon
        {
            try
            {
                command.CommandText = sql;
                connection.Open();
                sql = command.ExecuteScalar().ToString();
                connection.Close();
                return sql;
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
                throw;
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                    connection.Close();
            }
        }

        public DataTable sqlTablo(String sql)               //veritabanından sql sonucu oluşan tabloyu çeviren fonksiyon
        {
            try
            {
                DataTable tablo = new DataTable();
                command.CommandText = sql;
                connection.Open();
                adapter = new SqlDataAdapter(command);
                adapter.Fill(tablo);
                connection.Close();
                return tablo;
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
                throw;
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                    connection.Close();
            }
        }

    }
}
