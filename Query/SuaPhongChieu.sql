use MovieDB
go

create Proc SuaPhongChieu(@MaPC nvarchar(20),@TenPC nvarchar(50),@DinhDang nvarchar(20),@MaRP nvarchar(10),@TenRP nvarchar(50))
as
begin
	UPDATE PhongChieu
	SET TenPhongChieu=@TenPC, DinhDang=@DinhDang,MaRapPhim=@MaRP,TenRapPhim= @TenRP
	WHERE MaPhongChieu=@MaPC
end
go

Drop proc SuaPhongChieu
go