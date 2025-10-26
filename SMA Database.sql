-- 1️⃣ Create the database
CREATE DATABASE KP_SportsDB;
GO

-- 2️⃣ Use the database
USE KP_SportsDB;
GO

-- 3️⃣ Create Students table
CREATE TABLE Students (
    IdNum INT PRIMARY KEY,           -- Unique ID number
    Name NVARCHAR(50) NOT NULL,
    Surname NVARCHAR(50) NOT NULL,
    Gender NVARCHAR(10),             -- Male/Female/Other
    PhoneNum BIGINT                  -- Phone number as numeric
);
GO

-- 4️⃣ Create Login table (for Login_Form)
CREATE TABLE Logins (
    LoginID INT IDENTITY(1,1) PRIMARY KEY,
    IdNum INT NOT NULL,              -- Links to Students
    Username NVARCHAR(50) UNIQUE NOT NULL,
    PasswordHash NVARCHAR(256) NOT NULL,
    FOREIGN KEY (IdNum) REFERENCES Students(IdNum)
);
GO

-- 5️⃣ Optional: actions table if needed in future
CREATE TABLE StudentActions (
    ActionID INT IDENTITY(1,1) PRIMARY KEY,
    IdNum INT NOT NULL,
    ActionType NVARCHAR(50),        -- Insert / Update / Delete
    ActionDate DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (IdNum) REFERENCES Students(IdNum)
);
GO

-- 6️⃣ Sample data for Students
INSERT INTO Students (IdNum, Name, Surname, Gender, PhoneNum)
VALUES 
(1001, 'John', 'Doe', 'Male', 27831234567),
(1002, 'Jane', 'Smith', 'Female', 27839876543);
GO

-- 7️⃣ Sample data for Logins
INSERT INTO Logins (IdNum, Username, PasswordHash)
VALUES
(1001, 'johndoe', 'hashedpassword1'),
(1002, 'janesmith', 'hashedpassword2');
GO

-- 8️⃣ Verify tables
SELECT * FROM Students;
SELECT * FROM Logins;
SELECT * FROM StudentActions;
