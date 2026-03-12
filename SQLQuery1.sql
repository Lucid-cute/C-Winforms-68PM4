create database c#sv
use c#sv

create table Account(
id int primary key identity(1,1),
email varchar(100) not null,
password varchar(100) not null
)

create table Class(
id int primary key identity(1,1),
name nvarchar(100)
)

create table Student(
id int primary key identity(1,1),
classId int constraint FK_Student_Class foreign key references Class(id),
mssv varchar(10) not null unique,
name nvarchar(100) not null,
email nvarchar(100) not null,
)

insert Account values
('client@zz.zz','123')

insert Class values
('68PM1'),('68PM2'),('68PM3'),('68PM4')

select * from Class
insert into Student values
(1,'001','A','a@gmail.com'),
(1,'002','B','b@gmail.com'),
(1,'003','C','c@gmail.com'),
(2,'004','D','d@gmail.com'),
(2,'005','E','e@gmail.com'),
(2,'006','F','f@gmail.com'),
(2,'007','G','g@gmail.com'),
(2,'008','H','h@gmail.com')


