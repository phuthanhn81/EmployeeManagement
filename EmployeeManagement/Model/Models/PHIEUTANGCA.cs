namespace Model.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHIEUTANGCA")]
    public partial class PHIEUTANGCA
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

        public double? LUONGCB { get; set; }

        public double? LUONGGIO { get; set; }

        public double? SOGIO { get; set; }

        public double? LUONGTANGCA { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}
