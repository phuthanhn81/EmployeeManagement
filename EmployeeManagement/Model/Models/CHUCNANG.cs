namespace Model.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CHUCNANG")]
    public partial class CHUCNANG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CHUCNANG()
        {
            NHOM_CHUCNANGs = new HashSet<NHOM_CHUCNANGs>();
        }

        [Key]
        [StringLength(10)]
        public string MACN { get; set; }

        [StringLength(50)]
        public string TENCN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NHOM_CHUCNANGs> NHOM_CHUCNANGs { get; set; }
    }
}
