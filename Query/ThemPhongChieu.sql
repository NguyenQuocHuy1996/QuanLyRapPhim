use MovieDB
go

create Proc ThemPhongChieu(@MaPC nvarchar(20),@TenPC nvarchar(50),@DinhDang nvarchar(20),@MaRP nvarchar(10),@TenRP nvarchar(50))
as
begin
	INSERT INTO PhongChieu
	VALUES (@MaPC,@TenPC,@DinhDang,@MaRP,@TenRP)
end
go
