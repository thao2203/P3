namespace P3_Admin.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class US
    {
        [Key]
        [StringLength(10)]
        public string taiKhoanUs { get; set; }

        [StringLength(20)]
        public string matKhau { get; set; }

        [StringLength(100)]
        public string tenUser { get; set; }

        [StringLength(100)]
        public string chucVu { get; set; }

        [StringLength(250)]
        public string ghiChu { get; set; }
    }
}
