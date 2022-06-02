create database Students


create table Students(id int,Roll_No int,FirstName varchar(200),LastName varchar(200),Gender varchar(200),studentclass_id int)
create table Students_class(id int,Class_name varchar(200))

select * from Students;
select * from Students_class;

insert into Students values (1,101,'sneha','ghongade','female',1)
insert into Students values (2,102,'ankit','ghongade','male',2)
insert into Students values (3,103,'puja','verma','female',3)
insert into Students values (4,104,'sneha','sharma','male',4)

insert into Students_class values (1,'FY')
insert into Students_class values (2,'SY')
insert into Students_class values (3,'TY')


select Roll_No,CONCAT(FirstName,' ',LastName) as FullName,Gender,sc.Class_name from Students s
inner join Students_class sc on sc.id=s.studentclass_id

create function GetFullName(@ID int)
returns varchar(200)  AS 
Begin
 return (select CONCAT(FirstName,' ',LastName) as FullName from Students where id=@ID);
End

select * from Students
select dbo.GetFullName(2) ;

select * from employee
create proc AddEmployee(@id int,@name varchar(200),@departmentid int)
As 
Begin

insert into employee values(@id,@name,@departmentid);
END


exec dbo.AddEmployee 5,'xys',1







