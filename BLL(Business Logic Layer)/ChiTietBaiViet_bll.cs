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
            return bv.getCTBV("Select ct.maCTBV, dm.tenDM, dmc.tenDMC, bv.tieuDe, US.tenUser, bv.thoiGianDang, ct.luotXem, ct.noiDung1, ct.noiDung2, ct.noiDung3, ct.hinhAnh1, ct.hinhAnh2, ct.hinhAnh3, bl.tenNguoiDang, bl.thoiGianDang, bl.noiDung, dmc.maDMC, tb.tenNguoiDang, tb.noiDung, tb.thoiGianDang From CTBAIVIET ct, BAIVIET bv, DANHMUCCON dmc, US, BINHLUAN bl, DANHMUC dm, TLBINHLUAN tb, CUSTOMER cs Where ct.maBV = bv.maBV and bv.maBV=bl.maBV and bv.maDMC=dmc.maDMC and dm.maDM=dmc.maDM and bv.taiKhoanUs=US.taiKhoanUs and bl.maBL=tb.MABL and bv.maBV = '" + maBV+"' ");
        }
        public IList<ChiTietBaiViet> getCTacGia(string maDMC)
        {
            return bv.getCTBV("Select ct.maCTBV, dm.tenDM, dmc.tenDMC, bv.tieuDe, US.tenUser, bv.thoiGianDang, ct.luotXem, ct.noiDung1, ct.noiDung2, ct.noiDung3, ct.hinhAnh1, ct.hinhAnh2, ct.hinhAnh3, bl.tenNguoiDang, bl.thoiGianDang, bl.noiDung, dmc.maDMC, tb.tenNguoiDang, tb.noiDung, tb.thoiGianDang From CTBAIVIET ct, BAIVIET bv, DANHMUCCON dmc, US, BINHLUAN bl, DANHMUC dm, TLBINHLUAN tb, CUSTOMER cs Where ct.maBV = bv.maBV and bv.maBV=bl.maBV and bv.maDMC=dmc.maDMC and dm.maDM=dmc.maDM and bv.taiKhoanUs=US.taiKhoanUs and bl.maBL=tb.MABL and bv.maBV '" + maDMC + "' ");
        }

        public void upview(string mbv)
        {
            DataAccessHelper.execCmd(string.Format("update CTBAIVIET set luotXem= (select luotXem from CTBAIVIET where maBV ='{0}')+1 where  maBV ='{0}'",mbv));
        }
    }
}
