namespace Model.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TUYENDUNG")]
    public partial class TUYENDUNG
    {
        [Key]
        [Column(Order = 0, TypeName = "date")]
        public DateTime NTD { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NHH { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(5)]
        public string CHUCVU { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(5)]
        public string BOPHAN { get; set; }

        [Required]
        [StringLength(5)]
        public string TRINHDO { get; set; }

        public int? SOLUONG { get; set; }

        public TimeSpan? GIOVAO { get; set; }

        public TimeSpan? GIORA { get; set; }

        [StringLength(100)]
        public string LUONG { get; set; }

        public virtual BOPHAN BOPHAN1 { get; set; }

        public virtual CHUCVU CHUCVU1 { get; set; }

        public virtual TRINHDO TRINHDO1 { get; set; }
    }
}
