USE	BTQLBANHANG

ALTER PROC SP_SAVEKH
(
	@MAKH VARCHAR(10),
	@TENCONGTY NVARCHAR(70),
	@TENGIAODICH NVARCHAR(100),
	@DIACHI NVARCHAR(100),
	@EMAIL VARCHAR(100),
	@DT VARCHAR(15),
	@FAX VARCHAR(20)
)
AS 
BEGIN	
	IF(EXISTS (SELECT * FROM dbo.KHACHHANG WHERE MAKHACHHANG = @MAKH))   
	BEGIN
		UPDATE dbo.KHACHHANG 
		SET 
			TENGIAODICH = @TENGIAODICH,
			DIACHI =@DIACHI,
			EMAIL = @EMAIL,
			DIENTHOAI = @DT,
			FAX = @FAX
		WHERE MAKHACHHANG = @MAKH
	END
	ELSE 
	BEGIN		
		INSERT INTO dbo.KHACHHANG
		        ( MAKHACHHANG ,
		          TENKHACHHANG ,
		          TENGIAODICH ,
		          DIACHI ,
		          EMAIL ,
		          DIENTHOAI ,
		          FAX
		        )
		VALUES  ( ''+@MAKH+'' , -- MAKHACHHANG - varchar(10)
		          N''+@TENCONGTY+'' , -- TENKHACHHANG - nvarchar(50)
		          N''+@TENGIAODICH+'' , -- TENGIAODICH - nvarchar(100)
		          N''+@DIACHI+'' , -- DIACHI - nvarchar(100)
		          ''+@EMAIL+'' , -- EMAIL - varchar(50)
		          ''+@DT+'' , -- DIENTHOAI - varchar(15)
		          ''+@FAX+''  -- FAX - varchar(15)
		        )
	END
END

EXEC [dbo].[SP_SAVEKH] 'MKH99', N'TRƯỜNG HÀ', N'NHẬP BIA', N'HUẾ', 'TRUONGHA@', '62348762','6243622573'