﻿using BLL_Business_Logic_Layer_.ServiceInterface;
using DAO_Data_Access_Object_;
using DTO_Data_Transfer_Object_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_Business_Logic_Layer_
{
    public class TLbinhLuan_BLL : ITLbinhLuan
    {
        TLbinhLuan_DAO tb = new TLbinhLuan_DAO();

        public IList<TLbinhLuan> getTLbinhluan()
        {
            return tb.getTLbinhluan("Select * from TLBINHLUAN where trangThai='1'");
        }

        public string Add_TLBL(TLbinhLuan tlcm)
        {
            string result = string.Empty;
            try
            {
                tb.Add_TLBL(tlcm);
                result = "Thêm thành công";
            }
            catch (Exception)
            {
                result = "Thêm thất bại";

            }
            return result;
        }
    }
}
