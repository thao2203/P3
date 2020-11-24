using BLL_Business_Logic_Layer_.ServiceInterface;
using DAO_Data_Access_Object_;
using DTO_Data_Transfer_Object_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_Business_Logic_Layer_
{
    public class DanhMuc_bll : IDanhMuc
    {
        DanhMuc_Dao bv = new DanhMuc_Dao();
        public IList<danhmuc> getdanhmuc()
        {
            return bv.getdanhmuc("select DANHMUC.maDM,DANHMUC.tenDM from dbo.DANHMUC");
        }
    }
}
