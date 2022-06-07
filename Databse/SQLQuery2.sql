create database SampleDB;

create table Sample(id int IDENTITY(1,1),fname varchar(100),PRIMARY KEY(id));
select * from Sample;
 
Truncate table Sample;