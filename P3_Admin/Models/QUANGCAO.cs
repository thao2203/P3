namespace P3_Admin.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("QUANGCAO")]
    public partial class QUANGCAO
    {
        [Key]
        [StringLength(10)]
        public string maQC { get; set; }

        [Column(TypeName = "image")]
        public byte[] hinhAnh { get; set; }

        public string video { get; set; }

        public DateTime? thoiGianDang { get; set; }

        public DateTime? thoiGianKetThuc { get; set; }

        public bool? trangThai { get; set; }

        [StringLength(10)]
        public string taiKhoanUs { get; set; }
    }
}
