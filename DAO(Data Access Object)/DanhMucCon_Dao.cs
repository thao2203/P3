using DTO_Data_Transfer_Object_;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO_Data_Access_Object_
{
    public class DanhMucCon_Dao
    {
        public IList<danhmuccon> getdanhmuccon(string sql)
        {
            DataTable dt = new DataTable();
            string cmdtext = sql;
            dt = DataAccessHelper.exc(cmdtext);
            List<danhmuccon> li = new List<danhmuccon>();

            foreach (DataRow dr in dt.Rows)
            {
                danhmuccon bv = new danhmuccon();
                bv.madmc = dr[0].ToString();
                bv.tendmc = dr[1].ToString();
                bv.madm = dr[2].ToString();
                bv.luotXem = int.Parse(dr[3].ToString());
                li.Add(bv);
            }
            return li;
        }

        //admin
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlConnectionString"].ConnectionString);

        public DataSet Get_maDMC()
        {
            string sql = "select * from DanhMucCon";
            SqlCommand com = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
    }
}
