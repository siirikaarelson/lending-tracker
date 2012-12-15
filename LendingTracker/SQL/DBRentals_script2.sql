USE [master]
GO
/****** Object:  Database [DBRentals]    Script Date: 11.12.2012 21:44:55 ******/
CREATE DATABASE [DBRentals]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DBRentals', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\DBRentals.mdf' , SIZE = 4160KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'DBRentals_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\DBRentals_log.ldf' , SIZE = 1040KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [DBRentals] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DBRentals].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DBRentals] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DBRentals] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DBRentals] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DBRentals] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DBRentals] SET ARITHABORT OFF 
GO
ALTER DATABASE [DBRentals] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DBRentals] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [DBRentals] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DBRentals] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DBRentals] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DBRentals] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DBRentals] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DBRentals] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DBRentals] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DBRentals] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DBRentals] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DBRentals] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DBRentals] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DBRentals] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DBRentals] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DBRentals] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DBRentals] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DBRentals] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DBRentals] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [DBRentals] SET  MULTI_USER 
GO
ALTER DATABASE [DBRentals] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DBRentals] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DBRentals] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DBRentals] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [DBRentals]
GO
/****** Object:  Table [dbo].[Catalog]    Script Date: 11.12.2012 21:44:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Catalog](
  [id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](50) NOT NULL,
	[Year] [int] NOT NULL,
	[Genre] [nchar](10) NOT NULL,
	[Quantity] [tinyint] NOT NULL,
	[Descr] [nvarchar](50) NULL,
	[Comment] [nvarchar](50) NULL,
	[Price] [float] NULL,
 CONSTRAINT [PK_PlaadiKat] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Clients]    Script Date: 11.12.2012 21:44:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clients](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Surname] [nvarchar](50) NOT NULL,
	[IDnumber] [bigint] NOT NULL,
	[DOCnumber] [nvarchar](50) NOT NULL,
	[Phone] [int] NOT NULL,
	[Email] [nvarchar](50) NULL,
	[Comment] [nvarchar](50) NULL,
	[VIP] [bit] NULL,
	[Problematic] [bit] NULL,
 CONSTRAINT [PK_Client] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Rentals]    Script Date: 11.12.2012 21:44:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rentals](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[ClientID] [int] NOT NULL,
	[MovieID] [int] NOT NULL,
	[StartDate] [smalldatetime] NOT NULL,
	[EndDate] [smalldatetime] NOT NULL,
	[Notify] [bit] NOT NULL,
	[Comment] [nvarchar](50) NULL
 CONSTRAINT [PK_DBRentalsed] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Users]    Script Date: 11.12.2012 21:44:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Username] [nchar](10) NOT NULL,
	[Password] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
ALTER TABLE [dbo].[Rentals]  WITH CHECK ADD  CONSTRAINT [FK_DBRentalsed_Catalog] FOREIGN KEY([MovieID])
REFERENCES [dbo].[Catalog] ([id])
GO
ALTER TABLE [dbo].[Rentals] CHECK CONSTRAINT [FK_DBRentalsed_Catalog]
GO
ALTER TABLE [dbo].[Rentals]  WITH CHECK ADD  CONSTRAINT [FK_DBRentalsed_Client1] FOREIGN KEY([ClientID])
REFERENCES [dbo].[Clients] ([id])
GO
ALTER TABLE [dbo].[Rentals] CHECK CONSTRAINT [FK_DBRentalsed_Client1]
GO
USE [master]
GO
ALTER DATABASE [DBRentals] SET  READ_WRITE 
GO

USE [DBRentals]
GO

--Test data to clients
PRINT 'Insert data to clients table'
INSERT INTO [dbo].[Clients] ([Name],[Surname],[IDnumber],[DOCnumber],[Phone],[Email],[Comment],[VIP],[Problematic]) VALUES('FirstName0', 'SurName0', 37720052709, 'K201231', 5500000,'1per@gmail.com', '1comment',1,0)
INSERT INTO [dbo].[Clients] ([Name],[Surname],[IDnumber],[DOCnumber],[Phone],[Email],[Comment],[VIP],[Problematic]) VALUES('FirstName2', 'SurName2', 33780052722, 'K401231', 5400000,'2per@gmail.com', '2comment',0,1)
INSERT INTO [dbo].[Clients] ([Name],[Surname],[IDnumber],[DOCnumber],[Phone],[Email],[Comment],[VIP],[Problematic]) VALUES('FirstName3', 'SurName3', 37210058744, 'K501231', 5300000,'3per@gmail.com', '3comment',1,0)
INSERT INTO [dbo].[Clients] ([Name],[Surname],[IDnumber],[DOCnumber],[Phone],[Email],[Comment],[VIP],[Problematic]) VALUES('FirstName4', 'SurName4', 37210052255, 'K601231', 5200000,'4per@gmail.com', '4comment',0,1)
INSERT INTO [dbo].[Clients] ([Name],[Surname],[IDnumber],[DOCnumber],[Phone],[Email],[Comment],[VIP],[Problematic]) VALUES('FirstName5', 'SurName5', 37210052466, 'K701231', 5000000,'5per@gmail.com', '5comment',1,0)
INSERT INTO [dbo].[Clients] ([Name],[Surname],[IDnumber],[DOCnumber],[Phone],[Email],[Comment],[VIP],[Problematic]) VALUES('FirstName6', 'SurName6', 37810052777, 'A101231', 5100000,'6per@gmail.com', '6comment',0,1)
INSERT INTO [dbo].[Clients] ([Name],[Surname],[IDnumber],[DOCnumber],[Phone],[Email],[Comment],[VIP],[Problematic]) VALUES('FirstName7', 'SurName7', 37910052233, 'A301231', 4900000,'7per@gmail.com', '7comment',1,0)
INSERT INTO [dbo].[Clients] ([Name],[Surname],[IDnumber],[DOCnumber],[Phone],[Email],[Comment],[VIP],[Problematic]) VALUES('FirstName8', 'SurName8', 38810052722, 'AA01231', 5100000,'8per@gmail.com', '8comment',0,1)
INSERT INTO [dbo].[Clients] ([Name],[Surname],[IDnumber],[DOCnumber],[Phone],[Email],[Comment],[VIP],[Problematic]) VALUES('FirstName9', 'SurName9', 39910052744, 'KK01231', 5620000,'9per@gmail.com', '9comment',1,0)
INSERT INTO [dbo].[Clients] ([Name],[Surname],[IDnumber],[DOCnumber],[Phone],[Email],[Comment],[VIP],[Problematic]) VALUES('FirstName10','SurName10',37210252721, 'KO01231', 5500009,'10per@gmail.com', '10comment',0,1)

--Test data to catalog
PRINT 'Insert data to catalog table'
INSERT INTO [dbo].[Catalog]([Title],[Year],[Genre],[Quantity],[Descr],[Comment],[Price]) VALUES('Movie Name1',1991,'Genre1',1,'Description1','Comment1',23)
INSERT INTO [dbo].[Catalog]([Title],[Year],[Genre],[Quantity],[Descr],[Comment],[Price]) VALUES('Movie Name2',1992,'Genre1',2, null,null,43)
INSERT INTO [dbo].[Catalog]([Title],[Year],[Genre],[Quantity],[Descr],[Comment],[Price]) VALUES('Movie Name3',1993,'Genre1',3,'Description3','Comment3',25)
INSERT INTO [dbo].[Catalog]([Title],[Year],[Genre],[Quantity],[Descr],[Comment],[Price]) VALUES('Movie Name4',1994,'Genre2',4, null,null,23)
INSERT INTO [dbo].[Catalog]([Title],[Year],[Genre],[Quantity],[Descr],[Comment],[Price]) VALUES('Movie Name5',1995,'Genre2',5,'Description5','Comment5',33)
INSERT INTO [dbo].[Catalog]([Title],[Year],[Genre],[Quantity],[Descr],[Comment],[Price]) VALUES('Movie Name6',1996,'Genre2',6, null,null,31)
INSERT INTO [dbo].[Catalog]([Title],[Year],[Genre],[Quantity],[Descr],[Comment],[Price]) VALUES('Movie Name7',1997,'Genre3',7,'Description7','Comment7',34)
INSERT INTO [dbo].[Catalog]([Title],[Year],[Genre],[Quantity],[Descr],[Comment],[Price]) VALUES('Movie Name8',1998,'Genre3',8, null,null,23)
INSERT INTO [dbo].[Catalog]([Title],[Year],[Genre],[Quantity],[Descr],[Comment],[Price]) VALUES('Movie Name9',1999,'Genre3',9,'Description9','Comment9',55)
INSERT INTO [dbo].[Catalog]([Title],[Year],[Genre],[Quantity],[Descr],[Comment],[Price]) VALUES('Movie Name10',2000,'Genre4',10, null,null,12)
GO

--Test data to rentals
PRINT 'Insert data to rentals table'
INSERT INTO [dbo].[Rentals] ([ClientID],[MovieID],[StartDate],[EndDate],[Notify],[Comment]) VALUES (1,1, getdate(),dateadd(dd, +7, getdate()),0,'Rental Comment1')
INSERT INTO [dbo].[Rentals] ([ClientID],[MovieID],[StartDate],[EndDate],[Notify],[Comment]) VALUES (1,2, dateadd(dd, +14, getdate()),dateadd(dd, +28, getdate()),1,'Rental Comment1')
INSERT INTO [dbo].[Rentals] ([ClientID],[MovieID],[StartDate],[EndDate],[Notify],[Comment]) VALUES (2,2, getdate(),dateadd(dd, +7, getdate()),0,'Rental Comment2')
INSERT INTO [dbo].[Rentals] ([ClientID],[MovieID],[StartDate],[EndDate],[Notify],[Comment]) VALUES (2,3, dateadd(dd, +14, getdate()),dateadd(dd, +28, getdate()),1,'Rental Comment2')
INSERT INTO [dbo].[Rentals] ([ClientID],[MovieID],[StartDate],[EndDate],[Notify],[Comment]) VALUES (3,3, getdate(),dateadd(dd, +7, getdate()),0,'Rental Comment3')
INSERT INTO [dbo].[Rentals] ([ClientID],[MovieID],[StartDate],[EndDate],[Notify],[Comment]) VALUES (3,4, dateadd(dd, +14, getdate()),dateadd(dd, +28, getdate()),1,'Rental Comment3')
INSERT INTO [dbo].[Rentals] ([ClientID],[MovieID],[StartDate],[EndDate],[Notify],[Comment]) VALUES (4,4, getdate(),dateadd(dd, +7, getdate()),0,'Rental Comment4')
INSERT INTO [dbo].[Rentals] ([ClientID],[MovieID],[StartDate],[EndDate],[Notify],[Comment]) VALUES (4,5, dateadd(dd, +14, getdate()),dateadd(dd, +28, getdate()),1,'Rental Comment4')
INSERT INTO [dbo].[Rentals] ([ClientID],[MovieID],[StartDate],[EndDate],[Notify],[Comment]) VALUES (5,4, getdate(),dateadd(dd, +7, getdate()),0,'Rental Comment4')
INSERT INTO [dbo].[Rentals] ([ClientID],[MovieID],[StartDate],[EndDate],[Notify],[Comment]) VALUES (5,5, dateadd(dd, +14, getdate()),dateadd(dd, +28, getdate()),1,'Rental Comment4')
INSERT INTO [dbo].[Rentals] ([ClientID],[MovieID],[StartDate],[EndDate],[Notify],[Comment]) VALUES (6,6, getdate(),dateadd(dd, +7, getdate()),0,'Rental Comment5')
INSERT INTO [dbo].[Rentals] ([ClientID],[MovieID],[StartDate],[EndDate],[Notify],[Comment]) VALUES (6,7, dateadd(dd, +14, getdate()),dateadd(dd, +28, getdate()),1,'Rental Comment5')
INSERT INTO [dbo].[Rentals] ([ClientID],[MovieID],[StartDate],[EndDate],[Notify],[Comment]) VALUES (7,6, getdate(),dateadd(dd, +7, getdate()),0,'Rental Comment6')
INSERT INTO [dbo].[Rentals] ([ClientID],[MovieID],[StartDate],[EndDate],[Notify],[Comment]) VALUES (7,7, dateadd(dd, +14, getdate()),dateadd(dd, +28, getdate()),1,'Rental Comment6')
INSERT INTO [dbo].[Rentals] ([ClientID],[MovieID],[StartDate],[EndDate],[Notify],[Comment]) VALUES (8,7, getdate(),dateadd(dd, +7, getdate()),0,'Rental Comment7')
INSERT INTO [dbo].[Rentals] ([ClientID],[MovieID],[StartDate],[EndDate],[Notify],[Comment]) VALUES (8,8, dateadd(dd, +14, getdate()),dateadd(dd, +28, getdate()),1,'Rental Comment7')
INSERT INTO [dbo].[Rentals] ([ClientID],[MovieID],[StartDate],[EndDate],[Notify],[Comment]) VALUES (9,9, getdate(),dateadd(dd, +7, getdate()),0,'Rental Comment8')
INSERT INTO [dbo].[Rentals] ([ClientID],[MovieID],[StartDate],[EndDate],[Notify],[Comment]) VALUES (9,10, dateadd(dd, +14, getdate()),dateadd(dd, +28, getdate()),1,'Rental Comment8')
INSERT INTO [dbo].[Rentals] ([ClientID],[MovieID],[StartDate],[EndDate],[Notify],[Comment]) VALUES (10,9, getdate(),dateadd(dd, +7, getdate()),0,'Rental Comment10')
INSERT INTO [dbo].[Rentals] ([ClientID],[MovieID],[StartDate],[EndDate],[Notify],[Comment]) VALUES (10,10, dateadd(dd, +14, getdate()),dateadd(dd, +28, getdate()),1,'Rental Comment10')

--Test data to users
PRINT 'Insert data to users table'
INSERT INTO [dbo].[Users] ([Username],[Password]) VALUES ('TheGood', 'qwert123')
