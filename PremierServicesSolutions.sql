Create database PremierServiceSolutions;
Go
Use PremierServiceSolutions;
Go
create table Employee(
EmployeeID int Primary KEY IDENTITY(1,1) NOT NULL,
JobTitle varchar(50) NOT NULL,
Name varchar(50) NOT NULL,
Surname varchar(50) NOT NULL,
PhoneNumber varchar(10) NOT NULL,
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
EmployeeID int not null,
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
 EmployeeID int not null,
 BusinessRoleID int not null,

 Primary key(EmployeeID,BusinessRoleID),
 
 Foreign key(BusinessRoleID) REFERENCES BusinessRole (BusinessRoleID),
 foreign key (EmployeeID) References Employee (EmployeeID)
 )

Create table ServiceinPackages(
packagesID int not null,
ServicesID int not null 
PRIMARY KEY(packagesID , ServicesID),
Foreign key (ServicesID) REFERENCES [Service](ServicesID),
Foreign key (packagesID) REFERENCES Packages(packagesID)
)

GO




--Insert into SLA (ExpireDate,StartDate,Status) values('2023/06/12','2023/05/11','Active');

--Select * from Packages

--Insert into Packages (PackageName ,Availability,Discount,SLAID) values ('Test','Y',0,1);


--INSERT into [Service] (MaintancesType,DifficultMeasure,Prices,Frequency,Task,Description,ToolsMaterials) values('corrective','hard',12,'m','TEST','TEST','TEST')
--Select * from [Service]


--Insert into ServiceinPackages(packagesID,ServicesID) values(3 , 1);
--Insert into ServiceinPackages(packagesID,ServicesID) values(3,2);
--Select * from ServiceinPackages
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

--Select * from InteractionHistory
--	Select * from Packages
--insert into Customer(Name,Surname,PackagesID,PhoneNumber,Email,DOB,Street,City,zip) values ('test','test',1,'0818150523','test@you','2002/08/12' ,'here' ,'here','here')
--select * from Customer
--insert into Employee(JobTitle,Name,Surname,PhoneNumber,Department,Salary,DateHired,DOB,Email,MangerID,Availability,Username,Password)
--values('CEO','TEst','test','0','call centre',12,'2023/06/12','2023/06/12','ddf@dfd' ,4,'y','Susan' ,'pass') 

--select * from Employee
--select * from Customer
--insert into CallHistory(CustomerID,StartTime,Endtime,EmployeeID) values(4,'2018-03-25 12:00:00','2018-04-05 07:30:00',1)

GO
Create view cusAgreement
as 
	select c.customerid,p.packagesID,PackageName,Availability,discount,p.SLAID,ExpireDate,StartDate,Status from Customer c inner join Packages p on c.PackagesID = p.PackagesID inner join SLA s on s.SLAID = p.SLAID

	--select * from cusAgreement where CustomerID = 4