using BLL_Business_Logic_Layer_.ServiceInterface;
using DAO_Data_Access_Object_;
using DTO_Data_Transfer_Object_;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_Business_Logic_Layer_
{
    public class DanhMuc_bll : IDanhMuc
    {
        DanhMuc_Dao dm = new DanhMuc_Dao();
        public IList<danhmuc> getdanhmuc()
        {
            return dm.getdanhmuc("select DANHMUC.maDM,DANHMUC.tenDM from dbo.DANHMUC");
        }

        //DataSet ds;
        //public List<danhmuc> Get_maDM()
        //{
        //    ds = dm.Get_maDM();
        //    List<danhmuc> l = new List<danhmuc>();
        //    foreach (DataRow dr in ds.Tables[0].Rows)
        //    {
        //        l.Add(new danhmuc
        //        {
        //            MaDM = dr["MaDM"].ToString(),

        //        });
        //    }
        //    return l;
        //}

        public IList<danhmuc> GetmaDM()
        {
            return dm.GetmaDM("select DANHMUC.maDM, DANHMUC.tenDM from dbo.DANHMUC");
        }
    }
}
