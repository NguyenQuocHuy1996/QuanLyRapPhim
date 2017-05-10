use MovieDB
go

alter PROC ThemLichChieu (@MaRP nvarchar(10),@TenRP nvarchar(50),@MaPC nvarchar(20),@TenPC nvarchar(50),@MaPhim nvarchar(10)
							,@TenPhim nvarchar(50),@NgayChieu nvarchar(10),@GioChieu nvarchar(10),@DinhDang nvarchar(20))
as
begin
	insert into LichChieu
	values (@MaRP,@TenRP,@MaPC,@TenPC,@MaPhim,@TenPhim,@NgayChieu,@GioChieu,@DinhDang)
end
go