create database LibraryManagementSystem
use LibraryManagementSystem

create table Librarian
(
LibrarianID int primary key,
NIC nchar (12),
First_Name varchar (50),
Last_Name varchar (50),
FullName varchar (50),
Email varchar (50),
Phone_Number nchar (10),
Street varchar (50),
City varchar (50),
PWD varchar (50)
)

select * from Librarian
insert into Librarian values('1','123456789123','John','Cena','J.Cena','cena@gmail.com','0771234567','Barker Street','Colombo','456')


create table Member
(
MemberID nchar (10) primary key,
NIC nchar (12),
First_Name varchar (50),
Last_Name varchar (50),
Email varchar (50),
Phone_Number nchar (10),
Street varchar (50),
City varchar (50)
)

select * from Member
insert into Member values('MID1','765432678943','Deelaka','Rathnayake','deelaka@gmail.com','0772345123','1st Road','Gampaha')


create table Publisher
(
PublisherID nchar (10) primary key,
FullName varchar (50),
Phone_Number nchar (10),
Street varchar (50),
City varchar (50)
)

select * from Publisher
insert into Publisher values('PID1','Saman Kumara','0754312345','Petta Road','Colombo')


create table Books
(
ISBN nchar (20) primary key,
Title varchar (50),
Price varchar (10),
PublisherID nchar (10)
)

select * from Books
insert into Books values('33432','Harry Potter','RS 1000','PID1')


create table Author
(
Author_Name varchar (50) primary key,
ISBN nchar (20)
)

select * from Author
insert into Author values('J.K.Rollins','33432')


create table Lend
(
LendingID nchar (10) primary key,
ISBN nchar (20),
MemberID nchar (10),
Copy_Number nchar (25),
Issue_Date varchar (50),
Returned_Date varchar (50),
Due_Date varchar (50)
)

select * from Lend
insert into Lend values('LID1','33432','MID1','33432C1','2020/12/31','2021/01/10','2021/01/12')


create table CopyRecords
(
Copy_Number nchar (25) primary key,
ISBN nchar (20),
Title varchar (50),
Copy_Year varchar (10)
)

select * from CopyRecords
insert into CopyRecords values('33432C1','33432','Harry Potter','2016')


create table Library
(
Library_Name varchar (50) primary key,
Contect_Number nchar (10)
)

select * from Library
insert into Library values('Public Library Colombo','0112555555')
insert into Library values('Public Library Nuwara','0115666666')


create table MainLibrary
(
Library_Name varchar (50),
Contect_Number nchar (10)
)

select * from MainLibrary
insert into MainLibrary values('Public Library Colombo','0112555555')


create table Branch
(
Library_Name varchar (50),
Library_No nchar (10),
Contect_Number nchar (10),
Street varchar (50),
City varchar (50)
)

select * from Branch
insert into Branch values('Public Library Colombo','B1','0112555555','Ananda Street','Colombo')










