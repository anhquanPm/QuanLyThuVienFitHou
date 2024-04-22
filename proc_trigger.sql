
----------------- NHÂN VIÊN

ALTER PROC proc_getNhanVien
AS
	SELECT sMaNV, sTenNV, sGioiTinh, sDiaChi, sSdt, sMaChucVu, FORMAT(dNgaySinh, 'dd/MM/yyyy') as 'dNgaySinh' FROM NHANVIEN
GO

exec proc_getNhanVien
GO

CREATE PROC proc_capNhatNhanVien
@maNV varchar(10) ,@tenNV nvarchar(30), @gioiTinh nvarchar(5), @diaChi nvarchar(30), @sdt varchar(10), @ngaySinh date
AS
	Update NHANVIEN
	Set sTenNV = @tenNV, sGioiTinh = @gioiTinh, sDiaChi = @diaChi, sSdt = @sdt, dNgaySinh = @ngaySinh
	WHERE sMaNV = @maNV

GO

CREATE PROC proc_capNhatNhanVienQLNV
@maNV varchar(10) ,@tenNV nvarchar(30), @gioiTinh nvarchar(5), @diaChi nvarchar(30), @sdt varchar(10),@macv varchar(10)  ,@ngaySinh date
AS
	Update NHANVIEN
	Set sTenNV = @tenNV, sGioiTinh = @gioiTinh, sDiaChi = @diaChi, sSdt = @sdt, sMaChucVu = @macv ,dNgaySinh = @ngaySinh
	WHERE sMaNV = @maNV

GO

CREATE PROC proc_themNhanVien
@maNV varchar(10) ,@tenNV nvarchar(30), @gioiTinh nvarchar(5), @diaChi nvarchar(30), @sdt varchar(10),@macv varchar(10)  ,@ngaySinh date
AS
	INSERT INTO NHANVIEN
	VALUES
	(
		@maNV, @tenNV, @gioiTinh, @diaChi, @sdt, @macv, @ngaySinh
	);
GO

CREATE PROC proc_xoaNhanVien
@manv varchar(10)
AS	
	DELETE NHANVIEN
	WHERE sMaNV = @manv
GO
	


alter PROC proc_timKiemTheoMaNV
@manv varchar(10)
AS
	SELECT sMaNV, sTenNV, sGioiTinh, sDiaChi, sSdt, sMaChucVu, FORMAT(dNgaySinh, 'dd/MM/yyyy') as 'dNgaySinh'
	FROM NHANVIEN
	WHERE sMaNV LIKE '%' + @manv + '%';

GO

ALTER PROC proc_timKiemTheoTenNV
@tennv varchar(10)
AS
	SELECT sMaNV, sTenNV, sGioiTinh, sDiaChi, sSdt, sMaChucVu, FORMAT(dNgaySinh, 'dd/MM/yyyy') as 'dNgaySinh'
	FROM NHANVIEN
	WHERE sTenNV LIKE '%' + @tennv + '%';
GO


----------------------------------------------------------------- SÁCH
ALTER PROC proc_getSach
AS
	SELECT sMaSach, sTenSach, FORMAT(dNamXB, 'dd/MM/yyyy') AS N'dNamXB', iSoLuong, sMaLoai, sMaTG, fGiaTien, sMaNxb 
	FROM SACH
GO

go

----------------------------------------------------------------- TÀI KHOẢN

CREATE PROC proc_getTaiKhoan
@user varchar(10), @pass varchar(10)
AS
	select NHANVIEN.sMaNV,  NHANVIEN.sTenNV, NHANVIEN.sGioiTinh, NHANVIEN.sDiaChi, NHANVIEN.sSdt, NHANVIEN.dNgaySinh
	from TaiKhoan INNER JOIN NHANVIEN ON TaiKhoan.sMaNV = NHANVIEN.sMaNV
	WHERE TaiKhoan.sUserName = @user and TaiKhoan.sPassWord = @pass
GO



CREATE PROC proc_doiMatKhau
@user varchar(10), @pass varchar(10)
AS	
	UPDATE TaiKhoan		
	set sPassWord = @pass
	WHERE sUserName = @user
GO


ALTER PROC proc_checkQuyen
@user varchar(10), @pass varchar(10)
AS
	SELECT bQuyen FROM TaiKhoan 
	WHERE sUserName = @user AND sPassWord = @pass AND bQuyen = 1
GO

EXEC proc_checkQuyen admin, 1

GO

CREATE PROC proc_dsTaiKhoan
AS
	SELECT *
	FROM TaiKhoan
GO

CREATE PROC proc_themTaiKhoan
@user varchar(10), @pass varchar(10), @maNv varchar(10), @quyen bit
AS
	INSERT INTO TaiKhoan
	VALUES
	(
		@user, @pass, @maNv, @quyen
	);
GO

CREATE PROC proc_capNhatTaiKhoan
@user varchar(10), @pass varchar(10), @quyen bit
AS
	UPDATE TaiKhoan
	SET sPassWord = @pass, bQuyen = @quyen
	WHERE sUserName = @user
GO

CREATE PROC proc_xoaTaiKhoan
@user varchar(10)
AS
	DELETE FROM TaiKhoan
	WHERE sUserName = @user
GO

CREATE PROC proc_timKiemTKTheoUser
@user varchar(10)
AS
	SELECT *
	FROM TaiKhoan
	WHERE sUserName LIKE '%' + @user + '%'
GO

ALTER PROC proc_timKiemTheoMaNV
@maNV nvarchar(30)
AS
	SELECT *
	FROM TaiKhoan 
	WHERE sMaNV LIKE '%' + @maNV + '%'
GO
	

------------------------------------------------------------------ SÁCH
ALTER PROC	proc_themSach
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



ALTER PROC proc_dongTacGia
@maTG varchar(10), @maSach varchar(10)
AS
	INSERT INTO Sach_TacGia
	VALUES(
		@maTG, @maSach
	);
go

ALTER PROC proc_getSach
AS
	SELECT SACH.sMaSach, SACH.sTenSach, FORMAT(dNamXB, 'dd/MM/yyyy') as dNamXB, SACH.iSoLuong, SACH.sMaLoai, SACH.fGiaTien,
	SACH.sMaNxb, Sach_TacGia.sMaTG
	FROM SACH INNER JOIN Sach_TacGia
	ON SACH.sMaSach = Sach_TacGia.sMaSach
GO

CREATE PROC proc_getSachChonLoc
AS
	SELECT SACH.sMaSach, SACH.sTenSach, FORMAT(SACH.dNamXB, 'dd/MM/yyyy') AS dNamXB, SACH.iSoLuong, SACH.sMaLoai, SACH.fGiaTien,
       SACH.sMaNxb, Sach_TacGia.sMaTG
	FROM SACH
	INNER JOIN Sach_TacGia ON SACH.sMaSach = Sach_TacGia.sMaSach
	WHERE Sach_TacGia.sMaTG = (SELECT MIN(sMaTG) FROM Sach_TacGia WHERE Sach_TacGia.sMaSach = SACH.sMaSach);
GO








ALTER PROC proc_capNhatSachs
@maSach varchar(10), @tenSach nvarchar(30), @namXB date, @soLuong int,
@maLoai varchar(10), @giaTien float, @maNXB varchar(10)
AS
	UPDATE SACH
	SET  sTenSach = @tenSach, dNamXB = @namXB, iSoLuong = @soLuong,
		sMaLoai = @maLoai, fGiaTien = @giaTien, sMaNxb = @maNXB
	WHERE sMaSach = @maSach
GO

ALTER PROC proc_xoaSach
@maSach varchar(10), @maTG varchaR(10)
AS
	DELETE Sach_TacGia
	WHERE sMaSach = @maSach AND sMaTG = @maTG

	DELETE SACH
	WHERE sMaSach = @maSach

	
GO

ALTER PROC proc_timKiemTheoMaSach
@maSach varchar(10)
AS
	SELECT SACH.sMaSach, SACH.sTenSach, FORMAT(dNamXB, 'dd/MM/yyyy') as dNamXB, SACH.iSoLuong, SACH.sMaLoai, SACH.fGiaTien,
	SACH.sMaNxb, Sach_TacGia.sMaTG
	FROM SACH INNER JOIN Sach_TacGia
	ON SACH.sMaSach = Sach_TacGia.sMaSach
	WHERE SACH.sMaSach LIKE '%' + @maSach +'%'
GO

ALTER PROC proc_timKiemTheoTenSach
@tenSach nvarchar(30)
AS
	SELECT SACH.sMaSach, SACH.sTenSach, FORMAT(dNamXB, 'dd/MM/yyyy') as dNamXB, SACH.iSoLuong, SACH.sMaLoai, SACH.fGiaTien,
	SACH.sMaNxb, Sach_TacGia.sMaTG
	FROM SACH INNER JOIN Sach_TacGia
	ON SACH.sMaSach = Sach_TacGia.sMaSach
	WHERE sTenSach LIKE '%' + @tenSach +'%'
GO

ALTER PROC proc_timKiemTheoMaLoai
@maLoai varchar(10)
AS
	SELECT SACH.sMaSach, SACH.sTenSach, FORMAT(dNamXB, 'dd/MM/yyyy') as dNamXB, SACH.iSoLuong, SACH.sMaLoai, SACH.fGiaTien,
	SACH.sMaNxb, Sach_TacGia.sMaTG
	FROM SACH INNER JOIN Sach_TacGia
	ON SACH.sMaSach = Sach_TacGia.sMaSach
	WHERE sMaLoai LIKE '%' + @maLoai +'%'
GO

select * from THELOAISACH
GO
-------------------------------------------------------DOC GIA
select * from DOCGIA
go

CREATE PROC proc_dsDocGia
AS
	SELECT DOCGIA.sMaDG, DOCGIA.sTenDG, FORMAT(DOCGIA.dNgaySinh, 'dd/MM/yyyy') AS 'dNgaySinh', DOCGIA.sGioiTinh,
	DOCGIA.sDiaChi, DOCGIA.sSdt
	FROM DOCGIA
GO


ALTER PROC proc_themDocGia
@maDG varchar(10), @tenDG nvarchar(50), @ngaySinh datetime, @gioiTinh nvarchar(5), @diaChi nvarchar(50), @sdt varchar(10)
AS
	INSERT INTO DOCGIA
	VALUES
	(
		@maDG, @tenDG, @ngaySinh, @gioiTinh, @diaChi, @sdt
	);
go

CREATE PROC proc_xoaDocGia
@maDG varchar(10)
AS
	DELETE FROM DOCGIA
	WHERE DOCGIA.sMaDG = @maDG

GO

ALTER PROC proc_suaDocGia
@maDG varchar(10), @tenDG nvarchar(50), @ngaySinh datetime, @gioiTinh NVARCHAR(5), @diaChi nvarchar(50), @sdt varchar(10)
AS
	UPDATE DOCGIA
	SET sTenDG = @tenDG, dNgaySinh = @ngaySinh, sGioiTinh = @gioiTinh,
	sDiaChi = @diaChi, sSdt = @sdt
	WHERE sMaDG = @maDG
GO

ALTER PROC proc_timKiemDocGiaTheoTen
@tenDG Nvarchar(30)
AS
	SELECT DOCGIA.sMaDG, DOCGIA.sTenDG, FORMAT(DOCGIA.dNgaySinh, 'dd/MM/yyyy') AS 'dNgaySinh', DOCGIA.sGioiTinh,
	DOCGIA.sDiaChi, DOCGIA.sSdt
	FROM DOCGIA
	WHERE sTenDG LIKE '%' + @tenDG + '%'
go

ALTER PROC proc_timKiemDocGiaTheoMaDG
@maDG varchar(10)
AS
	SELECT DOCGIA.sMaDG, DOCGIA.sTenDG, FORMAT(DOCGIA.dNgaySinh, 'dd/MM/yyyy') AS 'dNgaySinh', DOCGIA.sGioiTinh,
	DOCGIA.sDiaChi, DOCGIA.sSdt
	FROM DOCGIA
	WHERE sMaDG LIKE '%' + @maDG + '%'

--------------------------------------------TÁC GIẢ
go

CREATE PROC proc_dsTacGia
AS
	select * from TACGIA
go

CREATE PROC proc_capNhatTacGia
@maTG varchar(10), @tenTG nvarchar(30), @diaChi nvarchar(50), @sdt nvarchar(10)
AS
	UPDATE TACGIA
	SET sTenTG = @tenTG, sDiaChi = @diaChi, sSdt = @sdt
	WHERE sMaTG = @maTG
GO

CREATE PROC proc_xoaTacGia
@maTG varchar(10)
AS 
	DELETE FROM TACGIA
	WHERE sMaTG = @maTG
go

CREATE PROC proc_themTacGia
@maTG varchar(10), @tenTG nvarchar(30), @diaChi nvarchar(50), @sdt nvarchar(10)
AS
	INSERT INTO TACGIA
	VALUES
	(
		@maTG, @tenTG, @diaChi, @sdt	
	);
GO

CREATE PROC proc_timKiemTGTheoTen
@tenTG nvarchar(30)
AS
	SELECT * FROM TACGIA
	WHERE sTenTG LIKE '%' + @tenTG + '%'
go

CREATE PROC proc_timKiemTGTheoMaTG
@maTG varchar(10)
AS
	SELECT * FROM TACGIA
	WHERE sMaTG LIKE '%' + @maTG + '%'
go

-----------------------------------------------	PHIẾU MƯỢN 
SELECT PM.sMaPhieuMuon, PM.sMaDG, PM.dNgayMuon, PM.sMaNV, CTPM.sMaSach, CTPM.iMaLoaiPhieu, CTPM.dNgayHenTra
FROM PHIEUMUONSACH AS PM RIGHT JOIN CHITIETPHIEUMUON AS CTPM
				ON PM.sMaPhieuMuon = CTPM.sMaPhieuMuon 

GO

	SELECT * FROM PHIEUMUONSACH

CREATE PROC proc_dsPhieuMuon
AS
	SELECT PM.sMaPhieuMuon, PM.sMaDG, FORMAT(PM.dNgayMuon, 'dd/MM/yyyy') as dNgayMuon, PM.sMaNV, CTPM.sMaSach, 
		CTPM.iMaLoaiPhieu, FORMAT(CTPM.dNgayHenTra, 'dd/MM/yyyy') as dNgayHenTra
	FROM PHIEUMUONSACH AS PM RIGHT JOIN CHITIETPHIEUMUON AS CTPM
				ON PM.sMaPhieuMuon = CTPM.sMaPhieuMuon 
GO

create PROC proc_dsPhieuMuonTheoMa
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



ALTER PROC proc_themPhieuMuon
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

CREATE PROC proc_themChiTietPhieuMuon
@maPhieuMuon varchar(10), @maSach varchar(10), @maLoaiPhieu varchar(10)
AS
	INSERT INTO CHITIETPHIEUMUON
	VALUES(
		@maPhieuMuon, @maSach, @maLoaiPhieu, NULL
	);
GO

CREATE PROC proc_xoaPhieuMuon
@maPhieuMuon varchar (10)
AS
	DELETE fROM CHITIETPHIEUMUON
	WHERE sMaPhieuMuon = @maPhieuMuon
GO

ALTER PROC proc_capNhatPhieuMuon
@maPhieuMuon varchar(10), @maSach varchar(10), @maLoaiPhieu varchar(10)
AS
	UPDATE CHITIETPHIEUMUON
	SET sMaPhieuMuon = @maPhieuMuon,sMaSach = @maSach, iMaLoaiPhieu = @maLoaiPhieu
	WHERE sMaPhieuMuon = @maPhieuMuon
GO

CREATE PROC proc_timKiemPhieuMuonTheoMaPM
@maPhieuMuon varchar(10)
AS
	SELECT PM.sMaPhieuMuon, PM.sMaDG, FORMAT(PM.dNgayMuon, 'dd/MM/yyyy') as dNgayMuon, PM.sMaNV, CTPM.sMaSach, 
		CTPM.iMaLoaiPhieu, FORMAT(CTPM.dNgayHenTra, 'dd/MM/yyyy') as dNgayHenTra
	FROM PHIEUMUONSACH AS PM RIGHT JOIN CHITIETPHIEUMUON AS CTPM ON PM.sMaPhieuMuon = CTPM.sMaPhieuMuon
	WHERE PM.sMaPhieuMuon LIKE '%' + @maPhieuMuon + '%'
GO

CREATE PROC proc_timKiemPhieuMuonTheoDG
@maDG varchar(10)
AS
	SELECT PM.sMaPhieuMuon, PM.sMaDG, FORMAT(PM.dNgayMuon, 'dd/MM/yyyy') as dNgayMuon, PM.sMaNV, CTPM.sMaSach, 
		CTPM.iMaLoaiPhieu, FORMAT(CTPM.dNgayHenTra, 'dd/MM/yyyy') as dNgayHenTra
	FROM PHIEUMUONSACH AS PM RIGHT JOIN CHITIETPHIEUMUON AS CTPM ON PM.sMaPhieuMuon = CTPM.sMaPhieuMuon
	WHERE PM.sMaDG LIKE '%' + @maDG + '%'
GO


---------------------------------------------PHIẾU TRẢ SÁCH
SELECT * FROM PHIEUTRASACH
GO

CREATE PROC proc_dsPhieuTraSach
AS
	SELECT PT.sMaPhieuTra, PT.sMaSach, PT.sMaPhieuMuon, PT.sMaNV, FORMAT(PT.dNgayTra, 'dd/MM/yyyy') AS dNgayTra,
	PT.sMaDG, PT.iMaTinhTrangSach, PT.sMaPhieuPhat
	FROM PHIEUTRASACH AS PT
GO

ALTER PROC proc_themPhieuTra
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

CREATE PROC proc_capNhatPhieuTRa
@maPhieuTra varchar(10), @maSach varchar(10), @maPhieuMuon varchar(10), 
@maNV varchar(10), @ngayTra DATE, @maDG varchar(10), @maTinhTrangSach int
AS
	 UPDATE PHIEUTRASACH
	SET sMaSach = @maSach, sMaPhieuMuon = @maPhieuMuon, sMaNV = @maNV, 
	dNgayTra = @ngayTra, sMaDG = @maDG, iMaTinhTrangSach = @maTinhTrangSach
	WHERE sMaPhieuTra = @maPhieuTra
GO

CREATE PROC proc_XoaPhieuTra
@maPhieuTra varchar(10)
AS
	DELETE FROM PHIEUTRASACH
	WHERE sMaPhieuTra = @maPhieuTra
GO




-----------------------------------------------	PHIEU PHAT
SELECT * FROM PHIEUPHAT

--------------------------------------------TRIGGER
-- KÍCH HOẠT KHI MƯỢN SÁCH - 1 SÁCH TRONG KHO SÁCH, KHI TRẢ SÁCH +1 SÁCH TRONG KHO
-- KHI SÁCH ĐANG BẰNG 0 THÌ HIỆN RA THÔNG BÁO HẾT SÁCH
go

drop trigger tg_muonSach

ALTER TRIGGER tg_muonSach
ON [dbo].[CHITIETPHIEUMUON]
FOR INSERT
AS
	DECLARE @maPhieuMuon VARCHAR(10), @slKho int, @maSach varchar(10)

	 -- LẤY MÃ SÁCH TỪ BẢNG TẠM MÀ NGƯỜI DÙNG NHẬP VÀO
	 SELECT inserted.sMaSach FROM inserted INNER JOIN SACH
	 ON inserted.sMaSach = SACH.sMaSach
	
	SELECT @slKho = SACH.iSoLuong, @maPhieuMuon = inserted.sMaPhieuMuon FROM SACH INNER JOIN CHITIETPHIEUMUON
	ON SACH.sMaSach = CHITIETPHIEUMUON.sMaSach INNER JOIN inserted
	ON CHITIETPHIEUMUON.sMaPhieuMuon = inserted.sMaPhieuMuon
	WHERE CHITIETPHIEUMUON.sMaSach = SACH.sMaSach
	
	

	IF(@slKho = 0)
		BEGIN 
				
			PRINT N'SÁCH NÀY ĐÃ HẾT, BẠN KHÔNG THỂ MƯỢN'
			INSERT INTO ErrorLog (ErrorMessage) VALUES (N'Sách đã hết');
			ROLLBACK TRAN
			DELETE FROM PHIEUMUONSACH
			WHERE PHIEUMUONSACH.sMaPhieuMuon = @maPhieuMuon
		END
	ELSE
		BEGIN
			Update SACH
			SET SACH.iSoLuong = SACH.iSoLuong - 1
			FROM SACH INNER JOIN inserted ON SACH.sMaSach = inserted.sMaSach
			WHERE SACH.sMaSach = @maSach
		END
go
-------------------------------------------------------------------------------


ALTER TRIGGER tg_muonSach
ON [dbo].[CHITIETPHIEUMUON]
FOR INSERT
AS
BEGIN
    DECLARE @maPhieuMuon VARCHAR(10), @slKho int, @maSach varchar(10)

    -- LẤY MÃ SÁCH TỪ BẢNG TẠM MÀ NGƯỜI DÙNG NHẬP VÀO
    SELECT @maSach = inserted.sMaSach FROM inserted

    -- LẤY SỐ LƯỢNG TỒN KHO CỦA SÁCH
    SELECT @slKho = SACH.iSoLuong FROM SACH WHERE SACH.sMaSach = @maSach
    
    -- LẤY MÃ PHIẾU MƯỢN
    SELECT @maPhieuMuon = inserted.sMaPhieuMuon FROM inserted

    IF @slKho = 0
    BEGIN 
        PRINT N'SÁCH NÀY ĐÃ HẾT, BẠN KHÔNG THỂ MƯỢN'
        ROLLBACK TRAN
        DELETE FROM PHIEUMUONSACH
        WHERE PHIEUMUONSACH.sMaPhieuMuon = @maPhieuMuon
    END
    ELSE
    BEGIN
        -- GIẢM SỐ LƯỢNG SÁCH TRONG KHO
        UPDATE SACH
        SET SACH.iSoLuong = SACH.iSoLuong - 1
        WHERE SACH.sMaSach = @maSach
    END
END


INSERT INTO PHIEUMUONSACH 
VALUES
	(
		'M11', 'DG01', '2024-03-20', 'NV01'
	);

INSERT INTO CHITIETPHIEUMUON
VALUES
	(
		'M11', 'MS02', 1, '2024-03-27'
		
	);

go


CREATE TRIGGER tg_xoaPhieuMuonSach
ON [dbo].[CHITIETPHIEUMUON]
FOR DELETE
AS
BEGIN

	DECLARE @maSach varchar(10), @maPhieuMuon varchar(10)

	SELECT @maSach = deleted.sMaSach FROM deleted

	SELECT @maPhieuMuon = deleted.sMaPhieuMuon FROM deleted
	BEGIN
		UPDATE SACH
		SET SACH.iSoLuong = SACH.iSoLuong + 1
		WHERE SACH.sMaSach = @maSach

		DELETE FROM PHIEUMUONSACH
		WHERE PHIEUMUONSACH.sMaPhieuMuon = @maPhieuMuon
	END

END

go

CREATE TRIGGER tg_capNhatPhieuMuonSach
ON [dbo].[CHITIETPHIEUMUON]
FOR UPDATE
AS
	DECLARE @maSach varchar(10), @maPhieuMuon varchar(10), @maSachSau varchar(10)
	
	SELECT @maSach = deleted.sMaSach FROM deleted
	SELECT @maSachSau = inserted.sMaSach FROM inserted
	SELECT @maPhieuMuon = deleted.sMaPhieuMuon FROM deleted
	
	UPDATE SACH 
	SET SACH.iSoLuong = SACH.iSoLuong + 1
	WHERE SACH.sMaSach = @maSach

	UPDATE SACH 
	SET SACH.iSoLuong = SACH.iSoLuong - 1
	WHERE SACH.sMaSach = @maSachSau

GO

ALTER TRIGGER tg_autoNgayHenTRa
ON [dbo].[CHITIETPHIEUMUON]
FOR INSERT, UPDATE
AS
BEGIN
    DECLARE @maPhieuMuon VARCHAR(10), @loaiPhieu INT, @ngayMuon DATE

    SELECT @loaiPhieu = inserted.iMaLoaiPhieu,
           @maPhieuMuon = inserted.sMaPhieuMuon,
           @ngayMuon = PHIEUMUONSACH.dNgayMuon
    FROM inserted
    INNER JOIN PHIEUMUONSACH ON inserted.sMaPhieuMuon = PHIEUMUONSACH.sMaPhieuMuon

    IF @loaiPhieu = 1
    BEGIN
        UPDATE CHITIETPHIEUMUON 
        SET dNgayHenTra = DATEADD(DAY, 7, @ngayMuon) -- Thêm 7 ngày vào ngày mượn
        WHERE sMaPhieuMuon = @maPhieuMuon
    END

	IF @loaiPhieu = 2
    BEGIN
        UPDATE CHITIETPHIEUMUON 
        SET dNgayHenTra = DATEADD(DAY, 30, @ngayMuon) -- Thêm 30 ngày vào ngày mượn
        WHERE sMaPhieuMuon = @maPhieuMuon
    END
END

