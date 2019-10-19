CREATE DATABASE SmallBusinessManagementSystem
USE[SmallBusinessManagementSystem]

CREATE TABLE Categories(
Id INT IDENTITY(1,1),
Code VARCHAR(10),
Name VARCHAR(50)
)
SELECT * FROM Categories

CREATE TABLE Products(
Id INT IDENTITY(1,1),
CategoryName VARCHAR(50),
Code VARCHAR(50),
Name VARCHAR(50),
ReOrder INT,
Description VARCHAR(50)
)
SELECT * FROM Products