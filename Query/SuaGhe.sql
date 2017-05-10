use MovieDB
go

create Proc SuaGhe (@MaPhim nvarchar(10), @1 bit, @2 bit, @3 bit, @4 bit, @5 bit)
as
begin
	update RapPhim
	set G1=@1, G2=@2, G3=@3, G4=@4, G5=@5
	where MaPhim=@MaPhim
end
go

exec SuaGhe 'Phim01','False','True','False','False','True'

drop proc ThemVe
go