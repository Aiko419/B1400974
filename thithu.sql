

CREATE TABLE [dbo].[dbo_nganh]
(
	[MaNganh] [varchar](10)NOT NULL PRIMARY KEY,
	[MaKhoa] [varchar](10) Not NULL,
	[TenNganh] [varchar](50) not NULL,
	[SoNamDT] [int] NULL,
)
GO

CREATE TABLE [dbo].[dbo_monhoc]
(
	[MaMH] [varchar](10)NOT NULL PRIMARY KEY,
	[MaKhoa] [varchar](10) Not NULL,
	[TenMH] [varchar](255) not NULL,
	[SoTC] [int] NULL,
)
GO
CREATE TABLE [dbo].[dbo_khoa]
(
	[MaKhoa] [varchar](10)NOT NULL PRIMARY KEY,
	[TenKhoa] [varchar](50) Not NULL,
	[NgayTL] date,

)
GO

ALTER TABLE [dbo].[dbo_nganh] ADD CONSTRAINT FK_Nganh_Khoa FOREIGN KEY([MaKhoa]) REFERENCES [dbo].[dbo_khoa]([MaKhoa])
ALTER TABLE [dbo].[dbo_monhoc] ADD CONSTRAINT FK_MonHoc_Khoa FOREIGN KEY([MaKhoa]) REFERENCES [dbo].[dbo_khoa]([MaKhoa])