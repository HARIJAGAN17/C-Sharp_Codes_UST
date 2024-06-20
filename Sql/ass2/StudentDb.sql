create database StudentDb

go

use StudentDb

go

create table Student(

	id int identity(1000,5),
	[name] varchar(20),
	gender varchar(10),
	marks int,
	constraint mk_Student_marks check(marks>0 and marks<=100)
)

go

insert into Student ([name], gender, marks) values
('John', 'Male', 80),
('Jessie', 'Female', 92),
('Jeena', 'Female', 75),
('Thomas', 'Male', 65),
('Johnson', 'Male', 45),
('Meena', 'Female', 50);

go

select * from Student

go

select * from Student where gender = 'male'

go

select * from Student where gender = 'female'

go

select * from Student where marks > 45

go

select * from student where name like 'j%'

go

select * from student where name like '%a'

go

select gender, SUM(marks) as TotalMarks from Student group by gender

go

select gender, COUNT(*) as TotalStudent from Student group by gender

go


select gender, COUNT(*) as TotalStudent from Student where marks > 70 group by gender



