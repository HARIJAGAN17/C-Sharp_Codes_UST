create database SchoolDb

go

use SchoolDb

go

Create table Students(
	
	id int,
	first_name varchar(20),
	last_name varchar(20),
	marks int,
	constraint mk_students_marks check  (marks>0 and marks<=100),
)

go

--alter table Students
--add constraint  mk_students_marks check(marks>0 and marks<=100)

go

insert into Students(id, first_name, last_name, marks) values
(100, 'johny', 'ryan', 55),
(101, 'tina', 'mari', 75),
(102, 'tim', 'keith', 65),
(103, 'vineetha', 'mathew', 88),
(104, 'varun', 'john', 92),
(105, 'tarun', 'varghese', 94)


go


select id,first_name,last_name from Students where marks>60



go

select MAX(marks) as "HighestMarks" from Students

--select * from Students where marks = (select MAX(marks) as "HighestMarks" from Students)

go

select MIN(marks) as "LowestMarks" from Students

--select * from Students where marks = (select MIN(marks) as "LowestMarks" from Students)

go

select AVG(marks) as "Averagemarks" from Students
