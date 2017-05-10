use MovieDB
go

create Proc XoaNhanVien(@MaNV nvarchar(10))
as
begin
	DELETE NhanVien
	WHERE MaNV=@MaNV
end
go