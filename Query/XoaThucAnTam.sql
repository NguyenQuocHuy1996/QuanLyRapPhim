use MovieDB
go

Alter proc XoaThucAnTam(@TenTA nvarchar(50))
as
begin
	Delete ThucAn_Tam
	Where TenThucAn = @TenTA
end
go