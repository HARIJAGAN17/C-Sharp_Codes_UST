create database EmployeeDb

go

use EmployeeDb

go

create table Country(
	
	CountryId int primary key identity,
	CountryName varchar(20)
)


go

create table Gender(
	
	GenderId int primary key identity,
	GenderType varchar(10)
)

go

insert into Country (CountryName) values
('India'),
('USA'),
('England'),
('France');

go

insert into Gender(GenderType) values
('Male'),
('Female');

go

create table Employee (
    id int identity(1000, 5),
    [name] varchar(20),
    CountryId int,
    GenderId int,
    foreign key (CountryId) references Country(CountryId),
    foreign key (GenderId) references Gender(GenderId)
);

go

insert into Employee([name],CountryId,GenderId) values
('John', 1, 1),
('Jessie', 4, 2),
('Tina', 2, 2),
('Thomas', 3, 1),
('Johnson', 2, 1),
('Riya', 3, 2),
('Tommy', 4, 1),
('Preeti', 1, 2);

go


select e.id,e.name,e.CountryId,e.GenderId from Employee e join Country on e.CountryId=Country.CountryId join Gender on e.GenderId=Gender.GenderId

go

select e.id,e.name,e.CountryId,e.GenderId from Employee e join Country on e.CountryId=Country.CountryId join Gender on e.GenderId=Gender.GenderId where Gender.GenderType='male'

go

select e.id,e.name,e.CountryId,e.GenderId from Employee e join Country on e.CountryId=Country.CountryId join Gender on e.GenderId=Gender.GenderId where Gender.GenderType='female'

go

select g.GenderType,COUNT(*) as TotalEmployees from Employee e join  Gender g on e.GenderId = g.GenderId group by g.GenderType

go 

select c.CountryName,count(*) as TotalEmployees from Employee e join Country c on e.CountryId = c.CountryId group by c.CountryName