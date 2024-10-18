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

exec USP_GetTableList







