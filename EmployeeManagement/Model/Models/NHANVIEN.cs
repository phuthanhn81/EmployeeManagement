namespace Model.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NHANVIEN")]
    public partial class NHANVIEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NHANVIEN()
        {
            BANGCONGs = new HashSet<BANGCONG>();
            HOPDONGs = new HashSet<HOPDONG>();
            HOPDONGs1 = new HashSet<HOPDONG>();
            NGHIs = new HashSet<NGHI>();
            NHANSUs = new HashSet<NHANSU>();
            PHIEULUONGs = new HashSet<PHIEULUONG>();
            NHANVIEN_KHAUTRUs = new HashSet<NHANVIEN_KHAUTRUs>();
            NHANVIEN_KHENTHUONGs = new HashSet<NHANVIEN_KHENTHUONGs>();
            NHANVIEN_KYLUATs = new HashSet<NHANVIEN_KYLUATs>();
            NHANVIEN_PHUCAPs = new HashSet<NHANVIEN_PHUCAPs>();
            NHANVIEN_THETU = new HashSet<NHANVIEN_THETU>();
            PHEPNAMs = new HashSet<PHEPNAM>();
            PHIEUTANGCAs = new HashSet<PHIEUTANGCA>();
            TANGCAs = new HashSet<TANGCA>();
            TIENUNGs = new HashSet<TIENUNG>();
        }

        [Key]
        [StringLength(10)]
        public string MANV { get; set; }

        [StringLength(50)]
        public string HOTEN { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NGAYSINH { get; set; }

        [StringLength(10)]
        public string PHAI { get; set; }

        [StringLength(10)]
        public string SDT { get; set; }

        [StringLength(12)]
        public string CMND { get; set; }

        [Column(TypeName = "image")]
        public byte[] ANH { get; set; }

        [StringLength(30)]
        public string EMAIL { get; set; }

        [StringLength(100)]
        public string DIACHI { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NGAYVAOLAM { get; set; }

        public double? THAMNIEN { get; set; }

        [Required]
        [StringLength(5)]
        public string MACV { get; set; }

        [Required]
        [StringLength(5)]
        public string MABP { get; set; }

        [Required]
        [StringLength(5)]
        public string MATD { get; set; }

        [Required]
        [StringLength(5)]
        public string TRANGTHAI { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BANGCONG> BANGCONGs { get; set; }

        public virtual BOPHAN BOPHAN { get; set; }

        public virtual CHUCVU CHUCVU { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOPDONG> HOPDONGs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOPDONG> HOPDONGs1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NGHI> NGHIs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NHANSU> NHANSUs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEULUONG> PHIEULUONGs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NHANVIEN_KHAUTRUs> NHANVIEN_KHAUTRUs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NHANVIEN_KHENTHUONGs> NHANVIEN_KHENTHUONGs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NHANVIEN_KYLUATs> NHANVIEN_KYLUATs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NHANVIEN_PHUCAPs> NHANVIEN_PHUCAPs { get; set; }

        public virtual STATUS STATUS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NHANVIEN_THETU> NHANVIEN_THETU { get; set; }

        public virtual TRINHDO TRINHDO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHEPNAM> PHEPNAMs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUTANGCA> PHIEUTANGCAs { get; set; }

        public virtual SUTHAYDOI SUTHAYDOI { get; set; }

        public virtual TAIKHOAN TAIKHOAN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TANGCA> TANGCAs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TIENUNG> TIENUNGs { get; set; }
    }
}
