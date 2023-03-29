CREATE TABLE TaiKhoan (
         SoTK INT IDENTITY(1,1) PRIMARY KEY,
         UserName varchar(100), 
         Pass varchar(100), 
         HoTen varchar(100),
         NgaySinh date,
         Cccd varchar(100),
         Diachi varchar(1000),
         Sodienthoai varchar(11),
         isAdmin int,
         Tien FLOAT,
);
INSERT INTO TaiKhoan VALUES ('Admin', '123456', 'Nguyen Van a', '2022-11-16 08:19:41','10','Thanh pho Ho Chi Minh', '0123456789', 2, 0);
INSERT INTO TaiKhoan VALUES ('Admin2', '123456', 'Nguyen Van a', '2022-11-16 08:19:41','10','Thanh pho Ho Chi Minh', '0123456789',1, 0);
INSERT INTO TaiKhoan VALUES ('Admin3', '123456', 'Nguyen Van a', '2022-11-16 08:19:41','10','Thanh pho Ho Chi Minh', '0123456789',0, 0);
INSERT INTO TaiKhoan VALUES ('Admin4', '123456', 'Nguyen Van a', '2022-11-16 08:19:41','10','Thanh pho Ho Chi Minh', '0123456789',0, 0);

CREATE TABLE LaiSuat (
         MaLS INT IDENTITY(1,1) PRIMARY KEY,
         LaiGui FLOAT,
         LaiVay FLOAT,
         NgayApDung date,
);
INSERT INTO LaiSuat VALUES (0.08, 0.18, '2022-11-16 08:19:41');
INSERT INTO LaiSuat VALUES (0.08, 0.18, '2023-4-3 08:19:41');
INSERT INTO LaiSuat VALUES (0.08, 0.18, '2022-4-3 10:19:41');

CREATE TABLE GiaoDich (
         MaGD INT IDENTITY(1,1) PRIMARY KEY,
         NguoiGui int,
         NguoiNhan int,
         NgayGD date,
         Tien FLOAT,

);
INSERT INTO GiaoDich VALUES (1, 2, '2022-11-16 08:19:41', 100000);
INSERT INTO GiaoDich VALUES (2, 3, '2023-4-3 08:19:41',200000);
INSERT INTO GiaoDich VALUES (4, 1, '2022-4-3 10:19:41',3000000);


CREATE TABLE KhoanVay (
         SoKV INT IDENTITY(1,1) PRIMARY KEY,
         SoTK int,
         NgayVay date,
         Ngayhan date,
         Tien FLOAT,
         MaLS INT,
         TinhTrang int,
         Loai int,

);
INSERT INTO KhoanVay VALUES (1,'2022-11-16 08:19:41','2023-4-3 08:19:41', 100000, 1,1,0);
INSERT INTO KhoanVay VALUES (2,'2023-4-3 08:19:41','2024-4-3 08:19:41',200000, 3,0,1);

CREATE TABLE SoTietKiem (
         MaSTK INT IDENTITY(1,1) PRIMARY KEY,
         SoTK int,
         TenSo varchar(1000),
         NgayVay date,
         Ngayhan date,
         Tien FLOAT,
         MaLS INT,
         TinhTrang int
);

INSERT INTO SoTietKiem (SoTK,TenSo, NgayVay, Ngayhan, Tien, MaLS, TinhTrang) VALUES (1,'','2022-11-16','2023-4-3', 100000, 1,0);
INSERT INTO SoTietKiem (SoTK,TenSo, NgayVay, Ngayhan, Tien, MaLS, TinhTrang) VALUES (1,'','2022-11-15','2023-4-3', 100000, 1,0);
INSERT INTO SoTietKiem (SoTK,TenSo, NgayVay, Ngayhan, Tien, MaLS, TinhTrang) VALUES (1,'','2022-11-13','2023-4-3', 100000, 1,0);


select * from LaiSuat
select * from KhoanVay
select * from GiaoDich
select * from TaiKhoan


