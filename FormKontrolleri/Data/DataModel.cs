using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormKontrolleri.Data
{
    public class DataModel
    {
        SqlConnection con; SqlCommand cmd;
        public DataModel()
        {
            
        }

        public List<Kategori> GetCategories()
        {
            List<Kategori> ka = new List<Kategori>();
            using (con = new SqlConnection(@"Data Source =.\SQLEXPRESS;Initial Catalog = NORTHWND;Integrated Security = True"))
            {
                cmd = con.CreateCommand();
                cmd.CommandText = "SELECT CategoryID, CategoryName FROM Categories";
                //con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Kategori k = new Kategori()
                    {
                        ID = reader.GetInt32(0),
                        Isim = reader.GetString(1)
                    };
                    ka.Add(k);
                }
                return ka;
            }
        }
    }
}
