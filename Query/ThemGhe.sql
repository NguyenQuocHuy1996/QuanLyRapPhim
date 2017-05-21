use MovieDB
go

create Proc ThemGhe (@MaRP nvarchar(10), @TenRP nvarchar(50), @MaPhim nvarchar(10), @TenPhim nvarchar (50), @NgayChieu nvarchar(10), @GioChieu nvarchar(10), @SoGhe int)
as
begin
	INSERT INTO Ghe
	Values (@MaRP,@TenRP,@MaPhim,@TenPhim,@NgayChieu,@GioChieu,@SoGhe)
end
go