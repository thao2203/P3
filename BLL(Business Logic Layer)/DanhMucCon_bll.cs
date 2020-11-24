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
    public class DanhMucCon_bll : IDanhMucCon
    {
        DanhMucCon_Dao bv = new DanhMucCon_Dao();
        public IList<danhmuccon> getdanhmuccon()
        {
            return bv.getdanhmuccon("select DANHMUCCON.maDMC,DANHMUCCON.tenDMC,DANHMUCCON.maDM from dbo.DANHMUCCON");
        }
    }
}
