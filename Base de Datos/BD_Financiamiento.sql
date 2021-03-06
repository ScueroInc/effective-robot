USE [master]
GO
/****** Object:  Database [TPWeb]    Script Date: 10/8/2019 5:12:52 PM ******/
CREATE DATABASE [TPWeb]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TPWeb', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.BEKA\MSSQL\DATA\TPWeb.mdf' , SIZE = 4288KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'TPWeb_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.BEKA\MSSQL\DATA\TPWeb_log.ldf' , SIZE = 1072KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [TPWeb] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TPWeb].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TPWeb] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TPWeb] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TPWeb] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TPWeb] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TPWeb] SET ARITHABORT OFF 
GO
ALTER DATABASE [TPWeb] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [TPWeb] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TPWeb] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TPWeb] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TPWeb] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TPWeb] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TPWeb] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TPWeb] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TPWeb] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TPWeb] SET  ENABLE_BROKER 
GO
ALTER DATABASE [TPWeb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TPWeb] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TPWeb] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TPWeb] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TPWeb] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TPWeb] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TPWeb] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TPWeb] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [TPWeb] SET  MULTI_USER 
GO
ALTER DATABASE [TPWeb] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TPWeb] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TPWeb] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TPWeb] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [TPWeb] SET DELAYED_DURABILITY = DISABLED 
GO
USE [TPWeb]
GO
/****** Object:  Table [dbo].[Categoria_Deuda]    Script Date: 10/8/2019 5:12:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categoria_Deuda](
	[IDCategoria_Deuda] [int] IDENTITY(1,1) NOT NULL,
	[NCategoria_Deuda] [nvarchar](50) NOT NULL,
 CONSTRAINT [Categoria_Deuda_pk] PRIMARY KEY CLUSTERED 
(
	[IDCategoria_Deuda] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Categoria_Gasto]    Script Date: 10/8/2019 5:12:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categoria_Gasto](
	[IDCategoria_Gasto] [int] IDENTITY(1,1) NOT NULL,
	[NCategoria_Gasto] [nvarchar](50) NOT NULL,
 CONSTRAINT [Categoria_Gasto_pk] PRIMARY KEY CLUSTERED 
(
	[IDCategoria_Gasto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Categoria_Ingreso]    Script Date: 10/8/2019 5:12:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categoria_Ingreso](
	[IDCategoria_Ingreso] [int] IDENTITY(1,1) NOT NULL,
	[NCategoria_Ingreso] [nvarchar](50) NOT NULL,
 CONSTRAINT [Categoria_Ingreso_pk] PRIMARY KEY CLUSTERED 
(
	[IDCategoria_Ingreso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DetallerReporte]    Script Date: 10/8/2019 5:12:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetallerReporte](
	[IDTransaccion] [int] NOT NULL,
	[IDReporte] [int] NOT NULL,
 CONSTRAINT [DetallerReporte_pk] PRIMARY KEY CLUSTERED 
(
	[IDTransaccion] ASC,
	[IDReporte] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Deuda]    Script Date: 10/8/2019 5:12:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Deuda](
	[IDDeuda] [int] IDENTITY(1,1) NOT NULL,
	[NDeuda] [nvarchar](50) NOT NULL,
	[FechaInicioDeuda] [date] NOT NULL,
	[FechaFinDeuda] [date] NOT NULL,
	[TDescripcion] [text] NOT NULL,
	[Interes] [real] NULL,
	[MontoDeuda] [money] NOT NULL,
	[IDDivisa] [int] NOT NULL,
	[IDCategoria_Deuda] [int] NOT NULL,
	[IDEntidad] [int] NOT NULL,
	[IDUsuario] [int] NOT NULL,
 CONSTRAINT [Deuda_pk] PRIMARY KEY CLUSTERED 
(
	[IDDeuda] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Divisa]    Script Date: 10/8/2019 5:12:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Divisa](
	[IDDivisa] [int] IDENTITY(1,1) NOT NULL,
	[NDivisa] [nvarchar](25) NOT NULL,
 CONSTRAINT [Divisa_pk] PRIMARY KEY CLUSTERED 
(
	[IDDivisa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Entidad]    Script Date: 10/8/2019 5:12:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Entidad](
	[IDEntidad] [int] IDENTITY(1,1) NOT NULL,
	[NEntidad] [nvarchar](50) NOT NULL,
	[IDEntidad_Tipo] [int] NOT NULL,
 CONSTRAINT [Entidad_pk] PRIMARY KEY CLUSTERED 
(
	[IDEntidad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Entidad_Tipo]    Script Date: 10/8/2019 5:12:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Entidad_Tipo](
	[IDEntidad_Tipo] [int] IDENTITY(1,1) NOT NULL,
	[NEntida_Tipo] [nvarchar](50) NOT NULL,
 CONSTRAINT [Entidad_Tipo_pk] PRIMARY KEY CLUSTERED 
(
	[IDEntidad_Tipo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Frecuencia]    Script Date: 10/8/2019 5:12:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Frecuencia](
	[IDFrecuencia] [int] IDENTITY(1,1) NOT NULL,
	[NFrecuencia] [varchar](20) NOT NULL,
 CONSTRAINT [Frecuencia_pk] PRIMARY KEY CLUSTERED 
(
	[IDFrecuencia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Gasto]    Script Date: 10/8/2019 5:12:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Gasto](
	[IDGasto] [int] IDENTITY(1,1) NOT NULL,
	[IDCategoria_Gasto] [int] NOT NULL,
 CONSTRAINT [Gasto_pk] PRIMARY KEY CLUSTERED 
(
	[IDGasto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Ingreso]    Script Date: 10/8/2019 5:12:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ingreso](
	[IDIngreso] [int] IDENTITY(1,1) NOT NULL,
	[IDCategoria_Ingreso] [int] NOT NULL,
 CONSTRAINT [Ingreso_pk] PRIMARY KEY CLUSTERED 
(
	[IDIngreso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Mes]    Script Date: 10/8/2019 5:12:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mes](
	[IDMes] [int] IDENTITY(1,1) NOT NULL,
	[NMes] [nvarchar](15) NOT NULL,
 CONSTRAINT [Mes_pk] PRIMARY KEY CLUSTERED 
(
	[IDMes] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Reporte]    Script Date: 10/8/2019 5:12:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reporte](
	[FechaReporte] [date] NOT NULL,
	[FechaInicio] [date] NOT NULL,
	[FechaTermino] [date] NOT NULL,
	[IDReporte] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [Reporte_pk] PRIMARY KEY CLUSTERED 
(
	[IDReporte] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TipoCuenta]    Script Date: 10/8/2019 5:12:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoCuenta](
	[IDTipoCuenta] [int] IDENTITY(1,1) NOT NULL,
	[NTipoCuenta] [nvarchar](25) NOT NULL,
	[MTipoCuenta] [money] NOT NULL,
	[TiempoCuenta] [int] NOT NULL,
 CONSTRAINT [TipoCuenta_pk] PRIMARY KEY CLUSTERED 
(
	[IDTipoCuenta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Transaccion]    Script Date: 10/8/2019 5:12:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Transaccion](
	[IDTransaccion] [int] IDENTITY(1,1) NOT NULL,
	[NTransaccion] [varchar](50) NOT NULL,
	[MontoTransaccion] [money] NOT NULL,
	[FechaTransaccion] [datetime] NOT NULL,
	[IDDivisa] [int] NOT NULL,
	[IDMes] [int] NOT NULL,
	[IDUsuario] [int] NOT NULL,
	[IDFrecuencia] [int] NOT NULL,
 CONSTRAINT [Transaccion_pk] PRIMARY KEY CLUSTERED 
(
	[IDTransaccion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 10/8/2019 5:12:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Usuario](
	[IDUsuario] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Apellidos] [varchar](100) NULL,
	[Email] [varchar](50) NOT NULL,
	[Nickname] [varchar](25) NULL,
	[Password] [varchar](20) NOT NULL,
	[Celular] [varchar](12) NOT NULL,
	[IDTipoCuenta] [int] NOT NULL,
 CONSTRAINT [Usuario_pk] PRIMARY KEY CLUSTERED 
(
	[IDUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[DetallerReporte]  WITH CHECK ADD  CONSTRAINT [DetallerReporte_Reporte] FOREIGN KEY([IDReporte])
REFERENCES [dbo].[Reporte] ([IDReporte])
GO
ALTER TABLE [dbo].[DetallerReporte] CHECK CONSTRAINT [DetallerReporte_Reporte]
GO
ALTER TABLE [dbo].[DetallerReporte]  WITH CHECK ADD  CONSTRAINT [DetallerReporte_Transaccion] FOREIGN KEY([IDTransaccion])
REFERENCES [dbo].[Transaccion] ([IDTransaccion])
GO
ALTER TABLE [dbo].[DetallerReporte] CHECK CONSTRAINT [DetallerReporte_Transaccion]
GO
ALTER TABLE [dbo].[Deuda]  WITH CHECK ADD  CONSTRAINT [Deuda_Categoria_Deuda] FOREIGN KEY([IDCategoria_Deuda])
REFERENCES [dbo].[Categoria_Deuda] ([IDCategoria_Deuda])
GO
ALTER TABLE [dbo].[Deuda] CHECK CONSTRAINT [Deuda_Categoria_Deuda]
GO
ALTER TABLE [dbo].[Deuda]  WITH CHECK ADD  CONSTRAINT [Deuda_Divisa] FOREIGN KEY([IDDivisa])
REFERENCES [dbo].[Divisa] ([IDDivisa])
GO
ALTER TABLE [dbo].[Deuda] CHECK CONSTRAINT [Deuda_Divisa]
GO
ALTER TABLE [dbo].[Deuda]  WITH CHECK ADD  CONSTRAINT [Deuda_Entidad] FOREIGN KEY([IDEntidad])
REFERENCES [dbo].[Entidad] ([IDEntidad])
GO
ALTER TABLE [dbo].[Deuda] CHECK CONSTRAINT [Deuda_Entidad]
GO
ALTER TABLE [dbo].[Deuda]  WITH CHECK ADD  CONSTRAINT [Deuda_Usuario] FOREIGN KEY([IDUsuario])
REFERENCES [dbo].[Usuario] ([IDUsuario])
GO
ALTER TABLE [dbo].[Deuda] CHECK CONSTRAINT [Deuda_Usuario]
GO
ALTER TABLE [dbo].[Entidad]  WITH CHECK ADD  CONSTRAINT [Entidad_Entidad_Tipo] FOREIGN KEY([IDEntidad_Tipo])
REFERENCES [dbo].[Entidad_Tipo] ([IDEntidad_Tipo])
GO
ALTER TABLE [dbo].[Entidad] CHECK CONSTRAINT [Entidad_Entidad_Tipo]
GO
ALTER TABLE [dbo].[Gasto]  WITH CHECK ADD  CONSTRAINT [Gasto_Categoria_Gasto] FOREIGN KEY([IDCategoria_Gasto])
REFERENCES [dbo].[Categoria_Gasto] ([IDCategoria_Gasto])
GO
ALTER TABLE [dbo].[Gasto] CHECK CONSTRAINT [Gasto_Categoria_Gasto]
GO
ALTER TABLE [dbo].[Gasto]  WITH CHECK ADD  CONSTRAINT [Gasto_Transaccion] FOREIGN KEY([IDGasto])
REFERENCES [dbo].[Transaccion] ([IDTransaccion])
GO
ALTER TABLE [dbo].[Gasto] CHECK CONSTRAINT [Gasto_Transaccion]
GO
ALTER TABLE [dbo].[Ingreso]  WITH CHECK ADD  CONSTRAINT [Ingreso_Categoria_Ingreso] FOREIGN KEY([IDCategoria_Ingreso])
REFERENCES [dbo].[Categoria_Ingreso] ([IDCategoria_Ingreso])
GO
ALTER TABLE [dbo].[Ingreso] CHECK CONSTRAINT [Ingreso_Categoria_Ingreso]
GO
ALTER TABLE [dbo].[Ingreso]  WITH CHECK ADD  CONSTRAINT [Ingreso_Transaccion] FOREIGN KEY([IDIngreso])
REFERENCES [dbo].[Transaccion] ([IDTransaccion])
GO
ALTER TABLE [dbo].[Ingreso] CHECK CONSTRAINT [Ingreso_Transaccion]
GO
ALTER TABLE [dbo].[Transaccion]  WITH CHECK ADD  CONSTRAINT [Transaccion_Divisa] FOREIGN KEY([IDDivisa])
REFERENCES [dbo].[Divisa] ([IDDivisa])
GO
ALTER TABLE [dbo].[Transaccion] CHECK CONSTRAINT [Transaccion_Divisa]
GO
ALTER TABLE [dbo].[Transaccion]  WITH CHECK ADD  CONSTRAINT [Transaccion_Frecuencia] FOREIGN KEY([IDFrecuencia])
REFERENCES [dbo].[Frecuencia] ([IDFrecuencia])
GO
ALTER TABLE [dbo].[Transaccion] CHECK CONSTRAINT [Transaccion_Frecuencia]
GO
ALTER TABLE [dbo].[Transaccion]  WITH CHECK ADD  CONSTRAINT [Transaccion_Mes] FOREIGN KEY([IDMes])
REFERENCES [dbo].[Mes] ([IDMes])
GO
ALTER TABLE [dbo].[Transaccion] CHECK CONSTRAINT [Transaccion_Mes]
GO
ALTER TABLE [dbo].[Transaccion]  WITH CHECK ADD  CONSTRAINT [Transaccion_Usuario] FOREIGN KEY([IDUsuario])
REFERENCES [dbo].[Usuario] ([IDUsuario])
GO
ALTER TABLE [dbo].[Transaccion] CHECK CONSTRAINT [Transaccion_Usuario]
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [Usuario_TipoCuenta] FOREIGN KEY([IDTipoCuenta])
REFERENCES [dbo].[TipoCuenta] ([IDTipoCuenta])
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [Usuario_TipoCuenta]
GO
USE [master]
GO
ALTER DATABASE [TPWeb] SET  READ_WRITE 
GO
