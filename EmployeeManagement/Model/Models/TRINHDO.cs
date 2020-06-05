namespace Model.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TRINHDO")]
    public partial class TRINHDO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TRINHDO()
        {
            NHANVIENs = new HashSet<NHANVIEN>();
            TUYENDUNGs = new HashSet<TUYENDUNG>();
        }

        [Key]
        [StringLength(5)]
        public string MATD { get; set; }

        [StringLength(30)]
        public string TENTD { get; set; }

        public double? HESO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NHANVIEN> NHANVIENs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TUYENDUNG> TUYENDUNGs { get; set; }
    }
}
