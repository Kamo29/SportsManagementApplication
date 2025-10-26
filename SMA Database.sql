-- Create the database
CREATE DATABASE KP_SportsDB;
GO

-- Use the database
USE KP_SportsDB;
GO

-- Create Students table
CREATE TABLE Students (
    IdNum INT PRIMARY KEY,           -- Unique ID number
    Name NVARCHAR(50) NOT NULL,
    Surname NVARCHAR(50) NOT NULL,
    Gender NVARCHAR(10),             -- Male/Female/Other
    PhoneNum BIGINT                  -- Phone number as numeric
);
GO

-- Optional: insert sample data
INSERT INTO Students (IdNum, Name, Surname, Gender, PhoneNum)
VALUES 
(1001, 'John', 'Doe', 'Male', 27831234567),
(1002, 'Jane', 'Smith', 'Female', 27839876543);
GO

-- Check the table
SELECT * FROM Students;
