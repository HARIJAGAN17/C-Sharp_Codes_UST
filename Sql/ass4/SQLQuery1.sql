create Database CustomerDb

go

use CustomerDb

go

create table Customer(
		
	Id int primary key identity,
	[Name] varchar(15),
	Gender varchar(15),
	City varchar(15),
	Salary int,
)

go 

insert into Customer([Name],Gender,Salary,City) values
('Tom', 'Male', 4000, 'London'),
('Pam', 'Female', 3000, 'New York'),
('John', 'Male', 3500, 'London'),
('Sam', 'Male', 4500, 'London'),
('Todd', 'Male', 2800, 'Sydney'),
('Ben', 'Male', 7000, 'New York'),
('Sara', 'Female', 4800, 'Sydney'),
('Valarie', 'Female', 5500, 'New York'),
('James', 'Male', 6500, 'London'),
('Russell', 'Male', 8800, 'London')

go

select * from Customer

go

create procedure GetTotalSalary
As
Begin
	select City, SUM(Salary) as TotalSalary from Customer group by City
end

go

Execute GetTotalSalary

go

create procedure TotalSalaryCityGender
as
begin
	select City,Gender, SUM(Salary) as TotalSalary from Customer group by City,Gender
end

go 

Execute TotalSalaryCityGender

go

create procedure TotalSalaryNumberofEmployee
as
begin
	select City,Gender,COUNT(*)as TotalEmployees,Sum(Salary) as TotalSalary from Customer group by City,Gender
end

go

Exec TotalSalaryNumberofEmployee

go

create procedure TotalRecords @gender varchar(20), @city varchar(20)
as
begin 
	select * from Customer where Gender = @gender and City = @city
end

go

Exec TotalRecords @gender = 'male',@city = 'London'
	