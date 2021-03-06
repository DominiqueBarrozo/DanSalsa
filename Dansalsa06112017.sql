USE [master]
GO
/****** Object:  Database [DanSalsa]    Script Date: 06/11/2017 22:56:15 ******/
CREATE DATABASE [DanSalsa]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DanSalsa', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\DanSalsa.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'DanSalsa_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\DanSalsa_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [DanSalsa] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DanSalsa].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DanSalsa] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DanSalsa] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DanSalsa] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DanSalsa] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DanSalsa] SET ARITHABORT OFF 
GO
ALTER DATABASE [DanSalsa] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DanSalsa] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [DanSalsa] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DanSalsa] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DanSalsa] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DanSalsa] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DanSalsa] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DanSalsa] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DanSalsa] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DanSalsa] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DanSalsa] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DanSalsa] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DanSalsa] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DanSalsa] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DanSalsa] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DanSalsa] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DanSalsa] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DanSalsa] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DanSalsa] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [DanSalsa] SET  MULTI_USER 
GO
ALTER DATABASE [DanSalsa] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DanSalsa] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DanSalsa] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DanSalsa] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [DanSalsa]
GO
/****** Object:  Table [dbo].[Alumnos]    Script Date: 06/11/2017 22:56:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Alumnos](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[apellido] [varchar](50) NOT NULL,
	[tipoDoc] [varchar](10) NULL,
	[nroDoc] [bigint] NULL,
	[telefono] [int] NULL,
	[calle] [varchar](100) NULL,
	[numero] [int] NULL,
	[fechaNac] [datetime2](7) NULL,
	[activo] [smallint] NOT NULL,
	[sexo] [smallint] NULL,
 CONSTRAINT [PK_Alumnos] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Asistencia]    Script Date: 06/11/2017 22:56:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Asistencia](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idAlumno] [int] NOT NULL,
	[idClase] [int] NOT NULL,
	[fecha] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Asistencia] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Clase]    Script Date: 06/11/2017 22:56:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Clase](
	[id] [int] NOT NULL,
	[idProfesor] [int] NOT NULL,
	[idRitmo] [int] NOT NULL,
	[descripcion] [varchar](300) NOT NULL,
	[nombre] [varchar](100) NOT NULL,
	[monto] [money] NOT NULL,
 CONSTRAINT [PK_Clase] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Cobro]    Script Date: 06/11/2017 22:56:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cobro](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[fecha] [datetime2](7) NOT NULL,
	[idClase] [int] NOT NULL,
	[monto] [money] NOT NULL,
	[pagado] [money] NOT NULL,
 CONSTRAINT [PK_Cobro] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Inscripciones]    Script Date: 06/11/2017 22:56:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Inscripciones](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[fecha] [datetime2](7) NOT NULL,
	[idClase] [int] NOT NULL,
	[idAlumno] [int] NOT NULL,
	[activo] [smallint] NOT NULL,
 CONSTRAINT [PK_Inscripciones] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Profesor]    Script Date: 06/11/2017 22:56:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Profesor](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[apellido] [varchar](50) NOT NULL,
	[tipoDoc] [varchar](50) NULL,
	[nroDoc] [int] NULL,
	[telefono] [int] NOT NULL,
	[sexo] [smallint] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ProfesoresXRitmo]    Script Date: 06/11/2017 22:56:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProfesoresXRitmo](
	[idProfe] [int] NOT NULL,
	[idRitmo] [int] NOT NULL,
 CONSTRAINT [PK_ProfesoresXRitmo] PRIMARY KEY CLUSTERED 
(
	[idProfe] ASC,
	[idRitmo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Ritmo]    Script Date: 06/11/2017 22:56:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Ritmo](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](20) NOT NULL,
 CONSTRAINT [PK_Ritmo] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 06/11/2017 22:56:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Usuarios](
	[nombre] [varchar](50) NOT NULL,
	[apellido] [varchar](50) NOT NULL,
	[activo] [smallint] NULL,
	[id] [int] NOT NULL,
	[login] [varchar](20) NOT NULL,
	[password] [varchar](20) NOT NULL,
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[Clase]  WITH CHECK ADD  CONSTRAINT [FK_Clase_Ritmo] FOREIGN KEY([idRitmo])
REFERENCES [dbo].[Ritmo] ([id])
GO
ALTER TABLE [dbo].[Clase] CHECK CONSTRAINT [FK_Clase_Ritmo]
GO
ALTER TABLE [dbo].[Cobro]  WITH CHECK ADD  CONSTRAINT [FK_Cobro_Clase] FOREIGN KEY([idClase])
REFERENCES [dbo].[Clase] ([id])
GO
ALTER TABLE [dbo].[Cobro] CHECK CONSTRAINT [FK_Cobro_Clase]
GO
ALTER TABLE [dbo].[Inscripciones]  WITH CHECK ADD  CONSTRAINT [FK_Inscripciones_Alumnos] FOREIGN KEY([idAlumno])
REFERENCES [dbo].[Alumnos] ([id])
GO
ALTER TABLE [dbo].[Inscripciones] CHECK CONSTRAINT [FK_Inscripciones_Alumnos]
GO
ALTER TABLE [dbo].[Inscripciones]  WITH CHECK ADD  CONSTRAINT [FK_Inscripciones_Clase] FOREIGN KEY([idClase])
REFERENCES [dbo].[Clase] ([id])
GO
ALTER TABLE [dbo].[Inscripciones] CHECK CONSTRAINT [FK_Inscripciones_Clase]
GO
ALTER TABLE [dbo].[ProfesoresXRitmo]  WITH CHECK ADD  CONSTRAINT [FK_ProfesoresXRitmo_Ritmo] FOREIGN KEY([idRitmo])
REFERENCES [dbo].[Ritmo] ([id])
GO
ALTER TABLE [dbo].[ProfesoresXRitmo] CHECK CONSTRAINT [FK_ProfesoresXRitmo_Ritmo]
GO
USE [master]
GO
ALTER DATABASE [DanSalsa] SET  READ_WRITE 
GO
