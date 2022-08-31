]--use w3schools;
--select * from products;

--go
--create procedure spGetProductByName
--@ProductName nvarchar(20)
--as begin 
--select * from products where ProductName like @ProductName + '%'
--end;

--go
--spGetProductByName 'ch'

--go
--create procedure spAddProduct
--@ProductID int,
--@ProductName varchar(255),
--@SupplierID int,
--@CategoryID int,
--@Unit varchar(255),
--@Price float
--as 
--Begin
--insert into products values (@ProductID, @ProductName, @SupplierID, @CategoryID, @Unit, @Price)
--Select @ProductID = SCOPE_IDENTITY()
--End

--Declare @PId int

--execute spAddProduct 'Chaisss',1,1,'10 boxes x 20 bags',20


--insert into products values (@ProductID, @ProductName, @SupplierID, @CategoryID, @Unit, @Price)



use Sample;
select * from student


create table employee 
(EId int IDENTITY(1,1) primary key, 
FirstName nvarchar(20), 
LastName nvarchar(20),
Gender nvarchar(7), 
Salary numeric,
check (Gender in ('Male','Female', 'Unknown')))


insert into employee values ('janvi', 'desai', 'Female', 35000)

select * from employee

go 
create procedure spADDEmployee
@FN nvarchar(20),
@LN nvarchar(20),
@gender nvarchar(7),
@salary numeric
as
Begin
insert into employee values (@FN, @LN, @gender, @salary)
end

drop procedure spADDEmployee

go
execute spADDEmployee 'Hardi', 'Goyani', 'Female', 35500
execute spADDEmployee 'Nishita', 'Kalayani', 'Female', 32500
execute spADDEmployee 'Rishit', 'Kalayani', 'Male', 35000




Select EId,FirstName,LastName,Gender,Salary from employee


--drop table employee

use Sample
select * from employee

go
create procedure spGetEmployee
as 
begin 
select * from employee
end


exec spGetEmployee 

drop procedure spGetEmployee


go
create procedure spGetEmployeeById
@id int
as 
begin 
select * from employee where EId = @id
end

exec spGetEmployeeById 1

go
create procedure spGetData
as
begin 
select * from employee

select * from student
end


exec spGetData


go
create procedure getStudentInfo
@id int,
@name nvarchar(30),
@gender nvarchar(10), 
@Marks int
as
Begin
update StudentInfo set Full_Name = @name, gender = @gender, Total_Marks = @Marks where StudentId = @id;
End;


drop procedure getStudentInfo