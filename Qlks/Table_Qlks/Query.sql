use Qlks
go

IF (OBJECT_ID(N'dangnhap', 'p') IS NOT NULL)
DROP PROC dangnhap
GO

CREATE PROC [dbo].[dangnhap]
@taikhoan nvarchar(50),
@matkhau nvarchar(50)
as
BEGIN
if (exists(select TaiKhoan, MatKhau
		from NhanVien
		where TaiKhoan = @taikhoan and MatKhau = @matkhau ))
		select errcode =0
else
	select errcode = 1
END


 ----------------------------------------------------------------------------------------
go
IF (OBJECT_ID(N'phongtrong', 'p') IS NOT NULL)
DROP PROC phongtrong
GO

CREATE PROC [dbo].[phongtrong]

	@maphong int
as
BEGIN
		if @maphong = 0
			select MaPhong, TinhTrang, TenKh, NamSinh, SoCm, SoNguoiDp, NgayDp, NgayTp from [dbo].[phong]
		else
		 begin
			select MaPhong, TinhTrang, TenKh, NamSinh, SoCm, SoNguoiDp, NgayDp, NgayTp
			from [dbo].[phong]
			where MaPhong = @maphong 
		 end

END



 ----------------------------------------------------------------------------------------
go

IF (OBJECT_ID(N'suathongtinphong', 'p') IS NOT NULL)
DROP PROC suathongtinphong
GO

CREATE PROC [dbo].[suathongtinphong]

@maphong int,
@tinhtrang nvarchar(5),
@tenkh nvarchar(100),
@namsinh int,
@socm int,
@songuoidp int,
@ngaydp date,
@ngaytp date
as
	begin
		update phong
		set TinhTrang = @tinhtrang, TenKh = @tenkh, NamSinh = @namsinh, SoCm = @socm, SoNguoiDp = @songuoidp, NgayDp = @ngaydp, NgayTp = @ngaytp
		where MaPhong = @maphong
		select errcode = 1
	end 
go
 ----------------------------------------------------------------------------------------

IF (OBJECT_ID(N'xoaphong', 'p') IS NOT NULL)
DROP PROC xoaphong
GO

CREATE PROC [dbo].[xoaphong]

@maphong int
as
	begin
		update phong
		set TinhTrang = N'Trống', TenKh = null, NamSinh = null, SoCm = null, SoNguoiDp = null, NgayDp = null, NgayTp = null
		where MaPhong = @maphong
		select errcode = 1
	end

 ----------------------------------------------------------------------------------------
go
IF (OBJECT_ID(N'hiencpp', 'p') IS NOT NULL)
DROP PROC hiencpp
GO

CREATE PROC [dbo].[hiencpp]

@maphong int
as
		if @maphong = 0
			select * from [dbo].[ChiPhiPhu]
		else
			begin
				select TienDc, DichVu, Gia,TienDc - Gia as TongTien
				from [dbo].[ChiPhiPhu]
				where MaPhong =@maphong
				select errcode = 0
			end

 ----------------------------------------------------------------------------------------
go
IF (OBJECT_ID(N'CapNhatCp', 'p') IS NOT NULL)
DROP PROC CapNhatCp
GO

CREATE PROC [dbo].[CapNhatCp]

@maphong int,
@tiendatcoc int,
@dicvu Nvarchar(100),
@gia int
as
 begin
	update [dbo].[ChiPhiPhu]
	set TienDc = @tiendatcoc, DichVu = @dicvu, Gia = @gia
	where MaPhong = @maphong
	select errcode = 0, errmsg = N'Cập nhật thành công'
 end

  ----------------------------------------------------------------------------------------
 go
IF (OBJECT_ID(N'hientongtien', 'p') IS NOT NULL)
DROP PROC hientongtien
GO

CREATE PROC [dbo].[hientongtien]

 @maphong int
 as
 select Tien
 from [dbo].[TongTien]
 where MaPhong = @maphong

 ----------------------------------------------------------------------------------------
go
IF (OBJECT_ID(N'capnhattongtien', 'p') IS NOT NULL)
DROP PROC capnhattongtien
GO

CREATE PROC [dbo].[capnhattongtien]

@maphong int,
@tien int
as
update [dbo].[TongTien]
set Tien = @tien
where MaPhong = @maphong
select errcode = 0

 ----------------------------------------------------------------------------------------
go
IF (OBJECT_ID(N'timnv', 'p') IS NOT NULL)
DROP PROC timnv
GO

CREATE PROC [dbo].[timnv]

@hoten Nvarchar(100)
as
 		begin
			select Manv, HoTen, Phai, DiaChi, NgaySinh, SoDt, TaiKhoan, MatKhau 
			from NhanVien where HoTen = @hoten
		end


 ----------------------------------------------------------------------------------------
go
IF (OBJECT_ID(N'themnv', 'p') IS NOT NULL)
	DROP PROC themnv
GO

CREATE PROC [dbo].[themnv]
@hoten Nvarchar(100),
@phai Nvarchar(10),
@diachi Nvarchar(100),
@ngaysinh Nvarchar(100),
@sodt int,
@taikhoan Nvarchar(50),
@matkhau Nvarchar(50)
as
if(exists(select TaiKhoan from [dbo].[NhanVien] where TaiKhoan = @taikhoan))
	begin
		select errcode = 1, errmsg = N'Tài Khoản Đã Tồn Tại'
	end
else
	begin
		Insert [dbo].[NhanVien](HoTen, Phai, DiaChi, NgaySinh, SoDt, TaiKhoan, MatKhau)
		Values(@hoten, @phai, @diachi, @ngaysinh, @sodt, @taikhoan, @matkhau)
		select errcode=0, errmsg = N'Thêm Thành Công'
	end

 ----------------------------------------------------------------------------------------
go
IF (OBJECT_ID(N'suanv', 'p') IS NOT NULL)
DROP PROC suanv
GO

CREATE PROC [dbo].[suanv]
@hoten Nvarchar(100),
@phai Nvarchar(10),
@diachi Nvarchar(100),
@ngaysinh Nvarchar(100),
@sodt int,
@taikhoan Nvarchar(50),
@matkhau Nvarchar(50)
as
if(exists(select NhanVien.TaiKhoan from NhanVien where TaiKhoan = @taikhoan))
begin
	select errcode = 0
	UPDATE [dbo].[NhanVien]
	set HoTen = @hoten, Phai = @phai, DiaChi = @diachi, NgaySinh = @ngaysinh, SoDt = @sodt, MatKhau = @matkhau
	where TaiKhoan = @taikhoan
	
end
else
	select errcode = 1

 ----------------------------------------------------------------------------------------
go
IF (OBJECT_ID(N'xoanhanvien', 'p') IS NOT NULL)
DROP PROC xoanhanvien
GO
Create Proc [dbo].[xoanhanvien]
@manv int
as
	Delete NhanVien
	where MaNv = @manv


---------------------------------------------------------------------------------------------------
go
IF (OBJECT_ID(N'hiennhanvien', 'p') IS NOT NULL)
DROP PROC hiennhanvien
GO
Create Proc  [dbo].[hiennhanvien]
@manv int
as
if(@manv = 0)
begin
	select MaNv, HoTen
	from NhanVien
end
else
begin
	select MaNv, HoTen, Phai, DiaChi, NgaySinh, SoDt, TaiKhoan, MatKhau
	from NhanVien
	where MaNv = @manv
end
------------------------------------------------------------------------------------------
go

IF (OBJECT_ID(N'luuttphong', 'p') IS NOT NULL)
DROP PROC luuttphong
GO


Create Proc [dbo].[luuttphong]

@maphong int, 
@ten Nvarchar(100),
@namsinh int,
@socm int,
@ngaydp Nvarchar(100),
@ngaytp Nvarchar(100),
@tienphong int,
@chiphiphu int,
@tongtien int,
@nv Nvarchar (100)
as
	Insert Into [dbo].[luuthongtinphong](MaPhong, TenKh, NamSinh, SoCm, NgayDp, NgayTp, TienPhong, ChiPhiPhu, TongTien, NvLap)
	Values( @maphong, @ten, @namsinh, @socm, @ngaydp, @ngaytp, @tienphong, @chiphiphu, @tongtien, @nv)
	

---------------------------------------------------------------------------------------------------------
go
IF (OBJECT_ID(N'cb', 'p') IS NOT NULL)
DROP PROC cb
GO
Create Proc [dbo].[cb]

@so int
as
if @so = 0
	begin
		select Manv,Hoten from NhanVien
	end



-----------------------------------------------------------------------------------------------
go
IF (OBJECT_ID(N'hienloaiphong', 'p') IS NOT NULL)
DROP PROC hienloaiphong
GO


Create Proc [dbo].[hienloaiphong]

@maphong int
as
if(@maphong = 0)
	begin
		select distinct LoaiPhong from GiaPhong
	end
else
	select GiaPhong, LoaiPhong from GiaPhong where MaPhong = @maphong

go
IF (OBJECT_ID(N'hienmaphong', 'p') IS NOT NULL)
DROP PROC hienmaphong
GO

Create  Proc [dbo].[hienmaphong]
@maphong int
as
if(@maphong = 0)
	begin
		select distinct MaPhong from GiaPhong
	end
else
	select GiaPhong, LoaiPhong from GiaPhong where MaPhong = @maphong
-----------------------------------------------------------------------------------------------------
go
IF (OBJECT_ID(N'capnhatgiaphong', 'p') IS NOT NULL)
DROP PROC capnhatgiaphong
GO
Create  Proc [dbo].[capnhatgiaphong]

@maphong int,
@giaphong int,
@loaiphong Nvarchar(10)
as
	if(exists(select * from [dbo].[GiaPhong] where Maphong = @maphong))
		begin
			Update [dbo].[GiaPhong]
			set GiaPhong = @giaphong, LoaiPhong = @loaiphong
			where MaPhong = @maphong
			select errcode = 0
		end
	else
		select errcode = 1

-----------------------------------------------------------------------------------------------------------
go
IF (OBJECT_ID(N'abc', 'p') IS NOT NULL)
DROP PROC abc
GO
Create  Proc [dbo].[abc]
 
 @maphong int
 as
 if(exists(select MaPhong from Phong where [Maphong] = @maphong))
 select err = 1
 
 ---------------------------------------------------------------------------------------------------
 go
IF (OBJECT_ID(N'doimatkhau', 'p') IS NOT NULL)
DROP PROC doimatkhau
GO

Create  Proc [dbo].[doimatkhau]

 @taikhoan Nvarchar(50),
 @matkhaucu Nvarchar(50),
 @matkhaumoi Nvarchar(50)
 as
	if(exists(select TaiKhoan From NhanVien where TaiKhoan = @taikhoan and MatKhau = @matkhaucu))
		begin
			Update NhanVien
			Set MatKhau = @matkhaumoi
			Where TaiKhoan = @taikhoan and MatKhau = @matkhaucu
			select errcode = 0
		end
	else
		select errcode = 1

---------------------------------------------------------------------------------------------------
go
IF (OBJECT_ID(N'tinhtrangphong', 'p') IS NOT NULL)
DROP PROC tinhtrangphong
GO

Create Proc [dbo].[tinhtrangphong]
@ma int
as
if(@ma = 0)
begin
	select MaPhong, TinhTrang
	from phong
end
else
begin
	select MaPhong, TinhTrang
	from phong
	where MaPhong = @ma
end
---------------------------------------------------------------------------------------------------'
go
IF (OBJECT_ID(N'timkhachhang ', 'p') IS NOT NULL)
DROP PROC timkhachhang 
GO

Create Proc [dbo].[timkhachhang]

@chuoi nvarchar(50)
AS
SELECT MaPhong, TenKh, SoCm, NamSinh, NgayDp, NgayTp
FROM phong
WHERE TenKh LIKE '%' + @chuoi + '%' or SoCm like '%' + @chuoi + '%' or NamSinh like '%' + @chuoi + '%'

---------------------------------------------------------------------------------------------------
go
IF (OBJECT_ID(N'danhsachphong ', 'p') IS NOT NULL)
DROP PROC danhsachphong 
GO
Create Proc [dbo].[danhsachphong]

@ma int 
as 
if(@ma = 0)
begin
	select GiaPhong.Maphong, phong.TinhTrang, GiaPhong.GiaPhong, GiaPhong.LoaiPhong
	from GiaPhong inner join phong on GiaPhong.Maphong = phong.MaPhong
end

---------------------------------------------------------------------------------------------------
go
IF (OBJECT_ID(N'danhsachphongt ', 'p') IS NOT NULL)
DROP PROC danhsachphongt 
GO
Create Proc [dbo].[danhsachphongt]

@ma int 
as 
if(@ma = 0)
begin
	select GiaPhong.Maphong, phong.TinhTrang, GiaPhong.GiaPhong, GiaPhong.LoaiPhong
	from GiaPhong inner join phong on GiaPhong.Maphong = phong.MaPhong
	where TinhTrang = N'Trống'
end

---------------------------------------------------------------------------------------------------
go

IF (OBJECT_ID(N'danhsachphongkt ', 'p') IS NOT NULL)
DROP PROC danhsachphongkt 
GO

Create Proc [dbo].[danhsachphongkt]
 
@ma int 
as 
if(@ma = 0)
begin
	select GiaPhong.Maphong, phong.TinhTrang, GiaPhong.GiaPhong, GiaPhong.LoaiPhong
	from GiaPhong inner join phong on GiaPhong.Maphong = phong.MaPhong
	where TinhTrang = N'Không'
end

---------------------------------------------------------------------------------------------------
go

IF (OBJECT_ID(N'doanhthu ', 'p') IS NOT NULL)
DROP PROC doanhthu 
GO

Create Proc [dbo].[doanhthu]
@ma int
as
if(@ma = 0)
	begin
		select MaPhong, TongTien
		from luuthongtinphong
	end
else
	begin
		select  MaPhong, TongTien
		from luuthongtinphong
		where MaPhong = @ma
	end

---------------------------------------------------------------------------------------------------
go
IF (OBJECT_ID(N'doanhthuthang ', 'p') IS NOT NULL)
DROP PROC doanhthuthang 
GO

Create Proc [dbo].[doanhthuthang]

@chuoi nvarchar(50)
AS
select MaPhong, TongTien
from luuthongtinphong
WHERE (left([NgayDp],2) = @chuoi) and (left([NgayTp],2) = @chuoi)
--LIKE '%' + @chuoi + '%' or left([NgayDp],2) LIKE '%' + @chuoi + '%'

---------------------------------------------------------------------------------------------------
--IF (OBJECT_ID(N'laygame ', 'p') IS NOT NULL)
--DROP PROC laygame 
--GO

--Create Proc [dbo].[laygame]
--@ma int
--as
--select  Cauhoi, Dapan from game where ma = @ma


-----------------------------------------------------------------------------------------------------
--IF (OBJECT_ID(N'report1 ', 'p') IS NOT NULL)
--DROP PROC report1 
--GO

--Create Proc [dbo].[report1]

--@ma int
--as
--if(@ma = 0)
--begin
--	select MaPhong, MaKh, TenKh, NamSinh, SoCm, NgayDp, NgayTp, TienPhong, ChiPhiPhu, TongTien, NvLap
--	from luuthongtinphong
--end
--else
--begin
--	select MaPhong, MaKh, TenKh, NamSinh, SoCm, NgayDp, NgayTp, TienPhong, ChiPhiPhu, TongTien, NvLap
--	from luuthongtinphong
--	where MaKh = @ma
--end

-----------------------------------------------------------------------------------------------------
go

IF (OBJECT_ID(N'laytrangthaianhien ', 'p') IS NOT NULL)
DROP PROC laymakhachhang  
GO
Create Proc [dbo].[laymakhachhang]

@maphong int,
@tenkh nvarchar(50),
@tongtien int
as
	select MaKh
	from luuthongtinphong
	where MaPhong = @maphong and TenKh = @tenkh and TongTien = @tongtien

-----------------------------------------------------------------------------------------------------
go
IF (OBJECT_ID(N'laytrangthaianhien ', 'p') IS NOT NULL)
DROP PROC laytrangthaianhien  
GO
Create Proc [dbo].[laytrangthaianhien]

@ma int,
@trangthai nvarchar(10)
as
if(@ma = 0 and @trangthai = N'Hiện')
	begin
		select Maphong from SuaPhong where TrangThai = @trangthai
	end
if(@ma = 0 and @trangthai = N'Ẩn')
	begin
		select Maphong from SuaPhong where TrangThai = @trangthai
	end
-----------------------------------------------------------------------------------------------------
go
IF (OBJECT_ID(N'suatrangthaianhien ', 'p') IS NOT NULL)
DROP PROC suatrangthaianhien  
GO
Create Proc [dbo].[suatrangthaianhien]
@ma int,
@trangthai nvarchar(10)
as
update  Suaphong set TrangThai = @trangthai where Maphong = @ma
-----------------------------------------------------------------------------------------------------
go
IF (OBJECT_ID(N'txp ', 'p') IS NOT NULL)
DROP PROC txp 
GO
Create Proc [dbo].[txp]

@ma int
as
	select * from SuaPhong where Maphong = @ma
-----



