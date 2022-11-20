using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winUniversityPortal.Services
{
    public class DatabaseServices
    {
        SqlConnection con = new SqlConnection(ConfigurationSettings.AppSettings["strConnect"]);
        public void DMLOperations(String QRY)
        {
            SqlCommand obj = new SqlCommand(QRY, con);
            con.Open();
            obj.ExecuteNonQuery();
            con.Close();
        }
        public DataTable tableData(String QRY)
        {
            SqlDataAdapter da = new SqlDataAdapter(QRY, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }
    }
}
