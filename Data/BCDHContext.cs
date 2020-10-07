using System.Data.Entity;
using TD.BCDH.VinhLong.Models;
using TD.Core.Api.Mvc;

namespace TD.BCDH.VinhLong.Data
{
    public class BCDHContext : TDCoreDbContext
    {
        public BCDHContext() : base("name=BCDHVinhLongContext")
        {
        }

        #region DbSet
        public DbSet<ChucVu> ChucVu { get; set; }
        public DbSet<DonVi> DonVi { get; set; }
        public DbSet<GioiTinh> GioiTinh { get; set; }
        public DbSet<CapHoc> CapHoc { get; set; }
        public DbSet<DanToc> DanToc { get; set; }
        public DbSet<DonViGiaoDuc> DonViGiaoDuc { get; set; }
        public DbSet<GiaoVien> GiaoVien { get; set; }
        public DbSet<HocSinh> HocSinh { get; set; }
        public DbSet<HoSo> HoSo { get; set; }
        public DbSet<TonGiao> TonGiao { get; set; }
        public DbSet<KhoiHoc> KhoiHoc { get; set; }
        public DbSet<LinhVuc> LinhVuc { get; set; }
        public DbSet<LopHoc> LopHoc { get; set; }
        public DbSet<PhongHoc> PhongHoc { get; set; }
        public DbSet<PhuongXa> PhuongXa { get; set; }
        public DbSet<QuanHuyen> QuanHuyen { get; set; }
        public DbSet<ThuTucHanhChinh> ThuTucHanhChinh { get; set; }
        public DbSet<TinhThanh> TinhThanh { get; set; }
        public DbSet<TruongHoc> TruongHoc { get; set; }

        #endregion

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChucVu>().ToTable("dbo.ChucVu");
            modelBuilder.Entity<DonVi>().ToTable("dbo.DonVi");
            modelBuilder.Entity<GioiTinh>().ToTable("dbo.GioiTinh");
            modelBuilder.Entity<CapHoc>().ToTable("dbo.CapHoc");
            modelBuilder.Entity<DanToc>().ToTable("dbo.DanToc");
            modelBuilder.Entity<DonViGiaoDuc>().ToTable("dbo.DonViGiaoDuc");
            modelBuilder.Entity<GiaoVien>().ToTable("dbo.GiaoVien");
            modelBuilder.Entity<HocSinh>().ToTable("dbo.HocSinh");
            modelBuilder.Entity<HoSo>().ToTable("dbo.HoSo");
            modelBuilder.Entity<TonGiao>().ToTable("dbo.TonGiao");
            modelBuilder.Entity<KhoiHoc>().ToTable("dbo.KhoiHoc");
            modelBuilder.Entity<LinhVuc>().ToTable("dbo.LinhVuc");
            modelBuilder.Entity<LopHoc>().ToTable("dbo.LopHoc");
            modelBuilder.Entity<PhongHoc>().ToTable("dbo.PhongHoc");
            modelBuilder.Entity<PhuongXa>().ToTable("dbo.PhuongXa");
            modelBuilder.Entity<QuanHuyen>().ToTable("dbo.QuanHuyen");
            modelBuilder.Entity<ThuTucHanhChinh>().ToTable("dbo.ThuTucHanhChinh");
            modelBuilder.Entity<TinhThanh>().ToTable("dbo.TinhThanh");
            modelBuilder.Entity<TruongHoc>().ToTable("dbo.TruongHoc");
            base.OnModelCreating(modelBuilder);
        }
    }
}
