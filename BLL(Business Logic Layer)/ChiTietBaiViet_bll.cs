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
    public class ChiTietBaiViet_bll : IChiTietBaiViet
    {
        ChiTietBaiViet_Dao bv = new ChiTietBaiViet_Dao();

        public IList<ChiTietBaiViet> getCTBaiViet(string maBV)
        {
            return bv.getCTBV("  Select ct.maCTBV, dm.tenDM, dmc.tenDMC, bv.tieuDe, US.tenUser, bv.thoiGianDang, ct.luotXem, ct.noiDung1, ct.noiDung2, ct.noiDung3, ct.hinhAnh1, ct.hinhAnh2, ct.hinhAnh3, bl.tenNguoiDang, bl.thoiGianDang, bl.noiDung From CTBAIVIET ct, BAIVIET bv, DANHMUCCON dmc, US, BINHLUAN bl, DANHMUC dm Where ct.maBV = bv.maBV and ct.maBL=bl.maBL and bv.maDMC=dmc.maDMC and dm.maDM=dmc.maDM and bv.taiKhoanUs=US.taiKhoanUs and bv.maBV = '"+maBV+"' ");
        }
    }
}
