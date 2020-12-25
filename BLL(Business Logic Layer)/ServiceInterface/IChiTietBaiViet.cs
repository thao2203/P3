using System;
using DTO_Data_Transfer_Object_;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_Business_Logic_Layer_.ServiceInterface
{
    public interface IChiTietBaiViet
    {
        IList<ChiTietBaiViet> getCTBaiViet(string maBV);
        IList<ChiTietBaiViet> getCTacGia(string maDMC);
        void upview(string mbv);
    }
}
