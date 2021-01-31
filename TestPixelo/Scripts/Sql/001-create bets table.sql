IF NOT EXISTS(SELECT * FROM sys.databases WHERE name = 'test')
  BEGIN
    CREATE DATABASE [test]
  END
GO

USE [test]
GO
IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Bets' and xtype='U')
BEGIN

CREATE TABLE Bets(
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[MatchDescription] [nvarchar](100) NOT NULL,
	[RateOne] DECIMAL(10,2) NOT NULL,
	[RateDraw] DECIMAL(10,2) NOT NULL,
    [RateTwo] DECIMAL(10,2) NOT NULL,
	
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
))

END