using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//KHai bao thuoc tinh va phuong thuc khoi tao
namespace DTO_Data_Transfer_Object_
{
    //Xay dung heets cacs bang vaof ddaay
    //Khai báo các object đối tượng của class trong lớp đos
    public class baiViet
    {
        
        //khoi tao gtri ban dau
        public string MaBV { get; set; }
        public string TaiKhoanUS { get; set; }
        public string MaBL { get; set; }
        public string MaDMC { get; set; }
        public string TieuDe { get; set; }
        public string NoiDungCon { get; set; }
        public string HinhAnh { get; set; }
        public string TrangThai { get; set; }
        public DateTime ThoiGianDang { get; set; }
        public string MaDM { get; set; }
        public string tendanhmuccon { get; set; }
        public string tendanhmuc { get; set; }
        public string  tacgia { get; set; }

        public string cusBL { get; set; }
        public string noiDungBL { get; set; }
        public string hinhAnhCus { get; set; }
        public DateTime TgianBL { get; set; }

        public string cusTLBL { get; set; }
        public string noiDungTLBL { get; set; }
        public string hinhAnhCusTLBL { get; set; }
        public DateTime TgianTLBL { get; set; }
    }
}
