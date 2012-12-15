
--Test data to clients
PRINT 'Insert data to clients table'
INSERT INTO [dbo].[Clients] ([Name],[Surname],[IDnumber],[DOCnumber],[Phone],[Email],[Comment]) VALUES('FirstName0', 'SurName0', 377200527, '201231', 5500000,'1per@gmail.com', '1comment')
INSERT INTO [dbo].[Clients] ([Name],[Surname],[IDnumber],[DOCnumber],[Phone],[Email],[Comment]) VALUES('FirstName2', 'SurName2', 337800527, '401231', 5400000,'2per@gmail.com', '2comment')
INSERT INTO [dbo].[Clients] ([Name],[Surname],[IDnumber],[DOCnumber],[Phone],[Email],[Comment]) VALUES('FirstName3', 'SurName3', 372100587, '501231', 5300000,'3per@gmail.com', '3comment')
INSERT INTO [dbo].[Clients] ([Name],[Surname],[IDnumber],[DOCnumber],[Phone],[Email],[Comment]) VALUES('FirstName4', 'SurName4', 372100522, '601231', 5200000,'4per@gmail.com', '4comment')
INSERT INTO [dbo].[Clients] ([Name],[Surname],[IDnumber],[DOCnumber],[Phone],[Email],[Comment]) VALUES('FirstName5', 'SurName5', 372100524, '701231', 5000000,'5per@gmail.com', '5comment')
INSERT INTO [dbo].[Clients] ([Name],[Surname],[IDnumber],[DOCnumber],[Phone],[Email],[Comment]) VALUES('FirstName6', 'SurName6', 378100527, '101231', 5100000,'6per@gmail.com', '6comment')
INSERT INTO [dbo].[Clients] ([Name],[Surname],[IDnumber],[DOCnumber],[Phone],[Email],[Comment]) VALUES('FirstName7', 'SurName7', 379100522, '301231', 4900000,'7per@gmail.com', '7comment')
INSERT INTO [dbo].[Clients] ([Name],[Surname],[IDnumber],[DOCnumber],[Phone],[Email],[Comment]) VALUES('FirstName8', 'SurName8', 388100527, '001231', 5100000,'8per@gmail.com', '8comment')
INSERT INTO [dbo].[Clients] ([Name],[Surname],[IDnumber],[DOCnumber],[Phone],[Email],[Comment]) VALUES('FirstName9', 'SurName9', 399100527, '01231', 5620000,'9per@gmail.com', '9comment')
INSERT INTO [dbo].[Clients] ([Name],[Surname],[IDnumber],[DOCnumber],[Phone],[Email],[Comment]) VALUES('FirstName1','SurName10',372102527, '901231', 5500009,'10per@gmail.com', '10comment')

--Test data to catalog
PRINT 'Insert data to catalog table'
INSERT INTO [dbo].[Catalog]([Title],[Year],[Genre],[Quantity],[Descr],[Comment]) VALUES('Movie Name1',1991,'Genre1',1,'Description1','Comment1')
INSERT INTO [dbo].[Catalog]([Title],[Year],[Genre],[Quantity],[Descr],[Comment]) VALUES('Movie Name2',1992,'Genre1',2, null,null)
INSERT INTO [dbo].[Catalog]([Title],[Year],[Genre],[Quantity],[Descr],[Comment]) VALUES('Movie Name3',1993,'Genre1',3,'Description3','Comment3')
INSERT INTO [dbo].[Catalog]([Title],[Year],[Genre],[Quantity],[Descr],[Comment]) VALUES('Movie Name4',1994,'Genre2',4, null,null)
INSERT INTO [dbo].[Catalog]([Title],[Year],[Genre],[Quantity],[Descr],[Comment]) VALUES('Movie Name5',1995,'Genre2',5,'Description5','Comment5')
INSERT INTO [dbo].[Catalog]([Title],[Year],[Genre],[Quantity],[Descr],[Comment]) VALUES('Movie Name6',1996,'Genre2',6, null,null)
INSERT INTO [dbo].[Catalog]([Title],[Year],[Genre],[Quantity],[Descr],[Comment]) VALUES('Movie Name7',1997,'Genre3',7,'Description7','Comment7')
INSERT INTO [dbo].[Catalog]([Title],[Year],[Genre],[Quantity],[Descr],[Comment]) VALUES('Movie Name8',1998,'Genre3',8, null,null)
INSERT INTO [dbo].[Catalog]([Title],[Year],[Genre],[Quantity],[Descr],[Comment]) VALUES('Movie Name9',1999,'Genre3',9,'Description9','Comment9')
INSERT INTO [dbo].[Catalog]([Title],[Year],[Genre],[Quantity],[Descr],[Comment]) VALUES('Movie Name10',2000,'Genre4',10, null,null)
GO

--Test data to rentals
PRINT 'Insert data to rentals table'
INSERT INTO [dbo].[Rentals] ([ClientID],[MovieID],[StartDate],[EndDate],[Notify],[VIP],[Problematic],[Comment]) VALUES (1,1, getdate(),dateadd(dd, +7, getdate()),0,1,0,'Rental Comment1')
INSERT INTO [dbo].[Rentals] ([ClientID],[MovieID],[StartDate],[EndDate],[Notify],[VIP],[Problematic],[Comment]) VALUES (1,2, dateadd(dd, +14, getdate()),dateadd(dd, +28, getdate()),0,1,0,'Rental Comment1')
INSERT INTO [dbo].[Rentals] ([ClientID],[MovieID],[StartDate],[EndDate],[Notify],[VIP],[Problematic],[Comment]) VALUES (2,2, getdate(),dateadd(dd, +7, getdate()),0,1,0,'Rental Comment2')
INSERT INTO [dbo].[Rentals] ([ClientID],[MovieID],[StartDate],[EndDate],[Notify],[VIP],[Problematic],[Comment]) VALUES (2,3, dateadd(dd, +14, getdate()),dateadd(dd, +28, getdate()),0,1,0,'Rental Comment2')
INSERT INTO [dbo].[Rentals] ([ClientID],[MovieID],[StartDate],[EndDate],[Notify],[VIP],[Problematic],[Comment]) VALUES (3,3, getdate(),dateadd(dd, +7, getdate()),0,1,0,'Rental Comment3')
INSERT INTO [dbo].[Rentals] ([ClientID],[MovieID],[StartDate],[EndDate],[Notify],[VIP],[Problematic],[Comment]) VALUES (3,4, dateadd(dd, +14, getdate()),dateadd(dd, +28, getdate()),0,1,0,'Rental Comment3')
INSERT INTO [dbo].[Rentals] ([ClientID],[MovieID],[StartDate],[EndDate],[Notify],[VIP],[Problematic],[Comment]) VALUES (4,4, getdate(),dateadd(dd, +7, getdate()),0,1,0,'Rental Comment4')
INSERT INTO [dbo].[Rentals] ([ClientID],[MovieID],[StartDate],[EndDate],[Notify],[VIP],[Problematic],[Comment]) VALUES (4,5, dateadd(dd, +14, getdate()),dateadd(dd, +28, getdate()),0,1,0,'Rental Comment4')
INSERT INTO [dbo].[Rentals] ([ClientID],[MovieID],[StartDate],[EndDate],[Notify],[VIP],[Problematic],[Comment]) VALUES (5,4, getdate(),dateadd(dd, +7, getdate()),0,1,0,'Rental Comment4')
INSERT INTO [dbo].[Rentals] ([ClientID],[MovieID],[StartDate],[EndDate],[Notify],[VIP],[Problematic],[Comment]) VALUES (5,5, dateadd(dd, +14, getdate()),dateadd(dd, +28, getdate()),0,1,0,'Rental Comment4')
INSERT INTO [dbo].[Rentals] ([ClientID],[MovieID],[StartDate],[EndDate],[Notify],[VIP],[Problematic],[Comment]) VALUES (6,6, getdate(),dateadd(dd, +7, getdate()),0,1,0,'Rental Comment5')
INSERT INTO [dbo].[Rentals] ([ClientID],[MovieID],[StartDate],[EndDate],[Notify],[VIP],[Problematic],[Comment]) VALUES (6,7, dateadd(dd, +14, getdate()),dateadd(dd, +28, getdate()),0,1,0,'Rental Comment5')
INSERT INTO [dbo].[Rentals] ([ClientID],[MovieID],[StartDate],[EndDate],[Notify],[VIP],[Problematic],[Comment]) VALUES (7,6, getdate(),dateadd(dd, +7, getdate()),0,1,0,'Rental Comment6')
INSERT INTO [dbo].[Rentals] ([ClientID],[MovieID],[StartDate],[EndDate],[Notify],[VIP],[Problematic],[Comment]) VALUES (7,7, dateadd(dd, +14, getdate()),dateadd(dd, +28, getdate()),0,1,0,'Rental Comment6')
INSERT INTO [dbo].[Rentals] ([ClientID],[MovieID],[StartDate],[EndDate],[Notify],[VIP],[Problematic],[Comment]) VALUES (8,7, getdate(),dateadd(dd, +7, getdate()),0,1,0,'Rental Comment7')
INSERT INTO [dbo].[Rentals] ([ClientID],[MovieID],[StartDate],[EndDate],[Notify],[VIP],[Problematic],[Comment]) VALUES (8,8, dateadd(dd, +14, getdate()),dateadd(dd, +28, getdate()),0,1,0,'Rental Comment7')
INSERT INTO [dbo].[Rentals] ([ClientID],[MovieID],[StartDate],[EndDate],[Notify],[VIP],[Problematic],[Comment]) VALUES (9,9, getdate(),dateadd(dd, +7, getdate()),0,1,0,'Rental Comment8')
INSERT INTO [dbo].[Rentals] ([ClientID],[MovieID],[StartDate],[EndDate],[Notify],[VIP],[Problematic],[Comment]) VALUES (9,10, dateadd(dd, +14, getdate()),dateadd(dd, +28, getdate()),0,1,0,'Rental Comment8')
INSERT INTO [dbo].[Rentals] ([ClientID],[MovieID],[StartDate],[EndDate],[Notify],[VIP],[Problematic],[Comment]) VALUES (10,9, getdate(),dateadd(dd, +7, getdate()),0,1,0,'Rental Comment10')
INSERT INTO [dbo].[Rentals] ([ClientID],[MovieID],[StartDate],[EndDate],[Notify],[VIP],[Problematic],[Comment]) VALUES (10,10, dateadd(dd, +14, getdate()),dateadd(dd, +28, getdate()),0,1,0,'Rental Comment10')

--Test data to users
PRINT 'Insert data to users table'
INSERT INTO [dbo].[Users] ([Username],[Password]) VALUES ('TheGood', 'qwert123')