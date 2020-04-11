use master;
If DB_ID('Hospital Management') is not null
	Drop Database [Hospital Management];

Create Database [Hospital Management]
GO

Create Table [Hospital Management].dbo.Roles(
ID int Identity(1,1) Primary Key,
[User Name] varchar(30) Not null,
[Password] varchar(max) Not null,
[RoleType] varchar(10) Not null
);

GO
CREATE TABLE [Hospital Management].dbo.DoctorDetails (
ID int IDENTITY(1,1) PRIMARY KEY,
DoctorName varchar(20) Not null,
Age int,
Gender varchar(10) Not null,
[Address] varchar(255),
Email varchar(50),
[Contact No] int,
[Specialist In] varchar(10),
Salary varchar(20)
);

GO
create table [Hospital Management].dbo.RoomDetails(
ID int Identity(1,1) Primary Key,
Building varchar(20) Not null,
[Room Type] varchar(20) Not null,
[Room No] int Not null,
Price varchar(10) Not null,
[Status] varchar(10) Not null
);

GO
create Table [Hospital Management].dbo.PatientDetails(
ID int Identity(1,1) Primary Key,
Name varchar(30) Not null,
Age int,
Gender varchar(10) Not null,
[Address] varchar(max),
[Contact No] int,
Diease varchar(20),
[Doctor ID] int Foreign key References [Hospital Management].dbo.DoctorDetails(ID),
[Room Type] varchar(20) ,
[CheckIn Date] datetime,
Building varchar(20),
[Room No] int,
Price varchar(10),
[Status] varchar(10)
);

GO
Create Table[Hospital Management].dbo.DischargeDetails(
ID int Identity(1,1) Primary Key,
[Patient ID] int Foreign Key References [Hospital Management].dbo.PatientDetails(ID) not null,
[CheckIn Date] datetime Not null,
[CheckOut Date] datetime Not null,
[Discharge Status] varchar(10) Not Null,
[Additional Charge] varchar(10),
[Total Price] varchar(10)
);