use Payroll_Service;

create database payroll_service


create table employeep
(
Id int identity primary key,
Name varchar(250),
BasicPay float, 
Gender char(1),
PhoneNumber varchar(250),
Address varchar(250),
Department varchar(250), 
Deductions float, 
TaxablePay float, 
IncomeTax float,
NetPay float, 
StartDate Date 

)
select*from employeep