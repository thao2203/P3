namespace P3_Admin.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BAIVIET")]
    public partial class BAIVIET
    {
        [Key]
        [StringLength(10)]
        public string maBV { get; set; }

        [StringLength(10)]
        public string taiKhoanUs { get; set; }

        [StringLength(250)]
        public string tieuDe { get; set; }

        public string noiDungNho { get; set; }

        public DateTime? thoiGianDang { get; set; }

        public bool? trangThai { get; set; }

        [StringLength(10)]
        public string maDM { get; set; }

        [StringLength(50)]
        public string hinhAnh { get; set; }

        [StringLength(10)]
        public string maDMC { get; set; }
    }
}
