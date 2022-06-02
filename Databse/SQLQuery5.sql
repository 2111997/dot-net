create database Sneha;

create table employee(employee_id int,employee_name varchar(200),employee_address varchar(200) );




drop table employee;

create table employee(employee_id int,employee_name varchar(200),employee_address varchar(200),employee_gender varchar );

insert into employee values(1,'sneha','mumbai','female');
insert into employee values(2,'ankit','mumbai','male');
insert into employee values(3,'anjali','mumbai','female');
insert into employee values(4,'ram','mumbai','male');

select * from employee;

alter table employee Add salary int;
alter table employee Drop column salary ;
update  employee set employee_name='rohit' where employee_id=4;

create table student(id int,rollno int,FirstName varchar(20),LastName varchar(20),Gender varchar(10));

select * from student;

insert into student values(1,101,'sneha','ghongade','female');
insert into student values(2,102,'ankit','ghongade','male');
insert into student values(1,103,'pooja','verma','female');
insert into student values(1,104,'anjali','zade','female');
insert into student values(1,105,'kiran','ghongade','male');
insert into student values(1,106,'nikita','ghongade','female');

update  student set id=3 where rollno=103;

drop table student;
create table student(id int,rollno int,FirstName varchar(20),LastName varchar(20),Gender varchar(10));

select * from student;

insert into student values(1,101,'sneha','ghongade','female');
insert into student values(2,102,'ankit','ghongade','male');
insert into student values(3,103,'pooja','verma','female');
insert into student values(4,104,'anjali','zade','female');
insert into student values(5,105,'kiran','ghongade','male');
insert into student values(6,106,'nikita','ghongade','female');

select * from student where Gender='female';

select * from student order by id desc;
select * from student order by id ;

select * from student where rollno='102';
select * from student where rollno='103';

select * from student where rollno in (101,103,105);

select max(rollno) from student
select min(rollno) from student
select avg(rollno) from student

select count(*) from student 

select CONCAT(FirstName,' ',LastName) as FullName  from student


select * from employee;
alter table employee Add salary int;
alter table employee Add Department varchar;

update  employee set salary=2000000 where employee_id=4;
update  employee set salary=3000000 where employee_id=3;
update  employee set salary=4000000 where employee_id=2;
update  employee set salary=5000000 where employee_id=1;

select max(salary) from employee
select min(salary) from employee
select avg(salary) from employee

select count(*) from employee 








































 







