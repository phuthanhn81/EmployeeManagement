namespace Model.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TAX")]
    public partial class TAX
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BAC { get; set; }

        public double? MIN { get; set; }

        public double? MAX { get; set; }

        public double? THUE { get; set; }
    }
}
