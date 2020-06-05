namespace Model.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KHAUTRU")]
    public partial class KHAUTRU
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KHAUTRU()
        {
            NHANVIEN_KHAUTRUs = new HashSet<NHANVIEN_KHAUTRUs>();
        }

        [Key]
        [StringLength(10)]
        public string MAKT { get; set; }

        [StringLength(30)]
        public string TENKT { get; set; }

        public double? HESO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NHANVIEN_KHAUTRUs> NHANVIEN_KHAUTRUs { get; set; }
    }
}
