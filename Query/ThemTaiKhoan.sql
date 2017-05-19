use MovieDB
go

Create PROC ThemTaiKhoan(@TaiKhoan nvarchar(50), @MatKhau nvarchar(50), @MaNV nvarchar(10) , @TenNV nvarchar(50),@NgaySinh nvarchar(10),@ChucVu nvarchar(30))
as
begin
	insert into TaiKhoan
	values (@TaiKhoan,@MatKhau,@MaNV,@TenNV,@NgaySinh,@ChucVu)
end
go

drop proc ThemTaiKhoan
go