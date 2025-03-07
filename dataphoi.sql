USE [master]
GO
/****** Object:  Database [Phoi]    Script Date: 11/16/2019 3:52:01 AM ******/
CREATE DATABASE [Phoi] ON  PRIMARY 
( NAME = N'Phoi', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10.SQLEXPRESS\MSSQL\DATA\Phoi.mdf' , SIZE = 2304KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Phoi_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10.SQLEXPRESS\MSSQL\DATA\Phoi_log.LDF' , SIZE = 504KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Phoi] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Phoi].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Phoi] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Phoi] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Phoi] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Phoi] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Phoi] SET ARITHABORT OFF 
GO
ALTER DATABASE [Phoi] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [Phoi] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Phoi] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Phoi] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Phoi] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Phoi] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Phoi] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Phoi] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Phoi] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Phoi] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Phoi] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Phoi] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Phoi] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Phoi] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Phoi] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Phoi] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Phoi] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Phoi] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Phoi] SET  MULTI_USER 
GO
ALTER DATABASE [Phoi] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Phoi] SET DB_CHAINING OFF 
GO
USE [Phoi]
GO
/****** Object:  Table [dbo].[chuandoanbenh]    Script Date: 11/16/2019 3:52:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[chuandoanbenh](
	[tentrieuchung] [nvarchar](100) NOT NULL,
	[tenbenh] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[tentrieuchung] ASC,
	[tenbenh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[chuandoanbenh] ([tentrieuchung], [tenbenh]) VALUES (N'Choang vang', N'Tang huyet ap')
INSERT [dbo].[chuandoanbenh] ([tentrieuchung], [tenbenh]) VALUES (N'Dau nguc', N'Bui phoi')
INSERT [dbo].[chuandoanbenh] ([tentrieuchung], [tenbenh]) VALUES (N'Dau nguc', N'Gian phe quan')
INSERT [dbo].[chuandoanbenh] ([tentrieuchung], [tenbenh]) VALUES (N'Dau nguc', N'Kho noi')
INSERT [dbo].[chuandoanbenh] ([tentrieuchung], [tenbenh]) VALUES (N'Dau nguc', N'Lao phoi')
INSERT [dbo].[chuandoanbenh] ([tentrieuchung], [tenbenh]) VALUES (N'Dau nguc', N'Tang huyet ap')
INSERT [dbo].[chuandoanbenh] ([tentrieuchung], [tenbenh]) VALUES (N'Dau nguc', N'Thuyen tac phoi')
INSERT [dbo].[chuandoanbenh] ([tentrieuchung], [tenbenh]) VALUES (N'Dau nguc', N'U hat')
INSERT [dbo].[chuandoanbenh] ([tentrieuchung], [tenbenh]) VALUES (N'Dau nguc', N'Ung thu phoi')
INSERT [dbo].[chuandoanbenh] ([tentrieuchung], [tenbenh]) VALUES (N'Dau nguc', N'Viem mang phoi')
INSERT [dbo].[chuandoanbenh] ([tentrieuchung], [tenbenh]) VALUES (N'Dau nguc', N'Viem phoi')
INSERT [dbo].[chuandoanbenh] ([tentrieuchung], [tenbenh]) VALUES (N'Hat hoi', N'Cam lanh')
INSERT [dbo].[chuandoanbenh] ([tentrieuchung], [tenbenh]) VALUES (N'Hat hoi', N'Viem phe quan')
INSERT [dbo].[chuandoanbenh] ([tentrieuchung], [tenbenh]) VALUES (N'Ho', N'Bui phoi')
INSERT [dbo].[chuandoanbenh] ([tentrieuchung], [tenbenh]) VALUES (N'Ho', N'Cam lanh')
INSERT [dbo].[chuandoanbenh] ([tentrieuchung], [tenbenh]) VALUES (N'Ho', N'Kho noi')
INSERT [dbo].[chuandoanbenh] ([tentrieuchung], [tenbenh]) VALUES (N'Ho', N'Lao phoi')
INSERT [dbo].[chuandoanbenh] ([tentrieuchung], [tenbenh]) VALUES (N'Ho', N'Sot')
INSERT [dbo].[chuandoanbenh] ([tentrieuchung], [tenbenh]) VALUES (N'Ho', N'U hat')
INSERT [dbo].[chuandoanbenh] ([tentrieuchung], [tenbenh]) VALUES (N'Ho', N'Viem phe quan')
INSERT [dbo].[chuandoanbenh] ([tentrieuchung], [tenbenh]) VALUES (N'Ho co dom', N'Sot')
INSERT [dbo].[chuandoanbenh] ([tentrieuchung], [tenbenh]) VALUES (N'Ho co dom', N'Viem phoi')
INSERT [dbo].[chuandoanbenh] ([tentrieuchung], [tenbenh]) VALUES (N'Ho co dom keo dai', N'Viem phe quan')
INSERT [dbo].[chuandoanbenh] ([tentrieuchung], [tenbenh]) VALUES (N'Ho co dom keo dai', N'Viem phe quan man tinh')
INSERT [dbo].[chuandoanbenh] ([tentrieuchung], [tenbenh]) VALUES (N'Ho kho kiem soat', N'Xo hoa phoi')
INSERT [dbo].[chuandoanbenh] ([tentrieuchung], [tenbenh]) VALUES (N'Ho ra mau', N'Gian phe quan')
INSERT [dbo].[chuandoanbenh] ([tentrieuchung], [tenbenh]) VALUES (N'Ho ra mau', N'Phu phoi')
INSERT [dbo].[chuandoanbenh] ([tentrieuchung], [tenbenh]) VALUES (N'Ho ra mau', N'Thuyen tac phoi')
INSERT [dbo].[chuandoanbenh] ([tentrieuchung], [tenbenh]) VALUES (N'Kho khe', N'Hen xuyen')
INSERT [dbo].[chuandoanbenh] ([tentrieuchung], [tenbenh]) VALUES (N'Kho noi', N'Ung thu phoi')
INSERT [dbo].[chuandoanbenh] ([tentrieuchung], [tenbenh]) VALUES (N'Kho nuot', N'Ung thu phoi')
INSERT [dbo].[chuandoanbenh] ([tentrieuchung], [tenbenh]) VALUES (N'Kho tho', N'Bui phoi')
INSERT [dbo].[chuandoanbenh] ([tentrieuchung], [tenbenh]) VALUES (N'Kho tho', N'Gian phe quan')
INSERT [dbo].[chuandoanbenh] ([tentrieuchung], [tenbenh]) VALUES (N'Kho tho', N'Hen xuyen')
INSERT [dbo].[chuandoanbenh] ([tentrieuchung], [tenbenh]) VALUES (N'Kho tho', N'Lao phoi')
INSERT [dbo].[chuandoanbenh] ([tentrieuchung], [tenbenh]) VALUES (N'Kho tho', N'Phu phoi')
INSERT [dbo].[chuandoanbenh] ([tentrieuchung], [tenbenh]) VALUES (N'Kho tho', N'U hat')
INSERT [dbo].[chuandoanbenh] ([tentrieuchung], [tenbenh]) VALUES (N'Kho tho', N'Viem mang phoi')
INSERT [dbo].[chuandoanbenh] ([tentrieuchung], [tenbenh]) VALUES (N'Kho tho', N'Viem phoi')
INSERT [dbo].[chuandoanbenh] ([tentrieuchung], [tenbenh]) VALUES (N'Kho tho', N'Xo hoa phoi')
INSERT [dbo].[chuandoanbenh] ([tentrieuchung], [tenbenh]) VALUES (N'Met moi', N'U hat')
INSERT [dbo].[chuandoanbenh] ([tentrieuchung], [tenbenh]) VALUES (N'Mo hoi trom', N'Lao phoi')
INSERT [dbo].[chuandoanbenh] ([tentrieuchung], [tenbenh]) VALUES (N'Moi kho', N'Ung thu phoi')
INSERT [dbo].[chuandoanbenh] ([tentrieuchung], [tenbenh]) VALUES (N'Noi hach', N'Ung thu phoi')
INSERT [dbo].[chuandoanbenh] ([tentrieuchung], [tenbenh]) VALUES (N'Sot', N'Cam lanh')
INSERT [dbo].[chuandoanbenh] ([tentrieuchung], [tenbenh]) VALUES (N'Sot', N'Met moi')
INSERT [dbo].[chuandoanbenh] ([tentrieuchung], [tenbenh]) VALUES (N'Sot', N'Mo hoi trom')
INSERT [dbo].[chuandoanbenh] ([tentrieuchung], [tenbenh]) VALUES (N'Sot', N'Viem phe quan')
INSERT [dbo].[chuandoanbenh] ([tentrieuchung], [tenbenh]) VALUES (N'Sot', N'Viem phoi')
INSERT [dbo].[chuandoanbenh] ([tentrieuchung], [tenbenh]) VALUES (N'Sung chan', N'Thuyen tac phoi')
INSERT [dbo].[chuandoanbenh] ([tentrieuchung], [tenbenh]) VALUES (N'Tho doc', N'U hat')
INSERT [dbo].[chuandoanbenh] ([tentrieuchung], [tenbenh]) VALUES (N'Tien su benh lao phoi', N'Gian phe quan')
INSERT [dbo].[chuandoanbenh] ([tentrieuchung], [tenbenh]) VALUES (N'Tien su benh lao phoi', N'Kho tho')
INSERT [dbo].[chuandoanbenh] ([tentrieuchung], [tenbenh]) VALUES (N'Tim dap nhanh', N'Phu phoi')
INSERT [dbo].[chuandoanbenh] ([tentrieuchung], [tenbenh]) VALUES (N'Tim dap nhanh', N'Tang huyet ap')
INSERT [dbo].[chuandoanbenh] ([tentrieuchung], [tenbenh]) VALUES (N'Tim dap nhanh', N'Tho doc')
USE [master]
GO
ALTER DATABASE [Phoi] SET  READ_WRITE 
GO
