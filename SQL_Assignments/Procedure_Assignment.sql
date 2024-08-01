create table Product(Pid int primary key,PName varchar(20) unique not null, Price int, Stock int)



create procedure InsertProduct(@PName varchar(20),@Price int, @Stock int)
as
begin
	declare @Pid int
	if(exists(select * from Product))
		begin
			select @Pid=Max(Pid) from Product
			set @Pid=@Pid+1
		end
	else
		begin
			set @Pid=1
		end
		insert into Product values(@Pid,@PName,@Price,@Stock)
end

exec InsertProduct 'Chocolate', 85, 125
exec InsertProduct 'Biscuit', 20, 30

select * from Product


-- 1.  GetAllProducts
create procedure GetAllProducts
as 
begin
select * from Product
end

exec  GetAllProducts

-- 2.  GetProductByName
create procedure  GetProductByName(@name varchar(20))
as 
begin
select * from Product where pname=@name
end

exec GetProductByName 'adaptor'

-- 3. GetAllProductsBy>input Price

create procedure GetAllProductsByPrice1(@price int)
as 
begin
select * from Product where price>@price
end
exec GetAllProductsByPrice1 '100'


-- 4. DeleteProductById
create procedure  DeleteProductById(@id int)
as
begin
delete Product where pid=@id
end
exec  DeleteProductById '2'

-- 5. UpdateProduct(Update Price and Stock of the Product using Pid)
create procedure UpdateProduct(@id int)
as
begin
update Product set price=1000,stock =100 where pid=@id
end

exec UpdateProduct 4

select * from Product