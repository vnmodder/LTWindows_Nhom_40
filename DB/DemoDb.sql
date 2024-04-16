IF EXISTS(SELECT 1 FROM sys.databases WHERE name ='DemoWinForm')
	DROP DATABASE [DemoWinForm]
GO

Create database [DemoWinForm]
GO

use [DemoWinForm]
GO

CREATE TABLE [USER](
	Id INT PRIMARY KEY IDENTITY(1, 1),
	UserName VARCHAR(20) NOT NULL,
	[PassWord] VARCHAR(20) NOT NULL
)

CREATE TABLE [CLASS](
	Id INT PRIMARY KEY IDENTITY(1, 1),
	ClassName NVARCHAR(50) NOT NULL,
)

CREATE TABLE [STUDENT](
	Id INT PRIMARY KEY IDENTITY(1, 1),
	[Name] NVARCHAR(100),
	Gender BIT,
	BirthDay DATE,
	ClassId INT,
	Scores DECIMAL
)

GO

INSERT INTO [USER] (UserName,[PassWord]) VALUES ('user','123')
INSERT INTO [USER] (UserName,[PassWord]) VALUES ('admin','123')
GO

INSERT INTO [CLASS] (ClassName) VALUES (N'Lớp toán rời rạc')
INSERT INTO [CLASS] (ClassName) VALUES (N'Lớp toán cao cấp A1')
INSERT INTO [CLASS] (ClassName) VALUES (N'Lớp toán cao cấp A2')
INSERT INTO [CLASS] (ClassName) VALUES (N'Lớp xác xuất thống kê')
GO

CREATE PROC USP_GetUserById
@Id INT
AS
BEGIN
	SELECT * FROM [USER] WHERE Id = @Id
END
GO

exec USP_GetUserById @Id = 1
GO

CREATE PROC USP_GetUserByUserName
@UserName VARCHAR(20)
AS
BEGIN
	SELECT * FROM [USER] WHERE UserName = @UserName
END
GO

CREATE PROC USP_Login
@UserName VARCHAR(20),
@PassWord VARCHAR(20)
AS
BEGIN
	SELECT * FROM [USER] WHERE UserName = @UserName AND [PassWord]=@PassWord
END
GO