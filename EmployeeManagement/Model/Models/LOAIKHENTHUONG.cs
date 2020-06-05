namespace Model.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LOAIKHENTHUONG")]
    public partial class LOAIKHENTHUONG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LOAIKHENTHUONG()
        {
            NHANVIEN_KHENTHUONGs = new HashSet<NHANVIEN_KHENTHUONGs>();
        }

        [Key]
        [StringLength(10)]
        public string MALKT { get; set; }

        [StringLength(50)]
        public string TENLKT { get; set; }

        public double? TIEN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NHANVIEN_KHENTHUONGs> NHANVIEN_KHENTHUONGs { get; set; }
    }
}
