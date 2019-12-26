------------Table Creation-----------------
Create Database Rents_Management
Go
USE Rents_Management
-------Creating Tables ----------
CREATE TABLE Contacts (
Contact_Id          INT PRIMARY KEY IDENTITY(1,1),
Contact_FirstName   VARCHAR(20) NOT NULL,
Contact_LastName    VARCHAR(20) ,
Contact_PhoneNumber VARCHAR(20),
Contact_Email       VARCHAR(30) NOT NULL,
Contact_Adrress     VARCHAR(20),
Contact_Status      VARCHAR(20)
)
CREATE TABLE Owners (
Owner_Id                     INT PRIMARY KEY IDENTITY(1,1), 
Owner_SSN                    INT,
Owner_FirstName              VARCHAR(20),
Owner_LastName               VARCHAR(20),
Owner_PhoneNumber            VARCHAR(20),
Owner_Address                VARCHAR(20), 
Owner_NumberOfBuildingsOwned INT ,
Owner_Income                 INT 
)
CREATE TABLE Users (
User_Name     VARCHAR(10) PRIMARY KEY NOT NULL,
User_Password INT ,
User_Priv     INT
)
CREATE TABLE Buildings (
Building_Id            INT PRIMARY KEY IDENTITY(1,1),
Building_Name          VARCHAR(20) UNIQUE ,
Building_Street        VARCHAR(20) ,
Building_City          VARCHAR(20),
Building_District      VARCHAR(20),
Building_Number        INT ,
Building_NumberOfUnits INT ,
Building_OwnerId       INT FOREIGN KEY REFERENCES Owners ON DELETE SET NULL ON UPDATE CASCADE
)
CREATE TABLE Units (
Unit_Id                INT  PRIMARY KEY IDENTITY(1,1), 
Unit_Type              VARCHAR(20), 
Unit_RequiredRent      INT, 
Unit_State             BIT,
Unit_Area              INT, 
Unit_NumberOfBathrooms INT,
Unit_NumberOfRooms     INT, 
Unit_Condition         VARCHAR(20),
Unit_BuildingNo        INT FOREIGN KEY REFERENCES Buildings ON DELETE SET NULL ON UPDATE CASCADE
)

CREATE TABLE Tenants (
Tenant_Id          INT PRIMARY KEY IDENTITY(1,1),
Tenant_FirstName   VARCHAR(20),
Tenant_LastName    VARCHAR(20),
Tenant_SSN         INT,
Tenant_PhoneNumber VARCHAR(20) ,
Tenant_ContactID   INT FOREIGN KEY REFERENCES Contacts ON DELETE SET NULL ON UPDATE  CASCADE
)  

CREATE TABLE Leases (
Lease_Id               INT PRIMARY KEY IDENTITY(1,1), 
Lease_EndDate          DATE,
Lease_StartDate        DATE,
Lease_Status           BIT,
Lease_RentAmount       FLOAT,
Lease_Interest         FLOAT,
Lease_InterestInterval INT,
Lease_Deposit          FLOAT,
Lease_NextInterestDate DATE,
Lease_TenantId         INT FOREIGN KEY REFERENCES Tenants ON DELETE SET NULL ON UPDATE  CASCADE
)

CREATE TABLE Expenses (
Expense_TranId  INT  PRIMARY KEY IDENTITY(1,1) ,
Expense_Amount  FLOAT,
Expense_Date    DATE,
Expense_Reason  VARCHAR(20),
Expense_LeaseId INT, 
Expense_OwnerId INT FOREIGN KEY REFERENCES Owners  ON DELETE SET NULL ON UPDATE CASCADE
)

CREATE TABLE Employees (
Employee_Id            INT PRIMARY KEY IDENTITY(1,1), 
Employee_FirstName     VARCHAR(20),
Employee_LastName      VARCHAR(20),
Employee_SSN           INT,
Employee_OutstandingSalary   FLOAT,
Employee_Salary        FLOAT,
Employee_HiringDate    DATE ,
Employee_Type          VARCHAR(20),
Employee_PhoneNumber   VARCHAR(20),
Employee_Address       VARCHAR(20), 
Employee_MngrId        INT FOREIGN KEY REFERENCES Employees ON DELETE NO ACTION ON UPDATE NO ACTION,
Employee_OwnerId       INT FOREIGN KEY REFERENCES Owners ON DELETE NO ACTION ON UPDATE NO ACTION,
Employee_ContactId     INT FOREIGN KEY REFERENCES Contacts ON DELETE NO ACTION ON UPDATE NO ACTION
)

CREATE TABLE Rents (
Rent_Id          INT PRIMARY KEY IDENTITY(1,1), 
Rent_Amount      FLOAT,
Rent_DueDate     DATE,
Rent_Statues     BIT,
Rent_CollecterId INT FOREIGN KEY REFERENCES Employees ON DELETE NO ACTION ON UPDATE NO ACTION,
Rent_LeasesId    INT FOREIGN KEY REFERENCES Leases ON DELETE NO ACTION ON UPDATE NO ACTION
)

CREATE TABLE Unit_Rents (
Unit_Rents_TenantId INT FOREIGN KEY REFERENCES Tenants ON DELETE NO ACTION ON UPDATE NO ACTION,
Unit_Rents_UnitId   INT FOREIGN KEY REFERENCES Units ON DELETE NO ACTION ON UPDATE NO ACTION ,
Unit_Rents_RentId   INT FOREIGN KEY REFERENCES Rents ON DELETE NO ACTION ON UPDATE NO ACTION
PRIMARY KEY (Unit_Rents_TenantId,Unit_Rents_UnitId,Unit_Rents_RentId)
)


--------populating Tables---------

INSERT INTO Contacts(Contact_FirstName,Contact_LastName,Contact_PhoneNumber,Contact_Email,Contact_Adrress,Contact_Status) VALUES 
('Kamel','Mohsen','01097000365','kamelmohsen@yahoo.com','23 KhalatStreet','Tenant'),
('Fatma','Adel','01097000365','fatmaadel@yahoo.com','23 KhalatStreet','Tenant'),
('Fatema','Othman','01097000365','fatemaothman@yahoo.com','23 KhalatStreet','Tenant'),
('Ahmed','Nader','01097000365','ahmednader@yahoo.com','23 KhalatStreet','Tenant')
INSERT INTO OWNERS(Owner_SSN,Owner_FirstName,Owner_LastName,Owner_PhoneNumber,Owner_Address,Owner_NumberOfBuildingsOwned,Owner_Income) VALUES
(0001,'Mohsen','Kamel','0505231659','23 KHALAT',9,9000),
(0002,'Magdy','MOHSEN','0505231659','23 KHALAT',8,8000),
(0003,'Mahrous','MOHSEN','0505231659','23 KHALAT',7,7000),
(0004,'Sameh','MOHSEN','0505231659','23 KHALAT',6,600)
INSERT INTO Users VALUES
('ADMIN',123456,1),
('Nader',123456,3),
('Fatma',123456,3),
('Fatema',123456,3),
('Sayed',012654	,3),
('Mahmoud',92837,1)
INSERT INTO Buildings(Building_Name,Building_Street,Building_City,Building_District,Building_Number,Building_NumberOfUnits,Building_OwnerId) VALUES 
('23Khalat','Khalat','Cairo','Shobra',23,12,1),
('24Khalat','Khalat','Cairo','Shobra',24,12,2),
('25Khalat','Khalat','Cairo','Shobra',25,12,3),
('11269','269','Cairo','New Maadi',11,8,4),
('12389','237','New York','Helioplis',11,8,4)
INSERT INTO Units(Unit_Type,Unit_RequiredRent,Unit_State,Unit_Area,Unit_NumberOfBathrooms,Unit_NumberOfRooms,Unit_Condition,Unit_BuildingNo) VALUES 
('Residental',2500,0,95,1,1,'Super Lux',1),
('Residental',3500,1,95,2,2,'Super Lux',2),
('Residental',4500,0,95,1,3,'Super Lux',3),
('Residental',5500,1,95,2,4,'Super Lux',4),
('Residental',4500,0,95,1,3,'Super Lux',3),
('Residental',4500,0,95,1,3,'Super Lux',3),
('Residental',4500,0,95,1,3,'Super Lux',3),
('Commercial',4500,0,95,1,3,'Super Lux',3),
('Residental',4500,0,95,1,3,'Super Lux',3),
('Residental',4500,0,95,1,3,'Super Lux',3),
('Commercial',4500,0,95,1,3,'Super Lux',3),
('Residental',4500,0,95,1,3,'Super Lux',3),
('Residental',4500,0,95,1,3,'Super Lux',3),
('Commercial',4500,0,95,1,3,'Super Lux',3),
('Residental',4500,0,95,1,5,'Super Lux',3),
('Residental',4500,0,95,1,5,'Super Lux',3),
('Commercial',4500,0,95,1,3,'Super Lux',3)

INSERT INTO Tenants(Tenant_FirstName,Tenant_LastName,Tenant_SSN,Tenant_PhoneNumber,Tenant_ContactID) VALUES
 ('Mohammed','Elhosary',1162325,'01097000365',1),
 ('Abo','Maikel',1162326,'01097000365',2),
 ('Kokab','Beshay',1162327,'01097000365',3),
 ('Adel','Asfora',1162328,'01097000365',4),
 ('Adel','Asfora',1162328,'01097000365',4),
 ('Adel','Asfora',1162328,'01097000365',4),
 ('sayed ','Asfora',1162328,'01097000365',4),
 ('khaled','Asfora',1162328,'01097000365',4),
 ('johnny','Asfora',1162328,'01097000365',4),
 ('Adel','Asfora',1162328,'01097000365',4),
 ('Adel','Asfora',1162328,'01097000365',4),
 ('Adel','De le sayed',1162328,'01097000365',4),
 ('Kamel','Abo Leila',1162328,'01097000365',4),
 ('Adel','Asfora',1162328,'01097000365',4),
 ('Adel','Asfora',1162328,'01097000365',4),
 ('Yousef','Abd Elsalam',1162328,'01097000365',4),
 ('Adel','Asfora',1162328,'01097000365',4),
 ('Adel','Asfora',1162328,'01097000365',4),
 ('Adel','Asfora',1162328,'01097000365',4),
 ('Mfish','Fayda',1162328,'01097000365',4),
 ('Adel','Asfora',1162328,'01097000365',4),
 ('Adel','Asfora',1162328,'01097000365',4),
 ('Adel','Nadora',1162328,'01097000365',4),
 ('AbdelRahman','Asfora',1162328,'01097000365',4),
 ('Adel','Asfora',1162328,'01097000365',4)
INSERT INTO Leases(Lease_EndDate,Lease_StartDate,Lease_Status,Lease_RentAmount,Lease_Interest,Lease_InterestInterval,Lease_Deposit,Lease_NextInterestDate,Lease_TenantId) VALUES 
('2019-12-31','2018-12-1',1,2500,10,12,500,'2019-01-01',1),
('2019-12-31','2018-12-1',0,3500,10,12,500,'2019-01-01',2),
('2019-12-31','2018-12-1',1,5500,10,12,500,'2019-01-01',3),
('2019-12-31','2018-12-1',0,8500,10,12,500,'2019-01-01',4),
('2019-12-31','2018-12-1',0,8500,10,12,500,'2019-01-01',4),
('2019-12-31','2018-12-1',0,8500,10,12,500,'2019-01-01',4),
('2019-12-31','2018-12-1',0,8500,10,12,500,'2019-01-01',4),
('2019-12-31','2018-12-1',0,8500,10,12,500,'2019-01-01',4),
('2019-12-31','2018-12-1',0,8500,10,12,500,'2019-01-01',4),
('2019-12-31','2018-12-1',0,8500,10,12,500,'2019-01-01',4),
('2019-12-31','2018-12-1',0,8500,10,12,500,'2019-01-01',4),
('2019-12-31','2018-12-1',0,8500,10,12,500,'2019-01-01',4),
('2019-12-31','2018-12-1',0,8500,10,12,500,'2019-01-01',4),
('2019-12-31','2018-12-1',0,8500,10,12,500,'2019-01-01',4),
('2019-12-31','2018-12-1',0,8500,10,12,500,'2019-01-01',4),
('2019-12-31','2018-12-1',0,8500,10,12,500,'2019-01-01',4),
('2019-12-31','2018-12-1',0,8500,10,12,500,'2019-01-01',4),
('2019-12-31','2018-12-1',0,8500,10,12,500,'2019-01-01',4),
('2019-12-31','2018-12-1',0,8500,10,12,500,'2019-01-01',4),
('2019-12-31','2018-12-1',0,8500,10,12,500,'2019-01-01',4),
('2019-12-31','2018-12-1',0,8500,10,12,500,'2019-01-01',4),
('2019-12-31','2018-12-1',0,8500,10,12,500,'2019-01-01',4),
('2019-12-31','2018-12-1',0,8500,10,12,500,'2019-01-01',4),
('2019-12-31','2018-12-1',0,8500,10,12,500,'2019-01-01',4),
('2019-12-31','2018-12-1',0,8500,10,12,500,'2019-01-01',4)
INSERT INTO Expenses(Expense_Amount,Expense_Date,Expense_Reason,Expense_LeaseId,Expense_OwnerId) VALUES 
(100,'2018-12-12','Bawab',NULL,1),
(100,'2018-12-12','Bawab',NULL,2),
(100,'2018-12-12','Bawab',NULL,3),
(5000,'2018-12-12','Bab Gedeed',1,4),
(3520,'2018-12-13','Bawab',NULL,3)

INSERT INTO Employees(Employee_FirstName,Employee_LastName,Employee_SSN,Employee_Salary,Employee_OutstandingSalary,Employee_HiringDate,Employee_Type,Employee_PhoneNumber,Employee_Address,Employee_OwnerId,Employee_ContactId) VALUES 
('Kamel','Mohsen',1162325,2500,5000,'2018-01-01','Admin','0505231659','23Khalat',1,1),
('Fatma','Mohsen',1162326,3500,7000,'2018-01-01','Cash Collecter','0505231659','23Khalat',2,2),
('Fatema','Mohsen',1162327,4500,9000,'2018-01-01','Cash Collecter','0505231659','23Khalat',3,3),
('Ahmed','Mohsen',1162328,5500,11000,'2018-01-01','Cash Collecter','0505231659','23Khalat',4,4)
INSERT INTO Rents(Rent_Amount,Rent_DueDate,Rent_Statues,Rent_CollecterId) VALUES 
(2500,'2018-12-30',0,2),
(3500,'2018-12-30',1,3),
(4500,'2018-12-30',0,4),
(5500,'2018-12-30',1,2)
INSERT INTO Unit_Rents(Unit_Rents_TenantId,Unit_Rents_UnitId,Unit_Rents_RentId) VALUES 
(1,1,1),
(2,2,2),
(3,3,3),
(4,4,4)