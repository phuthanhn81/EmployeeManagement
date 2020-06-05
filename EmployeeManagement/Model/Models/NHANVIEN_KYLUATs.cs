namespace Model.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NHANVIEN_KYLUATs
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string MANV { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string MAKL { get; set; }

        public int? NGAY { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int THANG { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NAM { get; set; }

        [StringLength(1000)]
        public string GHICHU { get; set; }

        public virtual KYLUAT KYLUAT { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}
