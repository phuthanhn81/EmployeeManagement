namespace Model.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NGHI")]
    public partial class NGHI
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string MANV { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "date")]
        public DateTime NGAYBD { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "date")]
        public DateTime NGAYKT { get; set; }

        public string LYDO { get; set; }

        [StringLength(10)]
        public string MALC { get; set; }

        public virtual LOAICONG LOAICONG { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}
