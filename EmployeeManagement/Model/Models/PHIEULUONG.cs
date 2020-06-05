namespace Model.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHIEULUONG")]
    public partial class PHIEULUONG
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string MANV { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int THANG { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NAM { get; set; }

        public string GHICHU { get; set; }

        public bool? NHAN { get; set; }

        public double? LUONGCB { get; set; }

        public double? PHUCAP_CV { get; set; }

        public double? PHUCAP_TRN { get; set; }

        public double? PHUCAP_DH { get; set; }

        public double? PHUCAP_THN { get; set; }

        public double? PHUCAP_DK { get; set; }

        public double? LUONG_BHXH { get; set; }

        public double? BHXH { get; set; }

        public double? BHTN { get; set; }

        public double? BHYT { get; set; }

        public double? KHAUTRU_BH { get; set; }

        public double? PHUCAP_N { get; set; }

        public double? NGAYCONG { get; set; }

        public double? LUONGAO { get; set; }

        public double? TNCT { get; set; }

        public double? TNTT { get; set; }

        public double? TTNCN { get; set; }

        public double? LUONGTHUC { get; set; }

        public double? LUONGTANGCA { get; set; }

        public double? THUCLANH { get; set; }

        public double? UNGLUONG { get; set; }

        public double? KYLUAT { get; set; }

        public double? KHENTHUONG { get; set; }

        [StringLength(50)]
        public string TRANGTHAI { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}
