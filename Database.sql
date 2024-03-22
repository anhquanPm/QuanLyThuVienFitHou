USE [QuanLyThuVien]
GO
/****** Object:  Table [dbo].[SACH]    Script Date: 22/03/2024 7:12:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SACH](
	[sMaSach] [varchar](10) NOT NULL,
	[sTenSach] [nvarchar](30) NULL,
	[dNamXB] [datetime] NULL,
	[iSoLuong] [int] NULL,
	[sMaLoai] [varchar](10) NULL,
	[sMaTG] [varchar](10) NULL,
	[fGiaTien] [float] NULL,
	[sMaNxb] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[sMaSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CHITIETPHIEUMUON]    Script Date: 22/03/2024 7:12:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHITIETPHIEUMUON](
	[sMaPhieuMuon] [varchar](10) NOT NULL,
	[sMaSach] [varchar](10) NOT NULL,
	[iMaLoaiPhieu] [int] NULL,
	[dNgayHenTra] [datetime] NULL,
 CONSTRAINT [PK_CHITIETPHIEUMUON] PRIMARY KEY CLUSTERED 
(
	[sMaPhieuMuon] ASC,
	[sMaSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[DS_SACH_MUON_TRONG_NGAY_HOM_NAY]    Script Date: 22/03/2024 7:12:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[DS_SACH_MUON_TRONG_NGAY_HOM_NAY]
AS
	SELECT SACH.sTenSach, PHIEUMUON.dNgayMuon, sach.sMaSach, PHIEUMUON.dNgayHenTra, CHITIETPHIEUMUON.dNgayTra
	FROM SACH INNER JOIN CHITIETPHIEUMUON ON SACH.sMaSach = CHITIETPHIEUMUON.sMaSach 
				INNER JOIN PHIEUMUON ON CHITIETPHIEUMUON.iSoPhieuMuon = PHIEUMUON.iSoPhieuMuon
	WHERE DATEDIFF(DAY, PHIEUMUON.dNgayMuon, GETDATE()) = 0
GO
/****** Object:  Table [dbo].[CHITIETPHIEUTRA]    Script Date: 22/03/2024 7:12:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHITIETPHIEUTRA](
	[sMaPhieuTra] [varchar](10) NOT NULL,
	[sMaSach] [varchar](10) NOT NULL,
	[iMaTinhTrangSach] [int] NULL,
	[sMaPhieuPhat] [varchar](10) NULL,
 CONSTRAINT [PK_CHITIETPHIEUTRA] PRIMARY KEY CLUSTERED 
(
	[sMaPhieuTra] ASC,
	[sMaSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CHUCVU]    Script Date: 22/03/2024 7:12:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHUCVU](
	[sMaChucVu] [varchar](10) NOT NULL,
	[sTenChucVu] [nvarchar](50) NULL,
 CONSTRAINT [PK_CHUCVU] PRIMARY KEY CLUSTERED 
(
	[sMaChucVu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DOCGIA]    Script Date: 22/03/2024 7:12:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DOCGIA](
	[sMaDG] [varchar](10) NOT NULL,
	[sTenDG] [nvarchar](30) NULL,
	[dNgaySinh] [datetime] NULL,
	[bGioiTinh] [bit] NULL,
	[sDiaChi] [nvarchar](50) NULL,
	[sSdt] [varchar](11) NULL,
PRIMARY KEY CLUSTERED 
(
	[sMaDG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LOAIPHIEU]    Script Date: 22/03/2024 7:12:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOAIPHIEU](
	[iMaLoaiPhieu] [int] NOT NULL,
	[sTenLoaiPhieu] [nvarchar](50) NULL,
 CONSTRAINT [PK_LOAIPHIEU] PRIMARY KEY CLUSTERED 
(
	[iMaLoaiPhieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 22/03/2024 7:12:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[sMaNV] [varchar](10) NOT NULL,
	[sTenNV] [nvarchar](50) NULL,
	[sGioiTinh] [nvarchar](3) NULL,
	[sDiaChi] [nvarchar](50) NULL,
	[sSdt] [varchar](11) NULL,
	[sMaChucVu] [varchar](10) NULL,
	[dNgaySinh] [date] NULL,
 CONSTRAINT [PK_sMaNV] PRIMARY KEY CLUSTERED 
(
	[sMaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NHAXUATBAN]    Script Date: 22/03/2024 7:12:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHAXUATBAN](
	[sMaNxb] [varchar](10) NOT NULL,
	[sTenNxb] [nvarchar](50) NULL,
 CONSTRAINT [PK_NHAXUATBAN] PRIMARY KEY CLUSTERED 
(
	[sMaNxb] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PHIEUMUONSACH]    Script Date: 22/03/2024 7:12:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUMUONSACH](
	[sMaPhieuMuon] [varchar](10) NOT NULL,
	[sMaDG] [varchar](10) NULL,
	[dNgayMuon] [datetime] NULL,
	[sMaNV] [varchar](10) NULL,
 CONSTRAINT [PK__PHIEUMUO__0E461D3C152ED5C6] PRIMARY KEY CLUSTERED 
(
	[sMaPhieuMuon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PHIEUPHAT]    Script Date: 22/03/2024 7:12:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUPHAT](
	[sMaPhieuPhat] [varchar](10) NOT NULL,
	[sMaPhieuTra] [varchar](10) NOT NULL,
	[fTienPhat] [float] NULL,
	[sGhiChu] [nvarchar](50) NULL,
 CONSTRAINT [PK_PHIEUPHAT_1] PRIMARY KEY CLUSTERED 
(
	[sMaPhieuPhat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PHIEUTRASACH]    Script Date: 22/03/2024 7:12:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUTRASACH](
	[sMaPhieuTra] [varchar](10) NOT NULL,
	[sMaPhieuMuon] [varchar](10) NOT NULL,
	[sMaNV] [varchar](10) NULL,
	[dNgayTra] [datetime] NULL,
	[sMaDG] [varchar](10) NULL,
 CONSTRAINT [PK_PHIEUTRASACH] PRIMARY KEY CLUSTERED 
(
	[sMaPhieuTra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TACGIA]    Script Date: 22/03/2024 7:12:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TACGIA](
	[sMaTG] [varchar](10) NOT NULL,
	[sTenTG] [nvarchar](30) NULL,
	[sDiaChi] [nvarchar](50) NULL,
	[sSdt] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[sMaTG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 22/03/2024 7:12:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[sUserName] [varchar](50) NOT NULL,
	[sPassWord] [varchar](50) NULL,
	[sMaNV] [varchar](10) NULL,
	[bQuyen] [bit] NULL,
 CONSTRAINT [PK_TaiKhoan] PRIMARY KEY CLUSTERED 
(
	[sUserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[THELOAISACH]    Script Date: 22/03/2024 7:12:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[THELOAISACH](
	[sMaLoai] [varchar](10) NOT NULL,
	[sTenTheLoai] [nvarchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[sMaLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TINHTRANGSACH]    Script Date: 22/03/2024 7:12:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TINHTRANGSACH](
	[iMaTinhTrang] [int] NOT NULL,
	[sTinhTrangSach] [nvarchar](50) NULL,
 CONSTRAINT [PK_TINHTRANGSACH] PRIMARY KEY CLUSTERED 
(
	[iMaTinhTrang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[CHITIETPHIEUMUON] ([sMaPhieuMuon], [sMaSach], [iMaLoaiPhieu], [dNgayHenTra]) VALUES (N'M1', N'MS01', 1, CAST(N'2024-01-17T00:00:00.000' AS DateTime))
INSERT [dbo].[CHITIETPHIEUMUON] ([sMaPhieuMuon], [sMaSach], [iMaLoaiPhieu], [dNgayHenTra]) VALUES (N'M2', N'MS02', 1, CAST(N'2024-01-12T00:00:00.000' AS DateTime))
INSERT [dbo].[CHITIETPHIEUMUON] ([sMaPhieuMuon], [sMaSach], [iMaLoaiPhieu], [dNgayHenTra]) VALUES (N'M3', N'MS05', 1, CAST(N'2024-01-27T00:00:00.000' AS DateTime))
INSERT [dbo].[CHITIETPHIEUMUON] ([sMaPhieuMuon], [sMaSach], [iMaLoaiPhieu], [dNgayHenTra]) VALUES (N'M4', N'MS01', 1, CAST(N'2024-02-19T00:00:00.000' AS DateTime))
INSERT [dbo].[CHITIETPHIEUMUON] ([sMaPhieuMuon], [sMaSach], [iMaLoaiPhieu], [dNgayHenTra]) VALUES (N'M4', N'MS05', 1, CAST(N'2024-02-19T00:00:00.000' AS DateTime))
INSERT [dbo].[CHITIETPHIEUMUON] ([sMaPhieuMuon], [sMaSach], [iMaLoaiPhieu], [dNgayHenTra]) VALUES (N'M5', N'MS06', 1, CAST(N'2024-02-02T00:00:00.000' AS DateTime))
INSERT [dbo].[CHITIETPHIEUMUON] ([sMaPhieuMuon], [sMaSach], [iMaLoaiPhieu], [dNgayHenTra]) VALUES (N'M6', N'MS07', 2, CAST(N'2024-05-15T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[CHITIETPHIEUTRA] ([sMaPhieuTra], [sMaSach], [iMaTinhTrangSach], [sMaPhieuPhat]) VALUES (N'T1', N'MS01', 1, NULL)
INSERT [dbo].[CHITIETPHIEUTRA] ([sMaPhieuTra], [sMaSach], [iMaTinhTrangSach], [sMaPhieuPhat]) VALUES (N'T2', N'MS02', 1, NULL)
INSERT [dbo].[CHITIETPHIEUTRA] ([sMaPhieuTra], [sMaSach], [iMaTinhTrangSach], [sMaPhieuPhat]) VALUES (N'T3', N'MS05', 1, NULL)
INSERT [dbo].[CHITIETPHIEUTRA] ([sMaPhieuTra], [sMaSach], [iMaTinhTrangSach], [sMaPhieuPhat]) VALUES (N'T4', N'MS01', 1, NULL)
INSERT [dbo].[CHITIETPHIEUTRA] ([sMaPhieuTra], [sMaSach], [iMaTinhTrangSach], [sMaPhieuPhat]) VALUES (N'T4', N'MS05', 2, N'P1')
INSERT [dbo].[CHITIETPHIEUTRA] ([sMaPhieuTra], [sMaSach], [iMaTinhTrangSach], [sMaPhieuPhat]) VALUES (N'T5', N'MS06', 1, NULL)
INSERT [dbo].[CHITIETPHIEUTRA] ([sMaPhieuTra], [sMaSach], [iMaTinhTrangSach], [sMaPhieuPhat]) VALUES (N'T6', N'MS07', 1, NULL)
GO
INSERT [dbo].[CHUCVU] ([sMaChucVu], [sTenChucVu]) VALUES (N'CV01', N'Thủ thư')
INSERT [dbo].[CHUCVU] ([sMaChucVu], [sTenChucVu]) VALUES (N'CV02', N'Quản lý')
GO
INSERT [dbo].[DOCGIA] ([sMaDG], [sTenDG], [dNgaySinh], [bGioiTinh], [sDiaChi], [sSdt]) VALUES (N'DG01', N'Phạm Thị Hoa', CAST(N'2003-12-12T00:00:00.000' AS DateTime), 0, N'Hà nội', NULL)
INSERT [dbo].[DOCGIA] ([sMaDG], [sTenDG], [dNgaySinh], [bGioiTinh], [sDiaChi], [sSdt]) VALUES (N'DG02', N'Trần Văn HUy', CAST(N'2004-01-21T00:00:00.000' AS DateTime), 1, N'Hà Nội', NULL)
INSERT [dbo].[DOCGIA] ([sMaDG], [sTenDG], [dNgaySinh], [bGioiTinh], [sDiaChi], [sSdt]) VALUES (N'DG03', N'Trần Văn Hùng', CAST(N'2004-03-18T00:00:00.000' AS DateTime), 1, N'Hà Nội', NULL)
INSERT [dbo].[DOCGIA] ([sMaDG], [sTenDG], [dNgaySinh], [bGioiTinh], [sDiaChi], [sSdt]) VALUES (N'DG04', N'Nguyễn Thị Huyền', CAST(N'2000-12-01T00:00:00.000' AS DateTime), 0, N'Hà Nội', NULL)
INSERT [dbo].[DOCGIA] ([sMaDG], [sTenDG], [dNgaySinh], [bGioiTinh], [sDiaChi], [sSdt]) VALUES (N'DG05', N'Nguyễn Anh Dũng', CAST(N'2003-04-03T00:00:00.000' AS DateTime), 1, N'Nam Định', N'027345646')
GO
INSERT [dbo].[LOAIPHIEU] ([iMaLoaiPhieu], [sTenLoaiPhieu]) VALUES (1, N'Ngắn hạn')
INSERT [dbo].[LOAIPHIEU] ([iMaLoaiPhieu], [sTenLoaiPhieu]) VALUES (2, N'Dài hạn')
GO
INSERT [dbo].[NHANVIEN] ([sMaNV], [sTenNV], [sGioiTinh], [sDiaChi], [sSdt], [sMaChucVu], [dNgaySinh]) VALUES (N'NV01', N'Trần Anh Quân', N'Nam', N'Phú Thọ', N'0333241634', N'CV02', CAST(N'2004-07-10' AS Date))
INSERT [dbo].[NHANVIEN] ([sMaNV], [sTenNV], [sGioiTinh], [sDiaChi], [sSdt], [sMaChucVu], [dNgaySinh]) VALUES (N'NV02', N'Trần Trường Giang', N'Nam', N'Hà Nội', N'03545465', N'CV01', CAST(N'2004-04-09' AS Date))
INSERT [dbo].[NHANVIEN] ([sMaNV], [sTenNV], [sGioiTinh], [sDiaChi], [sSdt], [sMaChucVu], [dNgaySinh]) VALUES (N'NV03', N'Hoàng Anh Thắng', N'Nam', N'Hà Nội', N'063537574', N'CV01', CAST(N'2004-03-09' AS Date))
INSERT [dbo].[NHANVIEN] ([sMaNV], [sTenNV], [sGioiTinh], [sDiaChi], [sSdt], [sMaChucVu], [dNgaySinh]) VALUES (N'NV04', N'Nguyễn Ngọc Anh', N'Nữ', N'Nam Định', N'017836748', N'CV02', CAST(N'2000-09-09' AS Date))
INSERT [dbo].[NHANVIEN] ([sMaNV], [sTenNV], [sGioiTinh], [sDiaChi], [sSdt], [sMaChucVu], [dNgaySinh]) VALUES (N'NV07', N'Anh Quân 7', N'Nam', N'Hà Nội', N'02636344', N'CV02', CAST(N'2004-07-20' AS Date))
GO
INSERT [dbo].[NHAXUATBAN] ([sMaNxb], [sTenNxb]) VALUES (N'NXB01', N'KIM ĐỒNG')
INSERT [dbo].[NHAXUATBAN] ([sMaNxb], [sTenNxb]) VALUES (N'NXB02', N'THANH NIÊN')
INSERT [dbo].[NHAXUATBAN] ([sMaNxb], [sTenNxb]) VALUES (N'NXB03', N'ĐHQG HÀ NỘI')
INSERT [dbo].[NHAXUATBAN] ([sMaNxb], [sTenNxb]) VALUES (N'NXB04', N'THỜI ĐẠI')
GO
INSERT [dbo].[PHIEUMUONSACH] ([sMaPhieuMuon], [sMaDG], [dNgayMuon], [sMaNV]) VALUES (N'M1', N'DG01', CAST(N'2024-01-10T00:00:00.000' AS DateTime), N'NV02')
INSERT [dbo].[PHIEUMUONSACH] ([sMaPhieuMuon], [sMaDG], [dNgayMuon], [sMaNV]) VALUES (N'M2', N'DG02', CAST(N'2024-01-05T00:00:00.000' AS DateTime), N'NV02')
INSERT [dbo].[PHIEUMUONSACH] ([sMaPhieuMuon], [sMaDG], [dNgayMuon], [sMaNV]) VALUES (N'M3', N'DG03', CAST(N'2024-01-20T00:00:00.000' AS DateTime), N'NV03')
INSERT [dbo].[PHIEUMUONSACH] ([sMaPhieuMuon], [sMaDG], [dNgayMuon], [sMaNV]) VALUES (N'M4', N'DG03', CAST(N'2024-02-12T00:00:00.000' AS DateTime), N'NV04')
INSERT [dbo].[PHIEUMUONSACH] ([sMaPhieuMuon], [sMaDG], [dNgayMuon], [sMaNV]) VALUES (N'M5', N'DG04', CAST(N'2024-01-26T00:00:00.000' AS DateTime), N'NV04')
INSERT [dbo].[PHIEUMUONSACH] ([sMaPhieuMuon], [sMaDG], [dNgayMuon], [sMaNV]) VALUES (N'M6', N'DG05', CAST(N'2024-02-15T00:00:00.000' AS DateTime), N'NV01')
GO
INSERT [dbo].[PHIEUPHAT] ([sMaPhieuPhat], [sMaPhieuTra], [fTienPhat], [sGhiChu]) VALUES (N'P1', N'T4', 80000, N'bạn đọc làm mất sách')
GO
INSERT [dbo].[PHIEUTRASACH] ([sMaPhieuTra], [sMaPhieuMuon], [sMaNV], [dNgayTra], [sMaDG]) VALUES (N'T1', N'M1', N'NV01', NULL, N'DG01')
INSERT [dbo].[PHIEUTRASACH] ([sMaPhieuTra], [sMaPhieuMuon], [sMaNV], [dNgayTra], [sMaDG]) VALUES (N'T2', N'M2', N'NV01', NULL, N'DG02')
INSERT [dbo].[PHIEUTRASACH] ([sMaPhieuTra], [sMaPhieuMuon], [sMaNV], [dNgayTra], [sMaDG]) VALUES (N'T3', N'M3', N'NV03', NULL, N'DG03')
INSERT [dbo].[PHIEUTRASACH] ([sMaPhieuTra], [sMaPhieuMuon], [sMaNV], [dNgayTra], [sMaDG]) VALUES (N'T4', N'M4', N'NV02', NULL, N'DG03')
INSERT [dbo].[PHIEUTRASACH] ([sMaPhieuTra], [sMaPhieuMuon], [sMaNV], [dNgayTra], [sMaDG]) VALUES (N'T5', N'M5', N'NV01', NULL, N'DG04')
INSERT [dbo].[PHIEUTRASACH] ([sMaPhieuTra], [sMaPhieuMuon], [sMaNV], [dNgayTra], [sMaDG]) VALUES (N'T6', N'M6', N'NV03', NULL, N'DG05')
GO
INSERT [dbo].[SACH] ([sMaSach], [sTenSach], [dNamXB], [iSoLuong], [sMaLoai], [sMaTG], [fGiaTien], [sMaNxb]) VALUES (N'MS01', N'7 viên ngọc rồng', CAST(N'2019-07-16T00:00:00.000' AS DateTime), 11, N'cotich', N'TG01', 15000, N'NXB01')
INSERT [dbo].[SACH] ([sMaSach], [sTenSach], [dNamXB], [iSoLuong], [sMaLoai], [sMaTG], [fGiaTien], [sMaNxb]) VALUES (N'MS02', N'Naruto và đồng bọn', CAST(N'2013-08-06T00:00:00.000' AS DateTime), 12, N'cotich', N'TG01', 20000, N'NXB02')
INSERT [dbo].[SACH] ([sMaSach], [sTenSach], [dNamXB], [iSoLuong], [sMaLoai], [sMaTG], [fGiaTien], [sMaNxb]) VALUES (N'MS04', N'Chú bé ngu ngơ', CAST(N'2024-03-19T00:00:00.000' AS DateTime), 20, N'cotich', N'TG01', 20000, N'NXB02')
INSERT [dbo].[SACH] ([sMaSach], [sTenSach], [dNamXB], [iSoLuong], [sMaLoai], [sMaTG], [fGiaTien], [sMaNxb]) VALUES (N'MS05', N'Lập trình Java', CAST(N'2024-03-19T00:00:00.000' AS DateTime), 100, N'thamKhao', N'TG02', 100000, N'NXB03')
INSERT [dbo].[SACH] ([sMaSach], [sTenSach], [dNamXB], [iSoLuong], [sMaLoai], [sMaTG], [fGiaTien], [sMaNxb]) VALUES (N'MS06', N'Ngôn ngữ C', CAST(N'2024-03-19T00:00:00.000' AS DateTime), 30, N'thamKhao', N'TG02', 50000, N'NXB03')
INSERT [dbo].[SACH] ([sMaSach], [sTenSach], [dNamXB], [iSoLuong], [sMaLoai], [sMaTG], [fGiaTien], [sMaNxb]) VALUES (N'MS07', N'Tình yêu của Quân', CAST(N'2015-07-01T00:00:00.000' AS DateTime), 12, N'kinhdi', N'TG03', 120000, N'NXB04')
INSERT [dbo].[SACH] ([sMaSach], [sTenSach], [dNamXB], [iSoLuong], [sMaLoai], [sMaTG], [fGiaTien], [sMaNxb]) VALUES (N'MS08', N'Chúa hề và chúa tể', CAST(N'2024-03-19T00:00:00.000' AS DateTime), 12, N'kinhdi', N'TG03', 200000, N'NXB04')
INSERT [dbo].[SACH] ([sMaSach], [sTenSach], [dNamXB], [iSoLuong], [sMaLoai], [sMaTG], [fGiaTien], [sMaNxb]) VALUES (N'MS09', N'Đôi bạn Nhện và Bò', CAST(N'2024-03-19T00:00:00.000' AS DateTime), 23, N'ttranh', N'TG03', 12000, N'NXB01')
INSERT [dbo].[SACH] ([sMaSach], [sTenSach], [dNamXB], [iSoLuong], [sMaLoai], [sMaTG], [fGiaTien], [sMaNxb]) VALUES (N'MS10', N'Khỉ con chơi đồ', CAST(N'2024-03-19T00:00:00.000' AS DateTime), 4, N'cotich', N'TG03', 12000, N'NXB03')
INSERT [dbo].[SACH] ([sMaSach], [sTenSach], [dNamXB], [iSoLuong], [sMaLoai], [sMaTG], [fGiaTien], [sMaNxb]) VALUES (N'MS11', N'Chu be loat choat', CAST(N'2019-06-13T00:00:00.000' AS DateTime), 12, N'cotich', N'TG02', 12000, N'NXB02')
GO
INSERT [dbo].[TACGIA] ([sMaTG], [sTenTG], [sDiaChi], [sSdt]) VALUES (N'TG01', N'Trần Anh Quân', N'Phú Thọ -Việt Nam', NULL)
INSERT [dbo].[TACGIA] ([sMaTG], [sTenTG], [sDiaChi], [sSdt]) VALUES (N'TG02', N'Lưu Bang', N'Trung Quốc', NULL)
INSERT [dbo].[TACGIA] ([sMaTG], [sTenTG], [sDiaChi], [sSdt]) VALUES (N'TG03', N'Hàn Tín', N'Trung Quốc', NULL)
INSERT [dbo].[TACGIA] ([sMaTG], [sTenTG], [sDiaChi], [sSdt]) VALUES (N'TG04 ', N'Ngô Bảo Châu', N'BANG CALI KHÁT NƯỚC', N'911')
GO
INSERT [dbo].[TaiKhoan] ([sUserName], [sPassWord], [sMaNV], [bQuyen]) VALUES (N'admin', N'1', N'NV01', 1)
INSERT [dbo].[TaiKhoan] ([sUserName], [sPassWord], [sMaNV], [bQuyen]) VALUES (N'giang', N'giang', N'NV02', 0)
INSERT [dbo].[TaiKhoan] ([sUserName], [sPassWord], [sMaNV], [bQuyen]) VALUES (N'quan', N'q', N'NV07', 0)
INSERT [dbo].[TaiKhoan] ([sUserName], [sPassWord], [sMaNV], [bQuyen]) VALUES (N'thang', N'thang', N'NV03', 0)
GO
INSERT [dbo].[THELOAISACH] ([sMaLoai], [sTenTheLoai]) VALUES (N'cotich', N'Cổ tích')
INSERT [dbo].[THELOAISACH] ([sMaLoai], [sTenTheLoai]) VALUES (N'kinhdi', N'Kinh Dị')
INSERT [dbo].[THELOAISACH] ([sMaLoai], [sTenTheLoai]) VALUES (N'thamkhao', N'Sách tham khảo')
INSERT [dbo].[THELOAISACH] ([sMaLoai], [sTenTheLoai]) VALUES (N'tapchi', N'Tạp chí')
INSERT [dbo].[THELOAISACH] ([sMaLoai], [sTenTheLoai]) VALUES (N'ttranh', N'Truyện Tranh')
GO
INSERT [dbo].[TINHTRANGSACH] ([iMaTinhTrang], [sTinhTrangSach]) VALUES (1, N'Nguyên vẹn')
INSERT [dbo].[TINHTRANGSACH] ([iMaTinhTrang], [sTinhTrangSach]) VALUES (2, N'Hỏng sách')
INSERT [dbo].[TINHTRANGSACH] ([iMaTinhTrang], [sTinhTrangSach]) VALUES (3, N'Mất sách')
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UNIQUE_sTenTheLoai]    Script Date: 22/03/2024 7:12:38 PM ******/
ALTER TABLE [dbo].[THELOAISACH] ADD  CONSTRAINT [UNIQUE_sTenTheLoai] UNIQUE NONCLUSTERED 
(
	[sTenTheLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[CHITIETPHIEUMUON]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETPHIEUMUON_sMaPhieuMuon] FOREIGN KEY([sMaPhieuMuon])
REFERENCES [dbo].[PHIEUMUONSACH] ([sMaPhieuMuon])
GO
ALTER TABLE [dbo].[CHITIETPHIEUMUON] CHECK CONSTRAINT [FK_CHITIETPHIEUMUON_sMaPhieuMuon]
GO
ALTER TABLE [dbo].[CHITIETPHIEUMUON]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETPHIEUMUON_sMaSach] FOREIGN KEY([sMaSach])
REFERENCES [dbo].[SACH] ([sMaSach])
GO
ALTER TABLE [dbo].[CHITIETPHIEUMUON] CHECK CONSTRAINT [FK_CHITIETPHIEUMUON_sMaSach]
GO
ALTER TABLE [dbo].[CHITIETPHIEUMUON]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUMUONSACH_iLoaiPhieu] FOREIGN KEY([iMaLoaiPhieu])
REFERENCES [dbo].[LOAIPHIEU] ([iMaLoaiPhieu])
GO
ALTER TABLE [dbo].[CHITIETPHIEUMUON] CHECK CONSTRAINT [FK_PHIEUMUONSACH_iLoaiPhieu]
GO
ALTER TABLE [dbo].[CHITIETPHIEUTRA]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETPHIEUTRA_iMaTinhTrangSach] FOREIGN KEY([iMaTinhTrangSach])
REFERENCES [dbo].[TINHTRANGSACH] ([iMaTinhTrang])
GO
ALTER TABLE [dbo].[CHITIETPHIEUTRA] CHECK CONSTRAINT [FK_CHITIETPHIEUTRA_iMaTinhTrangSach]
GO
ALTER TABLE [dbo].[CHITIETPHIEUTRA]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETPHIEUTRA_sMaPhieuPhat] FOREIGN KEY([sMaPhieuPhat])
REFERENCES [dbo].[PHIEUPHAT] ([sMaPhieuPhat])
GO
ALTER TABLE [dbo].[CHITIETPHIEUTRA] CHECK CONSTRAINT [FK_CHITIETPHIEUTRA_sMaPhieuPhat]
GO
ALTER TABLE [dbo].[CHITIETPHIEUTRA]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETPHIEUTRA_sMaPhieuTra] FOREIGN KEY([sMaPhieuTra])
REFERENCES [dbo].[PHIEUTRASACH] ([sMaPhieuTra])
GO
ALTER TABLE [dbo].[CHITIETPHIEUTRA] CHECK CONSTRAINT [FK_CHITIETPHIEUTRA_sMaPhieuTra]
GO
ALTER TABLE [dbo].[CHITIETPHIEUTRA]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETPHIEUTRA_sMaSach] FOREIGN KEY([sMaSach])
REFERENCES [dbo].[SACH] ([sMaSach])
GO
ALTER TABLE [dbo].[CHITIETPHIEUTRA] CHECK CONSTRAINT [FK_CHITIETPHIEUTRA_sMaSach]
GO
ALTER TABLE [dbo].[NHANVIEN]  WITH CHECK ADD  CONSTRAINT [FK_NHANVIEN_sMaChucVu] FOREIGN KEY([sMaChucVu])
REFERENCES [dbo].[CHUCVU] ([sMaChucVu])
GO
ALTER TABLE [dbo].[NHANVIEN] CHECK CONSTRAINT [FK_NHANVIEN_sMaChucVu]
GO
ALTER TABLE [dbo].[PHIEUMUONSACH]  WITH CHECK ADD  CONSTRAINT [FK_sMaDG] FOREIGN KEY([sMaDG])
REFERENCES [dbo].[DOCGIA] ([sMaDG])
GO
ALTER TABLE [dbo].[PHIEUMUONSACH] CHECK CONSTRAINT [FK_sMaDG]
GO
ALTER TABLE [dbo].[PHIEUMUONSACH]  WITH CHECK ADD  CONSTRAINT [FK_sMaNV] FOREIGN KEY([sMaNV])
REFERENCES [dbo].[NHANVIEN] ([sMaNV])
GO
ALTER TABLE [dbo].[PHIEUMUONSACH] CHECK CONSTRAINT [FK_sMaNV]
GO
ALTER TABLE [dbo].[PHIEUTRASACH]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUTRASACH_sMaDG] FOREIGN KEY([sMaDG])
REFERENCES [dbo].[DOCGIA] ([sMaDG])
GO
ALTER TABLE [dbo].[PHIEUTRASACH] CHECK CONSTRAINT [FK_PHIEUTRASACH_sMaDG]
GO
ALTER TABLE [dbo].[PHIEUTRASACH]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUTRASACH_sMaNv] FOREIGN KEY([sMaNV])
REFERENCES [dbo].[NHANVIEN] ([sMaNV])
GO
ALTER TABLE [dbo].[PHIEUTRASACH] CHECK CONSTRAINT [FK_PHIEUTRASACH_sMaNv]
GO
ALTER TABLE [dbo].[PHIEUTRASACH]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUTRASACH_sMaPhieuMuon] FOREIGN KEY([sMaPhieuMuon])
REFERENCES [dbo].[PHIEUMUONSACH] ([sMaPhieuMuon])
GO
ALTER TABLE [dbo].[PHIEUTRASACH] CHECK CONSTRAINT [FK_PHIEUTRASACH_sMaPhieuMuon]
GO
ALTER TABLE [dbo].[SACH]  WITH CHECK ADD  CONSTRAINT [FK_sMaLoai] FOREIGN KEY([sMaLoai])
REFERENCES [dbo].[THELOAISACH] ([sMaLoai])
GO
ALTER TABLE [dbo].[SACH] CHECK CONSTRAINT [FK_sMaLoai]
GO
ALTER TABLE [dbo].[SACH]  WITH CHECK ADD  CONSTRAINT [FK_sMaNxb] FOREIGN KEY([sMaNxb])
REFERENCES [dbo].[NHAXUATBAN] ([sMaNxb])
GO
ALTER TABLE [dbo].[SACH] CHECK CONSTRAINT [FK_sMaNxb]
GO
ALTER TABLE [dbo].[SACH]  WITH CHECK ADD  CONSTRAINT [FK_sMaTG] FOREIGN KEY([sMaTG])
REFERENCES [dbo].[TACGIA] ([sMaTG])
GO
ALTER TABLE [dbo].[SACH] CHECK CONSTRAINT [FK_sMaTG]
GO
ALTER TABLE [dbo].[TaiKhoan]  WITH CHECK ADD  CONSTRAINT [FK_TaiKhoan_sMaNv] FOREIGN KEY([sMaNV])
REFERENCES [dbo].[NHANVIEN] ([sMaNV])
GO
ALTER TABLE [dbo].[TaiKhoan] CHECK CONSTRAINT [FK_TaiKhoan_sMaNv]
GO
ALTER TABLE [dbo].[TaiKhoan]  WITH CHECK ADD  CONSTRAINT [FK_TaiKhoan_TaiKhoan] FOREIGN KEY([sUserName])
REFERENCES [dbo].[TaiKhoan] ([sUserName])
GO
ALTER TABLE [dbo].[TaiKhoan] CHECK CONSTRAINT [FK_TaiKhoan_TaiKhoan]
GO
ALTER TABLE [dbo].[SACH]  WITH CHECK ADD  CONSTRAINT [Check_namXB] CHECK  ((datepart(year,[dNamXb])>=(2010)))
GO
ALTER TABLE [dbo].[SACH] CHECK CONSTRAINT [Check_namXB]
GO
/****** Object:  StoredProcedure [dbo].[KiemTraCapNhatNgayHenTra]    Script Date: 22/03/2024 7:12:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[KiemTraCapNhatNgayHenTra]
AS
BEGIN
    DECLARE @sMaPhieuMuon VARCHAR(255);
    DECLARE @iMaLoaiPhieu INT;
    DECLARE @dNgayMuon DATE;

    -- Khai báo một con trỏ để lặp qua tất cả các phiếu mượn
    DECLARE PhieuMuonCursor CURSOR FOR
    SELECT CHITIETPHIEUMUON.sMaPhieuMuon, iMaLoaiPhieu, dNgayMuon
    FROM CHITIETPHIEUMUON INNER JOIN PHIEUMUONSACH ON CHITIETPHIEUMUON.sMaPhieuMuon = PHIEUMUONSACH.sMaPhieuMuon;

    -- Mở con trỏ
    OPEN PhieuMuonCursor;

    -- Lặp qua từng bản ghi và kiểm tra, cập nhật dNgayHenTra
    FETCH NEXT FROM PhieuMuonCursor INTO @sMaPhieuMuon, @iMaLoaiPhieu, @dNgayMuon;
    WHILE @@FETCH_STATUS = 0
    BEGIN
        IF @iMaLoaiPhieu = 1
            UPDATE CHITIETPHIEUMUON
            SET dNgayHenTra = DATEADD(DAY, 7, @dNgayMuon)
            WHERE sMaPhieuMuon = @sMaPhieuMuon;
        ELSE IF @iMaLoaiPhieu = 2
            UPDATE CHITIETPHIEUMUON
            SET dNgayHenTra = DATEADD(DAY, 90, @dNgayMuon)
            WHERE sMaPhieuMuon = @sMaPhieuMuon;

        -- Lấy bản ghi tiếp theo
        FETCH NEXT FROM PhieuMuonCursor INTO @sMaPhieuMuon, @iMaLoaiPhieu, @dNgayMuon;
    END;

    -- Đóng con trỏ
    CLOSE PhieuMuonCursor;
    DEALLOCATE PhieuMuonCursor;
END;
GO
/****** Object:  StoredProcedure [dbo].[proc_capNhatNhanVien]    Script Date: 22/03/2024 7:12:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[proc_capNhatNhanVien]
@maNV varchar(10) ,@tenNV nvarchar(30), @gioiTinh nvarchar(5), @diaChi nvarchar(30), @sdt varchar(10), @ngaySinh date
AS
	Update NHANVIEN
	Set sTenNV = @tenNV, sGioiTinh = @gioiTinh, sDiaChi = @diaChi, sSdt = @sdt, dNgaySinh = @ngaySinh
	WHERE sMaNV = @maNV

GO
/****** Object:  StoredProcedure [dbo].[proc_capNhatNhanVienQLNV]    Script Date: 22/03/2024 7:12:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[proc_capNhatNhanVienQLNV]
@maNV varchar(10) ,@tenNV nvarchar(30), @gioiTinh nvarchar(5), @diaChi nvarchar(30), @sdt varchar(10),@macv varchar(10)  ,@ngaySinh date
AS
	Update NHANVIEN
	Set sTenNV = @tenNV, sGioiTinh = @gioiTinh, sDiaChi = @diaChi, sSdt = @sdt, sMaChucVu = @macv ,dNgaySinh = @ngaySinh
	WHERE sMaNV = @maNV

GO
/****** Object:  StoredProcedure [dbo].[proc_capNhatSach]    Script Date: 22/03/2024 7:12:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[proc_capNhatSach]
@maSach varchar(10), @tenSach nvarchar(30), @namXB date, @soLuong int,
@maLoai varchar(10), @maTacGia varchar(10), @giaTien float, @maNXB varchar(10)
AS
	UPDATE SACH
	SET  sTenSach = @tenSach, dNamXB = @namXB, iSoLuong = @soLuong,
		sMaLoai = @maLoai, sMaTG = @maTacGia, fGiaTien = @giaTien, sMaNxb = @maNXB
	WHERE sMaSach = @maSach
GO
/****** Object:  StoredProcedure [dbo].[proc_capNhatTaiKhoan]    Script Date: 22/03/2024 7:12:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[proc_capNhatTaiKhoan]
@user varchar(10), @pass varchar(10), @quyen bit
AS
	UPDATE TaiKhoan
	SET sPassWord = @pass, bQuyen = @quyen
	WHERE sUserName = @user
GO
/****** Object:  StoredProcedure [dbo].[proc_checkQuyen]    Script Date: 22/03/2024 7:12:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[proc_checkQuyen]
@user varchar(10), @pass varchar(10)
AS
	SELECT bQuyen FROM TaiKhoan 
	WHERE sUserName = @user AND sPassWord = @pass AND bQuyen = 1
GO
/****** Object:  StoredProcedure [dbo].[proc_doiMatKhau]    Script Date: 22/03/2024 7:12:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[proc_doiMatKhau]
@user varchar(10), @pass varchar(10)
AS	
	UPDATE TaiKhoan		
	set sPassWord = @pass
	WHERE sUserName = @user
GO
/****** Object:  StoredProcedure [dbo].[proc_dsTaiKhoan]    Script Date: 22/03/2024 7:12:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[proc_dsTaiKhoan]
AS
	SELECT *
	FROM TaiKhoan
GO
/****** Object:  StoredProcedure [dbo].[proc_getNhanVien]    Script Date: 22/03/2024 7:12:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[proc_getNhanVien]
AS
	SELECT sMaNV, sTenNV, sGioiTinh, sDiaChi, sSdt, sMaChucVu, FORMAT(dNgaySinh, 'dd/MM/yyyy') as 'dNgaySinh' FROM NHANVIEN
GO
/****** Object:  StoredProcedure [dbo].[proc_getSach]    Script Date: 22/03/2024 7:12:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[proc_getSach]
AS
	SELECT sMaSach, sTenSach, FORMAT(dNamXB, 'dd/MM/yyyy') AS N'dNamXB', iSoLuong, sMaLoai, sMaTG, fGiaTien, sMaNxb 
	FROM SACH
GO
/****** Object:  StoredProcedure [dbo].[proc_getTaiKhoan]    Script Date: 22/03/2024 7:12:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[proc_getTaiKhoan]
@user varchar(10), @pass varchar(10)
AS
	select NHANVIEN.sMaNV,  NHANVIEN.sTenNV, NHANVIEN.sGioiTinh, NHANVIEN.sDiaChi, NHANVIEN.sSdt, NHANVIEN.dNgaySinh
	from TaiKhoan INNER JOIN NHANVIEN ON TaiKhoan.sMaNV = NHANVIEN.sMaNV
	WHERE TaiKhoan.sUserName = @user and TaiKhoan.sPassWord = @pass
GO
/****** Object:  StoredProcedure [dbo].[proc_login]    Script Date: 22/03/2024 7:12:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[proc_login]
@user varchar(10),
@pass varchar(10)
AS
	SELECT * FROM TaiKhoan 
	WHERE sUserName = @user and sPassWord = @pass 
GO
/****** Object:  StoredProcedure [dbo].[proc_themNhanVien]    Script Date: 22/03/2024 7:12:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[proc_themNhanVien]
@maNV varchar(10) ,@tenNV nvarchar(30), @gioiTinh nvarchar(5), @diaChi nvarchar(30), @sdt varchar(10),@macv varchar(10)  ,@ngaySinh date
AS
	INSERT INTO NHANVIEN
	VALUES
	(
		@maNV, @tenNV, @gioiTinh, @diaChi, @sdt, @macv, @ngaySinh
	);
GO
/****** Object:  StoredProcedure [dbo].[proc_themSach]    Script Date: 22/03/2024 7:12:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC	[dbo].[proc_themSach]
@maSach varchar(10), @tenSach nvarchar(30), @namXB date, @soLuong int,
@maLoai varchar(10), @maTacGia varchar(10), @giaTien float, @maNXB varchar(10)
AS
	INSERT INTO SACH 
	VALUES(
		@maSach, @tenSach, @namXB, @soLuong, @maLoai, @maTacGia, @giaTien, @maNXB
	);
GO
/****** Object:  StoredProcedure [dbo].[proc_themTaiKhoan]    Script Date: 22/03/2024 7:12:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[proc_themTaiKhoan]
@user varchar(10), @pass varchar(10), @maNv varchar(10), @quyen bit
AS
	INSERT INTO TaiKhoan
	VALUES
	(
		@user, @pass, @maNv, @quyen
	);
GO
/****** Object:  StoredProcedure [dbo].[proc_timKiemTheoMaLoai]    Script Date: 22/03/2024 7:12:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[proc_timKiemTheoMaLoai]
@maLoai varchar(10)
AS
	SELECT sMaSach, sTenSach, FORMAT(dNamXB, 'dd/MM/yyyy') as 'dNamXB', iSoLuong, sMaLoai, sMaTG, fGiaTien,sMaNxb
	FROM SACH
	WHERE sMaLoai LIKE '%' + @maLoai +'%'
GO
/****** Object:  StoredProcedure [dbo].[proc_timKiemTheoMaNV]    Script Date: 22/03/2024 7:12:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[proc_timKiemTheoMaNV]
@manv varchar(10)
AS
	SELECT sMaNV, sTenNV, sGioiTinh, sDiaChi, sSdt, sMaChucVu, FORMAT(dNgaySinh, 'dd/MM/yyyy') as 'dNgaySinh'
	FROM NHANVIEN
	WHERE sMaNV LIKE '%' + @manv + '%';

GO
/****** Object:  StoredProcedure [dbo].[proc_timKiemTheoMaSach]    Script Date: 22/03/2024 7:12:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[proc_timKiemTheoMaSach]
@maSach varchar(10)
AS
	SELECT sMaSach, sTenSach, FORMAT(dNamXB, 'dd/MM/yyyy') as 'dNamXB', iSoLuong, sMaLoai, sMaTG, fGiaTien,sMaNxb
	FROM SACH
	WHERE sMaSach LIKE '%' + @maSach +'%'
GO
/****** Object:  StoredProcedure [dbo].[proc_timKiemTheoTenNV]    Script Date: 22/03/2024 7:12:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[proc_timKiemTheoTenNV]
@tennv varchar(10)
AS
	SELECT sMaNV, sTenNV, sGioiTinh, sDiaChi, sSdt, sMaChucVu, FORMAT(dNgaySinh, 'dd/MM/yyyy') as 'dNgaySinh'
	FROM NHANVIEN
	WHERE sTenNV LIKE '%' + @tennv + '%';
GO
/****** Object:  StoredProcedure [dbo].[proc_timKiemTheoTenSach]    Script Date: 22/03/2024 7:12:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[proc_timKiemTheoTenSach]
@tenSach nvarchar(30)
AS
	SELECT sMaSach, sTenSach, FORMAT(dNamXB, 'dd/MM/yyyy') as 'dNamXB', iSoLuong, sMaLoai, sMaTG, fGiaTien,sMaNxb
	FROM SACH
	WHERE sTenSach LIKE '%' + @tenSach +'%'
GO
/****** Object:  StoredProcedure [dbo].[proc_timkiemTKTheoTenNV]    Script Date: 22/03/2024 7:12:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[proc_timkiemTKTheoTenNV]
@tenNV nvarchar(30)
AS
	SELECT *
	FROM TaiKhoan 
	WHERE sUserName LIKE '%' + @tenNV + '%'
GO
/****** Object:  StoredProcedure [dbo].[proc_timKiemTKTheoUser]    Script Date: 22/03/2024 7:12:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[proc_timKiemTKTheoUser]
@user varchar(10)
AS
	SELECT *
	FROM TaiKhoan
	WHERE sUserName LIKE '%' + @user + '%'
GO
/****** Object:  StoredProcedure [dbo].[proc_xoaNhanVien]    Script Date: 22/03/2024 7:12:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[proc_xoaNhanVien]
@manv varchar(10)
AS	
	DELETE NHANVIEN
	WHERE sMaNV = @manv
GO
/****** Object:  StoredProcedure [dbo].[proc_xoaSach]    Script Date: 22/03/2024 7:12:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[proc_xoaSach]
@maSach varchar(10)
AS
	DELETE SACH
	WHERE sMaSach = @maSach
GO
/****** Object:  StoredProcedure [dbo].[proc_xoaTaiKhoan]    Script Date: 22/03/2024 7:12:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[proc_xoaTaiKhoan]
@user varchar(10)
AS
	DELETE FROM TaiKhoan
	WHERE sUserName = @user
GO
/****** Object:  StoredProcedure [dbo].[SELECT_NHANVIEN]    Script Date: 22/03/2024 7:12:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SELECT_NHANVIEN]
AS
	SELECT NHANVIEN.sMaNV, NHANVIEN.sTenNV, NHANVIEN.sGioiTinh, NHANVIEN.sDiaChi, NHANVIEN.sSdt, FORMAT( NHANVIEN.dNgaySinh, 'dd/MM/yyyy') AS [Ngày sinh], NHANVIEN.sMaChucVu
	FROM NHANVIEN
GO
/****** Object:  StoredProcedure [dbo].[SP_DS_CHUCVU]    Script Date: 22/03/2024 7:12:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_DS_CHUCVU]
AS
	SELECT CHUCVU.sTenChucVu
	FROM CHUCVU
GO
/****** Object:  StoredProcedure [dbo].[sp_Lay_Tuoi_Nhan_Vien_Cao_Nhat]    Script Date: 22/03/2024 7:12:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_Lay_Tuoi_Nhan_Vien_Cao_Nhat]
    @tuoi INT OUTPUT
AS
BEGIN
    SET @tuoi = 0;
    SELECT @tuoi = MAX(YEAR(GETDATE()) - YEAR(dNgaySinh))
    FROM NHANVIEN;
END
GO
/****** Object:  StoredProcedure [dbo].[sp_So_luong_Sinh_Vien_Sinh_Sinh_trong_thang]    Script Date: 22/03/2024 7:12:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_So_luong_Sinh_Vien_Sinh_Sinh_trong_thang]
@thang INT , @soLuong INT OUTPUT
AS
	SELECT @soLuong = COUNT (NHANVIEN.sMaNV)
	FROM NHANVIEN
	WHERE MONTH(dNgaySinh) = @thang

GO
/****** Object:  StoredProcedure [dbo].[SP_UPDATE_NHANVIEN]    Script Date: 22/03/2024 7:12:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_UPDATE_NHANVIEN]
@sMaNV varchar(10), @sTenNV nvarchar(50),@sGioiTinh nvarChar(5), @sDiaChi nvarchar(50),
@sSDT varchar(11), @sMaChucVu varchar(10), @dNgaySinh date
AS
	UPDATE NHANVIEN
	SET sTenNV = @sTenNV, sGioiTinh = @sGioiTinh, sDiaChi = @sDiaChi,
	sSdt = @sSDT, sMaChucVu = @sMaChucVu, dNgaySinh = @dNgaySinh
	WHERE @sMaNV = sMaNV
GO
/****** Object:  StoredProcedure [dbo].[SP_XOA_NHANVIEN]    Script Date: 22/03/2024 7:12:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_XOA_NHANVIEN]
@sMaNV VARCHAR(10)
AS
	DELETE FROM NHANVIEN
	WHERE sMaNV = @sMaNV
GO
/****** Object:  StoredProcedure [dbo].[spDem_Sinh_Vien]    Script Date: 22/03/2024 7:12:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[spDem_Sinh_Vien]
@Nam INT OUTPUT,
@Nu INT OUTPUT
AS
	SET @Nam = 0;
	SET @Nu = 0;
	SELECT @Nam = COUNT(*) FROM NHANVIEN
	WHERE sGioiTinh = 'Nam'

	SELECT @Nu = COUNT(*) FROM NHANVIEN
	WHERE sGioiTinh = N'Nữ'
GO
/****** Object:  StoredProcedure [dbo].[THEM_NHANVIEN]    Script Date: 22/03/2024 7:12:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[THEM_NHANVIEN]
@sMaNV varchar(10), @sTenNV nvarchar(50),@sGioiTinh nvarChar(5), @sDiaChi nvarchar(50),
@sSDT varchar(11), @sMaChucVu varchar(10), @dNgaySinh date
AS
	INSERT INTO NHANVIEN
	VALUES
	(@sMaNV, @sTenNV, @sGioiTinh, @sDiaChi, @sSDT, @sMaChucVu, @dNgaySinh );
GO
/****** Object:  StoredProcedure [dbo].[themTaiKhoan]    Script Date: 22/03/2024 7:12:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[themTaiKhoan]
@user varchar(10), @pass varchar(10), @maNv varchar(10), @quyen bit
AS
	INSERT INTO TaiKhoan
	VALUES
	(
		@user, @pass, @maNv, @quyen
	);
GO
