use MovieDB
go

alter PROC SuaLichChieu (@MaRP nvarchar(10),@TenRP nvarchar(50),@MaPC nvarchar(20),@TenPC nvarchar(50),@MaPhim nvarchar(10)
							,@TenPhim nvarchar(50),@NgayChieu nvarchar(10),@GioChieu nvarchar(10),@DinhDang nvarchar(20))
as
begin
	UPDATE LichChieu
	SET TenRapPhim=@TenRP, MaPhongChieu=@MaPC,TenPhongChieu=@TenPC,MaPhim=@MaPhim,TenPhim=@TenPhim,NgayChieu=@NgayChieu,GioChieu=@GioChieu,DinhDang=@DinhDang
	WHERE MaRapPhim = @MaRP
end
go