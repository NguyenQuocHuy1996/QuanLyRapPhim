use MovieDB
go

create proc XoaTaiKhoan (@TaiKhoan nvarchar(50))
as
begin
	DELETE TaiKhoan
	Where TaiKhoan = @TaiKhoan
end
go