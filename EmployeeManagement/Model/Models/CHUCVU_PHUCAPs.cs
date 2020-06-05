namespace Model.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CHUCVU_PHUCAPs
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(5)]
        public string MACV { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(5)]
        public string MAPC { get; set; }

        [StringLength(30)]
        public string TENPC { get; set; }

        public double? TIEN { get; set; }

        public virtual CHUCVU CHUCVU { get; set; }

        public virtual PHUCAP PHUCAP { get; set; }
    }
}
