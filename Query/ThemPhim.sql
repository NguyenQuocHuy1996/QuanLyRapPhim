use MovieDB
go

alter proc ThemPhim (@MaPhim nvarchar(10), @TenPhim nvarchar(50),@DaoDien nvarchar(30), @QuocGia nvarchar(10)
						, @Nam int, @ThoiLuong int, @TheLoai nvarchar(30), @HinhAnh image, @Trailer nvarchar(250))
as
begin
	insert into Phim(MaPhim, TenPhim, DaoDien, QuocGia, Nam, ThoiLuong, TheLoai, HinhAnh, Trailer)
	values (@MaPhim, @TenPhim, @DaoDien, @QuocGia, @Nam, @ThoiLuong, @TheLoai, @HinhAnh, @Trailer)
end
go

exec ThemPhim 'Phim06', N'ĐẤU TRƯỜNG ÂM NHẠC', N'Garth Jennings', N'Mỹ', '2016', '108', N'Hoạt Hình'