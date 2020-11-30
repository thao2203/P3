using DTO_Data_Transfer_Object_;
using System;
using System.Collections.Generic;
using System.Data;

namespace DAO_Data_Access_Object_
{
    public class ChiTietBaiViet_Dao
    {
        public IList<ChiTietBaiViet> getCTBV(string sql)
        {
            DataTable dt = new DataTable();
            string cmdtext = sql;
            dt = DataAccessHelper.exc(cmdtext);
            //string cmdtext = string.Format(@"SELECT bv.*, US.tenUser, dm.tenDM, dmc.tenDMC FROM (BAIVIET bv INNER JOIN US ON bv.taiKhoanUs = US.taiKhoanUs inner join DANHMUC dm ON bv.maDM=dm.maDM inner join DANHMUCCON dmc on bv.maDMC=dmc.maDMC)");
            //dt = DataAccessHelper.exc(cmdtext);
            List<ChiTietBaiViet> li = new List<ChiTietBaiViet>();
            foreach (DataRow dr in dt.Rows)
            {
                ChiTietBaiViet bv = new ChiTietBaiViet();
                bv.maCTBV= dr[0].ToString();
                bv.tenDMC = dr[1].ToString();
                bv.tieuDe = dr[2].ToString();
                bv.tacGia = dr[3].ToString();
                bv.thoiGian = DateTime.Parse(dr[4].ToString());
                bv.luotXem = Convert.ToInt32(dr[5]);
                bv.noiDung1 = dr[6].ToString();
                bv.noiDung2 = dr[7].ToString();
                bv.noiDung3 = dr[8].ToString();
                bv.hinhAnh1 = dr[9].ToString();
                bv.hinhAnh2 = dr[10].ToString();
                bv.hinhAnh3 = dr[11].ToString();
                bv.nguoiBL = dr[12].ToString();
                bv.thoiGianBL = DateTime.Parse(dr[13].ToString());
                bv.noiDungBL = dr[14].ToString();

                li.Add(bv);
            }
            return li;
        }
    }
}