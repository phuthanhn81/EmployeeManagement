namespace Model.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHEPNAM")]
    public partial class PHEPNAM
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string MANV { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NAM { get; set; }

        public int? NGAYPHEP { get; set; }

        [StringLength(100)]
        public string GHICHU { get; set; }

        public int? T1 { get; set; }

        public int? T2 { get; set; }

        public int? T3 { get; set; }

        public int? T4 { get; set; }

        public int? T5 { get; set; }

        public int? T6 { get; set; }

        public int? T7 { get; set; }

        public int? T8 { get; set; }

        public int? T9 { get; set; }

        public int? T10 { get; set; }

        public int? T11 { get; set; }

        public int? T12 { get; set; }

        public bool? THAMNIEN { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}
