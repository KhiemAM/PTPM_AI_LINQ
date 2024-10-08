create database QLSINHVIEN_PTPM_AI
USE QLSINHVIEN_PTPM_AI
GO
/****** Object:  Table [dbo].[Diem]    Script Date: 24/06/2020 12:59:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Diem](
	[MaSinhVien] [varchar](50) NOT NULL,
	[MaMonHoc] [varchar](50) NOT NULL,
	[Diem] [float] NULL,
 CONSTRAINT [PK_Diem] PRIMARY KEY CLUSTERED 
(
	[MaSinhVien] ASC,
	[MaMonHoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Khoa]    Script Date: 24/06/2020 12:59:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Khoa](
	[MaKhoa] [varchar](50) NOT NULL,
	[TenKhoa] [nvarchar](100) NULL,
 CONSTRAINT [PK_Khoa] PRIMARY KEY CLUSTERED 
(
	[MaKhoa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Lop]    Script Date: 24/06/2020 12:59:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Lop](
	[MaLop] [varchar](50) NOT NULL,
	[TenLop] [nvarchar](100) NULL,
	[MaKhoa] [varchar](50) NULL,
 CONSTRAINT [PK_Lop] PRIMARY KEY CLUSTERED 
(
	[MaLop] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MonHoc]    Script Date: 24/06/2020 12:59:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MonHoc](
	[MaMonHoc] [varchar](50) NOT NULL,
	[TenMonHoc] [nvarchar](100) NULL,
 CONSTRAINT [PK_MonhHoc] PRIMARY KEY CLUSTERED 
(
	[MaMonHoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SinhVien]    Script Date: 24/06/2020 12:59:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SinhVien](
	[MaSinhVien] [varchar](50) NOT NULL,
	[HoTen] [nvarchar](100) NULL,
	[NgaySinh] [datetime] NULL,
	[MaLop] [varchar](50) NULL,
 CONSTRAINT [PK_SinhVien] PRIMARY KEY CLUSTERED 
(
	[MaSinhVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Khoa] ([MaKhoa], [TenKhoa]) VALUES (N'CNSH', N'Sinh hoc')
INSERT [dbo].[Khoa] ([MaKhoa], [TenKhoa]) VALUES (N'CNTP', N'Cong nghe thuc pham')
INSERT [dbo].[Khoa] ([MaKhoa], [TenKhoa]) VALUES (N'CNTT', N'Cong nghe thong tin')
INSERT [dbo].[Khoa] ([MaKhoa], [TenKhoa]) VALUES (N'HH', N'Hoa Hoc')
INSERT [dbo].[Lop] ([MaLop], [TenLop], [MaKhoa]) VALUES (N'18CDTH1', N'18 cao dang tin hoc 1', N'CNTT')
ALTER TABLE [dbo].[Diem]  WITH CHECK ADD  CONSTRAINT [FK_Diem_MonHoc] FOREIGN KEY([MaMonHoc])
REFERENCES [dbo].[MonHoc] ([MaMonHoc])
GO
ALTER TABLE [dbo].[Diem] CHECK CONSTRAINT [FK_Diem_MonHoc]
GO
ALTER TABLE [dbo].[Diem]  WITH CHECK ADD  CONSTRAINT [FK_Diem_SinhVien] FOREIGN KEY([MaSinhVien])
REFERENCES [dbo].[SinhVien] ([MaSinhVien])
GO
ALTER TABLE [dbo].[Diem] CHECK CONSTRAINT [FK_Diem_SinhVien]
GO
ALTER TABLE [dbo].[Lop]  WITH CHECK ADD  CONSTRAINT [FK_Lop_Khoa] FOREIGN KEY([MaKhoa])
REFERENCES [dbo].[Khoa] ([MaKhoa])
GO
ALTER TABLE [dbo].[Lop] CHECK CONSTRAINT [FK_Lop_Khoa]
GO
ALTER TABLE [dbo].[SinhVien]  WITH CHECK ADD  CONSTRAINT [FK_SinhVien_Lop] FOREIGN KEY([MaLop])
REFERENCES [dbo].[Lop] ([MaLop])
GO
ALTER TABLE [dbo].[SinhVien] CHECK CONSTRAINT [FK_SinhVien_Lop]
GO


select * from SinhVien
select * from MonHoc
select * from Diem
select * from Lop
select * from Khoa

set dateformat DMY
insert into SinhVien values ('2001210783', 'Huynh Quang Khiem', '09-02-2003', '18CDTH1')
insert into SinhVien values ('2001210784', 'Nguyen Duc Hien', '09-02-2003', '18CDTH1')
insert into SinhVien values ('2001210785', 'Phan Gia huy', '09-02-2003', '18CDTH1')
insert into SinhVien values ('2001210786', 'Le Hai Trieu', '09-02-2003', '18CDTH1')
insert into SinhVien values ('2001210787', 'Pham Tuan Han', '09-02-2003', '18CDTH1')


insert into MonHoc values ('CTDL', 'Cau truc du lieu')
insert into MonHoc values ('HDT', 'Huong doi tuong')
insert into MonHoc values ('LTW', 'Lap trinh windows')
insert into MonHoc values ('NNLT', 'Ngon ngu lap trinh')	

insert into Lop values ('12DHTH01', '12 Dai hoc thong tin 01', 'CNTT')
insert into Lop values ('12DHTH02', '12 Dai hoc thong tin 02', 'CNTT')
insert into Lop values ('12DHTH03', '12 Dai hoc thong tin 03', 'CNTT')
insert into Lop values ('12DHTH04', '12 Dai hoc thong tin 04', 'CNTT')
insert into Lop values ('12DHTH05', '12 Dai hoc thong tin 05', 'CNTT')
insert into Lop values ('12DHTP01', '12 Dai hoc thuc pham 01', 'CNTP')
insert into Lop values ('12DHTP02', '12 Dai hoc thuc pham 02', 'CNTP')
insert into Lop values ('12DHTP03', '12 Dai hoc thuc pham 03', 'CNTP')
insert into Lop values ('12DHTP04', '12 Dai hoc thuc pham 04', 'CNTP')
insert into Lop values ('12DHTP05', '12 Dai hoc thuc pham 05', 'CNTP')