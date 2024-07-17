--creating database
create database Assignment1

--Creating tables Customers, Orders
use Assignment1
create table Customers(Customerid char(5) not null,CompanyName varchar(40) not null,
ContactName char(30),
[Address] varchar(60),
City char(15),
Phone char(24),
Fax char(24)
)
GO

create table Orders
(
OrderId int not null,
customerId char(5) not null,
Orderdate datetime,
Shippeddate datetime,
Freight money,
Shipname varchar(40),
Shipaddres varchar(60),
Quantity int null 
)
GO

--adding new column to Orders
alter table Orders add shipregion int not null

-- change the data type of the column shipregion from INTEGER to CHARACTER with length 8
alter table Orders alter column shipregion char(8) null

--Delete the formerly created column shipregion.
alter table Orders drop column shipregion

--instert a new row into the Orders
insert into Orders values ( 10, 'ord01', getdate(), getdate(), 100.0, 'Windstar', 'Ocean' ,1)
select * from Orders

-- add the current system date and time as the default value to the orderdate column
alter table Orders add constraint orderdate_default default getdate() for [orderdate]

--check names of the constraints of orderdate from Orders table
sp_helpconstraint Orders

--Rename the city column of the Customers table. The new name is Town. 
sp_rename 'Customers.City', 'Town'