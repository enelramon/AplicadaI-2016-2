Create Database Aplicada1Db;
go
use Aplicada1Db;
go

Create Table Clientes (Id int identity(1,1) primary key,
Nombres Varchar(50),
Balance float);


Insert into Clientes (Nombres,Balance) values ('Hugo',1000);
Insert into Clientes (Nombres,Balance) values ('Junior',100.50);
Insert into Clientes (Nombres,Balance) values ('Cesar',500.95);


select * from Clientes where Balance > 600 or  Balance < 101