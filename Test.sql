create database Test
go
use Test
go
create table ACCOUNT
(
	USERNAME NVARCHAR(100) PRIMARY KEY,
	DISPLAYNAME NVARCHAR(100) NOT NULL,
	PASSWORD NVARCHAR(100) NOT NULL,
	TYPE TINYINT NOT NULL
)
GO
CREATE TABLE TABLEFOOD
(
	ID INT IDENTITY PRIMARY KEY,
	NAME NVARCHAR(100),
	STATUS TINYINT NOT NULL,--0: TRỐNG,1: ĐÃ CÓ KHÁCH--
)
GO
CREATE TABLE FOODCATEGORY --LOẠI THỨC ĂN--
(
	ID INT IDENTITY PRIMARY KEY,
	NAME NVARCHAR(100)
)
GO
CREATE TABLE FOOD
(
	ID INT IDENTITY PRIMARY KEY,
	NAME NVARCHAR(100) NOT NULL,
	IDCATEGORY INT NOT NULL,
	PRICE MONEY,
	FOREIGN KEY (IDCATEGORY) REFERENCES dbo.FOODCATEGORY(ID)
)
GO
CREATE TABLE BILL
(
	ID INT IDENTITY PRIMARY KEY,
	DATECHECKIN DATE,
	DATECHECKOUT DATE,
	IDTABLE INT NOT NULL,
	STATUS INT NOT NULL --1:ĐÃ THANH TOÁN, 0:CHƯA THANH TOÁN
	FOREIGN KEY (IDTABLE) REFERENCES dbo.TABLEFOOD(ID)
)
GO
CREATE TABLE BILLINFO
(
	ID INT IDENTITY PRIMARY KEY NOT NULL,
	IDBILL INT NOT NULL,
	IDFOOD INT NOT NULL,
	COUNT INT NOT NULL DEFAULT 0
	FOREIGN KEY (IDBILL) REFERENCES DBO.BILL(ID),
	FOREIGN KEY (IDFOOD) REFERENCES DBO.FOOD(ID)
)
GO

insert into dbo.ACCOUNT
			(USERNAME,
			DISPLAYNAME,
			PASSWORD,
			TYPE)
values (N'N2',N'Nhat',N'1',1)

insert into dbo.ACCOUNT
			(USERNAME,
			DISPLAYNAME,
			PASSWORD,
			TYPE)
values (N'staff',N'staff',N'1',0)
go

create proc USP_GetListAccountByUserName
@username nvarchar(100)
As
begin
	select * from dbo.ACCOUNT where UserName = @username
end
go

exec dbo.USP_GetListAccountByUserName @username = N'N2' 

 --Add bàn vào form chính
declare @i int =0
while @i<=15
begin
	insert TABLEFOOD(name,STATUS) values (N'Bàn '+ cast(@i as nvarchar(100)),0)
	set @i=@i+1
end
select*from TABLEFOOD

Create proc USP_GetTableList
as select * from dbo.TABLEFOOD
go
update  dbo.TABLEFOOD set status =1 where ID= 18
exec dbo.USP_GetTableList
go

---Tạo bảo mật đăng nhập:
create proc USP_Login
@userName nvarchar(100), @passWord nvarchar(100)
as
begin
	select * from dbo.ACCOUNT where USERNAME=@userName and PASSWORD=@passWord
end 
go
select*from TABLEFOOD
select*from TABLEFOOD