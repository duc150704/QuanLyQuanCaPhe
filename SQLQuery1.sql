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

alter table Bill
add timeCheckIn time(0), timeCheckOut time(0)


alter table Bill add totalPrice Float
go


alter table TableFood
add isActive bit default 0
go

update TableFood set isActive = 1
go

select * from TableFood


alter table Bill
add discount int
go


update Bill set discount = 0
go



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


alter proc USP_GetTableList
as select * from TableFood where isActive = 1
go



select * from Bill

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


create proc USP_InserBill
@idTable int
as
begin
	insert into Bill(DateCheckIn, DateCheckOut, idTable, status, discount, timeCheckIn)
	values (getdate(),null, @idTable, 0,0, getdate())
end
go


create PROC USP_InsertBillInfo
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


create trigger UTG_UpdateBillInfo
on BillInfo for insert, update
as
begin
	declare @idBill int

	select @idBill = idBill from inserted

	declare @idTable int

	select @idTable = idTable from Bill where id = @idBill and status = 0

	declare @count int
	select @count = count (*) from BillInfo where idBill = @idBill

	if(@count > 0)
		begin
			update TableFood set status = N'Có người' where id = @idTable
		end
	else 
		begin
			update TableFood set status = N'Trống' where id = @idTable
		end

end
go

create trigger UTG_UpdateBill
on Bill for update
as
begin
	declare @idBill int

	select @idBill = id from inserted

	declare @idTable int

	select @idTable = idTable from Bill where id = @idBill

	declare @count int = 0

	select @count = count(*) from Bill where idTable = @idTable and status = 0
	
	if(@count = 0)
		update TableFood set status = N'Trống' where id = @idTable

end
go





create proc USP_SwitchTable
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
go




create proc USP_GetListBillByDate
@checkIn date, @checkOut date
as
begin
	select t.name as [Tên bàn], FORMAT(DateCheckIn, 'dd/MM/yyyy') AS [Ngày vào], timeCheckIn [Giờ vào],timeCheckOut[Giờ về], discount[Giảm giá(%)] , b.totalPrice[Đã thanh toán]
	from Bill as b, TableFood as t
	where DateCheckIn >= @checkIn and DateCheckOut <= @checkOut and b.status = 1
	and t.id = b.idTable
	order by b.id desc
end
go


create proc USP_UpdateAccount
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
go

CREATE TRIGGER UTG_DeleteBillInfo
ON dbo.BillInfo FOR DELETE
AS 
BEGIN
	DECLARE @idBillInfo INT
	DECLARE @idBill INT
	SELECT @idBillInfo = id, @idBill = Deleted.idBill FROM Deleted
	
	DECLARE @idTable INT
	SELECT @idTable = idTable FROM dbo.Bill WHERE id = @idBill
	
	DECLARE @count INT = 0
	
	SELECT @count = COUNT(*) FROM dbo.BillInfo AS bi, dbo.Bill AS b WHERE b.id = bi.idBill AND b.id = @idBill AND b.status = 0
	
	IF (@count = 0)
		UPDATE dbo.TableFood SET status = N'Trống' WHERE id = @idTable
END
GO

create proc USP_GetListTable
as
begin
	select id as [ID], name as [Tên bàn], status as [Trạng thái] from TableFood
end
go

ALTER TABLE FoodCategory
ADD isAvailable bit;



update FoodCategory
set isAvailable = 1


select * from BillInfo


