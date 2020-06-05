namespace Model.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CHUCVU")]
    public partial class CHUCVU
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CHUCVU()
        {
            BOPHAN_CHUCVUs = new HashSet<BOPHAN_CHUCVUs>();
            CHUCVU_PHUCAPs = new HashSet<CHUCVU_PHUCAPs>();
            NHANVIENs = new HashSet<NHANVIEN>();
            TUYENDUNGs = new HashSet<TUYENDUNG>();
        }

        [Key]
        [StringLength(5)]
        public string MACV { get; set; }

        [StringLength(30)]
        public string TENCV { get; set; }

        public int? GIOIHAN { get; set; }

        public int? PHEPNAM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOPHAN_CHUCVUs> BOPHAN_CHUCVUs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHUCVU_PHUCAPs> CHUCVU_PHUCAPs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NHANVIEN> NHANVIENs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TUYENDUNG> TUYENDUNGs { get; set; }
    }
}
