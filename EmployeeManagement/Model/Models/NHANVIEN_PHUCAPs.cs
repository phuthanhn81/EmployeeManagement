namespace Model.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NHANVIEN_PHUCAPs
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string MANV { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(5)]
        public string MAPC { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NHHPC { get; set; }

        [StringLength(100)]
        public string NOIDUNG { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }

        public virtual PHUCAP PHUCAP { get; set; }
    }
}
