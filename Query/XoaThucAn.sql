use MovieDB
go

create PROC XoaThucAn(@MaThucAn nvarchar(10))
as
begin
	Delete ThucAn
	Where MaThucAn=@MaThucAn
end
go

XoaThucAn 'TA01'