create table TBitems(
Code int identity(1 ,1) primary key ,
Name nvarchar (100) not null ,
Price int not null ,
Description nvarchar (max) null 
);