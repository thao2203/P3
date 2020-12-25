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
    public class US_Dao
    {
        //admin

        public IList<US> Gettaikhoanus(string sql)
        {
            DataTable dt = new DataTable();
            string cmdtext = sql;
            dt = DataAccessHelper.exc(cmdtext);
            List<US> li = new List<US>();

            foreach (DataRow dr in dt.Rows)
            {
                US bv = new US();
                bv.taiKhoanUS = dr[0].ToString();
                bv.matKhau = dr[1].ToString();
                bv.tenUser = dr[2].ToString();
                bv.chucVu = dr[3].ToString();
                bv.ghiChu = dr[4].ToString();
                bv.hinhAnh = dr[5].ToString();
                li.Add(bv);
            }
            return li;
        }
    }
}
