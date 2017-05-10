use MovieDB
go

create PROC ThemThucAn(@MaThucAn nvarchar(10), @TenThucAn nvarchar(20), @DonVi nvarchar (10), @DonGia int, @Combo int)
as
begin
	insert into ThucAn(MaThucAn, TenThucAn, DonVi, DonGia, Combo)
	values (@MaThucAn,@TenThucAn,@DonVi,@DonGia,@Combo)	
end
go

ThemThucAn 'TA01',N'Bắp rang',N'Hộp','50000','1'