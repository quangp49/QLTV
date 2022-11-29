USE QLTV2
CREATE TABLE CHUCVU
(
	MaCV VARCHAR(10),
	TenCV NVARCHAR(20) PRIMARY KEY,
	Luong INT
)
GO
CREATE TABLE PHONGDOC
(
    Maphong VARCHAR(10) PRIMARY KEY,
	Succhuasach int,
	Suchuamaytinh int,
	Thoigianmo TIME,
	Thoigiandong TIME,
)
GO
CREATE TABLE NHANVIEN
(
	MaNV VARCHAR(10) PRIMARY KEY,
	TenCV NVARCHAR(20),
	Hoten NVARCHAR(20),
	Ngaysinh DATE,
	Quequan NVARCHAR(20),
	Sdt VARCHAR(10),
	Maphong VARCHAR(10) ,
	FOREIGN KEY (Maphong) REFERENCES dbo.PHONGDOC(Maphong),
	FOREIGN KEY (TenCV) REFERENCES dbo.CHUCVU(TenCV)
)
GO
CREATE TABLE TAIKHOAN
(
	Tendangnhap VARCHAR(10) PRIMARY KEY,
	Matkhau VARCHAR(10),
	MaNV VARCHAR(10) UNIQUE,
	Quyentruycap NVARCHAR(10),
	FOREIGN KEY (MaNV) REFERENCES dbo.NHANVIEN(MaNV)
)
GO
CREATE TABLE MAYTINH
(
	MaMT VARCHAR(10) PRIMARY KEY,
	TenMT VARCHAR(10),
	Ngaynhap DATE,
	Trangthai NVARCHAR(10),
	Maphong VARCHAR(10),
	FOREIGN KEY (Maphong) REFERENCES dbo.PHONGDOC(Maphong)
)
GO
CREATE TABLE DAUSACH
(
	Madausach VARCHAR(10) PRIMARY KEY,
	Matuasach VARCHAR(10),
	Tensach NVARCHAR(20),
	Tentacgia NVARCHAR(20),
	NXB NVARCHAR(20),
	Gia INT,
	Ngaynhap DATE,
	Maphong VARCHAR(10),
	Tinhtrang NVARCHAR(10),
	Trangthai NVARCHAR(10),
	FOREIGN KEY (Maphong) REFERENCES dbo.PHONGDOC(Maphong),
)
GO
CREATE TABLE NGUOIDOC
(
	Manguoidoc VARCHAR(10) PRIMARY KEY,
	Tennguoidoc NVARCHAR(20),
	Ngaysinh DATE,
	Sdt VARCHAR(10),
	Lop NVARCHAR(20)
)
CREATE TABLE PHIEUMUON
(
	Maphieu VARCHAR(10) PRIMARY KEY,
	Manguoidoc VARCHAR(10),
	Ngaymuon DATE,
	Ngaytra DATE,
	FOREIGN KEY (Manguoidoc) REFERENCES dbo.NGUOIDOC(Manguoidoc)
)
GO
CREATE TABLE SUCO
(
  Masuco INT IDENTITY(1,1) PRIMARY KEY,
  Tensuco NVARCHAR(20),
  Thoigian DATE,
  Boithuong INT,
)
GO
CREATE TABLE CTPHIEU
(
	Maphieu VARCHAR(10) ,
	Madausach VARCHAR(10) UNIQUE,
	Masuco INT  ,
	FOREIGN KEY(Maphieu) REFERENCES dbo.PHIEUMUON(Maphieu),
	FOREIGN KEY(Madausach) REFERENCES dbo.DAUSACH(Madausach),
	FOREIGN KEY (Masuco) REFERENCES dbo.SUCO(Masuco)
)


INSERT INTO dbo.CHUCVU
(
    MaCV,
    TenCV,
    Luong
)
VALUES
(   'QL',  -- MaCV - varchar(10)
    N'Quản lý', -- TenCV - nvarchar(20)
    250000    -- Luong - int
    )
INSERT INTO dbo.CHUCVU
(
    MaCV,
    TenCV,
    Luong
)
VALUES
(   'NV',  -- MaCV - varchar(10)
    N'Nhân viên', -- TenCV - nvarchar(20)
    150000    -- Luong - int
    )

INSERT INTO dbo.PHONGDOC
(
    Maphong,
    Succhuasach,
    Suchuamaytinh,
    Thoigianmo,
    Thoigiandong
)
VALUES
(   'P1',         -- Maphong - varchar(10)
    20,          -- Succhuasach - int
    5,          -- Suchuamaytinh - int
    '08:30:00', -- Thoigianmo - time(7)
    '17:45:00'  -- Thoigiandong - time(7)
    )
INSERT INTO dbo.PHONGDOC
(
    Maphong,
    Succhuasach,
    Suchuamaytinh,
    Thoigianmo,
    Thoigiandong
)
VALUES
(   'P2',         -- Maphong - varchar(10)
    30,          -- Succhuasach - int
    10,          -- Suchuamaytinh - int
    '08:30:00', -- Thoigianmo - time(7)
    '17:30:00'  -- Thoigiandong - time(7)
    )
INSERT INTO dbo.PHONGDOC
(
    Maphong,
    Succhuasach,
    Suchuamaytinh,
    Thoigianmo,
    Thoigiandong
)
VALUES
(   'P3',         -- Maphong - varchar(10)
    20,          -- Succhuasach - int
    10,          -- Suchuamaytinh - int
    '09:30:00', -- Thoigianmo - time(7)
    '17:45:00'  -- Thoigiandong - time(7)
    )
INSERT INTO dbo.NHANVIEN
(
    MaNV,
    TenCV,
    Hoten,
    Ngaysinh,
    Quequan,
    Sdt,
    Maphong
)
VALUES
(   'NV001',        -- MaNV - varchar(10)
    N'Nhân viên',       -- TenCV - nvarchar(20)
    N'Hoàng Minh Đức',       -- Hoten - nvarchar(20)
    '20010312', -- Ngaysinh - date
    N'Hải Phòng',       -- Quequan - nvarchar(20)
    '0914384022',        -- Sdt - varchar(10)
    'P1'         -- Maphong - varchar(10)
    )
INSERT INTO dbo.NHANVIEN
(
    MaNV,
    TenCV,
    Hoten,
    Ngaysinh,
    Quequan,
    Sdt,
    Maphong
)
VALUES
(   'NV002',        -- MaNV - varchar(10)
    N'Quản lý',       -- TenCV - nvarchar(20)
    N'Nguyễn Hà Trang',       -- Hoten - nvarchar(20)
    '1998-10-12', -- Ngaysinh - date
    N'Hà Nội',       -- Quequan - nvarchar(20)
    '1234567890',        -- Sdt - varchar(10)
    'P2'         -- Maphong - varchar(10)
    )
INSERT INTO dbo.NHANVIEN
(
    MaNV,
    TenCV,
    Hoten,
    Ngaysinh,
    Quequan,
    Sdt,
    Maphong
)
VALUES
(   'NV003',        -- MaNV - varchar(10)
    N'Nhân viên',       -- TenCV - nvarchar(20)
    N'Nguyễn Thanh Mai',       -- Hoten - nvarchar(20)
     '2000-01-20', -- Ngaysinh - date
    N'Hà Tĩnh',       -- Quequan - nvarchar(20)
    '4727373721',        -- Sdt - varchar(10)
    'P2'         -- Maphong - varchar(10)
    )
INSERT INTO dbo.NHANVIEN
(
    MaNV,
    TenCV,
    Hoten,
    Ngaysinh,
    Quequan,
    Sdt,
    Maphong
)
VALUES
(   'NV004',        -- MaNV - varchar(10)
    N'Quản lý',       -- TenCV - nvarchar(20)
    N'Nguyễn Tiến Huy',       -- Hoten - nvarchar(20)
    '1995-03-10', -- Ngaysinh - date
    N'Nam Định',       -- Quequan - nvarchar(20)
    '0836961073',        -- Sdt - varchar(10)
    'P3'         -- Maphong - varchar(10)
    )
INSERT INTO dbo.TAIKHOAN
(
    Tendangnhap,
    Matkhau,
    MaNV,
    Quyentruycap
)
VALUES
(   'user1', -- Tendangnhap - varchar(10)
    '1', -- Matkhau - varchar(10)
    'NV001', -- MaNV - varchar(10)
    N'Nhân viên' -- Quyentruycap - nvarchar(10)
    )
INSERT INTO dbo.TAIKHOAN
(
    Tendangnhap,
    Matkhau,
    MaNV,
    Quyentruycap
)
VALUES
(   'user2', -- Tendangnhap - varchar(10)
    '2', -- Matkhau - varchar(10)
    'NV002', -- MaNV - varchar(10)
    N'Quản lý' -- Quyentruycap - nvarchar(10)
    )
INSERT INTO dbo.TAIKHOAN
(
    Tendangnhap,
    Matkhau,
    MaNV,
    Quyentruycap
)
VALUES
(   'user3', -- Tendangnhap - varchar(10)
    '3', -- Matkhau - varchar(10)
    'NV003', -- MaNV - varchar(10)
    N'Nhân viên' -- Quyentruycap - nvarchar(10)
    )
INSERT INTO dbo.TAIKHOAN
(
    Tendangnhap,
    Matkhau,
    MaNV,
    Quyentruycap
)
VALUES
(   'user4', -- Tendangnhap - varchar(10)
    '4', -- Matkhau - varchar(10)
    'NV004', -- MaNV - varchar(10)
    N'Quản lý' -- Quyentruycap - nvarchar(10)
    )

INSERT INTO dbo.MAYTINH
(
    MaMT,
    TenMT,
    Ngaynhap,
    Trangthai,
    Maphong
)
VALUES
(   'MT01',        -- MaMT - varchar(10)
    'ASUS',        -- TenMT - varchar(10)
    '20191002', -- Ngaynhap - date
    N'Off',       -- Trangthai - nvarchar(10)
    'P1'         -- Maphong - varchar(10)
    )
INSERT INTO dbo.MAYTINH
(
    MaMT,
    TenMT,
    Ngaynhap,
    Trangthai,
    Maphong
)
VALUES
(   'MT02',        -- MaMT - varchar(10)
    'DELL',        -- TenMT - varchar(10)
    '20200610', -- Ngaynhap - date
    N'Off',       -- Trangthai - nvarchar(10)
    'P1'         -- Maphong - varchar(10)
    )
INSERT INTO dbo.MAYTINH
(
    MaMT,
    TenMT,
    Ngaynhap,
    Trangthai,
    Maphong
)
VALUES
(   'MT03',        -- MaMT - varchar(10)
    'HP',        -- TenMT - varchar(10)
    '20200415', -- Ngaynhap - date
    N'Off',       -- Trangthai - nvarchar(10)
    'P2'         -- Maphong - varchar(10)
    )
INSERT INTO dbo.MAYTINH
(
    MaMT,
    TenMT,
    Ngaynhap,
    Trangthai,
    Maphong
)
VALUES
(   'MT04',        -- MaMT - varchar(10)
    'HP',        -- TenMT - varchar(10)
    '20210519', -- Ngaynhap - date
    N'Off',       -- Trangthai - nvarchar(10)
    'P3'         -- Maphong - varchar(10)
    )
INSERT INTO dbo.MAYTINH
(
    MaMT,
    TenMT,
    Ngaynhap,
    Trangthai,
    Maphong
)
VALUES
(   'MT05',        -- MaMT - varchar(10)
    'ASUS',        -- TenMT - varchar(10)
    '20181203', -- Ngaynhap - date
    N'Off',       -- Trangthai - nvarchar(10)
    'P2'         -- Maphong - varchar(10)
    )
INSERT INTO dbo.MAYTINH
(
    MaMT,
    TenMT,
    Ngaynhap,
    Trangthai,
    Maphong
)
VALUES
(   'MT06',        -- MaMT - varchar(10)
    'LENOVO',        -- TenMT - varchar(10)
    '20220106', -- Ngaynhap - date
    N'Off',       -- Trangthai - nvarchar(10)
    'P3'         -- Maphong - varchar(10)
    )
INSERT INTO dbo.MAYTINH
(
    MaMT,
    TenMT,
    Ngaynhap,
    Trangthai,
    Maphong
)
VALUES
(   'MT07',        -- MaMT - varchar(10)
    'ASUS',        -- TenMT - varchar(10)
    '20191003', -- Ngaynhap - date
    N'Off',       -- Trangthai - nvarchar(10)
    'P1'         -- Maphong - varchar(10)
    )
INSERT INTO dbo.DAUSACH
(
    Madausach,
    Matuasach,
    Tensach,
    Tentacgia,
    NXB,
    Gia,
    Ngaynhap,
    Maphong,
    Tinhtrang,
    Trangthai
)
VALUES
(   'BOOK01',        -- Madausach - varchar(10)
    'TRR',        -- Matuasach - varchar(10)
    N'Toán rời rạc',       -- Tensach - nvarchar(20)
    N'Nguyễn Đức Nghĩa',       -- Tentacgia - nvarchar(20)
    N'Sư Phạm',       -- NXB - nvarchar(20)
    8000,         -- Gia - int
    '20191024', -- Ngaynhap - date
    'P1',        -- Maphong - varchar(10)
    N'Mới',       -- Tinhtrang - nvarchar(10)
    N'Đã mượn'        -- Trangthai - nvarchar(10)
    )
INSERT INTO dbo.DAUSACH
(
    Madausach,
    Matuasach,
    Tensach,
    Tentacgia,
    NXB,
    Gia,
    Ngaynhap,
    Maphong,
    Tinhtrang,
    Trangthai
)
VALUES
(   'BOOK02',        -- Madausach - varchar(10)
    'OOP',        -- Matuasach - varchar(10)
    N'Lập trình HĐT',       -- Tensach - nvarchar(20)
    N'Phạm Tiến Huy',       -- Tentacgia - nvarchar(20)
    N'Sư Phạm',       -- NXB - nvarchar(20)
    12000,         -- Gia - int
    '20201119', -- Ngaynhap - date
    'P1',        -- Maphong - varchar(10)
    N'Mới',       -- Tinhtrang - nvarchar(10)
    N'Đã mượn'        -- Trangthai - nvarchar(10)
    )
INSERT INTO dbo.DAUSACH
(
    Madausach,
    Matuasach,
    Tensach,
    Tentacgia,
    NXB,
    Gia,
    Ngaynhap,
    Maphong,
    Tinhtrang,
    Trangthai
)
VALUES
(   'BOOK03',        -- Madausach - varchar(10)
    'OOP',        -- Matuasach - varchar(10)
    N'Lập trình HĐT',       -- Tensach - nvarchar(20)
    N'Phạm Tiến Huy',       -- Tentacgia - nvarchar(20)
    N'Sư Phạm',       -- NXB - nvarchar(20)
    12000,         -- Gia - int
    '20210912', -- Ngaynhap - date
    'P2',        -- Maphong - varchar(10)
    N'Mới',       -- Tinhtrang - nvarchar(10)
    N'Đã mượn'        -- Trangthai - nvarchar(10)
    )
INSERT INTO dbo.DAUSACH
(
    Madausach,
    Matuasach,
    Tensach,
    Tentacgia,
    NXB,
    Gia,
    Ngaynhap,
    Maphong,
    Tinhtrang,
    Trangthai
)
VALUES
(   'BOOK04',        -- Madausach - varchar(10)
    'C#',        -- Matuasach - varchar(10)
    N'Lập trình C#',       -- Tensach - nvarchar(20)
    N'Nguyễn Thành Long',       -- Tentacgia - nvarchar(20)
    N'ĐHQG',       -- NXB - nvarchar(20)
    10000,         -- Gia - int
    '20180315', -- Ngaynhap - date
    'P3',        -- Maphong - varchar(10)
    N'Cũ',       -- Tinhtrang - nvarchar(10)
    N'Đã mượn'        -- Trangthai - nvarchar(10)
    )
INSERT INTO dbo.DAUSACH
(
    Madausach,
    Matuasach,
    Tensach,
    Tentacgia,
    NXB,
    Gia,
    Ngaynhap,
    Maphong,
    Tinhtrang,
    Trangthai
)
VALUES
(   'BOOK05',        -- Madausach - varchar(10)
    'JAVA',        -- Matuasach - varchar(10)
    N'Lập trình JAVA',       -- Tensach - nvarchar(20)
    N'Nguyễn Tuấn Mạnh',       -- Tentacgia - nvarchar(20)
    N'Sư Phạm',       -- NXB - nvarchar(20)
    15000,         -- Gia - int
    '20161204', -- Ngaynhap - date
    'P3',        -- Maphong - varchar(10)
    N'Cũ',       -- Tinhtrang - nvarchar(10)
    N'Chưa mượn'        -- Trangthai - nvarchar(10)
    )
INSERT INTO dbo.DAUSACH
(
    Madausach,
    Matuasach,
    Tensach,
    Tentacgia,
    NXB,
    Gia,
    Ngaynhap,
    Maphong,
    Tinhtrang,
    Trangthai
)
VALUES
(   'BOOK06',        -- Madausach - varchar(10)
    'TRR',        -- Matuasach - varchar(10)
    N'Toán rời rạc',       -- Tensach - nvarchar(20)
    N'Nguyễn Đức Nghĩa',       -- Tentacgia - nvarchar(20)
    N'Sư Phạm',       -- NXB - nvarchar(20)
    8000,         -- Gia - int
    '20210310', -- Ngaynhap - date
    'P2',        -- Maphong - varchar(10)
    N'Mới',       -- Tinhtrang - nvarchar(10)
    N'Chưa mượn'        -- Trangthai - nvarchar(10)
    )
INSERT INTO dbo.DAUSACH
(
    Madausach,
    Matuasach,
    Tensach,
    Tentacgia,
    NXB,
    Gia,
    Ngaynhap,
    Maphong,
    Tinhtrang,
    Trangthai
)
VALUES
(   'BOOK07',        -- Madausach - varchar(10)
    'DSTT',        -- Matuasach - varchar(10)
    N'Đại số tuyến tính',       -- Tensach - nvarchar(20)
    N'Nguyễn Đức Lân',       -- Tentacgia - nvarchar(20)
    N'NXBGD',       -- NXB - nvarchar(20)
    8000,         -- Gia - int
    '20200312', -- Ngaynhap - date
    'P2',        -- Maphong - varchar(10)
    N'Mới',       -- Tinhtrang - nvarchar(10)
    N'Chưa mượn'        -- Trangthai - nvarchar(10)
    )
INSERT INTO dbo.DAUSACH
(
    Madausach,
    Matuasach,
    Tensach,
    Tentacgia,
    NXB,
    Gia,
    Ngaynhap,
    Maphong,
    Tinhtrang,
    Trangthai
)
VALUES
(   'BOOK08',        -- Madausach - varchar(10)
    'NODEJS',        -- Matuasach - varchar(10)
    N'Lập trình NodeJS',       -- Tensach - nvarchar(20)
    N'Phạm Thanh Nga',       -- Tentacgia - nvarchar(20)
    N'KHTN',       -- NXB - nvarchar(20)
    12000,         -- Gia - int
    '20210310', -- Ngaynhap - date
    'P3',        -- Maphong - varchar(10)
    N'Mới',       -- Tinhtrang - nvarchar(10)
    N'Chưa mượn'        -- Trangthai - nvarchar(10)
    )
INSERT INTO dbo.DAUSACH
(
    Madausach,
    Matuasach,
    Tensach,
    Tentacgia,
    NXB,
    Gia,
    Ngaynhap,
    Maphong,
    Tinhtrang,
    Trangthai
)
VALUES
(   'BOOK09',        -- Madausach - varchar(10)
    'TRR',        -- Matuasach - varchar(10)
    N'Toán rời rạc',       -- Tensach - nvarchar(20)
    N'Nguyễn Đức Nghĩa',       -- Tentacgia - nvarchar(20)
    N'Sư Phạm',       -- NXB - nvarchar(20)
    8000,         -- Gia - int
    '20210310', -- Ngaynhap - date
    'P2',        -- Maphong - varchar(10)
    N'Mới',       -- Tinhtrang - nvarchar(10)
    N'Chưa mượn'        -- Trangthai - nvarchar(10)
    )
INSERT INTO dbo.DAUSACH
(
    Madausach,
    Matuasach,
    Tensach,
    Tentacgia,
    NXB,
    Gia,
    Ngaynhap,
    Maphong,
    Tinhtrang,
    Trangthai
)
VALUES
(   'BOOK10',        -- Madausach - varchar(10)
    'VLDC',        -- Matuasach - varchar(10)
    N'Vật lý đại cương',       -- Tensach - nvarchar(20)
    N'Chu Thị Phương',       -- Tentacgia - nvarchar(20)
    N'Sư Phạm',       -- NXB - nvarchar(20)
    13000,         -- Gia - int
    '20210519', -- Ngaynhap - date
    'P1',        -- Maphong - varchar(10)
    N'Mới',       -- Tinhtrang - nvarchar(10)
    N'Chưa mượn'        -- Trangthai - nvarchar(10)
    )
INSERT INTO dbo.NGUOIDOC
(
    Manguoidoc,
    Tennguoidoc,
    Ngaysinh,
    Sdt,
    Lop
)
VALUES
(   'ND01',        -- Manguoidoc - varchar(10)
    N'Nguyễn Trọng Mạnh',       -- Tennguoidoc - nvarchar(20)
    '20010509', -- Ngaysinh - date
    '1235487690',        -- Sdt - varchar(10)
    N'CTTN TT'        -- Lop - nvarchar(20)
    )
INSERT INTO dbo.NGUOIDOC
(
    Manguoidoc,
    Tennguoidoc,
    Ngaysinh,
    Sdt,
    Lop
)
VALUES
(   'ND02',        -- Manguoidoc - varchar(10)
    N'Phạm Khánh Linh',       -- Tennguoidoc - nvarchar(20)
    '19990319', -- Ngaysinh - date
    '0827819301',        -- Sdt - varchar(10)
    N'HTTTQL'        -- Lop - nvarchar(20)
    )
INSERT INTO dbo.NGUOIDOC
(
    Manguoidoc,
    Tennguoidoc,
    Ngaysinh,
    Sdt,
    Lop
)
VALUES
(   'ND03',        -- Manguoidoc - varchar(10)
    N'Vũ Thị Hoài',       -- Tennguoidoc - nvarchar(20)
    '20000118', -- Ngaysinh - date
    '0321047851',        -- Sdt - varchar(10)
    N'Toán Tin-01'        -- Lop - nvarchar(20)
    )
INSERT INTO dbo.NGUOIDOC
(
    Manguoidoc,
    Tennguoidoc,
    Ngaysinh,
    Sdt,
    Lop
)
VALUES
(   'ND04',        -- Manguoidoc - varchar(10)
    N'Hoàng Minh Đức',       -- Tennguoidoc - nvarchar(20)
    '20010312', -- Ngaysinh - date
    '0123456789',        -- Sdt - varchar(10)
    N'Toán Tin-02'        -- Lop - nvarchar(20)
    )
INSERT INTO dbo.PHIEUMUON
(
    Maphieu,
    Manguoidoc,
    Ngaymuon,
    Ngaytra
)
VALUES
(   'PHIEU01',        -- Maphieu - varchar(10)
    'ND01',        -- Manguoidoc - varchar(10)
    '20210320', -- Ngaymuon - date
    '20210410'  -- Ngaytra - date
    )

INSERT INTO dbo.PHIEUMUON
(
    Maphieu,
    Manguoidoc,
    Ngaymuon,
    Ngaytra
)
VALUES
(   'PHIEU02',        -- Maphieu - varchar(10)
    'ND01',        -- Manguoidoc - varchar(10)
    '20210710', -- Ngaymuon - date
    '20210805'  -- Ngaytra - date
    )
INSERT INTO dbo.PHIEUMUON
(
    Maphieu,
    Manguoidoc,
    Ngaymuon,
    Ngaytra
)
VALUES
(   'PHIEU03',        -- Maphieu - varchar(10)
    'ND02',        -- Manguoidoc - varchar(10)
    '20201101', -- Ngaymuon - date
    '20201120'  -- Ngaytra - date
    )




INSERT INTO dbo.CTPHIEU
(
    Maphieu,
    Madausach,
	Masuco
)
VALUES
(   'PHIEU01', -- Maphieu - varchar(10)
    'BOOK01',  -- Madausach - varchar(10)
	 NULL
    )
INSERT INTO dbo.CTPHIEU
(
    Maphieu,
    Madausach,
	Masuco
)
VALUES
(   'PHIEU01', -- Maphieu - varchar(10)
    'BOOK03',  -- Madausach - varchar(10)
	NULL
    )

INSERT INTO dbo.CTPHIEU
(
    Maphieu,
    Madausach,
	Masuco
)
VALUES
(   'PHIEU02', -- Maphieu - varchar(10)
    'BOOK04',  -- Madausach - varchar(10)
	NULL
    )

INSERT INTO dbo.CTPHIEU
(
    Maphieu,
    Madausach,
	Masuco
)
VALUES
(   'PHIEU03', -- Maphieu - varchar(10)
    'BOOK02',  -- Madausach - varchar(10)
	 NULL
    )
