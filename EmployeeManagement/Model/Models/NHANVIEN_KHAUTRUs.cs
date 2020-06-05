namespace Model.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NHANVIEN_KHAUTRUs
    {
        [Key]
        [Column(Order = 0, TypeName = "date")]
        public DateTime NHHKT { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string MAKT { get; set; }

        public double? HESO { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(10)]
        public string MANV { get; set; }

        public virtual KHAUTRU KHAUTRU { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}
