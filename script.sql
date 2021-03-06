USE [master]
GO
/****** Object:  Database [FutbolSahesi]    Script Date: 19.11.2018 21:31:34 ******/
CREATE DATABASE [FutbolSahesi]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'FutbolSahesi', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\FutbolSahesi.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'FutbolSahesi_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\FutbolSahesi_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [FutbolSahesi] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [FutbolSahesi].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [FutbolSahesi] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [FutbolSahesi] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [FutbolSahesi] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [FutbolSahesi] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [FutbolSahesi] SET ARITHABORT OFF 
GO
ALTER DATABASE [FutbolSahesi] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [FutbolSahesi] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [FutbolSahesi] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [FutbolSahesi] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [FutbolSahesi] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [FutbolSahesi] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [FutbolSahesi] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [FutbolSahesi] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [FutbolSahesi] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [FutbolSahesi] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [FutbolSahesi] SET  DISABLE_BROKER 
GO
ALTER DATABASE [FutbolSahesi] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [FutbolSahesi] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [FutbolSahesi] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [FutbolSahesi] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [FutbolSahesi] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [FutbolSahesi] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [FutbolSahesi] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [FutbolSahesi] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [FutbolSahesi] SET  MULTI_USER 
GO
ALTER DATABASE [FutbolSahesi] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [FutbolSahesi] SET DB_CHAINING OFF 
GO
ALTER DATABASE [FutbolSahesi] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [FutbolSahesi] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [FutbolSahesi]
GO
/****** Object:  Table [dbo].[Booking]    Script Date: 19.11.2018 21:31:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Booking](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Date] [date] NOT NULL,
	[Time] [time](7) NOT NULL,
	[MeydancaId] [int] NOT NULL,
	[OtaqId] [int] NOT NULL,
	[MushteriId] [int] NOT NULL,
	[CreatedAt] [datetime] NOT NULL,
	[Price] [money] NOT NULL,
 CONSTRAINT [PK_Booking] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Meydancalar]    Script Date: 19.11.2018 21:31:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Meydancalar](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Price] [money] NOT NULL,
 CONSTRAINT [PK_Meydancalar] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Mushteri]    Script Date: 19.11.2018 21:31:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mushteri](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Surname] [nvarchar](50) NULL,
	[Phone] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
 CONSTRAINT [PK_Mushteri] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Otaqlar]    Script Date: 19.11.2018 21:31:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Otaqlar](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Number] [int] NOT NULL,
	[Control] [nvarchar](50) NOT NULL,
	[Amount] [int] NOT NULL,
 CONSTRAINT [PK_Otaqlar] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Booking] ON 

INSERT [dbo].[Booking] ([Id], [Date], [Time], [MeydancaId], [OtaqId], [MushteriId], [CreatedAt], [Price]) VALUES (13, CAST(0xF23E0B00 AS Date), CAST(0x07007870335C0000 AS Time), 2, 5, 2, CAST(0x0000A99600F73140 AS DateTime), 15.0000)
INSERT [dbo].[Booking] ([Id], [Date], [Time], [MeydancaId], [OtaqId], [MushteriId], [CreatedAt], [Price]) VALUES (14, CAST(0xF53E0B00 AS Date), CAST(0x0700F0E066B80000 AS Time), 2, 5, 14, CAST(0x0000A99901466A6A AS DateTime), 15.0000)
INSERT [dbo].[Booking] ([Id], [Date], [Time], [MeydancaId], [OtaqId], [MushteriId], [CreatedAt], [Price]) VALUES (15, CAST(0xF43E0B00 AS Date), CAST(0x0700881C05B00000 AS Time), 4, 3, 11, CAST(0x0000A9990107AC00 AS DateTime), 7.0000)
INSERT [dbo].[Booking] ([Id], [Date], [Time], [MeydancaId], [OtaqId], [MushteriId], [CreatedAt], [Price]) VALUES (19, CAST(0xF33E0B00 AS Date), CAST(0x070050CFDF960000 AS Time), 8, 5, 15, CAST(0x0000A99801499700 AS DateTime), 20.0000)
INSERT [dbo].[Booking] ([Id], [Date], [Time], [MeydancaId], [OtaqId], [MushteriId], [CreatedAt], [Price]) VALUES (20, CAST(0xF43E0B00 AS Date), CAST(0x0700B893419F0000 AS Time), 5, 4, 7, CAST(0x0000A99900B54640 AS DateTime), 11.0000)
INSERT [dbo].[Booking] ([Id], [Date], [Time], [MeydancaId], [OtaqId], [MushteriId], [CreatedAt], [Price]) VALUES (21, CAST(0xF53E0B00 AS Date), CAST(0x07002058A3A70000 AS Time), 7, 5, 3, CAST(0x0000A99901140810 AS DateTime), 18.0000)
INSERT [dbo].[Booking] ([Id], [Date], [Time], [MeydancaId], [OtaqId], [MushteriId], [CreatedAt], [Price]) VALUES (22, CAST(0xF63E0B00 AS Date), CAST(0x0700E80A7E8E0000 AS Time), 10, 3, 9, CAST(0x0000A998012741F0 AS DateTime), 6.0000)
INSERT [dbo].[Booking] ([Id], [Date], [Time], [MeydancaId], [OtaqId], [MushteriId], [CreatedAt], [Price]) VALUES (23, CAST(0xF73E0B00 AS Date), CAST(0x07002058A3A70000 AS Time), 3, 4, 12, CAST(0x0000A99B00E4C517 AS DateTime), 10.0000)
INSERT [dbo].[Booking] ([Id], [Date], [Time], [MeydancaId], [OtaqId], [MushteriId], [CreatedAt], [Price]) VALUES (24, CAST(0xF83E0B00 AS Date), CAST(0x0700F0E066B80000 AS Time), 6, 3, 10, CAST(0x0000A99B0116D480 AS DateTime), 12.0000)
INSERT [dbo].[Booking] ([Id], [Date], [Time], [MeydancaId], [OtaqId], [MushteriId], [CreatedAt], [Price]) VALUES (25, CAST(0xF63E0B00 AS Date), CAST(0x070058A5C8C00000 AS Time), 13, 3, 5, CAST(0x0000A99B0117A5EC AS DateTime), 10.0000)
INSERT [dbo].[Booking] ([Id], [Date], [Time], [MeydancaId], [OtaqId], [MushteriId], [CreatedAt], [Price]) VALUES (26, CAST(0xF83E0B00 AS Date), CAST(0x0700B0BD58750000 AS Time), 14, 5, 13, CAST(0x0000A99B01189CC4 AS DateTime), 7.0000)
INSERT [dbo].[Booking] ([Id], [Date], [Time], [MeydancaId], [OtaqId], [MushteriId], [CreatedAt], [Price]) VALUES (27, CAST(0xF63E0B00 AS Date), CAST(0x07001882BA7D0000 AS Time), 4, 5, 11, CAST(0x0000A99B011CDD69 AS DateTime), 7.0000)
INSERT [dbo].[Booking] ([Id], [Date], [Time], [MeydancaId], [OtaqId], [MushteriId], [CreatedAt], [Price]) VALUES (28, CAST(0xF93E0B00 AS Date), CAST(0x0700E80A7E8E0000 AS Time), 8, 4, 17, CAST(0x0000A99B01219700 AS DateTime), 20.0000)
INSERT [dbo].[Booking] ([Id], [Date], [Time], [MeydancaId], [OtaqId], [MushteriId], [CreatedAt], [Price]) VALUES (29, CAST(0xF83E0B00 AS Date), CAST(0x0700E03495640000 AS Time), 2, 7, 1, CAST(0x0000A99C00CC9F13 AS DateTime), 15.0000)
INSERT [dbo].[Booking] ([Id], [Date], [Time], [MeydancaId], [OtaqId], [MushteriId], [CreatedAt], [Price]) VALUES (30, CAST(0xF83E0B00 AS Date), CAST(0x0700A8E76F4B0000 AS Time), 3, 8, 5, CAST(0x0000A99C00E16B42 AS DateTime), 8.0000)
INSERT [dbo].[Booking] ([Id], [Date], [Time], [MeydancaId], [OtaqId], [MushteriId], [CreatedAt], [Price]) VALUES (31, CAST(0xF93E0B00 AS Date), CAST(0x07001882BA7D0000 AS Time), 5, 8, 18, CAST(0x0000A99C00E83FB1 AS DateTime), 11.0000)
INSERT [dbo].[Booking] ([Id], [Date], [Time], [MeydancaId], [OtaqId], [MushteriId], [CreatedAt], [Price]) VALUES (32, CAST(0xF73E0B00 AS Date), CAST(0x0700E03495640000 AS Time), 5, 7, 9, CAST(0x0000A99C0109A202 AS DateTime), 11.0000)
INSERT [dbo].[Booking] ([Id], [Date], [Time], [MeydancaId], [OtaqId], [MushteriId], [CreatedAt], [Price]) VALUES (33, CAST(0xF73E0B00 AS Date), CAST(0x0700B893419F0000 AS Time), 14, 4, 1, CAST(0x0000A99C010A04EB AS DateTime), 7.0000)
INSERT [dbo].[Booking] ([Id], [Date], [Time], [MeydancaId], [OtaqId], [MushteriId], [CreatedAt], [Price]) VALUES (34, CAST(0xF73E0B00 AS Date), CAST(0x0700E03495640000 AS Time), 4, 5, 13, CAST(0x0000A99C010A4459 AS DateTime), 7.0000)
INSERT [dbo].[Booking] ([Id], [Date], [Time], [MeydancaId], [OtaqId], [MushteriId], [CreatedAt], [Price]) VALUES (35, CAST(0xFA3E0B00 AS Date), CAST(0x070058A5C8C00000 AS Time), 14, 6, 19, CAST(0x0000A99C0117076C AS DateTime), 7.0000)
INSERT [dbo].[Booking] ([Id], [Date], [Time], [MeydancaId], [OtaqId], [MushteriId], [CreatedAt], [Price]) VALUES (36, CAST(0xFA3E0B00 AS Date), CAST(0x070010ACD1530000 AS Time), 11, 4, 20, CAST(0x0000A99C012C1189 AS DateTime), 8.0000)
INSERT [dbo].[Booking] ([Id], [Date], [Time], [MeydancaId], [OtaqId], [MushteriId], [CreatedAt], [Price]) VALUES (40, CAST(0xF83E0B00 AS Date), CAST(0x070050CFDF960000 AS Time), 6, 5, 13, CAST(0x0000A99D00A1C018 AS DateTime), 12.0000)
INSERT [dbo].[Booking] ([Id], [Date], [Time], [MeydancaId], [OtaqId], [MushteriId], [CreatedAt], [Price]) VALUES (45, CAST(0xF93E0B00 AS Date), CAST(0x0700881C05B00000 AS Time), 5, 3, 4, CAST(0x0000A99D013A7BD0 AS DateTime), 11.0000)
INSERT [dbo].[Booking] ([Id], [Date], [Time], [MeydancaId], [OtaqId], [MushteriId], [CreatedAt], [Price]) VALUES (47, CAST(0xF83E0B00 AS Date), CAST(0x07001882BA7D0000 AS Time), 8, 4, 2, CAST(0x0000A99D01399455 AS DateTime), 20.0000)
SET IDENTITY_INSERT [dbo].[Booking] OFF
SET IDENTITY_INSERT [dbo].[Meydancalar] ON 

INSERT [dbo].[Meydancalar] ([Id], [Name], [Price]) VALUES (1, N'Baki Olimpiya', 10.0000)
INSERT [dbo].[Meydancalar] ([Id], [Name], [Price]) VALUES (2, N'Tofiq Behremav', 15.0000)
INSERT [dbo].[Meydancalar] ([Id], [Name], [Price]) VALUES (3, N'Xezer Lenkeran Merkezi', 8.0000)
INSERT [dbo].[Meydancalar] ([Id], [Name], [Price]) VALUES (4, N'Mehdi Huseynzade', 7.0000)
INSERT [dbo].[Meydancalar] ([Id], [Name], [Price]) VALUES (5, N'Bakcell Arena', 11.0000)
INSERT [dbo].[Meydancalar] ([Id], [Name], [Price]) VALUES (6, N'Inter Arena', 12.0000)
INSERT [dbo].[Meydancalar] ([Id], [Name], [Price]) VALUES (7, N'Zire Olimpiya', 18.0000)
INSERT [dbo].[Meydancalar] ([Id], [Name], [Price]) VALUES (8, N'Genclik ', 20.0000)
INSERT [dbo].[Meydancalar] ([Id], [Name], [Price]) VALUES (9, N'Zabrat', 9.0000)
INSERT [dbo].[Meydancalar] ([Id], [Name], [Price]) VALUES (10, N'Quzanli Olimpiya', 6.0000)
INSERT [dbo].[Meydancalar] ([Id], [Name], [Price]) VALUES (11, N'Salyan Olimpiya', 8.0000)
INSERT [dbo].[Meydancalar] ([Id], [Name], [Price]) VALUES (12, N'Shemkir', 9.0000)
INSERT [dbo].[Meydancalar] ([Id], [Name], [Price]) VALUES (13, N'Qazax', 10.0000)
INSERT [dbo].[Meydancalar] ([Id], [Name], [Price]) VALUES (14, N'Qebele', 7.0000)
INSERT [dbo].[Meydancalar] ([Id], [Name], [Price]) VALUES (15, N'Zaqatala', 8.0000)
INSERT [dbo].[Meydancalar] ([Id], [Name], [Price]) VALUES (16, N'MOIK', 12.0000)
SET IDENTITY_INSERT [dbo].[Meydancalar] OFF
SET IDENTITY_INSERT [dbo].[Mushteri] ON 

INSERT [dbo].[Mushteri] ([Id], [Name], [Surname], [Phone], [Email]) VALUES (1, N'Sevil', N'Mansirova', N'050-348-89-90', NULL)
INSERT [dbo].[Mushteri] ([Id], [Name], [Surname], [Phone], [Email]) VALUES (2, N'Ruslan ', N'Berzigyar', N'055-420-20-00', NULL)
INSERT [dbo].[Mushteri] ([Id], [Name], [Surname], [Phone], [Email]) VALUES (3, N'Ulvi', N'Ibrahomov', N'055-325-18-95', NULL)
INSERT [dbo].[Mushteri] ([Id], [Name], [Surname], [Phone], [Email]) VALUES (4, N'Elnur', N'Ramazanzade', N'070-788-78-78', NULL)
INSERT [dbo].[Mushteri] ([Id], [Name], [Surname], [Phone], [Email]) VALUES (5, N'Yolcu', N' Nasib', N'055-450-50-50', NULL)
INSERT [dbo].[Mushteri] ([Id], [Name], [Surname], [Phone], [Email]) VALUES (6, N'Vuqar', N'Ali', N'077-420-15-05', NULL)
INSERT [dbo].[Mushteri] ([Id], [Name], [Surname], [Phone], [Email]) VALUES (7, N'Nigar', N'Adilqizi', N'050-315-00-05', NULL)
INSERT [dbo].[Mushteri] ([Id], [Name], [Surname], [Phone], [Email]) VALUES (8, N'Memmed', N'Memmedov', N'055-789-87-87', NULL)
INSERT [dbo].[Mushteri] ([Id], [Name], [Surname], [Phone], [Email]) VALUES (9, N'Tofiq', N'Ferecullayev', N'050-418-33-66', NULL)
INSERT [dbo].[Mushteri] ([Id], [Name], [Surname], [Phone], [Email]) VALUES (10, N'Tural', N'Ibrahimov', N'055-460-45-45', NULL)
INSERT [dbo].[Mushteri] ([Id], [Name], [Surname], [Phone], [Email]) VALUES (11, N'Qudret', N'Memmedov', N'055-920-23-03', NULL)
INSERT [dbo].[Mushteri] ([Id], [Name], [Surname], [Phone], [Email]) VALUES (12, N'Samir ', N'Ehmedov', N'070-200-11-14', NULL)
INSERT [dbo].[Mushteri] ([Id], [Name], [Surname], [Phone], [Email]) VALUES (13, N'Terlan', N'Agcayev', N'050-211-45-35', NULL)
INSERT [dbo].[Mushteri] ([Id], [Name], [Surname], [Phone], [Email]) VALUES (14, N'Javid', N'Cabbarov', N'055-456-56-85', NULL)
INSERT [dbo].[Mushteri] ([Id], [Name], [Surname], [Phone], [Email]) VALUES (15, N'Rustem ', N'Haciyev', N'077-320-36-76', NULL)
INSERT [dbo].[Mushteri] ([Id], [Name], [Surname], [Phone], [Email]) VALUES (17, N'Ali', N'Aliyev', N'050-455-22-11', NULL)
INSERT [dbo].[Mushteri] ([Id], [Name], [Surname], [Phone], [Email]) VALUES (18, N'Ali', N'Isgenderov', N'055-215-15-15', NULL)
INSERT [dbo].[Mushteri] ([Id], [Name], [Surname], [Phone], [Email]) VALUES (19, N'Namik', N'Ehmedov', N'050-788-89-89', NULL)
INSERT [dbo].[Mushteri] ([Id], [Name], [Surname], [Phone], [Email]) VALUES (20, N'Nazim', N'Nagiyev', N'050-355-56-89', NULL)
INSERT [dbo].[Mushteri] ([Id], [Name], [Surname], [Phone], [Email]) VALUES (21, N'Alim', N'Elekberov', N'055-456-12-78', NULL)
SET IDENTITY_INSERT [dbo].[Mushteri] OFF
SET IDENTITY_INSERT [dbo].[Otaqlar] ON 

INSERT [dbo].[Otaqlar] ([Id], [Number], [Control], [Amount]) VALUES (3, 1, N'5', 2)
INSERT [dbo].[Otaqlar] ([Id], [Number], [Control], [Amount]) VALUES (4, 2, N'6', 5)
INSERT [dbo].[Otaqlar] ([Id], [Number], [Control], [Amount]) VALUES (5, 3, N'4', 9)
INSERT [dbo].[Otaqlar] ([Id], [Number], [Control], [Amount]) VALUES (6, 4, N'3', 8)
INSERT [dbo].[Otaqlar] ([Id], [Number], [Control], [Amount]) VALUES (7, 5, N'2', 4)
INSERT [dbo].[Otaqlar] ([Id], [Number], [Control], [Amount]) VALUES (8, 6, N'7', 3)
SET IDENTITY_INSERT [dbo].[Otaqlar] OFF
ALTER TABLE [dbo].[Booking]  WITH CHECK ADD  CONSTRAINT [FK_Booking_Meydancalar] FOREIGN KEY([MeydancaId])
REFERENCES [dbo].[Meydancalar] ([Id])
GO
ALTER TABLE [dbo].[Booking] CHECK CONSTRAINT [FK_Booking_Meydancalar]
GO
ALTER TABLE [dbo].[Booking]  WITH CHECK ADD  CONSTRAINT [FK_Booking_Mushteri] FOREIGN KEY([MushteriId])
REFERENCES [dbo].[Mushteri] ([Id])
GO
ALTER TABLE [dbo].[Booking] CHECK CONSTRAINT [FK_Booking_Mushteri]
GO
ALTER TABLE [dbo].[Booking]  WITH CHECK ADD  CONSTRAINT [FK_Booking_Otaqlar] FOREIGN KEY([OtaqId])
REFERENCES [dbo].[Otaqlar] ([Id])
GO
ALTER TABLE [dbo].[Booking] CHECK CONSTRAINT [FK_Booking_Otaqlar]
GO
USE [master]
GO
ALTER DATABASE [FutbolSahesi] SET  READ_WRITE 
GO
