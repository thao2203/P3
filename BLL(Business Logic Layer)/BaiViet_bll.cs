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
            return bv.getbaivietngaunhien12("SELECT Top(3) bv.maBV, dmc.maDMC, bv.tieuDe, bv.hinhAnh, dm.tenDM, dmc.tenDMC FROM (BAIVIET bv INNER JOIN US ON bv.taiKhoanUs = US.taiKhoanUs inner join DANHMUC dm ON bv.maDM=dm.maDM inner join DANHMUCCON dmc on bv.maDMC=dmc.maDMC) Where bv.trangThai='1' Order By NEWID()");
        }
        public IList<baiViet> getBaiVietNgauNhien1()
        {
            return bv.getbaivietngaunhien12("SELECT Top(3) bv.maBV, dmc.maDMC, bv.tieuDe, bv.hinhAnh, dm.tenDM, dmc.tenDMC FROM (BAIVIET bv INNER JOIN US ON bv.taiKhoanUs = US.taiKhoanUs inner join DANHMUC dm ON bv.maDM=dm.maDM inner join DANHMUCCON dmc on bv.maDMC=dmc.maDMC) Where bv.trangThai='1' Order By NEWID()");
        }
        public IList<baiViet> getBaiVietNgauNhien2()
        {
            return bv.getbaivietngaunhien12("SELECT Top(3) bv.maBV, dmc.maDMC, bv.tieuDe, bv.hinhAnh, dm.tenDM, dmc.tenDMC FROM (BAIVIET bv INNER JOIN US ON bv.taiKhoanUs = US.taiKhoanUs inner join DANHMUC dm ON bv.maDM=dm.maDM inner join DANHMUCCON dmc on bv.maDMC=dmc.maDMC) Where bv.trangThai='1' Order By NEWID()");
        }
        public IList<baiViet> getBaiVietNgauNhien3()
        {
            return bv.getbaiviet("SELECT Top(3) bv.*, US.tenUser, dm.tenDM, dmc.tenDMC FROM (BAIVIET bv INNER JOIN US ON bv.taiKhoanUs = US.taiKhoanUs inner join DANHMUC dm ON bv.maDM=dm.maDM inner join DANHMUCCON dmc on bv.maDMC=dmc.maDMC) Where bv.trangThai='1' Order By NEWID()");
        }
        public IList<baiViet> getBaiVietNoiBat()
        {
            return bv.getbaivietnoibat("SELECT Top(3) bv.maBV, bv.maDMC, bv.tieuDe, dm.tenDM, dmc.tenDMC, bv.hinhAnh, ct.luotXem FROM (BAIVIET bv INNER JOIN DANHMUC dm ON bv.maDM=dm.maDM inner join DANHMUCCON dmc on bv.maDMC=dmc.maDMC inner join CTBAIVIET ct on ct.maBV=bv.maBV) Where bv.trangThai='1' Order By ct.luotXem DESC");
        }
        public IList<baiViet> getPhanTrangBV(string maLoai ,string pagesize)
        {
            return bv.getbaiviet("Select bv.*, US.tenUser, dm.tenDM, dmc.tenDMC From BaiViet bv, US, DanhMuc dm, DanhMucCon dmc Where dmc.maDMC = '"+maLoai+ "' and bv.taiKhoanUs=Us.taiKhoanUs and dm.maDM=bv.maDM and dmc.maDMC=bv.maDMC and bv.trangThai='1' order by US.tenUser, dm.tenDM, dmc.tenDMC  desc Offset 0 Rows Fetch next " + pagesize+" rows only");
        }
        public IList<baiViet> getBvTheoLoai( string maLoai)
        {
            return bv.getbaiviet("Select bv.*, US.tenUser, dm.tenDM, dmc.tenDMC From BaiViet bv, US, DanhMuc dm, DanhMucCon dmc Where dmc.maDMC = '" + maLoai+ "' and bv.taiKhoanUs=Us.taiKhoanUs and dm.maDM=bv.maDM and dmc.maDMC=bv.maDMC and bv.trangThai='1' ");
        }
        
        public IList<baiViet> getBaiVietYummy()
        {
            return bv.getbaiviet("Select bv.*, US.tenUser, dm.tenDM, dmc.tenDMC FROM (BAIVIET bv INNER JOIN US ON bv.taiKhoanUs = US.taiKhoanUs inner join DANHMUC dm ON bv.maDM=dm.maDM inner join DANHMUCCON dmc on bv.maDMC=dmc.maDMC) where maBV='bv41' and bv.trangThai='1'");
        }
        public IList<baiViet> getBaiVietYummy2()
        {
            return bv.getbaiviet("Select bv.*, US.tenUser, dm.tenDM, dmc.tenDMC FROM (BAIVIET bv INNER JOIN US ON bv.taiKhoanUs = US.taiKhoanUs inner join DANHMUC dm ON bv.maDM=dm.maDM inner join DANHMUCCON dmc on bv.maDMC=dmc.maDMC) where maBV='bv45' and bv.trangThai='1'");
        }
        public IList<baiViet> getBaiVietYummy3()
        {
            return bv.getbaiviet("Select bv.*, US.tenUser, dm.tenDM, dmc.tenDMC FROM (BAIVIET bv INNER JOIN US ON bv.taiKhoanUs = US.taiKhoanUs inner join DANHMUC dm ON bv.maDM=dm.maDM inner join DANHMUCCON dmc on bv.maDMC=dmc.maDMC) where maBV='bv46' and bv.trangThai='1'");
        }
        public IList<baiViet> getBaiVietHot()
        {
            return bv.getbaiviet("SELECT Top(4) bv.*, US.tenUser, dm.tenDM, dmc.tenDMC FROM (BAIVIET bv INNER JOIN US ON bv.taiKhoanUs = US.taiKhoanUs inner join DANHMUC dm ON bv.maDM=dm.maDM inner join DANHMUCCON dmc on bv.maDMC=dmc.maDMC) WHERE dmc.tenDMC='HOT' and bv.trangThai='1'");
        }
        public IList<baiViet> getBaiVietMoiNhat()
        {
            return bv.getbaiviet("SELECT Top(4) bv.*, US.tenUser, dm.tenDM, dmc.tenDMC FROM (BAIVIET bv INNER JOIN US ON bv.taiKhoanUs = US.taiKhoanUs inner join DANHMUC dm ON bv.maDM=dm.maDM inner join DANHMUCCON dmc on bv.maDMC=dmc.maDMC) Where bv.trangThai='1' order by bv.thoiGianDang DESC");
        }
        public IList<baiViet> getBaiVietBanhNgot()
        {
            return bv.getbaiviet("SELECT Top(6) bv.*, US.tenUser, dm.tenDM, dmc.tenDMC FROM ((BAIVIET bv INNER JOIN US ON bv.taiKhoanUs = US.taiKhoanUs inner join DANHMUC dm ON bv.maDM=dm.maDM inner join DANHMUCCON dmc on bv.maDMC=dmc.maDMC)) WHERE bv.maDMC='dmc02' and bv.trangThai='1'");
        }
        public IList<baiViet> getBaiVietHaNoi()
        {
            return bv.getbaiviet("SELECT Top(6) bv.*, US.tenUser, dm.tenDM, dmc.tenDMC FROM ((BAIVIET bv INNER JOIN US ON bv.taiKhoanUs = US.taiKhoanUs inner join DANHMUC dm ON bv.maDM=dm.maDM inner join DANHMUCCON dmc on bv.maDMC=dmc.maDMC)) WHERE bv.maDMC='dmc14' and bv.trangThai='1'");
        }

        public IList<baiViet> Search(string bviet)
        {
            return bv.getbaiviet(string.Format(@"Select Top(5) bv.*, US.tenUser, dm.tenDM, dmc.tenDMC From BaiViet bv, US, DanhMuc dm, DanhMucCon dmc Where bv.tieuDe like N'%{0}%' and bv.taiKhoanUs=Us.taiKhoanUs and dm.maDM=bv.maDM and dmc.maDMC=bv.maDMC and bv.trangThai='1'", bviet));
        }

        
        public IList<baiViet> getBaiVietMoiNhatCT()
        {
            return bv.getbaiviet("SELECT Top(3) bv.*, US.tenUser, dm.tenDM, dmc.tenDMC FROM (BAIVIET bv INNER JOIN US ON bv.taiKhoanUs = US.taiKhoanUs inner join DANHMUC dm ON bv.maDM=dm.maDM inner join DANHMUCCON dmc on bv.maDMC=dmc.maDMC) Where bv.trangThai='1' order by bv.thoiGianDang DESC");

        }


        // ADmin
        DataSet ds;
        public ListBV Get_Paging_BV(int pageindex, int pagesize)
        {
            ListBV bvlist = new ListBV();
            bvlist = bv.Get_Paging_BV(pageindex, pagesize);
            return bvlist;
        }
        public List<baiViet> Get_BV_byid(string id)
        {
            ds = bv.Get_bv_byid(id);
            List<baiViet> list = new List<baiViet>();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                list.Add(new baiViet
                {
                    MaBV = dr["MaBV"].ToString(),
                    MaDM = dr["MaDM"].ToString(),
                    MaDMC = dr["MaDMC"].ToString(),
                    TaiKhoanUS = dr["TaiKhoanUS"].ToString(),
                    TieuDe = dr["TieuDe"].ToString(),
                    TrangThai = dr["TrangThai"].ToString(),
                    ThoiGianDang = DateTime.Parse(dr["ThoiGianDang"].ToString()),
                    NoiDungCon = dr["NoiDungNho"].ToString(),
                    HinhAnh = dr["HinhAnh"].ToString(),
                });
            }
            return list;
        }

        public string Add_BV(baiViet info)
        {
            string result = string.Empty;
            try
            {
                bv.Add_BV(info);
                result = "Thêm thành công";
            }
            catch (Exception)
            {
                result = "Thêm thất bại";

            }
            return result;
        }
        public string Update_BV(baiViet dt)
        {
            string res = string.Empty;
            try
            {
                bv.Update_BV(dt);
                res = "Cập nhật thành công";
            }
            catch (Exception)
            {
                res = "Cập nhật thất bại";
            }
            return res;
        }
        public string Delete_BV(string id)
        {
            string res = string.Empty;
            try
            {
                bv.Delete_BV(id);
                res = "Xóa thành công";
            }
            catch (Exception)
            {
                res = "Xóa thất bại";
            }
            return res;
        }

    }
}
