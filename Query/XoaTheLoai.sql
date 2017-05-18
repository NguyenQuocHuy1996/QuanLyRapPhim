use MovieDB
go

Create proc XoaTheLoai (@TheLoai nvarchar(100))
as
begin
	Delete TheLoai
	Where TheLoai=@TheLoai
end
go

EXEC XoaTheLoai N'Huy'
go

drop proc XoaTheLoai
go