--USE [master]
--GO
--/****** Object:  Database [0ED87D3259A58098B81C4D8388F2B54B_6\COMC2747 DB APPLICATIONS\2747DBENSONVS\dbenson2747SeniorCitizenProj1k\SENIORCITIZENPROJ2722.MDF]    Script Date: 10/9/2016 6:10:24 PM ******/
--CREATE DATABASE [0ED87D3259A58098B81C4D8388F2B54B_6\COMC2747 DB APPLICATIONS\2747DBENSONVS\dbenson2747SeniorCitizenProj1k\SENIORCITIZENPROJ2722.MDF]
-- CONTAINMENT = NONE
-- ON  PRIMARY 
--( NAME = N'SeniorCitizenProj2722', FILENAME = N'C:\Users\Darren\Documents\HomeWorkFall2016\COMC2747 DB Applications\2747dbensonVS\dbenson2747SeniorCitizenProj1k\SeniorCitizenProj2722.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
-- LOG ON 
--( NAME = N'SeniorCitizenProj2722_log', FILENAME = N'C:\Users\Darren\Documents\HomeWorkFall2016\COMC2747 DB Applications\2747dbensonVS\dbenson2747SeniorCitizenProj1k\SeniorCitizenProj2722_log.ldf' , SIZE = 768KB , MAXSIZE = UNLIMITED, FILEGROWTH = 10%)
--GO
--ALTER DATABASE [0ED87D3259A58098B81C4D8388F2B54B_6\COMC2747 DB APPLICATIONS\2747DBENSONVS\dbenson2747SeniorCitizenProj1k\SENIORCITIZENPROJ2722.MDF] SET COMPATIBILITY_LEVEL = 120
--GO
--IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
--begin
--EXEC [0ED87D3259A58098B81C4D8388F2B54B_6\COMC2747 DB APPLICATIONS\2747DBENSONVS\dbenson2747SeniorCitizenProj1k\SENIORCITIZENPROJ2722.MDF].[dbo].[sp_fulltext_database] @action = 'enable'
--end
--GO
--ALTER DATABASE [0ED87D3259A58098B81C4D8388F2B54B_6\COMC2747 DB APPLICATIONS\2747DBENSONVS\dbenson2747SeniorCitizenProj1k\SENIORCITIZENPROJ2722.MDF] SET ANSI_NULL_DEFAULT OFF 
--GO
--ALTER DATABASE [0ED87D3259A58098B81C4D8388F2B54B_6\COMC2747 DB APPLICATIONS\2747DBENSONVS\dbenson2747SeniorCitizenProj1k\SENIORCITIZENPROJ2722.MDF] SET ANSI_NULLS OFF 
--GO
--ALTER DATABASE [0ED87D3259A58098B81C4D8388F2B54B_6\COMC2747 DB APPLICATIONS\2747DBENSONVS\dbenson2747SeniorCitizenProj1k\SENIORCITIZENPROJ2722.MDF] SET ANSI_PADDING OFF 
--GO
--ALTER DATABASE [0ED87D3259A58098B81C4D8388F2B54B_6\COMC2747 DB APPLICATIONS\2747DBENSONVS\dbenson2747SeniorCitizenProj1k\SENIORCITIZENPROJ2722.MDF] SET ANSI_WARNINGS OFF 
--GO
--ALTER DATABASE [0ED87D3259A58098B81C4D8388F2B54B_6\COMC2747 DB APPLICATIONS\2747DBENSONVS\dbenson2747SeniorCitizenProj1k\SENIORCITIZENPROJ2722.MDF] SET ARITHABORT OFF 
--GO
--ALTER DATABASE [0ED87D3259A58098B81C4D8388F2B54B_6\COMC2747 DB APPLICATIONS\2747DBENSONVS\dbenson2747SeniorCitizenProj1k\SENIORCITIZENPROJ2722.MDF] SET AUTO_CLOSE ON 
--GO
--ALTER DATABASE [0ED87D3259A58098B81C4D8388F2B54B_6\COMC2747 DB APPLICATIONS\2747DBENSONVS\dbenson2747SeniorCitizenProj1k\SENIORCITIZENPROJ2722.MDF] SET AUTO_SHRINK OFF 
--GO
--ALTER DATABASE [0ED87D3259A58098B81C4D8388F2B54B_6\COMC2747 DB APPLICATIONS\2747DBENSONVS\dbenson2747SeniorCitizenProj1k\SENIORCITIZENPROJ2722.MDF] SET AUTO_UPDATE_STATISTICS ON 
--GO
--ALTER DATABASE [0ED87D3259A58098B81C4D8388F2B54B_6\COMC2747 DB APPLICATIONS\2747DBENSONVS\dbenson2747SeniorCitizenProj1k\SENIORCITIZENPROJ2722.MDF] SET CURSOR_CLOSE_ON_COMMIT OFF 
--GO
--ALTER DATABASE [0ED87D3259A58098B81C4D8388F2B54B_6\COMC2747 DB APPLICATIONS\2747DBENSONVS\dbenson2747SeniorCitizenProj1k\SENIORCITIZENPROJ2722.MDF] SET CURSOR_DEFAULT  GLOBAL 
--GO
--ALTER DATABASE [0ED87D3259A58098B81C4D8388F2B54B_6\COMC2747 DB APPLICATIONS\2747DBENSONVS\dbenson2747SeniorCitizenProj1k\SENIORCITIZENPROJ2722.MDF] SET CONCAT_NULL_YIELDS_NULL OFF 
--GO
--ALTER DATABASE [0ED87D3259A58098B81C4D8388F2B54B_6\COMC2747 DB APPLICATIONS\2747DBENSONVS\dbenson2747SeniorCitizenProj1k\SENIORCITIZENPROJ2722.MDF] SET NUMERIC_ROUNDABORT OFF 
--GO
--ALTER DATABASE [0ED87D3259A58098B81C4D8388F2B54B_6\COMC2747 DB APPLICATIONS\2747DBENSONVS\dbenson2747SeniorCitizenProj1k\SENIORCITIZENPROJ2722.MDF] SET QUOTED_IDENTIFIER OFF 
--GO
--ALTER DATABASE [0ED87D3259A58098B81C4D8388F2B54B_6\COMC2747 DB APPLICATIONS\2747DBENSONVS\dbenson2747SeniorCitizenProj1k\SENIORCITIZENPROJ2722.MDF] SET RECURSIVE_TRIGGERS OFF 
--GO
--ALTER DATABASE [0ED87D3259A58098B81C4D8388F2B54B_6\COMC2747 DB APPLICATIONS\2747DBENSONVS\dbenson2747SeniorCitizenProj1k\SENIORCITIZENPROJ2722.MDF] SET  DISABLE_BROKER 
--GO
--ALTER DATABASE [0ED87D3259A58098B81C4D8388F2B54B_6\COMC2747 DB APPLICATIONS\2747DBENSONVS\dbenson2747SeniorCitizenProj1k\SENIORCITIZENPROJ2722.MDF] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
--GO
--ALTER DATABASE [0ED87D3259A58098B81C4D8388F2B54B_6\COMC2747 DB APPLICATIONS\2747DBENSONVS\dbenson2747SeniorCitizenProj1k\SENIORCITIZENPROJ2722.MDF] SET DATE_CORRELATION_OPTIMIZATION OFF 
--GO
--ALTER DATABASE [0ED87D3259A58098B81C4D8388F2B54B_6\COMC2747 DB APPLICATIONS\2747DBENSONVS\dbenson2747SeniorCitizenProj1k\SENIORCITIZENPROJ2722.MDF] SET TRUSTWORTHY OFF 
--GO
--ALTER DATABASE [0ED87D3259A58098B81C4D8388F2B54B_6\COMC2747 DB APPLICATIONS\2747DBENSONVS\dbenson2747SeniorCitizenProj1k\SENIORCITIZENPROJ2722.MDF] SET ALLOW_SNAPSHOT_ISOLATION OFF 
--GO
--ALTER DATABASE [0ED87D3259A58098B81C4D8388F2B54B_6\COMC2747 DB APPLICATIONS\2747DBENSONVS\dbenson2747SeniorCitizenProj1k\SENIORCITIZENPROJ2722.MDF] SET PARAMETERIZATION SIMPLE 
--GO
--ALTER DATABASE [0ED87D3259A58098B81C4D8388F2B54B_6\COMC2747 DB APPLICATIONS\2747DBENSONVS\dbenson2747SeniorCitizenProj1k\SENIORCITIZENPROJ2722.MDF] SET READ_COMMITTED_SNAPSHOT OFF 
--GO
--ALTER DATABASE [0ED87D3259A58098B81C4D8388F2B54B_6\COMC2747 DB APPLICATIONS\2747DBENSONVS\dbenson2747SeniorCitizenProj1k\SENIORCITIZENPROJ2722.MDF] SET HONOR_BROKER_PRIORITY OFF 
--GO
--ALTER DATABASE [0ED87D3259A58098B81C4D8388F2B54B_6\COMC2747 DB APPLICATIONS\2747DBENSONVS\dbenson2747SeniorCitizenProj1k\SENIORCITIZENPROJ2722.MDF] SET RECOVERY SIMPLE 
--GO
--ALTER DATABASE [0ED87D3259A58098B81C4D8388F2B54B_6\COMC2747 DB APPLICATIONS\2747DBENSONVS\dbenson2747SeniorCitizenProj1k\SENIORCITIZENPROJ2722.MDF] SET  MULTI_USER 
--GO
--ALTER DATABASE [0ED87D3259A58098B81C4D8388F2B54B_6\COMC2747 DB APPLICATIONS\2747DBENSONVS\dbenson2747SeniorCitizenProj1k\SENIORCITIZENPROJ2722.MDF] SET PAGE_VERIFY CHECKSUM  
--GO
--ALTER DATABASE [0ED87D3259A58098B81C4D8388F2B54B_6\COMC2747 DB APPLICATIONS\2747DBENSONVS\dbenson2747SeniorCitizenProj1k\SENIORCITIZENPROJ2722.MDF] SET DB_CHAINING OFF 
--GO
--ALTER DATABASE [0ED87D3259A58098B81C4D8388F2B54B_6\COMC2747 DB APPLICATIONS\2747DBENSONVS\dbenson2747SeniorCitizenProj1k\SENIORCITIZENPROJ2722.MDF] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
--GO
--ALTER DATABASE [0ED87D3259A58098B81C4D8388F2B54B_6\COMC2747 DB APPLICATIONS\2747DBENSONVS\dbenson2747SeniorCitizenProj1k\SENIORCITIZENPROJ2722.MDF] SET TARGET_RECOVERY_TIME = 0 SECONDS 
--GO
--ALTER DATABASE [0ED87D3259A58098B81C4D8388F2B54B_6\COMC2747 DB APPLICATIONS\2747DBENSONVS\dbenson2747SeniorCitizenProj1k\SENIORCITIZENPROJ2722.MDF] SET DELAYED_DURABILITY = DISABLED 
--GO
--USE [0ED87D3259A58098B81C4D8388F2B54B_6\COMC2747 DB APPLICATIONS\2747DBENSONVS\dbenson2747SeniorCitizenProj1k\SENIORCITIZENPROJ2722.MDF]
--GO
/****** Object:  Table [dbo].[Client]    Script Date: 10/9/2016 6:10:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Client](
	[ClientID] [int] IDENTITY(500,1) NOT NULL,
	[ClientFirstName] [varchar](25) NOT NULL,
	[ClientLastName] [varchar](25) NOT NULL,
	[ClientAge] [int] NOT NULL,
	[ClientGender] [varchar](6) NOT NULL,
	[ClientDateOfBirth] [date] NOT NULL,
	[EmployeeID] [int] NOT NULL,
 CONSTRAINT [PK_Client_1] PRIMARY KEY CLUSTERED 
(
	[ClientID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ClientService]    Script Date: 10/9/2016 6:10:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ClientService](
	[ClientID] [int] NOT NULL,
	[ServiceID] [int] NOT NULL,
 CONSTRAINT [PK_ClientService] PRIMARY KEY CLUSTERED 
(
	[ClientID] ASC,
	[ServiceID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Discount]    Script Date: 10/9/2016 6:10:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Discount](
	[DiscountID] [int] IDENTITY(700,1) NOT NULL,
	[DiscDescription] [varchar](35) NOT NULL,
	[DiscountRate] [decimal](8, 2) NOT NULL,
 CONSTRAINT [PK_Discount] PRIMARY KEY CLUSTERED 
(
	[DiscountID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 10/9/2016 6:10:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Employee](
	[EmployeeID] [int] IDENTITY(100,1) NOT NULL,
	[EmpFirstName] [varchar](25) NOT NULL,
	[EmpLastName] [varchar](25) NOT NULL,
	[EmpAge] [int] NOT NULL,
	[EmpGender] [varchar](6) NOT NULL,
	[EmpDateOfBirth] [date] NOT NULL,
	[EmpPhone] [varchar](20) NOT NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[EmployeeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Residence]    Script Date: 10/9/2016 6:10:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Residence](
	[ResidenceID] [int] IDENTITY(1000,1) NOT NULL,
	[Address] [varchar](35) NOT NULL,
	[City] [varchar](25) NOT NULL,
	[State] [varchar](20) NOT NULL,
	[Zip] [int] NOT NULL,
	[ResidencePhone] [varchar](20) NOT NULL,
	[ClientID] [int] NOT NULL,
 CONSTRAINT [PK_Residence] PRIMARY KEY CLUSTERED 
(
	[ResidenceID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Schedule]    Script Date: 10/9/2016 6:10:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Schedule](
	[ScheduleID] [int] IDENTITY(1,1) NOT NULL,
	[ScheduleStart] [varchar](10) NULL,
	[ScheduleEnd] [varchar](10) NULL,
	[DiscountID] [int] NULL,
	[ScheduleType] [varchar](25) NOT NULL,
	[NumHours] [int] NULL,
 CONSTRAINT [PK_Schedule] PRIMARY KEY CLUSTERED 
(
	[ScheduleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Service]    Script Date: 10/9/2016 6:10:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Service](
	[ServiceID] [int] IDENTITY(1,1) NOT NULL,
	[ServiceDescription] [varchar](40) NOT NULL,
	[ServiceRateHourly] [decimal](8, 2) NULL,
	[ServiceRateDaily] [decimal](8, 2) NULL,
	[ServiceRateWeekly] [decimal](8, 2) NULL,
 CONSTRAINT [PK_Service] PRIMARY KEY CLUSTERED 
(
	[ServiceID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ServiceSchedule]    Script Date: 10/9/2016 6:10:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ServiceSchedule](
	[ServiceID] [int] NOT NULL,
	[ScheduleID] [int] NOT NULL,
 CONSTRAINT [PK_ServiceSchedule] PRIMARY KEY CLUSTERED 
(
	[ServiceID] ASC,
	[ScheduleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Client] ON 

GO
INSERT [dbo].[Client] ([ClientID], [ClientFirstName], [ClientLastName], [ClientAge], [ClientGender], [ClientDateOfBirth], [EmployeeID]) VALUES (500, N'George', N'Jones', 68, N'Male', CAST(N'1948-05-04' AS Date), 100)
GO
INSERT [dbo].[Client] ([ClientID], [ClientFirstName], [ClientLastName], [ClientAge], [ClientGender], [ClientDateOfBirth], [EmployeeID]) VALUES (501, N'Miranda', N'Lopez', 70, N'Female', CAST(N'1946-11-12' AS Date), 101)
GO
INSERT [dbo].[Client] ([ClientID], [ClientFirstName], [ClientLastName], [ClientAge], [ClientGender], [ClientDateOfBirth], [EmployeeID]) VALUES (502, N'Michelle', N'Laura', 72, N'Female', CAST(N'1944-09-08' AS Date), 106)
GO
INSERT [dbo].[Client] ([ClientID], [ClientFirstName], [ClientLastName], [ClientAge], [ClientGender], [ClientDateOfBirth], [EmployeeID]) VALUES (503, N'Jonna', N'Brigand', 65, N'Male', CAST(N'1951-03-30' AS Date), 103)
GO
INSERT [dbo].[Client] ([ClientID], [ClientFirstName], [ClientLastName], [ClientAge], [ClientGender], [ClientDateOfBirth], [EmployeeID]) VALUES (504, N'Michael', N'Ortega', 69, N'Male', CAST(N'1947-01-14' AS Date), 104)
GO
INSERT [dbo].[Client] ([ClientID], [ClientFirstName], [ClientLastName], [ClientAge], [ClientGender], [ClientDateOfBirth], [EmployeeID]) VALUES (505, N'Sally', N'Johansen', 74, N'Female', CAST(N'1942-05-10' AS Date), 102)
GO
INSERT [dbo].[Client] ([ClientID], [ClientFirstName], [ClientLastName], [ClientAge], [ClientGender], [ClientDateOfBirth], [EmployeeID]) VALUES (506, N'Rebecca', N'Smith', 70, N'Female', CAST(N'1946-07-04' AS Date), 105)
GO
INSERT [dbo].[Client] ([ClientID], [ClientFirstName], [ClientLastName], [ClientAge], [ClientGender], [ClientDateOfBirth], [EmployeeID]) VALUES (507, N'Jacob', N'Rogers', 81, N'Male', CAST(N'1935-06-21' AS Date), 101)
GO
INSERT [dbo].[Client] ([ClientID], [ClientFirstName], [ClientLastName], [ClientAge], [ClientGender], [ClientDateOfBirth], [EmployeeID]) VALUES (508, N'Stanley', N'Cooper', 75, N'Male', CAST(N'1941-02-23' AS Date), 100)
GO
INSERT [dbo].[Client] ([ClientID], [ClientFirstName], [ClientLastName], [ClientAge], [ClientGender], [ClientDateOfBirth], [EmployeeID]) VALUES (509, N'Jon', N'Braylen', 78, N'Male', CAST(N'1938-10-12' AS Date), 103)
GO
SET IDENTITY_INSERT [dbo].[Client] OFF
GO
INSERT [dbo].[ClientService] ([ClientID], [ServiceID]) VALUES (500, 1)
GO
INSERT [dbo].[ClientService] ([ClientID], [ServiceID]) VALUES (500, 3)
GO
INSERT [dbo].[ClientService] ([ClientID], [ServiceID]) VALUES (501, 3)
GO
INSERT [dbo].[ClientService] ([ClientID], [ServiceID]) VALUES (501, 4)
GO
INSERT [dbo].[ClientService] ([ClientID], [ServiceID]) VALUES (502, 5)
GO
INSERT [dbo].[ClientService] ([ClientID], [ServiceID]) VALUES (503, 3)
GO
INSERT [dbo].[ClientService] ([ClientID], [ServiceID]) VALUES (504, 4)
GO
INSERT [dbo].[ClientService] ([ClientID], [ServiceID]) VALUES (505, 1)
GO
INSERT [dbo].[ClientService] ([ClientID], [ServiceID]) VALUES (505, 5)
GO
INSERT [dbo].[ClientService] ([ClientID], [ServiceID]) VALUES (506, 4)
GO
INSERT [dbo].[ClientService] ([ClientID], [ServiceID]) VALUES (507, 1)
GO
INSERT [dbo].[ClientService] ([ClientID], [ServiceID]) VALUES (507, 4)
GO
INSERT [dbo].[ClientService] ([ClientID], [ServiceID]) VALUES (507, 6)
GO
INSERT [dbo].[ClientService] ([ClientID], [ServiceID]) VALUES (508, 4)
GO
INSERT [dbo].[ClientService] ([ClientID], [ServiceID]) VALUES (508, 6)
GO
INSERT [dbo].[ClientService] ([ClientID], [ServiceID]) VALUES (509, 4)
GO
INSERT [dbo].[ClientService] ([ClientID], [ServiceID]) VALUES (509, 5)
GO
SET IDENTITY_INSERT [dbo].[Discount] ON 

GO
INSERT [dbo].[Discount] ([DiscountID], [DiscDescription], [DiscountRate]) VALUES (700, N'Daily vs Hourly', CAST(10.00 AS Decimal(8, 2)))
GO
INSERT [dbo].[Discount] ([DiscountID], [DiscDescription], [DiscountRate]) VALUES (701, N'Weekly', CAST(15.00 AS Decimal(8, 2)))
GO
SET IDENTITY_INSERT [dbo].[Discount] OFF
GO
SET IDENTITY_INSERT [dbo].[Employee] ON 

GO
INSERT [dbo].[Employee] ([EmployeeID], [EmpFirstName], [EmpLastName], [EmpAge], [EmpGender], [EmpDateOfBirth], [EmpPhone]) VALUES (100, N'Darren', N'Benson', 32, N'Male', CAST(N'1984-02-25' AS Date), N'608-555-1234')
GO
INSERT [dbo].[Employee] ([EmployeeID], [EmpFirstName], [EmpLastName], [EmpAge], [EmpGender], [EmpDateOfBirth], [EmpPhone]) VALUES (101, N'John', N'Doe', 35, N'Male', CAST(N'1981-07-14' AS Date), N'608-555-1235')
GO
INSERT [dbo].[Employee] ([EmployeeID], [EmpFirstName], [EmpLastName], [EmpAge], [EmpGender], [EmpDateOfBirth], [EmpPhone]) VALUES (102, N'Mary', N'Sullivan', 30, N'Female', CAST(N'1986-05-13' AS Date), N'507-555-1236')
GO
INSERT [dbo].[Employee] ([EmployeeID], [EmpFirstName], [EmpLastName], [EmpAge], [EmpGender], [EmpDateOfBirth], [EmpPhone]) VALUES (103, N'Colby', N'Ohare', 40, N'Male', CAST(N'1976-11-23' AS Date), N'507-555-1237')
GO
INSERT [dbo].[Employee] ([EmployeeID], [EmpFirstName], [EmpLastName], [EmpAge], [EmpGender], [EmpDateOfBirth], [EmpPhone]) VALUES (104, N'Teresa', N'Michaels', 31, N'Female', CAST(N'1985-03-01' AS Date), N'614-555-1238')
GO
INSERT [dbo].[Employee] ([EmployeeID], [EmpFirstName], [EmpLastName], [EmpAge], [EmpGender], [EmpDateOfBirth], [EmpPhone]) VALUES (105, N'Megan', N'Bowers', 45, N'Female', CAST(N'1971-06-25' AS Date), N'613-555-1239')
GO
INSERT [dbo].[Employee] ([EmployeeID], [EmpFirstName], [EmpLastName], [EmpAge], [EmpGender], [EmpDateOfBirth], [EmpPhone]) VALUES (106, N'Mark', N'Hogan', 37, N'Male', CAST(N'1979-04-22' AS Date), N'608-555-1240')
GO
SET IDENTITY_INSERT [dbo].[Employee] OFF
GO
SET IDENTITY_INSERT [dbo].[Residence] ON 

GO
INSERT [dbo].[Residence] ([ResidenceID], [Address], [City], [State], [Zip], [ResidencePhone], [ClientID]) VALUES (1000, N'150 West Andover', N'Winona', N'MN', 55987, N'507-555-2468', 500)
GO
INSERT [dbo].[Residence] ([ResidenceID], [Address], [City], [State], [Zip], [ResidencePhone], [ClientID]) VALUES (1001, N'76 East Broadway', N'Red Wing', N'MN', 55066, N'651-555-0123', 501)
GO
INSERT [dbo].[Residence] ([ResidenceID], [Address], [City], [State], [Zip], [ResidencePhone], [ClientID]) VALUES (1002, N'1231 Maple Drive', N'La Crosse', N'WI', 54601, N'608-555-1257', 502)
GO
INSERT [dbo].[Residence] ([ResidenceID], [Address], [City], [State], [Zip], [ResidencePhone], [ClientID]) VALUES (1003, N'102 Chester Drive', N'Winona', N'MN', 55987, N'507-555-4610', 503)
GO
INSERT [dbo].[Residence] ([ResidenceID], [Address], [City], [State], [Zip], [ResidencePhone], [ClientID]) VALUES (1004, N'92 East River Road', N'Winona', N'MN', 55987, N'507-555-7778', 504)
GO
INSERT [dbo].[Residence] ([ResidenceID], [Address], [City], [State], [Zip], [ResidencePhone], [ClientID]) VALUES (1005, N'54 Michaels Way', N'Rushford', N'MN', 55971, N'507-555-7654', 505)
GO
INSERT [dbo].[Residence] ([ResidenceID], [Address], [City], [State], [Zip], [ResidencePhone], [ClientID]) VALUES (1006, N'88 North Washington', N'Red Wing', N'MN', 55066, N'651-555-1480', 506)
GO
INSERT [dbo].[Residence] ([ResidenceID], [Address], [City], [State], [Zip], [ResidencePhone], [ClientID]) VALUES (1007, N'75 West Broadway', N'Alma', N'WI', 54610, N'608-555-7290', 507)
GO
INSERT [dbo].[Residence] ([ResidenceID], [Address], [City], [State], [Zip], [ResidencePhone], [ClientID]) VALUES (1008, N'125 South Maple', N'Winona', N'MN', 55987, N'507-555-7335', 508)
GO
INSERT [dbo].[Residence] ([ResidenceID], [Address], [City], [State], [Zip], [ResidencePhone], [ClientID]) VALUES (1009, N'91 West Bend ', N'Winona', N'MN', 55987, N'507-555-6881', 509)
GO
SET IDENTITY_INSERT [dbo].[Residence] OFF
GO
SET IDENTITY_INSERT [dbo].[Schedule] ON 

GO
INSERT [dbo].[Schedule] ([ScheduleID], [ScheduleStart], [ScheduleEnd], [DiscountID], [ScheduleType], [NumHours]) VALUES (1, N'Monday', N'Friday', 701, N'Weekly', 40)
GO
INSERT [dbo].[Schedule] ([ScheduleID], [ScheduleStart], [ScheduleEnd], [DiscountID], [ScheduleType], [NumHours]) VALUES (2, NULL, NULL, 700, N'Daily', 8)
GO
INSERT [dbo].[Schedule] ([ScheduleID], [ScheduleStart], [ScheduleEnd], [DiscountID], [ScheduleType], [NumHours]) VALUES (3, NULL, NULL, NULL, N'Hourly', 4)
GO
INSERT [dbo].[Schedule] ([ScheduleID], [ScheduleStart], [ScheduleEnd], [DiscountID], [ScheduleType], [NumHours]) VALUES (4, NULL, NULL, NULL, N'Hourly', 2)
GO
INSERT [dbo].[Schedule] ([ScheduleID], [ScheduleStart], [ScheduleEnd], [DiscountID], [ScheduleType], [NumHours]) VALUES (5, NULL, NULL, NULL, N'Hourly', 6)
GO
SET IDENTITY_INSERT [dbo].[Schedule] OFF
GO
SET IDENTITY_INSERT [dbo].[Service] ON 

GO
INSERT [dbo].[Service] ([ServiceID], [ServiceDescription], [ServiceRateHourly], [ServiceRateDaily], [ServiceRateWeekly]) VALUES (1, N'Grocery errand', CAST(7.50 AS Decimal(8, 2)), CAST(35.00 AS Decimal(8, 2)), CAST(110.00 AS Decimal(8, 2)))
GO
INSERT [dbo].[Service] ([ServiceID], [ServiceDescription], [ServiceRateHourly], [ServiceRateDaily], [ServiceRateWeekly]) VALUES (3, N'Lawn care', CAST(10.00 AS Decimal(8, 2)), CAST(50.00 AS Decimal(8, 2)), CAST(200.00 AS Decimal(8, 2)))
GO
INSERT [dbo].[Service] ([ServiceID], [ServiceDescription], [ServiceRateHourly], [ServiceRateDaily], [ServiceRateWeekly]) VALUES (4, N'Chauffeur', CAST(8.50 AS Decimal(8, 2)), CAST(40.00 AS Decimal(8, 2)), CAST(150.00 AS Decimal(8, 2)))
GO
INSERT [dbo].[Service] ([ServiceID], [ServiceDescription], [ServiceRateHourly], [ServiceRateDaily], [ServiceRateWeekly]) VALUES (5, N'House keeping', CAST(11.50 AS Decimal(8, 2)), CAST(75.00 AS Decimal(8, 2)), CAST(375.00 AS Decimal(8, 2)))
GO
INSERT [dbo].[Service] ([ServiceID], [ServiceDescription], [ServiceRateHourly], [ServiceRateDaily], [ServiceRateWeekly]) VALUES (6, N'In home aide', CAST(17.50 AS Decimal(8, 2)), CAST(120.00 AS Decimal(8, 2)), CAST(600.00 AS Decimal(8, 2)))
GO
SET IDENTITY_INSERT [dbo].[Service] OFF
GO
INSERT [dbo].[ServiceSchedule] ([ServiceID], [ScheduleID]) VALUES (1, 1)
GO
INSERT [dbo].[ServiceSchedule] ([ServiceID], [ScheduleID]) VALUES (1, 2)
GO
INSERT [dbo].[ServiceSchedule] ([ServiceID], [ScheduleID]) VALUES (1, 3)
GO
INSERT [dbo].[ServiceSchedule] ([ServiceID], [ScheduleID]) VALUES (1, 4)
GO
INSERT [dbo].[ServiceSchedule] ([ServiceID], [ScheduleID]) VALUES (1, 5)
GO
INSERT [dbo].[ServiceSchedule] ([ServiceID], [ScheduleID]) VALUES (3, 1)
GO
INSERT [dbo].[ServiceSchedule] ([ServiceID], [ScheduleID]) VALUES (3, 2)
GO
INSERT [dbo].[ServiceSchedule] ([ServiceID], [ScheduleID]) VALUES (3, 3)
GO
INSERT [dbo].[ServiceSchedule] ([ServiceID], [ScheduleID]) VALUES (3, 4)
GO
INSERT [dbo].[ServiceSchedule] ([ServiceID], [ScheduleID]) VALUES (3, 5)
GO
INSERT [dbo].[ServiceSchedule] ([ServiceID], [ScheduleID]) VALUES (4, 1)
GO
INSERT [dbo].[ServiceSchedule] ([ServiceID], [ScheduleID]) VALUES (4, 2)
GO
INSERT [dbo].[ServiceSchedule] ([ServiceID], [ScheduleID]) VALUES (4, 3)
GO
INSERT [dbo].[ServiceSchedule] ([ServiceID], [ScheduleID]) VALUES (4, 4)
GO
INSERT [dbo].[ServiceSchedule] ([ServiceID], [ScheduleID]) VALUES (4, 5)
GO
INSERT [dbo].[ServiceSchedule] ([ServiceID], [ScheduleID]) VALUES (5, 1)
GO
INSERT [dbo].[ServiceSchedule] ([ServiceID], [ScheduleID]) VALUES (5, 2)
GO
INSERT [dbo].[ServiceSchedule] ([ServiceID], [ScheduleID]) VALUES (5, 3)
GO
INSERT [dbo].[ServiceSchedule] ([ServiceID], [ScheduleID]) VALUES (5, 4)
GO
INSERT [dbo].[ServiceSchedule] ([ServiceID], [ScheduleID]) VALUES (5, 5)
GO
INSERT [dbo].[ServiceSchedule] ([ServiceID], [ScheduleID]) VALUES (6, 1)
GO
INSERT [dbo].[ServiceSchedule] ([ServiceID], [ScheduleID]) VALUES (6, 2)
GO
INSERT [dbo].[ServiceSchedule] ([ServiceID], [ScheduleID]) VALUES (6, 3)
GO
INSERT [dbo].[ServiceSchedule] ([ServiceID], [ScheduleID]) VALUES (6, 4)
GO
INSERT [dbo].[ServiceSchedule] ([ServiceID], [ScheduleID]) VALUES (6, 5)
GO
ALTER TABLE [dbo].[Client]  WITH CHECK ADD  CONSTRAINT [FK_Client_Employee] FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[Employee] ([EmployeeID])
GO
ALTER TABLE [dbo].[Client] CHECK CONSTRAINT [FK_Client_Employee]
GO
ALTER TABLE [dbo].[ClientService]  WITH CHECK ADD  CONSTRAINT [FK_ClientService_Client] FOREIGN KEY([ClientID])
REFERENCES [dbo].[Client] ([ClientID])
GO
ALTER TABLE [dbo].[ClientService] CHECK CONSTRAINT [FK_ClientService_Client]
GO
ALTER TABLE [dbo].[ClientService]  WITH CHECK ADD  CONSTRAINT [FK_ClientService_Service] FOREIGN KEY([ServiceID])
REFERENCES [dbo].[Service] ([ServiceID])
GO
ALTER TABLE [dbo].[ClientService] CHECK CONSTRAINT [FK_ClientService_Service]
GO
ALTER TABLE [dbo].[Residence]  WITH CHECK ADD  CONSTRAINT [FK_Residence_Client] FOREIGN KEY([ClientID])
REFERENCES [dbo].[Client] ([ClientID])
GO
ALTER TABLE [dbo].[Residence] CHECK CONSTRAINT [FK_Residence_Client]
GO
ALTER TABLE [dbo].[Schedule]  WITH CHECK ADD  CONSTRAINT [FK_Schedule_Discount] FOREIGN KEY([DiscountID])
REFERENCES [dbo].[Discount] ([DiscountID])
GO
ALTER TABLE [dbo].[Schedule] CHECK CONSTRAINT [FK_Schedule_Discount]
GO
ALTER TABLE [dbo].[ServiceSchedule]  WITH CHECK ADD  CONSTRAINT [FK_ServiceSchedule_Schedule] FOREIGN KEY([ScheduleID])
REFERENCES [dbo].[Schedule] ([ScheduleID])
GO
ALTER TABLE [dbo].[ServiceSchedule] CHECK CONSTRAINT [FK_ServiceSchedule_Schedule]
GO
ALTER TABLE [dbo].[ServiceSchedule]  WITH CHECK ADD  CONSTRAINT [FK_ServiceSchedule_Service] FOREIGN KEY([ServiceID])
REFERENCES [dbo].[Service] ([ServiceID])
GO
ALTER TABLE [dbo].[ServiceSchedule] CHECK CONSTRAINT [FK_ServiceSchedule_Service]
GO
--USE [master]
--GO
--ALTER DATABASE [0ED87D3259A58098B81C4D8388F2B54B_6\COMC2747 DB APPLICATIONS\2747DBENSONVS\dbenson2747SeniorCitizenProj1k\SENIORCITIZENPROJ2722.MDF] SET  READ_WRITE 
--GO
