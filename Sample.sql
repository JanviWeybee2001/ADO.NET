use Sample;

create table student (studentId integer, name nvarchar(20), city nvarchar(20), country nvarchar(20))

select * from student

insert into student values (1, 'Janvi', 'Rajkot', 'India')
insert into student values (2, 'Hardi', 'Rajkot', 'India')
insert into student values (3, 'Aayushi', 'Surat', 'India')

drop table student

alter table student drop column city, country

use w3schools

select * from orders