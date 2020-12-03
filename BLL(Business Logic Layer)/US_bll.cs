using BLL_Business_Logic_Layer_.ServiceInterface;
using DAO_Data_Access_Object_;
using DTO_Data_Transfer_Object_;
using System;
using System.Collections.Generic;

namespace BLL_Business_Logic_Layer_
{
    public class US_bll : IUS
    {
        US_Dao bv = new US_Dao();

        public object US { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public IList<US> getLogin()
        {
            throw new NotImplementedException();
        }
    }
}
