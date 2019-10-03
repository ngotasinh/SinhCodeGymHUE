--CẬP NHẬT HOẶC THÊM MỚI Mặt HÀNG:
CREATE PROC sp_nhapmathang
(
    @mahang NCHAR(10),
    @tenhang NVARCHAR(50),
	@loaihang NVARCHAR(50),
	@quycach NVARCHAR(100),
	@giabanht FLOAT,
	@soluonght INT
)
as 
BEGIN
	IF(exists( select * from dbo.MATHANG where mahang = @mahang))
    BEGIN
    update dbo.MATHANG
    set
        tenhang = @tenhang,
		loaihang =@loaihang,
		quycach = @quycach,
		giabanHT =@giabanht,
		soluongHT = @soluonght

    WHERE mahang = @mahang
    END
	ELSE
    BEGIN
    INSERT	dbo.MATHANG
            ( mahang ,
              tenhang ,
              loaihang ,
              quycach ,
              giabanHT ,
              soluongHT
            )
    VALUES  ( N''+@mahang+'' ,
              N''+@tenhang+'' , 
              N''+@loaihang+'' , 
              N''+@quycach+'' , 
               @giabanht, 
               @soluonght
            )
    END
END
GO	
EXEC [dbo].[sp_nhapmathang] N'MH1',N'QUẦN TÂY',N'QUẦN',N' QUẦN DÀI MÀU ĐEN',50000,100

--CẬP NHẬT HOẶC THÊM MỚI KHÁCH HÀNG:
CREATE PROC SP_NHAPKHACHHANG
(
    @MaKhachHang nchar(10),
    @HoTen Nvarchar(50),
    @DiaChi nvarchar(100)
)
as 
BEGIN
	IF(exists( select * from dbo.KHACHHANG where makhachhang = @MaKhachHang))
    BEGIN
    update dbo.KHACHHANG
    set
        hotenKH = @HoTen,
        diachi = @DiaChi
    WHERE dbo.KHACHHANG.MAKHACHHANG = @MaKhachHang
    END
	ELSE
    BEGIN
    INSERT	dbo.KHACHHANG
            ( makhachhang, hotenKH, diachi )
    VALUES  ( N''+@MaKhachHang+'',
              N''+@HoTen+'', 
              N''+@DiaChi+''  
              )
    END
END
GO	

EXEC [dbo].[SP_NHAPKHACHHANG] N'KH104',N'NGÔ TÁ SINH', N'HUẾ'

GO	

--CẬP NHẬT HOẶC THÊM MỚI CHỨNG TỪ:
CREATE PROC sp_nhapchungtu
(
    @sochungtu INT,
	@makhachhang nchar(10),
	@ngaylapchungtu date
)
as 
BEGIN
	IF(exists( select * from dbo.CHUNGTU where sochungtu = @sochungtu))
    BEGIN
    update dbo.CHUNGTU
    set
		makhachang =@makhachhang,
		ngaylapchungtu = @ngaylapchungtu
    WHERE sochungtu = @sochungtu
    END
	ELSE
    BEGIN
    INSERT	dbo.CHUNGTU
            ( sochungtu ,
              makhachang ,
              ngaylapchungtu
            )
    VALUES  ( @sochungtu , 
              N''+@makhachhang+'' ,
              '@ngaylapchungtu'
            )
    END
END
GO	
EXEC [dbo].[sp_nhapchungtu]3, N'KH103', '20190914'

GO	

--CẬP NHẬT HOẶC THÊM MỚI CHI TIẾT CHỨNG TỪ:
CREATE PROC sp_nhapchitietchungtu
(
    @sochungtu INT,
    @mahang nchar(10),
    @tenhang NVARCHAR(50),
	@giaban FLOAT,
	@soluong INT
)
as 
BEGIN
	IF(exists( select * from dbo.CHITIETCHUNGTU where sochungtu = @sochungtu))
    BEGIN
    update dbo.CHITIETCHUNGTU
    set
        mahang = @mahang,
        tenhang = @tenhang,
		giaban= @giaban,
		soluong=@soluong
    WHERE sochungtu = @sochungtu
    END
	ELSE
    BEGIN
    INSERT	dbo.CHITIETCHUNGTU
            ( sochungtu ,
              mahang ,
              tenhang ,
              giaban ,
              soluong
            )
    VALUES  ( @sochungtu , 
              N''+@mahang+'' , 
              N''+@tenhang+'' , 
              @giaban ,
              @soluong  
            )
    END
END
GO	
EXEC [dbo].[sp_nhapchitietchungtu] 1, N'MH3', N'VÁY NGẮN',100000,2

GO	


--CẬP NHẬT HOẶC THÊM MỚI PHIẾU THU:
CREATE PROC sp_nhaphieuthu
(
	@sophieu INT,
    @sochungtu INT,
	@ngaythutien DATE,
	@sotienthu FLOAT
)
as 
BEGIN
	IF(exists( select * from dbo.PHIEUTHU where sophieu = @sophieu))
    BEGIN
    update dbo.PHIEUTHU
    set
		sochungtu = @sochungtu,
		ngaythutien = @ngaythutien,
		sotienthu= @sotienthu
    WHERE sophieu = @sophieu
    END
	ELSE
    BEGIN
    INSERT	dbo.PHIEUTHU
            ( sophieu ,
              sochungtu ,
              ngaythutien ,
              sotienthu
            )
    VALUES  ( @sophieu , 
              @sochungtu , 
              '@ngaythutien' ,
              @sotienthu
            )
    END
END
GO	
EXEC [dbo].[sp_nhapchungtu]3, N'KH103', '20190914'

GO	