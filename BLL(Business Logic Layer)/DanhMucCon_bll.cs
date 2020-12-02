using BLL_Business_Logic_Layer_.ServiceInterface;
using DAO_Data_Access_Object_;
using DTO_Data_Transfer_Object_;
using System.Collections.Generic;
using System;
namespace BLL_Business_Logic_Layer_
{
    public class DanhMucCon_bll : IDanhMucCon
    {
        DanhMucCon_Dao bv = new DanhMucCon_Dao();
        public IList<danhmuccon> getdanhmuccon()
        {
            return bv.getdanhmuccon("select DANHMUCCON.maDMC,DANHMUCCON.tenDMC,DANHMUCCON.maDM,DANHMUCCON.luotXem  from dbo.DANHMUCCON");
        }
        public IList<danhmuccon> getdanhmucconYMFooter()
        {
            return bv.getdanhmuccon("select DANHMUCCON.maDMC, DANHMUCCON.tenDMC, DANHMUCCON.maDM,DANHMUCCON.luotXem from dbo.DANHMUCCON where maDM = 'dm01'");
        }
    }
}
