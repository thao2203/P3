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
    public class binhLuan_BLL : IbinhLuan
    {
        binhLuan_DAO bl = new binhLuan_DAO();
        public IList<binhLuan> getbinhluan(string maBV)
        {
            return bl.getbinhluan("Select * from BINHLUAN where maBV = '" + maBV + "' ");
        }
    }
}
