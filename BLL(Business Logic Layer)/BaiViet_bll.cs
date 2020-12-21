using BLL_Business_Logic_Layer_.ServiceInterface;
using DAO_Data_Access_Object_;
using DTO_Data_Transfer_Object_;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_Business_Logic_Layer_
{
    public class BaiViet_bll : IBaiViet
    {
        BaiVet_Dao bv = new BaiVet_Dao();


        public IList<baiViet> getBaiVietNgauNhien()
        {
            return bv.getbaivietngaunhien12("SELECT Top(3) bv.maBV, dmc.maDMC, bv.tieuDe, bv.hinhAnh, dm.tenDM, dmc.tenDMC FROM (BAIVIET bv INNER JOIN US ON bv.taiKhoanUs = US.taiKhoanUs inner join DANHMUC dm ON bv.maDM=dm.maDM inner join DANHMUCCON dmc on bv.maDMC=dmc.maDMC) Order By NEWID()");
        }
        public IList<baiViet> getBaiVietNgauNhien1()
        {
            return bv.getbaivietngaunhien12("SELECT Top(3) bv.maBV, dmc.maDMC, bv.tieuDe, bv.hinhAnh, dm.tenDM, dmc.tenDMC FROM (BAIVIET bv INNER JOIN US ON bv.taiKhoanUs = US.taiKhoanUs inner join DANHMUC dm ON bv.maDM=dm.maDM inner join DANHMUCCON dmc on bv.maDMC=dmc.maDMC) Order By NEWID()");
        }
        public IList<baiViet> getBaiVietNgauNhien2()
        {
            return bv.getbaivietngaunhien12("SELECT Top(3) bv.maBV, dmc.maDMC, bv.tieuDe, bv.hinhAnh, dm.tenDM, dmc.tenDMC FROM (BAIVIET bv INNER JOIN US ON bv.taiKhoanUs = US.taiKhoanUs inner join DANHMUC dm ON bv.maDM=dm.maDM inner join DANHMUCCON dmc on bv.maDMC=dmc.maDMC) Order By NEWID()");
        }
        public IList<baiViet> getBaiVietNgauNhien3()
        {
            return bv.getbaiviet("SELECT Top(3) bv.*, US.tenUser, dm.tenDM, dmc.tenDMC FROM (BAIVIET bv INNER JOIN US ON bv.taiKhoanUs = US.taiKhoanUs inner join DANHMUC dm ON bv.maDM=dm.maDM inner join DANHMUCCON dmc on bv.maDMC=dmc.maDMC) Order By NEWID()");
        }
        public IList<baiViet> getBaiVietNoiBat()
        {
            return bv.getbaivietnoibat_DAO("SELECT Top(3) bv.maBV, bv.maDMC, bv.tieuDe, dm.tenDM, dmc.tenDMC, bv.hinhAnh, ct.luotXem FROM (BAIVIET bv INNER JOIN DANHMUC dm ON bv.maDM=dm.maDM inner join DANHMUCCON dmc on bv.maDMC=dmc.maDMC inner join CTBAIVIET ct on ct.maBV=bv.maBV) Order By ct.luotXem DESC");
        }
        public IList<baiViet> getPhanTrangBV(string maLoai ,string pagesize)
        {
            return bv.getbaiviet("Select bv.*, US.tenUser, dm.tenDM, dmc.tenDMC From BaiViet bv, US, DanhMuc dm, DanhMucCon dmc Where dmc.maDMC = '"+maLoai+ "' and bv.taiKhoanUs=Us.taiKhoanUs and dm.maDM=bv.maDM and dmc.maDMC=bv.maDMC order by US.tenUser, dm.tenDM, dmc.tenDMC  desc Offset 0 Rows Fetch next "+pagesize+" rows only");
        }
        public IList<baiViet> getBvTheoLoai( string maLoai)
        {
            return bv.getbaiviet("Select bv.*, US.tenUser, dm.tenDM, dmc.tenDMC From BaiViet bv, US, DanhMuc dm, DanhMucCon dmc Where dmc.maDMC = '" + maLoai+ "' and bv.taiKhoanUs=Us.taiKhoanUs and dm.maDM=bv.maDM and dmc.maDMC=bv.maDMC ");
        }
        
        public IList<baiViet> getThongTinBV()
        {
            return bv.getbaiviet("");
        }
        public IList<baiViet> getBaiVietYummy()
        {
            return bv.getbaiviet("Select bv.*, US.tenUser, dm.tenDM, dmc.tenDMC FROM (BAIVIET bv INNER JOIN US ON bv.taiKhoanUs = US.taiKhoanUs inner join DANHMUC dm ON bv.maDM=dm.maDM inner join DANHMUCCON dmc on bv.maDMC=dmc.maDMC) where maBV='bv41'");
        }
        public IList<baiViet> getBaiVietYummy2()
        {
            return bv.getbaiviet("Select bv.*, US.tenUser, dm.tenDM, dmc.tenDMC FROM (BAIVIET bv INNER JOIN US ON bv.taiKhoanUs = US.taiKhoanUs inner join DANHMUC dm ON bv.maDM=dm.maDM inner join DANHMUCCON dmc on bv.maDMC=dmc.maDMC) where maBV='bv45'");
        }
        public IList<baiViet> getBaiVietYummy3()
        {
            return bv.getbaiviet("Select bv.*, US.tenUser, dm.tenDM, dmc.tenDMC FROM (BAIVIET bv INNER JOIN US ON bv.taiKhoanUs = US.taiKhoanUs inner join DANHMUC dm ON bv.maDM=dm.maDM inner join DANHMUCCON dmc on bv.maDMC=dmc.maDMC) where maBV='bv46'");
        }
        public IList<baiViet> getBaiVietHot()
        {
            return bv.getbaiviet("SELECT Top(4) bv.*, US.tenUser, dm.tenDM, dmc.tenDMC FROM (BAIVIET bv INNER JOIN US ON bv.taiKhoanUs = US.taiKhoanUs inner join DANHMUC dm ON bv.maDM=dm.maDM inner join DANHMUCCON dmc on bv.maDMC=dmc.maDMC) WHERE dmc.tenDMC='HOT'");
        }
        public IList<baiViet> getBaiVietMoiNhat()
        {
            return bv.getbaiviet("SELECT Top(4) bv.*, US.tenUser, dm.tenDM, dmc.tenDMC FROM (BAIVIET bv INNER JOIN US ON bv.taiKhoanUs = US.taiKhoanUs inner join DANHMUC dm ON bv.maDM=dm.maDM inner join DANHMUCCON dmc on bv.maDMC=dmc.maDMC) order by bv.thoiGianDang DESC");
        }
        public IList<baiViet> getBaiVietBanhNgot()
        {
            return bv.getbaiviet("SELECT Top(6) bv.*, US.tenUser, dm.tenDM, dmc.tenDMC FROM ((BAIVIET bv INNER JOIN US ON bv.taiKhoanUs = US.taiKhoanUs inner join DANHMUC dm ON bv.maDM=dm.maDM inner join DANHMUCCON dmc on bv.maDMC=dmc.maDMC)) WHERE bv.maDMC='dmc02'");
        }
        public IList<baiViet> getBaiVietHaNoi()
        {
            return bv.getbaiviet("SELECT Top(6) bv.*, US.tenUser, dm.tenDM, dmc.tenDMC FROM ((BAIVIET bv INNER JOIN US ON bv.taiKhoanUs = US.taiKhoanUs inner join DANHMUC dm ON bv.maDM=dm.maDM inner join DANHMUCCON dmc on bv.maDMC=dmc.maDMC)) WHERE bv.maDMC='dmc14'");
        }

        public IList<baiViet> Search(string bviet)
        {
            return bv.getbaiviet(string.Format(@"Select Top(5) bv.*, US.tenUser, dm.tenDM, dmc.tenDMC From BaiViet bv, US, DanhMuc dm, DanhMucCon dmc Where bv.tieuDe like '%{0}%' and bv.taiKhoanUs=Us.taiKhoanUs and dm.maDM=bv.maDM and dmc.maDMC=bv.maDMC", bviet));
        }

        
        public IList<baiViet> getBaiVietMoiNhatCT()
        {
            return bv.getbaiviet("SELECT Top(3) bv.*, US.tenUser, dm.tenDM, dmc.tenDMC FROM (BAIVIET bv INNER JOIN US ON bv.taiKhoanUs = US.taiKhoanUs inner join DANHMUC dm ON bv.maDM=dm.maDM inner join DANHMUCCON dmc on bv.maDMC=dmc.maDMC) order by bv.thoiGianDang DESC");

        }

        //public IList<baiViet> Get_Paging_BaiViet(int pageindex, int pagesize)
        //{
        //    return bv.Get_Paging_BaiViet(pageindex, pagesize);
        //}

        // ADmin
        public ListBV Get_Paging_BV(int pageindex, int pagesize)
        {
            ListBV bvlist = new ListBV();
            bvlist = bv.Get_Paging_BV(pageindex, pagesize);
            return bvlist;
        }
    }
}
