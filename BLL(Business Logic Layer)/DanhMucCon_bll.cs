using BLL_Business_Logic_Layer_.ServiceInterface;
using DAO_Data_Access_Object_;
using DTO_Data_Transfer_Object_;
using System.Collections.Generic;
using System;
using System.Data;

namespace BLL_Business_Logic_Layer_
{
    public class DanhMucCon_bll : IDanhMucCon
    {
        DanhMucCon_Dao dmc = new DanhMucCon_Dao();
        //public IList<danhmuccon> getdanhmuccon()
        //{
        //    return dmc.getdanhmuccon("select DANHMUCCON.maDMC,DANHMUCCON.tenDMC,DANHMUCCON.maDM,DANHMUCCON.luotXem  from dbo.DANHMUCCON");
        //}
        public IList<danhmuccon> getdanhmuccon()
        {
            return dmc.getdanhmuccon("select * from dbo.DANHMUCCON");
        }
        //public IList<danhmuccon> getdanhmucconYMFooter()
        //{
        //    return dmc.getdanhmuccon("select DANHMUCCON.maDMC, DANHMUCCON.tenDMC, DANHMUCCON.maDM,DANHMUCCON.luotXem from dbo.DANHMUCCON where maDM = 'dm01'");
        //}

        public IList<danhmuccon> getDMCbyMaDM(string maDM)
        {
            return dmc.getdanhmuccon("select * from dbo.DANHMUCCON where maDM = '"+ maDM + "'");
        }

        //public IList<danhmuccon> getmaDMC()
        //{
        //    return dmc.getmadmc("select * from dbo.DANHMUCCON");
        //}
    }
}
