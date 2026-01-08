-- Student Management System Database Script
-- Database: Student

-- Create Database
IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'Student')
BEGIN
    CREATE DATABASE Student;
END
GO

USE Student;
GO

-- Create Registration Table
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Registration')
BEGIN
    CREATE TABLE Registration (
        regNo INT PRIMARY KEY,
        firstName VARCHAR(50),
        lastName VARCHAR(50),
        dateOfBirth DATETIME,
        gender VARCHAR(50),
        address VARCHAR(50),
        email VARCHAR(50),
        mobilePhone INT,
        homePhone INT,
        parentName VARCHAR(50),
        nic VARCHAR(50),
        contactNo INT
    );
END
GO

-- Create Users Table (for multiple login users)
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Users')
BEGIN
    CREATE TABLE Users (
        userId INT PRIMARY KEY IDENTITY(1,1),
        username VARCHAR(50) UNIQUE,
        password VARCHAR(100)
    );
    
    -- Insert default admin user
    INSERT INTO Users (username, password) VALUES ('Admin', 'Skills@123');
END
GO


