CREATE DATABASE [QuanLyThuVien] 
GO
USE [QuanLyThuVien]
GO
/****** Object:  Table [dbo].[CT_PHIEUMUON]    Script Date: 12/18/2017 11:21:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING OFF
GO
CREATE TABLE [dbo].[CT_PHIEUMUON](
	[MaPhieu] [varchar](6) NOT NULL,
	[MaSach] [varchar](8) NOT NULL,
	[SoLuong] [int] NOT NULL,
	[NgayTra] [datetime] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 12/18/2017 11:21:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[MaNV] [varchar](6) NOT NULL,
	[HoTen] [nvarchar](30) NOT NULL,
	[GioiTinh] [nvarchar](3) NULL,
	[NgaySinh] [datetime] NOT NULL,
	[DienThoai] [varchar](11) NULL,
	[DiaChi] [nvarchar](100) NULL,
	[Email] [nvarchar](30) NULL,
	[NgayVaoLam] [datetime] NOT NULL,
 CONSTRAINT [PK_NHANVIEN] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NHAXUATBAN]    Script Date: 12/18/2017 11:21:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NHAXUATBAN](
	[MaNXB] [varchar](6) NOT NULL,
	[TenNXB] [nvarchar](100) NOT NULL,
	[DiaChiNXB] [nvarchar](100) NULL,
	[DienThoaiNXB] [varchar](11) NULL,
 CONSTRAINT [PK_NHAXUATBAN] PRIMARY KEY CLUSTERED 
(
	[MaNXB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Permission]    Script Date: 12/18/2017 11:21:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING OFF
GO
CREATE TABLE [dbo].[Permission](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Code] [varchar](50) NOT NULL,
	[Module] [varchar](50) NOT NULL,
	[Name] [nvarchar](255) NOT NULL,
	[Description] [nvarchar](max) NULL,
 CONSTRAINT [PK_Permission] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PHIEUMUON]    Script Date: 12/18/2017 11:21:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PHIEUMUON](
	[MaPhieu] [varchar](6) NOT NULL,
	[MaTV] [varchar](6) NOT NULL,
	[NgayMuon] [datetime] NOT NULL,
	[MaNV] [varchar](6) NOT NULL,
 CONSTRAINT [PK_PHIEUMUON_1] PRIMARY KEY CLUSTERED 
(
	[MaPhieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SACH]    Script Date: 12/18/2017 11:21:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SACH](
	[MaSach] [varchar](8) NOT NULL,
	[TenSach] [nvarchar](100) NOT NULL,
	[SoTrang] [int] NULL,
	[Gia] [bigint] NULL,
	[SoLuong] [int] NULL,
	[NgayNhap] [datetime] NULL,
	[MaNXB] [varchar](6) NOT NULL,
	[MaTG] [varchar](6) NOT NULL,
	[MaTL] [varchar](6) NOT NULL,
	[TinhTrang] [bit] NULL,
 CONSTRAINT [PK_SACH_1] PRIMARY KEY CLUSTERED 
(
	[MaSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TACGIA]    Script Date: 12/18/2017 11:21:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TACGIA](
	[MaTG] [varchar](6) NOT NULL,
	[HoTenTG] [nvarchar](30) NOT NULL,
	[DiaChiTG] [nvarchar](100) NULL,
	[DienThoaiTG] [varchar](11) NULL,
 CONSTRAINT [PK_TACGIA] PRIMARY KEY CLUSTERED 
(
	[MaTG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[THANHVIEN]    Script Date: 12/18/2017 11:21:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[THANHVIEN](
	[MaTV] [varchar](6) NOT NULL,
	[HoTen] [nvarchar](30) NOT NULL,
	[Email] [nvarchar](30) NULL,
	[GioiTinh] [nvarchar](3) NULL,
	[NgaySinh] [datetime] NULL,
	[DiaChi] [nvarchar](100) NULL,
	[DienThoai] [varchar](50) NULL,
	[NgayLamThe] [datetime] NULL,
	[NgayHetHan] [datetime] NULL,
 CONSTRAINT [PK_DOCGIA] PRIMARY KEY CLUSTERED 
(
	[MaTV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[THELOAI]    Script Date: 12/18/2017 11:21:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[THELOAI](
	[MaTL] [varchar](6) NOT NULL,
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
/****** Object:  Table [dbo].[TINHTRANGSACH]    Script Date: 12/18/2017 11:21:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TINHTRANGSACH](
	[IDTT] [int] IDENTITY(1,1) NOT NULL,
	[MaSach] [varchar](8) NULL,
	[DaMuon] [int] NULL,
	[ConLai] [int] NULL,
 CONSTRAINT [PK_TINHTRANGSACH] PRIMARY KEY CLUSTERED 
(
	[IDTT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TRASACH]    Script Date: 12/18/2017 11:21:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING OFF
GO
CREATE TABLE [dbo].[TRASACH](
	[MaPhieu] [varchar](6) NOT NULL,
	[MaSach] [varchar](8) NOT NULL,
	[MaNV] [varchar](6) NOT NULL,
	[SoLuong] [int] NOT NULL,
	[SachTraNgay] [datetime] NOT NULL,
	[PhatHuHong] [bigint] NULL,
	[PhatQuaHan] [bigint] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[User]    Script Date: 12/18/2017 11:21:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING OFF
GO
CREATE TABLE [dbo].[User](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Username] [varchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[MaTV] [varchar](6) NULL,
	[MaNV] [varchar](6) NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[UserPermission]    Script Date: 12/18/2017 11:21:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserPermission](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NOT NULL,
	[PermissionID] [int] NOT NULL,
	[Status] [int] NOT NULL,
 CONSTRAINT [PK_UserPermission] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [GioiTinh], [NgaySinh], [DienThoai], [DiaChi], [Email], [NgayVaoLam]) VALUES (N'NV0001', N'Vũ Văn Tuấn', N'Nam', CAST(0x0000836600000000 AS DateTime), N'0979321343 ', N'Bắc Giang', N'vuvantuan92@gmail.com         ', CAST(0x00009CF100000000 AS DateTime))
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [GioiTinh], [NgaySinh], [DienThoai], [DiaChi], [Email], [NgayVaoLam]) VALUES (N'NV0002', N'Nguyễn Hồng Tài', N'Nam', CAST(0x0000827700000000 AS DateTime), N'0986123456 ', N'Nghệ An', N'hongtai@gmail.com             ', CAST(0x00009D9800000000 AS DateTime))
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [GioiTinh], [NgaySinh], [DienThoai], [DiaChi], [Email], [NgayVaoLam]) VALUES (N'NV0003', N'Nguyễn Nhật Tú', N'Nam', CAST(0x000081F400000000 AS DateTime), N'0987654321 ', N'Mù Căng Trải', N'nhattu@hotmail.com            ', CAST(0x00009F0500000000 AS DateTime))
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [GioiTinh], [NgaySinh], [DienThoai], [DiaChi], [Email], [NgayVaoLam]) VALUES (N'NV0004', N'Lê Văn Tám Mùi', N'Nam', CAST(0x000083EA00000000 AS DateTime), N'0978555666 ', N'Hà Nội', N'tammui@ovi.com                ', CAST(0x0000A06300000000 AS DateTime))
GO
INSERT [dbo].[NHAXUATBAN] ([MaNXB], [TenNXB], [DiaChiNXB], [DienThoaiNXB]) VALUES (N'NXB001', N'Kim Đồng', N'Từ Liêm-Minh Khai-HN', N'043-1234567')
INSERT [dbo].[NHAXUATBAN] ([MaNXB], [TenNXB], [DiaChiNXB], [DienThoaiNXB]) VALUES (N'NXB002', N'Tuổi Trẻ', N'Đống Đa-Hà Nội', N'043-321564')
INSERT [dbo].[NHAXUATBAN] ([MaNXB], [TenNXB], [DiaChiNXB], [DienThoaiNXB]) VALUES (N'NXB003', N'Lao Động', N'Quận 3, tp HCM', N'083-69258 ')
GO
SET IDENTITY_INSERT [dbo].[Permission] ON 
INSERT [dbo].[Permission] ([ID], [Code], [Module], [Name], [Description]) VALUES (1, N'ADMIN', N'MAIN', N'ADMIN', NULL)
INSERT [dbo].[Permission] ([ID], [Code], [Module], [Name], [Description]) VALUES (2, N'TV', N'MAIN', N'TV', NULL)
SET IDENTITY_INSERT [dbo].[Permission] OFF
GO
INSERT [dbo].[SACH] ([MaSach], [TenSach], [SoTrang], [Gia], [SoLuong], [NgayNhap], [MaNXB], [MaTG], [MaTL], [TinhTrang]) VALUES (N'MS000001', N'Kính Va?n Hoa', 250, 99000, 56, CAST(0x00009BA400000000 AS DateTime), N'NXB001', N'TG0001', N'TL0001', 1)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [SoTrang], [Gia], [SoLuong], [NgayNhap], [MaNXB], [MaTG], [MaTL], [TinhTrang]) VALUES (N'MS000002', N'Van', 66, 36000, 21, CAST(0x0000A06F00000000 AS DateTime), N'NXB001', N'TG0001', N'TL0001', 1)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [SoTrang], [Gia], [SoLuong], [NgayNhap], [MaNXB], [MaTG], [MaTL], [TinhTrang]) VALUES (N'MS000003', N'Lập Trình Windows', 125, 80000, 122, CAST(0x0000A07B00000000 AS DateTime), N'NXB003', N'TG0003', N'TL0004', 1)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [SoTrang], [Gia], [SoLuong], [NgayNhap], [MaNXB], [MaTG], [MaTL], [TinhTrang]) VALUES (N'MS000004', N'Nguyên Lý HĐH', 56, 8500, 19, CAST(0x00009BA400000000 AS DateTime), N'NXB001', N'TG0003', N'TL0004', 1)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [SoTrang], [Gia], [SoLuong], [NgayNhap], [MaNXB], [MaTG], [MaTL], [TinhTrang]) VALUES (N'MS000005', N'English', 135, 66000, 36, CAST(0x00009FCB00000000 AS DateTime), N'NXB002', N'TG0001', N'TL0006', 1)
GO
INSERT [dbo].[TACGIA] ([MaTG], [HoTenTG], [DiaChiTG], [DienThoaiTG]) VALUES (N'TG0001', N'Nguyễn Nhật Ánh', N' Quận 3-tp. HCM', N'0904159357 ')
INSERT [dbo].[TACGIA] ([MaTG], [HoTenTG], [DiaChiTG], [DienThoaiTG]) VALUES (N'TG0002', N'Hồ Chí Minh', N'Nghệ An', N'           ')
INSERT [dbo].[TACGIA] ([MaTG], [HoTenTG], [DiaChiTG], [DienThoaiTG]) VALUES (N'TG0003', N'Trần Đăng Khoa', N'TP Hồ Chí Minh', N'063-5268842')
GO
INSERT [dbo].[THANHVIEN] ([MaTV], [HoTen], [Email], [GioiTinh], [NgaySinh], [DiaChi], [DienThoai], [NgayLamThe], [NgayHetHan]) VALUES (N'DG0001', N'Lê Thị Hải', N'haile@gmail.com', N'Nữ', CAST(0x00007EFB00000000 AS DateTime), N'Nghệ An', N'0988666888 ', CAST(0x0000A00900000000 AS DateTime), CAST(0x0000AC8F00000000 AS DateTime))
INSERT [dbo].[THANHVIEN] ([MaTV], [HoTen], [Email], [GioiTinh], [NgaySinh], [DiaChi], [DienThoai], [NgayLamThe], [NgayHetHan]) VALUES (N'DG0002', N'Nguyễn Thị Hà', N'nguyenthiha@gmail.com', N'Nữ', CAST(0x000083EA00000000 AS DateTime), N'Vĩnh Phúc', N'0987369852 ', CAST(0x00009E5E00000000 AS DateTime), CAST(0x0000A13800000000 AS DateTime))
INSERT [dbo].[THANHVIEN] ([MaTV], [HoTen], [Email], [GioiTinh], [NgaySinh], [DiaChi], [DienThoai], [NgayLamThe], [NgayHetHan]) VALUES (N'DG0003', N'Hà Thị Thu Trang', N'thutrang@gmail.com', N'Nữ', CAST(0x000083DB00000000 AS DateTime), N'Bắc Giang', N'0916234567 ', CAST(0x0000A06300000000 AS DateTime), CAST(0x0000A1E200000000 AS DateTime))
GO
INSERT [dbo].[THELOAI] ([MaTL], [TenTL], [GhiChu]) VALUES (N'TL0001', N'Truyện Ngắn', NULL)
INSERT [dbo].[THELOAI] ([MaTL], [TenTL], [GhiChu]) VALUES (N'TL0002', N'Truyện dài', N'')
INSERT [dbo].[THELOAI] ([MaTL], [TenTL], [GhiChu]) VALUES (N'TL0003', N'Tiểu Thuyết', N'')
INSERT [dbo].[THELOAI] ([MaTL], [TenTL], [GhiChu]) VALUES (N'TL0004', N'Tin Học', N'Hot !')
INSERT [dbo].[THELOAI] ([MaTL], [TenTL], [GhiChu]) VALUES (N'TL0005', N'Truyện Tranh', N'New !')
INSERT [dbo].[THELOAI] ([MaTL], [TenTL], [GhiChu]) VALUES (N'TL0006', N'Văn học', N'')
GO
SET IDENTITY_INSERT [dbo].[User] ON 
INSERT [dbo].[User] ([ID], [Username], [Password], [MaTV], [MaNV]) VALUES (1, N'admin', N'ŒivåµA½é½Mîß±g©ÈsüK¸¨o*´H©', NULL, N'NV0001')
INSERT [dbo].[User] ([ID], [Username], [Password], [MaTV], [MaNV]) VALUES (2, N'tv', N'¤n]+¾-;²Ò‹`TÙŒkÎ(‰=àPrAhmU‡',N'DG0001',NULL)
SET IDENTITY_INSERT [dbo].[User] OFF
GO
SET IDENTITY_INSERT [dbo].[UserPermission] ON 
INSERT [dbo].[UserPermission] ([ID], [UserID], [PermissionID], [Status]) VALUES (1, 1, 1, 0)
INSERT [dbo].[UserPermission] ([ID], [UserID], [PermissionID], [Status]) VALUES (2, 2, 2, 0)
SET IDENTITY_INSERT [dbo].[UserPermission] OFF
GO
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
ALTER TABLE [dbo].[PHIEUMUON]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUMUON_NHANVIEN] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[PHIEUMUON] CHECK CONSTRAINT [FK_PHIEUMUON_NHANVIEN]
GO
ALTER TABLE [dbo].[PHIEUMUON]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUMUON_THANHVIEN] FOREIGN KEY([MaTV])
REFERENCES [dbo].[THANHVIEN] ([MaTV])
GO
ALTER TABLE [dbo].[PHIEUMUON] CHECK CONSTRAINT [FK_PHIEUMUON_THANHVIEN]
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
ALTER TABLE [dbo].[TINHTRANGSACH]  WITH CHECK ADD  CONSTRAINT [FK_TINHTRANGSACH_SACH] FOREIGN KEY([MaSach])
REFERENCES [dbo].[SACH] ([MaSach])
GO
ALTER TABLE [dbo].[TINHTRANGSACH] CHECK CONSTRAINT [FK_TINHTRANGSACH_SACH]
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
ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [FK_User_NHANVIEN] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[User] CHECK CONSTRAINT [FK_User_NHANVIEN]
GO
ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [FK_User_THANHVIEN] FOREIGN KEY([MaTV])
REFERENCES [dbo].[THANHVIEN] ([MaTV])
GO
ALTER TABLE [dbo].[User] CHECK CONSTRAINT [FK_User_THANHVIEN]
GO
ALTER TABLE [dbo].[UserPermission]  WITH CHECK ADD  CONSTRAINT [FK_UserPermission_Permission] FOREIGN KEY([PermissionID])
REFERENCES [dbo].[Permission] ([ID])
GO
ALTER TABLE [dbo].[UserPermission] CHECK CONSTRAINT [FK_UserPermission_Permission]
GO
ALTER TABLE [dbo].[UserPermission]  WITH CHECK ADD  CONSTRAINT [FK_UserPermission_User] FOREIGN KEY([UserID])
REFERENCES [dbo].[User] ([ID])
GO
ALTER TABLE [dbo].[UserPermission] CHECK CONSTRAINT [FK_UserPermission_User]
GO
/****** Object:  StoredProcedure [dbo].[DanhSachNhanVien]    Script Date: 12/18/2017 11:21:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[DanhSachNhanVien]
as
Begin
select * from NHANVIEN
end
GO
/****** Object:  StoredProcedure [dbo].[DELETESACH]    Script Date: 12/18/2017 11:21:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DELETESACH]
@MaSach varchar (8)
AS
BEGIN
IF EXISTS(SELECT * FROM SACH WHERE MaSach = @MaSach)
		DELETE FROM SACH WHERE MaSach = @MaSach
END

GO
/****** Object:  StoredProcedure [dbo].[DELETETV]    Script Date: 12/18/2017 11:21:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DELETETV]
@MaTV varchar (6)
AS
BEGIN
IF EXISTS(SELECT * FROM THANHVIEN WHERE MaTV = @MaTV)
		DELETE FROM THANHVIEN WHERE MaTV = @MaTV
END

GO
/****** Object:  StoredProcedure [dbo].[KhoSach]    Script Date: 12/18/2017 11:21:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[KhoSach]
As
Begin
	Select S.MaSach, S.TenSach, S.Gia, TTS.DaMuon, TTS.ConLai
	From SACH as S Join TINHTRANGSACH as TTS
	On s.MaSach = TTS.MaSach
End

GO
/****** Object:  StoredProcedure [dbo].[LOADSACH]    Script Date: 12/18/2017 11:21:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[LOADSACH]
AS
BEGIN
SELECT*FROM SACH
END

GO
/****** Object:  StoredProcedure [dbo].[LOADTHANHVIEN]    Script Date: 12/18/2017 11:21:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[LOADTHANHVIEN]
AS
BEGIN
SELECT*FROM THANHVIEN
END

GO
/****** Object:  StoredProcedure [dbo].[LoadTraSach]    Script Date: 12/18/2017 11:21:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[LoadTraSach]
AS
BEGIN
SELECT * FROM TRASACH
END

GO
/****** Object:  StoredProcedure [dbo].[LuuPhieuTra]    Script Date: 12/18/2017 11:21:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[LuuPhieuTra]
@MaPhieu varchar(6),
@MaSach varchar(8),
@MaNV varchar(6),
@SoLuong int,
@SachTraNgay datetime,
@PhatHuHong bigint,
@PhatQuaHan bigint
as 
BEGIN
	INSERT INTO TRASACH(MaPhieu,MaSach, MaNV,SoLuong, SachTraNgay,PhatHuHong,PhatQuaHan)
	VALUES (@MaPhieu,@MaSach,@MaNV,@SoLuong,@SachTraNgay,@PhatHuHong,@PhatQuaHan)
END

GO
/****** Object:  StoredProcedure [dbo].[MuonSachQuaHan]    Script Date: 12/18/2017 11:21:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[MuonSachQuaHan]
AS
BEGIN
SELECT * FROM(
SELECT     TOP (100) PERCENT dbo.PHIEUMUON.MaPhieu, dbo.CT_PHIEUMUON.MaSach, dbo.SACH.TenSach, dbo.TACGIA.HoTenTG, dbo.THANHVIEN.MaTV, dbo.THANHVIEN.HoTen, dbo.THANHVIEN.DiaChi, dbo.PHIEUMUON.NgayMuon, dbo.CT_PHIEUMUON.NgayTra, dbo.TRASACH.SachTraNgay, DATEDIFF(day, dbo.TRASACH.SachTraNgay, dbo.CT_PHIEUMUON.NgayTra) AS SONGAYQUAHAN
FROM         dbo.PHIEUMUON INNER JOIN
                      dbo.CT_PHIEUMUON ON dbo.PHIEUMUON.MaPhieu = dbo.CT_PHIEUMUON.MaPhieu INNER JOIN
                      dbo.THANHVIEN ON dbo.PHIEUMUON.MaTV = dbo.THANHVIEN.MaTV INNER JOIN
                      dbo.SACH ON dbo.CT_PHIEUMUON.MaSach = dbo.SACH.MaSach INNER JOIN
                      dbo.TACGIA ON dbo.SACH.MaTG = dbo.TACGIA.MaTG INNER JOIN
                      dbo.TRASACH ON dbo.PHIEUMUON.MaPhieu = dbo.TRASACH.MaPhieu AND dbo.SACH.MaSach = dbo.TRASACH.MaSach
WHERE     (dbo.TRASACH.SachTraNgay - dbo.CT_PHIEUMUON.NgayTra > 0) OR
                      (GETDATE() - dbo.CT_PHIEUMUON.NgayTra > 0) AND (dbo.TRASACH.SachTraNgay IS NULL)
ORDER BY dbo.PHIEUMUON.MaPhieu, dbo.CT_PHIEUMUON.MaSach, dbo.SACH.TenSach, dbo.TACGIA.HoTenTG, dbo.THANHVIEN.MaTV, dbo.THANHVIEN.HoTen, dbo.THANHVIEN.DiaChi, dbo.PHIEUMUON.NgayMuon, dbo.CT_PHIEUMUON.NgayTra, dbo.TRASACH.SachTraNgay
) AS A
WHERE A.SONGAYQUAHAN<0
END

GO
/****** Object:  StoredProcedure [dbo].[store_timkiem]    Script Date: 12/18/2017 11:21:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Tim kiem sach
CREATE PROCEDURE [dbo].[store_timkiem] 
@TenSach nvarchar(100)
AS
BEGIN
	SET NOCOUNT ON;
	if Not Exists (Select S.MaSach, S.TenSach, TG.HoTenTG, NXB.TenNXB, TL.TenTL , S.NgayNhap , S.Gia, S.SoLuong
					From SACH as S Inner Join TACGIA as TG
					On TG.MaTG = S.MaTG Inner Join NHAXUATBAN as NXB
					On  S.MaNXB = NXB.MaNXB Inner Join THELOAI as TL
					On S.MaTL = TL.MaTL
					Where S.TenSach Like @TenSach)
	Begin
		(Select S.MaSach, S.TenSach, TG.HoTenTG, NXB.TenNXB, TL.TenTL , S.NgayNhap , S.Gia, S.SoLuong
					From SACH as S Inner Join TACGIA as TG
					On TG.MaTG = S.MaTG Inner Join NHAXUATBAN as NXB
					On  S.MaNXB = NXB.MaNXB Inner Join THELOAI as TL
					On S.MaTL = TL.MaTL
					Where S.MaSach Like @TenSach)
	End
	Else
	Begin
		(Select S.MaSach, S.TenSach, TG.HoTenTG, NXB.TenNXB, TL.TenTL , S.NgayNhap , S.Gia, S.SoLuong
					From SACH as S Inner Join TACGIA as TG
					On TG.MaTG = S.MaTG Inner Join NHAXUATBAN as NXB
					On  S.MaNXB = NXB.MaNXB Inner Join THELOAI as TL
					On S.MaTL = TL.MaTL
					Where S.TenSach Like @TenSach)
	End

END

GO
/****** Object:  StoredProcedure [dbo].[SuaNhanVien]    Script Date: 12/18/2017 11:21:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[SuaNhanVien]
@MaNV varchar(6), @HoTen nvarchar(30), @GioiTinh nvarchar(3) , @NgaySinh DateTime, @DienThoai varchar(11), @DiaChi nvarchar(100),
@Email nvarchar(30), @NgayVaoLam Datetime
As
Begin
IF EXISTS(SELECT * FROM NHANVIEN WHERE MaNV = @MaNV)
BEGIN
	Update NHANVIEN
	Set MaNV = @MaNV, HoTen = @HoTen, GioiTinh = @GioiTinh, NgaySinh = @NgaySinh, DienThoai = @DienThoai, DiaChi = @DiaChi,
	Email = @Email, NgayVaoLam = @NgayVaoLam
	Where MaNV = @MaNV
	END
	ELSE
	INSERT INTO NHANVIEN(MaNV,HoTen,GioiTinh,NgaySinh,DienThoai,DiaChi,Email,NgayVaoLam) VALUES(@MaNV,@HoTen,@GioiTinh,@NgaySinh,@DienThoai,@DiaChi,@Email,@NgayVaoLam)
End


GO
/****** Object:  StoredProcedure [dbo].[ThanhVienMuon]    Script Date: 12/18/2017 11:21:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[ThanhVienMuon]
As
Begin
	Select PM.MaPhieu, S.MaSach, S.TenSach, TV.MaTV, TV.HoTen, PM.NgayMuon, CTPM.NgayTra, CTPM.SoLuong, TV.DiaChi, TV.DienThoai, PM.MaNV
	From SACH as S
	Inner Join CT_PHIEUMUON As CTPM On S.MaSach = CTPM.MaSach 
	JOIN PHIEUMUON PM ON CTPM.MaPhieu = PM.MaPhieu
	Inner Join THANHVIEN As TV
	On TV.MaTV = PM.MaTV
End

GO
/****** Object:  StoredProcedure [dbo].[ThemNhanVien]    Script Date: 12/18/2017 11:21:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[ThemNhanVien]
@MaNV char(6), @HoTen Nvarchar(30), @GioiTinh Bit, @NgaySinh DateTime, @DienThoai char(11), @DiaChi Nvarchar(100),
@Email Nvarchar(30), @NgayVaoLam Datetime
As
Begin
	Insert Into NHANVIEN(MaNV,HoTen,GioiTinh,NgaySinh,DienThoai,DiaChi,Email,NgayVaoLam)
	Values (@MaNV, @HoTen, @GioiTinh, @NgaySinh, @DienThoai,@DiaChi, @Email, @NgayVaoLam);
End


GO
/****** Object:  StoredProcedure [dbo].[ThemPhieuMuon]    Script Date: 12/18/2017 11:21:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[ThemPhieuMuon]
@MaPhieu varchar(6), @MaTV char(6), @NgayMuon Datetime, @MaNV varchar(6), @NgayTra Datetime, @MaSach varchar(8), @SoLuong int
As
Begin
	IF  NOT EXISTS (SELECT * FROM PHIEUMUON WHERE MaPhieu = @MaPhieu and MaTV = @MaTV and NgayMuon= @NgayMuon and MaNV = @MaNV)
		BEGIN
			Insert Into PHIEUMUON(MaPhieu,MaTV,NgayMuon,MaNV)
			Values (@MaPhieu,@MaTV,@NgayMuon,@MaNV)
			Insert into CT_PHIEUMUON(MaPhieu,MaSach,SoLuong,NgayTra)
			Values (@MaPhieu,@MaSach,@SoLuong,@NgayTra)
		END
	ELSE
		Insert into CT_PHIEUMUON(MaPhieu,MaSach,SoLuong,NgayTra)
		Values (@MaPhieu,@MaSach,@SoLuong,@NgayTra)
End


GO
/****** Object:  StoredProcedure [dbo].[ThongTinUser]    Script Date: 12/18/2017 11:21:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Thong tin User
CREATE PROCEDURE [dbo].[ThongTinUser]
@UserID int
AS
BEGIN
	IF EXISTS(SELECT * FROM [dbo].[User] WHERE MaTV IS NULL AND ID = @UserID )
		SELECT u.MaNV,u.MaTV,NV.HoTen,NV.GioiTinh,NV.NgaySinh,NV.DienThoai,NV.Email
			FROM [User] U JOIN NHANVIEN NV ON U.MaNV = NV.MaNV
			WHERE U.ID = @UserID
	 ELSE
	 IF EXISTS(SELECT*FROM [dbo].[User] WHERE MaTV IS NOT NULL)
		SELECT u.MaNV,u.MaTV,TV.HoTen,TV.GioiTinh,TV.NgaySinh,TV.DienThoai,TV.Email
		FROM [User] U JOIN THANHVIEN TV ON U.MaTV = TV.MaTV
		WHERE U.ID = @UserID
END

GO
/****** Object:  StoredProcedure [dbo].[TimKiemNV]    Script Date: 12/18/2017 11:21:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[TimKiemNV]
@TenNV Nvarchar(100)
As
Begin
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
  -- Insert statements for procedure here
	if Not Exists (Select *
					From NHANVIEN As NV
					Where NV.HoTen Like @TenNV)
	Begin
				(Select *
					From NHANVIEN As NV
					Where NV.MaNV Like @TenNV)
	End
	Else
	Begin
				(Select *
					From NHANVIEN As NV
					Where NV.HoTen Like @TenNV)
	End
End


GO
/****** Object:  StoredProcedure [dbo].[TimNV]    Script Date: 12/18/2017 11:21:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TimNV]
@MaNV varchar (6)
AS
BEGIN
IF EXISTS(SELECT * FROM NHANVIEN WHERE MaNV LIKE '%'+@MaNV+'%')
		SELECT * FROM NHANVIEN WHERE MaNV LIKE '%'+@MaNV+'%'
END

GO
/****** Object:  StoredProcedure [dbo].[TimSach]    Script Date: 12/18/2017 11:21:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TimSach]
@Sach varchar (100)
AS
BEGIN
IF EXISTS(SELECT * FROM SACH WHERE MaSach LIKE '%'+@Sach+'%')
		SELECT * FROM SACH WHERE MaSach LIKE '%'+@Sach+'%'
END

GO
/****** Object:  StoredProcedure [dbo].[TimTV]    Script Date: 12/18/2017 11:21:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TimTV]
@MaTV varchar (6)
AS
BEGIN
IF EXISTS(SELECT * FROM THANHVIEN WHERE MaTV LIKE '%'+@MaTV+'%')
		SELECT * FROM THANHVIEN WHERE MatV LIKE '%'+@MaTV+'%'
END

GO
/****** Object:  StoredProcedure [dbo].[UPDATEANDINSERT]    Script Date: 12/18/2017 11:21:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UPDATEANDINSERT]
@MaSach varchar (8),
@TenSach varchar(100),
@MaTacGia varchar(6),
@MaTheLoai varchar(6),
@SoLuong int,
@DonGia bigint,
@MaNXB varchar (6),
@SoTrang int,
@TinhTrang bit,
@NgayNhap Datetime
AS
BEGIN
	IF EXISTS(SELECT * FROM SACH WHERE MaSach = @MaSach)
	UPDATE SACH SET MaSach = @MaSach, TenSach= @TenSach,SoTrang = @SoTrang,Gia=@DonGia,SoLuong=@SoLuong, NgayNhap = @NgayNhap, MaNXB=@MaNXB, MaTG =@MaTacGia,MaTL =@MaTheLoai,TinhTrang = @TinhTrang WHERE MaSach = @MaSach
	ELSE	
	INSERT INTO SACH(MaSach,TenSach,SoTrang,Gia,SoLuong,NgayNhap,MaNXB,MaTG,MaTL,TinhTrang) VALUES(@MaSach,@TenSach,@SoTrang,@DonGia,@SoLuong,@NgayNhap,@MaNXB,@MaTacGia,@MaTheLoai,@TinhTrang)
END

GO
/****** Object:  StoredProcedure [dbo].[UPDATEANDINSERTTV]    Script Date: 12/18/2017 11:21:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UPDATEANDINSERTTV]
@MaTV varchar (6),
@HoTen varchar(30),
@Email varchar(30),
@GioiTinh varchar(3),
@NgaySinh Datetime,
@DiaChi nvarchar(100),
@DienThoai char(11),
@NgayLamThe Datetime,
@NgayHetHan Datetime
AS
BEGIN
	IF EXISTS(SELECT * FROM THANHVIEN WHERE MaTV = @MaTV)
	UPDATE THANHVIEN SET MaTV = @MaTV, HoTen= @HoTen,Email = @Email,GioiTinh=@GioiTinh,NgaySinh=@NgaySinh, DiaChi = @DiaChi, DienThoai=@DienThoai, NgayLamThe =@NgayLamThe,NgayHetHan =@NgayHetHan WHERE MaTV = @MaTV
	ELSE	
	INSERT INTO THANHVIEN(MaTV,HoTen,Email,GioiTinh,NgaySinh,DiaChi,DienThoai,NgayLamThe,NgayHetHan) VALUES(@MaTV,@HoTen,@Email,@GioiTinh,@NgaySinh,@DiaChi,@DienThoai,@NgayLamThe,@NgayHetHan)
END

GO
/****** Object:  StoredProcedure [dbo].[usp_USER_ChangePassword]    Script Date: 12/18/2017 11:21:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_USER_ChangePassword]
@psUsername varchar(50),
@psPassword varchar(50),
@psChangePasword varchar(50),
@pResultCode int output,
@pResultMessage varchar(50) output
AS
BEGIN
	--Chuyen Password Ma Hoa
	DECLARE @lPasswordHash varchar(32)
	DECLARE @lChangePasswordHash varchar(32)
	SET @lPasswordHash = HASHBYTES('SHA2_256', @psPassword)
	SET @lChangePasswordHash = HASHBYTES('SHA2_256', @psChangePasword)
	--KT User, Pass
	IF Exists(Select ID from [User] where UserName = @psUsername and PassWord = @lPasswordHash)
	--Neu Ton Tai
	BEGIN
		--Doi MK
		Update [User] SET PassWord = @lChangePasswordHash WHERE UserName = @psUsername 
		SELECT @pResultCode = ID, @pResultMessage = 'CHANGEPASSWORDOK' from [User] where UserName = @psUsername and PassWord = @lChangePasswordHash
		RETURN
	END
	--Khong Ton Tai
	ELSE
	BEGIN
		SELECT @pResultCode = -1 , @pResultMessage = 'CHANGEPASSWORDFAILED' 
		RETURN
	END
END

GO
/****** Object:  StoredProcedure [dbo].[usp_USER_CheckUser]    Script Date: 12/18/2017 11:21:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_USER_CheckUser]
@psUsername varchar(50),
@psPassword varchar(50),
@pResultCode int output,
@pResultMessage varchar(50) output
AS
BEGIN
	DECLARE @lPasswordHash varchar(32)
	SET @lPasswordHash = HASHBYTES('SHA2_256', @psPassword)
	IF Not Exists(Select ID from [User] where UserName = @psUsername and PassWord = @lPasswordHash)
	BEGIN
		SELECT @pResultCode = -1, @pResultMessage = 'LOGINFAILED'
		RETURN
	END
	ELSE
	BEGIN
		SELECT @pResultCode = ID , @pResultMessage = 'LOGINOK'  from [User] where UserName = @psUsername and PassWord = @lPasswordHash
		RETURN
	END
END

GO
/****** Object:  StoredProcedure [dbo].[usp_USER_CreateUser]    Script Date: 12/18/2017 11:21:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_USER_CreateUser]
	@psUsername varchar(50)
	,@psPassword varchar(255)
	,@MaTV varchar (6)
	,@MaNV varchar (6)
	,@pResultCode int output
	,@pResultMessage varchar(50) output
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	DECLARE @lPasswordHash varchar(32)
	,@Ma char (6)
	IF Exists(Select ID from [User] WHERE Username = @psUsername)
	BEGIN
		SELECT @pResultCode = -1, @pResultMessage = 'USEREXISTED'
		RETURN
	END

	SET @lPasswordHash = HASHBYTES('SHA2_256', @psPassword)
	--IF((@MaNV != NULL AND @MaTV = NULL)OR(@MaNV = NULL AND @MaTV != NULL))
	--BEGIN
	INSERT INTO [User](Username, Password, MaTV, MaNV) Values(@psUsername, @lPasswordHash,@MaTV,@MaNV)
	SELECT @pResultCode = SCOPE_IDENTITY(), @pResultMessage = 'USERCREATEDOK'
	RETURN
	--END
END

GO
/****** Object:  StoredProcedure [dbo].[usp_USER_DeleteUser]    Script Date: 12/18/2017 11:21:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_USER_DeleteUser]
@psUsername varchar(50),
@psPassword varchar(50),
@pResultCode int output,
@pResultMessage varchar(50) output
AS
BEGIN
	--Chuyen Password Ma Hoa
	DECLARE @lPasswordHash varchar(32)
	SET @lPasswordHash = HASHBYTES('SHA2_256', @psPassword)
	--KT User, Pass
	IF Exists(Select ID from [User] where UserName = @psUsername and PassWord = @lPasswordHash)
	--Neu Ton Tai
	BEGIN	
		--Thong Bao Thanh Cong
		SELECT @pResultCode = ID, @pResultMessage = 'DELETEUSEROK' from [User] where UserName = @psUsername and PassWord = @lPasswordHash
		--Xoa User
		DELETE FROM [User] WHERE UserName = @psUsername
		RETURN
	END
	--Khong Ton Tai
	ELSE
	BEGIN
		SELECT @pResultCode = -1 , @pResultMessage = 'DELETEUSERFAILED' 
		RETURN
	END
END

GO
/****** Object:  StoredProcedure [dbo].[usp_USER_GetUserPermision]    Script Date: 12/18/2017 11:21:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================

CREATE PROCEDURE [dbo].[usp_USER_GetUserPermision]
	@piUserID int,
	@psModule varchar(50)
AS
BEGIN
	
	SET NOCOUNT ON;
	SELECT UP.UserID, P.Code as PermissionCode FROM UserPermission UP JOIN Permission P ON P.ID = UP.PermissionID
	WHERE UP.UserID = @piUserID AND P.Module = @psModule
END

GO
/****** Object:  StoredProcedure [dbo].[XoaNhanVien]    Script Date: 12/18/2017 11:21:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--Procedure Xóa Nhân Viên
Create Procedure [dbo].[XoaNhanVien]
@MaNV varchar(6)
As
Begin
		Delete From NHANVIEN Where MaNV = @MaNV
End

GO

/****** Object:  Trigger [dbo].[AddChiTietPhieuMuon]    Script Date: 12/18/2017 11:21:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Trigger [dbo].[AddChiTietPhieuMuon] On [dbo].[CT_PHIEUMUON] 
for Insert,update
As
Begin
	declare @MS varchar(8), @DM int = 0, @CL int = 0 , @TS int, @DemS int
	SELECT @DM = SUM(SoLuong),@MS = MaSach from CT_PHIEUMUON
	GROUP BY MaSach
	--select SoLuong, MaSach from CT_PHIEUMUON
	--select @DM=SoLuong, @MS = MaSach from inserted
	select @TS = SoLuong from SACH where MaSach = @MS
	declare @AV int = @TS - @DM

	--select COUNT(SoLuong) from  CT_PHIEUMUON where MaSach = 'MS000001'
	select @DemS = count(*) from TINHTRANGSACH where  MaSach = @MS
	

	
	if(@DemS > 0)
	begin
		declare @DM1 int
		Declare @DM2 int
		
		Select  @DM1 = DaMuon from TINHTRANGSACH where MaSach = @MS
		select @DM2 = SoLuong  from CT_PHIEUMUON where MaSach = @MS
		declare @JAV int
		set  @JAV = @TS - (@DM1 + @DM2)

			if(@JAV < 0)
				begin
					print 'So luong con lai khong phu hop'
					rollback 
				end
			else
				begin


					update TINHTRANGSACH
					set  DaMuon = @DM1 + @DM2, ConLai = @JAV
					where MaSach = @MS
				end
	end			
	else
	begin
			insert into TINHTRANGSACH(MaSach,DaMuon,ConLai)
			values(@MS,@DM,@AV)
	end
End
GO
CREATE Trigger [dbo].[AddChiTietPhieuTra] On [dbo].[TRASACH] 
for Insert,update
As
Begin
	declare @MS varchar(8), @DM int = 0, @CL int = 0 , @TS int, @DemS int
	SELECT @DM = SUM(SoLuong),@MS = MaSach from TRASACH
	GROUP BY MaSach
	select @TS = SoLuong from SACH where MaSach = @MS
	select @DemS = count(*) from TINHTRANGSACH where  MaSach = @MS
	

	
	if(@DemS > 0)
	begin
		declare @DM1 int
		Declare @DM2 int
		
		Select  @DM1 = DaMuon, @DM2 = ConLai from TINHTRANGSACH where MaSach = @MS
		declare @KQ1 int,@KQ2 int
		set  @KQ1 = @DM1-@DM
		set @KQ2 = @DM2 +@DM

			if(@KQ1 < 0)
				begin
					print 'So luong con lai khong phu hop'
					rollback 
				end
			else
				begin
					update TINHTRANGSACH
					set  DaMuon = @KQ1, ConLai = @KQ2
					where MaSach = @MS
				end
	end			
End
/****** Object:  StoredProcedure [dbo].[updateThongTin]    Script Date: 12/19/2017 12:35:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[updateThongTin]
@Ma varchar(6),
@HoTen nvarchar(30),
@Email nvarchar(30),
@GioiTinh nvarchar(3),
@NgaySinh datetime,
@DienThoai varchar(11)
AS
BEGIN
 IF EXISTS(SELECT * FROM THANHVIEN WHERE MaTV = @Ma)
	UPDATE THANHVIEN SET HoTen = @HoTen, Email=@Email, GioiTinh = @GioiTinh, NgaySinh = @NgaySinh, DienThoai = @DienThoai
	WHERE MaTV = @Ma
ELSE
	UPDATE NHANVIEN SET HoTen = @HoTen, Email=@Email, GioiTinh = @GioiTinh, NgaySinh = @NgaySinh, DienThoai = @DienThoai
	WHERE MaNV = @Ma
END
GO