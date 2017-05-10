use MovieDB
go

create Proc ThemNhanVien(@MaNV nvarchar(10), @TenNV nvarchar(50),@NgaySinh nvarchar(10),@GioiTinh nvarchar(10),
						@SoCMND int, @DiaChi nvarchar(50),@SDT int ,@Email nvarchar(50),@ChucVu nvarchar(30),@NgayVaoLam nvarchar(10))
as
begin
	INSERT INTO NhanVien (MaNV,TenNV,NgaySinh,GioiTinh,SoCMND,DiaChi,SDT,Email,ChucVu,NgayVaoLam)
	Values (@MaNV,@TenNV,@NgaySinh,@GioiTinh,@SoCMND,@DiaChi,@SDT,@Email,@ChucVu,@NgayVaoLam)
end
go

use MovieDB
go