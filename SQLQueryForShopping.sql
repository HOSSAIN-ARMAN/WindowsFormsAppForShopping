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
Description VARCHAR(50)
)



SELECT * FROM Products

--SELECT CategoryName, Code, Name, ReOrder, Description
--FROM[Products] JOIN Categories
--ON[Products].CategoryName = Categories.Name

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

CREATE TABLE Purchase(
Id INT identity(1,1)PRIMARY KEY,

)