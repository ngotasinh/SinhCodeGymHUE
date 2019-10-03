CREATE PROC sp_chitietchungtu
AS	
BEGIN
	SELECT kh.hotenKH,kh.diachi,ctct.sochungtu,ctct.mahang,ctct.tenhang,ctct.soluong,ctct.giaban,ct.ngaylapchungtu
	FROM dbo.CHUNGTU ct JOIN dbo.CHITIETCHUNGTU ctct 
	ON	ctct.sochungtu = ct.sochungtu JOIN dbo.KHACHHANG kh
	ON	kh.makhachhang = ct.makhachang
	GROUP BY kh.hotenKH,kh.diachi,ctct.sochungtu,ctct.mahang,ctct.tenhang,ctct.soluong,ctct.giaban,ct.ngaylapchungtu
END	

GO	
EXEC sp_chitietchungtu