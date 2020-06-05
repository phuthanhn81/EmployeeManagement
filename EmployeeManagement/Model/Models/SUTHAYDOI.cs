namespace Model.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SUTHAYDOI")]
    public partial class SUTHAYDOI
    {
        [Key]
        [StringLength(10)]
        public string MANV { get; set; }

        [StringLength(5)]
        public string MABP { get; set; }

        public virtual BOPHAN BOPHAN { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}
