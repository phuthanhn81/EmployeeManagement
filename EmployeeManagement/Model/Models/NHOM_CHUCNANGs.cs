namespace Model.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NHOM_CHUCNANGs
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string MANHOM { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(10)]
        public string MACN { get; set; }

        public virtual CHUCNANG CHUCNANG { get; set; }

        public virtual NHOM NHOM { get; set; }
    }
}
