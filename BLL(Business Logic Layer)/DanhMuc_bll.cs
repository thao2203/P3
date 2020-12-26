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


        public IList<danhmuc> GetmaDM()
        {
            return dm.GetmaDM("select DANHMUC.maDM, DANHMUC.tenDM from dbo.DANHMUC");
        }
    }
}
