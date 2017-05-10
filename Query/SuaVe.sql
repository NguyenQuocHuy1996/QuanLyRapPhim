use MovieDB
go

create proc ThemVe (@TenPhim nvarchar(50), @NgayChieu nvarchar(10), @GioChieu nvarchar(10), @SoGhe nvarchar(5))
as
begin
	insert into Ve(TenPhim,NgayChieu,GioChieu,SoGhe)
	values (@TenPhim,@NgayChieu,@GioChieu,@SoGhe)
end
go
