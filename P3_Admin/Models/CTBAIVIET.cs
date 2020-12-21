namespace P3_Admin.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CTBAIVIET")]
    public partial class CTBAIVIET
    {
        [Key]
        [StringLength(10)]
        public string maCTBV { get; set; }

        [StringLength(10)]
        public string maBV { get; set; }

        public string noiDung1 { get; set; }

        public string noiDung2 { get; set; }

        public string noiDung3 { get; set; }

        [StringLength(50)]
        public string hinhAnh1 { get; set; }

        [StringLength(50)]
        public string hinhAnh2 { get; set; }

        [StringLength(50)]
        public string hinhAnh3 { get; set; }

        [StringLength(10)]
        public string maBL { get; set; }

        public int? luotXem { get; set; }
    }
}
