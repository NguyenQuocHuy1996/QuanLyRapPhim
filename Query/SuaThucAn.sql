use MovieDB
go

create PROC SuaThucAn(@MaThucAn nvarchar(10), @TenThucAn nvarchar(20), @DonVi nvarchar (10), @DonGia int, @Combo int)
as
begin
	Update ThucAn
	Set TenThucAn = @TenThucAn, DonVi=@DonVi, DonGia=@DonGia, Combo=@Combo
	Where MaThucAn=@MaThucAn
end
go

