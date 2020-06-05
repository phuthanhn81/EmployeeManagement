namespace Model.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KYLUAT")]
    public partial class KYLUAT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KYLUAT()
        {
            NHANVIEN_KYLUATs = new HashSet<NHANVIEN_KYLUATs>();
        }

        [Key]
        [StringLength(10)]
        public string MAKL { get; set; }

        [StringLength(50)]
        public string TENKL { get; set; }

        public double? TIEN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NHANVIEN_KYLUATs> NHANVIEN_KYLUATs { get; set; }
    }
}
