using BLL_Business_Logic_Layer_.ServiceInterface;
using DAO_Data_Access_Object_;
using DTO_Data_Transfer_Object_;
using System;
using System.Collections.Generic;

namespace BLL_Business_Logic_Layer_
{
    public class US_bll : IUS
    {
        US_Dao ud = new US_Dao();
        //phương thức Lấy về tài khoản người dùng với user name và password
        public IList<US> checkUser(string tk, string mk)
        {
            return ud.checkAcount(tk, mk);
        }

       
    }
}
