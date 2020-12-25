using BLL_Business_Logic_Layer_.ServiceInterface;
using DAO_Data_Access_Object_;
using DTO_Data_Transfer_Object_;
using System;
using System.Collections.Generic;
using System.Data;

namespace BLL_Business_Logic_Layer_
{
    public class US_bll : IUS
    {
        US_Dao ud = new US_Dao();

        //admin

        public IList<US> Gettaikhoanus(US us)
        {
            return ud.Gettaikhoanus(string.Format("select * from dbo.US where taikhoanus='{0}' and matkhau='{1}'",us.taiKhoanUS,us.matKhau));
        }

        public IList<US> getUS()
        {
            return ud.Gettaikhoanus("select * from dbo.US ");
        }
    }
}
