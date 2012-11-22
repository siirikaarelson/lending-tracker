USE [master]
GO
/****** Object:  Database [Laenutus]    Script Date: 22.11.2012 17:20:02 ******/
CREATE DATABASE [Laenutus]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Laenutus', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\Laenutus.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Laenutus_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\Laenutus_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Laenutus] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Laenutus].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Laenutus] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Laenutus] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Laenutus] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Laenutus] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Laenutus] SET ARITHABORT OFF 
GO
ALTER DATABASE [Laenutus] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Laenutus] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [Laenutus] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Laenutus] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Laenutus] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Laenutus] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Laenutus] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Laenutus] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Laenutus] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Laenutus] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Laenutus] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Laenutus] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Laenutus] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Laenutus] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Laenutus] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Laenutus] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Laenutus] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Laenutus] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Laenutus] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Laenutus] SET  MULTI_USER 
GO
ALTER DATABASE [Laenutus] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Laenutus] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Laenutus] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Laenutus] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [Laenutus]
GO
/****** Object:  Table [dbo].[Kasutajad]    Script Date: 22.11.2012 17:20:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kasutajad](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Username] [nchar](10) NOT NULL,
	[Password] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Kasutajad] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Kataloog]    Script Date: 22.11.2012 17:20:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kataloog](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](50) NOT NULL,
	[Year] [smalldatetime] NOT NULL,
	[Genre] [nchar](10) NOT NULL,
	[Quantity] [tinyint] NOT NULL,
	[Descr] [nvarchar](50) NULL,
	[Comment] [nvarchar](50) NULL,
 CONSTRAINT [PK_PlaadiKat] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Klient]    Script Date: 22.11.2012 17:20:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Klient](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nchar](10) NOT NULL,
	[Surname] [nvarchar](50) NOT NULL,
	[IDnumber] [int] NOT NULL,
	[DOCnumber] [int] NOT NULL,
	[Phone] [int] NOT NULL,
	[Email] [nvarchar](50) NULL,
	[Comment] [nvarchar](50) NULL,
 CONSTRAINT [PK_Klient] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Laenutused]    Script Date: 22.11.2012 17:20:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Laenutused](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[ClientID] [int] NOT NULL,
	[MovieID] [int] NOT NULL,
	[StartDate] [smalldatetime] NOT NULL,
	[EndDate] [smalldatetime] NOT NULL,
	[Notify] [bit] NULL,
	[VIP] [bit] NULL,
	[Problematic] [bit] NULL,
	[Comment] [nvarchar](50) NULL,
 CONSTRAINT [PK_Laenutused] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[Laenutused]  WITH CHECK ADD  CONSTRAINT [FK_Laenutused_Kataloog] FOREIGN KEY([MovieID])
REFERENCES [dbo].[Kataloog] ([id])
GO
ALTER TABLE [dbo].[Laenutused] CHECK CONSTRAINT [FK_Laenutused_Kataloog]
GO
ALTER TABLE [dbo].[Laenutused]  WITH CHECK ADD  CONSTRAINT [FK_Laenutused_Klient1] FOREIGN KEY([ClientID])
REFERENCES [dbo].[Klient] ([id])
GO
ALTER TABLE [dbo].[Laenutused] CHECK CONSTRAINT [FK_Laenutused_Klient1]
GO
USE [master]
GO
ALTER DATABASE [Laenutus] SET  READ_WRITE 
GO
