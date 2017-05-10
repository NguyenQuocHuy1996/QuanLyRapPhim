use MovieDB
go

Alter PROC ThemKhachHang(@TaiKhoan nvarchar(50), @MatKhau nvarchar(50), @HoTen nvarchar(50), @GioiTinh nvarchar(5), @NgaySinh nvarchar(10),@CMND int, @DiaChi nvarchar(255), @Email nvarchar(100), @SDT int)
as
begin
	insert into KhachHang(TaiKhoan,MatKhau,HoTen,GioiTinh,NgaySinh,CMND,DiaChi,Email,SDT)
	values (@TaiKhoan,@MatKhau,@HoTen,@GioiTinh,@NgaySinh,@CMND,@DiaChi,@Email,@SDT)
end
go