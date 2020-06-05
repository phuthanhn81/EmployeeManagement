namespace Model.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HOPDONG")]
    public partial class HOPDONG
    {
        [Key]
        [StringLength(30)]
        public string SOHD { get; set; }

        public DateTime? NGAYKY { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NGAYBD { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NGAYKT { get; set; }

        public string NOIDUNG { get; set; }

        public string GHICHU { get; set; }

        public double? LUONGCB { get; set; }

        public double? PHUCAP_N { get; set; }

        public double? PHUCAP_CV { get; set; }

        public double? KHAUTRU_BH { get; set; }

        [Required]
        [StringLength(10)]
        public string MANV { get; set; }

        [Required]
        [StringLength(10)]
        public string NGUOILAPHD { get; set; }

        public int MALHD { get; set; }

        [Required]
        [StringLength(5)]
        public string TRANGTHAI { get; set; }

        public virtual LOAIHOPDONG LOAIHOPDONG { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }

        public virtual NHANVIEN NHANVIEN1 { get; set; }

        public virtual STATUS STATUS { get; set; }
    }
}
