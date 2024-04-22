CREATE DATABASE [QuanLyThuVien]
go

USE [QuanLyThuVien]
GO
/****** Object:  Table [dbo].[DOCGIA]    Script Date: 22/04/2024 4:53:37 PM ******/



SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DOCGIA](
	[sMaDG] [varchar](10) NOT NULL,
	[sTenDG] [nvarchar](50) NULL,
	[dNgaySinh] [datetime] NULL,
	[sGioiTinh] [nvarchar](5) NULL,
	[sDiaChi] [nvarchar](50) NULL,
	[sSdt] [varchar](11) NULL,
 CONSTRAINT [PK__DOCGIA__328E2DD7F187E24D] PRIMARY KEY CLUSTERED 
(
	[sMaDG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[Ds_DocGia]    Script Date: 22/04/2024 4:53:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Ds_DocGia]
AS
	SELECT * FROM DOCGIA
GO
/****** Object:  Table [dbo].[SACH]    Script Date: 22/04/2024 4:53:37 PM ******/
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
	[fGiaTien] [float] NULL,
	[sMaNxb] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[sMaSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CHITIETPHIEUMUON]    Script Date: 22/04/2024 4:53:37 PM ******/
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
/****** Object:  Table [dbo].[PHIEUMUONSACH]    Script Date: 22/04/2024 4:53:37 PM ******/
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
/****** Object:  View [dbo].[view_top2SachMuonNhieu]    Script Date: 22/04/2024 4:53:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[view_top2SachMuonNhieu]
AS
	SELECT TOP 2 COUNT(CTPM.sMaSach) AS [SỐ LƯỢNG], S.sTenSach  
	FROM PHIEUMUONSACH PM INNER JOIN CHITIETPHIEUMUON CTPM
	ON PM.sMaPhieuMuon = CTPM.sMaPhieuMuon INNER JOIN SACH S ON
	CTPM.sMaSach = S.sMaSach
	GROUP BY S.sTenSach  
	ORDER BY COUNT(CTPM.sMaSach) DESC
GO
/****** Object:  Table [dbo].[PHIEUTRASACH]    Script Date: 22/04/2024 4:53:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUTRASACH](
	[sMaPhieuTra] [varchar](10) NOT NULL,
	[sMaSach] [varchar](10) NOT NULL,
	[sMaPhieuMuon] [varchar](10) NULL,
	[sMaNV] [varchar](10) NULL,
	[dNgayTra] [datetime] NULL,
	[sMaDG] [varchar](10) NULL,
	[iMaTinhTrangSach] [int] NULL,
	[sMaPhieuPhat] [varchar](10) NULL,
 CONSTRAINT [PK_PHIEUTRASACH_1] PRIMARY KEY CLUSTERED 
(
	[sMaPhieuTra] ASC,
	[sMaSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 22/04/2024 4:53:37 PM ******/
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
/****** Object:  View [dbo].[view_NhanVienSiengNang]    Script Date: 22/04/2024 4:53:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[view_NhanVienSiengNang]
AS
	SELECT TOP 1  NV.sMaNV, NV.sTenNV , COUNT(NV.sMaNV) AS [SỐ LẦN LẬP PHIẾU] FROM PHIEUMUONSACH PM INNER JOIN PHIEUTRASACH PT
	ON PM.sMaPhieuMuon = PT.sMaPhieuMuon INNER JOIN NHANVIEN NV
	ON PT.sMaNV = NV.sMaNV
	GROUP BY  NV.sMaNV, NV.sTenNV
	ORDER BY COUNT(NV.sMaNV) DESC
GO
/****** Object:  View [dbo].[SACH_CO_GIA_CAO_NHAT]    Script Date: 22/04/2024 4:53:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE VIEW [dbo].[SACH_CO_GIA_CAO_NHAT]
 AS
	SELECT TOP 3 S.sMaSach, S.sTenSach, FORMAT(s.dNamXB, 'dd/MM/yyyy') AS dNamXB, S.fGiaTien
	FROM SACH S
	GROUP BY  S.sMaSach, S.sTenSach, [dNamXB], S.fGiaTien
	--ORDER BY S.fGiaTien DESC
GO
/****** Object:  View [dbo].[DS_SACH_MUON_TRONG_NGAY_HOM_NAY]    Script Date: 22/04/2024 4:53:38 PM ******/
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
/****** Object:  Table [dbo].[CHUCVU]    Script Date: 22/04/2024 4:53:38 PM ******/
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
/****** Object:  Table [dbo].[LOAIPHIEU]    Script Date: 22/04/2024 4:53:38 PM ******/
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
/****** Object:  Table [dbo].[NHAXUATBAN]    Script Date: 22/04/2024 4:53:38 PM ******/
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
/****** Object:  Table [dbo].[PHIEUPHAT]    Script Date: 22/04/2024 4:53:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUPHAT](
	[sMaPhieuPhat] [varchar](10) NOT NULL,
	[sMaPhieuTra] [varchar](10) NOT NULL,
	[iMaTinhTrangSach] [int] NULL,
	[fTienPhat] [float] NULL,
	[sGhiChu] [nvarchar](50) NULL,
 CONSTRAINT [PK_PHIEUPHAT_1] PRIMARY KEY CLUSTERED 
(
	[sMaPhieuPhat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sach_TacGia]    Script Date: 22/04/2024 4:53:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sach_TacGia](
	[sMaTG] [varchar](10) NOT NULL,
	[sMaSach] [varchar](10) NOT NULL,
 CONSTRAINT [PK_Sach_TacGia] PRIMARY KEY CLUSTERED 
(
	[sMaTG] ASC,
	[sMaSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TACGIA]    Script Date: 22/04/2024 4:53:38 PM ******/
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
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 22/04/2024 4:53:38 PM ******/
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
/****** Object:  Table [dbo].[THELOAISACH]    Script Date: 22/04/2024 4:53:38 PM ******/
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
/****** Object:  Table [dbo].[TINHTRANGSACH]    Script Date: 22/04/2024 4:53:38 PM ******/
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
INSERT [dbo].[CHITIETPHIEUMUON] ([sMaPhieuMuon], [sMaSach], [iMaLoaiPhieu], [dNgayHenTra]) VALUES (N'M11', N'MS02', 1, CAST(N'2024-03-27T00:00:00.000' AS DateTime))
INSERT [dbo].[CHITIETPHIEUMUON] ([sMaPhieuMuon], [sMaSach], [iMaLoaiPhieu], [dNgayHenTra]) VALUES (N'M3', N'MS01', 2, CAST(N'2024-02-19T00:00:00.000' AS DateTime))
INSERT [dbo].[CHITIETPHIEUMUON] ([sMaPhieuMuon], [sMaSach], [iMaLoaiPhieu], [dNgayHenTra]) VALUES (N'M3', N'MS05', 1, CAST(N'2024-02-19T00:00:00.000' AS DateTime))
INSERT [dbo].[CHITIETPHIEUMUON] ([sMaPhieuMuon], [sMaSach], [iMaLoaiPhieu], [dNgayHenTra]) VALUES (N'M4', N'MS01', 1, CAST(N'2024-03-13T00:00:00.000' AS DateTime))
INSERT [dbo].[CHITIETPHIEUMUON] ([sMaPhieuMuon], [sMaSach], [iMaLoaiPhieu], [dNgayHenTra]) VALUES (N'M4', N'MS05', 1, CAST(N'2024-03-13T00:00:00.000' AS DateTime))
INSERT [dbo].[CHITIETPHIEUMUON] ([sMaPhieuMuon], [sMaSach], [iMaLoaiPhieu], [dNgayHenTra]) VALUES (N'M4', N'MS09', 2, CAST(N'2024-03-13T00:00:00.000' AS DateTime))
INSERT [dbo].[CHITIETPHIEUMUON] ([sMaPhieuMuon], [sMaSach], [iMaLoaiPhieu], [dNgayHenTra]) VALUES (N'M5', N'MS06', 1, CAST(N'2024-02-02T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[CHUCVU] ([sMaChucVu], [sTenChucVu]) VALUES (N'CV01', N'Thủ thư')
INSERT [dbo].[CHUCVU] ([sMaChucVu], [sTenChucVu]) VALUES (N'CV02', N'Quản lý')
GO
INSERT [dbo].[DOCGIA] ([sMaDG], [sTenDG], [dNgaySinh], [sGioiTinh], [sDiaChi], [sSdt]) VALUES (N'DG01', N'Phạm Thị Hoa', CAST(N'2003-12-12T00:00:00.000' AS DateTime), N'Nữ', N'Hà Nội', N'12121')
INSERT [dbo].[DOCGIA] ([sMaDG], [sTenDG], [dNgaySinh], [sGioiTinh], [sDiaChi], [sSdt]) VALUES (N'DG02', N'Trần Văn Hùng', CAST(N'2004-01-21T00:00:00.000' AS DateTime), N'Nam', N'Phú Thọ', N'3232')
INSERT [dbo].[DOCGIA] ([sMaDG], [sTenDG], [dNgaySinh], [sGioiTinh], [sDiaChi], [sSdt]) VALUES (N'DG03', N'Trần Văn Huy', CAST(N'2004-03-18T00:00:00.000' AS DateTime), N'Nam', N'Sao Hỏa', N'78756')
INSERT [dbo].[DOCGIA] ([sMaDG], [sTenDG], [dNgaySinh], [sGioiTinh], [sDiaChi], [sSdt]) VALUES (N'DG04', N'Nguyễn Thị Ánh Viên', CAST(N'2000-12-01T00:00:00.000' AS DateTime), N'Nữ', N'Namek', N'9675')
INSERT [dbo].[DOCGIA] ([sMaDG], [sTenDG], [dNgaySinh], [sGioiTinh], [sDiaChi], [sSdt]) VALUES (N'DG05', N'Nguyễn Anh Dũng', CAST(N'2003-04-03T00:00:00.000' AS DateTime), N'Nam', N'Vegeta 2', N'027345646')
GO
INSERT [dbo].[LOAIPHIEU] ([iMaLoaiPhieu], [sTenLoaiPhieu]) VALUES (1, N'Ngắn hạn')
INSERT [dbo].[LOAIPHIEU] ([iMaLoaiPhieu], [sTenLoaiPhieu]) VALUES (2, N'Dài hạn')
GO
INSERT [dbo].[NHANVIEN] ([sMaNV], [sTenNV], [sGioiTinh], [sDiaChi], [sSdt], [sMaChucVu], [dNgaySinh]) VALUES (N'NV01', N'Đại tướng Quân', N'Nam', N'Phú Thọ', N'0333241634', N'CV02', CAST(N'2004-07-10' AS Date))
INSERT [dbo].[NHANVIEN] ([sMaNV], [sTenNV], [sGioiTinh], [sDiaChi], [sSdt], [sMaChucVu], [dNgaySinh]) VALUES (N'NV02', N'Trần Trường Giang', N'Nam', N'Hà Nội', N'03545465', N'CV01', CAST(N'2004-04-09' AS Date))
INSERT [dbo].[NHANVIEN] ([sMaNV], [sTenNV], [sGioiTinh], [sDiaChi], [sSdt], [sMaChucVu], [dNgaySinh]) VALUES (N'NV03', N'Hoàng Anh Thắng', N'Nam', N'Hà Nội', N'063537574', N'CV01', CAST(N'2004-03-09' AS Date))
INSERT [dbo].[NHANVIEN] ([sMaNV], [sTenNV], [sGioiTinh], [sDiaChi], [sSdt], [sMaChucVu], [dNgaySinh]) VALUES (N'NV04', N'Nguyễn Ngọc Anh', N'Nữ', N'Nam Định', N'017836748', N'CV02', CAST(N'2000-09-09' AS Date))
INSERT [dbo].[NHANVIEN] ([sMaNV], [sTenNV], [sGioiTinh], [sDiaChi], [sSdt], [sMaChucVu], [dNgaySinh]) VALUES (N'NV07', N'Trần Anh Quân', N'Nam', N'Hà Nội', N'02636344', N'CV02', CAST(N'2004-07-20' AS Date))
GO
INSERT [dbo].[NHAXUATBAN] ([sMaNxb], [sTenNxb]) VALUES (N'NXB01', N'KIM ĐỒNG')
INSERT [dbo].[NHAXUATBAN] ([sMaNxb], [sTenNxb]) VALUES (N'NXB02', N'THANH NIÊN')
INSERT [dbo].[NHAXUATBAN] ([sMaNxb], [sTenNxb]) VALUES (N'NXB03', N'ĐHQG HÀ NỘI')
INSERT [dbo].[NHAXUATBAN] ([sMaNxb], [sTenNxb]) VALUES (N'NXB04', N'THỜI ĐẠI')
GO
INSERT [dbo].[PHIEUMUONSACH] ([sMaPhieuMuon], [sMaDG], [dNgayMuon], [sMaNV]) VALUES (N'M11', N'DG01', CAST(N'2024-03-20T00:00:00.000' AS DateTime), N'NV01')
INSERT [dbo].[PHIEUMUONSACH] ([sMaPhieuMuon], [sMaDG], [dNgayMuon], [sMaNV]) VALUES (N'M3', N'DG03', CAST(N'2024-01-20T00:00:00.000' AS DateTime), N'NV03')
INSERT [dbo].[PHIEUMUONSACH] ([sMaPhieuMuon], [sMaDG], [dNgayMuon], [sMaNV]) VALUES (N'M4', N'DG03', CAST(N'2024-02-12T00:00:00.000' AS DateTime), N'NV04')
INSERT [dbo].[PHIEUMUONSACH] ([sMaPhieuMuon], [sMaDG], [dNgayMuon], [sMaNV]) VALUES (N'M5', N'DG04', CAST(N'2024-01-26T00:00:00.000' AS DateTime), N'NV04')
GO
INSERT [dbo].[PHIEUPHAT] ([sMaPhieuPhat], [sMaPhieuTra], [iMaTinhTrangSach], [fTienPhat], [sGhiChu]) VALUES (N'P1', N'T4', NULL, 80000, N'bạn đọc làm mất sách')
GO
INSERT [dbo].[SACH] ([sMaSach], [sTenSach], [dNamXB], [iSoLuong], [sMaLoai], [fGiaTien], [sMaNxb]) VALUES (N'MS01', N'7 viên ngọc rồng', CAST(N'2019-07-16T00:00:00.000' AS DateTime), 12, N'cotich', 15000, N'NXB01')
INSERT [dbo].[SACH] ([sMaSach], [sTenSach], [dNamXB], [iSoLuong], [sMaLoai], [fGiaTien], [sMaNxb]) VALUES (N'MS02', N'Naruto và đồng bọn', CAST(N'2013-08-06T00:00:00.000' AS DateTime), 6, N'cotich', 20000, N'NXB02')
INSERT [dbo].[SACH] ([sMaSach], [sTenSach], [dNamXB], [iSoLuong], [sMaLoai], [fGiaTien], [sMaNxb]) VALUES (N'MS04', N'Chú bé ngu ngơ', CAST(N'2024-03-19T00:00:00.000' AS DateTime), 17, N'cotich', 20000, N'NXB02')
INSERT [dbo].[SACH] ([sMaSach], [sTenSach], [dNamXB], [iSoLuong], [sMaLoai], [fGiaTien], [sMaNxb]) VALUES (N'MS05', N'Lập trình Java', CAST(N'2024-03-19T00:00:00.000' AS DateTime), 9, N'thamkhao', 20000, N'NXB03')
INSERT [dbo].[SACH] ([sMaSach], [sTenSach], [dNamXB], [iSoLuong], [sMaLoai], [fGiaTien], [sMaNxb]) VALUES (N'MS06', N'Ngôn ngữ C', CAST(N'2024-03-19T00:00:00.000' AS DateTime), 28, N'thamKhao', 50000, N'NXB03')
INSERT [dbo].[SACH] ([sMaSach], [sTenSach], [dNamXB], [iSoLuong], [sMaLoai], [fGiaTien], [sMaNxb]) VALUES (N'MS07', N'Tình yêu của Quân', CAST(N'2015-07-01T00:00:00.000' AS DateTime), 11, N'kinhdi', 80000, N'NXB04')
INSERT [dbo].[SACH] ([sMaSach], [sTenSach], [dNamXB], [iSoLuong], [sMaLoai], [fGiaTien], [sMaNxb]) VALUES (N'MS09', N'Đôi bạn Nhện và Bò', CAST(N'2024-03-19T00:00:00.000' AS DateTime), 22, N'ttranh', 12000, N'NXB01')
INSERT [dbo].[SACH] ([sMaSach], [sTenSach], [dNamXB], [iSoLuong], [sMaLoai], [fGiaTien], [sMaNxb]) VALUES (N'MS10', N'Khỉ con chơi đồ', CAST(N'2024-03-19T00:00:00.000' AS DateTime), 11, N'cotich', 12000, N'NXB03')
INSERT [dbo].[SACH] ([sMaSach], [sTenSach], [dNamXB], [iSoLuong], [sMaLoai], [fGiaTien], [sMaNxb]) VALUES (N'MS11', N'Chu be loat choat', CAST(N'2019-06-13T00:00:00.000' AS DateTime), 0, N'cotich', 12000, N'NXB02')
GO
INSERT [dbo].[Sach_TacGia] ([sMaTG], [sMaSach]) VALUES (N'TG01', N'MS01')
INSERT [dbo].[Sach_TacGia] ([sMaTG], [sMaSach]) VALUES (N'TG01', N'MS02')
INSERT [dbo].[Sach_TacGia] ([sMaTG], [sMaSach]) VALUES (N'TG01', N'MS05')
INSERT [dbo].[Sach_TacGia] ([sMaTG], [sMaSach]) VALUES (N'TG01', N'MS07')
INSERT [dbo].[Sach_TacGia] ([sMaTG], [sMaSach]) VALUES (N'TG01', N'MS10')
INSERT [dbo].[Sach_TacGia] ([sMaTG], [sMaSach]) VALUES (N'TG01', N'MS11')
INSERT [dbo].[Sach_TacGia] ([sMaTG], [sMaSach]) VALUES (N'TG02', N'MS01')
INSERT [dbo].[Sach_TacGia] ([sMaTG], [sMaSach]) VALUES (N'TG02', N'MS04')
INSERT [dbo].[Sach_TacGia] ([sMaTG], [sMaSach]) VALUES (N'TG02', N'MS06')
INSERT [dbo].[Sach_TacGia] ([sMaTG], [sMaSach]) VALUES (N'TG02', N'MS09')
INSERT [dbo].[Sach_TacGia] ([sMaTG], [sMaSach]) VALUES (N'TG03', N'MS05')
INSERT [dbo].[Sach_TacGia] ([sMaTG], [sMaSach]) VALUES (N'TG03', N'MS11')
INSERT [dbo].[Sach_TacGia] ([sMaTG], [sMaSach]) VALUES (N'TG04', N'MS06')
GO
INSERT [dbo].[TACGIA] ([sMaTG], [sTenTG], [sDiaChi], [sSdt]) VALUES (N'TG01', N'Trần Anh Quân', N'Phú Thọ -Việt Nam', N'114')
INSERT [dbo].[TACGIA] ([sMaTG], [sTenTG], [sDiaChi], [sSdt]) VALUES (N'TG02', N'Lưu Bang', N'Trung Quốc', N'22222')
INSERT [dbo].[TACGIA] ([sMaTG], [sTenTG], [sDiaChi], [sSdt]) VALUES (N'TG03', N'Hàn Tín', N'Trung Quốc', N'676767')
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
/****** Object:  Index [UNIQUE_sTenTheLoai]    Script Date: 22/04/2024 4:53:38 PM ******/
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
ALTER TABLE [dbo].[PHIEUPHAT]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUPHAT_MaTinhTrangSach] FOREIGN KEY([iMaTinhTrangSach])
REFERENCES [dbo].[TINHTRANGSACH] ([iMaTinhTrang])
GO
ALTER TABLE [dbo].[PHIEUPHAT] CHECK CONSTRAINT [FK_PHIEUPHAT_MaTinhTrangSach]
GO
ALTER TABLE [dbo].[PHIEUTRASACH]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUTRASACH_CHITIETPHIEUMUON] FOREIGN KEY([sMaPhieuMuon], [sMaSach])
REFERENCES [dbo].[CHITIETPHIEUMUON] ([sMaPhieuMuon], [sMaSach])
GO
ALTER TABLE [dbo].[PHIEUTRASACH] CHECK CONSTRAINT [FK_PHIEUTRASACH_CHITIETPHIEUMUON]
GO
ALTER TABLE [dbo].[PHIEUTRASACH]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUTRASACH_iMaTinhTrangSach] FOREIGN KEY([iMaTinhTrangSach])
REFERENCES [dbo].[TINHTRANGSACH] ([iMaTinhTrang])
GO
ALTER TABLE [dbo].[PHIEUTRASACH] CHECK CONSTRAINT [FK_PHIEUTRASACH_iMaTinhTrangSach]
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
ALTER TABLE [dbo].[PHIEUTRASACH]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUTRASACH_sMaPhieuPhat] FOREIGN KEY([sMaPhieuPhat])
REFERENCES [dbo].[PHIEUPHAT] ([sMaPhieuPhat])
GO
ALTER TABLE [dbo].[PHIEUTRASACH] CHECK CONSTRAINT [FK_PHIEUTRASACH_sMaPhieuPhat]
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
ALTER TABLE [dbo].[Sach_TacGia]  WITH CHECK ADD  CONSTRAINT [FK_Sach_TacGia_MaSach] FOREIGN KEY([sMaSach])
REFERENCES [dbo].[SACH] ([sMaSach])
GO
ALTER TABLE [dbo].[Sach_TacGia] CHECK CONSTRAINT [FK_Sach_TacGia_MaSach]
GO
ALTER TABLE [dbo].[Sach_TacGia]  WITH CHECK ADD  CONSTRAINT [FK_Sach_TacGia_sMaTG] FOREIGN KEY([sMaTG])
REFERENCES [dbo].[TACGIA] ([sMaTG])
GO
ALTER TABLE [dbo].[Sach_TacGia] CHECK CONSTRAINT [FK_Sach_TacGia_sMaTG]
GO
ALTER TABLE [dbo].[TaiKhoan]  WITH CHECK ADD  CONSTRAINT [FK_TaiKhoan_sMaNv] FOREIGN KEY([sMaNV])
REFERENCES [dbo].[NHANVIEN] ([sMaNV])
GO
ALTER TABLE [dbo].[TaiKhoan] CHECK CONSTRAINT [FK_TaiKhoan_sMaNv]
GO
ALTER TABLE [dbo].[SACH]  WITH CHECK ADD  CONSTRAINT [Check_namXB] CHECK  ((datepart(year,[dNamXb])>=(2010)))
GO
ALTER TABLE [dbo].[SACH] CHECK CONSTRAINT [Check_namXB]
GO
/****** Object:  StoredProcedure [dbo].[KiemTraCapNhatNgayHenTra]    Script Date: 22/04/2024 4:53:38 PM ******/
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
/****** Object:  StoredProcedure [dbo].[proc_capNhatNhanVien]    Script Date: 22/04/2024 4:53:38 PM ******/
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
/****** Object:  StoredProcedure [dbo].[proc_capNhatNhanVienQLNV]    Script Date: 22/04/2024 4:53:38 PM ******/
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
/****** Object:  StoredProcedure [dbo].[proc_capNhatPhieuMuon]    Script Date: 22/04/2024 4:53:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[proc_capNhatPhieuMuon]
@maPhieuMuon varchar(10), @maSach varchar(10), @maLoaiPhieu varchar(10)
AS
	UPDATE CHITIETPHIEUMUON
	SET sMaPhieuMuon = @maPhieuMuon,sMaSach = @maSach, iMaLoaiPhieu = @maLoaiPhieu
	WHERE sMaPhieuMuon = @maPhieuMuon
GO
/****** Object:  StoredProcedure [dbo].[proc_capNhatPhieuTRa]    Script Date: 22/04/2024 4:53:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[proc_capNhatPhieuTRa]
@maPhieuTra varchar(10), @maSach varchar(10), @maPhieuMuon varchar(10), 
@maNV varchar(10), @ngayTra DATE, @maDG varchar(10), @maTinhTrangSach int
AS
	 UPDATE PHIEUTRASACH
	SET sMaSach = @maSach, sMaPhieuMuon = @maPhieuMuon, sMaNV = @maNV, 
	dNgayTra = @ngayTra, sMaDG = @maDG, iMaTinhTrangSach = @maTinhTrangSach
	WHERE sMaPhieuTra = @maPhieuTra
GO
/****** Object:  StoredProcedure [dbo].[proc_capNhatSach]    Script Date: 22/04/2024 4:53:38 PM ******/
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
/****** Object:  StoredProcedure [dbo].[proc_capNhatSachs]    Script Date: 22/04/2024 4:53:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[proc_capNhatSachs]
@maSach varchar(10), @tenSach nvarchar(30), @namXB date, @soLuong int,
@maLoai varchar(10), @giaTien float, @maNXB varchar(10)
AS
	UPDATE SACH
	SET  sTenSach = @tenSach, dNamXB = @namXB, iSoLuong = @soLuong,
		sMaLoai = @maLoai, fGiaTien = @giaTien, sMaNxb = @maNXB
	WHERE sMaSach = @maSach
GO
/****** Object:  StoredProcedure [dbo].[proc_capNhatTacGia]    Script Date: 22/04/2024 4:53:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[proc_capNhatTacGia]
@tenTG nvarchar(30), @diaChi nvarchar(50), @sdt nvarchar(10), @maTG varchar(10) 
AS
	UPDATE TACGIA
	SET sTenTG = @tenTG, sDiaChi = @diaChi, sSdt = @sdt
	WHERE sMaTG = @maTG
GO
/****** Object:  StoredProcedure [dbo].[proc_capNhatTaiKhoan]    Script Date: 22/04/2024 4:53:38 PM ******/
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
/****** Object:  StoredProcedure [dbo].[proc_checkQuyen]    Script Date: 22/04/2024 4:53:38 PM ******/
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
/****** Object:  StoredProcedure [dbo].[proc_doiMatKhau]    Script Date: 22/04/2024 4:53:38 PM ******/
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
/****** Object:  StoredProcedure [dbo].[proc_dongTacGia]    Script Date: 22/04/2024 4:53:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROC [dbo].[proc_dongTacGia]
@maTG varchar(10), @maSach varchar(10)
AS
	INSERT INTO Sach_TacGia
	VALUES(
		@maTG, @maSach
	);
GO
/****** Object:  StoredProcedure [dbo].[proc_dsDocGia]    Script Date: 22/04/2024 4:53:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[proc_dsDocGia]
AS
	SELECT DOCGIA.sMaDG, DOCGIA.sTenDG, FORMAT(DOCGIA.dNgaySinh, 'dd/MM/yyyy') AS 'dNgaySinh', DOCGIA.sGioiTinh,
	DOCGIA.sDiaChi, DOCGIA.sSdt
	FROM DOCGIA
GO
/****** Object:  StoredProcedure [dbo].[proc_dsPhieuMuon]    Script Date: 22/04/2024 4:53:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[proc_dsPhieuMuon]
AS
	SELECT PM.sMaPhieuMuon, PM.sMaDG, FORMAT(PM.dNgayMuon, 'dd/MM/yyyy') as dNgayMuon, PM.sMaNV, CTPM.sMaSach, 
		CTPM.iMaLoaiPhieu, FORMAT(CTPM.dNgayHenTra, 'dd/MM/yyyy') as dNgayHenTra
	FROM PHIEUMUONSACH AS PM RIGHT JOIN CHITIETPHIEUMUON AS CTPM
				ON PM.sMaPhieuMuon = CTPM.sMaPhieuMuon 
GO
/****** Object:  StoredProcedure [dbo].[proc_dsPhieuMuonTheoMa]    Script Date: 22/04/2024 4:53:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[proc_dsPhieuMuonTheoMa]
@maPhieuMuon varchar(10)
AS
	SELECT PM.sMaPhieuMuon,DG.sTenDG,S.sTenSach,CTPM.iMaLoaiPhieu,FORMAT(PM.dNgayMuon, 'dd/MM/yyyy') AS dNgayMuon
	,FORMAT(CTPM.dNgayHenTra, 'dd/MM/yyyy') AS dNgayHenTra, NV.sTenNV
	FROM NHANVIEN AS NV 
	INNER JOIN PHIEUMUONSACH AS PM ON NV.sMaNV = PM.sMaNV 
	RIGHT JOIN CHITIETPHIEUMUON AS CTPM ON PM.sMaPhieuMuon = CTPM.sMaPhieuMuon 
	INNER JOIN SACH AS S ON CTPM.sMaSach = S.sMaSach
	INNER JOIN DocGia AS DG ON PM.sMaDG = DG.sMaDG
	Where PM.sMaPhieuMuon = @maPhieuMuon
GO
/****** Object:  StoredProcedure [dbo].[proc_dsPhieuTraSach]    Script Date: 22/04/2024 4:53:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[proc_dsPhieuTraSach]
AS
	SELECT PT.sMaPhieuTra, PT.sMaSach, PT.sMaPhieuMuon, PT.sMaNV, FORMAT(PT.dNgayTra, 'dd/MM/yyyy') AS dNgayTra,
	PT.sMaDG, PT.iMaTinhTrangSach, PT.sMaPhieuPhat
	FROM PHIEUTRASACH AS PT
GO
/****** Object:  StoredProcedure [dbo].[proc_dsSachTaiBan]    Script Date: 22/04/2024 4:53:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[proc_dsSachTaiBan]
@taiBan nvarchar(10)
AS
	SELECT * FROM SACH
	WHERE sTaiBan = @taiBan
GO
/****** Object:  StoredProcedure [dbo].[proc_dsTacGia]    Script Date: 22/04/2024 4:53:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[proc_dsTacGia]
AS
	select * from TACGIA
GO
/****** Object:  StoredProcedure [dbo].[proc_dsTaiKhoan]    Script Date: 22/04/2024 4:53:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[proc_dsTaiKhoan]
AS
	SELECT *
	FROM TaiKhoan
GO
/****** Object:  StoredProcedure [dbo].[proc_getNhanVien]    Script Date: 22/04/2024 4:53:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

----------------- NHÂN VIÊN

CREATE PROC [dbo].[proc_getNhanVien]
AS
	SELECT sMaNV, sTenNV, sGioiTinh, sDiaChi, sSdt, sMaChucVu, FORMAT(dNgaySinh, 'dd/MM/yyyy') as 'dNgaySinh' FROM NHANVIEN
GO
/****** Object:  StoredProcedure [dbo].[proc_getSach]    Script Date: 22/04/2024 4:53:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[proc_getSach]
AS
	SELECT SACH.sMaSach, SACH.sTenSach, FORMAT(dNamXB, 'dd/MM/yyyy') as dNamXB, SACH.iSoLuong, SACH.sMaLoai, SACH.fGiaTien,
	SACH.sMaNxb, Sach_TacGia.sMaTG
	FROM SACH INNER JOIN Sach_TacGia
	ON SACH.sMaSach = Sach_TacGia.sMaSach
GO
/****** Object:  StoredProcedure [dbo].[proc_getSachChonLoc]    Script Date: 22/04/2024 4:53:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[proc_getSachChonLoc]
AS
	SELECT SACH.sMaSach, SACH.sTenSach, FORMAT(SACH.dNamXB, 'dd/MM/yyyy') AS dNamXB, SACH.iSoLuong, SACH.sMaLoai, SACH.fGiaTien,
       SACH.sMaNxb, Sach_TacGia.sMaTG
	FROM SACH
	INNER JOIN Sach_TacGia ON SACH.sMaSach = Sach_TacGia.sMaSach
	WHERE Sach_TacGia.sMaTG = (SELECT MIN(sMaTG) FROM Sach_TacGia WHERE Sach_TacGia.sMaSach = SACH.sMaSach);
GO
/****** Object:  StoredProcedure [dbo].[proc_getTaiKhoan]    Script Date: 22/04/2024 4:53:38 PM ******/
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
/****** Object:  StoredProcedure [dbo].[proc_login]    Script Date: 22/04/2024 4:53:38 PM ******/
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
/****** Object:  StoredProcedure [dbo].[proc_suaDocGia]    Script Date: 22/04/2024 4:53:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[proc_suaDocGia]
@maDG varchar(10), @tenDG nvarchar(50), @ngaySinh datetime, @gioiTinh NVARCHAR(5), @diaChi nvarchar(50), @sdt varchar(10)
AS
	UPDATE DOCGIA
	SET sTenDG = @tenDG, dNgaySinh = @ngaySinh, sGioiTinh = @gioiTinh,
	sDiaChi = @diaChi, sSdt = @sdt
	WHERE sMaDG = @maDG
GO
/****** Object:  StoredProcedure [dbo].[proc_themChiTietPhieuMuon]    Script Date: 22/04/2024 4:53:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[proc_themChiTietPhieuMuon]
@maPhieuMuon varchar(10), @maSach varchar(10), @maLoaiPhieu varchar(10)
AS
	INSERT INTO CHITIETPHIEUMUON
	VALUES(
		@maPhieuMuon, @maSach, @maLoaiPhieu, NULL
	);
GO
/****** Object:  StoredProcedure [dbo].[proc_themDocGia]    Script Date: 22/04/2024 4:53:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROC [dbo].[proc_themDocGia]
@maDG varchar(10), @tenDG nvarchar(50), @ngaySinh datetime, @gioiTinh nvarchar(5), @diaChi nvarchar(50), @sdt varchar(10)
AS
	INSERT INTO DOCGIA
	VALUES
	(
		@maDG, @tenDG, @ngaySinh, @gioiTinh, @diaChi, @sdt
	);
GO
/****** Object:  StoredProcedure [dbo].[proc_themNhanVien]    Script Date: 22/04/2024 4:53:38 PM ******/
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
/****** Object:  StoredProcedure [dbo].[proc_themPhieuMuon]    Script Date: 22/04/2024 4:53:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROC [dbo].[proc_themPhieuMuon]
    @maPhieuMuon VARCHAR(10),
    @maDG VARCHAR(10),
    @ngayMuon DATE,
    @maNV VARCHAR(10),
    @maSach VARCHAR(10),
    @maLoaiPhieu INT
 AS
    INSERT INTO PHIEUMUONSACH
    VALUES (
        @maPhieuMuon, @maDG, @ngayMuon, @maNV
    );

    INSERT INTO CHITIETPHIEUMUON
    VALUES (
        @maPhieuMuon, @maSach, @maLoaiPhieu, null
    );
GO
/****** Object:  StoredProcedure [dbo].[proc_themPhieuTra]    Script Date: 22/04/2024 4:53:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[proc_themPhieuTra]
@maPhieuTra varchar(10), @maSach varchar(10), @maPhieuMuon varchar(10), 
@maNV varchar(10), @ngayTra DATE, @maDG varchar(10), @maTinhTrangSach int
AS
	INSERT INTO PHIEUTRASACH
	VALUES
	(
		@maPhieuTra, @maSach, @maPhieuMuon, @maNV, @ngayTra, @maDG, @maTinhTrangSach, NULL
	);

exec proc_themPhieuTra 'TRA2', 'MS06', 'M5', 'NV03' ,'2024-02-02', 'DG04', 1

	

SELECT * FROM PHIEUMUONSACH
SELECT * FROM CHITIETPHIEUMUON
SELECT * FROM PHIEUTRASACH

GO
/****** Object:  StoredProcedure [dbo].[proc_themSach]    Script Date: 22/04/2024 4:53:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
	

------------------------------------------------------------------ SÁCH
CREATE PROC	[dbo].[proc_themSach]
@maSach varchar(10), @tenSach nvarchar(30), @namXB date, @soLuong int,
@maLoai varchar(10), @maTacGia varchar(10), @giaTien float, @maNXB varchar(10)
AS
	INSERT INTO SACH 
	VALUES(
		@maSach, @tenSach, @namXB, @soLuong, @maLoai, @giaTien, @maNXB
	);

	INSERT INTO Sach_TacGia
	VALUES(
		@maTacGia , @maSach
	);
GO
/****** Object:  StoredProcedure [dbo].[proc_themTacGia]    Script Date: 22/04/2024 4:53:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[proc_themTacGia]
@maTG varchar(10), @tenTG nvarchar(30), @diaChi nvarchar(50), @sdt nvarchar(10)
AS
	INSERT INTO TACGIA
	VALUES
	(
		@maTG, @tenTG, @diaChi, @sdt	
	);
GO
/****** Object:  StoredProcedure [dbo].[proc_themTaiKhoan]    Script Date: 22/04/2024 4:53:38 PM ******/
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
/****** Object:  StoredProcedure [dbo].[proc_timKiemDocGiaTheoMaDG]    Script Date: 22/04/2024 4:53:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[proc_timKiemDocGiaTheoMaDG]
@maDG varchar(10)
AS
	SELECT DOCGIA.sMaDG, DOCGIA.sTenDG, FORMAT(DOCGIA.dNgaySinh, 'dd/MM/yyyy') AS 'dNgaySinh', DOCGIA.sGioiTinh,
	DOCGIA.sDiaChi, DOCGIA.sSdt
	FROM DOCGIA
	WHERE sMaDG LIKE '%' + @maDG + '%'

--------------------------------------------TÁC GIẢ
GO
/****** Object:  StoredProcedure [dbo].[proc_timKiemDocGiaTheoTen]    Script Date: 22/04/2024 4:53:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[proc_timKiemDocGiaTheoTen]
@tenDG Nvarchar(30)
AS
	SELECT DOCGIA.sMaDG, DOCGIA.sTenDG, FORMAT(DOCGIA.dNgaySinh, 'dd/MM/yyyy') AS 'dNgaySinh', DOCGIA.sGioiTinh,
	DOCGIA.sDiaChi, DOCGIA.sSdt
	FROM DOCGIA
	WHERE sTenDG LIKE '%' + @tenDG + '%'
GO
/****** Object:  StoredProcedure [dbo].[proc_timKiemPhieuMuonTheoDG]    Script Date: 22/04/2024 4:53:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[proc_timKiemPhieuMuonTheoDG]
@maDG varchar(10)
AS
	SELECT PM.sMaPhieuMuon, PM.sMaDG, FORMAT(PM.dNgayMuon, 'dd/MM/yyyy') as dNgayMuon, PM.sMaNV, CTPM.sMaSach, 
		CTPM.iMaLoaiPhieu, FORMAT(CTPM.dNgayHenTra, 'dd/MM/yyyy') as dNgayHenTra
	FROM PHIEUMUONSACH AS PM RIGHT JOIN CHITIETPHIEUMUON AS CTPM ON PM.sMaPhieuMuon = CTPM.sMaPhieuMuon
	WHERE PM.sMaDG LIKE '%' + @maDG + '%'
GO
/****** Object:  StoredProcedure [dbo].[proc_timKiemPhieuMuonTheoMaPM]    Script Date: 22/04/2024 4:53:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[proc_timKiemPhieuMuonTheoMaPM]
@maPhieuMuon varchar(10)
AS
	SELECT PM.sMaPhieuMuon, PM.sMaDG, FORMAT(PM.dNgayMuon, 'dd/MM/yyyy') as dNgayMuon, PM.sMaNV, CTPM.sMaSach, 
		CTPM.iMaLoaiPhieu, FORMAT(CTPM.dNgayHenTra, 'dd/MM/yyyy') as dNgayHenTra
	FROM PHIEUMUONSACH AS PM RIGHT JOIN CHITIETPHIEUMUON AS CTPM ON PM.sMaPhieuMuon = CTPM.sMaPhieuMuon
	WHERE PM.sMaPhieuMuon LIKE '%' + @maPhieuMuon + '%'
GO
/****** Object:  StoredProcedure [dbo].[proc_timKiemTGTheoMaTG]    Script Date: 22/04/2024 4:53:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[proc_timKiemTGTheoMaTG]
@maTG varchar(10)
AS
	SELECT * FROM TACGIA
	WHERE sMaTG LIKE '%' + @maTG + '%'
GO
/****** Object:  StoredProcedure [dbo].[proc_timKiemTGTheoTen]    Script Date: 22/04/2024 4:53:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[proc_timKiemTGTheoTen]
@tenTG nvarchar(30)
AS
	SELECT * FROM TACGIA
	WHERE sTenTG LIKE '%' + @tenTG + '%'
GO
/****** Object:  StoredProcedure [dbo].[proc_timKiemTheoMaLoai]    Script Date: 22/04/2024 4:53:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[proc_timKiemTheoMaLoai]
@maLoai varchar(10)
AS
	SELECT SACH.sMaSach, SACH.sTenSach, FORMAT(dNamXB, 'dd/MM/yyyy') as dNamXB, SACH.iSoLuong, SACH.sMaLoai, SACH.fGiaTien,
	SACH.sMaNxb, Sach_TacGia.sMaTG
	FROM SACH INNER JOIN Sach_TacGia
	ON SACH.sMaSach = Sach_TacGia.sMaSach
	WHERE sMaLoai LIKE '%' + @maLoai +'%'
GO
/****** Object:  StoredProcedure [dbo].[proc_timKiemTheoMaNV]    Script Date: 22/04/2024 4:53:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[proc_timKiemTheoMaNV]
@maNV nvarchar(30)
AS
	SELECT *
	FROM TaiKhoan 
	WHERE sMaNV LIKE '%' + @maNV + '%'
GO
/****** Object:  StoredProcedure [dbo].[proc_timKiemTheoMaSach]    Script Date: 22/04/2024 4:53:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[proc_timKiemTheoMaSach]
@maSach varchar(10)
AS
	SELECT SACH.sMaSach, SACH.sTenSach, FORMAT(dNamXB, 'dd/MM/yyyy') as dNamXB, SACH.iSoLuong, SACH.sMaLoai, SACH.fGiaTien,
	SACH.sMaNxb, Sach_TacGia.sMaTG
	FROM SACH INNER JOIN Sach_TacGia
	ON SACH.sMaSach = Sach_TacGia.sMaSach
	WHERE SACH.sMaSach LIKE '%' + @maSach +'%'
GO
/****** Object:  StoredProcedure [dbo].[proc_timKiemTheoTenNV]    Script Date: 22/04/2024 4:53:38 PM ******/
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
/****** Object:  StoredProcedure [dbo].[proc_timKiemTheoTenSach]    Script Date: 22/04/2024 4:53:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[proc_timKiemTheoTenSach]
@tenSach nvarchar(30)
AS
	SELECT SACH.sMaSach, SACH.sTenSach, FORMAT(dNamXB, 'dd/MM/yyyy') as dNamXB, SACH.iSoLuong, SACH.sMaLoai, SACH.fGiaTien,
	SACH.sMaNxb, Sach_TacGia.sMaTG
	FROM SACH INNER JOIN Sach_TacGia
	ON SACH.sMaSach = Sach_TacGia.sMaSach
	WHERE sTenSach LIKE '%' + @tenSach +'%'
GO
/****** Object:  StoredProcedure [dbo].[proc_timkiemTKTheoTenNV]    Script Date: 22/04/2024 4:53:38 PM ******/
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
/****** Object:  StoredProcedure [dbo].[proc_timKiemTKTheoUser]    Script Date: 22/04/2024 4:53:38 PM ******/
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
/****** Object:  StoredProcedure [dbo].[proc_xoaDocGia]    Script Date: 22/04/2024 4:53:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[proc_xoaDocGia]
@maDG varchar(10)
AS
	DELETE FROM DOCGIA
	WHERE DOCGIA.sMaDG = @maDG
GO
/****** Object:  StoredProcedure [dbo].[proc_xoaNhanVien]    Script Date: 22/04/2024 4:53:38 PM ******/
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
/****** Object:  StoredProcedure [dbo].[proc_xoaPhieuMuon]    Script Date: 22/04/2024 4:53:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[proc_xoaPhieuMuon]
@maPhieuMuon varchar (10)
AS
	DELETE fROM CHITIETPHIEUMUON
	WHERE sMaPhieuMuon = @maPhieuMuon
GO
/****** Object:  StoredProcedure [dbo].[proc_XoaPhieuTra]    Script Date: 22/04/2024 4:53:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[proc_XoaPhieuTra]
@maPhieuTra varchar(10)
AS
	DELETE FROM PHIEUTRASACH
	WHERE sMaPhieuTra = @maPhieuTra
GO
/****** Object:  StoredProcedure [dbo].[proc_xoaSach]    Script Date: 22/04/2024 4:53:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[proc_xoaSach]
@maSach varchar(10), @maTG varchaR(10)
AS
	DELETE Sach_TacGia
	WHERE sMaSach = @maSach AND sMaTG = @maTG

	DELETE SACH
	WHERE sMaSach = @maSach

	
GO
/****** Object:  StoredProcedure [dbo].[proc_xoaTacGia]    Script Date: 22/04/2024 4:53:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[proc_xoaTacGia]
@maTG varchar(10)
AS 
	DELETE FROM TACGIA
	WHERE sMaTG = @maTG
GO
/****** Object:  StoredProcedure [dbo].[proc_xoaTaiKhoan]    Script Date: 22/04/2024 4:53:38 PM ******/
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
/****** Object:  StoredProcedure [dbo].[SELECT_NHANVIEN]    Script Date: 22/04/2024 4:53:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SELECT_NHANVIEN]
AS
	SELECT NHANVIEN.sMaNV, NHANVIEN.sTenNV, NHANVIEN.sGioiTinh, NHANVIEN.sDiaChi, NHANVIEN.sSdt, FORMAT( NHANVIEN.dNgaySinh, 'dd/MM/yyyy') AS [Ngày sinh], NHANVIEN.sMaChucVu
	FROM NHANVIEN
GO
/****** Object:  StoredProcedure [dbo].[SP_DS_CHUCVU]    Script Date: 22/04/2024 4:53:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_DS_CHUCVU]
AS
	SELECT CHUCVU.sTenChucVu
	FROM CHUCVU
GO
/****** Object:  StoredProcedure [dbo].[sp_Lay_Tuoi_Nhan_Vien_Cao_Nhat]    Script Date: 22/04/2024 4:53:38 PM ******/
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
/****** Object:  StoredProcedure [dbo].[sp_So_luong_Sinh_Vien_Sinh_Sinh_trong_thang]    Script Date: 22/04/2024 4:53:38 PM ******/
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
/****** Object:  StoredProcedure [dbo].[SP_UPDATE_NHANVIEN]    Script Date: 22/04/2024 4:53:38 PM ******/
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
/****** Object:  StoredProcedure [dbo].[SP_XOA_NHANVIEN]    Script Date: 22/04/2024 4:53:38 PM ******/
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
/****** Object:  StoredProcedure [dbo].[spDem_Sinh_Vien]    Script Date: 22/04/2024 4:53:38 PM ******/
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
/****** Object:  StoredProcedure [dbo].[THEM_NHANVIEN]    Script Date: 22/04/2024 4:53:38 PM ******/
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
/****** Object:  StoredProcedure [dbo].[themTaiKhoan]    Script Date: 22/04/2024 4:53:38 PM ******/
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
