USE [master]
GO
/****** Object:  Database [AppTestDB]    Script Date: 21/11/2023 22.22.03 ******/
CREATE DATABASE [AppTestDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'AppTestDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\AppTestDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'AppTestDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\AppTestDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [AppTestDB] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [AppTestDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [AppTestDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [AppTestDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [AppTestDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [AppTestDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [AppTestDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [AppTestDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [AppTestDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [AppTestDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [AppTestDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [AppTestDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [AppTestDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [AppTestDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [AppTestDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [AppTestDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [AppTestDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [AppTestDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [AppTestDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [AppTestDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [AppTestDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [AppTestDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [AppTestDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [AppTestDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [AppTestDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [AppTestDB] SET  MULTI_USER 
GO
ALTER DATABASE [AppTestDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [AppTestDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [AppTestDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [AppTestDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [AppTestDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [AppTestDB] SET QUERY_STORE = OFF
GO
USE [AppTestDB]
GO
/****** Object:  UserDefinedTableType [dbo].[genderType]    Script Date: 21/11/2023 22.22.03 ******/
CREATE TYPE [dbo].[genderType] AS TABLE(
	[Id] [int] NULL,
	[Nama] [varchar](255) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[HobiType]    Script Date: 21/11/2023 22.22.03 ******/
CREATE TYPE [dbo].[HobiType] AS TABLE(
	[Id] [varchar](1) NULL,
	[Nama] [varchar](255) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[PersonalType]    Script Date: 21/11/2023 22.22.03 ******/
CREATE TYPE [dbo].[PersonalType] AS TABLE(
	[Id] [int] NULL,
	[Nama] [varchar](255) NULL,
	[IdGender] [int] NULL,
	[IdHobi] [char](1) NULL,
	[Umur] [int] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UmurType]    Script Date: 21/11/2023 22.22.03 ******/
CREATE TYPE [dbo].[UmurType] AS TABLE(
	[Umur] [int] NULL,
	[Total] [int] NULL
)
GO
/****** Object:  Table [dbo].[tblM_gender]    Script Date: 21/11/2023 22.22.03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblM_gender](
	[Id] [int] NOT NULL,
	[Nama] [varchar](255) NULL,
 CONSTRAINT [PK__tblM_gen__3214EC07D356321F] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblM_Hobi]    Script Date: 21/11/2023 22.22.03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblM_Hobi](
	[Id] [varchar](1) NOT NULL,
	[Nama] [varchar](255) NULL,
 CONSTRAINT [PK__tblM_Hob__3214EC07B324D7FD] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblT_Personal]    Script Date: 21/11/2023 22.22.03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblT_Personal](
	[Id] [int] NOT NULL,
	[Nama] [varchar](255) NULL,
	[IdGender] [int] NULL,
	[IdHobi] [varchar](1) NULL,
	[Umur] [int] NULL,
 CONSTRAINT [PK__tblT_Per__3214EC0760D2DBB6] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblT_Umur]    Script Date: 21/11/2023 22.22.03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblT_Umur](
	[Umur] [int] NULL,
	[Total] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[InsertData]    Script Date: 21/11/2023 22.22.03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[InsertData]
    @gender genderType READONLY,
	@hobi HobiType READONLY,
	@person PersonalType READONLY,
	@umur UmurType READONLY
AS
BEGIN
	-- check and insert for gender data
	MERGE dbo.tblM_gender  AS gn
    USING @gender AS src
      ON src.id = gn.id
     WHEN MATCHED THEN
       UPDATE SET Nama = src.Nama
     WHEN NOT MATCHED BY TARGET THEN
       INSERT (Id, Nama)
       VALUES (src.Id, src.Nama);

	-- hoby data
	MERGE dbo.tblM_Hobi  AS hb
    USING @hobi AS hbt
      ON hbt.id = hb.id
     WHEN MATCHED THEN
       UPDATE SET Nama = hbt.Nama
     WHEN NOT MATCHED BY TARGET THEN
       INSERT (Id, Nama)
       VALUES (hbt.Id, hbt.Nama);

	--person type
	MERGE dbo.tblT_Personal  AS ps
    USING @person AS pst
      ON pst.id = ps.id
     WHEN MATCHED THEN
       UPDATE SET Nama = pst.Nama,IdGender=pst.IdGender,IdHobi=pst.IdHobi,Umur=pst.Umur
     WHEN NOT MATCHED BY TARGET THEN
       INSERT (Id, Nama,IdGender,IdHobi,Umur)
       VALUES (pst.Id, pst.Nama,pst.IdGender,pst.IdHobi,pst.Umur);

	   -- Umur data
	MERGE dbo.tblT_Umur  AS um
    USING @umur AS umt
      ON umt.Umur = um.Umur
     WHEN MATCHED THEN
       UPDATE SET Total = umt.Total
     WHEN NOT MATCHED BY TARGET THEN
       INSERT (Umur, Total)
       VALUES (umt.Umur, umt.Total);
END
GO
USE [master]
GO
ALTER DATABASE [AppTestDB] SET  READ_WRITE 
GO
