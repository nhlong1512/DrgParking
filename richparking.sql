USE [master]
GO
/****** Object:  Database [RichParking]    Script Date: 7/7/2023 12:41:55 PM ******/
CREATE DATABASE [RichParking]
GO
ALTER DATABASE [RichParking] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [RichParking].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [RichParking] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [RichParking] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [RichParking] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [RichParking] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [RichParking] SET ARITHABORT OFF 
GO
ALTER DATABASE [RichParking] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [RichParking] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [RichParking] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [RichParking] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [RichParking] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [RichParking] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [RichParking] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [RichParking] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [RichParking] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [RichParking] SET  DISABLE_BROKER 
GO
ALTER DATABASE [RichParking] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [RichParking] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [RichParking] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [RichParking] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [RichParking] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [RichParking] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [RichParking] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [RichParking] SET RECOVERY FULL 
GO
ALTER DATABASE [RichParking] SET  MULTI_USER 
GO
ALTER DATABASE [RichParking] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [RichParking] SET DB_CHAINING OFF 
GO
ALTER DATABASE [RichParking] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [RichParking] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [RichParking] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [RichParking] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'RichParking', N'ON'
GO
ALTER DATABASE [RichParking] SET QUERY_STORE = OFF
GO
USE [RichParking]
GO
/****** Object:  Table [dbo].[Car]    Script Date: 7/7/2023 12:41:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Car](
	[CarID] [nvarchar](50) NOT NULL,
	[CarType] [int] NULL,
	[LicensePlate] [nvarchar](50) NULL,
	[InTime] [datetime] NULL,
	[OutTime] [datetime] NULL,
	[IsDeleted] [bit] NULL,
	[IsWash] [bit] NULL,
	[IsOilChange] [bit] NULL,
	[CreatedBy] [nvarchar](50) NULL,
	[CreatedDate] [datetime] NULL,
	[ModifiedBy] [nvarchar](50) NULL,
	[ModifiedDate] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[CarID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Invoice]    Script Date: 7/7/2023 12:41:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Invoice](
	[InvoiceID] [nvarchar](50) NOT NULL,
	[Price] [decimal](18, 0) NULL,
	[IsDeleted] [bit] NULL,
	[CreatedBy] [nvarchar](50) NULL,
	[CreatedDate] [datetime] NULL,
	[ModifiedBy] [nvarchar](50) NULL,
	[ModifiedDate] [datetime] NULL,
	[CarID] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[InvoiceID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Car] ([CarID], [CarType], [LicensePlate], [InTime], [OutTime], [IsDeleted], [IsWash], [IsOilChange], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate]) VALUES (N'01adfbc4-50ea-4e74-af75-5fadbe3ab603', 1, N'51A-49434', CAST(N'2023-02-20T03:18:02.173' AS DateTime), CAST(N'2023-02-20T03:18:02.847' AS DateTime), 1, 1, 0, NULL, CAST(N'2023-02-20T03:18:02.173' AS DateTime), NULL, NULL)
INSERT [dbo].[Car] ([CarID], [CarType], [LicensePlate], [InTime], [OutTime], [IsDeleted], [IsWash], [IsOilChange], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate]) VALUES (N'046109eb-6826-45fd-8ee1-9448497d13a9', 3, N'73A-2321', CAST(N'2023-06-23T05:28:22.517' AS DateTime), CAST(N'2023-06-23T05:28:23.087' AS DateTime), 1, 0, 0, NULL, CAST(N'2023-06-23T05:28:22.517' AS DateTime), NULL, NULL)
INSERT [dbo].[Car] ([CarID], [CarType], [LicensePlate], [InTime], [OutTime], [IsDeleted], [IsWash], [IsOilChange], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate]) VALUES (N'08532e03-66db-4e99-bcbd-a50f94a2dfeb', 3, N'74E-13224', CAST(N'2023-07-05T08:29:20.847' AS DateTime), CAST(N'2023-07-05T08:29:21.663' AS DateTime), 1, 1, 1, NULL, CAST(N'2023-07-05T08:29:20.847' AS DateTime), NULL, NULL)
INSERT [dbo].[Car] ([CarID], [CarType], [LicensePlate], [InTime], [OutTime], [IsDeleted], [IsWash], [IsOilChange], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate]) VALUES (N'094940e3-1d37-4a3f-bc90-8e9a8a770b0c', 3, N'16E-43234', CAST(N'2023-05-21T10:26:58.897' AS DateTime), CAST(N'2023-05-21T10:26:59.507' AS DateTime), 1, 1, 0, NULL, CAST(N'2023-05-21T10:26:58.897' AS DateTime), NULL, NULL)
INSERT [dbo].[Car] ([CarID], [CarType], [LicensePlate], [InTime], [OutTime], [IsDeleted], [IsWash], [IsOilChange], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate]) VALUES (N'0fb65272-d257-4817-ad98-7bea8ba57d8a', 2, N'51A-49439', CAST(N'2023-02-20T03:17:50.817' AS DateTime), CAST(N'2023-02-20T03:17:52.800' AS DateTime), 1, 1, 1, NULL, CAST(N'2023-02-20T03:17:50.817' AS DateTime), NULL, NULL)
INSERT [dbo].[Car] ([CarID], [CarType], [LicensePlate], [InTime], [OutTime], [IsDeleted], [IsWash], [IsOilChange], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate]) VALUES (N'219b6fcf-54d5-4df4-a613-ffb664bb65c8', 3, N'74A-56789', CAST(N'2023-07-07T11:58:46.927' AS DateTime), NULL, 0, 1, 0, NULL, CAST(N'2023-07-07T11:58:46.927' AS DateTime), NULL, NULL)
INSERT [dbo].[Car] ([CarID], [CarType], [LicensePlate], [InTime], [OutTime], [IsDeleted], [IsWash], [IsOilChange], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate]) VALUES (N'2cb36d53-0456-4b1d-b45c-df805e6a7a0a', 1, N'12A-43234', CAST(N'2023-05-21T10:26:40.643' AS DateTime), CAST(N'2023-05-21T10:26:41.443' AS DateTime), 1, 1, 1, NULL, CAST(N'2023-05-21T10:26:40.643' AS DateTime), NULL, NULL)
INSERT [dbo].[Car] ([CarID], [CarType], [LicensePlate], [InTime], [OutTime], [IsDeleted], [IsWash], [IsOilChange], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate]) VALUES (N'3ed38122-d70c-470c-a87b-dd9758d43321', 3, N'61D-34245', CAST(N'2023-07-07T11:54:28.773' AS DateTime), CAST(N'2023-07-07T11:58:15.097' AS DateTime), 1, 1, 1, NULL, CAST(N'2023-07-07T11:54:28.773' AS DateTime), NULL, NULL)
INSERT [dbo].[Car] ([CarID], [CarType], [LicensePlate], [InTime], [OutTime], [IsDeleted], [IsWash], [IsOilChange], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate]) VALUES (N'462fe513-26a4-4feb-93b3-e52bda66d20b', 2, N'16A-43234', CAST(N'2023-05-21T10:26:49.090' AS DateTime), CAST(N'2023-05-21T10:26:49.837' AS DateTime), 1, 1, 1, NULL, CAST(N'2023-05-21T10:26:49.090' AS DateTime), NULL, NULL)
INSERT [dbo].[Car] ([CarID], [CarType], [LicensePlate], [InTime], [OutTime], [IsDeleted], [IsWash], [IsOilChange], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate]) VALUES (N'69612def-7c2f-4ca6-8809-9d43b683971f', 2, N'74E-43243', CAST(N'2023-07-05T08:29:33.937' AS DateTime), CAST(N'2023-07-05T08:29:34.553' AS DateTime), 1, 0, 0, NULL, CAST(N'2023-07-05T08:29:33.937' AS DateTime), NULL, NULL)
INSERT [dbo].[Car] ([CarID], [CarType], [LicensePlate], [InTime], [OutTime], [IsDeleted], [IsWash], [IsOilChange], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate]) VALUES (N'7094f3d8-3c8c-479f-a75d-1607291dab7a', 1, N'74A-24523', CAST(N'2023-07-07T11:58:55.717' AS DateTime), NULL, 0, 1, 0, NULL, CAST(N'2023-07-07T11:58:55.717' AS DateTime), NULL, NULL)
INSERT [dbo].[Car] ([CarID], [CarType], [LicensePlate], [InTime], [OutTime], [IsDeleted], [IsWash], [IsOilChange], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate]) VALUES (N'7125cbfa-fc75-4a9a-9a85-4346c86ce0b8', 1, N'74A-54222', CAST(N'2023-07-07T12:03:33.703' AS DateTime), CAST(N'2023-07-07T12:04:11.847' AS DateTime), 0, 1, 0, NULL, CAST(N'2023-07-07T12:03:33.703' AS DateTime), NULL, NULL)
INSERT [dbo].[Car] ([CarID], [CarType], [LicensePlate], [InTime], [OutTime], [IsDeleted], [IsWash], [IsOilChange], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate]) VALUES (N'7e7314be-9647-46e9-93cb-d9a82c60e9e7', 1, N'12A-12345', CAST(N'2023-01-17T10:15:32.653' AS DateTime), CAST(N'2023-01-17T10:15:48.020' AS DateTime), 1, 0, 1, NULL, CAST(N'2023-01-17T10:15:32.653' AS DateTime), NULL, NULL)
INSERT [dbo].[Car] ([CarID], [CarType], [LicensePlate], [InTime], [OutTime], [IsDeleted], [IsWash], [IsOilChange], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate]) VALUES (N'82c3c6b6-41ad-4b66-a275-297251a03e70', 2, N'52A-24578', CAST(N'2023-03-08T07:25:16.063' AS DateTime), CAST(N'2023-03-08T07:25:16.763' AS DateTime), 1, 1, 1, NULL, CAST(N'2023-03-08T07:25:16.063' AS DateTime), NULL, NULL)
INSERT [dbo].[Car] ([CarID], [CarType], [LicensePlate], [InTime], [OutTime], [IsDeleted], [IsWash], [IsOilChange], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate]) VALUES (N'946e0ed2-91ac-4da4-b2f3-4dcdcd22f3d2', 3, N'52A-22222', CAST(N'2023-03-08T07:25:36.580' AS DateTime), CAST(N'2023-03-08T07:25:37.403' AS DateTime), 1, 1, 1, NULL, CAST(N'2023-03-08T07:25:36.580' AS DateTime), NULL, NULL)
INSERT [dbo].[Car] ([CarID], [CarType], [LicensePlate], [InTime], [OutTime], [IsDeleted], [IsWash], [IsOilChange], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate]) VALUES (N'9bc15ca1-35f4-4bd1-b207-37c88cabe756', 3, N'74A-51230', CAST(N'2023-07-07T11:59:57.350' AS DateTime), NULL, 0, 1, 1, NULL, CAST(N'2023-07-07T11:59:57.350' AS DateTime), NULL, NULL)
INSERT [dbo].[Car] ([CarID], [CarType], [LicensePlate], [InTime], [OutTime], [IsDeleted], [IsWash], [IsOilChange], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate]) VALUES (N'a16980fa-94b9-4397-9f08-3f03f4e9c863', 3, N'72A-78032', CAST(N'2023-06-21T10:27:28.523' AS DateTime), CAST(N'2023-06-21T10:27:29.930' AS DateTime), 1, 0, 1, NULL, CAST(N'2023-06-21T10:27:28.523' AS DateTime), NULL, NULL)
INSERT [dbo].[Car] ([CarID], [CarType], [LicensePlate], [InTime], [OutTime], [IsDeleted], [IsWash], [IsOilChange], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate]) VALUES (N'a2dc5857-3bdf-4aba-bd3d-957aeccf3e23', 3, N'62D-2342', CAST(N'2023-07-07T11:58:36.920' AS DateTime), NULL, 0, 0, 1, NULL, CAST(N'2023-07-07T11:58:36.920' AS DateTime), NULL, NULL)
INSERT [dbo].[Car] ([CarID], [CarType], [LicensePlate], [InTime], [OutTime], [IsDeleted], [IsWash], [IsOilChange], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate]) VALUES (N'aec00acc-a0a7-4616-ada1-d3d22f23e492', 1, N'74A-19742', CAST(N'2023-07-07T08:30:23.563' AS DateTime), CAST(N'2023-07-07T08:30:24.737' AS DateTime), 1, 1, 0, NULL, CAST(N'2023-07-07T08:30:23.563' AS DateTime), NULL, NULL)
INSERT [dbo].[Car] ([CarID], [CarType], [LicensePlate], [InTime], [OutTime], [IsDeleted], [IsWash], [IsOilChange], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate]) VALUES (N'b2dbea5a-7b1f-4baa-b71e-50b40b9f18aa', 1, N'54B-24342', CAST(N'2023-04-21T10:26:06.480' AS DateTime), CAST(N'2023-04-21T10:26:08.367' AS DateTime), 1, 0, 1, NULL, CAST(N'2023-04-21T10:26:06.480' AS DateTime), NULL, NULL)
INSERT [dbo].[Car] ([CarID], [CarType], [LicensePlate], [InTime], [OutTime], [IsDeleted], [IsWash], [IsOilChange], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate]) VALUES (N'b771f48f-00d2-4cdc-a5d4-3d1774c5e286', 3, N'74A-78902', CAST(N'2023-07-05T08:29:11.160' AS DateTime), CAST(N'2023-07-05T08:29:11.823' AS DateTime), 1, 1, 0, NULL, CAST(N'2023-07-05T08:29:11.160' AS DateTime), NULL, NULL)
INSERT [dbo].[Car] ([CarID], [CarType], [LicensePlate], [InTime], [OutTime], [IsDeleted], [IsWash], [IsOilChange], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate]) VALUES (N'b7f79670-2824-4026-909a-f8c429586177', 2, N'12A-23432', CAST(N'2023-07-05T08:29:49.320' AS DateTime), CAST(N'2023-07-05T08:29:50.000' AS DateTime), 1, 1, 1, NULL, CAST(N'2023-07-05T08:29:49.320' AS DateTime), NULL, NULL)
INSERT [dbo].[Car] ([CarID], [CarType], [LicensePlate], [InTime], [OutTime], [IsDeleted], [IsWash], [IsOilChange], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate]) VALUES (N'b92ebec5-6f75-499d-acaf-ac005069e305', 2, N'52A-24532', CAST(N'2023-03-08T07:25:25.747' AS DateTime), CAST(N'2023-03-08T07:25:27.677' AS DateTime), 1, 1, 0, NULL, CAST(N'2023-03-08T07:25:25.747' AS DateTime), NULL, NULL)
INSERT [dbo].[Car] ([CarID], [CarType], [LicensePlate], [InTime], [OutTime], [IsDeleted], [IsWash], [IsOilChange], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate]) VALUES (N'b9bec6d7-fa2c-4728-8e00-5c3987ea7edf', 2, N'82D-34234', CAST(N'2023-07-07T11:54:16.463' AS DateTime), NULL, 0, 0, 1, NULL, CAST(N'2023-07-07T11:54:16.463' AS DateTime), NULL, NULL)
INSERT [dbo].[Car] ([CarID], [CarType], [LicensePlate], [InTime], [OutTime], [IsDeleted], [IsWash], [IsOilChange], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate]) VALUES (N'd1bb5a4b-49a3-42ab-aecd-86939fbdb652', 1, N'23A-64532', CAST(N'2023-01-17T10:15:44.603' AS DateTime), CAST(N'2023-01-17T10:15:50.730' AS DateTime), 1, 0, 1, NULL, CAST(N'2023-01-17T10:15:44.603' AS DateTime), NULL, NULL)
INSERT [dbo].[Car] ([CarID], [CarType], [LicensePlate], [InTime], [OutTime], [IsDeleted], [IsWash], [IsOilChange], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate]) VALUES (N'd77425b3-90d0-4e99-b5bc-782537796102', 2, N'74A-19730', CAST(N'2023-07-07T08:30:12.247' AS DateTime), CAST(N'2023-07-07T08:30:13.417' AS DateTime), 1, 1, 1, NULL, CAST(N'2023-07-07T08:30:12.247' AS DateTime), NULL, NULL)
INSERT [dbo].[Car] ([CarID], [CarType], [LicensePlate], [InTime], [OutTime], [IsDeleted], [IsWash], [IsOilChange], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate]) VALUES (N'e8f56740-a599-4e84-a371-d8ae14842318', 2, N'72A-34250', CAST(N'2023-06-21T10:27:40.713' AS DateTime), CAST(N'2023-06-21T10:27:41.507' AS DateTime), 1, 1, 1, NULL, CAST(N'2023-06-21T10:27:40.713' AS DateTime), NULL, NULL)
INSERT [dbo].[Car] ([CarID], [CarType], [LicensePlate], [InTime], [OutTime], [IsDeleted], [IsWash], [IsOilChange], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate]) VALUES (N'f28cda3e-9214-44e3-a6cf-feb25c29d6d0', 1, N'74A-56444', CAST(N'2023-07-07T12:03:55.880' AS DateTime), NULL, 0, 1, 0, NULL, CAST(N'2023-07-07T12:03:55.880' AS DateTime), NULL, NULL)
INSERT [dbo].[Car] ([CarID], [CarType], [LicensePlate], [InTime], [OutTime], [IsDeleted], [IsWash], [IsOilChange], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate]) VALUES (N'f29895f0-c0cd-4a35-975d-c647f4edb0de', 1, N'73A-23245', CAST(N'2023-06-23T05:28:11.640' AS DateTime), CAST(N'2023-06-23T05:28:12.510' AS DateTime), 1, 1, 0, NULL, CAST(N'2023-06-23T05:28:11.640' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Invoice] ([InvoiceID], [Price], [IsDeleted], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate], [CarID]) VALUES (N'009ff6f3-0ea1-40b7-be3f-fcc0674211f3', CAST(67 AS Decimal(18, 0)), 0, NULL, CAST(N'2023-03-08T07:25:16.770' AS DateTime), NULL, NULL, N'82c3c6b6-41ad-4b66-a275-297251a03e70')
INSERT [dbo].[Invoice] ([InvoiceID], [Price], [IsDeleted], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate], [CarID]) VALUES (N'19d90c43-c607-453a-854b-a6c814028220', CAST(7 AS Decimal(18, 0)), 0, NULL, CAST(N'2023-07-05T08:29:34.573' AS DateTime), NULL, NULL, N'69612def-7c2f-4ca6-8809-9d43b683971f')
INSERT [dbo].[Invoice] ([InvoiceID], [Price], [IsDeleted], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate], [CarID]) VALUES (N'21da9dfc-e10c-4acf-9738-99ed08504240', CAST(59 AS Decimal(18, 0)), 0, NULL, CAST(N'2023-06-21T10:27:29.937' AS DateTime), NULL, NULL, N'a16980fa-94b9-4397-9f08-3f03f4e9c863')
INSERT [dbo].[Invoice] ([InvoiceID], [Price], [IsDeleted], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate], [CarID]) VALUES (N'2bc5e15e-0fe4-4a3f-9e26-07410b40dbba', CAST(67 AS Decimal(18, 0)), 0, NULL, CAST(N'2023-05-21T10:26:49.840' AS DateTime), NULL, NULL, N'462fe513-26a4-4feb-93b3-e52bda66d20b')
INSERT [dbo].[Invoice] ([InvoiceID], [Price], [IsDeleted], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate], [CarID]) VALUES (N'3ca30214-b43a-4516-ad50-0b8350307d6e', CAST(67 AS Decimal(18, 0)), 0, NULL, CAST(N'2023-02-20T03:17:52.807' AS DateTime), NULL, NULL, N'0fb65272-d257-4817-ad98-7bea8ba57d8a')
INSERT [dbo].[Invoice] ([InvoiceID], [Price], [IsDeleted], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate], [CarID]) VALUES (N'3f9c4159-6a35-4a87-af30-b5fe7acbb57f', CAST(55 AS Decimal(18, 0)), 0, NULL, CAST(N'2023-04-21T10:26:08.377' AS DateTime), NULL, NULL, N'b2dbea5a-7b1f-4baa-b71e-50b40b9f18aa')
INSERT [dbo].[Invoice] ([InvoiceID], [Price], [IsDeleted], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate], [CarID]) VALUES (N'50d03134-ef9b-4448-b8ec-a8b7ff226759', CAST(69 AS Decimal(18, 0)), 0, NULL, CAST(N'2023-03-08T07:25:37.407' AS DateTime), NULL, NULL, N'946e0ed2-91ac-4da4-b2f3-4dcdcd22f3d2')
INSERT [dbo].[Invoice] ([InvoiceID], [Price], [IsDeleted], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate], [CarID]) VALUES (N'52f4c4e4-a192-4b04-b08f-7f5696432a50', CAST(9 AS Decimal(18, 0)), 0, NULL, CAST(N'2023-06-23T05:28:23.093' AS DateTime), NULL, NULL, N'046109eb-6826-45fd-8ee1-9448497d13a9')
INSERT [dbo].[Invoice] ([InvoiceID], [Price], [IsDeleted], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate], [CarID]) VALUES (N'57816563-0703-46a6-ab86-bddcaed528e7', CAST(67 AS Decimal(18, 0)), 0, NULL, CAST(N'2023-07-05T08:29:50.010' AS DateTime), NULL, NULL, N'b7f79670-2824-4026-909a-f8c429586177')
INSERT [dbo].[Invoice] ([InvoiceID], [Price], [IsDeleted], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate], [CarID]) VALUES (N'750bc603-b509-4ffb-bb6d-110120263d44', CAST(67 AS Decimal(18, 0)), 0, NULL, CAST(N'2023-07-07T08:30:13.423' AS DateTime), NULL, NULL, N'd77425b3-90d0-4e99-b5bc-782537796102')
INSERT [dbo].[Invoice] ([InvoiceID], [Price], [IsDeleted], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate], [CarID]) VALUES (N'79fbd419-2182-4e73-8bdd-a174846da21a', CAST(15 AS Decimal(18, 0)), 0, NULL, CAST(N'2023-07-07T08:30:24.743' AS DateTime), NULL, NULL, N'aec00acc-a0a7-4616-ada1-d3d22f23e492')
INSERT [dbo].[Invoice] ([InvoiceID], [Price], [IsDeleted], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate], [CarID]) VALUES (N'81ca3382-8e80-42ca-ae53-cd94655717cf', CAST(15 AS Decimal(18, 0)), 0, NULL, CAST(N'2023-06-23T05:28:12.517' AS DateTime), NULL, NULL, N'f29895f0-c0cd-4a35-975d-c647f4edb0de')
INSERT [dbo].[Invoice] ([InvoiceID], [Price], [IsDeleted], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate], [CarID]) VALUES (N'911c96e1-4671-4f79-8074-4e200e20a813', CAST(19 AS Decimal(18, 0)), 0, NULL, CAST(N'2023-07-05T08:29:11.830' AS DateTime), NULL, NULL, N'b771f48f-00d2-4cdc-a5d4-3d1774c5e286')
INSERT [dbo].[Invoice] ([InvoiceID], [Price], [IsDeleted], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate], [CarID]) VALUES (N'94ac8838-a4c2-4bf6-a711-b2157056db36', CAST(55 AS Decimal(18, 0)), 0, NULL, CAST(N'2023-01-17T10:15:48.027' AS DateTime), NULL, NULL, N'7e7314be-9647-46e9-93cb-d9a82c60e9e7')
INSERT [dbo].[Invoice] ([InvoiceID], [Price], [IsDeleted], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate], [CarID]) VALUES (N'9d5a68fd-6971-4f24-b856-4a866deb1cea', CAST(69 AS Decimal(18, 0)), 0, NULL, CAST(N'2023-07-05T08:29:21.667' AS DateTime), NULL, NULL, N'08532e03-66db-4e99-bcbd-a50f94a2dfeb')
INSERT [dbo].[Invoice] ([InvoiceID], [Price], [IsDeleted], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate], [CarID]) VALUES (N'a1c67ad5-d9e6-4160-94bd-2829bb4ecec6', CAST(17 AS Decimal(18, 0)), 0, NULL, CAST(N'2023-03-08T07:25:27.680' AS DateTime), NULL, NULL, N'b92ebec5-6f75-499d-acaf-ac005069e305')
INSERT [dbo].[Invoice] ([InvoiceID], [Price], [IsDeleted], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate], [CarID]) VALUES (N'a97166fc-07af-452d-ad57-239ce3b001bf', CAST(15 AS Decimal(18, 0)), 0, NULL, CAST(N'2023-07-07T12:04:11.857' AS DateTime), NULL, NULL, N'7125cbfa-fc75-4a9a-9a85-4346c86ce0b8')
INSERT [dbo].[Invoice] ([InvoiceID], [Price], [IsDeleted], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate], [CarID]) VALUES (N'ac0a0bd5-ae2e-44db-a6bb-eff0b83e50f6', CAST(65 AS Decimal(18, 0)), 0, NULL, CAST(N'2023-05-21T10:26:41.453' AS DateTime), NULL, NULL, N'2cb36d53-0456-4b1d-b45c-df805e6a7a0a')
INSERT [dbo].[Invoice] ([InvoiceID], [Price], [IsDeleted], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate], [CarID]) VALUES (N'ad02816a-d910-41f7-9297-9714a960aaab', CAST(67 AS Decimal(18, 0)), 0, NULL, CAST(N'2023-06-21T10:27:41.510' AS DateTime), NULL, NULL, N'e8f56740-a599-4e84-a371-d8ae14842318')
INSERT [dbo].[Invoice] ([InvoiceID], [Price], [IsDeleted], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate], [CarID]) VALUES (N'd6cd2924-164a-41d4-b3c6-66678be51f5d', CAST(55 AS Decimal(18, 0)), 0, NULL, CAST(N'2023-01-17T10:15:50.737' AS DateTime), NULL, NULL, N'd1bb5a4b-49a3-42ab-aecd-86939fbdb652')
INSERT [dbo].[Invoice] ([InvoiceID], [Price], [IsDeleted], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate], [CarID]) VALUES (N'e0765843-b5ce-4649-aaeb-599b7cdf4e25', CAST(15 AS Decimal(18, 0)), 0, NULL, CAST(N'2023-02-20T03:18:02.850' AS DateTime), NULL, NULL, N'01adfbc4-50ea-4e74-af75-5fadbe3ab603')
INSERT [dbo].[Invoice] ([InvoiceID], [Price], [IsDeleted], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate], [CarID]) VALUES (N'e10973e1-ba24-4822-93df-8eb1d170dc1b', CAST(19 AS Decimal(18, 0)), 0, NULL, CAST(N'2023-05-21T10:26:59.513' AS DateTime), NULL, NULL, N'094940e3-1d37-4a3f-bc90-8e9a8a770b0c')
INSERT [dbo].[Invoice] ([InvoiceID], [Price], [IsDeleted], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate], [CarID]) VALUES (N'f9bae241-53b4-4f07-b6f2-3f0988b7f75a', CAST(69 AS Decimal(18, 0)), 0, NULL, CAST(N'2023-07-07T11:58:15.110' AS DateTime), NULL, NULL, N'3ed38122-d70c-470c-a87b-dd9758d43321')
GO
ALTER TABLE [dbo].[Invoice]  WITH CHECK ADD FOREIGN KEY([CarID])
REFERENCES [dbo].[Car] ([CarID])
GO
USE [master]
GO
ALTER DATABASE [RichParking] SET  READ_WRITE 
GO
