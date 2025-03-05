using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    
    class Ketnoi
    {
        SqlConnection conn = new SqlConnection(@"Data Source = LAPTOP-KPTOAC91\SQLEXPRESS;Initial Catalog=Phoi;Integrated Security=True");

        public DataTable ExcuteQuery(string sql)
        {
                DataTable dt = new DataTable();
                try
                {
                    conn.Open();
                }
                catch (Exception e) {
                
                }
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                conn.Close();
                return dt;

        }
        public List<string> Trieuchung(string sql)
        {
            List<string> list = new List<string>();
            try
            {
                conn.Open();
            }
            catch (Exception e)
            {

            }
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                list.Add(read["tentrieuchung"].ToString());
            }
            
            conn.Close();
            return list;
        }
        public List<string> Benh(string sql)
        {
            List<string> list = new List<string>();
            try
            {
                conn.Open();
            }
            catch (Exception e)
            {

            }
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                list.Add(read["tenbenh"].ToString());
            }

            conn.Close();
            return list;
        }

    }
    

}
