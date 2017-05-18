use MovieDB
go

alter proc ThemTheLoai (@TheLoai nvarchar(100))
as
begin
	insert into TheLoai(TheLoai)
	values (@TheLoai)
end
go

exec ThemTheLoai N'Huy'
go

drop proc ThemTheLoai
go