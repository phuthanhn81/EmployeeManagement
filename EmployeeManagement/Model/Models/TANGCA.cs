namespace Model.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TANGCA")]
    public partial class TANGCA
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string MANV { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NGAY { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int THANG { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NAM { get; set; }

        public TimeSpan? GIOVAO { get; set; }

        public TimeSpan? GIORA { get; set; }

        public double? SOGIO { get; set; }

        [StringLength(10)]
        public string MALC { get; set; }

        public virtual LOAICA LOAICA { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}
