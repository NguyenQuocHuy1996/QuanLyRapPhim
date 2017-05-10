use MovieDB
go

alter PROC XoaLichChieu (@MaRP nvarchar(10),@MaPC nvarchar(20),@MaPhim nvarchar(10),@NgayChieu nvarchar(10),@GioChieu nvarchar(10))
as
begin
	Delete from LichChieu
	where MaRapPhim =@MaRP and MaPhongChieu = @MaPC and MaPhim = @MaPhim and NgayChieu=@NgayChieu and GioChieu=@GioChieu
end
go