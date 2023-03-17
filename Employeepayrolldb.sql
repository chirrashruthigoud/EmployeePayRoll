use Payroll_Service;
select  * from employeep

--update employee salary
alter procedure SpAddEmployeeDetails
@Name nvarchar(200),
@Id int,
@BasicPay float
AS
update employeep set BasicPay=@BasicPay where Name=@Name and Id= @Id
select  * from employeep

--update employee salary
alter procedure SpAddEmployeeDetails
@Name nvarchar(200),
@Id int,
@BasicPay float
AS
update employeep set BasicPay=@BasicPay where Name=@Name and Id= @Id

alter procedure SpAddEmployeeDetails
@Name nvarchar(200),
@BasicPay float,
@PhoneNumber bigInt,
@Address varchar(200),
@Department varchar(100)
AS
insert into employeep(Name,BasicPay,PhoneNumber,Address,Department)values (@Name,@BasicPay,@PhoneNumber,@Address,@Department);
