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
    public class DanhMuc_Dao
    {
        public IList<danhmuc> getdanhmuc(string sql)
        {
            DataTable dt = new DataTable();
            string cmdtext = sql;
            dt = DataAccessHelper.exc(cmdtext);
            List<danhmuc> li = new List<danhmuc>();

            foreach (DataRow dr in dt.Rows)
            {
                danhmuc bv = new danhmuc();
                bv.MaDM = dr[0].ToString();
                bv.TenDM = dr[1].ToString();
                li.Add(bv);
            }
            return li;
        }
        public IList<danhmuc> GetmaDM(string sql)
        {
            DataTable dt = new DataTable();
            string cmdtext = sql;
            dt = DataAccessHelper.exc(cmdtext);
            List<danhmuc> li = new List<danhmuc>();

            foreach (DataRow dr in dt.Rows)
            {
                danhmuc bv = new danhmuc();
                bv.MaDM = dr[0].ToString();
                bv.TenDM = dr[1].ToString();
                li.Add(bv);
            }
            return li;
        }
        //admin
    }
}
