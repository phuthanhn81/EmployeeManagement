namespace Model.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TAIKHOAN")]
    public partial class TAIKHOAN
    {
        [Key]
        [StringLength(10)]
        public string USERNAME { get; set; }

        public string PASSWORD { get; set; }

        [StringLength(10)]
        public string MANHOM { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }

        public virtual NHOM NHOM { get; set; }
    }
}
