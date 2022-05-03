--UC-1-AbilityToCreateAddressBookService
create database Address_Book_Service

--UC-2-CreatATableOfAddressBookTable
create table AddressBookTable
( Emp_Id int identity(1,1) primary key,
FirstName varchar(20)
,LastName varchar(20),
Address varchar(20),
City varchar(20),
State varchar(20)
,Zip BIGINT,
PhoneNumber BIGINT);