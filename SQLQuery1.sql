create database QuanLyQuanCaPhe
go

use QuanLyQuanCaPhe
go


create table TableFood -- bàn thức ăn
(
	id int primary key,
	name nvarchar(100) not null, 
	status nvarchar(100) not null  default N'Trống'-- trạng thái của bàn, ví dụ : bàn trống hay bàn có người
)

create table Account
(
	UserName nvarchar(100) primary key not null , 
	DisplayName nvarchar(100) not null,  -- tên hiện thị 
	Password nvarchar(1000) not null,
	Type int not null,  -- loại tài khoản
)

create table FoodCategory  -- Danh sách đồ ăn
(
	id int primary key,
	name nvarchar(100) not null
)

create table Food
(
	id int primary key,
	name nvarchar(100) not null,
	idCategory int foreign key references FoodCategory(id) not null,
	price float not null
)


create table Bill
(
	id int primary key,
	DateCheckIn date not null default getdate() ,
	DateCheckOut date,
	idTable int foreign key references TableFood(id) not null,
	status int not null default 0, -- 1 : đã thanh toán || 0 : chưa thanh toán
)



create table BillInfo
(
	id int primary key,
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
	insert TableFood(id,name)
	values (@i, N'Bàn ' + CAST( @i as nvarchar(100)))
	set @i = @i + 1
end
go

create proc USP_GetTableList
as select * from TableFood
go


--thêm category
insert FoodCategory (id,name)
values (0,N'Đồ uống'),
		(1,N'Đồ ăn nhẹ')

go

--thêm món ăn
insert into Food(id,name, idCategory, price)
values (0,N'Cà phê đen', 0, 30000),
		(1,N'Cà phê sữa', 0, 25000),
		(2,N'Cà phê phin', 0, 50000),
		(3,N'Trà xanh', 0, 30000),
		(4,N'Trà đào', 0, 30000),
		(5,N'Bánh mì', 1, 20000),
		(6,N'Bánh bông lan', 1, 30000),
		(8,N'Cánh gà', 1, 30000),
		(9,N'Đùi gà', 1, 30000)
go
		


--thêm bill
insert into Bill
values (0,GETDATE(), null , 1, 0),
		(1,GETDATE(), null , 2, 0),
		(2,GETDATE(), GETDATE() , 3, 1),
		(3,GETDATE(), GETDATE() , 4, 1)
go


--thêm billinfo
insert BillInfo
values (0,2,0,5),
		(1,3,2,4),
		(2,1,1,2),
		(3,4,3,1)
go

select * from FoodCategory
select * from Food
select * from Bill
select * from BillInfo


