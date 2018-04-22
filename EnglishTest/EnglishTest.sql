CREATE DATABASE EnglishTest
GO

USE EnglishTest
GO

CREATE TABLE [dbo].[UserAdmin]
(
	[UserName] VARCHAR(50) PRIMARY KEY,
	[Password] VARCHAR(50),
	[Role] INT
)
GO

CREATE TABLE [dbo].[UserCandidate]
(
	[UserName] VARCHAR(50) PRIMARY KEY,
	[Password] VARCHAR(50),
	[FullName] NVARCHAR(250),
	[DateOfBirth] DATE,
	[Role] BIT,
	[LevelID] INT,
	[PositionID] INT,
	[UnitID] INT,
	[Mark] BIT,
	[Status] BIT
)
GO

CREATE TABLE [dbo].[Unit]
(
	[UnitID] INT PRIMARY KEY IDENTITY,
	[UnitName] VARCHAR(250)
)
GO

ALTER TABLE [dbo].[UserCandidate]
ADD CONSTRAINT FK_UCUnitID FOREIGN KEY ([UnitID]) REFERENCES [dbo].[Unit]([UnitID])
GO

CREATE TABLE [dbo].[Level]
(
	[LevelID] INT PRIMARY KEY IDENTITY,
	[LevelName] VARCHAR(250)
)
GO

ALTER TABLE [dbo].[UserCandidate]
ADD CONSTRAINT FK_UCLevelID FOREIGN KEY ([LevelID]) REFERENCES [dbo].[Level]([LevelID])
GO

CREATE TABLE [dbo].[Position]
(
	[PositionID] INT PRIMARY KEY IDENTITY,
	[PositionName] VARCHAR(250)
)
GO

ALTER TABLE [dbo].[UserCandidate]
ADD CONSTRAINT FK_UCPositionID FOREIGN KEY ([PositionID]) REFERENCES [dbo].[Position]([PositionID])
GO

CREATE TABLE [dbo].[TestKit]
(
	[TestKitID] INT PRIMARY KEY IDENTITY,
	[TypeKitName] VARCHAR(250),
	[Level] INT,
	[Amount] INT,
	[Minutes] INT
)
GO

CREATE TABLE [dbo].[Question]
(
	[QuestionID] INT PRIMARY KEY IDENTITY,
	[Content] VARCHAR(MAX),
	[Level] INT,
	[TestKitID] INT,
	[CreateBy] VARCHAR(50),
	[CreateDate] DATE,
	[UpdateBy] VARCHAR(50),
	[UpdateDate] DATE
)
GO

ALTER TABLE [dbo].[Question]
ADD CONSTRAINT FK_QTKID FOREIGN KEY ([TestKitID]) REFERENCES [dbo].[TestKit]([TestKitID])
GO

CREATE TABLE [dbo].[Answer]
(
	[AnswerID] INT PRIMARY KEY IDENTITY,
	[Content] VARCHAR(MAX),
	[Status] BIT,
	[QuestionID] INT,
	[CreateBy] VARCHAR(50),
	[Createdate] DATE,
	[UpdateBy] VARCHAR(50),
	[UpdateDate] DATE
)
GO

ALTER TABLE [dbo].[Answer]
ADD CONSTRAINT FK_AQuestionID FOREIGN KEY ([QuestionID]) REFERENCES [dbo].[Question]([QuestionID])
GO

CREATE TABLE [dbo].[Result]
(
	[ResultID] INT PRIMARY KEY IDENTITY,
	[UserName] VARCHAR(50),
	[NumberCorrect] INT,
	[TestKitID] INT,
	[Score] FLOAT
)
GO

ALTER TABLE [dbo].[Result]
ADD CONSTRAINT FK_RTKID FOREIGN KEY ([TestKitID]) REFERENCES [dbo].[TestKit]([TestKitID])
GO
ALTER TABLE [dbo].[Result]
ADD CONSTRAINT FK_RUserName FOREIGN KEY ([UserName]) REFERENCES [dbo].[UserCandidate]([UserName])
GO
