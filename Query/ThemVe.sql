use MovieDB
go

create proc ThemVe (@TenPhim nvarchar(50), @NgayChieu nvarchar(10), @GioChieu nvarchar(10), @SoGhe nvarchar(5), @LoaiGhe nvarchar(10), @DoiTuong nvarchar(10), @GiaVe int)
as
begin

	insert into Ve(TenPhim,NgayChieu,GioChieu,SoGhe,LoaiGhe,DoiTuong,GiaVe)
	values (@TenPhim,@NgayChieu,@GioChieu,@SoGhe,@LoaiGhe,@DoiTuong,@GiaVe)
end
go
