Create database PremierServiceSolutions;
Go
Use PremierServiceSolutions;
Go
create table Employee(
EmployeeID int Primary KEY IDENTITY(1,1) NOT NULL,
JobTitle varchar(50) NOT NULL,
Name varchar(50) NOT NULL,
Surname varchar(50) NOT NULL,
PhoneNumber varchar(12) NOT NULL,
Department varchar(50) NOT NULL,
Salary Decimal(7,2) NOT NULL,
DateHired Date NOT NULL,
DOB Date NOT NULL,
Email varchar(50) NOT NULL,
MangerID int NOT NULL,
Availability varchar(30) NOT NULL,
Username varchar(50) not null,
Password varchar(50) not null,
)

create table BusinessRole(
BusinessRoleID int primary key identity(1,1) NOT NULL,
Name varchar(50) not null,
Surname varchar(50) not null,
ContactNumber varchar(10) not null,
BusinessRole varchar(50)not null
) 
Create table SLA(
SLAID int primary key identity(1,1)not null,
ExpireDate date not null,
StartDate date not null,
Status varchar(50) not null
)
Create table Packages(
PackagesID int primary key identity(1,1) not null,
PackageName Varchar(50) not null,
Availability varchar(10) not null,
Discount decimal(6,2) ,
SLAID int not null,

Foreign key (SLAID) REFERENCES SLA(SLAID)
)
  
Create table Customer(
CustomerID int primary key identity(1,1) NOT NULL,
Name varchar(50) not null,
Surname varchar(50) not null,
PackagesID int not null,
PhoneNumber varchar(10)not null,
Email Varchar(50)not null,
DOB Date not null,
Street varchar(50) not null,
City varchar(50) not null,
zip varchar(10) not null,


FOREIGN KEY (PackagesID) REFERENCES Packages (PackagesID)
)

create table [Service](
ServicesID int primary key identity(1,1) not null,
MaintancesType varchar(40)not null,
DifficultMeasure Varchar(50) not null,
Prices decimal(7,2)not null,
Frequency char(1)not null,
Task varchar(40)not null,
Description varchar(250) not null,
ToolsMaterials varchar(250) not null
)

create table Jobs(
JobsID int primary key identity(1,1) not null,
CustomerID int not null ,
EmployeeID int,
Notes varchar(225),
status varchar(50)not null,
DateStarted date not null,
DateEnded date,
ServiceID int not null,
Priority varchar(10)


FOREIGN KEY (EmployeeID) REFERENCES Employee (EmployeeID),
FOREIGN KEY (CustomerID) REFERENCES Customer (CustomerID),
FOREIGN KEY (ServiceID) REFERENCES [Service] (ServicesID)
)
--insert into Jobs(CustomerID,EmployeeID,Notes,status,DateStarted,ServiceID,Priority) values(4,2,'','Not yet started','2023/08/12',2,'High');
 Create table CallHistory(
 Callinstance int primary key identity(1,1) not null,
 CustomerID int not null , 
 StartTime datetime not null,
 Endtime datetime not null,
 EmployeeID int not null,

 Foreign key(CustomerID) REFERENCES Customer (CustomerID),
 foreign key (EmployeeID) References Employee (EmployeeID)
 )

 create table BusinessCustomer(
 CustomerID int not null,
 BusinessRoleID int not null,

 Primary key(CustomerID,BusinessRoleID),
 
 Foreign key(BusinessRoleID) REFERENCES BusinessRole (BusinessRoleID),
 foreign key (CustomerID) References Customer (CustomerID)
 )

Create table ServiceinPackages(
packagesID int not null,
ServicesID int not null 
PRIMARY KEY(packagesID , ServicesID),
Foreign key (ServicesID) REFERENCES [Service](ServicesID),
Foreign key (packagesID) REFERENCES Packages(packagesID)
)

GO

GO

-- Views the prices of a packages
CREATE VIEW PackagesPrices
AS
	SELECT PackagesID , PackageName ,Availability,Discount, SLAID ,(Select Sum(Prices) from [Service] s inner join ServiceinPackages sp on s.ServicesID=sp.ServicesID group by sp.packagesID ) as 'prices'from Packages
GO	

--Call history 
Create view InteractionHistory 
AS
	select c.CustomerID ,c.Name +' '+c.surname as 'Customer' ,e.EmployeeID,e.name +' '+e.surname as 'Employee ', StartTime , endtime , datediff(second, StartTime,Endtime) as 'Duration 'from CallHistory ch inner join Customer c on ch.CustomerID = c.CustomerID inner join Employee e on e.EmployeeID = ch.EmployeeID

GO

GO
Create view cusAgreement
AS 
	select c.customerid,p.packagesID,PackageName,Availability,discount,p.SLAID,ExpireDate,StartDate,Status from Customer c inner join Packages p on c.PackagesID = p.PackagesID inner join SLA s on s.SLAID = p.SLAID

GO
--Insert 

--Employee
--1
Insert into Employee(JobTitle,Name,Surname,Department,Salary,DateHired,DOB,Email,MangerID,Availability,Username,Password,PhoneNumber)
Values('COO','John ','Bolton','Admin' ,50000,'2010/01/20','08/31/1976','8/31/1976',0,'no','delmer.bot1974','mexe3pah1S','+27824900898');
--2
Insert into Employee(JobTitle,Name,Surname,Department,Salary,DateHired,DOB,Email,MangerID,Availability,Username,Password ,PhoneNumber)
Values('Manager','Elizabeth','Boudreaux','Call Centre' ,20000,'2022/01/14','11/27/1980','marielle.ra@yahoo.com',1,'no','leta.kohler','ahLeir4o','+27854323511');
--3
Insert into Employee(JobTitle,Name,Surname,Department,Salary,DateHired,DOB,Email,MangerID,Availability,Username,Password,PhoneNumber)
Values('Operator','Russell ','Young','Call Centre' ,10000,'2023/01/20','01/06/1983','syble_mitche@gmail.com',2,'no','CristianGamer007','oph3ahFah','+27837512952');
--4
Insert into Employee(JobTitle,Name,Surname,Department,Salary,DateHired,DOB,Email,MangerID,Availability,Username,Password,PhoneNumber)
Values('Manager','Michael','Pasquale','Client Maintenance' ,20000,'2023/01/20','04/07/1964','kyla_heane0@hotmail.com',1,'no','Zedst4r','uWahHai1','+27835050813');
--5
Insert into Employee(JobTitle,Name,Surname,Department,Salary,DateHired,DOB,Email,MangerID,Availability,Username,Password,PhoneNumber)
Values('Operator','Michael','Lopez','Client Maintenance' ,10000,'2023/01/20','10/18/1966','mckenna2015@gmail.com',4,'no','Adilos','eig3Aer','+27837148018');
--6
Insert into Employee(JobTitle,Name,Surname,Department,Salary,DateHired,DOB,Email,MangerID,Availability,Username,Password,PhoneNumber)
Values('Manager','Norma ','Jackson','Service Department' ,20000,'2023/01/20','03/19/1985','theo1984@gmail.com',1,'Yes','kurtis.rod2004','ohGieph4oox','+27818150525');
--7
Insert into Employee(JobTitle,Name,Surname,Department,Salary,DateHired,DOB,Email,MangerID,Availability,Username,Password,PhoneNumber)
Values('Operator','Virginia ','Gray','Service Department' ,20000,'2023/01/20','03/19/1985','constantin.herz@gmail.com',6,'Yes','isofost_cs','doveiShoo6oh','+27853037068');
--8
Insert into Employee(JobTitle,Name,Surname,Department,Salary,DateHired,DOB,Email,MangerID,Availability,Username,Password,PhoneNumber)
Values('Manager','Eric','Moore','management Department' ,60000,'2023/01/20',' 04/09/1977','madyson_altenwer@yahoo.com',1,'no','barton','aiy7jeeNieN','085 303 7068');

select * from Employee

--SLA
insert into SLA(StartDate,ExpireDate,Status)
values('2020/01/20','2023/01/20','Active')

insert into SLA(StartDate,ExpireDate,Status)
values('2022/01/20','2025/01/20','Active')

insert into SLA(StartDate,ExpireDate,Status)
values('2023/01/20','2026/01/20','Active')

insert into SLA(StartDate,ExpireDate,Status)
values('2024/01/20','2027/01/20','Active')

insert into SLA(StartDate,ExpireDate,Status)
values('2019/01/20','2022/01/20','expired')

Select * from SLA
--Service
--1
insert into Service(MaintancesType,DifficultMeasure,Prices,Frequency,Task,Description,ToolsMaterials)
values('Preventive' ,'Easy',3000,'M','Oil change','Remove current oil and replace with new','Wrench,Oil,Bucket');
--2
insert into Service(MaintancesType,DifficultMeasure,Prices,Frequency,Task,Description,ToolsMaterials)
values('Corrective ' ,'hard',3000,'Y','Test the battery','Test the battery','Wrench,Muilti meter');
--3
insert into Service(MaintancesType,DifficultMeasure,Prices,Frequency,Task,Description,ToolsMaterials)
values('Preventive' ,'Easy',3000,'Y','TIRE PRESSURE AND TREAD DEPTH','TIRE PRESSURE AND TREAD DEPTH','Wrench,Oil,Bucket');
--4
insert into Service(MaintancesType,DifficultMeasure,Prices,Frequency,Task,Description,ToolsMaterials)
values('Preventive' ,'Easy',3000,'y','TRANSFER CASE FLUID','TRANSFER CASE FLUID','Wrench,Oil,Bucket');
--5
insert into Service(MaintancesType,DifficultMeasure,Prices,Frequency,Task,Description,ToolsMaterials)
values('Preventive' ,'Easy',3000,'M','Oil change','Remove current oil and replace with new','Wrench,Oil,Bucket');

Select * from Service

--Packages
--1
insert into Packages(SLAID,Availability,Discount,PackageName)
Values(1,'Yes',0,'Basic car')
--2
insert into Packages(SLAID,Availability,Discount,PackageName)
Values(2,'Yes',10,'Oil')
--3
insert into Packages(SLAID,Availability,Discount,PackageName)
Values(3,'Yes',0,'All')
--4
insert into Packages(SLAID,Availability,Discount,PackageName)
Values(4,'no',0,'Fluid')
--5
insert into Packages(SLAID,Availability,Discount,PackageName)
Values(5,'Yes',0,'Oil')

select * from Packages
--Services in packages
insert into ServiceinPackages(packagesID,ServicesID)
values(1,1)
insert into ServiceinPackages(packagesID,ServicesID)
values(1,2)
insert into ServiceinPackages(packagesID,ServicesID)
values(1,3)
insert into ServiceinPackages(packagesID,ServicesID)
values(2,5)
insert into ServiceinPackages(packagesID,ServicesID)
values(3,1)
insert into ServiceinPackages(packagesID,ServicesID)
values(3,2)
insert into ServiceinPackages(packagesID,ServicesID)
values(3,3)
insert into ServiceinPackages(packagesID,ServicesID)
values(3,4)
insert into ServiceinPackages(packagesID,ServicesID)
values(3,5)
insert into ServiceinPackages(packagesID,ServicesID)
values(4,5)
insert into ServiceinPackages(packagesID,ServicesID)
values(4,4)
insert into ServiceinPackages(packagesID,ServicesID)
values(5,1)
insert into ServiceinPackages(packagesID,ServicesID)
values(5,2)
Select * from ServiceinPackages
--Customer 
--1
--ind
insert into Customer(Name,Surname,Street,City,zip,PackagesID,PhoneNumber,Email,DOB)
Values('Gregory','McKnight','2121 Zigzag Rd','Vereeniging','1934',1,'0826674525','GregoryKMcKnight@jourrapide.com','2002/06/24');
insert into Customer(Name,Surname,Street,City,zip,PackagesID,PhoneNumber,Email,DOB)
Values('Cindy','Spencer','702 Sandown Rd','Piketberg','8100',2,'0839833327','CindyJSpencer@teleworm.us','1985/11/09');
insert into Customer(Name,Surname,Street,City,zip,PackagesID,PhoneNumber,Email,DOB)
Values('Patricia','Harrison','1998 Bezuidenhout St','Kriel','2276',3,'0826674525','PatriciaJHarrison@jourrapide.com','2002/06/24');
--Bus
insert into Customer(Name,Surname,Street,City,zip,PackagesID,PhoneNumber,Email,DOB)
Values('Business','PortBus','2104 St. John Street','Vereeniging','1934',4,'','','');
insert into Customer(Name,Surname,Street,City,zip,PackagesID,PhoneNumber,Email,DOB)
Values('Business','CountryBus','2121 Zigzag Rd','Somerset West','3333',5,'','','');
insert into Customer(Name,Surname,Street,City,zip,PackagesID,PhoneNumber,Email,DOB)
Values('Business','AndreaBusess','944 Bath Rd','Phoenix','4302',3,'','','');
--Business Role
--1
insert into BusinessRole(BusinessRole,Name,Surname,ContactNumber)
Values('CEO','Lucille','Restrepo,','0825700715');
--2
insert into BusinessRole(BusinessRole,Name,Surname,ContactNumber)
Values('Driver','John','Perry,','0832002427');
--3
insert into BusinessRole(BusinessRole,Name,Surname,ContactNumber)
Values('CEO','Frances ','Fisher,','0821490571');
--4
insert into BusinessRole(BusinessRole,Name,Surname,ContactNumber)
Values('COO','Rebecca','Cobb,','0846935086');
--5
insert into BusinessRole(BusinessRole,Name,Surname,ContactNumber)
Values('CEO','Lindsey','Harris,','0852094201');
--6
insert into BusinessRole(BusinessRole,Name,Surname,ContactNumber)
Values('COO','Wilma','Ralls,','0857238071');
--Business 
Select * from Customer
select * from BusinessRole

insert into BusinessCustomer(CustomerID,BusinessRoleID)
Values(5,1)
insert into BusinessCustomer(CustomerID,BusinessRoleID)
Values(5,2)
insert into BusinessCustomer(CustomerID,BusinessRoleID)
Values(6,3)
insert into BusinessCustomer(CustomerID,BusinessRoleID)
Values(6,4)
insert into BusinessCustomer(CustomerID,BusinessRoleID)
Values(7,5)
insert into BusinessCustomer(CustomerID,BusinessRoleID)
Values(7,6)
Select * from BusinessCustomer
--Call history 
insert into CallHistory(CustomerID,EmployeeID,StartTime,Endtime)
Values(2,3,'2020-11-11 13:23:44','2020-11-11 15:23:44')
insert into CallHistory(CustomerID,EmployeeID,StartTime,Endtime)
Values(2,3,'2021-11-11 13:23:44','2021-11-11 13:50:44')
insert into CallHistory(CustomerID,EmployeeID,StartTime,Endtime)
Values(3,4,'2022-11-11 10:23:44','2022-11-11 13:23:44')
insert into CallHistory(CustomerID,EmployeeID,StartTime,Endtime)
Values(4,4,'2023-11-11 09:23:44','2023-11-11 13:23:44')
insert into CallHistory(CustomerID,EmployeeID,StartTime,Endtime)
Values(5,4,'2023-11-11 13:23:44','2023-11-11 14:23:44')

Select * from CallHistory
select * from Customer
--Jobs
insert into Jobs(CustomerID,EmployeeID,DateStarted,DateEnded,Notes,Priority,ServiceID,status)
Values(2,6,'2023/07/10','2023/07/20','Standard oil change','High',1,'Done');

insert into Jobs(CustomerID,EmployeeID,DateStarted,DateEnded,Notes,Priority,ServiceID,status)
Values(3,6,'2023/07/11','2023/07/14','Battery test','Medium',2,'Done');

insert into Jobs(CustomerID,EmployeeID,DateStarted,Notes,Priority,ServiceID,status)
Values(4,6,'2023/08/10','Tire','Low',3,'Active');
insert into Jobs(CustomerID,EmployeeID,DateStarted,Notes,Priority,ServiceID,status)
Values(5,7,'2023/08/11','Case Fluid','High',4,'Active');
insert into Jobs(CustomerID,EmployeeID,DateStarted,Notes,Priority,ServiceID,status)
Values(6,7,'2023/08/12','Standard oil change','Medium',5,'Active');
