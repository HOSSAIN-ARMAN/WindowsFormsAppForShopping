CREATE DATABASE SmallBusinessManagementSystem
USE[SmallBusinessManagementSystem]

CREATE TABLE Categories(
Id INT IDENTITY(1,1) PRIMARY KEY,
Code VARCHAR(10),
Name VARCHAR(50)
)

SELECT * FROM Categories

CREATE TABLE Products(
Id INT IDENTITY(1,1) PRIMARY KEY,
CategoryName VARCHAR(50),
Code VARCHAR(50),
Name VARCHAR(50),
ReOrder INT,
Description VARCHAR(50),
Constant int DEFAULT 1
)

SELECT distinct Name FROM Products WHERE CategoryName = 'Mobile'

SELECT * FROM Products

SELECT (Id) FROM Products WHERE Name = 'i-phone'

--SELECT CategoryName, Code, Name, ReOrder, Description
--FROM[Products] JOIN Categories
--ON[Products].CategoryName = Categories.Name

CREATE TABLE Customer(
Id INT IDENTITY(1,1) PRIMARY KEY,
CustomerCode VARCHAR(255),
CustomerName VARCHAR(255),
CustomerAddress VARCHAR(255),
CustomerEmail VARCHAR(255),
Contact VARCHAR(255),
LoyaltyPoint INT
)

SELECT * FROM Customer


CREATE TABLE Supplier(
Id INT IDENTITY(1,1) PRIMARY KEY,
Code VARCHAR(50),
Name VARCHAR(50),
Address VARCHAR(50),
Email VARCHAR(50),
Contact VARCHAR(50),
Person VARCHAR(50),
)
SELECT * FROM Supplier;

--CREATE TABLE Purchase(
--Id INT identity(1,1)PRIMARY KEY,
--ProductCode VARCHAR(50),
--ManufactureDate VARCHAR(50),
--ExpireDate VARCHAR(50),
--Quantity INT,
--UnitePrice INT,
--TotalPrice INT,
--PreviousUnitPrice INT DEFAULT 0,
--PreviousMRP INT DEFAULT 0,
--Mrp INT,
--Remarks VARCHAR(50),
--SupplierDate VARCHAR(50),
--supplierInvoice INT,
--SupplierName VARCHAR(50),
--ConstantValue INT DEFAULT 1
--)


SELECT *FROM Purchase

CREATE TABLE AddPurchase(
Id INT identity(1,1)PRIMARY KEY,
ProductCode VARCHAR(50),
ManufactureDate VARCHAR(50),
ExpireDate VARCHAR(50),
Quantity INT,
UnitePrice INT,
TotalPrice INT,
Mrp INT,
Remarks VARCHAR(50),
SupplierDate VARCHAR(50),
supplierInvoice Varchar(50),
SupplierName VARCHAR(50),
--ConstantValue INT DEFAULT 1
)

SELECT * FROM AddPurchase
SELECT SUM(Quantity) FROM AddPurchase WHERE ProductCode = 'Pizza ( f999 )'

SELECT TOP (1)UnitePrice FROM AddPurchase WHERE ProductCode = 'Pizza ( f999 )'

SELECT  TOP(1)UnitePrice FROM AddPurchase WHERE ProductCode = 'Pizza ( f999 )' ORDER BY UnitePrice DESC 


