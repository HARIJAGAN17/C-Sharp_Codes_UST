create database CompanyDb

go

use CompanyDb

go

create table Departments
(
	id int primary key identity,
	DepartmentName varchar(20),
	[Location] varchar(20),
	DepartmentHead varchar(20)
)

go

insert into Departments(DepartmentName,[Location],DepartmentHead)
values('IT','London','Rick'),
('Payroll','Delhi','Ron'),
('HR','New York','Cristie'),
('Other Department','Sydney','Cindrella')

go

create table Employees(
	
	id int primary key identity,
	[Name] varchar(20),
	Gender varchar(10),
	DepartmentId int,
	Salary int constraint SK_CompantDb_Salary check(Salary>2500),
	foreign key (DepartmentId) references Departments(id),
)

go


insert into Employees([Name],Gender,Salary,DepartmentId)
Values
('Tom', 'Male', 4000, 1),
('Pam', 'Female', 3000, 3),
('John', 'Male', 3500, 1),
('Sam', 'Male', 4500, 2),
('Todd', 'Male', 2800, 2),
('Ben', 'Male', 7000, 1),
('Sara', 'Female', 4800, 3),
('Valarie', 'Female', 5500, 1),
('James', 'Male', 6500, null),
('Russell', 'Male', 8800, null)

go

create procedure GetByDept
as
begin
	select e.[Name],e.Gender,e.Salary,d.DepartmentName from Employees e join Departments d on d.id = e.DepartmentId where d.DepartmentName != 'Other Department'
end

go

exec GetByDept

go

create procedure GetAllNull
as
begin
	select e.[Name],e.Gender,e.Salary,d.DepartmentName from Employees e left join Departments d on d.id = e.DepartmentId
end

go

exec GetAllNull

go

create procedure GetTotalSalaryGender
as
begin
	select Gender,SUM(Salary) as TotalSalary from Employees Group by Gender
end

go

exec GetTotalSalaryGender

go

create procedure GetSalaryDeptName
as
begin
	select d.DepartmentName,SUM(e.Salary) as TotalSalary from Employees e join Departments d on  e.DepartmentId = d.id   Group by d.DepartmentName
end

go

exec GetSalaryDeptName

go

create procedure UpdateEmployeeSalary @salary int, @id int
as
begin
	update Employees set Salary =@salary where id = @id
end

go

exec UpdateEmployeeSalary @salary = 20000,@id = 1

go

create procedure DeleteEmployee  @id int
as
begin

	delete from Employees where id = @id

end

go

exec DeleteEmployee @id =3

go

create procedure TotalEmployeeDpt
as
begin
	select d.DepartmentName,Count(*) as TotalEmployees from Employees e join Departments d on e.DepartmentId = d.id group by d.DepartmentName
end

go

exec TotalEmployeeDpt