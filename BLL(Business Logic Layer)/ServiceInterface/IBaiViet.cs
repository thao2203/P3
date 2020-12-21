using DTO_Data_Transfer_Object_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_Business_Logic_Layer_.ServiceInterface
{
    public interface IBaiViet
    {

        IList<baiViet> getBvTheoLoai(string maLoai);
        IList<baiViet> getPhanTrangBV(string maLoai,string pagesize);
        IList<baiViet> getBaiVietNoiBat();
        IList<baiViet> getThongTinBV();
        IList<baiViet> getBaiVietHot();
        IList<baiViet> getBaiVietMoiNhat();
        IList<baiViet> getBaiVietMoiNhatCT();
        IList<baiViet> getBaiVietNgauNhien();
        IList<baiViet> getBaiVietNgauNhien1();
        IList<baiViet> getBaiVietNgauNhien2();
        IList<baiViet> getBaiVietNgauNhien3();
        IList<baiViet> getBaiVietYummy();
        IList<baiViet> getBaiVietYummy2();
        IList<baiViet> getBaiVietYummy3();
        IList<baiViet> getBaiVietBanhNgot();
        IList<baiViet> getBaiVietHaNoi();
        IList<baiViet> Search(string tenbaiviet);

        //admin
        //Areas
    }
}
