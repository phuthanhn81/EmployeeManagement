namespace Model.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHUCAP")]
    public partial class PHUCAP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHUCAP()
        {
            CHUCVU_PHUCAPs = new HashSet<CHUCVU_PHUCAPs>();
            NHANVIEN_PHUCAPs = new HashSet<NHANVIEN_PHUCAPs>();
        }

        [Key]
        [StringLength(5)]
        public string MAPC { get; set; }

        [Required]
        [StringLength(30)]
        public string TENPC { get; set; }

        public double TIEN { get; set; }

        public bool? THUE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHUCVU_PHUCAPs> CHUCVU_PHUCAPs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NHANVIEN_PHUCAPs> NHANVIEN_PHUCAPs { get; set; }
    }
}
