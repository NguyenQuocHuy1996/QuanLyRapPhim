use MovieDB
go

Alter proc ThemRapPhim (@MaRP nvarchar(10), @TenRP nvarchar(50), @DiaChi nvarchar(50), @MaNV nvarchar(10), @TenNV nvarchar(50))
as
begin
	insert into RapPhim(MaRapPhim,TenRapPhim,DiaChi,MaNV,TenNV)
	values (@MaRP, @TenRP,@DiaChi,@MaNV,@TenNV)
end
go

exec ThemRapPhim N'RP04', N'Galaxy Nguyễn Hồng Đào', N'457/234/1 Nguyễn Hồng Đào, Bàu Cát, Tân Bình', 'NV02', N'Nguyễn Thị Mỹ Linh'