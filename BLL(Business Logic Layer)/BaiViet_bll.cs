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
    public class BaiViet_bll : IBaiViet
    {
        BaiVet_Dao bv = new BaiVet_Dao();

        public int checkBaiViet_ID(int bvietID)
        {
            throw new NotImplementedException();
        }

        public int Delete(int bvietID)
        {
            throw new NotImplementedException();
        }
        public IList<baiViet> getBaiVietNgauNhien()
        {
            return bv.getbaiviet("SELECT Top(3) bv.*, US.tenUser, dm.tenDM, dmc.tenDMC FROM (BAIVIET bv INNER JOIN US ON bv.taiKhoanUs = US.taiKhoanUs inner join DANHMUC dm ON bv.maDM=dm.maDM inner join DANHMUCCON dmc on bv.maDMC=dmc.maDMC) Order By NEWID()");
        }
        public IList<baiViet> getBaiVietNgauNhien1()
        {
            return bv.getbaiviet("SELECT Top(3) bv.*, US.tenUser, dm.tenDM, dmc.tenDMC FROM (BAIVIET bv INNER JOIN US ON bv.taiKhoanUs = US.taiKhoanUs inner join DANHMUC dm ON bv.maDM=dm.maDM inner join DANHMUCCON dmc on bv.maDMC=dmc.maDMC) Order By NEWID()");
        }
        public IList<baiViet> getBaiVietNgauNhien2()
        {
            return bv.getbaiviet("SELECT Top(3) bv.*, US.tenUser, dm.tenDM, dmc.tenDMC FROM (BAIVIET bv INNER JOIN US ON bv.taiKhoanUs = US.taiKhoanUs inner join DANHMUC dm ON bv.maDM=dm.maDM inner join DANHMUCCON dmc on bv.maDMC=dmc.maDMC) Order By NEWID()");
        }
        public IList<baiViet> getBaiVietNgauNhien3()
        {
            return bv.getbaiviet("SELECT Top(3) bv.*, US.tenUser, dm.tenDM, dmc.tenDMC FROM (BAIVIET bv INNER JOIN US ON bv.taiKhoanUs = US.taiKhoanUs inner join DANHMUC dm ON bv.maDM=dm.maDM inner join DANHMUCCON dmc on bv.maDMC=dmc.maDMC) Order By NEWID()");
        }
        public IList<baiViet> getBaiVietNoiBat()
        {
            return bv.getbaiviet("SELECT Top(3) bv.*, US.tenUser, dm.tenDM, dmc.tenDMC FROM (BAIVIET bv INNER JOIN US ON bv.taiKhoanUs = US.taiKhoanUs inner join DANHMUC dm ON bv.maDM=dm.maDM inner join DANHMUCCON dmc on bv.maDMC=dmc.maDMC) Order By NEWID()");
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

        public BaiViet_bll getBaiViet_ID(int bvietID)
        {
            throw new NotImplementedException();
        }

        public int getBaiViet_ID_Last()
        {
            throw new NotImplementedException();
        }

        public int Insert(baiViet bviet)
        {
            throw new NotImplementedException();
        }

        public IList<baiViet> Search(string bviet)
        {
            return bv.getbaiviet(string.Format(@"Select bv.*, US.tenUser, dm.tenDM, dmc.tenDMC From BaiViet bv, US, DanhMuc dm, DanhMucCon dmc Where bv.tieuDe like '%{0}%' and bv.taiKhoanUs=Us.taiKhoanUs and dm.maDM=bv.maDM and dmc.maDMC=bv.maDMC", bviet));
        }

        public int Update(baiViet bviet)
        {
            throw new NotImplementedException();
        }

        public IList<baiViet> getDSBV()
        {
            return bv.getbaiviet("Select BV.*, US.tenUser, dm.tenDM, dmc.tenDMC From dbo.BAIVIET BV Left join dbo.US US On BV.taiKhoanUs = US.taiKhoanUs left join dbo.DANHMUC DM ON BV.maDM = DM.maDM left join dbo.DANHMUCCON DMC ON BV.maDMC = DMC.maDMC");
        }
    }
}
