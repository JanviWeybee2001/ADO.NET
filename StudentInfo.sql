
use Sample

create table StudentInfo (
StudentId int IDENTITY(1,1) unique, 
Full_Name nvarchar(30), 
gender nvarchar(10), 
Total_Marks int, 
check (gender in ('Male','Female')))

insert into StudentInfo values ('Janvi Desai', 'Female', 500);
insert into StudentInfo values ('Hardi Goyani', 'Female', 550);
insert into StudentInfo values ('Rishit Kalayani', 'Male', 450);
insert into StudentInfo values ('Sahil Parasaniya', 'Male', 550);
insert into StudentInfo values ('Nishita Kalayani', 'Female', 400);
insert into StudentInfo values ('Hemangi Nirmal', 'Female', 450);
insert into StudentInfo values ('Sagar Patel', 'Male', 500);
insert into StudentInfo values ('Bhavin Bandhiya', 'Male', 500);
insert into StudentInfo values ('Krshna Bhuva', 'Female', 450);
insert into StudentInfo values ('Parth Shinagala', 'Male', 550);
insert into StudentInfo values ('Surbhi kayda', 'Female', 550);

select * from StudentInfo

drop table StudentInfo