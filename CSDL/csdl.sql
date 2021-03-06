USE [master]
GO
/****** Object:  Database [PROJECT3_BlogAmThuc]    Script Date: 2020-11-25 12:24:23 AM ******/
CREATE DATABASE [PROJECT3_BlogAmThuc]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'PROJECT3_BlogAmThuc', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER01\MSSQL\DATA\PROJECT3_BlogAmThuc.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'PROJECT3_BlogAmThuc_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER01\MSSQL\DATA\PROJECT3_BlogAmThuc_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [PROJECT3_BlogAmThuc] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [PROJECT3_BlogAmThuc].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [PROJECT3_BlogAmThuc] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [PROJECT3_BlogAmThuc] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [PROJECT3_BlogAmThuc] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [PROJECT3_BlogAmThuc] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [PROJECT3_BlogAmThuc] SET ARITHABORT OFF 
GO
ALTER DATABASE [PROJECT3_BlogAmThuc] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [PROJECT3_BlogAmThuc] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [PROJECT3_BlogAmThuc] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [PROJECT3_BlogAmThuc] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [PROJECT3_BlogAmThuc] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [PROJECT3_BlogAmThuc] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [PROJECT3_BlogAmThuc] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [PROJECT3_BlogAmThuc] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [PROJECT3_BlogAmThuc] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [PROJECT3_BlogAmThuc] SET  ENABLE_BROKER 
GO
ALTER DATABASE [PROJECT3_BlogAmThuc] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [PROJECT3_BlogAmThuc] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [PROJECT3_BlogAmThuc] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [PROJECT3_BlogAmThuc] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [PROJECT3_BlogAmThuc] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [PROJECT3_BlogAmThuc] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [PROJECT3_BlogAmThuc] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [PROJECT3_BlogAmThuc] SET RECOVERY FULL 
GO
ALTER DATABASE [PROJECT3_BlogAmThuc] SET  MULTI_USER 
GO
ALTER DATABASE [PROJECT3_BlogAmThuc] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [PROJECT3_BlogAmThuc] SET DB_CHAINING OFF 
GO
ALTER DATABASE [PROJECT3_BlogAmThuc] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [PROJECT3_BlogAmThuc] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [PROJECT3_BlogAmThuc] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'PROJECT3_BlogAmThuc', N'ON'
GO
ALTER DATABASE [PROJECT3_BlogAmThuc] SET QUERY_STORE = OFF
GO
USE [PROJECT3_BlogAmThuc]
GO
/****** Object:  Table [dbo].[BAIVIET]    Script Date: 2020-11-25 12:24:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BAIVIET](
	[maBV] [nvarchar](10) NOT NULL,
	[taiKhoanUs] [nvarchar](10) NULL,
	[maBL] [nvarchar](10) NULL,
	[tieuDe] [nvarchar](250) NULL,
	[noiDung] [nvarchar](max) NULL,
	[thoiGianDang] [datetime] NULL,
	[trangThai] [bit] NULL,
	[maDM] [nvarchar](10) NULL,
	[hinhAnh] [nvarchar](50) NULL,
	[maDMC] [nvarchar](10) NULL,
 CONSTRAINT [PK__BAIVIET__7A3F66444083CC69] PRIMARY KEY CLUSTERED 
(
	[maBV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BINHLUAN]    Script Date: 2020-11-25 12:24:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BINHLUAN](
	[maBL] [nvarchar](10) NOT NULL,
	[tenNguoiDang] [nvarchar](100) NULL,
	[maCustomer] [nvarchar](10) NULL,
	[email] [nvarchar](250) NULL,
	[noiDung] [nvarchar](max) NULL,
	[thoiGianDang] [datetime] NULL,
	[trangThai] [bit] NULL,
 CONSTRAINT [PK__BINHLUAN__7A3F664A78B46C5D] PRIMARY KEY CLUSTERED 
(
	[maBL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CUSTOMER]    Script Date: 2020-11-25 12:24:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CUSTOMER](
	[maCustomer] [nvarchar](10) NOT NULL,
	[tenCustomer] [nvarchar](100) NULL,
	[email] [nvarchar](100) NULL,
	[ghiChu] [nvarchar](250) NULL,
 CONSTRAINT [PK__CUSTOMER__C9D5858F37385DFB] PRIMARY KEY CLUSTERED 
(
	[maCustomer] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DANHMUC]    Script Date: 2020-11-25 12:24:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DANHMUC](
	[maDM] [nvarchar](10) NOT NULL,
	[tenDM] [nvarchar](50) NULL,
	[moTa] [nvarchar](250) NULL,
 CONSTRAINT [PK__DANHMUC__7A3EF408045EA63F] PRIMARY KEY CLUSTERED 
(
	[maDM] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DANHMUCCON]    Script Date: 2020-11-25 12:24:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DANHMUCCON](
	[maDMC] [nvarchar](10) NOT NULL,
	[maDM] [nvarchar](10) NULL,
	[tenDMC] [nvarchar](50) NULL,
	[moTa] [nvarchar](250) NULL,
 CONSTRAINT [PK__DANHMUCC__2430726DE459BAE3] PRIMARY KEY CLUSTERED 
(
	[maDMC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QUANGCAO]    Script Date: 2020-11-25 12:24:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QUANGCAO](
	[maQC] [nvarchar](10) NOT NULL,
	[hinhAnh] [image] NULL,
	[video] [nvarchar](max) NULL,
	[thoiGianDang] [datetime] NULL,
	[thoiGianKetThuc] [datetime] NULL,
	[trangThai] [bit] NULL,
	[taiKhoanUs] [nvarchar](10) NULL,
 CONSTRAINT [PK__QUANGCAO__7A3EFC2C5842E589] PRIMARY KEY CLUSTERED 
(
	[maQC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TLBINHLUAN]    Script Date: 2020-11-25 12:24:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TLBINHLUAN](
	[maTLBL] [nvarchar](10) NOT NULL,
	[MABL] [nvarchar](10) NULL,
	[tenNguoiDang] [nvarchar](100) NULL,
	[taiKhoanUs] [nvarchar](10) NULL,
	[maCustomer] [nvarchar](10) NULL,
	[email] [nvarchar](250) NULL,
	[noiDung] [nvarchar](max) NULL,
	[thoiGianDang] [datetime] NULL,
	[trangThai] [bit] NULL,
 CONSTRAINT [PK__TLBINHLU__259BC81B32239026] PRIMARY KEY CLUSTERED 
(
	[maTLBL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[US]    Script Date: 2020-11-25 12:24:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[US](
	[taiKhoanUs] [nvarchar](10) NOT NULL,
	[matKhau] [nvarchar](20) NULL,
	[tenUser] [nvarchar](100) NULL,
	[chucVu] [nvarchar](100) NULL,
	[ghiChu] [nvarchar](250) NULL,
 CONSTRAINT [PK__US__7019F891D22A91D7] PRIMARY KEY CLUSTERED 
(
	[taiKhoanUs] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[BAIVIET] ([maBV], [taiKhoanUs], [maBL], [tieuDe], [noiDung], [thoiGianDang], [trangThai], [maDM], [hinhAnh], [maDMC]) VALUES (N'bv01', N'us1', N'bl01', N'Cách làm đậu xốt tứ xuyên cay thơm', N'aaaaaaaaaaaaaaaaaaaa', CAST(N'2020-11-18T00:00:00.000' AS DateTime), 1, N'dm02', N'https://i.imgur.com/izYzclp.jpg', N'dmc01')
INSERT [dbo].[BAIVIET] ([maBV], [taiKhoanUs], [maBL], [tieuDe], [noiDung], [thoiGianDang], [trangThai], [maDM], [hinhAnh], [maDMC]) VALUES (N'bv02', N'us1', N'bl01', N'Cách làm Japchae - Khám phá món ăn cung đình Hàn Quốc', N'Cách làm Japchae - Khám phá món ăn cung đình Hàn Quốc', CAST(N'2020-11-18T00:00:00.000' AS DateTime), 1, N'dm05', N'https://i.imgur.com/gxSxeJQ.jpg', N'dmc09')
INSERT [dbo].[BAIVIET] ([maBV], [taiKhoanUs], [maBL], [tieuDe], [noiDung], [thoiGianDang], [trangThai], [maDM], [hinhAnh], [maDMC]) VALUES (N'bv03', N'us1', N'bl01', N'Cách làm cá cam nướng chanh Kaffir thưởng thức cùng vang trắng.', N'', CAST(N'2020-04-23T00:00:00.000' AS DateTime), 1, N'dm02', N'https://i.imgur.com/h4sE431.jpg', N'dmc02')
INSERT [dbo].[BAIVIET] ([maBV], [taiKhoanUs], [maBL], [tieuDe], [noiDung], [thoiGianDang], [trangThai], [maDM], [hinhAnh], [maDMC]) VALUES (N'bv04', N'us1', N'bl01', N'Cách làm cá cam nướng chanh Kaffir thưởng thức cùng vang trắng.', N'', CAST(N'2020-04-23T00:00:00.000' AS DateTime), 1, N'dm02', N'https://i.imgur.com/kIhLkdv.jpg', N'dmc03')
INSERT [dbo].[BAIVIET] ([maBV], [taiKhoanUs], [maBL], [tieuDe], [noiDung], [thoiGianDang], [trangThai], [maDM], [hinhAnh], [maDMC]) VALUES (N'bv05', N'us1', N'bl01', N'VALENTINE’S DAY: CÁCH LÀM COCO-BROWNIE HOÀN HẢO NHƯ CRUSH CỦA BẠN', N'', CAST(N'2020-12-29T00:00:00.000' AS DateTime), 1, N'dm02', N'https://i.imgur.com/V7oTyOt.jpg', N'dmc04')
INSERT [dbo].[BAIVIET] ([maBV], [taiKhoanUs], [maBL], [tieuDe], [noiDung], [thoiGianDang], [trangThai], [maDM], [hinhAnh], [maDMC]) VALUES (N'bv06', N'us1', N'bl01', N'SUMMER CHEESECAKE (NO-BAKED)', N'aaaaaaaaaaaaaaaaa', CAST(N'2020-12-01T00:00:00.000' AS DateTime), 1, N'dm02', N'https://i.imgur.com/4hmv71P.jpg', N'dmc05')
INSERT [dbo].[BAIVIET] ([maBV], [taiKhoanUs], [maBL], [tieuDe], [noiDung], [thoiGianDang], [trangThai], [maDM], [hinhAnh], [maDMC]) VALUES (N'bv07', N'us1', N'bl01', N'Món ngon dân dã ngày xuân', N'', CAST(N'2020-10-12T00:00:00.000' AS DateTime), 1, N'dm03', N'https://i.imgur.com/ge707ez.jpg', N'dmc13')
INSERT [dbo].[BAIVIET] ([maBV], [taiKhoanUs], [maBL], [tieuDe], [noiDung], [thoiGianDang], [trangThai], [maDM], [hinhAnh], [maDMC]) VALUES (N'bv08', N'us1', N'bl01', N'CÁCH LÀM BẮP XÀO TÉP “MỘT THỜI ĐỂ NHỚ”', N'', CAST(N'2020-10-12T00:00:00.000' AS DateTime), 1, N'dm03', N'https://i.imgur.com/fdaDrd0.jpg', N'dmc14')
INSERT [dbo].[BAIVIET] ([maBV], [taiKhoanUs], [maBL], [tieuDe], [noiDung], [thoiGianDang], [trangThai], [maDM], [hinhAnh], [maDMC]) VALUES (N'bv09', N'us1', N'bl01', N'CÁCH LÀM CHÓ BƯỞI TUYỆT XINH PHÁ CỖ TRÔNG TRĂNG', N'', CAST(N'2020-05-23T00:00:00.000' AS DateTime), 1, N'dm03', N'https://i.imgur.com/54v5dhS.jpg', N'dmc15')
INSERT [dbo].[BAIVIET] ([maBV], [taiKhoanUs], [maBL], [tieuDe], [noiDung], [thoiGianDang], [trangThai], [maDM], [hinhAnh], [maDMC]) VALUES (N'bv10', N'us1', N'bl01', N'[CÔNG THỨC] Cách làm bánh khúc Bắc Bộ', N'', CAST(N'2020-06-13T00:00:00.000' AS DateTime), 1, N'dm02', N'https://i.imgur.com/GzJaoO2.jpg', N'dmc06')
INSERT [dbo].[BAIVIET] ([maBV], [taiKhoanUs], [maBL], [tieuDe], [noiDung], [thoiGianDang], [trangThai], [maDM], [hinhAnh], [maDMC]) VALUES (N'bv11', N'us1', N'bl01', N'MÓN “HOA GẠO XÀO” TRONG TRUYỀN THUYẾT', N'', CAST(N'2020-06-13T00:00:00.000' AS DateTime), 1, N'dm02', N'https://i.imgur.com/sb2yTDL.jpg', N'dmc07')
INSERT [dbo].[BAIVIET] ([maBV], [taiKhoanUs], [maBL], [tieuDe], [noiDung], [thoiGianDang], [trangThai], [maDM], [hinhAnh], [maDMC]) VALUES (N'bv12', N'us1', N'bl01', N'24H HÒ HẸN VỚI MÙA THU HÀ NỘI', N'', CAST(N'2020-06-13T00:00:00.000' AS DateTime), 1, N'dm02', N'https://i.imgur.com/oqTZDbr.jpg', N'dmc01')
INSERT [dbo].[BAIVIET] ([maBV], [taiKhoanUs], [maBL], [tieuDe], [noiDung], [thoiGianDang], [trangThai], [maDM], [hinhAnh], [maDMC]) VALUES (N'bv13', N'us1', N'bl01', N'CÁCH LÀM MẮM TÉP CHƯNG TÓP MỠ THỊT BĂM', N'', CAST(N'2020-06-13T00:00:00.000' AS DateTime), 1, N'dm02', N'https://i.imgur.com/A70TaBV.jpg', N'dmc02')
INSERT [dbo].[BAIVIET] ([maBV], [taiKhoanUs], [maBL], [tieuDe], [noiDung], [thoiGianDang], [trangThai], [maDM], [hinhAnh], [maDMC]) VALUES (N'bv14', N'us1', N'bl01', N'CÁCH LÀM CHÈ HOÀI SƠN TÁO ĐỎ', N'', CAST(N'2020-06-13T00:00:00.000' AS DateTime), 1, N'dm02', N'https://i.imgur.com/rJ8mmaa.jpg', N'dmc03')
INSERT [dbo].[BAIVIET] ([maBV], [taiKhoanUs], [maBL], [tieuDe], [noiDung], [thoiGianDang], [trangThai], [maDM], [hinhAnh], [maDMC]) VALUES (N'bv15', N'us1', N'bl01', N'SẤU NGÂM MẮM SIÊU LỪA MIỆNG', N'', CAST(N'2020-06-13T00:00:00.000' AS DateTime), 1, N'dm02', N'https://i.imgur.com/b9MkfLx.jpg', N'dmc04')
INSERT [dbo].[BAIVIET] ([maBV], [taiKhoanUs], [maBL], [tieuDe], [noiDung], [thoiGianDang], [trangThai], [maDM], [hinhAnh], [maDMC]) VALUES (N'bv16', N'us1', N'bl01', N'MÙA THU ĂN HỒNG TRE', N'', CAST(N'2020-04-25T00:00:00.000' AS DateTime), 1, N'dm03', N'https://i.imgur.com/t53AnHz.jpg', N'dmc13')
INSERT [dbo].[BAIVIET] ([maBV], [taiKhoanUs], [maBL], [tieuDe], [noiDung], [thoiGianDang], [trangThai], [maDM], [hinhAnh], [maDMC]) VALUES (N'bv17', N'us1', N'bl01', N'MẬN HẬU CUỐI VỤ. LÀM MẺ Ô MAI MẬN DẺO', N'', CAST(N'2020-04-25T00:00:00.000' AS DateTime), 1, N'dm03', N'https://i.imgur.com/e5oqwMw.jpg', N'dmc13')
INSERT [dbo].[BAIVIET] ([maBV], [taiKhoanUs], [maBL], [tieuDe], [noiDung], [thoiGianDang], [trangThai], [maDM], [hinhAnh], [maDMC]) VALUES (N'bv18', N'us1', N'bl01', N'MÙA CÁ NGẦN NAO NỨC', N'', CAST(N'2020-04-25T00:00:00.000' AS DateTime), 1, N'dm03', N'https://i.imgur.com/4cgHVze.jpg', N'dmc13')
INSERT [dbo].[BAIVIET] ([maBV], [taiKhoanUs], [maBL], [tieuDe], [noiDung], [thoiGianDang], [trangThai], [maDM], [hinhAnh], [maDMC]) VALUES (N'bv19', N'us1', N'bl01', N'CÁCH LÀM SÚP GẤC HẢI SẢN – MÓN ĂN QUÝ TỘC', N'', CAST(N'2020-04-25T00:00:00.000' AS DateTime), 1, N'dm03', N'https://i.imgur.com/lLggQ94.jpg', N'dmc13')
INSERT [dbo].[BAIVIET] ([maBV], [taiKhoanUs], [maBL], [tieuDe], [noiDung], [thoiGianDang], [trangThai], [maDM], [hinhAnh], [maDMC]) VALUES (N'bv20', N'us1', N'bl01', N'Chào tháng mới, tuần mới. Chào Bánh Trôi, Bánh Chay', N'', CAST(N'2020-04-25T00:00:00.000' AS DateTime), 1, N'dm03', N'https://i.imgur.com/bpp9h5X.png', N'dmc13')
INSERT [dbo].[BAIVIET] ([maBV], [taiKhoanUs], [maBL], [tieuDe], [noiDung], [thoiGianDang], [trangThai], [maDM], [hinhAnh], [maDMC]) VALUES (N'bv21', N'us1', N'bl01', N'KHOẢNH KHẮC KÌ DIỆU HÀ NỘI – HOA SƯA 2018', N'', CAST(N'2020-04-25T00:00:00.000' AS DateTime), 1, N'dm03', N'https://i.imgur.com/FPGI9g4.gif', N'dmc15')
INSERT [dbo].[BAIVIET] ([maBV], [taiKhoanUs], [maBL], [tieuDe], [noiDung], [thoiGianDang], [trangThai], [maDM], [hinhAnh], [maDMC]) VALUES (N'bv22', N'us1', N'bl01', N'CÁCH LÀM CUA XỐT SẤU CHÍN', N'', CAST(N'2020-04-25T00:00:00.000' AS DateTime), 1, N'dm03', N'https://i.imgur.com/xaW8Qrm.jpg', N'dmc13')
INSERT [dbo].[BAIVIET] ([maBV], [taiKhoanUs], [maBL], [tieuDe], [noiDung], [thoiGianDang], [trangThai], [maDM], [hinhAnh], [maDMC]) VALUES (N'bv23', N'us1', N'bl01', N'KÝ ỨC TRÔI NƯỚC', N'', CAST(N'2020-04-25T00:00:00.000' AS DateTime), 1, N'dm03', N'https://i.imgur.com/aO1tT5Q.jpg', N'dmc15')
INSERT [dbo].[BAIVIET] ([maBV], [taiKhoanUs], [maBL], [tieuDe], [noiDung], [thoiGianDang], [trangThai], [maDM], [hinhAnh], [maDMC]) VALUES (N'bv24', N'us1', N'bl01', N'TÀN XUÂN, HÁI MAI…', N'', CAST(N'2020-04-25T00:00:00.000' AS DateTime), 1, N'dm03', N'https://i.imgur.com/ylEkIGu.jpg', N'dmc13')
INSERT [dbo].[BAIVIET] ([maBV], [taiKhoanUs], [maBL], [tieuDe], [noiDung], [thoiGianDang], [trangThai], [maDM], [hinhAnh], [maDMC]) VALUES (N'bv25', N'us1', N'bl01', N'MÍA CHƯNG HOA BƯỞI – QUÀ CỦA THÁNG BA', N'', CAST(N'2020-04-25T00:00:00.000' AS DateTime), 1, N'dm03', N'https://i.imgur.com/1iP4y8p.jpg', N'dmc13')
INSERT [dbo].[BAIVIET] ([maBV], [taiKhoanUs], [maBL], [tieuDe], [noiDung], [thoiGianDang], [trangThai], [maDM], [hinhAnh], [maDMC]) VALUES (N'bv26', N'us1', N'bl02', N'SỬA SOẠN ĂN RƯƠI', N'', CAST(N'2020-11-23T00:00:00.000' AS DateTime), 1, N'dm03', N'https://i.imgur.com/YmUotCs.jpg', N'dmc14')
INSERT [dbo].[BAIVIET] ([maBV], [taiKhoanUs], [maBL], [tieuDe], [noiDung], [thoiGianDang], [trangThai], [maDM], [hinhAnh], [maDMC]) VALUES (N'bv27', N'us1', N'bl02', N'Ăn các món này với nhau sẽ đem đến sức khoẻ tuyệt vời', N'', CAST(N'2020-11-09T00:00:00.000' AS DateTime), 1, N'dm01', N'https://i.imgur.com/KIEyftX.jpg', N'dmc17')
INSERT [dbo].[BAIVIET] ([maBV], [taiKhoanUs], [maBL], [tieuDe], [noiDung], [thoiGianDang], [trangThai], [maDM], [hinhAnh], [maDMC]) VALUES (N'bv28', N'us1', N'bl02', N'Tìm hiểu cách tách lòng đỏ và lòng trắng trứng hiệu quả nhất', N'', CAST(N'2020-11-09T00:00:00.000' AS DateTime), 1, N'dm01', N'https://i.imgur.com/YM0dX3e.png', N'dmc20')
INSERT [dbo].[BAIVIET] ([maBV], [taiKhoanUs], [maBL], [tieuDe], [noiDung], [thoiGianDang], [trangThai], [maDM], [hinhAnh], [maDMC]) VALUES (N'bv29', N'us1', N'bl02', N'Tổng hợp các loại rau tuyệt vời cho người giảm cân', N'', CAST(N'2020-11-09T00:00:00.000' AS DateTime), 1, N'dm01', N'https://i.imgur.com/P4DwVV3.jpg', N'dmc18')
GO
INSERT [dbo].[BINHLUAN] ([maBL], [tenNguoiDang], [maCustomer], [email], [noiDung], [thoiGianDang], [trangThai]) VALUES (N'bl01', N'Mít ', N'cs01', N'thaong22.03@gmail.com', N'Tôi thật sự yêu thích món ăn của bạn', CAST(N'2020-12-12T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[BINHLUAN] ([maBL], [tenNguoiDang], [maCustomer], [email], [noiDung], [thoiGianDang], [trangThai]) VALUES (N'bl02', N'Ali Nguyễn', N'cs01', N'thaong22.03@gmail.com', N'Cảm ơn, Ước gì tôi có thể tìm thấy công thức của bạn sớm hơn', CAST(N'2020-11-20T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[BINHLUAN] ([maBL], [tenNguoiDang], [maCustomer], [email], [noiDung], [thoiGianDang], [trangThai]) VALUES (N'bl03', N'Chu Ngọc', N'cs01', N'thaong22.03@gmail.com', N'Hãy tạo thêm nhiều bài viết tuyệt vòi nữa nhé <3', CAST(N'2020-11-23T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[BINHLUAN] ([maBL], [tenNguoiDang], [maCustomer], [email], [noiDung], [thoiGianDang], [trangThai]) VALUES (N'bl04', N'Ngọc Lụa', N'cs01', N'thaong22.03@gmail.com', N'Chúng ta có thể gặp nhau để chia sẻ cồng thức nấu ngon không ạ?', CAST(N'2020-11-24T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[BINHLUAN] ([maBL], [tenNguoiDang], [maCustomer], [email], [noiDung], [thoiGianDang], [trangThai]) VALUES (N'bl05', N'Thu Uyên', N'cs01', N'thaong22.03@gmail.com', N'Cảm ơn vì bài viết quá hay đã giúp tôi hoàn thành món ăn tuyệt vời <3', CAST(N'2020-11-12T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[BINHLUAN] ([maBL], [tenNguoiDang], [maCustomer], [email], [noiDung], [thoiGianDang], [trangThai]) VALUES (N'bl06', N'Panora', N'cs01', N'thaong22.03@gmail.com', N'Tôi nghĩ là thêm một chút ngọt món ăn sẽ ngon hơn nhiều', CAST(N'2020-11-23T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[BINHLUAN] ([maBL], [tenNguoiDang], [maCustomer], [email], [noiDung], [thoiGianDang], [trangThai]) VALUES (N'bl07', N'Linh Dương', N'cs01', N'thaong22.03@gmail.com', N'Tôi có thể mua bò Mỹ chuẩn ngon ở đâu??', CAST(N'2020-11-01T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[BINHLUAN] ([maBL], [tenNguoiDang], [maCustomer], [email], [noiDung], [thoiGianDang], [trangThai]) VALUES (N'bl08', N'Lê Thảo', N'cs01', N'thaong22.03@gmail.com', N'Tôi không dị ứng với chanh có thể thay bằng dấm hoặc me chua không ??', CAST(N'2020-11-02T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[BINHLUAN] ([maBL], [tenNguoiDang], [maCustomer], [email], [noiDung], [thoiGianDang], [trangThai]) VALUES (N'bl09', N'Gia Huy', N'cs01', N'thaong22.03@gmail.com', N'Cảm ơn bài viết hay của bạn tôi đã làm được rất nhiều món ngon cho gia đình của tôi', CAST(N'2020-12-11T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[BINHLUAN] ([maBL], [tenNguoiDang], [maCustomer], [email], [noiDung], [thoiGianDang], [trangThai]) VALUES (N'bl10', N'Thu Quỳnh', N'cs01', N'thaong22.03@gmail.com', N'Xin chào, hãy cho tôi biết từ đâu bạn có thể lụa chọn được thực phẩm sạch, tươi ngon như vậy ạ?', CAST(N'2020-10-21T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[BINHLUAN] ([maBL], [tenNguoiDang], [maCustomer], [email], [noiDung], [thoiGianDang], [trangThai]) VALUES (N'bl11', N'Duy Khánh', N'cs01', N'thaong22.03@gmail.com', N'Bài viết tới bạn hãy làm thêm về chủ đề ẩm thực du lịch đi ạ!!!', CAST(N'2020-11-13T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[BINHLUAN] ([maBL], [tenNguoiDang], [maCustomer], [email], [noiDung], [thoiGianDang], [trangThai]) VALUES (N'bl12', N'Trấn Thành', N'cs01', N'thaong22.03@gmail.com', N'Xin chào, Tôi là Trấn Thành tôi có mở của hàng ', CAST(N'2020-09-12T00:00:00.000' AS DateTime), 1)
GO
INSERT [dbo].[CUSTOMER] ([maCustomer], [tenCustomer], [email], [ghiChu]) VALUES (N'cs01', N'Chu Thảo Ngọc', N'thaongoc2609@gmail.com', N'Trợ lý đăng tin')
INSERT [dbo].[CUSTOMER] ([maCustomer], [tenCustomer], [email], [ghiChu]) VALUES (N'cs02', N'Nguyễn Ngọc Lụa', N'ngoclua1805@gmail.com', N'Trợ lý đăng tin')
INSERT [dbo].[CUSTOMER] ([maCustomer], [tenCustomer], [email], [ghiChu]) VALUES (N'cs03', N'Nguyễn Thị Thu Uyên', N'thuuyen2103@gmail.com', N'Trợ lý đăng tin')
GO
INSERT [dbo].[DANHMUC] ([maDM], [tenDM], [moTa]) VALUES (N'dm01', N'Trang chủ', N'mota1')
INSERT [dbo].[DANHMUC] ([maDM], [tenDM], [moTa]) VALUES (N'dm02', N'Công thức', N'mota2')
INSERT [dbo].[DANHMUC] ([maDM], [tenDM], [moTa]) VALUES (N'dm03', N'Cảm hứng sống', NULL)
INSERT [dbo].[DANHMUC] ([maDM], [tenDM], [moTa]) VALUES (N'dm04', N'Mẹo vặt', NULL)
INSERT [dbo].[DANHMUC] ([maDM], [tenDM], [moTa]) VALUES (N'dm05', N'Góc review', NULL)
INSERT [dbo].[DANHMUC] ([maDM], [tenDM], [moTa]) VALUES (N'dm06', N'Bánh mì', N'mota3')
GO
INSERT [dbo].[DANHMUCCON] ([maDMC], [maDM], [tenDMC], [moTa]) VALUES (N'dmc01', N'dm02', N'Bánh mỳ', N'mota1')
INSERT [dbo].[DANHMUCCON] ([maDMC], [maDM], [tenDMC], [moTa]) VALUES (N'dmc02', N'dm02', N'Bánh ngọt', N'mota2')
INSERT [dbo].[DANHMUCCON] ([maDMC], [maDM], [tenDMC], [moTa]) VALUES (N'dmc03', N'dm02', N'Đồ uống', NULL)
INSERT [dbo].[DANHMUCCON] ([maDMC], [maDM], [tenDMC], [moTa]) VALUES (N'dmc04', N'dm02', N'Món khai vị', NULL)
INSERT [dbo].[DANHMUCCON] ([maDMC], [maDM], [tenDMC], [moTa]) VALUES (N'dmc05', N'dm02', N'Món chính', NULL)
INSERT [dbo].[DANHMUCCON] ([maDMC], [maDM], [tenDMC], [moTa]) VALUES (N'dmc06', N'dm02', N'Món phụ', NULL)
INSERT [dbo].[DANHMUCCON] ([maDMC], [maDM], [tenDMC], [moTa]) VALUES (N'dmc07', N'dm02', N'Món tráng miệng', NULL)
INSERT [dbo].[DANHMUCCON] ([maDMC], [maDM], [tenDMC], [moTa]) VALUES (N'dmc08', N'dm05', N'Ẩm thực ba miền', NULL)
INSERT [dbo].[DANHMUCCON] ([maDMC], [maDM], [tenDMC], [moTa]) VALUES (N'dmc09', N'dm05', N'Nấu nướng', NULL)
INSERT [dbo].[DANHMUCCON] ([maDMC], [maDM], [tenDMC], [moTa]) VALUES (N'dmc10', N'dm05', N'Thế giới món ngon', NULL)
INSERT [dbo].[DANHMUCCON] ([maDMC], [maDM], [tenDMC], [moTa]) VALUES (N'dmc11', N'dm05', N'Văn hoá ẩm thực', NULL)
INSERT [dbo].[DANHMUCCON] ([maDMC], [maDM], [tenDMC], [moTa]) VALUES (N'dmc12', N'dm05', N'Món ăn và sức khoẻ', NULL)
INSERT [dbo].[DANHMUCCON] ([maDMC], [maDM], [tenDMC], [moTa]) VALUES (N'dmc13', N'dm03', N'Góc nhỏ Yummy', NULL)
INSERT [dbo].[DANHMUCCON] ([maDMC], [maDM], [tenDMC], [moTa]) VALUES (N'dmc14', N'dm03', N'Ký ức Hà Nội', NULL)
INSERT [dbo].[DANHMUCCON] ([maDMC], [maDM], [tenDMC], [moTa]) VALUES (N'dmc15', N'dm03', N'Nhật ký xây mơ', NULL)
INSERT [dbo].[DANHMUCCON] ([maDMC], [maDM], [tenDMC], [moTa]) VALUES (N'dmc16', N'dm05', N'Ẩm thực Hàn', NULL)
INSERT [dbo].[DANHMUCCON] ([maDMC], [maDM], [tenDMC], [moTa]) VALUES (N'dmc17', N'dm01', N'Tác giả', NULL)
INSERT [dbo].[DANHMUCCON] ([maDMC], [maDM], [tenDMC], [moTa]) VALUES (N'dmc18', N'dm01', N'Về chúng tôi', NULL)
INSERT [dbo].[DANHMUCCON] ([maDMC], [maDM], [tenDMC], [moTa]) VALUES (N'dmc19', N'dm01', N'Liên lạc', NULL)
INSERT [dbo].[DANHMUCCON] ([maDMC], [maDM], [tenDMC], [moTa]) VALUES (N'dmc20', N'dm01', N'HOT', NULL)
GO
INSERT [dbo].[QUANGCAO] ([maQC], [hinhAnh], [video], [thoiGianDang], [thoiGianKetThuc], [trangThai], [taiKhoanUs]) VALUES (N'qc1', NULL, NULL, NULL, NULL, NULL, N'us1')
INSERT [dbo].[QUANGCAO] ([maQC], [hinhAnh], [video], [thoiGianDang], [thoiGianKetThuc], [trangThai], [taiKhoanUs]) VALUES (N'qc2', NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[QUANGCAO] ([maQC], [hinhAnh], [video], [thoiGianDang], [thoiGianKetThuc], [trangThai], [taiKhoanUs]) VALUES (N'qc3', NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[QUANGCAO] ([maQC], [hinhAnh], [video], [thoiGianDang], [thoiGianKetThuc], [trangThai], [taiKhoanUs]) VALUES (N'qc4', NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[US] ([taiKhoanUs], [matKhau], [tenUser], [chucVu], [ghiChu]) VALUES (N'us1', N'12', N'Thảo Nguyễn', N'Quản lý', N'Tác giả')
INSERT [dbo].[US] ([taiKhoanUs], [matKhau], [tenUser], [chucVu], [ghiChu]) VALUES (N'us2', N'23', N'Miasoya', N'Trợ lý', N'Trợ lý tác giả')
GO
/****** Object:  StoredProcedure [dbo].[thembaiviet]    Script Date: 2020-11-25 12:24:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

   CREATE PROCEDURE [dbo].[thembaiviet] 
	@maBV nvarchar(10),
	@tieude nvarchar(250),
	@noidung nvarchar(max),
	@hinhanh image,
	@thoigiandang datetime,
	@trangThai bit,
	@madm nvarchar(10)
AS
BEGIN
	insert into BAIVIET (mabv,tieuDe,noiDung,hinhAnh,thoiGianDang,trangThai,maDM) values(@maBV,@tieude,@noidung,@hinhanh,@thoigiandang,@trangThai,@madm )
END
GO
USE [master]
GO
ALTER DATABASE [PROJECT3_BlogAmThuc] SET  READ_WRITE 
GO
