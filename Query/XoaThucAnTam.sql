use MovieDB
go

Alter proc XoaThucAnTam(@ID int)
as
begin
	Delete ThucAn_Tam
	Where ID = @ID
end
go