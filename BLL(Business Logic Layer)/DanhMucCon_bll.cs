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
        public IList<danhmuccon> getdanhmuccon()
        {
            return dmc.getdanhmuccon("select DANHMUCCON.maDMC,DANHMUCCON.tenDMC,DANHMUCCON.maDM,DANHMUCCON.luotXem  from dbo.DANHMUCCON");
        }
        public IList<danhmuccon> getdanhmucconYMFooter()
        {
            return dmc.getdanhmuccon("select DANHMUCCON.maDMC, DANHMUCCON.tenDMC, DANHMUCCON.maDM,DANHMUCCON.luotXem from dbo.DANHMUCCON where maDM = 'dm01'");
        }

        //admin
        DataSet ds;
        public List<danhmuccon> Get_maDMC()
        {
            ds = dmc.Get_maDMC();
            List<danhmuccon> l = new List<danhmuccon>();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                l.Add(new danhmuccon
                {
                    madmc = dr["MaDMC"].ToString(),
                   
                });
            }
            return l;
        }
    }
}
