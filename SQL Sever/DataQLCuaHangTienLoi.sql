USE [master]
GO
/****** Object:  Database [QuanLyCuaHangTienLoi]    Script Date: 12/11/2022 11:36:52 AM ******/
CREATE DATABASE [QuanLyCuaHangTienLoi]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuanLyCuaHangTienLoi', FILENAME = N'E:\TaiLieuHocTap\Đồ Án\BuiThanhTy_TangThuyVy_DH19TIN01_DoAn2\SQL Sever\QuanLyCuaHangTienLoi.mdf' , SIZE = 3264KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QuanLyCuaHangTienLoi_log', FILENAME = N'E:\TaiLieuHocTap\Đồ Án\BuiThanhTy_TangThuyVy_DH19TIN01_DoAn2\SQL Sever\QuanLyCuaHangTienLoi_log.ldf' , SIZE = 816KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QuanLyCuaHangTienLoi] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLyCuaHangTienLoi].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLyCuaHangTienLoi] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLyCuaHangTienLoi] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLyCuaHangTienLoi] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLyCuaHangTienLoi] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLyCuaHangTienLoi] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLyCuaHangTienLoi] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QuanLyCuaHangTienLoi] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLyCuaHangTienLoi] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLyCuaHangTienLoi] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLyCuaHangTienLoi] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLyCuaHangTienLoi] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLyCuaHangTienLoi] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLyCuaHangTienLoi] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLyCuaHangTienLoi] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLyCuaHangTienLoi] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QuanLyCuaHangTienLoi] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLyCuaHangTienLoi] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLyCuaHangTienLoi] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLyCuaHangTienLoi] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLyCuaHangTienLoi] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLyCuaHangTienLoi] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLyCuaHangTienLoi] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLyCuaHangTienLoi] SET RECOVERY FULL 
GO
ALTER DATABASE [QuanLyCuaHangTienLoi] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLyCuaHangTienLoi] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLyCuaHangTienLoi] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuanLyCuaHangTienLoi] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuanLyCuaHangTienLoi] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [QuanLyCuaHangTienLoi] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'QuanLyCuaHangTienLoi', N'ON'
GO
USE [QuanLyCuaHangTienLoi]
GO
/****** Object:  Table [dbo].[ChiTietHoaDon]    Script Date: 12/11/2022 11:36:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietHoaDon](
	[idCTHD] [int] IDENTITY(1,1) NOT NULL,
	[idHD] [int] NOT NULL,
	[idSP] [int] NOT NULL,
	[SoLuong] [float] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idCTHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DangNhap]    Script Date: 12/11/2022 11:36:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DangNhap](
	[TaiKhoan] [nvarchar](100) NOT NULL,
	[MatKhau] [nvarchar](1000) NOT NULL,
	[LoaiTK] [int] NOT NULL,
	[idNV] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[TaiKhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DonVi]    Script Date: 12/11/2022 11:36:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DonVi](
	[idDV] [int] IDENTITY(1,1) NOT NULL,
	[TenDV] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idDV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GiamGia]    Script Date: 12/11/2022 11:36:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GiamGia](
	[idGG] [int] IDENTITY(1,1) NOT NULL,
	[idSP] [int] NOT NULL,
	[PhanTramGiamGia] [float] NOT NULL,
	[NgayKT] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[idGG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 12/11/2022 11:36:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[idHD] [int] IDENTITY(1,1) NOT NULL,
	[NgayBan] [date] NOT NULL,
	[TongTien] [float] NOT NULL,
	[idNV] [int] NULL,
	[idKH] [int] NULL,
	[TinhTrang] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 12/11/2022 11:36:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[idKH] [int] IDENTITY(1,1) NOT NULL,
	[TenKH] [nvarchar](100) NOT NULL,
	[SDTKH] [varchar](15) NOT NULL,
	[DiaChiKH] [nvarchar](100) NOT NULL,
	[EmailKH] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kho]    Script Date: 12/11/2022 11:36:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kho](
	[idK] [int] IDENTITY(1,1) NOT NULL,
	[idNCC] [int] NOT NULL,
	[idSP] [int] NOT NULL,
	[NgayNhap] [date] NOT NULL,
	[SoLuong] [float] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiSanPham]    Script Date: 12/11/2022 11:36:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiSanPham](
	[idLSP] [int] IDENTITY(1,1) NOT NULL,
	[TenLSP] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idLSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhaCungCap]    Script Date: 12/11/2022 11:36:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaCungCap](
	[idNCC] [int] IDENTITY(1,1) NOT NULL,
	[TenNCC] [nvarchar](100) NOT NULL,
	[SDTNCC] [varchar](15) NOT NULL,
	[DiaChiNCC] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idNCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 12/11/2022 11:36:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[idNV] [int] IDENTITY(1,1) NOT NULL,
	[TenNV] [nvarchar](100) NOT NULL,
	[NgaySinhNV] [datetime] NOT NULL,
	[DiaChiNV] [nvarchar](100) NOT NULL,
	[SDTNV] [varchar](15) NOT NULL,
	[ChucVu] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SanPham]    Script Date: 12/11/2022 11:36:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SanPham](
	[idSP] [int] IDENTITY(1,1) NOT NULL,
	[idLSP] [int] NOT NULL,
	[idDV] [int] NOT NULL,
	[TenSP] [nvarchar](100) NOT NULL,
	[DonGia] [float] NOT NULL,
	[SoLuong] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[idSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[ChiTietHoaDon] ON 

INSERT [dbo].[ChiTietHoaDon] ([idCTHD], [idHD], [idSP], [SoLuong]) VALUES (1, 1, 1, 100)
INSERT [dbo].[ChiTietHoaDon] ([idCTHD], [idHD], [idSP], [SoLuong]) VALUES (3, 1, 2, 1)
INSERT [dbo].[ChiTietHoaDon] ([idCTHD], [idHD], [idSP], [SoLuong]) VALUES (1008, 2, 2, 1)
INSERT [dbo].[ChiTietHoaDon] ([idCTHD], [idHD], [idSP], [SoLuong]) VALUES (1015, 2, 1, 100)
INSERT [dbo].[ChiTietHoaDon] ([idCTHD], [idHD], [idSP], [SoLuong]) VALUES (1018, 3, 2, 1)
INSERT [dbo].[ChiTietHoaDon] ([idCTHD], [idHD], [idSP], [SoLuong]) VALUES (1027, 3, 1, 100)
INSERT [dbo].[ChiTietHoaDon] ([idCTHD], [idHD], [idSP], [SoLuong]) VALUES (1031, 13, 5, 2)
INSERT [dbo].[ChiTietHoaDon] ([idCTHD], [idHD], [idSP], [SoLuong]) VALUES (1035, 17, 1, 100)
INSERT [dbo].[ChiTietHoaDon] ([idCTHD], [idHD], [idSP], [SoLuong]) VALUES (1036, 18, 1, 100)
INSERT [dbo].[ChiTietHoaDon] ([idCTHD], [idHD], [idSP], [SoLuong]) VALUES (1037, 18, 2, 1)
INSERT [dbo].[ChiTietHoaDon] ([idCTHD], [idHD], [idSP], [SoLuong]) VALUES (1038, 18, 5, 2)
INSERT [dbo].[ChiTietHoaDon] ([idCTHD], [idHD], [idSP], [SoLuong]) VALUES (1039, 19, 1, 100)
INSERT [dbo].[ChiTietHoaDon] ([idCTHD], [idHD], [idSP], [SoLuong]) VALUES (1040, 19, 2, 2)
INSERT [dbo].[ChiTietHoaDon] ([idCTHD], [idHD], [idSP], [SoLuong]) VALUES (1041, 19, 5, 2)
INSERT [dbo].[ChiTietHoaDon] ([idCTHD], [idHD], [idSP], [SoLuong]) VALUES (1042, 20, 2, 1)
INSERT [dbo].[ChiTietHoaDon] ([idCTHD], [idHD], [idSP], [SoLuong]) VALUES (1046, 24, 1, 100)
INSERT [dbo].[ChiTietHoaDon] ([idCTHD], [idHD], [idSP], [SoLuong]) VALUES (1047, 24, 2, 1)
INSERT [dbo].[ChiTietHoaDon] ([idCTHD], [idHD], [idSP], [SoLuong]) VALUES (1048, 24, 5, 1)
INSERT [dbo].[ChiTietHoaDon] ([idCTHD], [idHD], [idSP], [SoLuong]) VALUES (1049, 25, 2, 50)
INSERT [dbo].[ChiTietHoaDon] ([idCTHD], [idHD], [idSP], [SoLuong]) VALUES (1050, 25, 1, 100)
SET IDENTITY_INSERT [dbo].[ChiTietHoaDon] OFF
GO
INSERT [dbo].[DangNhap] ([TaiKhoan], [MatKhau], [LoaiTK], [idNV]) VALUES (N'nghia', N'0', 0, 3)
INSERT [dbo].[DangNhap] ([TaiKhoan], [MatKhau], [LoaiTK], [idNV]) VALUES (N'tri', N'0', 0, 2)
INSERT [dbo].[DangNhap] ([TaiKhoan], [MatKhau], [LoaiTK], [idNV]) VALUES (N'ty', N'0', 1, 1)
GO
SET IDENTITY_INSERT [dbo].[DonVi] ON 

INSERT [dbo].[DonVi] ([idDV], [TenDV]) VALUES (1, N'VinaMilk')
INSERT [dbo].[DonVi] ([idDV], [TenDV]) VALUES (3, N'Gói')
INSERT [dbo].[DonVi] ([idDV], [TenDV]) VALUES (4, N'Hộp')
SET IDENTITY_INSERT [dbo].[DonVi] OFF
GO
SET IDENTITY_INSERT [dbo].[GiamGia] ON 

INSERT [dbo].[GiamGia] ([idGG], [idSP], [PhanTramGiamGia], [NgayKT]) VALUES (1004, 1, 10, CAST(N'2022-11-26T00:00:00.000' AS DateTime))
INSERT [dbo].[GiamGia] ([idGG], [idSP], [PhanTramGiamGia], [NgayKT]) VALUES (1005, 2, 11, CAST(N'2022-11-26T00:00:00.000' AS DateTime))
INSERT [dbo].[GiamGia] ([idGG], [idSP], [PhanTramGiamGia], [NgayKT]) VALUES (1007, 5, 13, CAST(N'2022-11-26T00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[GiamGia] OFF
GO
SET IDENTITY_INSERT [dbo].[HoaDon] ON 

INSERT [dbo].[HoaDon] ([idHD], [NgayBan], [TongTien], [idNV], [idKH], [TinhTrang]) VALUES (1, CAST(N'2022-11-11' AS Date), 21000, 2, 1, 1)
INSERT [dbo].[HoaDon] ([idHD], [NgayBan], [TongTien], [idNV], [idKH], [TinhTrang]) VALUES (2, CAST(N'2022-11-10' AS Date), 18900, 3, 2, 1)
INSERT [dbo].[HoaDon] ([idHD], [NgayBan], [TongTien], [idNV], [idKH], [TinhTrang]) VALUES (3, CAST(N'2022-11-21' AS Date), 21000, 1, 4, 1)
INSERT [dbo].[HoaDon] ([idHD], [NgayBan], [TongTien], [idNV], [idKH], [TinhTrang]) VALUES (13, CAST(N'2022-11-26' AS Date), 6960, 1, 8, 1)
INSERT [dbo].[HoaDon] ([idHD], [NgayBan], [TongTien], [idNV], [idKH], [TinhTrang]) VALUES (16, CAST(N'2022-11-26' AS Date), 21040, 1, 8, 1)
INSERT [dbo].[HoaDon] ([idHD], [NgayBan], [TongTien], [idNV], [idKH], [TinhTrang]) VALUES (17, CAST(N'2022-11-26' AS Date), 9000, 1, 8, 1)
INSERT [dbo].[HoaDon] ([idHD], [NgayBan], [TongTien], [idNV], [idKH], [TinhTrang]) VALUES (18, CAST(N'2022-11-26' AS Date), 34479, 1, 14, 1)
INSERT [dbo].[HoaDon] ([idHD], [NgayBan], [TongTien], [idNV], [idKH], [TinhTrang]) VALUES (19, CAST(N'2022-12-01' AS Date), 49620, 1, 14, 1)
INSERT [dbo].[HoaDon] ([idHD], [NgayBan], [TongTien], [idNV], [idKH], [TinhTrang]) VALUES (20, CAST(N'2022-12-01' AS Date), 22350, 1, 14, 1)
INSERT [dbo].[HoaDon] ([idHD], [NgayBan], [TongTien], [idNV], [idKH], [TinhTrang]) VALUES (24, CAST(N'2022-12-06' AS Date), 30180, 1, 2, 1)
INSERT [dbo].[HoaDon] ([idHD], [NgayBan], [TongTien], [idNV], [idKH], [TinhTrang]) VALUES (25, CAST(N'2022-12-07' AS Date), 1567500, 1, 14, 1)
SET IDENTITY_INSERT [dbo].[HoaDon] OFF
GO
SET IDENTITY_INSERT [dbo].[KhachHang] ON 

INSERT [dbo].[KhachHang] ([idKH], [TenKH], [SDTKH], [DiaChiKH], [EmailKH]) VALUES (1, N'Nguyễn Văn A', N'0101010101', N'Cà Mau', N'VanAEmail.com')
INSERT [dbo].[KhachHang] ([idKH], [TenKH], [SDTKH], [DiaChiKH], [EmailKH]) VALUES (2, N'Nguyễn Văn B', N'0202020202', N'Trà Vinh', N'Chưa Đặt Tên')
INSERT [dbo].[KhachHang] ([idKH], [TenKH], [SDTKH], [DiaChiKH], [EmailKH]) VALUES (4, N'Nguyen Van C', N'0303030303', N'Can Tho', N'VanC@gmail.com')
INSERT [dbo].[KhachHang] ([idKH], [TenKH], [SDTKH], [DiaChiKH], [EmailKH]) VALUES (6, N'Nguyen Van D', N'0404040404', N'An Giang', N'VanD@gmail.com')
INSERT [dbo].[KhachHang] ([idKH], [TenKH], [SDTKH], [DiaChiKH], [EmailKH]) VALUES (7, N'Nguyen Van E', N'0505050505', N'Dinh Mon', N'VanE@gmail.com')
INSERT [dbo].[KhachHang] ([idKH], [TenKH], [SDTKH], [DiaChiKH], [EmailKH]) VALUES (8, N'Van F', N'0606060606', N'Can Gio', N'VanF@gmail.com')
INSERT [dbo].[KhachHang] ([idKH], [TenKH], [SDTKH], [DiaChiKH], [EmailKH]) VALUES (14, N'Van G', N'0707070707', N'Can Tho', N'vanG@gmail.com')
SET IDENTITY_INSERT [dbo].[KhachHang] OFF
GO
SET IDENTITY_INSERT [dbo].[Kho] ON 

INSERT [dbo].[Kho] ([idK], [idNCC], [idSP], [NgayNhap], [SoLuong]) VALUES (1, 1, 1, CAST(N'2022-11-11' AS Date), 100)
INSERT [dbo].[Kho] ([idK], [idNCC], [idSP], [NgayNhap], [SoLuong]) VALUES (2, 4, 2, CAST(N'2022-11-11' AS Date), 100)
INSERT [dbo].[Kho] ([idK], [idNCC], [idSP], [NgayNhap], [SoLuong]) VALUES (5, 3, 5, CAST(N'2022-11-25' AS Date), 100)
INSERT [dbo].[Kho] ([idK], [idNCC], [idSP], [NgayNhap], [SoLuong]) VALUES (9, 1, 1, CAST(N'2022-12-06' AS Date), 50)
INSERT [dbo].[Kho] ([idK], [idNCC], [idSP], [NgayNhap], [SoLuong]) VALUES (10, 1, 1, CAST(N'2022-12-06' AS Date), 1)
INSERT [dbo].[Kho] ([idK], [idNCC], [idSP], [NgayNhap], [SoLuong]) VALUES (11, 4, 2, CAST(N'2022-12-06' AS Date), 1)
INSERT [dbo].[Kho] ([idK], [idNCC], [idSP], [NgayNhap], [SoLuong]) VALUES (12, 3, 5, CAST(N'2022-12-06' AS Date), 1)
INSERT [dbo].[Kho] ([idK], [idNCC], [idSP], [NgayNhap], [SoLuong]) VALUES (13, 3, 10, CAST(N'2022-12-06' AS Date), 100)
SET IDENTITY_INSERT [dbo].[Kho] OFF
GO
SET IDENTITY_INSERT [dbo].[LoaiSanPham] ON 

INSERT [dbo].[LoaiSanPham] ([idLSP], [TenLSP]) VALUES (1, N'Nước')
INSERT [dbo].[LoaiSanPham] ([idLSP], [TenLSP]) VALUES (2, N'Nước Ngọt')
INSERT [dbo].[LoaiSanPham] ([idLSP], [TenLSP]) VALUES (3, N'Bánh')
INSERT [dbo].[LoaiSanPham] ([idLSP], [TenLSP]) VALUES (4, N'Thịt')
INSERT [dbo].[LoaiSanPham] ([idLSP], [TenLSP]) VALUES (5, N'Rau Quả')
INSERT [dbo].[LoaiSanPham] ([idLSP], [TenLSP]) VALUES (6, N'Bánh Kẹo')
SET IDENTITY_INSERT [dbo].[LoaiSanPham] OFF
GO
SET IDENTITY_INSERT [dbo].[NhaCungCap] ON 

INSERT [dbo].[NhaCungCap] ([idNCC], [TenNCC], [SDTNCC], [DiaChiNCC]) VALUES (1, N'VinaMilk', N'0010010010', N'Vĩnh Long')
INSERT [dbo].[NhaCungCap] ([idNCC], [TenNCC], [SDTNCC], [DiaChiNCC]) VALUES (2, N'Trung Nguyên', N'0020020020', N'Lâm Đồng')
INSERT [dbo].[NhaCungCap] ([idNCC], [TenNCC], [SDTNCC], [DiaChiNCC]) VALUES (3, N'Oishi', N'0030030030', N'Sài Gòn')
INSERT [dbo].[NhaCungCap] ([idNCC], [TenNCC], [SDTNCC], [DiaChiNCC]) VALUES (4, N'CoCaCoLa', N'0040040040', N'Sài Gòn')
INSERT [dbo].[NhaCungCap] ([idNCC], [TenNCC], [SDTNCC], [DiaChiNCC]) VALUES (5, N'pepsi', N'1234567890', N'Cần Thơ')
SET IDENTITY_INSERT [dbo].[NhaCungCap] OFF
GO
SET IDENTITY_INSERT [dbo].[NhanVien] ON 

INSERT [dbo].[NhanVien] ([idNV], [TenNV], [NgaySinhNV], [DiaChiNV], [SDTNV], [ChucVu]) VALUES (1, N'Bùi Thành Tỷ', CAST(N'2001-01-01T00:00:00.000' AS DateTime), N'Bạc Liêu', N'0000000000', N'Admin')
INSERT [dbo].[NhanVien] ([idNV], [TenNV], [NgaySinhNV], [DiaChiNV], [SDTNV], [ChucVu]) VALUES (2, N'Nguyễn Minh Trí', CAST(N'2001-02-02T00:00:00.000' AS DateTime), N'An Giang', N'1111111111', N'Nhân Viên')
INSERT [dbo].[NhanVien] ([idNV], [TenNV], [NgaySinhNV], [DiaChiNV], [SDTNV], [ChucVu]) VALUES (3, N'Võ Minh Nghĩa', CAST(N'2022-11-24T00:00:00.000' AS DateTime), N'Cần Thơ', N'2222222222', N'Nhân Viên')
INSERT [dbo].[NhanVien] ([idNV], [TenNV], [NgaySinhNV], [DiaChiNV], [SDTNV], [ChucVu]) VALUES (4, N'Trương Trọng Hiếu', CAST(N'1900-01-01T00:00:00.000' AS DateTime), N'Cà Mau', N'3333333333', N'Nhân Viên')
SET IDENTITY_INSERT [dbo].[NhanVien] OFF
GO
SET IDENTITY_INSERT [dbo].[SanPham] ON 

INSERT [dbo].[SanPham] ([idSP], [idLSP], [idDV], [TenSP], [DonGia], [SoLuong]) VALUES (1, 1, 1, N'Sữa', 10000, 500)
INSERT [dbo].[SanPham] ([idSP], [idLSP], [idDV], [TenSP], [DonGia], [SoLuong]) VALUES (2, 2, 1, N'Coca CoLa', 15000, 500)
INSERT [dbo].[SanPham] ([idSP], [idLSP], [idDV], [TenSP], [DonGia], [SoLuong]) VALUES (5, 6, 3, N'Snack Cua', 9000, 500)
INSERT [dbo].[SanPham] ([idSP], [idLSP], [idDV], [TenSP], [DonGia], [SoLuong]) VALUES (10, 6, 4, N'Kẹo dâu', 1000, 500)
SET IDENTITY_INSERT [dbo].[SanPham] OFF
GO
ALTER TABLE [dbo].[ChiTietHoaDon] ADD  DEFAULT ((0)) FOR [SoLuong]
GO
ALTER TABLE [dbo].[DangNhap] ADD  DEFAULT ((0)) FOR [MatKhau]
GO
ALTER TABLE [dbo].[DangNhap] ADD  DEFAULT ((0)) FOR [LoaiTK]
GO
ALTER TABLE [dbo].[DonVi] ADD  DEFAULT (N'Chưa Đặt Tên') FOR [TenDV]
GO
ALTER TABLE [dbo].[GiamGia] ADD  DEFAULT ((0)) FOR [PhanTramGiamGia]
GO
ALTER TABLE [dbo].[HoaDon] ADD  DEFAULT (getdate()) FOR [NgayBan]
GO
ALTER TABLE [dbo].[HoaDon] ADD  DEFAULT ((0)) FOR [TongTien]
GO
ALTER TABLE [dbo].[HoaDon] ADD  DEFAULT ((0)) FOR [TinhTrang]
GO
ALTER TABLE [dbo].[KhachHang] ADD  DEFAULT (N'Chưa Đặt Tên') FOR [TenKH]
GO
ALTER TABLE [dbo].[KhachHang] ADD  DEFAULT ((1111111111)) FOR [SDTKH]
GO
ALTER TABLE [dbo].[KhachHang] ADD  DEFAULT (N'Chưa Đặt Tên') FOR [DiaChiKH]
GO
ALTER TABLE [dbo].[KhachHang] ADD  DEFAULT (N'Chưa Đặt Tên') FOR [EmailKH]
GO
ALTER TABLE [dbo].[Kho] ADD  DEFAULT (getdate()) FOR [NgayNhap]
GO
ALTER TABLE [dbo].[Kho] ADD  DEFAULT ((0)) FOR [SoLuong]
GO
ALTER TABLE [dbo].[LoaiSanPham] ADD  DEFAULT (N'Chưa Đặt Tên') FOR [TenLSP]
GO
ALTER TABLE [dbo].[NhaCungCap] ADD  DEFAULT (N'Chưa Đặt Tên') FOR [TenNCC]
GO
ALTER TABLE [dbo].[NhaCungCap] ADD  DEFAULT ((2222222222.)) FOR [SDTNCC]
GO
ALTER TABLE [dbo].[NhaCungCap] ADD  DEFAULT (N'Chưa Đặt Tên') FOR [DiaChiNCC]
GO
ALTER TABLE [dbo].[NhanVien] ADD  DEFAULT (N'Chưa Đặt Tên') FOR [TenNV]
GO
ALTER TABLE [dbo].[NhanVien] ADD  DEFAULT ((0)) FOR [NgaySinhNV]
GO
ALTER TABLE [dbo].[NhanVien] ADD  DEFAULT (N'Chưa Đặt Tên') FOR [DiaChiNV]
GO
ALTER TABLE [dbo].[NhanVien] ADD  DEFAULT ((0)) FOR [SDTNV]
GO
ALTER TABLE [dbo].[NhanVien] ADD  DEFAULT (N'Nhân Viên') FOR [ChucVu]
GO
ALTER TABLE [dbo].[SanPham] ADD  DEFAULT (N'Chưa Đặt Tên') FOR [TenSP]
GO
ALTER TABLE [dbo].[SanPham] ADD  DEFAULT ((0)) FOR [DonGia]
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD FOREIGN KEY([idHD])
REFERENCES [dbo].[HoaDon] ([idHD])
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD FOREIGN KEY([idSP])
REFERENCES [dbo].[SanPham] ([idSP])
GO
ALTER TABLE [dbo].[DangNhap]  WITH CHECK ADD FOREIGN KEY([idNV])
REFERENCES [dbo].[NhanVien] ([idNV])
GO
ALTER TABLE [dbo].[GiamGia]  WITH CHECK ADD FOREIGN KEY([idSP])
REFERENCES [dbo].[SanPham] ([idSP])
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD FOREIGN KEY([idKH])
REFERENCES [dbo].[KhachHang] ([idKH])
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD FOREIGN KEY([idKH])
REFERENCES [dbo].[KhachHang] ([idKH])
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD FOREIGN KEY([idKH])
REFERENCES [dbo].[KhachHang] ([idKH])
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD FOREIGN KEY([idNV])
REFERENCES [dbo].[NhanVien] ([idNV])
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD FOREIGN KEY([idNV])
REFERENCES [dbo].[NhanVien] ([idNV])
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD FOREIGN KEY([idNV])
REFERENCES [dbo].[NhanVien] ([idNV])
GO
ALTER TABLE [dbo].[Kho]  WITH CHECK ADD FOREIGN KEY([idSP])
REFERENCES [dbo].[SanPham] ([idSP])
GO
ALTER TABLE [dbo].[Kho]  WITH CHECK ADD FOREIGN KEY([idNCC])
REFERENCES [dbo].[NhaCungCap] ([idNCC])
GO
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD FOREIGN KEY([idLSP])
REFERENCES [dbo].[LoaiSanPham] ([idLSP])
GO
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD FOREIGN KEY([idDV])
REFERENCES [dbo].[DonVi] ([idDV])
GO
/****** Object:  StoredProcedure [dbo].[USP_CapNhatSoLuongKho]    Script Date: 12/11/2022 11:36:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[USP_CapNhatSoLuongKho]
@idHoaDon INT
AS
BEGIN
	UPDATE dbo.SanPham SET SoLuong = sp.SoLuong - cthd.SoLuong
	FROM ChiTietHoaDon as cthd, SanPham as sp
	WHERE cthd.idSP = sp.idSP and cthd.idHD = @idHoaDon
END
GO
/****** Object:  StoredProcedure [dbo].[USP_CapNhatTaiKhoan]    Script Date: 12/11/2022 11:36:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_CapNhatTaiKhoan]
@taiKhoan nvarchar(100), @matKhau nvarchar(100), @matKhauMoi nvarchar(100)
as
begin
    declare @isRightPass int = 0

	select @isRightPass = count(*) from dbo.DangNhap where TaiKhoan = @taiKhoan and MatKhau = @matKhau

	if(@isRightPass = 1)
	begin
		update dbo.DangNhap set MatKhau = @matKhauMoi where TaiKhoan = @taiKhoan
	end
end
GO
/****** Object:  StoredProcedure [dbo].[USP_DangNhap]    Script Date: 12/11/2022 11:36:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[USP_DangNhap]
@taiKhoan nvarchar(100), @matKhau nvarchar(100)
as
begin
    select * from dbo.DangNhap WHERE TaiKhoan = @taiKhoan AND MatKhau = @matKhau
end
GO
/****** Object:  StoredProcedure [dbo].[USP_DanhSachHoaDonTheoNgay]    Script Date: 12/11/2022 11:36:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[USP_DanhSachHoaDonTheoNgay]
@ngayBD date, @ngayKT date
as
begin
    select hd.idHD as [ID Hóa Đơn], nv.TenNV as [Tên Nhân Viên], kh.TenKH as [Tên Khách Hàng], hd.TongTien as [Tổng Tiền], hd.NgayBan as [Ngày Bán]
	from dbo.HoaDon as hd, dbo.NhanVien as nv, dbo.KhachHang as kh
	where NgayBan >= @ngayBD and NgayBan <= @ngayKT and hd.idKH = kh.idKH and hd.idNV = nv.idNV
end
GO
/****** Object:  StoredProcedure [dbo].[USP_DanhSachNhapKhoTheoNgay]    Script Date: 12/11/2022 11:36:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_DanhSachNhapKhoTheoNgay]
@ngayBD date, @ngayKT date
as
begin
    select k.idK as [Kho], sp.TenSP as [Tên Sản Phẩm], ncc.TenNCC as [Nhà Cung Cấp], k.SoLuong as [Số lượng], k.NgayNhap as [Ngày Nhập] 
	from Kho as k, SanPham as sp, NhaCungCap as ncc
	where NgayNhap >= @ngayBD and NgayNhap <= @ngayKT and k.idSP = sp.idSP and k.idNCC = ncc.idNCC
end
GO
/****** Object:  StoredProcedure [dbo].[USP_HoaDonCuaKhachHang]    Script Date: 12/11/2022 11:36:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[USP_HoaDonCuaKhachHang]
as
begin
    declare @idHD int
	Select @idHD = MAX(idHD) from dbo.HoaDon
    SELECT sp.TenSP, sp.DonGia, cthd.SoLuong, gg.PhanTramGiamGia, ((sp.DonGia*cthd.SoLuong) - ((sp.DonGia*cthd.SoLuong) / 100) * gg.PhanTramGiamGia) as TienSanPham, kh.TenKH, kh.DiaChiKH, kh.SDTKH, kh.EmailKH, nv.TenNV, hd.NgayBan, hd.TongTien
	FROM dbo.ChiTietHoaDon AS cthd, dbo.HoaDon AS hd, dbo.SanPham AS sp, dbo.GiamGia as gg, dbo.KhachHang as kh, dbo.NhanVien as nv
	WHERE cthd.idHD = hd.idHD AND cthd.idSP = sp.idSP and gg.idSP = sp.idSP and hd.idKH = kh.idKH and hd.idNV = nv.idNV AND hd.idHD = @idHD
end
GO
/****** Object:  StoredProcedure [dbo].[USP_LayDanhSachGiamGia]    Script Date: 12/11/2022 11:36:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[USP_LayDanhSachGiamGia]
as
begin
    select gg.idGG as [Mã Giảm Giá], sp.idSP as [Mã Sản Phẩm], sp.TenSP as [Tên Sản Phẩm], lsp.TenLSP as [Loại Sản Phẩm], sp.DonGia as [Giá], gg.PhanTramGiamGia as [Phần Trăm Giảm Giá], gg.NgayKT as [Ngày Kết Thúc]
	from dbo.SanPham as sp, dbo.LoaiSanPham as lsp, dbo.GiamGia as gg
	where sp.idLSP = lsp.idLSP and gg.idSP = sp.idSP
end
GO
/****** Object:  StoredProcedure [dbo].[USP_LayDanhSachKho]    Script Date: 12/11/2022 11:36:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[USP_LayDanhSachKho]
as
begin
    select sp.idSP as [Mã Sản Phẩm], sp.TenSP as [Tên Sản Phẩm], sp.DonGia as [Giá Bán], sp.SoLuong as [Số Lượng], lsp.TenLSP as [Loại], dv.TenDV as [Đơn Vị]
	from dbo.SanPham as sp, dbo.LoaiSanPham as lsp, dbo.DonVi as dv
	where sp.idLSP = lsp.idLSP and sp.idDV = dv.idDV
end
GO
/****** Object:  StoredProcedure [dbo].[USP_LayDanhSachSanPhamChonGiamGia]    Script Date: 12/11/2022 11:36:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_LayDanhSachSanPhamChonGiamGia]
as
begin
    select sp.idSP as [Mã Sản Phẩm], sp.TenSP as [Tên Sản Phẩm], lsp.TenLSP as [Loại Sản Phẩm], sp.DonGia as [Giá] 
	from dbo.SanPham as sp, dbo.LoaiSanPham as lsp
	where sp.idLSP = lsp.idLSP
end
GO
/****** Object:  StoredProcedure [dbo].[USP_ThemChiTietHoaDon]    Script Date: 12/11/2022 11:36:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[USP_ThemChiTietHoaDon]
@idHoaDon INT, @idSanPham INT, @soluong INT
AS
BEGIN
    DECLARE @idTonTaiChiTietHoaDon INT
	DECLARE @soluongSanPham INT = 1

	SELECT @idTonTaiChiTietHoaDon = idCTHD, @soluongSanPham = cthd.SoLuong FROM dbo.ChiTietHoaDon AS cthd WHERE cthd.idHD = @idHoaDon AND cthd.idSP = @idSanPham

	IF (@idTonTaiChiTietHoaDon > 0)
	BEGIN
	    DECLARE @soluongmoi INT = @soluongSanPham + @soluong
		IF(@soluongmoi > 0)
		UPDATE dbo.ChiTietHoaDon SET SoLuong = @soluongSanPham + @soluong WHERE idSP = @idSanPham
		ELSE
		DELETE dbo.ChiTietHoaDon WHERE idHD = @idHoaDon AND idSP = @idSanPham
	END
	ELSE
	BEGIN
	    INSERT dbo.ChiTietHoaDon(idHD, idSP, SoLuong)
		VALUES (@idHoaDon, @idSanPham, @soluong)
	END
END
GO
/****** Object:  StoredProcedure [dbo].[USP_ThemHoaDon]    Script Date: 12/11/2022 11:36:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_ThemHoaDon]
@idKH INT, @idNV int
AS
BEGIN
    INSERT dbo.HoaDon( NgayBan, TongTien, idNV, idKH, TinhTrang)
	VALUES (GETDATE(), 0, @idNV, @idKH, 0)
END
GO
/****** Object:  StoredProcedure [dbo].[USP_ThemKhachHang]    Script Date: 12/11/2022 11:36:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_ThemKhachHang]
@tenKH nvarchar(100), @sdtKH varchar(15), @diachiKH nvarchar(100), @emailKH nvarchar(100)
AS
BEGIN
    INSERT dbo.KhachHang( TenKH, SDTKH, DiaChiKH, EmailKH)
	VALUES (@tenKH, @sdtKH, @diachiKH, @emailKH)
END
GO
/****** Object:  StoredProcedure [dbo].[USP_TimTaiKhoanBangTaiKhoan]    Script Date: 12/11/2022 11:36:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_TimTaiKhoanBangTaiKhoan]
@taiKhoan nvarchar(100)
as
begin
    select * from dbo.DangNhap where TaiKhoan = @taiKhoan
end
GO
USE [master]
GO
ALTER DATABASE [QuanLyCuaHangTienLoi] SET  READ_WRITE 
GO
