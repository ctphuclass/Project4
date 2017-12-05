CREATE DATABASE QuanLyThuVien
GO
USE QuanLyThuVien
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
CREATE TABLE [dbo].[THANHVIEN](
	[MaTV] [char](6) NOT NULL,
	[HoTen] [nvarchar](30) NOT NULL,
	[Email] [nvarchar](30) NULL,
	[GioiTinh] [nvarchar](3) NULL,
	[NgaySinh] [datetime] NULL,
	[DiaChi] [nvarchar](100) NULL,
	[DienThoai] [char](11) NULL,
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
CREATE TABLE [dbo].[User](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Username] [varchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[MaTV] [char](6) NULL,
	[MaNV] [char](6) NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
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
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 11/19/2017 7:02:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[MaNV] [char](6) NOT NULL,
	[HoTen] [nvarchar](30) NOT NULL,
	[GioiTinh] [nvarchar](3) NULL,
	[NgaySinh] [datetime] NOT NULL,
	[DienThoai] [char](11) NULL,
	[DiaChi] [nvarchar](100) NULL,
	[Email] [nchar](30) NULL,
	[NgayVaoLam] [datetime] NOT NULL,
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
	[MaTV] [char](6) NOT NULL,
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
Alter PROCEDURE [dbo].[store_timkiem] 
	-- Add the parameters for the stored procedure here
@TenSach nvarchar(100)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
  -- Insert statements for procedure here
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

INSERT dbo.THANHVIEN ([MaTV], [HoTen], [Email], [GioiTinh], [NgaySinh], [DiaChi], [DienThoai], [NgayLamThe], [NgayHetHan]) VALUES (N'DG0001', N'Lê Thị Hải', N'haile@gmail.com', N'Nữ', CAST(0x00007EFB00000000 AS DateTime), N'Nghệ An', N'0988666888 ', CAST(0x0000A00900000000 AS DateTime), CAST(0x0000AC8F00000000 AS DateTime))
INSERT dbo.THANHVIEN ([MaTV], [HoTen], [Email], [GioiTinh], [NgaySinh], [DiaChi], [DienThoai], [NgayLamThe], [NgayHetHan]) VALUES (N'DG0002', N'Nguyễn Thị Hà', N'nguyenthiha@gmail.com',N'Nữ', CAST(0x000083EA00000000 AS DateTime), N'Vĩnh Phúc', N'0987369852 ', CAST(0x00009E5E00000000 AS DateTime), CAST(0x0000A13800000000 AS DateTime))
INSERT dbo.THANHVIEN ([MaTV], [HoTen], [Email], [GioiTinh], [NgaySinh], [DiaChi], [DienThoai], [NgayLamThe], [NgayHetHan]) VALUES (N'DG0003', N'Hà Thị Thu Trang', N'thutrang@gmail.com', N'Nữ', CAST(0x000083DB00000000 AS DateTime), N'Bắc Giang', N'0916234567 ', CAST(0x0000A06300000000 AS DateTime), CAST(0x0000A1E200000000 AS DateTime))
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [GioiTinh], [NgaySinh], [DienThoai], [DiaChi], [Email], [NgayVaoLam]) VALUES (N'NV0001', N'Vũ Văn Tuân', N'Nam', CAST(0x0000836600000000 AS DateTime), N'0979321343 ', N'Bắc Giang', N'vuvantuan92@gmail.com         ', CAST(0x00009CF100000000 AS DateTime))
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [GioiTinh], [NgaySinh], [DienThoai], [DiaChi], [Email], [NgayVaoLam]) VALUES (N'NV0002', N'Nguyễn Hồng Tài', N'Nam', CAST(0x0000827700000000 AS DateTime), N'0986123456 ', N'Nghệ An', N'hongtai@gmail.com             ', CAST(0x00009D9800000000 AS DateTime))
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [GioiTinh], [NgaySinh], [DienThoai], [DiaChi], [Email], [NgayVaoLam]) VALUES (N'NV0003', N'Nguyễn Nhật Tú', N'Nam', CAST(0x000081F400000000 AS DateTime), N'0987654321 ', N'Mù Căng Trải', N'nhattu@hotmail.com            ', CAST(0x00009F0500000000 AS DateTime))
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [GioiTinh], [NgaySinh], [DienThoai], [DiaChi], [Email], [NgayVaoLam]) VALUES (N'NV0004', N'Lê Văn Tám Mùi', N'Nam', CAST(0x000083EA00000000 AS DateTime), N'0978555666 ', N'Hà Nội', N'tammui@ovi.com                ', CAST(0x0000A06300000000 AS DateTime))
INSERT [dbo].[NHAXUATBAN] ([MaNXB], [TenNXB], [DiaChiNXB], [DienThoaiNXB]) VALUES (N'NXB001', N'Kim Đồng', N'Từ Liêm-Minh Khai-HN', N'043-1234567')
INSERT [dbo].[NHAXUATBAN] ([MaNXB], [TenNXB], [DiaChiNXB], [DienThoaiNXB]) VALUES (N'NXB002', N'Tuổi Trẻ', N'Đống Đa-Hà Nội', N'043-321564')
INSERT [dbo].[NHAXUATBAN] ([MaNXB], [TenNXB], [DiaChiNXB], [DienThoaiNXB]) VALUES (N'NXB003', N'Lao Động', N'Quận 3, tp HCM', N'083-69258 ')
INSERT [dbo].[PHIEUMUON] ([MaPhieu], [MaTV], [NgayMuon], [MaNV]) VALUES (N'PM0001', N'DG0001', CAST(0x00009FEA00000000 AS DateTime), N'NV0001')
INSERT [dbo].[PHIEUMUON] ([MaPhieu], [MaTV], [NgayMuon], [MaNV]) VALUES (N'PM0002', N'DG0002', CAST(0x0000A06300000000 AS DateTime), N'NV0002')
INSERT [dbo].[SACH] ([MaSach],[TenSach],[SoTrang],[Gia],[SoLuong],[NgayNhap],[MaNXB],[MaTG],[MaTL],[TinhTrang]) VALUES (N'MS000001', N'Kính Vạn Hoa', 250, 99000, 54, CAST(0x00009BA400000000 AS DateTime), N'NXB001', N'TG0001', N'TL0001', 1)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [SoTrang], [Gia], [SoLuong], [NgayNhap], [MaNXB], [MaTG], [MaTL], [TinhTrang]) VALUES (N'MS000002', N'Trở về tuổi thơ', 66, 36000, 21, CAST(0x0000A06E00000000 AS DateTime), N'NXB001', N'TG0001', N'TL0001', 1)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [SoTrang], [Gia], [SoLuong], [NgayNhap], [MaNXB], [MaTG], [MaTL], [TinhTrang]) VALUES (N'MS000003', N'Lập Trình Windows', 125, 80000, 122, CAST(0x0000A07B00000000 AS DateTime), N'NXB003', N'TG0003', N'TL0004', 1)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [SoTrang], [Gia], [SoLuong], [NgayNhap], [MaNXB], [MaTG], [MaTL], [TinhTrang]) VALUES (N'MS000004', N'Nguyên Lý HĐH', 56, 8500, 19, CAST(0x00009BA400000000 AS DateTime), N'NXB001', N'TG0003', N'TL0004', 1)
INSERT [dbo].[SACH] ([MaSach], [TenSach], [SoTrang], [Gia], [SoLuong], [NgayNhap], [MaNXB], [MaTG], [MaTL], [TinhTrang]) VALUES (N'MS000005', N'English', 135, 66000, 36, CAST(0x00009FCB00000000 AS DateTime), N'NXB002', N'TG0001', N'TL0006', 1)
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
INSERT [dbo].[User] ([Username], [Password], [MaTV], [MaNV]) VALUES ( N'admin', N'ŒivåµA½é½Mîß±g©ÈsüK¸¨o*´H©', NULL, N'NV0001')
INSERT [dbo].[User] ([Username], [Password], [MaTV], [MaNV]) VALUES ( N'tv', N'¤n]+¾-;²Ò‹`TÙŒkÎ(‰=àPrAhmU‡', N'DG0001', NULL)

INSERT [dbo].[Permission] ([Code], [Module], [Name], [Description]) VALUES ( N'ADMIN', N'MAIN', N'ADMIN', NULL)
INSERT [dbo].[Permission] ([Code], [Module], [Name], [Description]) VALUES ( N'TV', N'MAIN', N'TV', NULL)

INSERT [dbo].[UserPermission] ([UserID], [PermissionID], [Status]) VALUES ( 1, 1, 0)
INSERT [dbo].[UserPermission] ([UserID], [PermissionID], [Status]) VALUES ( 2, 2, 0)
INSERT [dbo].[CT_PHIEUMUON] ([MaPhieu], [MaSach], [HanTra]) VALUES (N'PM0001', N'MS000001', CAST(0x0000A0C700000000 AS DateTime))
INSERT [dbo].[CT_PHIEUMUON] ([MaPhieu], [MaSach], [HanTra]) VALUES (N'PM0001', N'MS000002', CAST(0x0000A0C700000000 AS DateTime))
INSERT [dbo].[CT_PHIEUMUON] ([MaPhieu], [MaSach], [HanTra]) VALUES (N'PM0002', N'MS000003', CAST(0x0000A0DC00000000 AS DateTime))
ALTER TABLE [dbo].[CT_PHIEUMUON]  WITH CHECK ADD  CONSTRAINT [FK_CT_PHIEUMUON_PHIEUMUON] FOREIGN KEY([MaPhieu])
REFERENCES [dbo].[PHIEUMUON] ([MaPhieu])
GO
ALTER TABLE [dbo].[CT_PHIEUMUON] CHECK CONSTRAINT [FK_CT_PHIEUMUON_PHIEUMUON]
GO
ALTER TABLE dbo.[User] ADD CONSTRAINT
	FK_User_NHANVIEN FOREIGN KEY
	(
	MaNV
	) REFERENCES dbo.NHANVIEN
	(
	MaNV
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.UserPermission ADD CONSTRAINT
	FK_UserPermission_Permission FOREIGN KEY
	(
	PermissionID
	) REFERENCES dbo.Permission
	(
	ID
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.UserPermission ADD CONSTRAINT
	FK_UserPermission_User FOREIGN KEY
	(
	UserID
	) REFERENCES dbo.[User]
	(
	ID
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.[User] ADD CONSTRAINT
	FK_User_THANHVIEN FOREIGN KEY
	(
	MaTV
	) REFERENCES dbo.THANHVIEN
	(
	MaTV
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.[User] SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.UserPermission ADD CONSTRAINT
	FK_UserPermission_Permission FOREIGN KEY
	(
	UserID
	) REFERENCES dbo.Permission
	(
	ID
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.UserPermission ADD CONSTRAINT
	FK_UserPermission_User FOREIGN KEY
	(
	PermissionID
	) REFERENCES dbo.[User]
	(
	ID
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE [dbo].[CT_PHIEUMUON]  WITH CHECK ADD  CONSTRAINT [FK_CT_PHIEUMUON_SACH] FOREIGN KEY([MaSach])
REFERENCES [dbo].[SACH] ([MaSach])
GO
ALTER TABLE [dbo].[CT_PHIEUMUON] CHECK CONSTRAINT [FK_CT_PHIEUMUON_SACH]
GO
ALTER TABLE [dbo].[PHIEUMUON]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUMUON_THANHVIEN] FOREIGN KEY([MaTV])
REFERENCES [dbo].[THANHVIEN] ([MaTV])
GO
ALTER TABLE [dbo].[PHIEUMUON] CHECK CONSTRAINT [FK_PHIEUMUON_THANHVIEN]
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
--Procedure
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
/****** Object:  StoredProcedure [dbo].[usp_USER_CheckUser]    Script Date: 10/31/2017 2:02:53 PM ******/
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
/****** Object:  StoredProcedure [dbo].[usp_USER_CreateUser]    Script Date: 10/31/2017 2:02:53 PM ******/
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
	,@MaTV char (6)
	,@MaNV char (6)
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
DECLARE @psUsername varchar(50) = 'tv',
		@psPassword varchar(50) ='tv',
		@MaTV char(6) = 'DG0001',
		@MaNV char(6) = null,
		@pResultCode int,
		@pResultMessage varchar(50)

EXEC dbo.usp_USER_CreateUser @psUsername, @psPassword , @MaTV,@MaNV , @pResultCode output, @pResultMessage output
SELECT @pResultCode, @pResultMessage
/****** Object:  StoredProcedure [dbo].[usp_USER_DeleteUser]    Script Date: 10/31/2017 2:02:53 PM ******/
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
/****** Object:  StoredProcedure [dbo].[usp_USER_GetUserList]    Script Date: 10/31/2017 2:02:53 PM ******/
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
--Tim kiem sach
CREATE PROCEDURE [dbo].[store_timkiem] 
	-- Add the parameters for the stored procedure here
@MaSach char(8),
@TenSach nvarchar(100)
AS
BEGIN
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * from SACH where MaSach like '%'+@MaSach+'%'
						 and TenSach like '%'+@TenSach+'%'				
END
GO
--Thong tin User
DROP PROC ThongTinUser
GO
ALTER PROCEDURE ThongTinUser
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
EXEC ThongTinUser 2
GO
SELECT * FROM THANHVIEN
SELECT * FROM PHIEUMUON
SELECT * FROM [User]
-- Procedure Thêm Nhân Viên
Alter Procedure ThemNhanVien
@MaNV char(6), @HoTen Nvarchar(30), @GioiTinh Bit, @NgaySinh DateTime, @DienThoai char(11), @DiaChi Nvarchar(100),
@Email Nvarchar(30), @NgayVaoLam Datetime
As
Begin
	Insert Into NHANVIEN(MaNV,HoTen,GioiTinh,NgaySinh,DienThoai,DiaChi,Email,NgayVaoLam)
	Values (@MaNV, @HoTen, @GioiTinh, @NgaySinh, @DienThoai,@DiaChi, @Email, @NgayVaoLam);
End
Go

-- Procedure Sửa Nhân Viên
Create Procedure SuaNhanVien
@MaNV char(6), @HoTen Nvarchar(30), @GioiTinh Bit, @NgaySinh DateTime, @DienThoai char(11), @DiaChi Nvarchar(100),
@Email Nvarchar(30), @NgayVaoLam Datetime
As
Begin
	Update NHANVIEN
	Set MaNV = @MaNV, HoTen = @HoTen, GioiTinh = @GioiTinh, NgaySinh = @NgaySinh, DienThoai = @DienThoai, DiaChi = @DiaChi,
	Email = @Email, NgayVaoLam = @NgayVaoLam
	Where MaNV = @MaNV
End
Go
--Danh Sach NV
Create procedure DanhSachNhanVien
as
Begin
select * from NHANVIEN
end
GO
exec DanhSachNhanVien
--Procedure Xóa Nhân Viên
Create Procedure XoaNhanVien
@MaNV char(6)
As
Begin
		Delete From NHANVIEN Where MaNV = @MaNV
End
Go
