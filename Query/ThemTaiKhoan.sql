use MovieDB
go

Create PROC ThemTaiKhoan(@TaiKhoan nvarchar(50), @MatKhau nvarchar(50), @LoaiTaiKhoan nvarchar(20))
as
begin
	insert into TaiKhoan(TaiKhoan,MatKhau,LoaiTaiKhoan)
	values (@TaiKhoan,@MatKhau,@LoaiTaiKhoan)
end
go