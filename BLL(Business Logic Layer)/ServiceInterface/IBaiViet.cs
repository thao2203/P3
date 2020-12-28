using DTO_Data_Transfer_Object_;
using System.Collections.Generic;
namespace BLL_Business_Logic_Layer_.ServiceInterface
{
    public interface IBaiViet
    {
        //BV theo Loai
        IList<baiViet> getBvTheoLoai(string maLoai);
        void upluotxemview(string maDMC);
        IList<baiViet> getPhanTrangBV(string maLoai,string pagesize);
        //End BV theo Loai
        IList<baiViet> getBaiVietNoiBat();
        IList<baiViet> getBaiVietHot();
        IList<baiViet> getBaiVietMoiNhat();
        IList<baiViet> getBaiVietMoiNhatCT();
        IList<baiViet> getBaiVietNgauNhien();
        IList<baiViet> getBaiVietBanhNgot();
        IList<baiViet> getBaiVietHaNoi();
        IList<baiViet> Search(string tenbaiviet);
        IList<baiViet> getBaiVietYummy();
        IList<baiViet> getBaiVietNgauNhien1();
        IList<baiViet> getBaiVietNgauNhien2();
        IList<baiViet> getBaiVietNgauNhien3();
        IList<baiViet> getBaiVietYummy2();
        IList<baiViet> getBaiVietYummy3();
        IList<baiViet> SearchAllBV(string key);
    }
}
