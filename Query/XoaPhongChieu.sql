use MovieDB
go

alter Proc XoaPhongChieu(@MaPC nvarchar(20))
as
begin
	DELETE PhongChieu
	WHERE MaPhongChieu= @MaPC
end
go