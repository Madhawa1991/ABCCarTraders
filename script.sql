USE [master]
GO
/****** Object:  Database [ABC Car Traders]    Script Date: 9/5/2024 4:37:18 PM ******/
CREATE DATABASE [ABC Car Traders]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ABC Car Traders', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\ABC Car Traders.mdf' , SIZE = 73728KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ABC Car Traders_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\ABC Car Traders_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [ABC Car Traders] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ABC Car Traders].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ABC Car Traders] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ABC Car Traders] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ABC Car Traders] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ABC Car Traders] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ABC Car Traders] SET ARITHABORT OFF 
GO
ALTER DATABASE [ABC Car Traders] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ABC Car Traders] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ABC Car Traders] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ABC Car Traders] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ABC Car Traders] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ABC Car Traders] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ABC Car Traders] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ABC Car Traders] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ABC Car Traders] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ABC Car Traders] SET  ENABLE_BROKER 
GO
ALTER DATABASE [ABC Car Traders] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ABC Car Traders] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ABC Car Traders] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ABC Car Traders] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ABC Car Traders] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ABC Car Traders] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ABC Car Traders] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ABC Car Traders] SET RECOVERY FULL 
GO
ALTER DATABASE [ABC Car Traders] SET  MULTI_USER 
GO
ALTER DATABASE [ABC Car Traders] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ABC Car Traders] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ABC Car Traders] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ABC Car Traders] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ABC Car Traders] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ABC Car Traders] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'ABC Car Traders', N'ON'
GO
ALTER DATABASE [ABC Car Traders] SET QUERY_STORE = ON
GO
ALTER DATABASE [ABC Car Traders] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [ABC Car Traders]
GO
/****** Object:  Table [dbo].[customer]    Script Date: 9/5/2024 4:37:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[customer](
	[username] [varchar](50) NOT NULL,
	[password] [varchar](50) NOT NULL,
	[NIC] [varchar](12) NOT NULL,
	[address] [varchar](100) NOT NULL,
	[telephone] [int] NOT NULL,
	[email] [varchar](50) NOT NULL,
	[role] [varchar](10) NOT NULL,
	[Registor Date] [smalldatetime] NOT NULL,
	[Update Date] [smalldatetime] NULL,
	[userID] [nchar](10) NULL,
	[status] [varchar](10) NULL,
	[LastLoginDate] [smalldatetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Item]    Script Date: 9/5/2024 4:37:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Item](
	[ItemCode] [varchar](50) NOT NULL,
	[Vehicle/Part] [varchar](10) NULL,
	[ItemName] [varchar](100) NULL,
	[ItemPrice] [decimal](18, 0) NOT NULL,
	[Brand] [varchar](50) NULL,
	[ModelYear] [varchar](4) NULL,
	[Type] [varchar](50) NULL,
	[Pricerange] [varchar](50) NULL,
	[Condition] [varchar](50) NULL,
	[FuelType] [varchar](50) NULL,
	[Status] [varchar](50) NULL,
	[Mileage] [int] NULL,
	[Description] [varchar](500) NULL,
	[ItemImage] [varbinary](max) NULL,
	[AddDate] [smalldatetime] NOT NULL,
	[EditDate] [smalldatetime] NULL,
	[StatusChangeDate] [smalldatetime] NULL,
 CONSTRAINT [PK_Item] PRIMARY KEY CLUSTERED 
(
	[ItemCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[order]    Script Date: 9/5/2024 4:37:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[order](
	[OrderID] [varchar](50) NOT NULL,
	[ItemCode] [varchar](50) NOT NULL,
	[UserID] [varchar](50) NOT NULL,
	[OrderStatus] [varchar](50) NOT NULL,
	[CustomerComment] [varchar](500) NULL,
	[AdminComment] [varchar](500) NULL,
	[OrderDate] [smalldatetime] NULL,
	[RejectDate] [smalldatetime] NULL,
	[SoldDate] [smalldatetime] NULL,
	[CancelDate] [smalldatetime] NULL,
	[RemoveDate] [smalldatetime] NULL,
	[AcceptedDate] [nchar](10) NULL
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [ABC Car Traders] SET  READ_WRITE 
GO
