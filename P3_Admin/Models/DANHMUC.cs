namespace P3_Admin.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DANHMUC")]
    public partial class DANHMUC
    {
        [Key]
        [StringLength(10)]
        public string maDM { get; set; }

        [StringLength(50)]
        public string tenDM { get; set; }

        [StringLength(250)]
        public string moTa { get; set; }
    }
}
