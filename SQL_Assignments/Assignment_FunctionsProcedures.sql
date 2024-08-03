--1.Create a user-defined function called dbo.fn_AddTwoNumbers that accepts two integer parameters.
--Return the value that is the sum of the two numbers. Test the function.
use MyDb1
create function fn_AddTwoNumbers(@num1 int,@num2 int)
returns int
as
begin
declare @sum int
set @sum=@num1+@num2
return @sum
end
select dbo.fn_AddTwoNumbers(27,45)

--2.Create a user-defined function called dbo.Trim that takes a VARCHAR(250) parameter. This function
--should trim off the spaces from both the beginning and the end of the string. Test the function.

create function Trim(@input varchar(250))
returns varchar(250)
as
begin
return LTRIM(RTRIM(@input))
end
select dbo.Trim('   Hello, World!   ') as TrimmedString
SELECT dbo.Trim('   Leading spaces') AS TrimmedString
SELECT dbo.Trim('Trailing spaces   ') AS TrimmedString
SELECT dbo.Trim('') AS TrimmedString

--3.Create a function dbo.fn_RemoveNumbers that removes any numeric characters from a VARCHAR(250)
CREATE FUNCTION dbo.fn_RemoveNumbers (@input VARCHAR(250))
RETURNS VARCHAR(250)
AS
BEGIN
    DECLARE @output VARCHAR(250) = ''
    DECLARE @i INT = 1
    DECLARE @char CHAR(1)

    WHILE @i <= LEN(@input)
    BEGIN
        SET @char = SUBSTRING(@input, @i, 1)
        IF ISNUMERIC(@char) = 0
        BEGIN
            SET @output = @output + @char
        END
        SET @i = @i + 1
    END

    RETURN @output
END

SELECT dbo.fn_RemoveNumbers('Hello123World') AS Result
SELECT dbo.fn_RemoveNumbers('123@Hello456!') AS Result
SELECT dbo.fn_RemoveNumbers('HelloWorld') AS Result

--4.Write a function called dbo.fn_FormatPhone that takes a string of ten numbers. The function will
--format the string into this phone number format: “(###) ###-####.” Test the function. 
CREATE FUNCTION dbo.fn_FormatPhone (@input VARCHAR(10))
RETURNS VARCHAR(14)
AS
BEGIN
    IF LEN(@input) <> 10 OR ISNUMERIC(@input) = 0
    BEGIN
        RETURN NULL
    END
    RETURN '(' + SUBSTRING(@input, 1, 3) + ') ' + SUBSTRING(@input, 4, 3) + '-' + SUBSTRING(@input, 7, 4)
END

SELECT dbo.fn_FormatPhone('1234567890') AS FormattedPhone
SELECT dbo.fn_FormatPhone('123456789') AS FormattedPhone
SELECT dbo.fn_FormatPhone('12345abcde') AS FormattedPhone

--5.Create a procedure that will take table name and column specification from the user and create the table.
CREATE PROCEDURE dbo.sp_CreateTable
    @TableName NVARCHAR(128),
    @ColumnDefinitions NVARCHAR(MAX)
AS
BEGIN
    DECLARE @SQL NVARCHAR(MAX)

    -- Construct the CREATE TABLE statement
    SET @SQL = N'CREATE TABLE ' + QUOTENAME(@TableName) + N' (' + @ColumnDefinitions + N')'

    -- Execute the CREATE TABLE statement
    EXEC sp_executesql @SQL
END

EXEC dbo.sp_CreateTable
    @TableName = 'TestTable1',
    @ColumnDefinitions = 'Id INT PRIMARY KEY, Name NVARCHAR(50) NOT NULL'

EXEC dbo.sp_CreateTable
    @TableName = 'TestTable2',
    @ColumnDefinitions = 'Id INT PRIMARY KEY, Name NVARCHAR(50) NOT NULL, Age INT, BirthDate DATE, Email NVARCHAR(100)'

EXEC dbo.sp_CreateTable
    @TableName = 'TestTable3',
    @ColumnDefinitions = 'Id INT PRIMARY KEY, Name NVARCHAR(50) NOT NULL, Age INT CHECK (Age >= 0), Salary DECIMAL(18, 2)'

	SELECT TABLE_NAME
FROM INFORMATION_SCHEMA.TABLES
WHERE TABLE_NAME LIKE 'TestTable%'

SELECT TABLE_NAME, COLUMN_NAME, DATA_TYPE
FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = 'TestTable1' OR TABLE_NAME = 'TestTable2' OR TABLE_NAME = 'TestTable3'

--6.. write a procedure that will take source and destination table name as parameter and copy the data
--from source table to destination table
CREATE PROCEDURE dbo.sp_CopyTableData
    @SourceTable NVARCHAR(128),
    @DestinationTable NVARCHAR(128)
AS
BEGIN
    DECLARE @SQL NVARCHAR(MAX)

    -- Construct the INSERT INTO SELECT statement
    SET @SQL = N'INSERT INTO ' + QUOTENAME(@DestinationTable) + N' SELECT * FROM ' + QUOTENAME(@SourceTable)

    -- Execute the INSERT INTO SELECT statement
    EXEC sp_executesql @SQL
END


