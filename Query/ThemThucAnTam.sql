use MovieDB
go

alter proc ThemThucAnTam(@ID int, @TenTA nvarchar(50), @Gia int)
as
begin
	Insert into ThucAN_Tam
	Values (@ID,@TenTA,@Gia)
end
go