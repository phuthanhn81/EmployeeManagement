namespace Model.Models
{
    using System.Data.Entity;

    public partial class QLNS : DbContext
    {
        public QLNS()
            : base("name=QLNS")
        {
            Configuration.LazyLoadingEnabled = false;
        }

        public virtual DbSet<BANGCONG> BANGCONGs { get; set; }
        public virtual DbSet<BOPHAN> BOPHANs { get; set; }
        public virtual DbSet<BOPHAN_CHUCVUs> BOPHAN_CHUCVUs { get; set; }
        public virtual DbSet<CHUCNANG> CHUCNANGs { get; set; }
        public virtual DbSet<CHUCVU> CHUCVUs { get; set; }
        public virtual DbSet<CHUCVU_PHUCAPs> CHUCVU_PHUCAPs { get; set; }
        public virtual DbSet<GIAMTRU> GIAMTRUs { get; set; }
        public virtual DbSet<HOPDONG> HOPDONGs { get; set; }
        public virtual DbSet<KHAUTRU> KHAUTRUs { get; set; }
        public virtual DbSet<KYLUAT> KYLUATs { get; set; }
        public virtual DbSet<LOAICA> LOAICAs { get; set; }
        public virtual DbSet<LOAICONG> LOAICONGs { get; set; }
        public virtual DbSet<LOAIHOPDONG> LOAIHOPDONGs { get; set; }
        public virtual DbSet<LOAIKHENTHUONG> LOAIKHENTHUONGs { get; set; }
        public virtual DbSet<NGHI> NGHIs { get; set; }
        public virtual DbSet<NHANSU> NHANSUs { get; set; }
        public virtual DbSet<NHANVIEN> NHANVIENs { get; set; }
        public virtual DbSet<NHANVIEN_KHAUTRUs> NHANVIEN_KHAUTRUs { get; set; }
        public virtual DbSet<NHANVIEN_KHENTHUONGs> NHANVIEN_KHENTHUONGs { get; set; }
        public virtual DbSet<NHANVIEN_KYLUATs> NHANVIEN_KYLUATs { get; set; }
        public virtual DbSet<NHANVIEN_PHUCAPs> NHANVIEN_PHUCAPs { get; set; }
        public virtual DbSet<NHANVIEN_THETU> NHANVIEN_THETU { get; set; }
        public virtual DbSet<NHOM> NHOMs { get; set; }
        public virtual DbSet<NHOM_CHUCNANGs> NHOM_CHUCNANGs { get; set; }
        public virtual DbSet<PHEPNAM> PHEPNAMs { get; set; }
        public virtual DbSet<PHIEULUONG> PHIEULUONGs { get; set; }
        public virtual DbSet<PHIEUTANGCA> PHIEUTANGCAs { get; set; }
        public virtual DbSet<PHUCAP> PHUCAPs { get; set; }
        public virtual DbSet<STATUS> STATUS { get; set; }
        public virtual DbSet<SUTHAYDOI> SUTHAYDOIs { get; set; }
        public virtual DbSet<TAIKHOAN> TAIKHOANs { get; set; }
        public virtual DbSet<TANGCA> TANGCAs { get; set; }
        public virtual DbSet<TAX> TAXes { get; set; }
        public virtual DbSet<THETU> THETUs { get; set; }
        public virtual DbSet<TIENUNG> TIENUNGs { get; set; }
        public virtual DbSet<TRINHDO> TRINHDOes { get; set; }
        public virtual DbSet<TUYENDUNG> TUYENDUNGs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BANGCONG>()
                .Property(e => e.MANV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<BANGCONG>()
                .Property(e => e.MALC)
                .IsUnicode(false);

            modelBuilder.Entity<BOPHAN>()
                .Property(e => e.MABP)
                .IsUnicode(false);

            modelBuilder.Entity<BOPHAN>()
                .HasMany(e => e.BOPHAN_CHUCVUs)
                .WithRequired(e => e.BOPHAN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOPHAN>()
                .HasMany(e => e.NHANVIENs)
                .WithRequired(e => e.BOPHAN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOPHAN>()
                .HasMany(e => e.TUYENDUNGs)
                .WithRequired(e => e.BOPHAN1)
                .HasForeignKey(e => e.BOPHAN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOPHAN_CHUCVUs>()
                .Property(e => e.MABP)
                .IsUnicode(false);

            modelBuilder.Entity<BOPHAN_CHUCVUs>()
                .Property(e => e.MACV)
                .IsUnicode(false);

            modelBuilder.Entity<CHUCNANG>()
                .Property(e => e.MACN)
                .IsUnicode(false);

            modelBuilder.Entity<CHUCNANG>()
                .HasMany(e => e.NHOM_CHUCNANGs)
                .WithRequired(e => e.CHUCNANG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CHUCVU>()
                .Property(e => e.MACV)
                .IsUnicode(false);

            modelBuilder.Entity<CHUCVU>()
                .HasMany(e => e.BOPHAN_CHUCVUs)
                .WithRequired(e => e.CHUCVU)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CHUCVU>()
                .HasMany(e => e.CHUCVU_PHUCAPs)
                .WithRequired(e => e.CHUCVU)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CHUCVU>()
                .HasMany(e => e.NHANVIENs)
                .WithRequired(e => e.CHUCVU)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CHUCVU>()
                .HasMany(e => e.TUYENDUNGs)
                .WithRequired(e => e.CHUCVU1)
                .HasForeignKey(e => e.CHUCVU)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CHUCVU_PHUCAPs>()
                .Property(e => e.MACV)
                .IsUnicode(false);

            modelBuilder.Entity<CHUCVU_PHUCAPs>()
                .Property(e => e.MAPC)
                .IsUnicode(false);

            modelBuilder.Entity<GIAMTRU>()
                .Property(e => e.MAGT)
                .IsUnicode(false);

            modelBuilder.Entity<HOPDONG>()
                .Property(e => e.SOHD)
                .IsUnicode(false);

            modelBuilder.Entity<HOPDONG>()
                .Property(e => e.MANV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HOPDONG>()
                .Property(e => e.NGUOILAPHD)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HOPDONG>()
                .Property(e => e.TRANGTHAI)
                .IsUnicode(false);

            modelBuilder.Entity<KHAUTRU>()
                .Property(e => e.MAKT)
                .IsUnicode(false);

            modelBuilder.Entity<KHAUTRU>()
                .HasMany(e => e.NHANVIEN_KHAUTRUs)
                .WithRequired(e => e.KHAUTRU)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KYLUAT>()
                .Property(e => e.MAKL)
                .IsUnicode(false);

            modelBuilder.Entity<KYLUAT>()
                .HasMany(e => e.NHANVIEN_KYLUATs)
                .WithRequired(e => e.KYLUAT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LOAICA>()
                .Property(e => e.MALC)
                .IsUnicode(false);

            modelBuilder.Entity<LOAICONG>()
                .Property(e => e.MALC)
                .IsUnicode(false);

            modelBuilder.Entity<LOAIHOPDONG>()
                .Property(e => e.DANG)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LOAIHOPDONG>()
                .HasMany(e => e.HOPDONGs)
                .WithRequired(e => e.LOAIHOPDONG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LOAIKHENTHUONG>()
                .Property(e => e.MALKT)
                .IsUnicode(false);

            modelBuilder.Entity<LOAIKHENTHUONG>()
                .HasMany(e => e.NHANVIEN_KHENTHUONGs)
                .WithRequired(e => e.LOAIKHENTHUONG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NGHI>()
                .Property(e => e.MANV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NGHI>()
                .Property(e => e.MALC)
                .IsUnicode(false);

            modelBuilder.Entity<NHANSU>()
                .Property(e => e.MANV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NHANSU>()
                .Property(e => e.TRANGTHAI)
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.MANV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.SDT)
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.CMND)
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.MACV)
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.MABP)
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.MATD)
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.TRANGTHAI)
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .HasMany(e => e.BANGCONGs)
                .WithRequired(e => e.NHANVIEN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NHANVIEN>()
                .HasMany(e => e.HOPDONGs)
                .WithRequired(e => e.NHANVIEN)
                .HasForeignKey(e => e.MANV)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NHANVIEN>()
                .HasMany(e => e.HOPDONGs1)
                .WithRequired(e => e.NHANVIEN1)
                .HasForeignKey(e => e.NGUOILAPHD)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NHANVIEN>()
                .HasMany(e => e.NGHIs)
                .WithRequired(e => e.NHANVIEN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NHANVIEN>()
                .HasMany(e => e.NHANSUs)
                .WithRequired(e => e.NHANVIEN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NHANVIEN>()
                .HasMany(e => e.PHIEULUONGs)
                .WithRequired(e => e.NHANVIEN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NHANVIEN>()
                .HasMany(e => e.NHANVIEN_KHAUTRUs)
                .WithRequired(e => e.NHANVIEN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NHANVIEN>()
                .HasMany(e => e.NHANVIEN_KHENTHUONGs)
                .WithRequired(e => e.NHANVIEN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NHANVIEN>()
                .HasMany(e => e.NHANVIEN_KYLUATs)
                .WithRequired(e => e.NHANVIEN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NHANVIEN>()
                .HasMany(e => e.NHANVIEN_PHUCAPs)
                .WithRequired(e => e.NHANVIEN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NHANVIEN>()
                .HasMany(e => e.NHANVIEN_THETU)
                .WithRequired(e => e.NHANVIEN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NHANVIEN>()
                .HasMany(e => e.PHEPNAMs)
                .WithRequired(e => e.NHANVIEN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NHANVIEN>()
                .HasMany(e => e.PHIEUTANGCAs)
                .WithRequired(e => e.NHANVIEN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NHANVIEN>()
                .HasOptional(e => e.SUTHAYDOI)
                .WithRequired(e => e.NHANVIEN);

            modelBuilder.Entity<NHANVIEN>()
                .HasOptional(e => e.TAIKHOAN)
                .WithRequired(e => e.NHANVIEN);

            modelBuilder.Entity<NHANVIEN>()
                .HasMany(e => e.TANGCAs)
                .WithRequired(e => e.NHANVIEN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NHANVIEN>()
                .HasMany(e => e.TIENUNGs)
                .WithRequired(e => e.NHANVIEN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NHANVIEN_KHAUTRUs>()
                .Property(e => e.MAKT)
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN_KHAUTRUs>()
                .Property(e => e.MANV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN_KHENTHUONGs>()
                .Property(e => e.MANV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN_KHENTHUONGs>()
                .Property(e => e.MALKT)
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN_KYLUATs>()
                .Property(e => e.MANV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN_KYLUATs>()
                .Property(e => e.MAKL)
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN_PHUCAPs>()
                .Property(e => e.MANV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN_PHUCAPs>()
                .Property(e => e.MAPC)
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN_THETU>()
                .Property(e => e.MANV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NHOM>()
                .Property(e => e.MANHOM)
                .IsUnicode(false);

            modelBuilder.Entity<NHOM>()
                .HasMany(e => e.NHOM_CHUCNANGs)
                .WithRequired(e => e.NHOM)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NHOM_CHUCNANGs>()
                .Property(e => e.MANHOM)
                .IsUnicode(false);

            modelBuilder.Entity<NHOM_CHUCNANGs>()
                .Property(e => e.MACN)
                .IsUnicode(false);

            modelBuilder.Entity<PHEPNAM>()
                .Property(e => e.MANV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PHIEULUONG>()
                .Property(e => e.MANV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PHIEUTANGCA>()
                .Property(e => e.MANV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PHUCAP>()
                .Property(e => e.MAPC)
                .IsUnicode(false);

            modelBuilder.Entity<PHUCAP>()
                .HasMany(e => e.CHUCVU_PHUCAPs)
                .WithRequired(e => e.PHUCAP)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PHUCAP>()
                .HasMany(e => e.NHANVIEN_PHUCAPs)
                .WithRequired(e => e.PHUCAP)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<STATUS>()
                .Property(e => e.TRANGTHAI)
                .IsUnicode(false);

            modelBuilder.Entity<STATUS>()
                .HasMany(e => e.HOPDONGs)
                .WithRequired(e => e.STATUS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<STATUS>()
                .HasMany(e => e.NHANVIENs)
                .WithRequired(e => e.STATUS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<STATUS>()
                .HasMany(e => e.THETUs)
                .WithOptional(e => e.STATUS)
                .HasForeignKey(e => e.TINHTRANG);

            modelBuilder.Entity<SUTHAYDOI>()
                .Property(e => e.MANV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SUTHAYDOI>()
                .Property(e => e.MABP)
                .IsUnicode(false);

            modelBuilder.Entity<TAIKHOAN>()
                .Property(e => e.USERNAME)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TAIKHOAN>()
                .Property(e => e.PASSWORD)
                .IsUnicode(false);

            modelBuilder.Entity<TAIKHOAN>()
                .Property(e => e.MANHOM)
                .IsUnicode(false);

            modelBuilder.Entity<TANGCA>()
                .Property(e => e.MANV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TANGCA>()
                .Property(e => e.MALC)
                .IsUnicode(false);

            modelBuilder.Entity<THETU>()
                .Property(e => e.TINHTRANG)
                .IsUnicode(false);

            modelBuilder.Entity<THETU>()
                .HasMany(e => e.NHANVIEN_THETU)
                .WithRequired(e => e.THETU)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TIENUNG>()
                .Property(e => e.MANV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TRINHDO>()
                .Property(e => e.MATD)
                .IsUnicode(false);

            modelBuilder.Entity<TRINHDO>()
                .HasMany(e => e.NHANVIENs)
                .WithRequired(e => e.TRINHDO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TRINHDO>()
                .HasMany(e => e.TUYENDUNGs)
                .WithRequired(e => e.TRINHDO1)
                .HasForeignKey(e => e.TRINHDO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TUYENDUNG>()
                .Property(e => e.CHUCVU)
                .IsUnicode(false);

            modelBuilder.Entity<TUYENDUNG>()
                .Property(e => e.BOPHAN)
                .IsUnicode(false);

            modelBuilder.Entity<TUYENDUNG>()
                .Property(e => e.TRINHDO)
                .IsUnicode(false);
        }
    }
}
