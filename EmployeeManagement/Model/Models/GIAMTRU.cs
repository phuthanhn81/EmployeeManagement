namespace Model.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GIAMTRU")]
    public partial class GIAMTRU
    {
        [Key]
        [StringLength(10)]
        public string MAGT { get; set; }

        [StringLength(50)]
        public string TENGT { get; set; }

        public double? TIEN { get; set; }
    }
}
