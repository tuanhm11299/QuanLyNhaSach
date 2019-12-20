CREATE DATABASE QLNS2019
GO
USE QLNS2019
GO

CREATE TABLE SACH
(
	MaSach		nchar(10)PRIMARY KEY,
	TenSach		nchar(100),
	TheLoai		nchar(50),
	TacGia		nchar(100),
	SoLuongTon	int,
)


CREATE TABLE PHIEUNHAP
(
	MaPhieuNhap	nchar(10)PRIMARY KEY not null,
	NgayNhap datetime,
)

CREATE TABLE CHITIETPHIEUNHAP
(
	MaChiTietPhieuNHap	nchar(10)PRIMARY KEY not null,
	MaPhieuNhap	nchar(10)FOREIGN KEY REFERENCES PHIEUNHAP(MaPhieuNhap),
	MaSach	nchar(10)FOREIGN KEY REFERENCES SACH(MaSach),
	SoLuongNhap	int,
	DonGiaNhap int,
)

CREATE TABLE KHACHHANG
(
	MaKhachHang	nchar(10)PRIMARY KEY not null,
	HoTenKhachHang nchar(100),
	DiaChi nchar(100),
	DienThoai nchar(20),
	Email nchar(50),
	SoTienNo float
)

CREATE TABLE HOADON
(
	MaHoaDon	nchar(10)PRIMARY KEY not null,
	MaKhachHang nchar(10)FOREIGN KEY REFERENCES KHACHHANG(MaKhachHang),
	NgayLapHoaDon datetime,
	TongThanhTien int
)

CREATE TABLE CHITIETHOADON
(
	MaChiTietHoaDon	nchar(10)PRIMARY KEY not null,
	MaHoaDon nchar(10)FOREIGN KEY REFERENCES HOADON(MaHoaDon),
	MaSach nchar(10)FOREIGN KEY REFERENCES SACH(MaSach),
	SoLuongBan int,
	DonGiaBan float,
)

CREATE TABLE PHIEUTHUTIEN
(
	MaPhieuThu	nchar(10)PRIMARY KEY not null,
	SoTienThu float,
	NgayThuTien datetime,
	MaKhachHang nchar(10)FOREIGN KEY REFERENCES KHACHHANG(MaKhachHang),
)

CREATE TABLE BAOCAOTON
(
	MaChiTietTon	nchar(10)PRIMARY KEY not null,
	Thang int,
	Nam int,
	MaSach nchar(10)FOREIGN KEY REFERENCES SACH(MaSach),
	TonDau int,
	TonPhatSinh int,
	TonCuoi int,
)

CREATE TABLE BAOCAOCONGNO
(
	MaChiTietCongNo	nchar(10)PRIMARY KEY not null,
	Thang int,
	Nam int,
	MaKhachHang nchar(10)FOREIGN KEY REFERENCES KHACHHANG(MaKhachHang),
	NoDau float,
	NoCuoi float,
	NoPhatSinh float,
)

CREATE TABLE THAMSO
(
	MaThamSo	int identity(1,1) PRIMARY KEY not null,
	SoLuongNhapItNhat int,
	SoLuongTonToiDaTruocNhap int,
	SoLuongTonSauToiThieu int,
	SoTienNoToiDa float,
	SuDungQuyDinh4 int,
)

insert into THAMSO values(150,300,20,20000,1)

insert into SACH values('ma_1','Tieng Viet 1','SGK','BGDDT',15)
insert into SACH values('ma_2','Tieng Anh 1','SGK','BGDDT',20)
insert into SACH values('ma_3','Ngu Van 1','SGK','BGDDT',10)

insert into PHIEUNHAP values ('maPN_1','2019/1/24 00:00:00')
insert into PHIEUNHAP values ('maPN_2','2019/1/24 00:00:00')
insert into PHIEUNHAP values ('maPN_3','2019/1/24 00:00:00')

insert into CHITIETPHIEUNHAP values ('maCT_1','maPN_1','ma_1',15,100000)
insert into CHITIETPHIEUNHAP values ('maCT_2','maPN_2','ma_2',10,120000)
insert into CHITIETPHIEUNHAP values ('maCT_3','maPN_3','ma_3',5,90000)

insert into KHACHHANG values('maKH_1','Le Thi Rieng','Da Nang','123456789','a@gmail',1000000)
insert into KHACHHANG values('maKH_2','Bui Tien Dung','Lang Son','123456789','b@gmail',500000)
insert into KHACHHANG values('maKH_3','Ngoc Trinh','Tay Ninh','123456789','c@gmail',1000000000)

insert into HOADON values('maHD_1','maKH_1','2019/2/10 00:00:00',2000000)
insert into HOADON values('maHD_2','maKH_2','2019/2/14 00:00:00',1000000)
insert into HOADON values('maHD_3','maKH_3','2019/2/26 00:00:00',1500000000)

insert into CHITIETHOADON values('maCTHD_1','maHD_1','ma_1',100,55000)
insert into CHITIETHOADON values('maCTHD_2','maHD_2','ma_2',150,65000)
insert into CHITIETHOADON values('maCTHD_3','maHD_3','ma_3',100,55000)

insert into PHIEUTHUTIEN values('maP_1',110000,'2019/1/24 00:00:00','maKH_1')
insert into PHIEUTHUTIEN values('maP_2',120000,'2019/1/24 00:00:00','maKH_2')
insert into PHIEUTHUTIEN values('maP_3',175000,'2019/1/24 00:00:00','maKH_3')

insert into BAOCAOTON values ('maCTT_1',2,2019,'ma_1',10,15,20)
insert into BAOCAOTON values ('maCTT_2',2,2019,'ma_2',15,20,10)
insert into BAOCAOTON values ('maCTT_3',2,2019,'ma_3',10,15,20)

insert into BAOCAOCONGNO values ('maCTN_1',2,2019,'maKH_1',20,15,10)
insert into BAOCAOCONGNO values ('maCTN_2',2,2019,'maKH_2',15,10,5)
insert into BAOCAOCONGNO values ('maCTN_3',2,2019,'maKH_3',20,15,10)
