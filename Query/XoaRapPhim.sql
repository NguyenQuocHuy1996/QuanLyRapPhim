use MovieDB
go

create proc XoaRapPhim (@MaRP nvarchar(10))
as
begin
	Delete RapPhim
	where MaRapPhim = @MaRP
end
go