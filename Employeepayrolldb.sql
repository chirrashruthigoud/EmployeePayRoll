use Payroll_Service;
select  * from employeep

--update employee salary
alter procedure SpAddEmployeeDetails
@Name nvarchar(200),
@Id int,
@BasicPay float
AS
update employeep set BasicPay=@BasicPay where Name=@Name and Id= @Id
