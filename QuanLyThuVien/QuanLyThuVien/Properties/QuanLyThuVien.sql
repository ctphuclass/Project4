CREATE DATABASE QuanLyThuVien
GO
USE QuanLyThuVien
GO
/****** Object:  StoredProcedure [dbo].[store_timkiem]    Script Date: 11/19/2017 7:02:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[store_timkiem] 
	-- Add the parameters for the stored procedure here
@MaSach char(8),
@TenSach nvarchar(100),
@Ndtt nvarchar(300),
@MaTG char(6),
@MaTL char(6),
@MaNXB char(6)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * from SACH where MaSach like '%'+@MaSach+'%'
						 and TenSach like '%'+@TenSach+'%'
						 and NoiDungTT like '%'+@Ndtt+'%'
						 and MaTG like '%'+@MaTG+'%'
						 and MaTL like '%'+@MaTL+'%'
						 and MaNXB like '%'+@MaNXB+'%'
						
END

GO
/****** Object:  Table [dbo].[CT_PHIEUMUON]    Script Date: 11/19/2017 7:02:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CT_PHIEUMUON](
	[MaPhieu] [char](6) NOT NULL,
	[MaSach] [char](8) NOT NULL,
	[HanTra] [datetime] NOT NULL,
 CONSTRAINT [PK_CT_PHIEUMUON] PRIMARY KEY CLUSTERED 
(
	[MaPhieu] ASC,
	[MaSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DOCGIA]    Script Date: 11/19/2017 7:02:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DOCGIA](
	[MaDG] [char](6) NOT NULL,
	[HoTenDG] [nvarchar](30) NOT NULL,
	[EmailDG] [nvarchar](30) NULL,
	[GioiTinhDG] [bit] NULL,
	[NgaySinhDG] [datetime] NULL,
	[DiaChiDG] [nvarchar](100) NULL,
	[DienThoaiDG] [char](11) NULL,
	[NgayLamThe] [datetime] NULL,
	[NgayHetHan] [datetime] NULL,
	[HoatDong] [bit] NULL,
 CONSTRAINT [PK_DOCGIA] PRIMARY KEY CLUSTERED 
(
	[MaDG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 11/19/2017 7:02:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[MaNV] [char](6) NOT NULL,
	[HoTenNV] [nvarchar](30) NOT NULL,
	[GioiTinhNV] [bit] NULL,
	[NgaySinhNV] [datetime] NOT NULL,
	[DienThoaiNV] [char](11) NULL,
	[DiaChiNV] [nvarchar](100) NULL,
	[EmailNV] [nchar](30) NULL,
	[NgayVaoLam] [datetime] NOT NULL,
	[MatKhau] [varchar](10) NULL,
	[QuyenHan] [bit] NOT NULL,
 CONSTRAINT [PK_NHANVIEN] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NHAXUATBAN]    Script Date: 11/19/2017 7:02:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NHAXUATBAN](
	[MaNXB] [char](6) NOT NULL,
	[TenNXB] [nvarchar](100) NOT NULL,
	[DiaChiNXB] [nvarchar](100) NULL,
	[DienThoaiNXB] [char](11) NULL,
	[Website] [char](50) NULL,
 CONSTRAINT [PK_NHAXUATBAN] PRIMARY KEY CLUSTERED 
(
	[MaNXB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PHIEUMUON]    Script Date: 11/19/2017 7:02:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PHIEUMUON](
	[MaPhieu] [char](6) NOT NULL,
	[MaDG] [char](6) NOT NULL,
	[NgayMuon] [datetime] NOT NULL,
	[MaNV] [char](6) NOT NULL,
 CONSTRAINT [PK_PHIEUMUON_1] PRIMARY KEY CLUSTERED 
(
	[MaPhieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SACH]    Script Date: 11/19/2017 7:02:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SACH](
	[MaSach] [char](8) NOT NULL,
	[TenSach] [nvarchar](100) NOT NULL,
	[NoiDungTT] [nvarchar](300) NULL,
	[SoTrang] [int] NULL,
	[Gia] [bigint] NULL,
	[SoLuong] [int] NULL,
	[NgayNhap] [datetime] NULL,
	[MaNXB] [char](6) NOT NULL,
	[MaTG] [char](6) NOT NULL,
	[MaTL] [char](6) NOT NULL,
	[TinhTrang] [bit] NULL,
 CONSTRAINT [PK_SACH_1] PRIMARY KEY CLUSTERED 
(
	[MaSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TACGIA]    Script Date: 11/19/2017 7:02:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TACGIA](
	[MaTG] [char](6) NOT NULL,
	[HoTenTG] [nvarchar](30) NOT NULL,
	[DiaChiTG] [nvarchar](100) NULL,
	[DienThoaiTG] [char](11) NULL,
 CONSTRAINT [PK_TACGIA] PRIMARY KEY CLUSTERED 
(
	[MaTG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[THELOAI]    Script Date: 11/19/2017 7:02:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[THELOAI](
	[MaTL] [char](6) NOT NULL,
	[TenTL] [nvarchar](100) NOT NULL,
	[GhiChu] [nvarchar](500) NULL,
 CONSTRAINT [PK_THELOAI] PRIMARY KEY CLUSTERED 
(
	[MaTL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TRASACH]    Script Date: 11/19/2017 7:02:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TRASACH](
	[MaPhieu] [char](6) NOT NULL,
	[MaSach] [char](8) NOT NULL,
	[MaNV] [char](6) NOT NULL,
	[NgayTra] [datetime] NOT NULL,
	[PhatHuHong] [bigint] NULL,
	[PhatQuaHan] [bigint] NULL,
 CONSTRAINT [PK_TRASACH_1] PRIMARY KEY CLUSTERED 
(
	[MaPhieu] ASC,
	[MaSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  View [dbo].[MuonSachQuaHan]    Script Date: 11/19/2017 7:02:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[MuonSachQuaHan]
AS
SELECT     TOP (100) PERCENT dbo.PHIEUMUON.MaPhieu, dbo.CT_PHIEUMUON.MaSach, dbo.SACH.TenSach, dbo.TACGIA.HoTenTG, dbo.DOCGIA.MaDG, dbo.DOCGIA.HoTenDG, dbo.DOCGIA.DiaChiDG, dbo.PHIEUMUON.NgayMuon, dbo.CT_PHIEUMUON.HanTra, dbo.TRASACH.NgayTra, DATEDIFF(day, dbo.TRASACH.NgayTra, dbo.CT_PHIEUMUON.HanTra) AS SONGAYQUAHAN
FROM         dbo.PHIEUMUON INNER JOIN
                      dbo.CT_PHIEUMUON ON dbo.PHIEUMUON.MaPhieu = dbo.CT_PHIEUMUON.MaPhieu INNER JOIN
                      dbo.DOCGIA ON dbo.PHIEUMUON.MaDG = dbo.DOCGIA.MaDG INNER JOIN
                      dbo.SACH ON dbo.CT_PHIEUMUON.MaSach = dbo.SACH.MaSach INNER JOIN
                      dbo.TACGIA ON dbo.SACH.MaTG = dbo.TACGIA.MaTG INNER JOIN
                      dbo.TRASACH ON dbo.PHIEUMUON.MaPhieu = dbo.TRASACH.MaPhieu AND dbo.SACH.MaSach = dbo.TRASACH.MaSach
WHERE     (dbo.TRASACH.NgayTra - dbo.CT_PHIEUMUON.HanTra > 0) OR
                      (GETDATE() - dbo.CT_PHIEUMUON.HanTra > 0) AND (dbo.TRASACH.NgayTra IS NULL)
ORDER BY dbo.PHIEUMUON.MaPhieu, dbo.CT_PHIEUMUON.MaSach, dbo.SACH.TenSach, dbo.TACGIA.HoTenTG, dbo.DOCGIA.MaDG, dbo.DOCGIA.HoTenDG, dbo.DOCGIA.DiaChiDG, dbo.PHIEUMUON.NgayMuon, dbo.CT_PHIEUMUON.HanTra, dbo.TRASACH.NgayTra

GO
INSERT [dbo].[CT_PHIEUMUON] ([MaPhieu], [MaSach], [HanTra]) VALUES (N'PM0001', N'MS000001', CAST(0x0000A0C700000000 AS DateTime))
INSERT [dbo].[CT_PHIEUMUON] ([MaPhieu], [MaSach], [HanTra]) VALUES (N'PM0001', N'MS000002', CAST(0x0000A0C700000000 AS DateTime))
INSERT [dbo].[CT_PHIEUMUON] ([MaPhieu], [MaSach], [HanTra]) VALUES (N'PM0002', N'MS000003', CAST(0x0000A0DC00000000 AS DateTime))
INSERT [dbo].[DOCGIA] ([MaDG], [HoTenDG], [EmailDG], [GioiTinhDG], [NgaySinhDG], [DiaChiDG], [DienThoaiDG], [NgayLamThe], [NgayHetHan], [HoatDong]) VALUES (N'DG0001', N'Lê Thị Hải', N'haile@gmail.com', 0, CAST(0x00007EFB00000000 AS DateTime), N'Nghệ An', N'0988666888 ', CAST(0x0000A00900000000 AS DateTime), CAST(0x0000AC8F00000000 AS DateTime), 1)
INSERT [dbo].[DOCGIA] ([MaDG], [HoTenDG], [EmailDG], [GioiTinhDG], [NgaySinhDG], [DiaChiDG], [DienThoaiDG], [NgayLamThe], [NgayHetHan], [HoatDong]) VALUES (N'DG0002', N'Nguyễn Thị Hà', N'nguyenthiha@gmail.com', 0, CAST(0x000083EA00000000 AS DateTime), N'Vĩnh Phúc', N'0987369852 ', CAST(0x00009E5E00000000 AS DateTime), CAST(0x0000A13800000000 AS DateTime), 1)
INSERT [dbo].[DOCGIA] ([MaDG], [HoTenDG], [EmailDG], [GioiTinhDG], [NgaySinhDG], [DiaChiDG], [DienThoaiDG], [NgayLamThe], [NgayHetHan], [HoatDong]) VALUES (N'DG0003', N'Hà Thị Thu Trang', N'thutrang@gmail.com', 0, CAST(0x000083DB00000000 AS DateTime), N'Bắc Giang', N'0916234567 ', CAST(0x0000A06300000000 AS DateTime), CAST(0x0000A1E200000000 AS DateTime), 0)
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTenNV], [GioiTinhNV], [NgaySinhNV], [DienThoaiNV], [DiaChiNV], [EmailNV], [NgayVaoLam], [MatKhau], [QuyenHan]) VALUES (N'NV0001', N'Vũ Văn Tuân', 1, CAST(0x0000836600000000 AS DateTime), N'0979321343 ', N'Bắc Giang', N'vuvantuan92@gmail.com         ', CAST(0x00009CF100000000 AS DateTime), N'admin', 1)
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTenNV], [GioiTinhNV], [NgaySinhNV], [DienThoaiNV], [DiaChiNV], [EmailNV], [NgayVaoLam], [MatKhau], [QuyenHan]) VALUES (N'NV0002', N'Nguyễn Hồng Tài', 1, CAST(0x0000827700000000 AS DateTime), N'0986123456 ', N'Nghệ An', N'hongtai@gmail.com             ', CAST(0x00009D9800000000 AS DateTime), N'hongtai', 0)
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTenNV], [GioiTinhNV], [NgaySinhNV], [DienThoaiNV], [DiaChiNV], [EmailNV], [NgayVaoLam], [MatKhau], [QuyenHan]) VALUES (N'NV0003', N'Nguyễn Nhật Tú', 1, CAST(0x000081F400000000 AS DateTime), N'0987654321 ', N'Mù Căng Trải', N'nhattu@hotmail.com            ', CAST(0x00009F0500000000 AS DateTime), N'nhattu', 0)
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTenNV], [GioiTinhNV], [NgaySinhNV], [DienThoaiNV], [DiaChiNV], [EmailNV], [NgayVaoLam], [MatKhau], [QuyenHan]) VALUES (N'NV0004', N'Lê Văn Tám Mùi', 1, CAST(0x000083EA00000000 AS DateTime), N'0978555666 ', N'Hà Nội', N'tammui@ovi.com                ', CAST(0x0000A06300000000 AS DateTime), N'tammui', 0)
INSERT [dbo].[NHAXUATBAN] ([MaNXB], [TenNXB], [DiaChiNXB], [DienThoaiNXB], [Website]) VALUES (N'NXB001', N'Kim Đồng', N'Từ Liêm-Minh Khai-HN', N'043-1234567', N'nxbkimdong.com.vn                                 ')
INSERT [dbo].[NHAXUATBAN] ([MaNXB], [TenNXB], [DiaChiNXB], [DienThoaiNXB], [Website]) VALUES (N'NXB002', N'Tuổi Trẻ', N'Đống Đa-Hà Nội', N'043-321564 ', N'tuoitre.vn                                        ')
INSERT [dbo].[NHAXUATBAN] ([MaNXB], [TenNXB], [DiaChiNXB], [DienThoaiNXB], [Website]) VALUES (N'NXB003', N'Lao Động', N'Quận 3, tp HCM', N'083-69258  ', N'laodong.com.vn                                    ')
INSERT [dbo].[PHIEUMUON] ([MaPhieu], [MaDG], [NgayMuon], [MaNV]) VALUES (N'PM0001', N'DG0001', CAST(0x00009FEA00000000 AS DateTime), N'NV0001')
INSERT [dbo].[PHIEUMUON] ([MaPhieu], [MaDG], [NgayMuon], [MaNV]) VALUES (N'PM0002', N'DG0002', CAST(0x0000A06300000000 AS DateTime), N'NV0002')
INSERT [dbo].[SACH] ([MaSach], [TenSach], [NoiDungTT], [SoTrang], [Gia], [SoLuong], [NgayNhap], [MaNXB], [MaTG], [MaTL], [TinhTrang]) VALUES (N'MS000001', N'Kính Vạn Hoa', N'Truyện kể về cuộc điều tra của nhóm học sinh...', 250, 99000, 54, CAST(0x00009BA400000000 AS DateTime), N'NXB001', N'TG0001', N'TL0001', 1)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [NoiDungTT], [SoTrang], [Gia], [SoLuong], [NgayNhap], [MaNXB], [MaTG], [MaTL], [TinhTrang]) VALUES (N'MS000002', N'Trở về tuổi thơ', N'Tâm hồn của một con người sau bao nhiêu năm muốn trở về giống như ngày còn thơ bé...', 66, 36000, 21, CAST(0x0000A06E00000000 AS DateTime), N'NXB001', N'TG0001', N'TL0001', 1)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [NoiDungTT], [SoTrang], [Gia], [SoLuong], [NgayNhap], [MaNXB], [MaTG], [MaTL], [TinhTrang]) VALUES (N'MS000003', N'Lập Trình Windows', N'Giáo trình hướng dẫn lập trình bằng ngôn ngữ C#...', 125, 80000, 122, CAST(0x0000A07B00000000 AS DateTime), N'NXB003', N'TG0003', N'TL0004', 1)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [NoiDungTT], [SoTrang], [Gia], [SoLuong], [NgayNhap], [MaNXB], [MaTG], [MaTL], [TinhTrang]) VALUES (N'MS000004', N'Nguyên Lý HĐH', N'Bài giảng ĐH CN HN', 56, 8500, 19, CAST(0x00009BA400000000 AS DateTime), N'NXB001', N'TG0003', N'TL0004', 1)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [NoiDungTT], [SoTrang], [Gia], [SoLuong], [NgayNhap], [MaNXB], [MaTG], [MaTL], [TinhTrang]) VALUES (N'MS000005', N'English', N'Luyện thi TOIEC', 135, 66000, 36, CAST(0x00009FCB00000000 AS DateTime), N'NXB002', N'TG0001', N'TL0006', 1)
INSERT [dbo].[TACGIA] ([MaTG], [HoTenTG], [DiaChiTG], [DienThoaiTG]) VALUES (N'TG0001', N'Nguyễn Nhật Ánh', N' Quận 3-tp. HCM', N'0904159357 ')
INSERT [dbo].[TACGIA] ([MaTG], [HoTenTG], [DiaChiTG], [DienThoaiTG]) VALUES (N'TG0002', N'Hồ Chí Minh', N'Nghệ An', N'           ')
INSERT [dbo].[TACGIA] ([MaTG], [HoTenTG], [DiaChiTG], [DienThoaiTG]) VALUES (N'TG0003', N'Trần Đăng Khoa', N'TP Hồ Chí Minh', N'063-5268842')
INSERT [dbo].[THELOAI] ([MaTL], [TenTL], [GhiChu]) VALUES (N'TL0001', N'Truyện Ngắn', NULL)
INSERT [dbo].[THELOAI] ([MaTL], [TenTL], [GhiChu]) VALUES (N'TL0002', N'Truyện dài', N'')
INSERT [dbo].[THELOAI] ([MaTL], [TenTL], [GhiChu]) VALUES (N'TL0003', N'Tiểu Thuyết', N'')
INSERT [dbo].[THELOAI] ([MaTL], [TenTL], [GhiChu]) VALUES (N'TL0004', N'Tin Học', N'Hot !')
INSERT [dbo].[THELOAI] ([MaTL], [TenTL], [GhiChu]) VALUES (N'TL0005', N'Truyện Tranh', N'New !')
INSERT [dbo].[THELOAI] ([MaTL], [TenTL], [GhiChu]) VALUES (N'TL0006', N'Văn học', N'')
INSERT [dbo].[TRASACH] ([MaPhieu], [MaSach], [MaNV], [NgayTra], [PhatHuHong], [PhatQuaHan]) VALUES (N'PM0001', N'MS000001', N'NV0002', CAST(0x0000A08700000000 AS DateTime), 9000, 2000)
INSERT [dbo].[TRASACH] ([MaPhieu], [MaSach], [MaNV], [NgayTra], [PhatHuHong], [PhatQuaHan]) VALUES (N'PM0001', N'MS000002', N'NV0002', CAST(0x0000A08A00000000 AS DateTime), 0, 0)
ALTER TABLE [dbo].[CT_PHIEUMUON]  WITH CHECK ADD  CONSTRAINT [FK_CT_PHIEUMUON_PHIEUMUON] FOREIGN KEY([MaPhieu])
REFERENCES [dbo].[PHIEUMUON] ([MaPhieu])
GO
ALTER TABLE [dbo].[CT_PHIEUMUON] CHECK CONSTRAINT [FK_CT_PHIEUMUON_PHIEUMUON]
GO
ALTER TABLE [dbo].[CT_PHIEUMUON]  WITH CHECK ADD  CONSTRAINT [FK_CT_PHIEUMUON_SACH] FOREIGN KEY([MaSach])
REFERENCES [dbo].[SACH] ([MaSach])
GO
ALTER TABLE [dbo].[CT_PHIEUMUON] CHECK CONSTRAINT [FK_CT_PHIEUMUON_SACH]
GO
ALTER TABLE [dbo].[PHIEUMUON]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUMUON_DOCGIA] FOREIGN KEY([MaDG])
REFERENCES [dbo].[DOCGIA] ([MaDG])
GO
ALTER TABLE [dbo].[PHIEUMUON] CHECK CONSTRAINT [FK_PHIEUMUON_DOCGIA]
GO
ALTER TABLE [dbo].[PHIEUMUON]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUMUON_NHANVIEN] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[PHIEUMUON] CHECK CONSTRAINT [FK_PHIEUMUON_NHANVIEN]
GO
ALTER TABLE [dbo].[SACH]  WITH CHECK ADD  CONSTRAINT [FK_SACH_NHAXUATBAN] FOREIGN KEY([MaNXB])
REFERENCES [dbo].[NHAXUATBAN] ([MaNXB])
GO
ALTER TABLE [dbo].[SACH] CHECK CONSTRAINT [FK_SACH_NHAXUATBAN]
GO
ALTER TABLE [dbo].[SACH]  WITH CHECK ADD  CONSTRAINT [FK_SACH_TACGIA] FOREIGN KEY([MaTG])
REFERENCES [dbo].[TACGIA] ([MaTG])
GO
ALTER TABLE [dbo].[SACH] CHECK CONSTRAINT [FK_SACH_TACGIA]
GO
ALTER TABLE [dbo].[SACH]  WITH CHECK ADD  CONSTRAINT [FK_SACH_THELOAI] FOREIGN KEY([MaTL])
REFERENCES [dbo].[THELOAI] ([MaTL])
GO
ALTER TABLE [dbo].[SACH] CHECK CONSTRAINT [FK_SACH_THELOAI]
GO
ALTER TABLE [dbo].[TRASACH]  WITH CHECK ADD  CONSTRAINT [FK_TRASACH_NHANVIEN] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[TRASACH] CHECK CONSTRAINT [FK_TRASACH_NHANVIEN]
GO
ALTER TABLE [dbo].[TRASACH]  WITH CHECK ADD  CONSTRAINT [FK_TRASACH_PHIEUMUON] FOREIGN KEY([MaPhieu])
REFERENCES [dbo].[PHIEUMUON] ([MaPhieu])
GO
ALTER TABLE [dbo].[TRASACH] CHECK CONSTRAINT [FK_TRASACH_PHIEUMUON]
GO
ALTER TABLE [dbo].[TRASACH]  WITH CHECK ADD  CONSTRAINT [FK_TRASACH_SACH] FOREIGN KEY([MaSach])
REFERENCES [dbo].[SACH] ([MaSach])
GO
ALTER TABLE [dbo].[TRASACH] CHECK CONSTRAINT [FK_TRASACH_SACH]
GO
