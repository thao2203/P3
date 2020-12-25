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
                bv.madm = dr[1].ToString();
                bv.tendmc = dr[2].ToString();
                bv.mota = dr[3].ToString();
                bv.luotXem = int.Parse(dr[4].ToString());
                li.Add(bv);
            }
            return li;
        }

        //public IList<danhmuccon> getmadmc(string sql)
        //{
        //    DataTable dt = new DataTable();
        //    string cmdtext = sql;
        //    dt = DataAccessHelper.exc(cmdtext);
        //    List<danhmuccon> li = new List<danhmuccon>();

        //    foreach (DataRow dr in dt.Rows)
        //    {
        //        danhmuccon bv = new danhmuccon();
        //        bv.madmc = dr[0].ToString();
        //        bv.tendmc = dr[1].ToString();
        //        li.Add(bv);
        //    }
        //    return li;
        //}

        //admin
    }
}
