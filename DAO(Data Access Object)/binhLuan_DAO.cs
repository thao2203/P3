using DTO_Data_Transfer_Object_;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO_Data_Access_Object_
{
    public class binhLuan_DAO
    {
        public IList<binhLuan> getbinhluan(string sql)
        {
            DataTable dt = new DataTable();
            string cmdtext = sql;
            dt = DataAccessHelper.exc(cmdtext);
            List<binhLuan> li = new List<binhLuan>();
            foreach (DataRow dr in dt.Rows)
            {
                binhLuan bl = new binhLuan();
                bl.mabL = int.Parse(dr[0].ToString());
                bl.tenNGuoiDang = dr[1].ToString();
                bl.maCustomer = int.Parse(dr[2].ToString());
                bl.email = dr[3].ToString();
                bl.noiDung = dr[4].ToString();
                bl.thoiGianDang= DateTime.Parse(dr[5].ToString());
                bl.trangThai = dr[6].ToString();
                bl.maBV = dr[7].ToString();

                li.Add(bl);
            }
            return li;
        }
    }
}
