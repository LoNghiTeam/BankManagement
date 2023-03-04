CREATE TABLE TaiKhoan (
         SoTK INT IDENTITY(1,1) PRIMARY KEY,
         UserName varchar(100), 
         Pass varchar(100), 
         HoTen varchar(100),
         NgaySinh date,
         isAdmin int,

         Tien FLOAT,
);
INSERT INTO TaiKhoan VALUES ('Admin', '123456', 'Nguyen Van a', '2022-11-16 08:19:41', 2, 0);
INSERT INTO TaiKhoan VALUES ('Admin2', '123456', 'Nguyen Van a', '2022-11-16 08:19:41',1, 0);
INSERT INTO TaiKhoan VALUES ('Admin3', '123456', 'Nguyen Van a', '2022-11-16 08:19:41',0, 0);
INSERT INTO TaiKhoan VALUES ('Admin4', '123456', 'Nguyen Van a', '2022-11-16 08:19:41',0, 0);

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
         FOREIGN KEY (NguoiGui) REFERENCES TaiKhoan(SoTK),
         FOREIGN KEY (NguoiNhan) REFERENCES TaiKhoan(SoTK),
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
         FOREIGN KEY (SoTK) REFERENCES TaiKhoan(SoTK),
         FOREIGN KEY (MaLS) REFERENCES LaiSuat(MaLS),
);
INSERT INTO KhoanVay VALUES (1,'2022-11-16 08:19:41','2023-4-3 08:19:41', 100000, 1,1,0);
INSERT INTO KhoanVay VALUES (2,'2023-4-3 08:19:41','2024-4-3 08:19:41',200000, 3,0,1);


select * from LaiSuat
select * from KhoanVay
select * from GiaoDich
select * from TaiKhoan