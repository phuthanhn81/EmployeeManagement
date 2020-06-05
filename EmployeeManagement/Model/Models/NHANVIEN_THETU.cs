namespace Model.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NHANVIEN_THETU
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SO { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string MANV { get; set; }

        public int ID { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }

        public virtual THETU THETU { get; set; }
    }
}
