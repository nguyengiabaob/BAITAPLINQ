Create database QLSINHVIEN4
Go
use QLSINHVIEN4
Go

--drop database QLSINHVIEN2
-- Tạo cấu trúc bảng
--Drop table KHOA
Create table KHOA
(
	MaKhoa varchar(10) not null,
	TenKhoa nvarchar(100) not null,
	NamThanhLap int
	constraint PRK_KHOA primary key (MaKhoa)
)
--Drop table KHOAHOC
Create table KHOAHOC
(
	MaKhoaHoc varchar(10) not null,
	NamBatDau int,
	NamKetThuc int
	constraint PRK_KHOAHOC primary key (MaKhoaHoc)
)
--Drop table SINHVIEN
Create table SINHVIEN
(
	MaSV varchar(10) not null,
	HoTen nvarchar(100) not null,
	NgaySinh datetime,
	GioiTinh bit,
	DiaChi nvarchar(100),
	MaLop varchar(10),
	Hinh nvarchar(100)
	constraint PRK_SINHVIEN primary key (MaSV)
)
--Drop table CHUONGTRINH
Create table CHUONGTRINH
(
	MaCT varchar(10) not null,
	TenChuongTrinh nvarchar(100)
	constraint PRK_CHUONGTRINH primary key (MaCT)
)
--Drop table MONHOC
Create table MONHOC
(
	MaMH varchar(10) not null,
	TenMonHoc nvarchar(100) not null,
	MaKhoa varchar(10),
	SoTC int 
	constraint PRK_MONHOC primary key (MaMH)
)
--Drop table KETQUA
Create table KETQUA
(
	MaSV varchar(10) not null,
	MaMH varchar(10) not null,
	LanThi int not null,
	Diem float
	constraint PRK_KETQUA primary key (MaSV, MaMH, LanThi)
)
--Drop table LOP
Create table LOP
(
	MaLop varchar(10) not null,
	TenLop nvarchar(50),
	MaKhoaHoc varchar(10),
	MaKhoa varchar(10),
	MaCT varchar(10),
	SoThuTu int
	constraint PRK_LOP primary key (MaLop)
)
-- Tạo liên kết
alter table SINHVIEN
add 
	constraint FRK_SINHVIEN_LOP foreign key (MaLop) references LOP(MaLop) 

alter table MONHOC
add
	constraint FRK_MONHOC_KHOA foreign key (MaKhoa) references KHOA(MaKhoa) 

alter table KETQUA
add
	constraint FRK_KETQUA_SINHVIEN foreign key(MaSV) references SINHVIEN(MaSV) ,
	constraint FRK_KETQUA_MONHOC foreign key (MaMH) references MONHOC(MaMH) 

alter table LOP
add
	constraint FRK_LOP_KHOAHOC foreign key (MaKhoaHoc) references KHOAHOC(MaKhoaHoc),
	constraint FRK_LOP_KHOA foreign key (MaKhoa) references KHOA(MaKhoa) ,
	constraint FRK_LOP_CHUONGTRINH foreign key (MaCT) references CHUONGTRINH(MaCT) 
--Nhập dữ liệu
insert into KHOA values('CNTT', N'Công nghệ thông tin', 1995)
insert into KHOA values('GDTH', N'Giáo Dục Tiều Học', 1970)
--
insert into KHOAHOC values('K2014', 2014, 2018)
insert into KHOAHOC values('K2015', 2015, 2019)
insert into KHOAHOC values('K2016', 2016, 2020)
--
insert into CHUONGTRINH values('CQ', N'Chính Qui')
insert into CHUONGTRINH values('CD', N'Cao Đẳng')
--
insert into MONHOC values('TO01', N'Toán cao cấp A1', 'CNTT',2)
insert into MONHOC values('VL01', N'Vật lý A1', 'GDTH',2)
insert into MONHOC values('TO02', N'Toán rời rạc', 'CNTT',2)
insert into MONHOC values('TH01', N'Cấu trúc dữ liệu 1', 'CNTT',3)
insert into MONHOC values('TH02', N'Hệ điều hành', 'CNTT',3 )
--LOP
insert into LOP values('D14PM01',N'Kỹ thuật phần mềm D14PM01', 'K2014', 'CNTT','CQ', 1)
insert into LOP values('D14HT01',N'Hệ thống thông tin D14HT01', 'K2014', 'CNTT','CQ', 2)
insert into LOP values('D15GDTH01',N'Giáo dục tiểu học D15GDTH01', 'K2015', 'GDTH','CQ', 1)
--SINHVIEN
insert into SINHVIEN values('0212001', N'Nguyễn Huỳnh Anh', '7/1/1995',0, N'Binh Duong', 'D14PM01',N'')
insert into SINHVIEN values('0212002', N'Nguyễn Thanh Bình', '6/20/1990',1, N'Tp HCM', 'D14PM01',N'')
insert into SINHVIEN values('0212003', N'Nguyễn Thanh Cường', '4/25/1993',1, N'Binh Duong', 'D14HT01',N'')
insert into SINHVIEN values('0212004', N'Lê Thị Ngân', '2/1/1990',0, N'Đồng Nai', 'D14HT01','')
insert into SINHVIEN values('0311001', N'Phan Tuấn Anh', '10/5/1995',1, N'Tây Ninh', 'D14PM01',N'')
insert into SINHVIEN values('0311002', N'Huỳnh Thanh Sang', '11/12/1994',1, N'Bến Tre', 'D15GDTH01',N'')
--
insert into KETQUA values('0212001', 'TO01', 1,4)
insert into KETQUA values('0212001', 'TO01', 2,7)
insert into KETQUA values('0212002', 'TO01', 1,8)
insert into KETQUA values('0212003', 'TO01', 1,6)
insert into KETQUA values('0212004', 'TO02', 1,9)
insert into KETQUA values('0212001', 'TO02', 1,8)
insert into KETQUA values('0212002', 'VL01', 1,5.5)
insert into KETQUA values('0212003', 'VL01', 1,4)
insert into KETQUA values('0212003', 'VL01', 2,6)
insert into KETQUA values('0212001', 'TH01', 1,6.5)
insert into KETQUA values('0212002', 'TH01', 1,4)
insert into KETQUA values('0212003', 'TH01', 1,7)
