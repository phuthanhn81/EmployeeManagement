namespace Model.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BOPHAN")]
    public partial class BOPHAN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BOPHAN()
        {
            BOPHAN_CHUCVUs = new HashSet<BOPHAN_CHUCVUs>();
            NHANVIENs = new HashSet<NHANVIEN>();
            SUTHAYDOIs = new HashSet<SUTHAYDOI>();
            TUYENDUNGs = new HashSet<TUYENDUNG>();
        }

        [Key]
        [StringLength(5)]
        public string MABP { get; set; }

        [StringLength(30)]
        public string TENBP { get; set; }

        public TimeSpan? GIOVAO { get; set; }

        public TimeSpan? GIOKTVAO { get; set; }

        public TimeSpan? GIORA { get; set; }

        public TimeSpan? GIOKTRA { get; set; }

        public TimeSpan? GIOVAOTC { get; set; }

        public TimeSpan? GIOKTVAOTC { get; set; }

        public TimeSpan? GIORATC { get; set; }

        public TimeSpan? GIOKTRATC { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOPHAN_CHUCVUs> BOPHAN_CHUCVUs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NHANVIEN> NHANVIENs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SUTHAYDOI> SUTHAYDOIs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TUYENDUNG> TUYENDUNGs { get; set; }
    }
}
