namespace P3_Admin.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSTOMER")]
    public partial class CUSTOMER
    {
        [Key]
        [StringLength(10)]
        public string maCustomer { get; set; }

        [StringLength(100)]
        public string tenCustomer { get; set; }

        [StringLength(100)]
        public string email { get; set; }

        [StringLength(250)]
        public string ghiChu { get; set; }
    }
}
