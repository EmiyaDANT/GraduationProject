USE [master]
GO
/****** Object:  Database [RiderBBS]    Script Date: 2022/3/6 20:43:29 ******/
CREATE DATABASE [RiderBBS] ON  PRIMARY 
( NAME = N'RiderBBS', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\RiderBBS.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'RiderBBS_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\RiderBBS_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [RiderBBS].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [RiderBBS] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [RiderBBS] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [RiderBBS] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [RiderBBS] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [RiderBBS] SET ARITHABORT OFF 
GO
ALTER DATABASE [RiderBBS] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [RiderBBS] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [RiderBBS] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [RiderBBS] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [RiderBBS] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [RiderBBS] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [RiderBBS] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [RiderBBS] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [RiderBBS] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [RiderBBS] SET  ENABLE_BROKER 
GO
ALTER DATABASE [RiderBBS] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [RiderBBS] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [RiderBBS] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [RiderBBS] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [RiderBBS] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [RiderBBS] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [RiderBBS] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [RiderBBS] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [RiderBBS] SET  MULTI_USER 
GO
ALTER DATABASE [RiderBBS] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [RiderBBS] SET DB_CHAINING OFF 
GO
USE [RiderBBS]
GO
/****** Object:  Table [dbo].[CircleTable]    Script Date: 2022/3/6 20:43:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CircleTable](
	[CircleID] [int] IDENTITY(1000,1) NOT NULL,
	[CircleMasterID] [int] NULL,
	[CircleName] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[CircleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CollectionTable]    Script Date: 2022/3/6 20:43:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CollectionTable](
	[CollectionId] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NULL,
	[PostId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[CollectionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CommentTable]    Script Date: 2022/3/6 20:43:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CommentTable](
	[CommentId] [int] IDENTITY(1,1) NOT NULL,
	[CommentDetail] [varchar](500) NULL,
	[UserId] [int] NULL,
	[PostId] [int] NULL,
	[CommentTime] [datetime] NULL,
 CONSTRAINT [PK__CommentT__C3B4DFCA615C3CD3] PRIMARY KEY CLUSTERED 
(
	[CommentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PostTable]    Script Date: 2022/3/6 20:43:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PostTable](
	[PostId] [int] IDENTITY(1,1) NOT NULL,
	[PostTypeId] [int] NULL,
	[UserId] [int] NULL,
	[PostName] [varchar](50) NOT NULL,
	[Hits] [int] NULL,
	[Views] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[PostId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TypeTable]    Script Date: 2022/3/6 20:43:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TypeTable](
	[PostTypeId] [int] IDENTITY(1,1) NOT NULL,
	[PostTypeName] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[PostTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserTable]    Script Date: 2022/3/6 20:43:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserTable](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[Username] [varchar](20) NOT NULL,
	[Userpwd] [varchar](50) NOT NULL,
	[IsAdmin] [bit] NOT NULL,
	[CircleID] [int] NULL,
 CONSTRAINT [PK__UserTabl__1788CC4C12451677] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[PostTable] ON 

INSERT [dbo].[PostTable] ([PostId], [PostTypeId], [UserId], [PostName], [Hits], [Views]) VALUES (2, 1, 1, N'GG', 0, 0)
INSERT [dbo].[PostTable] ([PostId], [PostTypeId], [UserId], [PostName], [Hits], [Views]) VALUES (3, 1, 1, N'ww', 0, 0)
INSERT [dbo].[PostTable] ([PostId], [PostTypeId], [UserId], [PostName], [Hits], [Views]) VALUES (4, 1, 1, N'hh', 0, 0)
SET IDENTITY_INSERT [dbo].[PostTable] OFF
GO
SET IDENTITY_INSERT [dbo].[TypeTable] ON 

INSERT [dbo].[TypeTable] ([PostTypeId], [PostTypeName]) VALUES (1, N'活动帖')
INSERT [dbo].[TypeTable] ([PostTypeId], [PostTypeName]) VALUES (2, N'攻略帖')
INSERT [dbo].[TypeTable] ([PostTypeId], [PostTypeName]) VALUES (3, N'器材帖')
INSERT [dbo].[TypeTable] ([PostTypeId], [PostTypeName]) VALUES (4, N'组团帖')
SET IDENTITY_INSERT [dbo].[TypeTable] OFF
GO
SET IDENTITY_INSERT [dbo].[UserTable] ON 

INSERT [dbo].[UserTable] ([UserId], [Username], [Userpwd], [IsAdmin], [CircleID]) VALUES (1, N'admin', N'123', 1, NULL)
SET IDENTITY_INSERT [dbo].[UserTable] OFF
GO
ALTER TABLE [dbo].[CommentTable] ADD  CONSTRAINT [DF_CommentTable_CommentTime]  DEFAULT (getdate()) FOR [CommentTime]
GO
ALTER TABLE [dbo].[PostTable] ADD  CONSTRAINT [DF_PostTable_Hits]  DEFAULT ((0)) FOR [Hits]
GO
ALTER TABLE [dbo].[PostTable] ADD  CONSTRAINT [DF_PostTable_Views]  DEFAULT ((0)) FOR [Views]
GO
ALTER TABLE [dbo].[UserTable] ADD  CONSTRAINT [DF_UserTable_IsAdmin]  DEFAULT ((0)) FOR [IsAdmin]
GO
ALTER TABLE [dbo].[CollectionTable]  WITH CHECK ADD FOREIGN KEY([PostId])
REFERENCES [dbo].[PostTable] ([PostId])
GO
ALTER TABLE [dbo].[CollectionTable]  WITH CHECK ADD  CONSTRAINT [FK__Collectio__UserI__300424B4] FOREIGN KEY([UserId])
REFERENCES [dbo].[UserTable] ([UserId])
GO
ALTER TABLE [dbo].[CollectionTable] CHECK CONSTRAINT [FK__Collectio__UserI__300424B4]
GO
ALTER TABLE [dbo].[CommentTable]  WITH CHECK ADD  CONSTRAINT [FK__CommentTa__PostI__2D27B809] FOREIGN KEY([PostId])
REFERENCES [dbo].[PostTable] ([PostId])
GO
ALTER TABLE [dbo].[CommentTable] CHECK CONSTRAINT [FK__CommentTa__PostI__2D27B809]
GO
ALTER TABLE [dbo].[CommentTable]  WITH CHECK ADD  CONSTRAINT [FK__CommentTa__UserI__2C3393D0] FOREIGN KEY([UserId])
REFERENCES [dbo].[UserTable] ([UserId])
GO
ALTER TABLE [dbo].[CommentTable] CHECK CONSTRAINT [FK__CommentTa__UserI__2C3393D0]
GO
ALTER TABLE [dbo].[PostTable]  WITH CHECK ADD FOREIGN KEY([PostTypeId])
REFERENCES [dbo].[TypeTable] ([PostTypeId])
GO
ALTER TABLE [dbo].[PostTable]  WITH CHECK ADD  CONSTRAINT [FK__PostTable__UserI__29572725] FOREIGN KEY([UserId])
REFERENCES [dbo].[UserTable] ([UserId])
GO
ALTER TABLE [dbo].[PostTable] CHECK CONSTRAINT [FK__PostTable__UserI__29572725]
GO
ALTER TABLE [dbo].[UserTable]  WITH CHECK ADD  CONSTRAINT [FK_UserTable_CircleTable] FOREIGN KEY([CircleID])
REFERENCES [dbo].[CircleTable] ([CircleID])
GO
ALTER TABLE [dbo].[UserTable] CHECK CONSTRAINT [FK_UserTable_CircleTable]
GO
USE [master]
GO
ALTER DATABASE [RiderBBS] SET  READ_WRITE 
GO
