create database QuanLyQuanCaPhe
go

use QuanLyQuanCaPhe
go


create table TableFood -- bàn thức ăn
(
	id int identity primary key ,
	name nvarchar(100) not null, 
	status nvarchar(100) default N'Trống'-- trạng thái của bàn, ví dụ : bàn trống hay bàn có người
)



create table Account
(
	UserName nvarchar(100) primary key , 
	DisplayName nvarchar(100) not null,  -- tên hiện thị 
	Password nvarchar(1000) not null,
	Type int not null,  -- loại tài khoản
)

create table FoodCategory  -- Danh sách đồ ăn
(
	id int identity primary key,
	name nvarchar(100) not null
)

create table Food
(
	id int identity primary key,
	name nvarchar(100) not null,
	idCategory int foreign key references FoodCategory(id) not null,
	price float not null
)


create table Bill
(
	id int identity primary key,
	DateCheckIn date not null default getdate() ,
	DateCheckOut date,
	idTable int foreign key references TableFood(id) not null,
	status int not null default 0, -- 1 : đã thanh toán || 0 : chưa thanh toán
)



create table BillInfo
(
	id int identity primary key,
	quantity int not null,
	idBill int foreign key references Bill(id) not null,
	idFood int foreign key references Food(id) not null,

)


insert into Account (UserName, DisplayName, Password, Type)
values ('NgoVanDuc', 'NgoDuc', 'ngovanduc@123',0),
		('NguyenVanHieu','NguyenHieu','nguyenvanhieu@123',1),
		('admin','admin','admin',1)

go

create proc USP_GetPeopleByUserName
@userName nvarchar(100)
as
begin
	select *from Account Where UserName = @userName 
end
go

create proc USP_Login
@userName nvarchar(100), @passWord nvarchar(100)
as
begin
	select * from Account where UserName = @userName and Password = @passWord 
end
go
--thêm bàn
declare @i int = 0
while @i <= 10
begin
	insert TableFood(name)
	values (N'Bàn ' + CAST( @i as nvarchar(100)))
	set @i = @i + 1
end
go


create proc USP_GetTableList
as select * from TableFood
go


--thêm category
insert FoodCategory (name)
values (N'Đồ uống'),
		(N'Đồ ăn nhẹ')

go

--thêm món ăn
insert into Food(name, idCategory, price)
values (N'Cà phê đen', 5, 30000),
		(N'Cà phê sữa', 5, 25000),
		(N'Cà phê phin', 5, 50000),
		(N'Trà xanh', 5, 30000),
		(N'Trà đào', 5, 30000),
		(N'Bánh mì', 6, 20000),
		(N'Bánh bông lan', 6, 30000),
		(N'Cánh gà', 6, 30000),
		(N'Đùi gà', 6, 30000)
go

		


--thêm bill
insert into Bill (DateCheckIn, DateCheckOut , idTable , status)
values (GETDATE(), null , 1, 0),
		(GETDATE(), null , 2, 0),
		(GETDATE(), GETDATE() , 3, 1),
		(GETDATE(), GETDATE() , 4, 1)
go


--thêm billinfo
insert BillInfo
values (2,4,5),
		(3,2,4),
		(1,1,3),
		(4,1,3)
go

select * from BillInfo
select * from Bill
select * from Food


create proc USP_InserBill
@idTable int
as
begin
	insert into Bill(DateCheckIn, DateCheckOut, idTable, status)
	values (getdate(),null, @idTable, 0)
end
go


ALTER PROC USP_InsertBillInfo
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




select * from FoodCategory
select * from Food
select * from Bill
select * from BillInfo



