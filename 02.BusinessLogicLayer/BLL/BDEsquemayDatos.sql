USE [master]
GO
/****** Object:  Database [ClubDeportivo]    Script Date: 03/09/2018 06:32:04 a. m. ******/
CREATE DATABASE [ClubDeportivo]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ClubDeportivo', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\ClubDeportivo.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ClubDeportivo_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\ClubDeportivo_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [ClubDeportivo] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ClubDeportivo].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ClubDeportivo] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ClubDeportivo] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ClubDeportivo] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ClubDeportivo] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ClubDeportivo] SET ARITHABORT OFF 
GO
ALTER DATABASE [ClubDeportivo] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ClubDeportivo] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ClubDeportivo] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ClubDeportivo] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ClubDeportivo] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ClubDeportivo] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ClubDeportivo] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ClubDeportivo] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ClubDeportivo] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ClubDeportivo] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ClubDeportivo] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ClubDeportivo] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ClubDeportivo] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ClubDeportivo] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ClubDeportivo] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ClubDeportivo] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ClubDeportivo] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ClubDeportivo] SET RECOVERY FULL 
GO
ALTER DATABASE [ClubDeportivo] SET  MULTI_USER 
GO
ALTER DATABASE [ClubDeportivo] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ClubDeportivo] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ClubDeportivo] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ClubDeportivo] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
USE [ClubDeportivo]
GO
/****** Object:  Table [dbo].[Canchas]    Script Date: 03/09/2018 06:32:06 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Canchas](
	[id_cancha] [int] IDENTITY(1,1) NOT NULL,
	[tipo_cancha] [nvarchar](50) NOT NULL,
	[costo] [decimal](10, 2) NOT NULL,
	[status] [bit] NOT NULL,
 CONSTRAINT [PK_Canchas] PRIMARY KEY CLUSTERED 
(
	[id_cancha] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 03/09/2018 06:32:06 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clientes](
	[rfc] [nvarchar](13) NOT NULL,
	[nombre] [nvarchar](150) NOT NULL,
	[telefono] [nvarchar](15) NOT NULL,
	[status] [bit] NOT NULL,
 CONSTRAINT [PK_Clientes] PRIMARY KEY CLUSTERED 
(
	[rfc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Reservaciones]    Script Date: 03/09/2018 06:32:06 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reservaciones](
	[id_reservacion] [int] IDENTITY(1,1) NOT NULL,
	[id_cancha] [int] NOT NULL,
	[entrada] [datetime] NOT NULL,
	[salida] [datetime] NOT NULL,
	[arbitro] [bit] NOT NULL,
	[total] [decimal](12, 2) NOT NULL,
	[rfc] [nvarchar](13) NOT NULL,
	[estado_reservacion] [nchar](1) NOT NULL,
 CONSTRAINT [PK_Reservaciones_1] PRIMARY KEY CLUSTERED 
(
	[id_reservacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Canchas] ON 

INSERT [dbo].[Canchas] ([id_cancha], [tipo_cancha], [costo], [status]) VALUES (1, N'Tierra', CAST(400.00 AS Decimal(10, 2)), 1)
INSERT [dbo].[Canchas] ([id_cancha], [tipo_cancha], [costo], [status]) VALUES (2, N'Cesped Artificial', CAST(600.00 AS Decimal(10, 2)), 1)
INSERT [dbo].[Canchas] ([id_cancha], [tipo_cancha], [costo], [status]) VALUES (3, N'Cesped Natural', CAST(1000.00 AS Decimal(10, 2)), 1)
INSERT [dbo].[Canchas] ([id_cancha], [tipo_cancha], [costo], [status]) VALUES (4, N'Concreto', CAST(500.00 AS Decimal(10, 2)), 1)
SET IDENTITY_INSERT [dbo].[Canchas] OFF
INSERT [dbo].[Clientes] ([rfc], [nombre], [telefono], [status]) VALUES (N'GACD950716H0', N'DIEGO SAIT GRANDE CAMACHO', N'476-123-4455', 1)
INSERT [dbo].[Clientes] ([rfc], [nombre], [telefono], [status]) VALUES (N'JIIJIJ', N'IJIJIJJ', N'898-989-8989', 1)
INSERT [dbo].[Clientes] ([rfc], [nombre], [telefono], [status]) VALUES (N'JIJIJ8877', N'SHJSHSJH', N'444-411-1111', 1)
INSERT [dbo].[Clientes] ([rfc], [nombre], [telefono], [status]) VALUES (N'JIJIJJIIJI', N'IJIJIJJ', N'878-787-8777', 1)
INSERT [dbo].[Clientes] ([rfc], [nombre], [telefono], [status]) VALUES (N'JISA231122', N'JIRAG LOPEZ', N'476-123-4567', 1)
INSERT [dbo].[Clientes] ([rfc], [nombre], [telefono], [status]) VALUES (N'SASS88877', N'SAASS', N'476-123-4567', 1)
INSERT [dbo].[Clientes] ([rfc], [nombre], [telefono], [status]) VALUES (N'SSS88', N'SSSA', N'444-444-4444', 1)
INSERT [dbo].[Clientes] ([rfc], [nombre], [telefono], [status]) VALUES (N'XOXO001231', N'CLIENTE EJEMPLO', N'476-131-12-31', 1)
SET IDENTITY_INSERT [dbo].[Reservaciones] ON 

INSERT [dbo].[Reservaciones] ([id_reservacion], [id_cancha], [entrada], [salida], [arbitro], [total], [rfc], [estado_reservacion]) VALUES (1, 1, CAST(N'2018-09-03T08:00:00.000' AS DateTime), CAST(N'2018-09-03T12:00:00.000' AS DateTime), 0, CAST(1600.00 AS Decimal(12, 2)), N'JIJIJJIIJI', N'E')
INSERT [dbo].[Reservaciones] ([id_reservacion], [id_cancha], [entrada], [salida], [arbitro], [total], [rfc], [estado_reservacion]) VALUES (2, 1, CAST(N'2018-09-03T08:00:00.000' AS DateTime), CAST(N'2018-09-03T11:00:00.000' AS DateTime), 1, CAST(1800.00 AS Decimal(12, 2)), N'JIJIJ8877', N'E')
INSERT [dbo].[Reservaciones] ([id_reservacion], [id_cancha], [entrada], [salida], [arbitro], [total], [rfc], [estado_reservacion]) VALUES (3, 4, CAST(N'2018-09-03T08:00:00.000' AS DateTime), CAST(N'2018-09-03T10:00:00.000' AS DateTime), 0, CAST(1000.00 AS Decimal(12, 2)), N'JIJIJ8877', N'E')
SET IDENTITY_INSERT [dbo].[Reservaciones] OFF
ALTER TABLE [dbo].[Reservaciones]  WITH CHECK ADD  CONSTRAINT [FK_Reservaciones_Canchas] FOREIGN KEY([id_cancha])
REFERENCES [dbo].[Canchas] ([id_cancha])
GO
ALTER TABLE [dbo].[Reservaciones] CHECK CONSTRAINT [FK_Reservaciones_Canchas]
GO
ALTER TABLE [dbo].[Reservaciones]  WITH CHECK ADD  CONSTRAINT [FK_Reservaciones_Clientes] FOREIGN KEY([rfc])
REFERENCES [dbo].[Clientes] ([rfc])
GO
ALTER TABLE [dbo].[Reservaciones] CHECK CONSTRAINT [FK_Reservaciones_Clientes]
GO
/****** Object:  StoredProcedure [dbo].[stp_canchas_getall]    Script Date: 03/09/2018 06:32:06 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[stp_canchas_getall] 
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT id_cancha, tipo_cancha, costo from Canchas where status=1
END
GO
/****** Object:  StoredProcedure [dbo].[stp_clientes_add]    Script Date: 03/09/2018 06:32:06 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[stp_clientes_add]
	@rfc nvarchar(13),
	@nombre nvarchar(150),
	@telefono nvarchar(15)
AS
BEGIN
	INSERT INTO [dbo].[Clientes]
			   ([rfc]
			   ,[nombre]
			   ,[telefono]
			   ,[status])
		 VALUES
			   (@rfc
			   ,@nombre
			   ,@telefono
			   ,1)

END
GO
/****** Object:  StoredProcedure [dbo].[stp_clientes_get_rfc]    Script Date: 03/09/2018 06:32:06 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[stp_clientes_get_rfc]
AS
BEGIN
	SET NOCOUNT ON;
	SELECT [rfc]
		  ,[nombre]
		  ,[telefono]
		  ,[status]
	  FROM [dbo].[Clientes];
END
GO
/****** Object:  StoredProcedure [dbo].[stp_clientes_getall]    Script Date: 03/09/2018 06:32:06 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[stp_clientes_getall]
AS
BEGIN
	SET NOCOUNT ON;
	SELECT [rfc]
		  ,[nombre]
		  ,[telefono]
		  ,[status]
	  FROM [dbo].[Clientes]
	  where status=1;
END
GO
/****** Object:  StoredProcedure [dbo].[stp_reservaciones_add]    Script Date: 03/09/2018 06:32:06 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[stp_reservaciones_add]
	@rfc nvarchar(13),
	@id_cancha int,
	@entrada datetime,
	@salida datetime,
	@arbitro bit,
	@total decimal(12,2)
AS
BEGIN
	INSERT INTO [dbo].[Reservaciones]
			   ([id_cancha]
			   ,[entrada]
			   ,[salida]
			   ,[arbitro]
			   ,[total]
			   ,[rfc]
			   ,[estado_reservacion])
		 VALUES
			   (@id_cancha
			   ,@entrada
			   ,@salida
			   ,@arbitro
			   ,@total
			   ,@rfc
			   ,'E');
END
GO
/****** Object:  StoredProcedure [dbo].[stp_reservaciones_changestatus]    Script Date: 03/09/2018 06:32:06 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[stp_reservaciones_changestatus]
	@id_reservacion int,
	@estado_reservacion nchar(1)
AS
BEGIN
	UPDATE [dbo].[Reservaciones]
	   SET [estado_reservacion] = @estado_reservacion
	 WHERE id_reservacion=@id_reservacion and estado_reservacion='E'
END
GO
/****** Object:  StoredProcedure [dbo].[stp_reservaciones_get_activas]    Script Date: 03/09/2018 06:32:06 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[stp_reservaciones_get_activas]
AS
BEGIN
	SET NOCOUNT ON;
	SELECT [id_reservacion]
		  ,Reservaciones.id_cancha
		  ,Canchas.tipo_cancha
		  ,convert(date, entrada) as fecha_reservacion
		  ,DATEDIFF(hour, entrada, salida) as horas_rentada
		  ,[rfc]
		  ,[total]
	  FROM [dbo].[Reservaciones] inner join Canchas
		on Reservaciones.id_cancha=Canchas.id_cancha
	  WHERE estado_reservacion='A'
END
GO
/****** Object:  StoredProcedure [dbo].[stp_reservaciones_get_all]    Script Date: 03/09/2018 06:32:06 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[stp_reservaciones_get_all]
AS
BEGIN
	SET NOCOUNT ON;
	SELECT [id_reservacion]
		  ,Reservaciones.id_cancha
		  ,Canchas.tipo_cancha
		  ,entrada
		  ,salida
	  FROM [dbo].[Reservaciones] inner join Canchas
		on Reservaciones.id_cancha=Canchas.id_cancha
	  WHERE (estado_reservacion='A') or (estado_reservacion='E')
END
GO
/****** Object:  StoredProcedure [dbo].[stp_reservaciones_get_espera]    Script Date: 03/09/2018 06:32:06 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[stp_reservaciones_get_espera]
AS
BEGIN
	SET NOCOUNT ON;
	SELECT [id_reservacion]
		  ,[id_cancha]
		  ,[entrada]
		  ,[salida]
		  ,[arbitro]
		  ,[total]
		  ,[rfc]
		  ,[estado_reservacion]
	  FROM [dbo].[Reservaciones]
	  WHERE estado_reservacion='E'
END
GO
USE [master]
GO
ALTER DATABASE [ClubDeportivo] SET  READ_WRITE 
GO
