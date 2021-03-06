USE [master]
GO
/****** Object:  Database [hamwic]    Script Date: 10/04/2012 23:28:36 ******/
CREATE DATABASE [hamwic] ON  PRIMARY 
( NAME = N'hamwic', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.DB\MSSQL\DATA\hamwic.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'hamwic_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.DB\MSSQL\DATA\hamwic_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [hamwic] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [hamwic].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [hamwic] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [hamwic] SET ANSI_NULLS OFF
GO
ALTER DATABASE [hamwic] SET ANSI_PADDING OFF
GO
ALTER DATABASE [hamwic] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [hamwic] SET ARITHABORT OFF
GO
ALTER DATABASE [hamwic] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [hamwic] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [hamwic] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [hamwic] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [hamwic] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [hamwic] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [hamwic] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [hamwic] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [hamwic] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [hamwic] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [hamwic] SET  DISABLE_BROKER
GO
ALTER DATABASE [hamwic] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [hamwic] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [hamwic] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [hamwic] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [hamwic] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [hamwic] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [hamwic] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [hamwic] SET  READ_WRITE
GO
ALTER DATABASE [hamwic] SET RECOVERY FULL
GO
ALTER DATABASE [hamwic] SET  MULTI_USER
GO
ALTER DATABASE [hamwic] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [hamwic] SET DB_CHAINING OFF
GO
USE [hamwic]
GO
/****** Object:  Table [dbo].[Subgroup]    Script Date: 10/04/2012 23:28:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Subgroup](
	[id] [int] NOT NULL,
	[Name] [int] NOT NULL,
 CONSTRAINT [PK_Subgroup] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Member]    Script Date: 10/04/2012 23:28:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Member](
	[id] [int] NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[Surname] [nvarchar](50) NOT NULL,
	[Nickname] [nvarchar](50) NULL,
	[CurrentMember] [bit] NOT NULL,
 CONSTRAINT [PK_Member] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Address]    Script Date: 10/04/2012 23:28:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Address](
	[id] [int] NOT NULL,
	[Details] [varchar](255) NOT NULL,
 CONSTRAINT [PK_Address] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SubgroupMembership]    Script Date: 10/04/2012 23:28:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SubgroupMembership](
	[id] [int] NOT NULL,
	[MemberId] [int] NOT NULL,
	[DateFrom] [datetime] NOT NULL,
	[DateTo] [datetime] NULL,
	[Officer] [bit] NOT NULL,
	[SubGroupId] [int] NOT NULL,
 CONSTRAINT [PK_SubgroupMembership] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MemberAddress]    Script Date: 10/04/2012 23:28:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MemberAddress](
	[id] [int] NOT NULL,
	[MemberId] [int] NOT NULL,
	[AddressId] [int] NOT NULL,
 CONSTRAINT [PK_MemberAddress] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Meeting]    Script Date: 10/04/2012 23:28:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Meeting](
	[id] [int] NOT NULL,
	[SubgroupId] [int] NULL,
	[Location] [varchar](50) NULL,
	[DateTimeFrom] [datetime] NOT NULL,
	[DateTimeTo] [datetime] NOT NULL,
 CONSTRAINT [PK_Meeting] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[RentPayment]    Script Date: 10/04/2012 23:28:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RentPayment](
	[id] [int] NOT NULL,
	[DatePaid] [smalldatetime] NOT NULL,
	[MemberId] [int] NOT NULL,
	[Value] [money] NULL,
 CONSTRAINT [PK_RentPayment] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Property]    Script Date: 10/04/2012 23:28:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Property](
	[id] [int] NOT NULL,
	[Name] [nvarchar](50) NULL,
	[AddressId] [int] NOT NULL,
 CONSTRAINT [PK_Property] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Room]    Script Date: 10/04/2012 23:28:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Room](
	[id] [int] NOT NULL,
	[Number] [int] NOT NULL,
	[PropertyId] [int] NOT NULL,
 CONSTRAINT [PK_Room] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MemberMeeting]    Script Date: 10/04/2012 23:28:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MemberMeeting](
	[id] [int] NOT NULL,
	[MeetingId] [int] NOT NULL,
	[MemberId] [int] NOT NULL,
 CONSTRAINT [PK_MemberMeeting] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Allocation]    Script Date: 10/04/2012 23:28:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Allocation](
	[id] [int] NOT NULL,
	[MemberId] [int] NOT NULL,
	[RoomId] [int] NOT NULL,
	[DateFrom] [smalldatetime] NOT NULL,
	[DateTo] [smalldatetime] NULL,
 CONSTRAINT [PK_Allocation] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  ForeignKey [FK_SubgroupMembership_Member]    Script Date: 10/04/2012 23:28:40 ******/
ALTER TABLE [dbo].[SubgroupMembership]  WITH CHECK ADD  CONSTRAINT [FK_SubgroupMembership_Member] FOREIGN KEY([MemberId])
REFERENCES [dbo].[Member] ([id])
GO
ALTER TABLE [dbo].[SubgroupMembership] CHECK CONSTRAINT [FK_SubgroupMembership_Member]
GO
/****** Object:  ForeignKey [FK_SubgroupMembership_Subgroup]    Script Date: 10/04/2012 23:28:40 ******/
ALTER TABLE [dbo].[SubgroupMembership]  WITH CHECK ADD  CONSTRAINT [FK_SubgroupMembership_Subgroup] FOREIGN KEY([SubGroupId])
REFERENCES [dbo].[Subgroup] ([id])
GO
ALTER TABLE [dbo].[SubgroupMembership] CHECK CONSTRAINT [FK_SubgroupMembership_Subgroup]
GO
/****** Object:  ForeignKey [FK_MemberAddress_Address]    Script Date: 10/04/2012 23:28:40 ******/
ALTER TABLE [dbo].[MemberAddress]  WITH CHECK ADD  CONSTRAINT [FK_MemberAddress_Address] FOREIGN KEY([AddressId])
REFERENCES [dbo].[Address] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[MemberAddress] CHECK CONSTRAINT [FK_MemberAddress_Address]
GO
/****** Object:  ForeignKey [FK_MemberAddress_Member]    Script Date: 10/04/2012 23:28:40 ******/
ALTER TABLE [dbo].[MemberAddress]  WITH CHECK ADD  CONSTRAINT [FK_MemberAddress_Member] FOREIGN KEY([MemberId])
REFERENCES [dbo].[Member] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[MemberAddress] CHECK CONSTRAINT [FK_MemberAddress_Member]
GO
/****** Object:  ForeignKey [FK_Meeting_Subgroup]    Script Date: 10/04/2012 23:28:40 ******/
ALTER TABLE [dbo].[Meeting]  WITH CHECK ADD  CONSTRAINT [FK_Meeting_Subgroup] FOREIGN KEY([SubgroupId])
REFERENCES [dbo].[Subgroup] ([id])
GO
ALTER TABLE [dbo].[Meeting] CHECK CONSTRAINT [FK_Meeting_Subgroup]
GO
/****** Object:  ForeignKey [FK_RentPayment_Member]    Script Date: 10/04/2012 23:28:40 ******/
ALTER TABLE [dbo].[RentPayment]  WITH CHECK ADD  CONSTRAINT [FK_RentPayment_Member] FOREIGN KEY([MemberId])
REFERENCES [dbo].[Member] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[RentPayment] CHECK CONSTRAINT [FK_RentPayment_Member]
GO
/****** Object:  ForeignKey [FK_Property_Address]    Script Date: 10/04/2012 23:28:40 ******/
ALTER TABLE [dbo].[Property]  WITH CHECK ADD  CONSTRAINT [FK_Property_Address] FOREIGN KEY([AddressId])
REFERENCES [dbo].[Address] ([id])
GO
ALTER TABLE [dbo].[Property] CHECK CONSTRAINT [FK_Property_Address]
GO
/****** Object:  ForeignKey [FK_Room_Property]    Script Date: 10/04/2012 23:28:40 ******/
ALTER TABLE [dbo].[Room]  WITH CHECK ADD  CONSTRAINT [FK_Room_Property] FOREIGN KEY([PropertyId])
REFERENCES [dbo].[Property] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Room] CHECK CONSTRAINT [FK_Room_Property]
GO
/****** Object:  ForeignKey [FK_MemberMeeting_Meeting]    Script Date: 10/04/2012 23:28:40 ******/
ALTER TABLE [dbo].[MemberMeeting]  WITH CHECK ADD  CONSTRAINT [FK_MemberMeeting_Meeting] FOREIGN KEY([MeetingId])
REFERENCES [dbo].[Meeting] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[MemberMeeting] CHECK CONSTRAINT [FK_MemberMeeting_Meeting]
GO
/****** Object:  ForeignKey [FK_MemberMeeting_Member]    Script Date: 10/04/2012 23:28:40 ******/
ALTER TABLE [dbo].[MemberMeeting]  WITH CHECK ADD  CONSTRAINT [FK_MemberMeeting_Member] FOREIGN KEY([MemberId])
REFERENCES [dbo].[Member] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[MemberMeeting] CHECK CONSTRAINT [FK_MemberMeeting_Member]
GO
/****** Object:  ForeignKey [FK_Allocation_Member]    Script Date: 10/04/2012 23:28:40 ******/
ALTER TABLE [dbo].[Allocation]  WITH CHECK ADD  CONSTRAINT [FK_Allocation_Member] FOREIGN KEY([MemberId])
REFERENCES [dbo].[Member] ([id])
GO
ALTER TABLE [dbo].[Allocation] CHECK CONSTRAINT [FK_Allocation_Member]
GO
/****** Object:  ForeignKey [FK_Allocation_Room]    Script Date: 10/04/2012 23:28:40 ******/
ALTER TABLE [dbo].[Allocation]  WITH CHECK ADD  CONSTRAINT [FK_Allocation_Room] FOREIGN KEY([RoomId])
REFERENCES [dbo].[Room] ([id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Allocation] CHECK CONSTRAINT [FK_Allocation_Room]
GO
