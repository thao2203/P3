using DTO_Data_Transfer_Object_;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO_Data_Access_Object_
{
    public class BaiVet_Dao
    {
        public IList<baiViet> getbaiviet(string sql)
        {
            DataTable dt = new DataTable();
            string cmdtext = sql;
            dt = DataAccessHelper.exc(cmdtext);
            //string cmdtext = string.Format(@"SELECT bv.*, US.tenUser, dm.tenDM, dmc.tenDMC FROM (BAIVIET bv INNER JOIN US ON bv.taiKhoanUs = US.taiKhoanUs inner join DANHMUC dm ON bv.maDM=dm.maDM inner join DANHMUCCON dmc on bv.maDMC=dmc.maDMC)");
            //dt = DataAccessHelper.exc(cmdtext);
            List<baiViet> li = new List<baiViet>();
            foreach (DataRow dr in dt.Rows)
            {
                baiViet bv = new baiViet();
                bv.MaBV = dr[0].ToString();
                bv.TaiKhoanUS = dr[1].ToString();
                bv.MaBL = dr[2].ToString();
                bv.MaDMC = dr[9].ToString();
                bv.TieuDe = dr[3].ToString();
                bv.NoiDungCon = dr[4].ToString();
                bv.HinhAnh = dr[8].ToString();
                bv.ThoiGianDang =DateTime.Parse(dr[5].ToString());
                bv.TrangThai = dr[6].ToString();
                bv.MaDM = dr[7].ToString();
                bv.tacgia = dr[10].ToString();
                bv.tendanhmuc = dr[11].ToString();
                bv.tendanhmuccon = dr[12].ToString();
                //bv.luotXem = int.Parse(dr[13].ToString());
                li.Add(bv);
            }
            return li;
        }
    }
}
