using DTO_Data_Transfer_Object_;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO_Data_Access_Object_
{
    public class TLbinhLuan_DAO
    {
        public IList<TLbinhLuan> getTLbinhluan(string sql)
        {
            DataTable dt = new DataTable();
            string cmdtext = sql;
            dt = DataAccessHelper.exc(cmdtext);
            List<TLbinhLuan> li = new List<TLbinhLuan>();
            foreach (DataRow dr in dt.Rows)
            {
                TLbinhLuan tb = new TLbinhLuan();
                tb.maTLBL = int.Parse(dr[0].ToString());
                tb.maBL = Convert.ToInt32(dr[1]);
                tb.tenNguoiDang = dr[2].ToString();
                tb.email = dr[3].ToString();
                tb.noiDung = dr[4].ToString();
                tb.thoiGianDang = DateTime.Parse(dr[5].ToString());
                tb.trangThai = dr[6].ToString();

                li.Add(tb);
            }
            return li;
        }
    }
}
