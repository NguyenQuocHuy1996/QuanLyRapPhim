use MovieDB
go

create proc ThemHoaDon(@TenTA nvarchar(50), @Gia int, @Ngay nvarchar(10), @Gio nvarchar(5))
as
begin
	Insert Into HoaDon
	values(@TenTA,@Gia,@Ngay,@Gio)
end
go