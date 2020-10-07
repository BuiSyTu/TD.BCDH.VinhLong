namespace TD.BCDH.VinhLong.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addmigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CapHoc",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ma = c.String(),
                        Ten = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ChucVu",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ma = c.String(),
                        Ten = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.DanToc",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128),
                        MaDanToc = c.String(),
                        TenDanToc = c.String(),
                        LoaiDanToc = c.String(),
                        TrangThai = c.String(),
                        NgayCapNhat = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.DonVi",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ma = c.String(),
                        Ten = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.DonViGiaoDuc",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128),
                        MaDonVi = c.String(),
                        TenDonVi = c.String(),
                        MaDonViCha = c.String(),
                        TrangThai = c.String(),
                        NgayCapNhat = c.String(),
                        MaToThon = c.String(),
                        MaPhuongXa = c.String(),
                        MaQuanHuyen = c.String(),
                        MaTinhThanh = c.String(),
                        Website = c.String(),
                        Sdt = c.String(),
                        Email = c.String(),
                        LoaiDonVi = c.String(),
                        DonViQuanLy = c.String(),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.GiaoVien",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128),
                        Ma = c.String(),
                        Ten = c.String(),
                        NgaySinh = c.String(),
                        GioiTinh = c.String(),
                        TenGioiTinh = c.String(),
                        SoCMND = c.String(),
                        ChucVu = c.String(),
                        ChuyenNganhDaoTao = c.String(),
                        TrinhDoDaoTao = c.String(),
                        LoaiTrinhDoDaoTao = c.String(),
                        Email = c.String(),
                        Sdt = c.String(),
                        MaTruong = c.String(),
                        TenTruong = c.String(),
                        ToBoMon = c.String(),
                        LoaiCongViec = c.String(),
                        QuocTich = c.String(),
                        DanToc = c.String(),
                        TenDanToc = c.String(),
                        TonGiao = c.String(),
                        TenTonGiao = c.String(),
                        MaTinhThanh = c.String(),
                        TenTinhThanh = c.String(),
                        MaQuanHuyen = c.String(),
                        TenQuanHuyen = c.String(),
                        NgayCapCMT = c.String(),
                        NoiCapCMT = c.String(),
                        QueQuan = c.String(),
                        DiaChiTamTru = c.String(),
                        DiaChiThuongTru = c.String(),
                        TrinhDoDaoTaoCnChinh = c.String(),
                        TrinhDoNgoaiNgu = c.String(),
                        TrinhDoVanHoa = c.String(),
                        NgayVaoNghe = c.String(),
                        LoaiHopDong = c.String(),
                        HeSoLuong = c.String(),
                        BacLuong = c.String(),
                        NgachLuong = c.String(),
                        TrangThai = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.GioiTinh",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ma = c.String(),
                        Ten = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.HocSinh",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NgaySinh = c.String(),
                        GioiTinh = c.String(),
                        DanToc = c.String(),
                        NoiSinh = c.String(),
                        TruongHoc = c.String(),
                        LopHoc = c.String(),
                        TrangThai = c.String(),
                        TenLopHoc = c.String(),
                        KhoiLop = c.String(),
                        SdtBo = c.String(),
                        SdtMe = c.String(),
                        Ma = c.String(),
                        Ten = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.HoSo",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128),
                        SoBienNhan = c.String(),
                        ThuTuc = c.String(),
                        LinhVuc = c.String(),
                        NgayNhan = c.String(),
                        NgayHoanThanh = c.String(),
                        NoiNhan = c.String(),
                        NhanQuaMang = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.KhoiHoc",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ma = c.String(),
                        Ten = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.LinhVuc",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ma = c.String(),
                        Ten = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.LopHoc",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        KhoiHoc = c.String(),
                        MaGvcn = c.String(),
                        PhanBan = c.String(),
                        LopGhep = c.String(),
                        LopChuyen = c.String(),
                        BuoiHoc = c.String(),
                        MaNn1 = c.String(),
                        MaNn2 = c.String(),
                        LopVnen = c.String(),
                        Ma = c.String(),
                        Ten = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PhongHoc",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128),
                        TenPhong = c.String(),
                        TongSo = c.String(),
                        KienCo = c.String(),
                        BanKienCo = c.String(),
                        Tam = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.PhuongXa",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128),
                        MaPhuongXa = c.String(),
                        TenPhuongXa = c.String(),
                        MaQuanHuyen = c.String(),
                        TrangThai = c.String(),
                        NgayCapNhat = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.QuanHuyen",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128),
                        MaQuanHuyen = c.String(),
                        TenQuanHuyen = c.String(),
                        MaTinhThanh = c.String(),
                        TrangThai = c.String(),
                        NgayCapNhat = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.ThuTucHanhChinh",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LinhVuc = c.String(),
                        Ma = c.String(),
                        Ten = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TinhThanh",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128),
                        MaTinhThanh = c.String(),
                        TenTinhThanh = c.String(),
                        TrangThai = c.String(),
                        NgayCapNhat = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.TonGiao",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128),
                        MaTonGiao = c.String(),
                        TenTonGiao = c.String(),
                        TrangThai = c.String(),
                        NgayCapNhat = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.TruongHoc",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128),
                        MaTruongHoc = c.String(),
                        TenTruongHoc = c.String(),
                        TrangThai = c.String(),
                        NgayCapNhat = c.String(),
                        LoaiHinhDaoTao = c.String(),
                        TenLoaiHinhDaoTao = c.String(),
                        ChuanQuocGia = c.String(),
                        LoaiChuanQuocGia = c.String(),
                        MaTthon = c.String(),
                        MaPxa = c.String(),
                        MaQhuyen = c.String(),
                        MaTthanh = c.String(),
                        LoaiHinhTruong = c.String(),
                        TenLoaiHinhTruong = c.String(),
                        VungKhoKhan = c.String(),
                        VungBienGioi = c.String(),
                        ChiBoDang = c.String(),
                        WebSite = c.String(),
                        Sdt = c.String(),
                        Email = c.String(),
                        Fax = c.String(),
                        MaDonVi = c.String(),
                        NgayThanhLap = c.String(),
                        TenHieuTruong = c.String(),
                        SdtHieuTruong = c.String(),
                        DiaChi = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TruongHoc");
            DropTable("dbo.TonGiao");
            DropTable("dbo.TinhThanh");
            DropTable("dbo.ThuTucHanhChinh");
            DropTable("dbo.QuanHuyen");
            DropTable("dbo.PhuongXa");
            DropTable("dbo.PhongHoc");
            DropTable("dbo.LopHoc");
            DropTable("dbo.LinhVuc");
            DropTable("dbo.KhoiHoc");
            DropTable("dbo.HoSo");
            DropTable("dbo.HocSinh");
            DropTable("dbo.GioiTinh");
            DropTable("dbo.GiaoVien");
            DropTable("dbo.DonViGiaoDuc");
            DropTable("dbo.DonVi");
            DropTable("dbo.DanToc");
            DropTable("dbo.ChucVu");
            DropTable("dbo.CapHoc");
        }
    }
}
