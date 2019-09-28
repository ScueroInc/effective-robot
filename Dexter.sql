USE [FinApp]
GO
/****** Object:  Table [dbo].[Categoria_Deuda]    Script Date: 9/28/2019 1:15:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Categoria_Deuda](
	[IDCategoriaDeuda] [varchar](10) NOT NULL,
	[NCategoriaDeuda] [nvarchar](50) NOT NULL,
 CONSTRAINT [Categoria_Deuda_pk] PRIMARY KEY CLUSTERED 
(
	[IDCategoriaDeuda] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Categoria_Gasto]    Script Date: 9/28/2019 1:15:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Categoria_Gasto](
	[IDCategoria_Gasto] [varchar](10) NOT NULL,
	[NCategoria_Gasto] [nvarchar](50) NOT NULL,
 CONSTRAINT [Categoria_Gasto_pk] PRIMARY KEY CLUSTERED 
(
	[IDCategoria_Gasto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Categoria_Ingreso]    Script Date: 9/28/2019 1:15:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Categoria_Ingreso](
	[IDCategoria_Ingreso] [varchar](10) NOT NULL,
	[NCategoria_Ingreso] [nvarchar](50) NOT NULL,
 CONSTRAINT [Categoria_Ingreso_pk] PRIMARY KEY CLUSTERED 
(
	[IDCategoria_Ingreso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DetalleReporte]    Script Date: 9/28/2019 1:15:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DetalleReporte](
	[IDTransaccion] [varchar](10) NOT NULL,
	[IDReporte] [varchar](10) NOT NULL,
 CONSTRAINT [DetalleReporte_pk] PRIMARY KEY CLUSTERED 
(
	[IDTransaccion] ASC,
	[IDReporte] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Deuda]    Script Date: 9/28/2019 1:15:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Deuda](
	[IDDeuda] [varchar](10) NULL,
	[NDeuda] [nvarchar](50) NULL,
	[FechaInicioDeuda] [date] NULL,
	[FechaFinDeuda] [date] NULL,
	[TDescripcion] [text] NULL,
	[Porcentaje] [float] NULL,
	[MontoDeuda] [money] NULL,
	[IDDivisa] [varchar](10) NULL,
	[IDCategoriaDeuda] [varchar](10) NULL,
	[IDEntidad] [varchar](10) NULL,
	[IDUsuario] [varchar](10) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Divisa]    Script Date: 9/28/2019 1:15:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Divisa](
	[IDDivisa] [varchar](10) NOT NULL,
	[NDivisa] [nvarchar](25) NOT NULL,
 CONSTRAINT [Divisa_pk] PRIMARY KEY CLUSTERED 
(
	[IDDivisa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Entidad]    Script Date: 9/28/2019 1:15:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Entidad](
	[IDEntidad] [varchar](10) NOT NULL,
	[NEntidad] [nvarchar](50) NOT NULL,
	[IDEntidad_Tipo] [varchar](10) NOT NULL,
 CONSTRAINT [Entidad_pk] PRIMARY KEY CLUSTERED 
(
	[IDEntidad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Entidad_Tipo]    Script Date: 9/28/2019 1:15:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Entidad_Tipo](
	[IDEntidad_Tipo] [varchar](10) NOT NULL,
	[NEntida_Tipo] [nvarchar](50) NOT NULL,
 CONSTRAINT [Entidad_Tipo_pk] PRIMARY KEY CLUSTERED 
(
	[IDEntidad_Tipo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Frecuencia]    Script Date: 9/28/2019 1:15:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Frecuencia](
	[IdFrecuencia] [varchar](10) NOT NULL,
	[NFrecuencia] [varchar](50) NOT NULL,
 CONSTRAINT [Frecuencia_pk] PRIMARY KEY CLUSTERED 
(
	[IdFrecuencia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Gasto]    Script Date: 9/28/2019 1:15:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Gasto](
	[Id_Gasto] [varchar](10) NOT NULL,
	[IDCategoria_Gasto] [varchar](10) NOT NULL,
 CONSTRAINT [Gasto_pk] PRIMARY KEY CLUSTERED 
(
	[Id_Gasto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Ingreso]    Script Date: 9/28/2019 1:15:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Ingreso](
	[Id_Ingreso] [varchar](10) NOT NULL,
	[IDCategoria_Ingreso] [varchar](10) NOT NULL,
 CONSTRAINT [Ingreso_pk] PRIMARY KEY CLUSTERED 
(
	[Id_Ingreso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Mes]    Script Date: 9/28/2019 1:15:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Mes](
	[IDMes] [varchar](10) NOT NULL,
	[NMes] [nvarchar](15) NOT NULL,
 CONSTRAINT [Mes_pk] PRIMARY KEY CLUSTERED 
(
	[IDMes] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Reporte]    Script Date: 9/28/2019 1:15:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Reporte](
	[IDReporte] [varchar](10) NOT NULL,
	[FechaReporte] [date] NOT NULL,
	[FechaInicio] [date] NOT NULL,
	[FechaTermino] [date] NOT NULL,
 CONSTRAINT [Reporte_pk] PRIMARY KEY CLUSTERED 
(
	[IDReporte] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TipoCuenta]    Script Date: 9/28/2019 1:15:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TipoCuenta](
	[IDTipoCuenta] [varchar](10) NOT NULL,
	[NTipoCuenta] [nvarchar](25) NOT NULL,
	[MontoTipoCuenta] [money] NOT NULL,
	[TiempoCuenta] [int] NOT NULL,
 CONSTRAINT [TipoCuenta_pk] PRIMARY KEY CLUSTERED 
(
	[IDTipoCuenta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Transaccion]    Script Date: 9/28/2019 1:15:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Transaccion](
	[IDTransaccion] [varchar](10) NOT NULL,
	[NTransaccion] [varchar](50) NOT NULL,
	[MontoTransaccion] [money] NOT NULL,
	[FechaTransaccion] [datetime] NOT NULL,
	[IDDivisa] [varchar](10) NOT NULL,
	[IDMes] [varchar](10) NOT NULL,
	[IDUsuario] [varchar](10) NOT NULL,
	[IdFrecuencia] [varchar](10) NOT NULL,
 CONSTRAINT [Transaccion_pk] PRIMARY KEY CLUSTERED 
(
	[IDTransaccion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 9/28/2019 1:15:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Usuario](
	[Nombre] [varchar](50) NOT NULL,
	[Apellidos] [varchar](100) NULL,
	[Email] [nvarchar](50) NOT NULL,
	[Nickname] [varchar](25) NULL,
	[Password] [varchar](20) NOT NULL,
	[Celular] [varchar](12) NOT NULL,
	[DTipoCuenta] [varchar](10) NOT NULL,
	[IDUsuario] [varchar](10) NOT NULL,
 CONSTRAINT [Usuario_pk] PRIMARY KEY CLUSTERED 
(
	[IDUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[DetalleReporte]  WITH CHECK ADD  CONSTRAINT [FK_DetalleReporte_Reporte] FOREIGN KEY([IDReporte])
REFERENCES [dbo].[Reporte] ([IDReporte])
GO
ALTER TABLE [dbo].[DetalleReporte] CHECK CONSTRAINT [FK_DetalleReporte_Reporte]
GO
ALTER TABLE [dbo].[DetalleReporte]  WITH CHECK ADD  CONSTRAINT [FK_DetalleReporte_Transaccion] FOREIGN KEY([IDTransaccion])
REFERENCES [dbo].[Transaccion] ([IDTransaccion])
GO
ALTER TABLE [dbo].[DetalleReporte] CHECK CONSTRAINT [FK_DetalleReporte_Transaccion]
GO
ALTER TABLE [dbo].[Deuda]  WITH CHECK ADD  CONSTRAINT [FK_Deuda_Categoria_Deuda] FOREIGN KEY([IDCategoriaDeuda])
REFERENCES [dbo].[Categoria_Deuda] ([IDCategoriaDeuda])
GO
ALTER TABLE [dbo].[Deuda] CHECK CONSTRAINT [FK_Deuda_Categoria_Deuda]
GO
ALTER TABLE [dbo].[Deuda]  WITH CHECK ADD  CONSTRAINT [FK_Deuda_Divisa] FOREIGN KEY([IDDivisa])
REFERENCES [dbo].[Divisa] ([IDDivisa])
GO
ALTER TABLE [dbo].[Deuda] CHECK CONSTRAINT [FK_Deuda_Divisa]
GO
ALTER TABLE [dbo].[Deuda]  WITH CHECK ADD  CONSTRAINT [FK_Deuda_Entidad] FOREIGN KEY([IDEntidad])
REFERENCES [dbo].[Entidad] ([IDEntidad])
GO
ALTER TABLE [dbo].[Deuda] CHECK CONSTRAINT [FK_Deuda_Entidad]
GO
ALTER TABLE [dbo].[Deuda]  WITH CHECK ADD  CONSTRAINT [FK_Deuda_Usuario] FOREIGN KEY([IDUsuario])
REFERENCES [dbo].[Usuario] ([IDUsuario])
GO
ALTER TABLE [dbo].[Deuda] CHECK CONSTRAINT [FK_Deuda_Usuario]
GO
ALTER TABLE [dbo].[Entidad]  WITH CHECK ADD  CONSTRAINT [FK_Entidad_Entidad_Tipo] FOREIGN KEY([IDEntidad_Tipo])
REFERENCES [dbo].[Entidad_Tipo] ([IDEntidad_Tipo])
GO
ALTER TABLE [dbo].[Entidad] CHECK CONSTRAINT [FK_Entidad_Entidad_Tipo]
GO
ALTER TABLE [dbo].[Gasto]  WITH CHECK ADD  CONSTRAINT [FK_Gasto_Categoria_Gasto] FOREIGN KEY([IDCategoria_Gasto])
REFERENCES [dbo].[Categoria_Gasto] ([IDCategoria_Gasto])
GO
ALTER TABLE [dbo].[Gasto] CHECK CONSTRAINT [FK_Gasto_Categoria_Gasto]
GO
ALTER TABLE [dbo].[Gasto]  WITH CHECK ADD  CONSTRAINT [FK_Gasto_Transaccion] FOREIGN KEY([Id_Gasto])
REFERENCES [dbo].[Transaccion] ([IDTransaccion])
GO
ALTER TABLE [dbo].[Gasto] CHECK CONSTRAINT [FK_Gasto_Transaccion]
GO
ALTER TABLE [dbo].[Ingreso]  WITH CHECK ADD  CONSTRAINT [FK_Ingreso_Categoria_Ingreso] FOREIGN KEY([IDCategoria_Ingreso])
REFERENCES [dbo].[Categoria_Ingreso] ([IDCategoria_Ingreso])
GO
ALTER TABLE [dbo].[Ingreso] CHECK CONSTRAINT [FK_Ingreso_Categoria_Ingreso]
GO
ALTER TABLE [dbo].[Ingreso]  WITH CHECK ADD  CONSTRAINT [FK_Ingreso_Transaccion] FOREIGN KEY([Id_Ingreso])
REFERENCES [dbo].[Transaccion] ([IDTransaccion])
GO
ALTER TABLE [dbo].[Ingreso] CHECK CONSTRAINT [FK_Ingreso_Transaccion]
GO
ALTER TABLE [dbo].[Transaccion]  WITH CHECK ADD  CONSTRAINT [FK_Transaccion_Divisa] FOREIGN KEY([IDDivisa])
REFERENCES [dbo].[Divisa] ([IDDivisa])
GO
ALTER TABLE [dbo].[Transaccion] CHECK CONSTRAINT [FK_Transaccion_Divisa]
GO
ALTER TABLE [dbo].[Transaccion]  WITH CHECK ADD  CONSTRAINT [FK_Transaccion_Frecuencia] FOREIGN KEY([IdFrecuencia])
REFERENCES [dbo].[Frecuencia] ([IdFrecuencia])
GO
ALTER TABLE [dbo].[Transaccion] CHECK CONSTRAINT [FK_Transaccion_Frecuencia]
GO
ALTER TABLE [dbo].[Transaccion]  WITH CHECK ADD  CONSTRAINT [FK_Transaccion_Mes] FOREIGN KEY([IDMes])
REFERENCES [dbo].[Mes] ([IDMes])
GO
ALTER TABLE [dbo].[Transaccion] CHECK CONSTRAINT [FK_Transaccion_Mes]
GO
ALTER TABLE [dbo].[Transaccion]  WITH CHECK ADD  CONSTRAINT [FK_Transaccion_Usuario] FOREIGN KEY([IDUsuario])
REFERENCES [dbo].[Usuario] ([IDUsuario])
GO
ALTER TABLE [dbo].[Transaccion] CHECK CONSTRAINT [FK_Transaccion_Usuario]
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_TipoCuenta] FOREIGN KEY([DTipoCuenta])
REFERENCES [dbo].[TipoCuenta] ([IDTipoCuenta])
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [FK_Usuario_TipoCuenta]
GO
