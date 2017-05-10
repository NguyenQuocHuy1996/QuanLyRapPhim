use MovieDB
go

create Proc SuaNhanVien(@MaNV nvarchar(10), @TenNV nvarchar(50),@NgaySinh nvarchar(10),@GioiTinh nvarchar(10),
						@SoCMND int, @DiaChi nvarchar(50),@SDT int ,@Email nvarchar(50),@ChucVu nvarchar(30),@NgayVaoLam nvarchar(10))
as
begin
	UPDATE NhanVien
	SET TenNV=@TenNV,NgaySinh=@NgaySinh,GioiTinh=@GioiTinh,SoCMND=@SoCMND,DiaChi=@DiaChi
				,SDT=@SDT,Email=@Email,ChucVu=@ChucVu,NgayVaoLam=@NgayVaoLam
	WHERE MaNV=@MaNV
end
go