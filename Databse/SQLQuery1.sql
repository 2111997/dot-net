select * from employee;

drop table employee;



create table employee (id int,name varchar(200),departmentid int)
create table department(id int,department varchar(20))

insert into employee values(1,'sneha',1)
insert into employee values(2,'ankit',2)
insert into employee values(3,'puja',3)
insert into employee values(4,'Rahul',4)
 

insert into department values(1,'IT')
insert into department values(2,'Sales')
insert into department values(4,'Admin')

select * from employee
select * from department

select emp.name,dep.department from employee as emp inner join department as dep on emp.departmentid=dep.id

select emp.name,dep.department from employee as emp left join department as dep on emp.departmentid=dep.id

select emp.name,dep.department from employee as emp right join department as dep on emp.departmentid=dep.id

select * from employee emp FULL OUTER JOIN department dep on emp.departmentid=dep.id;

select * from employee emp LEFT OUTER JOIN department dep on emp.departmentid=dep.id;

select * from employee emp RIGHT OUTER JOIN department dep on emp.departmentid=dep.id;

select * from employee as emp inner join department as dep on emp.departmentid=dep.id;





