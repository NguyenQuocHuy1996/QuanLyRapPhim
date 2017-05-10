use MovieDB
go

create proc SuaRapPhim (@MaRP nvarchar(10), @TenRP nvarchar(50), @DiaChi nvarchar(50), @MaNV nvarchar(10), @TenNV nvarchar(50))
as
begin
	Update RapPhim
	Set TenRapPhim=@TenRP, DiaChi=@DiaChi, MaNV=@MaNV, TenNV=@TenNV
	Where MaRapPhim=@MaRP
end
go