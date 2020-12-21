namespace P3_Admin.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TLBINHLUAN")]
    public partial class TLBINHLUAN
    {
        [Key]
        [StringLength(10)]
        public string maTLBL { get; set; }

        [StringLength(10)]
        public string MABL { get; set; }

        [StringLength(100)]
        public string tenNguoiDang { get; set; }

        [StringLength(10)]
        public string taiKhoanUs { get; set; }

        [StringLength(10)]
        public string maCustomer { get; set; }

        [StringLength(250)]
        public string email { get; set; }

        public string noiDung { get; set; }

        public DateTime? thoiGianDang { get; set; }

        public bool? trangThai { get; set; }
    }
}
