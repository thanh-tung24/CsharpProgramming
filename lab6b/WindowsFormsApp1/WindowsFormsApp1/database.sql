USE master;
GO

-- 1. Nếu CSDL đã tồn tại thì ngắt kết nối và xóa đi để làm mới
IF EXISTS (SELECT name FROM sys.databases WHERE name = N'QLSinhVien')
BEGIN
    ALTER DATABASE QLSinhVien SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE QLSinhVien;
END
GO

-- 2. Tạo mới CSDL QLSinhVien
CREATE DATABASE QLSinhVien;
GO

USE QLSinhVien;
GO

-- 3. Tạo bảng Khoa
CREATE TABLE Khoa (
    MaKhoa VARCHAR(10) PRIMARY KEY,
    TenKhoa NVARCHAR(100) NOT NULL
);
GO

-- 4. Tạo bảng Lop
CREATE TABLE Lop (
    MaLop VARCHAR(10) PRIMARY KEY,
    TenLop NVARCHAR(100) NOT NULL,
    MaKhoa VARCHAR(10) FOREIGN KEY REFERENCES Khoa(MaKhoa) ON DELETE CASCADE
);
GO

-- 5. Tạo bảng SinhVien
CREATE TABLE SinhVien (
    MaSinhVien VARCHAR(10) PRIMARY KEY,
    HoTen NVARCHAR(100) NOT NULL,
    NgaySinh DATETIME,
    MaLop VARCHAR(10) FOREIGN KEY REFERENCES Lop(MaLop) ON DELETE CASCADE
);
GO

-- 6. Tạo bảng MonHoc
CREATE TABLE MonHoc (
    MaMonHoc VARCHAR(10) PRIMARY KEY,
    TenMonHoc NVARCHAR(100) NOT NULL
);
GO

-- 7. Tạo bảng Diem
CREATE TABLE Diem (
    MaSinhVien VARCHAR(10),
    MaMonHoc VARCHAR(10),
    Diem FLOAT,
    PRIMARY KEY (MaSinhVien, MaMonHoc),
    FOREIGN KEY (MaSinhVien) REFERENCES SinhVien(MaSinhVien) ON DELETE CASCADE,
    FOREIGN KEY (MaMonHoc) REFERENCES MonHoc(MaMonHoc) ON DELETE CASCADE
);
GO

-- 8. Chèn dữ liệu mẫu theo đúng thứ tự khóa ngoại
INSERT INTO Khoa VALUES 
('CNTT', N'Công nghệ thông tin'), 
('KT', N'Kinh tế'), 
('NN', N'Ngoại ngữ'), 
('CK', N'Cơ khí'), 
('XD', N'Xây dựng');
GO

INSERT INTO Lop VALUES 
('KTPM01', N'Kỹ thuật phần mềm 1', 'CNTT'), 
('KHMT01', N'Khoa học máy tính 1', 'CNTT'), 
('QTKD01', N'Quản trị kinh doanh 1', 'KT'), 
('NNA01', N'Ngôn ngữ Anh 1', 'NN'), 
('CKS01', N'Cơ khí số 1', 'CK');
GO

INSERT INTO SinhVien VALUES 
('SV01', N'Nguyễn Văn A', '2002-01-15', 'KTPM01'), 
('SV02', N'Trần Thị B', '2002-05-20', 'KTPM01'), 
('SV03', N'Lê Văn C', '2001-11-10', 'KHMT01'), 
('SV04', N'Phạm Thị D', '2003-03-25', 'QTKD01'), 
('SV05', N'Hoàng Văn E', '2002-08-12', 'NNA01');
GO

INSERT INTO MonHoc VALUES 
('TH01', N'Lập trình C#'), 
('TH02', N'Cơ sở dữ liệu'), 
('KT01', N'Kinh tế vĩ mô'), 
('NN01', N'Tiếng Anh giao tiếp'), 
('TH03', N'Cấu trúc dữ liệu');
GO

INSERT INTO Diem VALUES 
('SV01', 'TH01', 8.5), 
('SV01', 'TH02', 9.0), 
('SV02', 'TH01', 7.0), 
('SV03', 'TH03', 8.0), 
('SV04', 'KT01', 6.5);
GO