create database LibraryManagementSystem
use LibraryManagementSystem

create table Librarian
(
LibrarianID int primary key,
NIC nchar (12),
First_Name varchar (50),
Last_Name varchar (50),
Library_Name varchar (50),
Email varchar (50),
Phone_Number nchar (10),
Street varchar (50),
City varchar (50),
PWD varchar (50)
)

select * from Librarian
insert into Librarian values('1','992828123V','Isuru','Perera','Colombo Public Library','isuru@gmail.com','0771234567','Barker Street','Colombo','45@q')
insert into Librarian values('2','953033145V','Rasika','Ranaweera','Public Library Dehiwala','rasika@gmail.com','0773214765','Nawam Street','Colombo','asd?asd')
insert into Librarian values('3','984848225V','Anush','Gayashan','CIS Senior Library','anush@gmail.com','0712234599','Ananda Street','Gampaha','9999o9')
insert into Librarian values('4','199928281234','Wannidu','Hasaranga','Kettarama Public Library','waniya@gmail.com','0775234400','Munchee Street','Wattala','qqq12')
insert into Librarian values('5','200028285000','Dasun','Shanaka','READERS WORLD THE LENDING LIBRARY','shanka@gmail.com','0751237567','Ward Street','Galle','nbvw12')
insert into Librarian values('6','199928451899','Shehan','Jayasuriya','Nunavil Public Library','jaya@gmail.com','0771237000','Haward Street','Kandy','778t')
insert into Librarian values('7','976822621V','Lasith','Malinga','Public Library Kandy','lasith@gmail.com','0788237060','Food Street','Dematagoda','wwer1')
insert into Librarian values('8','999912891V','Nuwan','Kulasekara','Public Library Jaffa','kule@gmail.com','0771437542','Queens Street','Nuwaraeliya','aewwwe')
insert into Librarian values('9','961326890V','Shaminda','Eranga','Public Library Vavuniya','era@gmail.com','0761437890','Arcade Street','Horana','07719@')
insert into Librarian values('10','932827655V','Rangana','Herath','Public Library Moratuwa','hera@gmail.com','0751287291','RC Street','Piliyandala','lpl2020')


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
truncate table Member
insert into Member values('MID200','984848300V','Deelaka','Rathnayake','deelaka@gmail.com','0772345889','1st Street','Gampaha')
insert into Member values('MID201','944048765V','Suranga','Lakmal','laka@gmail.com','0722345889','Wijesuriya Street','Galle')
insert into Member values('MID202','954548567V','Kusal','Mendis','kmedis@gmail.com','0717734520','4th Street','Moratuwa')
insert into Member values('MID203','994748309V','Kusal','Perera','kjp@gmail.com','0772377500','Lakshapathiaya Street','Colombo')
insert into Member values('MID204','914048778V','Dinesh','Chandimal','chandi@gmail.com','0772545900','Samanala Street','Colombo')
insert into Member values('MID205','984348225V','Danushaka','Gunathilaka','dg70@gmail.com','0792345812','2nd Street','Badulla')
insert into Member values('MID206','994748333V','Lahiru','Kumara','laiya@gmail.com','0713345700','Ruwanpura Street','Kandy')
insert into Member values('MID207','994748333V','Dimuth','Karunarathne','dimmma@gmail.com','0723309888','Nirawana Street','Kandy')
insert into Member values('MID208','994748333V','Banuka','Rajapaksha','raja@gmail.com','0777775700','Factory Street','Ja-ela')
insert into Member values('MID209','199945487339','Binod','Banuka','banuka@gmail.com','0776665220','Lanka Street','Kaluthara')


create table Publisher
(
PublisherID nchar (10) primary key,
FullName varchar (50),
Phone_Number nchar (10),
Street varchar (50),
City varchar (50)
)

select * from Publisher
insert into Publisher values('PID2000','Saman Kumara','0754312345','Petta Street','Colombo')
insert into Publisher values('PID2001','Namal wijesuriya','0724312399','Church Street','Kandy')
insert into Publisher values('PID2002','chandrasena Perera','0777312500','S.De.S Jayasingha Street','Jaffana')
insert into Publisher values('PID2003','Kumarathunga Desilva','0712312655','BMICH Street','Colombo')
insert into Publisher values('PID2004','Arjuna Ranathunga','0774312223','W.W Kumara Street','Galle')
insert into Publisher values('PID2005','Avishka Perera','0766611111','5th Street','Dambulla')
insert into Publisher values('PID2006','Ishan Medis','0711112987','Temple Street','Trinco')
insert into Publisher values('PID2007','Aravinda Desilva','0774323468','Martin Wicramasingha Street','Colombo')
insert into Publisher values('PID2008','Prsanna Ranathunga','0714383986','Tower Street','Gampola')
insert into Publisher values('PID2009','Vimal Weerawansha','0778327341','White House Street','Kegalle')



create table Books
(
ISBN nchar (20) primary key,
Title varchar (50),
Price varchar (10),
PublisherID nchar (10)
)

select * from Books
insert into Books values('ISBN10-9780136019701','Harry Potter and the sorcerer stone','RS 1500','PID1')
insert into Books values('ISBN11-9780136018300','Sherlock Holmes','RS 750','PID5')
insert into Books values('ISBN12-9781474622578','THE QUEENS GAMBIT','RS 2000','PID2')
insert into Books values('ISBN13-9781510202252','THE ICKABOG','RS 500','PID1')
insert into Books values('ISBN14-9789553115874','THEE HA THAA','RS 2200','PID3')
insert into Books values('ISBN15-9789554124523','Mora','RS 990','PID6')
insert into Books values('ISBN16-9790231234578','C# for Beginners','RS 1000','PID1')
insert into Books values('ISBN17-9790336019701','Database fro Beginners','RS 1500','PID4')
insert into Books values('ISBN18-9780007580835','THE MIRROR AND THE LIGHT','RS 1750','PID8')
insert into Books values('ISBN19-9790446019701','System Analaysis and Design','RS 1250','PID5')


create table Author
(
Author_Name varchar (50) primary key,
ISBN nchar (20)
)

select * from Author
insert into Author values('J.K Rowling','ISBN10-9780136019701')
insert into Author values('Chandana Mendis','ISBN11-9780136018300')
insert into Author values('	WALTER TEVIS','ISBN129-781474622578')
insert into Author values('Nuwan Pradeep','ISBN13-9781510202252')
insert into Author values('	Surath De Mel','ISBN14-9789553115874')
insert into Author values('Randula Hemal','ISBN15-9789554124523')
insert into Author values('J.P Desilva','ISBN16-9790231234578')
insert into Author values('	Joe Biden','ISBN17-9790336019701')
insert into Author values('	Hilary Mantel','ISBN18-9780007580835')
insert into Author values('Mahinda Gamage','ISBN19-9790446019701')


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
insert into Lend values('LID200','ISBN10-9780136019701','MID200','ISBN10-9780136019701C1','2020/12/31','2021/01/10','10')
insert into Lend values('LID201','ISBN11-9780136018300','MID203','ISBN11-9780136018300C1','2020/11/29','2021/01/01','31')
insert into Lend values('LID202','ISBN12-9781474622578','MID204','ISBN12-9781474622578C1','2020/12/15','2021/01/05','21')
insert into Lend values('LID203','ISBN13-9781510202252','MID201','ISBN13-9781510202252C1','2020/12/05','2021/01/02','28')
insert into Lend values('LID204','ISBN14-9789553115874','MID200','ISBN14-9789553115874C1','2020/12/08','2021/01/09','31')
insert into Lend values('LID205','ISBN15-9789554124523','MID202','ISBN15-9789554124523C1','2020/12/11','2021/02/01','50')
insert into Lend values('LID206','ISBN16-9790231234578','MID208','ISBN16-9790231234578C1','2020/11/11','2021/01/05','55')
insert into Lend values('LID207','ISBN17-9790336019701','MID9209','ISBN17-9790336019701C1','2020/12/31','2021/03/01','60')
insert into Lend values('LID208','ISBN18-9780007580835','MID207','ISBN18-9780007580835C1','2020/12/01','2021/01/11','41')
insert into Lend values('LID209','ISBN19-9790446019701','MID206','ISBN19-9790446019701C1','2020/12/25','2021/01/06','13')
insert into Lend values('LID210','ISBN10-9780136018300','MID205','ISBN10-9780136018300C2','2020/12/12','2021/01/01','20')


create table CopyRecords
(
Copy_Number nchar (25) primary key,
ISBN nchar (20),
Title varchar (50),
Library_Name varchar (50),
Copy_Year varchar (10)
)

select * from CopyRecords
insert into CopyRecords values('ISBN10-9780136019701C1','ISBN10-9780136019701','Harry Potter and the sorcerer stone','Colombo Public Library','2016')
insert into CopyRecords values('ISBN11-9780136018300C1','ISBN11-9780136018300','Sherlock Holmes','Public Library Dehiwala','2012')
insert into CopyRecords values('ISBN11-9780136018300C2','ISBN11-9780136018300','Sherlock Holmes','Public Library Dehiwala','2012')
insert into CopyRecords values('ISBN12-9781474622578C1','ISBN12-9781474622578','THE QUEENS GAMBIT','CIS Senior Library','2015')
insert into CopyRecords values('ISBN13-9781510202252C1','ISBN13-9781510202252','THE ICKABOG','Kettarama Public Library','2018')
insert into CopyRecords values('ISBN14-9789553115874C1','ISBN14-9789553115874','THEE HA THAA','READERS WORLD THE LENDING LIBRARY','2019')
insert into CopyRecords values('ISBN15-9789554124523C1','ISBN15-9789554124523','Mora','Nunavil Public Library','2017')
insert into CopyRecords values('ISBN16-9790231234578C1','ISBN16-9790231234578','C# for Beginners','Public Library Kandy','2016')
insert into CopyRecords values('ISBN17-9790336019701C1','ISBN17-9790336019701','Database fro Beginners','Public Library Jaffa','2018')
insert into CopyRecords values('ISBN18-9780007580835C1','ISBN18-9780007580835','THE MIRROR AND THE LIGHT','Public Library Vavuniya','2015')
insert into CopyRecords values('ISBN19-9790446019701C1','ISBN19-9790446019701','System Analaysis and Design','Public Library Moratuwa','2012')



create table Library
(
Library_Name varchar (50) primary key,
Contect_Number nchar (10)
)

select * from Library
insert into Library values('Colombo Public Library','0112555555') 
insert into Library values('Public Library Dehiwala','0115612278')
insert into Library values('CIS Senior Library','0115654444')
insert into Library values('Kettarama Public Library','0112655555')
insert into Library values('READERS WORLD THE LENDING LIBRARY','0112765123')
insert into Library values('Nunavil Public Library','0117710777')
insert into Library values('Public Library Kandy','0115544444')
insert into Library values('Public Library Jaffa','0113123123')
insert into Library values('Public Library Vavuniya','0112657891')
insert into Library values('Public Library Moratuwa','0112357901')


create table MainLibrary
(
Library_Name varchar (50),
Contect_Number nchar (10)
)

select * from MainLibrary
insert into MainLibrary values('Colombo Public Library','0112555555')


create table Branch
(
Library_Name varchar (50),
Library_No nchar (10),
Contect_Number nchar (10),
Street varchar (50),
City varchar (50)
)

select * from Branch
insert into Branch values('Colombo Public Library','B1','0112555555','Ananda Street','Colombo')
insert into Branch values('Public Library Dehiwala','B2','0115612278','Nedimala Street','Dehiwala')
insert into Branch values('CIS Senior Library','B3','0115654444','Kings Street','Kollupitiya')
insert into Branch values('Kettarama Public Library','B4','0112655555','Nawarathna Street','Maradana')
insert into Branch values('READERS WORLD THE LENDING LIBRARY','B5','0112765123','5th Street','Colombo')
insert into Branch values('Nunavil Public Library','B6','0117710777','Kalu Street',' Chavakachcheri')
insert into Branch values('Public Library Kandy','B7','0115544444','Palace Street','Kandy')
insert into Branch values('Public Library Jaffa','B8','0113123123','Pulmoddai Street','Jaffa')
insert into Branch values('Public Library Vavuniya','B9','0112657891','Off Park Street','Vavuniya')
insert into Branch values('Public Library Moratuwa','B10','0112357901','Teron Street','Morauwa')