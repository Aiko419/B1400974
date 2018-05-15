CREATE TABLE lopchuyennganh
(
	MaLop int NOT NULL,
	TenLop nvarchar(100) NOT NULL,
	CONSTRAINT Pk_lopchuyennganh PRIMARY KEY (MaLop) 
)

GO
CREATE TABLE sinhvien
(
	MSSV int NOT NULL,
	HoTen nvarchar(50) NOT NULL,
	NgaySinh date NOT NULL,
	QueQuan nvarchar(100) NOT NULL,
	MaLop int NOT NULL,
	CONSTRAINT Pk_sinhvien PRIMARY KEY (MSSV) 
)

GO

ALTER TABLE sinhvien ADD CONSTRAINT FK_sinhvien_lopchuyennganh FOREIGN KEY(MaLop) REFERENCES lopchuyennganh(MaLop)


