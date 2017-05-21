use MovieDB
go

alter proc ThemThucAnTam(@TenTA nvarchar(50),@Gia int)
as
begin
	if(exists(select TenThucAn from ThucAn_Tam where TenThucAn = @TenTA))
		begin
			update ThucAn_Tam
			set SoLuong = (SELECT SoLuong FROM ThucAn_Tam WHERE TenThucAn = @TenTA) + 1, TongTien=(SELECT TongTien FROM ThucAn_Tam WHERE TenThucAn = @TenTA) + @Gia
			where TenThucAn = @TenTA
		end
	else
		begin
			insert into ThucAn_Tam(TenThucAn,SoLuong,DonGia,TongTien)
			Values (@TenTA,1,@Gia,@Gia)
		end
end
go