USE [master]
GO
/****** Object:  Database [QuanLyQuanCaPhe]    Script Date: 12/21/2024 11:48:09 PM ******/
CREATE DATABASE [QuanLyQuanCaPhe]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuanLyQuanCaPhe', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\QuanLyQuanCaPhe.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QuanLyQuanCaPhe_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\QuanLyQuanCaPhe_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [QuanLyQuanCaPhe] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLyQuanCaPhe].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLyQuanCaPhe] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLyQuanCaPhe] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLyQuanCaPhe] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLyQuanCaPhe] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLyQuanCaPhe] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLyQuanCaPhe] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [QuanLyQuanCaPhe] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLyQuanCaPhe] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLyQuanCaPhe] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLyQuanCaPhe] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLyQuanCaPhe] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLyQuanCaPhe] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLyQuanCaPhe] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLyQuanCaPhe] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLyQuanCaPhe] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QuanLyQuanCaPhe] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLyQuanCaPhe] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLyQuanCaPhe] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLyQuanCaPhe] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLyQuanCaPhe] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLyQuanCaPhe] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLyQuanCaPhe] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLyQuanCaPhe] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QuanLyQuanCaPhe] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLyQuanCaPhe] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLyQuanCaPhe] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuanLyQuanCaPhe] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuanLyQuanCaPhe] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QuanLyQuanCaPhe] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QuanLyQuanCaPhe] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [QuanLyQuanCaPhe] SET QUERY_STORE = ON
GO
ALTER DATABASE [QuanLyQuanCaPhe] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [QuanLyQuanCaPhe]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 12/21/2024 11:48:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[UserName] [nvarchar](100) NOT NULL,
	[DisplayName] [nvarchar](100) NOT NULL,
	[Password] [nvarchar](1000) NOT NULL,
	[Type] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Bill]    Script Date: 12/21/2024 11:48:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bill](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[DateCheckIn] [datetime] NOT NULL,
	[DateCheckOut] [date] NULL,
	[idTable] [int] NOT NULL,
	[status] [int] NOT NULL,
	[timeCheckIn] [time](0) NULL,
	[timeCheckOut] [time](0) NULL,
	[discount] [int] NULL,
	[totalPrice] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BillInfo]    Script Date: 12/21/2024 11:48:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BillInfo](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[quantity] [int] NOT NULL,
	[idBill] [int] NOT NULL,
	[idFood] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Food]    Script Date: 12/21/2024 11:48:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Food](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](100) NOT NULL,
	[idCategory] [int] NOT NULL,
	[price] [float] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FoodCategory]    Script Date: 12/21/2024 11:48:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FoodCategory](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](100) NOT NULL,
	[isAvailable] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TableFood]    Script Date: 12/21/2024 11:48:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TableFood](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](100) NOT NULL,
	[status] [nvarchar](100) NULL,
	[isActive] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Account] ([UserName], [DisplayName], [Password], [Type]) VALUES (N'123', N'1223', N'33354741122871651676713774147412831195', 1)
INSERT [dbo].[Account] ([UserName], [DisplayName], [Password], [Type]) VALUES (N'abc', N'abc', N'33354741122871651676713774147412831195', 1)
INSERT [dbo].[Account] ([UserName], [DisplayName], [Password], [Type]) VALUES (N'admin', N'admin', N'33354741122871651676713774147412831195', 1)
INSERT [dbo].[Account] ([UserName], [DisplayName], [Password], [Type]) VALUES (N'NgoVanDuc', N'NgoDuc', N'33354741122871651676713774147412831195', 0)
INSERT [dbo].[Account] ([UserName], [DisplayName], [Password], [Type]) VALUES (N'NguyenVanHieu', N'NguyenHieu', N'33354741122871651676713774147412831195', 1)
GO
SET IDENTITY_INSERT [dbo].[Food] ON 

INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (2, N'Cà phê đen', 1, 30000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (3, N'Cà phê sữa', 1, 25000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (4, N'Cà phê phin', 1, 50000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (5, N'Trà xanh', 1, 30000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (6, N'Trà đào', 1, 30000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (7, N'Bánh mì', 2, 20000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (8, N'Bánh bông lan', 2, 30000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (9, N'Cánh gà', 2, 30000)
INSERT [dbo].[Food] ([id], [name], [idCategory], [price]) VALUES (10, N'Đùi gà', 2, 30000)
SET IDENTITY_INSERT [dbo].[Food] OFF
GO
SET IDENTITY_INSERT [dbo].[FoodCategory] ON 

INSERT [dbo].[FoodCategory] ([id], [name], [isAvailable]) VALUES (1, N'Đồ uống', 1)
INSERT [dbo].[FoodCategory] ([id], [name], [isAvailable]) VALUES (2, N'Đồ ăn nhẹ', 1)
SET IDENTITY_INSERT [dbo].[FoodCategory] OFF
GO
SET IDENTITY_INSERT [dbo].[TableFood] ON 

INSERT [dbo].[TableFood] ([id], [name], [status], [isActive]) VALUES (1, N'Bàn 0', N'Trống', 1)
INSERT [dbo].[TableFood] ([id], [name], [status], [isActive]) VALUES (2, N'Bàn 1', N'Trống', 1)
INSERT [dbo].[TableFood] ([id], [name], [status], [isActive]) VALUES (3, N'Bàn 2', N'Trống', 1)
INSERT [dbo].[TableFood] ([id], [name], [status], [isActive]) VALUES (4, N'Bàn 3', N'Trống', 1)
INSERT [dbo].[TableFood] ([id], [name], [status], [isActive]) VALUES (5, N'Bàn 4', N'Trống', 1)
INSERT [dbo].[TableFood] ([id], [name], [status], [isActive]) VALUES (6, N'Bàn 5', N'Trống', 1)
INSERT [dbo].[TableFood] ([id], [name], [status], [isActive]) VALUES (7, N'Bàn 6', N'Trống', 1)
INSERT [dbo].[TableFood] ([id], [name], [status], [isActive]) VALUES (8, N'Bàn 7', N'Trống', 1)
INSERT [dbo].[TableFood] ([id], [name], [status], [isActive]) VALUES (9, N'Bàn 8', N'Trống', 1)
INSERT [dbo].[TableFood] ([id], [name], [status], [isActive]) VALUES (10, N'Bàn 9', N'Trống', 1)
INSERT [dbo].[TableFood] ([id], [name], [status], [isActive]) VALUES (11, N'Bàn 10', N'Trống', 1)
SET IDENTITY_INSERT [dbo].[TableFood] OFF
GO
ALTER TABLE [dbo].[Bill] ADD  DEFAULT (getdate()) FOR [DateCheckIn]
GO
ALTER TABLE [dbo].[Bill] ADD  DEFAULT ((0)) FOR [status]
GO
ALTER TABLE [dbo].[Bill] ADD  DEFAULT ((0)) FOR [discount]
GO
ALTER TABLE [dbo].[FoodCategory] ADD  DEFAULT ((1)) FOR [isAvailable]
GO
ALTER TABLE [dbo].[TableFood] ADD  DEFAULT (N'Trống') FOR [status]
GO
ALTER TABLE [dbo].[TableFood] ADD  DEFAULT ((1)) FOR [isActive]
GO
ALTER TABLE [dbo].[Bill]  WITH CHECK ADD FOREIGN KEY([idTable])
REFERENCES [dbo].[TableFood] ([id])
GO
ALTER TABLE [dbo].[BillInfo]  WITH CHECK ADD FOREIGN KEY([idBill])
REFERENCES [dbo].[Bill] ([id])
GO
ALTER TABLE [dbo].[BillInfo]  WITH CHECK ADD FOREIGN KEY([idFood])
REFERENCES [dbo].[Food] ([id])
GO
ALTER TABLE [dbo].[Food]  WITH CHECK ADD FOREIGN KEY([idCategory])
REFERENCES [dbo].[FoodCategory] ([id])
GO
/****** Object:  StoredProcedure [dbo].[USP_GetListBillByDate]    Script Date: 12/21/2024 11:48:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




create proc [dbo].[USP_GetListBillByDate]
@checkIn date, @checkOut date
as
begin
	select t.name as [Tên bàn], FORMAT(DateCheckIn, 'dd/MM/yyyy') AS [Ngày vào], timeCheckIn [Giờ vào],timeCheckOut[Giờ về], discount[Giảm giá(%)] , b.totalPrice[Đã thanh toán]
	from Bill as b, TableFood as t
	where DateCheckIn >= @checkIn and DateCheckOut <= @checkOut and b.status = 1
	and t.id = b.idTable
	order by b.id desc
end
GO
/****** Object:  StoredProcedure [dbo].[USP_GetListTable]    Script Date: 12/21/2024 11:48:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[USP_GetListTable]
as
begin
	select id as [ID], name as [Tên bàn], status as [Trạng thái] from TableFood
end
GO
/****** Object:  StoredProcedure [dbo].[USP_GetPeopleByUserName]    Script Date: 12/21/2024 11:48:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[USP_GetPeopleByUserName]
@userName nvarchar(100)
as
begin
	select *from Account Where UserName = @userName 
end
GO
/****** Object:  StoredProcedure [dbo].[USP_GetTableList]    Script Date: 12/21/2024 11:48:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create proc [dbo].[USP_GetTableList]
as select * from TableFood where isActive = 1
GO
/****** Object:  StoredProcedure [dbo].[USP_InserBill]    Script Date: 12/21/2024 11:48:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USP_InserBill]
@idTable int
as
begin
	insert into Bill(DateCheckIn, DateCheckOut, idTable, status, discount, timeCheckIn)
	values (getdate(),null, @idTable, 0,0, getdate())
end
GO
/****** Object:  StoredProcedure [dbo].[USP_InsertBillInfo]    Script Date: 12/21/2024 11:48:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create PROC [dbo].[USP_InsertBillInfo]
@idBill INT, @idFood INT, @count INT
AS 
BEGIN
	DECLARE @isExitsBillInfo INT
	DECLARE @foodCount INT = 1
	SELECT @isExitsBillInfo = id, @foodCount = b.quantity FROM BillInfo AS b WHERE idBill = @idBill AND idFood = @idFood
	IF (@isExitsBillInfo > 0)
	BEGIN
		DECLARE @newCount INT = @foodCount + @count
		IF (@newCount > 0)
			UPDATE BillInfo SET quantity = @foodCount + @count WHERE idFood = @idFood AND idBill = @idBill
		ELSE
			DELETE BillInfo WHERE idBill = @idBill AND idFood = @idFood
	END
	ELSE
	BEGIN
		INSERT BillInfo(idBill, idFood, quantity)
		VALUES (@idBill, @idFood, @count)
	END
END
GO
/****** Object:  StoredProcedure [dbo].[USP_Login]    Script Date: 12/21/2024 11:48:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[USP_Login]
@userName nvarchar(100), @passWord nvarchar(100)
as
begin
	select * from Account where UserName = @userName and Password = @passWord 
end
GO
/****** Object:  StoredProcedure [dbo].[USP_SwitchTable]    Script Date: 12/21/2024 11:48:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO





create proc [dbo].[USP_SwitchTable]
@idTable1 int, @idTable2 int
as
begin
	declare @idFirstBill int
	declare @idSecondBill int
	declare @isFirstTableEmpty int = 1
	declare @isSecondTableEmpty int = 1


	select @idSecondBill = id from Bill where idTable = @idTable2 and status = 0
	select @idFirstBill = id from Bill where idTable = @idTable1 and status = 0




	if(@idFirstBill is null)
	begin
		insert Bill (DateCheckIn,DateCheckOut,idTable,status, timeCheckIn)
		values (getdate(),null,@idTable1,0,GETDATE())
	
		select @idFirstBill = max(id) from Bill Where idTable = @idTable1 and status = 0

		

	end
	select @isFirstTableEmpty = count(*) from BillInfo where idBill = @idFirstBill



	if(@idSecondBill is null)
	begin
		insert Bill (DateCheckIn,DateCheckOut,idTable,status,timeCheckIn)
		values (getdate(),null,@idTable2,0,getdate())
	
		select @idSecondBill = max(id) from Bill Where idTable = @idTable2 and status = 0

	

	end
		select @isSecondTableEmpty = count(*) from BillInfo where idBill = @idSecondBill




	select id into IDBillInfoTable from BillInfo where idBill = @idSecondBill
	update BillInfo set idBill = @idSecondBill where idBill = @idFirstBill
	update BillInfo set idBill = @idFirstBill where id in (select *from IDBillInfoTable)

	drop table IDBillInfoTable

	if(@isFirstTableEmpty = 0)
	begin
		update TableFood set status = N'Trống' where id = @idTable2
	end

	if(@isSecondTableEmpty = 0)
	begin
		update TableFood set status = N'Trống' where id = @idTable1
	end

end
GO
/****** Object:  StoredProcedure [dbo].[USP_UpdateAccount]    Script Date: 12/21/2024 11:48:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create proc [dbo].[USP_UpdateAccount]
@userName nvarchar(100), @displayName nvarchar(100), @password nvarchar(100),
@newPassword nvarchar(100)
as
begin
	declare @isCorrectPassword int

	select @isCorrectPassword = count (*) from Account where @userName = UserName and @password = Password

	if(@isCorrectPassword = 1)
		begin
			if(@newPassword = null or @newPassword = '')
				begin
					update Account set DisplayName = @displayName where UserName = @userName
				end
			else 
				begin
						update Account set DisplayName = @displayName, Password = @newPassword where UserName = @userName
				end
		end

end
GO
USE [master]
GO
ALTER DATABASE [QuanLyQuanCaPhe] SET  READ_WRITE 
GO
