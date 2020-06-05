namespace Model.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BOPHAN_CHUCVUs
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(5)]
        public string MABP { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(5)]
        public string MACV { get; set; }

        public double? LUONGCB { get; set; }

        public double? LUONGTV { get; set; }

        public double? PHUCAP { get; set; }

        public double? PHUCAP_TRN { get; set; }

        public double? PHUCAP_DH { get; set; }

        public double? PHUCAP_THN { get; set; }

        public virtual BOPHAN BOPHAN { get; set; }

        public virtual CHUCVU CHUCVU { get; set; }
    }
}
