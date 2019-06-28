USE [BARRACHINA_DB]
GO
/****** Object:  Table [dbo].[Ventas]    Script Date: 06/28/2019 18:26:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Ventas](
	[NumeroVenta] [int] IDENTITY(1,1) NOT NULL,
	[Usuario] [int] NULL,
	[Cliente] [int] NULL,
	[Fecha] [varchar](50) NULL,
	[Total] [decimal](18, 2) NULL,
	[MetodoPago] [varchar](50) NULL,
 CONSTRAINT [PK_Ventas] PRIMARY KEY CLUSTERED 
(
	[NumeroVenta] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Ventas] ON
INSERT [dbo].[Ventas] ([NumeroVenta], [Usuario], [Cliente], [Fecha], [Total], [MetodoPago]) VALUES (1, 1, 0, N'28/06/2019', CAST(245.00 AS Decimal(18, 2)), N'Efectivo')
INSERT [dbo].[Ventas] ([NumeroVenta], [Usuario], [Cliente], [Fecha], [Total], [MetodoPago]) VALUES (2, 1, 0, N'28/06/2019', CAST(495.00 AS Decimal(18, 2)), N'Efectivo')
INSERT [dbo].[Ventas] ([NumeroVenta], [Usuario], [Cliente], [Fecha], [Total], [MetodoPago]) VALUES (3, 1, 3, N'28/06/2019', CAST(225.00 AS Decimal(18, 2)), N'CtaCorriente')
SET IDENTITY_INSERT [dbo].[Ventas] OFF
/****** Object:  Table [dbo].[Usuarios]    Script Date: 06/28/2019 18:26:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Usuarios](
	[CodigoUsuario] [int] NOT NULL,
	[Nombre] [varchar](30) NOT NULL,
	[Sector] [varchar](50) NULL,
	[Contrasenia] [varchar](30) NOT NULL,
	[Estado] [bit] NULL,
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[CodigoUsuario] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Usuarios] ([CodigoUsuario], [Nombre], [Sector], [Contrasenia], [Estado]) VALUES (1, N'Alejandra', N'Administración', N'1234', 1)
INSERT [dbo].[Usuarios] ([CodigoUsuario], [Nombre], [Sector], [Contrasenia], [Estado]) VALUES (2, N'Federico', N'Compra', N'4321', 0)
INSERT [dbo].[Usuarios] ([CodigoUsuario], [Nombre], [Sector], [Contrasenia], [Estado]) VALUES (3, N'Drama', N'Compra', N'2222', 0)
INSERT [dbo].[Usuarios] ([CodigoUsuario], [Nombre], [Sector], [Contrasenia], [Estado]) VALUES (8, N'lalala', N'Administración', N'546546', 1)
INSERT [dbo].[Usuarios] ([CodigoUsuario], [Nombre], [Sector], [Contrasenia], [Estado]) VALUES (10, N'aaa', N'Ventas', N'bbb', 1)
INSERT [dbo].[Usuarios] ([CodigoUsuario], [Nombre], [Sector], [Contrasenia], [Estado]) VALUES (99, N'99', N'Compra', N'99', 0)
INSERT [dbo].[Usuarios] ([CodigoUsuario], [Nombre], [Sector], [Contrasenia], [Estado]) VALUES (45646, N'45646', N'Depósito', N'56465', 1)
/****** Object:  Table [dbo].[TipoProductos]    Script Date: 06/28/2019 18:26:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TipoProductos](
	[CodigoTipoProducto] [int] NOT NULL,
	[NombreTipoProducto] [varchar](30) NOT NULL,
	[Estado] [bit] NULL,
 CONSTRAINT [PK_TipoProductos] PRIMARY KEY CLUSTERED 
(
	[CodigoTipoProducto] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[TipoProductos] ([CodigoTipoProducto], [NombreTipoProducto], [Estado]) VALUES (1, N'Galletitas', 1)
INSERT [dbo].[TipoProductos] ([CodigoTipoProducto], [NombreTipoProducto], [Estado]) VALUES (2, N'Alfajores', 1)
INSERT [dbo].[TipoProductos] ([CodigoTipoProducto], [NombreTipoProducto], [Estado]) VALUES (3, N'Cigarrillos', 1)
INSERT [dbo].[TipoProductos] ([CodigoTipoProducto], [NombreTipoProducto], [Estado]) VALUES (4, N'Chicles', 1)
INSERT [dbo].[TipoProductos] ([CodigoTipoProducto], [NombreTipoProducto], [Estado]) VALUES (5, N'Caramelos', 1)
INSERT [dbo].[TipoProductos] ([CodigoTipoProducto], [NombreTipoProducto], [Estado]) VALUES (6, N'Chocolates', 1)
INSERT [dbo].[TipoProductos] ([CodigoTipoProducto], [NombreTipoProducto], [Estado]) VALUES (7, N'Carga Virtual', 1)
INSERT [dbo].[TipoProductos] ([CodigoTipoProducto], [NombreTipoProducto], [Estado]) VALUES (8, N'Bebidas s/alcohol', 1)
/****** Object:  Table [dbo].[Rubros]    Script Date: 06/28/2019 18:26:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Rubros](
	[CodigoRubro] [int] NOT NULL,
	[NombreRubro] [varchar](30) NOT NULL,
	[Estado] [bit] NULL,
 CONSTRAINT [PK_Rubros] PRIMARY KEY CLUSTERED 
(
	[CodigoRubro] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Rubros] ([CodigoRubro], [NombreRubro], [Estado]) VALUES (1, N'Kiosco', 1)
INSERT [dbo].[Rubros] ([CodigoRubro], [NombreRubro], [Estado]) VALUES (2, N'Almacen Comestible', 1)
INSERT [dbo].[Rubros] ([CodigoRubro], [NombreRubro], [Estado]) VALUES (3, N'Almacen Limpieza', 1)
INSERT [dbo].[Rubros] ([CodigoRubro], [NombreRubro], [Estado]) VALUES (4, N'Perfumeria', 1)
INSERT [dbo].[Rubros] ([CodigoRubro], [NombreRubro], [Estado]) VALUES (5, N'Locutorio', 1)
INSERT [dbo].[Rubros] ([CodigoRubro], [NombreRubro], [Estado]) VALUES (6, N'Cyber', 1)
INSERT [dbo].[Rubros] ([CodigoRubro], [NombreRubro], [Estado]) VALUES (7, N'Almacen', 1)
INSERT [dbo].[Rubros] ([CodigoRubro], [NombreRubro], [Estado]) VALUES (88, N'99', 0)
INSERT [dbo].[Rubros] ([CodigoRubro], [NombreRubro], [Estado]) VALUES (90, N'9000', 0)
/****** Object:  Table [dbo].[Direcciones]    Script Date: 06/28/2019 18:26:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Direcciones](
	[CodigoDireccion] [int] IDENTITY(1,1) NOT NULL,
	[Calle] [varchar](30) NOT NULL,
	[Numero] [int] NOT NULL,
	[CodigoPostal] [int] NOT NULL,
	[Localidad] [varchar](30) NOT NULL,
	[Provincia] [varchar](30) NOT NULL,
	[Estado] [bit] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Direcciones] ON
INSERT [dbo].[Direcciones] ([CodigoDireccion], [Calle], [Numero], [CodigoPostal], [Localidad], [Provincia], [Estado]) VALUES (1, N'2611890', 1890, 7607, N'Miramar', N'Buenos Aires', 1)
INSERT [dbo].[Direcciones] ([CodigoDireccion], [Calle], [Numero], [CodigoPostal], [Localidad], [Provincia], [Estado]) VALUES (2, N'40', 650, 7607, N'Miramar', N'Buenos Aires', 1)
INSERT [dbo].[Direcciones] ([CodigoDireccion], [Calle], [Numero], [CodigoPostal], [Localidad], [Provincia], [Estado]) VALUES (3, N'9 de Julio', 3048, 7600, N'Mar del Plata', N'Buenos Aires', 1)
INSERT [dbo].[Direcciones] ([CodigoDireccion], [Calle], [Numero], [CodigoPostal], [Localidad], [Provincia], [Estado]) VALUES (4, N'Ruta 2', 400, 7608, N'Mar del Plata', N'Buenos Aiers', 1)
INSERT [dbo].[Direcciones] ([CodigoDireccion], [Calle], [Numero], [CodigoPostal], [Localidad], [Provincia], [Estado]) VALUES (5, N'Av Colon ', 2851, 7600, N'Mar del Plata', N'Buenos Aires', 1)
INSERT [dbo].[Direcciones] ([CodigoDireccion], [Calle], [Numero], [CodigoPostal], [Localidad], [Provincia], [Estado]) VALUES (6, N'Av Colon', 555, 7600, N'Mar del Plata', N'Buenos Aires', 0)
INSERT [dbo].[Direcciones] ([CodigoDireccion], [Calle], [Numero], [CodigoPostal], [Localidad], [Provincia], [Estado]) VALUES (7, N'120', 689, 7607, N'Miramar', N'Buenos Aires', 1)
INSERT [dbo].[Direcciones] ([CodigoDireccion], [Calle], [Numero], [CodigoPostal], [Localidad], [Provincia], [Estado]) VALUES (8, N'Marquez', 2289, 7600, N'Mar del Plata', N'Buenos Aires', 1)
INSERT [dbo].[Direcciones] ([CodigoDireccion], [Calle], [Numero], [CodigoPostal], [Localidad], [Provincia], [Estado]) VALUES (9, N'111', 111, 11, N'11', N'11', 0)
INSERT [dbo].[Direcciones] ([CodigoDireccion], [Calle], [Numero], [CodigoPostal], [Localidad], [Provincia], [Estado]) VALUES (10, N'22', 222, 22, N'222', N'22', 0)
INSERT [dbo].[Direcciones] ([CodigoDireccion], [Calle], [Numero], [CodigoPostal], [Localidad], [Provincia], [Estado]) VALUES (11, N'33', 333, 33, N'333', N'333', 0)
INSERT [dbo].[Direcciones] ([CodigoDireccion], [Calle], [Numero], [CodigoPostal], [Localidad], [Provincia], [Estado]) VALUES (13, N'Av Salvador del Carill', 2281, 1898, N'Villa Urquiza', N'Buenos Aires', 1)
INSERT [dbo].[Direcciones] ([CodigoDireccion], [Calle], [Numero], [CodigoPostal], [Localidad], [Provincia], [Estado]) VALUES (15, N'29', 1516, 7607, N'Miramar', N'Buenos Aires', 1)
INSERT [dbo].[Direcciones] ([CodigoDireccion], [Calle], [Numero], [CodigoPostal], [Localidad], [Provincia], [Estado]) VALUES (16, N'11', 111, 1, N'11', N'11', 0)
INSERT [dbo].[Direcciones] ([CodigoDireccion], [Calle], [Numero], [CodigoPostal], [Localidad], [Provincia], [Estado]) VALUES (14, N'Maipu', 2045, 1646, N'San Fernando', N'Buenos Aires', 1)
INSERT [dbo].[Direcciones] ([CodigoDireccion], [Calle], [Numero], [CodigoPostal], [Localidad], [Provincia], [Estado]) VALUES (12, N'Guido115', 15, 1642, N'San Isidro', N'Buenos aires', 1)
SET IDENTITY_INSERT [dbo].[Direcciones] OFF
/****** Object:  Table [dbo].[DetalleVentas]    Script Date: 06/28/2019 18:26:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DetalleVentas](
	[NumeroFactura] [int] NOT NULL,
	[NumeroLinea] [int] NOT NULL,
	[CodigoProducto] [varchar](50) NULL,
	[Unidad] [int] NULL,
	[Bulto] [int] NULL,
	[PrecioCosto] [decimal](18, 2) NULL,
	[CantidadxBulto] [int] NULL,
	[PrecioVentaMinorista] [decimal](18, 2) NULL,
	[PrecioVentaMayorista] [decimal](18, 2) NULL,
 CONSTRAINT [PK_DetalleVenta] PRIMARY KEY CLUSTERED 
(
	[NumeroFactura] ASC,
	[NumeroLinea] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[DetalleVentas] ([NumeroFactura], [NumeroLinea], [CodigoProducto], [Unidad], [Bulto], [PrecioCosto], [CantidadxBulto], [PrecioVentaMinorista], [PrecioVentaMayorista]) VALUES (1, 1, N'1', 1, 0, CAST(99.22 AS Decimal(18, 2)), 10, CAST(125.00 AS Decimal(18, 2)), CAST(112.50 AS Decimal(18, 2)))
INSERT [dbo].[DetalleVentas] ([NumeroFactura], [NumeroLinea], [CodigoProducto], [Unidad], [Bulto], [PrecioCosto], [CantidadxBulto], [PrecioVentaMinorista], [PrecioVentaMayorista]) VALUES (1, 2, N'2', 1, 0, CAST(93.02 AS Decimal(18, 2)), 10, CAST(120.00 AS Decimal(18, 2)), CAST(108.00 AS Decimal(18, 2)))
INSERT [dbo].[DetalleVentas] ([NumeroFactura], [NumeroLinea], [CodigoProducto], [Unidad], [Bulto], [PrecioCosto], [CantidadxBulto], [PrecioVentaMinorista], [PrecioVentaMayorista]) VALUES (2, 1, N'1', 1, 0, CAST(99.22 AS Decimal(18, 2)), 10, CAST(125.00 AS Decimal(18, 2)), CAST(112.50 AS Decimal(18, 2)))
INSERT [dbo].[DetalleVentas] ([NumeroFactura], [NumeroLinea], [CodigoProducto], [Unidad], [Bulto], [PrecioCosto], [CantidadxBulto], [PrecioVentaMinorista], [PrecioVentaMayorista]) VALUES (2, 2, N'2', 1, 0, CAST(93.02 AS Decimal(18, 2)), 10, CAST(120.00 AS Decimal(18, 2)), CAST(108.00 AS Decimal(18, 2)))
INSERT [dbo].[DetalleVentas] ([NumeroFactura], [NumeroLinea], [CodigoProducto], [Unidad], [Bulto], [PrecioCosto], [CantidadxBulto], [PrecioVentaMinorista], [PrecioVentaMayorista]) VALUES (2, 3, N'1', 1, 0, CAST(99.22 AS Decimal(18, 2)), 10, CAST(125.00 AS Decimal(18, 2)), CAST(112.50 AS Decimal(18, 2)))
INSERT [dbo].[DetalleVentas] ([NumeroFactura], [NumeroLinea], [CodigoProducto], [Unidad], [Bulto], [PrecioCosto], [CantidadxBulto], [PrecioVentaMinorista], [PrecioVentaMayorista]) VALUES (2, 4, N'3', 1, 0, CAST(99.22 AS Decimal(18, 2)), 10, CAST(125.00 AS Decimal(18, 2)), CAST(112.50 AS Decimal(18, 2)))
INSERT [dbo].[DetalleVentas] ([NumeroFactura], [NumeroLinea], [CodigoProducto], [Unidad], [Bulto], [PrecioCosto], [CantidadxBulto], [PrecioVentaMinorista], [PrecioVentaMayorista]) VALUES (3, 2, N'3', 1, 0, CAST(99.22 AS Decimal(18, 2)), 10, CAST(125.00 AS Decimal(18, 2)), CAST(112.50 AS Decimal(18, 2)))
INSERT [dbo].[DetalleVentas] ([NumeroFactura], [NumeroLinea], [CodigoProducto], [Unidad], [Bulto], [PrecioCosto], [CantidadxBulto], [PrecioVentaMinorista], [PrecioVentaMayorista]) VALUES (3, 3, N'3', 1, 0, CAST(99.22 AS Decimal(18, 2)), 10, CAST(125.00 AS Decimal(18, 2)), CAST(112.50 AS Decimal(18, 2)))
/****** Object:  Table [dbo].[DetalleNotaDevolucion]    Script Date: 06/28/2019 18:26:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DetalleNotaDevolucion](
	[NumeroFactura] [int] NULL,
	[NumeroLinea] [int] NULL,
	[CodigoProducto] [varchar](50) NULL,
	[Unidad] [int] NULL,
	[Bulto] [int] NULL,
	[PrecioCosto] [decimal](18, 2) NULL,
	[CantidadxBulto] [int] NULL,
	[PrecioVentaMinorista] [decimal](18, 2) NULL,
	[PrecioVentaMayorista] [decimal](18, 2) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[DetalleNotaDevolucion] ([NumeroFactura], [NumeroLinea], [CodigoProducto], [Unidad], [Bulto], [PrecioCosto], [CantidadxBulto], [PrecioVentaMinorista], [PrecioVentaMayorista]) VALUES (3, 2, N'1', 2, 0, CAST(99.22 AS Decimal(18, 2)), 10, CAST(125.00 AS Decimal(18, 2)), CAST(112.50 AS Decimal(18, 2)))
INSERT [dbo].[DetalleNotaDevolucion] ([NumeroFactura], [NumeroLinea], [CodigoProducto], [Unidad], [Bulto], [PrecioCosto], [CantidadxBulto], [PrecioVentaMinorista], [PrecioVentaMayorista]) VALUES (3, 3, N'2', 1, 0, CAST(93.02 AS Decimal(18, 2)), 10, CAST(120.00 AS Decimal(18, 2)), CAST(108.00 AS Decimal(18, 2)))
INSERT [dbo].[DetalleNotaDevolucion] ([NumeroFactura], [NumeroLinea], [CodigoProducto], [Unidad], [Bulto], [PrecioCosto], [CantidadxBulto], [PrecioVentaMinorista], [PrecioVentaMayorista]) VALUES (4, 1, N'1', 2, 0, CAST(99.22 AS Decimal(18, 2)), 10, CAST(125.00 AS Decimal(18, 2)), CAST(112.50 AS Decimal(18, 2)))
INSERT [dbo].[DetalleNotaDevolucion] ([NumeroFactura], [NumeroLinea], [CodigoProducto], [Unidad], [Bulto], [PrecioCosto], [CantidadxBulto], [PrecioVentaMinorista], [PrecioVentaMayorista]) VALUES (4, 2, N'2', 1, 0, CAST(93.02 AS Decimal(18, 2)), 10, CAST(120.00 AS Decimal(18, 2)), CAST(108.00 AS Decimal(18, 2)))
INSERT [dbo].[DetalleNotaDevolucion] ([NumeroFactura], [NumeroLinea], [CodigoProducto], [Unidad], [Bulto], [PrecioCosto], [CantidadxBulto], [PrecioVentaMinorista], [PrecioVentaMayorista]) VALUES (2, 1, N'1', 1, 0, CAST(99.22 AS Decimal(18, 2)), 10, CAST(125.00 AS Decimal(18, 2)), CAST(112.50 AS Decimal(18, 2)))
INSERT [dbo].[DetalleNotaDevolucion] ([NumeroFactura], [NumeroLinea], [CodigoProducto], [Unidad], [Bulto], [PrecioCosto], [CantidadxBulto], [PrecioVentaMinorista], [PrecioVentaMayorista]) VALUES (5, 1, N'1', 4, 0, CAST(99.22 AS Decimal(18, 2)), 10, CAST(125.00 AS Decimal(18, 2)), CAST(112.50 AS Decimal(18, 2)))
INSERT [dbo].[DetalleNotaDevolucion] ([NumeroFactura], [NumeroLinea], [CodigoProducto], [Unidad], [Bulto], [PrecioCosto], [CantidadxBulto], [PrecioVentaMinorista], [PrecioVentaMayorista]) VALUES (5, 2, N'2', 2, 0, CAST(93.02 AS Decimal(18, 2)), 10, CAST(120.00 AS Decimal(18, 2)), CAST(108.00 AS Decimal(18, 2)))
/****** Object:  Table [dbo].[DetalleCompras]    Script Date: 06/28/2019 18:26:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DetalleCompras](
	[NumeroFactura] [int] NULL,
	[NumeroLinea] [int] NULL,
	[CodigoProducto] [varchar](50) NULL,
	[Cantidad] [int] NULL,
	[PrecioCosto] [decimal](18, 2) NULL,
	[PrecioVentaMinorista] [decimal](18, 2) NULL,
	[PrecioVentaMayorista] [decimal](18, 2) NULL,
	[Rentabilidad] [decimal](18, 2) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[DetalleCompras] ([NumeroFactura], [NumeroLinea], [CodigoProducto], [Cantidad], [PrecioCosto], [PrecioVentaMinorista], [PrecioVentaMayorista], [Rentabilidad]) VALUES (2, 1, N'1', 200, CAST(99.22 AS Decimal(18, 2)), CAST(125.00 AS Decimal(18, 2)), CAST(112.50 AS Decimal(18, 2)), CAST(25.00 AS Decimal(18, 2)))
INSERT [dbo].[DetalleCompras] ([NumeroFactura], [NumeroLinea], [CodigoProducto], [Cantidad], [PrecioCosto], [PrecioVentaMinorista], [PrecioVentaMayorista], [Rentabilidad]) VALUES (2, 2, N'2', 20, CAST(93.02 AS Decimal(18, 2)), CAST(120.00 AS Decimal(18, 2)), CAST(108.00 AS Decimal(18, 2)), CAST(25.00 AS Decimal(18, 2)))
INSERT [dbo].[DetalleCompras] ([NumeroFactura], [NumeroLinea], [CodigoProducto], [Cantidad], [PrecioCosto], [PrecioVentaMinorista], [PrecioVentaMayorista], [Rentabilidad]) VALUES (3, 1, N'5', 200, CAST(1.28 AS Decimal(18, 2)), CAST(5.00 AS Decimal(18, 2)), CAST(4.50 AS Decimal(18, 2)), CAST(25.00 AS Decimal(18, 2)))
INSERT [dbo].[DetalleCompras] ([NumeroFactura], [NumeroLinea], [CodigoProducto], [Cantidad], [PrecioCosto], [PrecioVentaMinorista], [PrecioVentaMayorista], [Rentabilidad]) VALUES (3, 2, N'6', 200, CAST(89.36 AS Decimal(18, 2)), CAST(115.00 AS Decimal(18, 2)), CAST(103.50 AS Decimal(18, 2)), CAST(25.00 AS Decimal(18, 2)))
INSERT [dbo].[DetalleCompras] ([NumeroFactura], [NumeroLinea], [CodigoProducto], [Cantidad], [PrecioCosto], [PrecioVentaMinorista], [PrecioVentaMayorista], [Rentabilidad]) VALUES (4, 1, N'1', 200, CAST(99.22 AS Decimal(18, 2)), CAST(125.00 AS Decimal(18, 2)), CAST(112.50 AS Decimal(18, 2)), CAST(25.00 AS Decimal(18, 2)))
INSERT [dbo].[DetalleCompras] ([NumeroFactura], [NumeroLinea], [CodigoProducto], [Cantidad], [PrecioCosto], [PrecioVentaMinorista], [PrecioVentaMayorista], [Rentabilidad]) VALUES (4, 2, N'2', 200, CAST(93.02 AS Decimal(18, 2)), CAST(120.00 AS Decimal(18, 2)), CAST(108.00 AS Decimal(18, 2)), CAST(25.00 AS Decimal(18, 2)))
INSERT [dbo].[DetalleCompras] ([NumeroFactura], [NumeroLinea], [CodigoProducto], [Cantidad], [PrecioCosto], [PrecioVentaMinorista], [PrecioVentaMayorista], [Rentabilidad]) VALUES (4, 3, N'3', 200, CAST(99.22 AS Decimal(18, 2)), CAST(125.00 AS Decimal(18, 2)), CAST(112.50 AS Decimal(18, 2)), CAST(25.00 AS Decimal(18, 2)))
INSERT [dbo].[DetalleCompras] ([NumeroFactura], [NumeroLinea], [CodigoProducto], [Cantidad], [PrecioCosto], [PrecioVentaMinorista], [PrecioVentaMayorista], [Rentabilidad]) VALUES (1, 1, N'1', 200, CAST(99.22 AS Decimal(18, 2)), CAST(125.00 AS Decimal(18, 2)), CAST(112.50 AS Decimal(18, 2)), CAST(25.00 AS Decimal(18, 2)))
INSERT [dbo].[DetalleCompras] ([NumeroFactura], [NumeroLinea], [CodigoProducto], [Cantidad], [PrecioCosto], [PrecioVentaMinorista], [PrecioVentaMayorista], [Rentabilidad]) VALUES (1, 2, N'2', 200, CAST(93.02 AS Decimal(18, 2)), CAST(120.00 AS Decimal(18, 2)), CAST(108.00 AS Decimal(18, 2)), CAST(25.00 AS Decimal(18, 2)))
INSERT [dbo].[DetalleCompras] ([NumeroFactura], [NumeroLinea], [CodigoProducto], [Cantidad], [PrecioCosto], [PrecioVentaMinorista], [PrecioVentaMayorista], [Rentabilidad]) VALUES (1, 3, N'3', 200, CAST(93.02 AS Decimal(18, 2)), CAST(120.00 AS Decimal(18, 2)), CAST(108.00 AS Decimal(18, 2)), CAST(25.00 AS Decimal(18, 2)))
INSERT [dbo].[DetalleCompras] ([NumeroFactura], [NumeroLinea], [CodigoProducto], [Cantidad], [PrecioCosto], [PrecioVentaMinorista], [PrecioVentaMayorista], [Rentabilidad]) VALUES (1, 4, N'4', 200, CAST(86.82 AS Decimal(18, 2)), CAST(110.00 AS Decimal(18, 2)), CAST(99.00 AS Decimal(18, 2)), CAST(25.00 AS Decimal(18, 2)))
/****** Object:  Table [dbo].[Descuentos]    Script Date: 06/28/2019 18:26:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Descuentos](
	[CodigoDescuento] [int] NOT NULL,
	[NombreDescuento] [varchar](50) NOT NULL,
	[Porcentaje] [decimal](18, 2) NOT NULL,
	[Estado] [bit] NULL,
 CONSTRAINT [PK_Descuentos] PRIMARY KEY CLUSTERED 
(
	[CodigoDescuento] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Descuentos] ([CodigoDescuento], [NombreDescuento], [Porcentaje], [Estado]) VALUES (0, N'SinDescuento', CAST(0.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[Descuentos] ([CodigoDescuento], [NombreDescuento], [Porcentaje], [Estado]) VALUES (1, N'ClienteBasico', CAST(7.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[Descuentos] ([CodigoDescuento], [NombreDescuento], [Porcentaje], [Estado]) VALUES (2, N'ClientePremium', CAST(10.00 AS Decimal(18, 2)), 0)
INSERT [dbo].[Descuentos] ([CodigoDescuento], [NombreDescuento], [Porcentaje], [Estado]) VALUES (3, N'ClienteDistribuidora', CAST(15.00 AS Decimal(18, 2)), 1)
/****** Object:  Table [dbo].[CuentaCorrientes]    Script Date: 06/28/2019 18:26:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CuentaCorrientes](
	[CodigoCuentaCorriente] [int] IDENTITY(1,1) NOT NULL,
	[Saldo] [decimal](18, 2) NULL,
	[LimiteCuenta] [decimal](18, 2) NULL,
	[Estado] [bit] NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[CuentaCorrientes] ON
INSERT [dbo].[CuentaCorrientes] ([CodigoCuentaCorriente], [Saldo], [LimiteCuenta], [Estado]) VALUES (1, CAST(0.00 AS Decimal(18, 2)), CAST(5000.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[CuentaCorrientes] ([CodigoCuentaCorriente], [Saldo], [LimiteCuenta], [Estado]) VALUES (2, CAST(0.00 AS Decimal(18, 2)), CAST(2000.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[CuentaCorrientes] ([CodigoCuentaCorriente], [Saldo], [LimiteCuenta], [Estado]) VALUES (3, CAST(24.00 AS Decimal(18, 2)), CAST(2000.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[CuentaCorrientes] ([CodigoCuentaCorriente], [Saldo], [LimiteCuenta], [Estado]) VALUES (4, CAST(0.00 AS Decimal(18, 2)), CAST(2000.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[CuentaCorrientes] ([CodigoCuentaCorriente], [Saldo], [LimiteCuenta], [Estado]) VALUES (5, CAST(0.00 AS Decimal(18, 2)), CAST(2000.00 AS Decimal(18, 2)), 0)
SET IDENTITY_INSERT [dbo].[CuentaCorrientes] OFF
/****** Object:  Table [dbo].[Contactos]    Script Date: 06/28/2019 18:26:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Contactos](
	[CodigoContacto] [int] IDENTITY(1,1) NOT NULL,
	[Telefono] [varchar](50) NOT NULL,
	[Celular] [varchar](50) NOT NULL,
	[Mail] [varchar](50) NULL,
	[CodigoDireccion] [int] NOT NULL,
	[Estado] [bit] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Contactos] ON
INSERT [dbo].[Contactos] ([CodigoContacto], [Telefono], [Celular], [Mail], [CodigoDireccion], [Estado]) VALUES (1, N'02291423484', N'02234518568', N'piantoni@gmail.com', 1, 1)
INSERT [dbo].[Contactos] ([CodigoContacto], [Telefono], [Celular], [Mail], [CodigoDireccion], [Estado]) VALUES (2, N'2291425846', N'2291424258', N'MatiasPires@gmail.com', 2, 1)
INSERT [dbo].[Contactos] ([CodigoContacto], [Telefono], [Celular], [Mail], [CodigoDireccion], [Estado]) VALUES (3, N'2234558254', N'2235548354', N'cocacolacompany@gmail.com', 3, 1)
INSERT [dbo].[Contactos] ([CodigoContacto], [Telefono], [Celular], [Mail], [CodigoDireccion], [Estado]) VALUES (4, N'2234782913', N'2234238945', N'pepsi@gmail.com', 4, 1)
INSERT [dbo].[Contactos] ([CodigoContacto], [Telefono], [Celular], [Mail], [CodigoDireccion], [Estado]) VALUES (5, N'2234915054', N'2291425684', N'arcor@gmail.com', 5, 1)
INSERT [dbo].[Contactos] ([CodigoContacto], [Telefono], [Celular], [Mail], [CodigoDireccion], [Estado]) VALUES (6, N'2234857896', N'2234567253', N'milka@gmail.com', 6, 0)
INSERT [dbo].[Contactos] ([CodigoContacto], [Telefono], [Celular], [Mail], [CodigoDireccion], [Estado]) VALUES (7, N'2291434589', N'2291434856', N'alarcon@gmail.com', 7, 1)
INSERT [dbo].[Contactos] ([CodigoContacto], [Telefono], [Celular], [Mail], [CodigoDireccion], [Estado]) VALUES (8, N'2234856874', N'2234879654', N'la.paulina@gmail.com', 8, 1)
INSERT [dbo].[Contactos] ([CodigoContacto], [Telefono], [Celular], [Mail], [CodigoDireccion], [Estado]) VALUES (9, N'111', N'111', N'111', 9, 0)
INSERT [dbo].[Contactos] ([CodigoContacto], [Telefono], [Celular], [Mail], [CodigoDireccion], [Estado]) VALUES (10, N'222', N'22', N'222', 10, 0)
INSERT [dbo].[Contactos] ([CodigoContacto], [Telefono], [Celular], [Mail], [CodigoDireccion], [Estado]) VALUES (11, N'333', N'333', N'33', 11, 0)
INSERT [dbo].[Contactos] ([CodigoContacto], [Telefono], [Celular], [Mail], [CodigoDireccion], [Estado]) VALUES (12, N'1147463241', N'1123870444', N'alejandrabarrachina23@gmail.com', 12, 1)
INSERT [dbo].[Contactos] ([CodigoContacto], [Telefono], [Celular], [Mail], [CodigoDireccion], [Estado]) VALUES (13, N'1147234868', N'1128450454', N'federicolamas98@gmail.com', 13, 1)
INSERT [dbo].[Contactos] ([CodigoContacto], [Telefono], [Celular], [Mail], [CodigoDireccion], [Estado]) VALUES (15, N'2291424213', N'2291457918', N'marinamansilla@gmail.com', 15, 1)
INSERT [dbo].[Contactos] ([CodigoContacto], [Telefono], [Celular], [Mail], [CodigoDireccion], [Estado]) VALUES (16, N'111', N'11', N'111', 16, 0)
INSERT [dbo].[Contactos] ([CodigoContacto], [Telefono], [Celular], [Mail], [CodigoDireccion], [Estado]) VALUES (14, N'114743241', N'1123584697', N'martinabarrachina@gmail.com', 14, 1)
SET IDENTITY_INSERT [dbo].[Contactos] OFF
/****** Object:  Table [dbo].[CondicionesIVA]    Script Date: 06/28/2019 18:26:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CondicionesIVA](
	[CodigoCondicionIVA] [int] IDENTITY(1,1) NOT NULL,
	[NombreCondicionIVA] [varchar](30) NOT NULL,
	[Estado] [bit] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[CondicionesIVA] ON
INSERT [dbo].[CondicionesIVA] ([CodigoCondicionIVA], [NombreCondicionIVA], [Estado]) VALUES (1, N'Responsable Inscripto', 1)
INSERT [dbo].[CondicionesIVA] ([CodigoCondicionIVA], [NombreCondicionIVA], [Estado]) VALUES (2, N'Exento', 1)
INSERT [dbo].[CondicionesIVA] ([CodigoCondicionIVA], [NombreCondicionIVA], [Estado]) VALUES (3, N'Responsable No Inscripto', 1)
INSERT [dbo].[CondicionesIVA] ([CodigoCondicionIVA], [NombreCondicionIVA], [Estado]) VALUES (4, N'Monotributista', 1)
INSERT [dbo].[CondicionesIVA] ([CodigoCondicionIVA], [NombreCondicionIVA], [Estado]) VALUES (5, N'No Categorizado', 1)
SET IDENTITY_INSERT [dbo].[CondicionesIVA] OFF
/****** Object:  Table [dbo].[Compras]    Script Date: 06/28/2019 18:26:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Compras](
	[NumeroCompra] [int] IDENTITY(1,1) NOT NULL,
	[Usuario] [int] NULL,
	[Proveedor] [int] NULL,
	[Fecha] [date] NULL,
	[Total] [decimal](18, 0) NULL,
 CONSTRAINT [PK_Compras] PRIMARY KEY CLUSTERED 
(
	[NumeroCompra] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Compras] ON
INSERT [dbo].[Compras] ([NumeroCompra], [Usuario], [Proveedor], [Fecha], [Total]) VALUES (1, 1, 100, CAST(0xD53F0B00 AS Date), NULL)
INSERT [dbo].[Compras] ([NumeroCompra], [Usuario], [Proveedor], [Fecha], [Total]) VALUES (2, 1, 100, CAST(0xD53F0B00 AS Date), NULL)
INSERT [dbo].[Compras] ([NumeroCompra], [Usuario], [Proveedor], [Fecha], [Total]) VALUES (3, 1, 200, CAST(0xD53F0B00 AS Date), NULL)
INSERT [dbo].[Compras] ([NumeroCompra], [Usuario], [Proveedor], [Fecha], [Total]) VALUES (4, 1, 100, CAST(0xD53F0B00 AS Date), NULL)
SET IDENTITY_INSERT [dbo].[Compras] OFF
/****** Object:  Table [dbo].[NotaDevolucion]    Script Date: 06/28/2019 18:26:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NotaDevolucion](
	[NumeroNotaCredito] [int] IDENTITY(1,1) NOT NULL,
	[Usuario] [int] NULL,
	[Cliente] [int] NULL,
	[Fecha] [varchar](50) NULL,
	[Total] [decimal](18, 2) NULL,
	[MetodoPago] [varchar](50) NULL,
	[MotivoDevolucion] [varchar](50) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[NotaDevolucion] ON
INSERT [dbo].[NotaDevolucion] ([NumeroNotaCredito], [Usuario], [Cliente], [Fecha], [Total], [MetodoPago], [MotivoDevolucion]) VALUES (1, 1, 0, N'28/06/2019', CAST(125.00 AS Decimal(18, 2)), N'Efectivo', N'Equivocación Cliente')
INSERT [dbo].[NotaDevolucion] ([NumeroNotaCredito], [Usuario], [Cliente], [Fecha], [Total], [MetodoPago], [MotivoDevolucion]) VALUES (2, 1, 0, N'28/06/2019', CAST(370.00 AS Decimal(18, 2)), N'Efectivo', N'Equivocación Cliente')
INSERT [dbo].[NotaDevolucion] ([NumeroNotaCredito], [Usuario], [Cliente], [Fecha], [Total], [MetodoPago], [MotivoDevolucion]) VALUES (3, 1, 0, N'28/06/2019', CAST(370.00 AS Decimal(18, 2)), N'Efectivo', N'Mercadería en mal estado')
INSERT [dbo].[NotaDevolucion] ([NumeroNotaCredito], [Usuario], [Cliente], [Fecha], [Total], [MetodoPago], [MotivoDevolucion]) VALUES (4, 1, 0, N'28/06/2019', CAST(740.00 AS Decimal(18, 2)), N'Efectivo', N'Equivocación Usuario')
SET IDENTITY_INSERT [dbo].[NotaDevolucion] OFF
/****** Object:  Table [dbo].[MovimientosDinero]    Script Date: 06/28/2019 18:26:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MovimientosDinero](
	[NumeroOperacion] [int] NULL,
	[Usuario] [int] NULL,
	[Motivo] [varchar](50) NULL,
	[Dinero] [decimal](18, 2) NULL,
	[Fecha] [date] NULL,
	[Hora] [nchar](10) NULL,
	[Observaciones] [text] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MotivosDevolucion]    Script Date: 06/28/2019 18:26:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MotivosDevolucion](
	[CodigoMotivoDevolucion] [int] NOT NULL,
	[Nombre] [varchar](30) NOT NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[MotivosDevolucion] ([CodigoMotivoDevolucion], [Nombre]) VALUES (1, N'Mercaderia vencida')
INSERT [dbo].[MotivosDevolucion] ([CodigoMotivoDevolucion], [Nombre]) VALUES (2, N'Mercadería en mal estado')
INSERT [dbo].[MotivosDevolucion] ([CodigoMotivoDevolucion], [Nombre]) VALUES (3, N'Equivocación Cliente')
INSERT [dbo].[MotivosDevolucion] ([CodigoMotivoDevolucion], [Nombre]) VALUES (4, N'Equivocación Usuario')
INSERT [dbo].[MotivosDevolucion] ([CodigoMotivoDevolucion], [Nombre]) VALUES (5, N'Disconformidad con precio')
INSERT [dbo].[MotivosDevolucion] ([CodigoMotivoDevolucion], [Nombre]) VALUES (6, N'Otros')
/****** Object:  Table [dbo].[Impuestos]    Script Date: 06/28/2019 18:26:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Impuestos](
	[CodigoImpuesto] [int] NOT NULL,
	[Nombre] [varchar](30) NOT NULL,
	[Descripcion] [text] NULL,
	[Estado] [bit] NULL,
 CONSTRAINT [PK_Impuestos] PRIMARY KEY CLUSTERED 
(
	[CodigoImpuesto] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Impuestos] ([CodigoImpuesto], [Nombre], [Descripcion], [Estado]) VALUES (1, N'IVA', N'Impuesto al Valor Agregado', 1)
INSERT [dbo].[Impuestos] ([CodigoImpuesto], [Nombre], [Descripcion], [Estado]) VALUES (2, N'IB', N'Ingresos Brutos', 1)
INSERT [dbo].[Impuestos] ([CodigoImpuesto], [Nombre], [Descripcion], [Estado]) VALUES (3, N'IVA RES 3337', N'Agentes de Retención IVA', 1)
INSERT [dbo].[Impuestos] ([CodigoImpuesto], [Nombre], [Descripcion], [Estado]) VALUES (4, N'II', N'Impuesto Interno', 1)
/****** Object:  Table [dbo].[FormasPago]    Script Date: 06/28/2019 18:26:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[FormasPago](
	[CodigoFormaPago] [int] NOT NULL,
	[Nombre] [varchar](30) NOT NULL,
	[Porcentaje] [decimal](18, 0) NOT NULL,
	[Estado] [bit] NULL,
 CONSTRAINT [PK_FormasPago] PRIMARY KEY CLUSTERED 
(
	[CodigoFormaPago] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[FormasPago] ([CodigoFormaPago], [Nombre], [Porcentaje], [Estado]) VALUES (1, N'Efectivo', CAST(0 AS Decimal(18, 0)), 1)
INSERT [dbo].[FormasPago] ([CodigoFormaPago], [Nombre], [Porcentaje], [Estado]) VALUES (2, N'Debito', CAST(5 AS Decimal(18, 0)), 1)
INSERT [dbo].[FormasPago] ([CodigoFormaPago], [Nombre], [Porcentaje], [Estado]) VALUES (3, N'Credito1', CAST(15 AS Decimal(18, 0)), 1)
INSERT [dbo].[FormasPago] ([CodigoFormaPago], [Nombre], [Porcentaje], [Estado]) VALUES (4, N'Credito', CAST(30 AS Decimal(18, 0)), 1)
INSERT [dbo].[FormasPago] ([CodigoFormaPago], [Nombre], [Porcentaje], [Estado]) VALUES (5, N'MercadoPago', CAST(0 AS Decimal(18, 0)), 1)
/****** Object:  Table [dbo].[Proveedores]    Script Date: 06/28/2019 18:26:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Proveedores](
	[CodigoProveedor] [int] NOT NULL,
	[RazonSocial] [varchar](50) NULL,
	[NumeroCUIT] [varchar](50) NULL,
	[NombreFantasia] [varchar](50) NULL,
	[CodigoCondicionIVA] [int] NULL,
	[CodigoContacto] [int] NULL,
	[Estado] [bit] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Proveedores] ([CodigoProveedor], [RazonSocial], [NumeroCUIT], [NombreFantasia], [CodigoCondicionIVA], [CodigoContacto], [Estado]) VALUES (100, N'Marcelo Piantoni', N'1846454827', N'Piantoni', 1, 1, 1)
INSERT [dbo].[Proveedores] ([CodigoProveedor], [RazonSocial], [NumeroCUIT], [NombreFantasia], [CodigoCondicionIVA], [CodigoContacto], [Estado]) VALUES (200, N'Matias Pires', N'1189535745', N'Pires & Lag', 1, 2, 1)
INSERT [dbo].[Proveedores] ([CodigoProveedor], [RazonSocial], [NumeroCUIT], [NombreFantasia], [CodigoCondicionIVA], [CodigoContacto], [Estado]) VALUES (300, N'Viviana Cañas', N'30525390086', N'Coca Cola', 1, 3, 1)
INSERT [dbo].[Proveedores] ([CodigoProveedor], [RazonSocial], [NumeroCUIT], [NombreFantasia], [CodigoCondicionIVA], [CodigoContacto], [Estado]) VALUES (400, N'Martina Salas', N'185434872', N'Pepsi', 1, 4, 1)
INSERT [dbo].[Proveedores] ([CodigoProveedor], [RazonSocial], [NumeroCUIT], [NombreFantasia], [CodigoCondicionIVA], [CodigoContacto], [Estado]) VALUES (500, N'Claudia Alarcor', N'215896325', N'Arcor', 1, 5, 1)
INSERT [dbo].[Proveedores] ([CodigoProveedor], [RazonSocial], [NumeroCUIT], [NombreFantasia], [CodigoCondicionIVA], [CodigoContacto], [Estado]) VALUES (600, N'Sebastian Perez', N'229564877', N'Milka', 1, 6, 0)
INSERT [dbo].[Proveedores] ([CodigoProveedor], [RazonSocial], [NumeroCUIT], [NombreFantasia], [CodigoCondicionIVA], [CodigoContacto], [Estado]) VALUES (700, N'Maria Soles', N'278956427', N'Alarcon', 1, 7, 1)
INSERT [dbo].[Proveedores] ([CodigoProveedor], [RazonSocial], [NumeroCUIT], [NombreFantasia], [CodigoCondicionIVA], [CodigoContacto], [Estado]) VALUES (800, N'Lucas Mendez', N'1856324879', N'CardLine', 1, 8, 1)
INSERT [dbo].[Proveedores] ([CodigoProveedor], [RazonSocial], [NumeroCUIT], [NombreFantasia], [CodigoCondicionIVA], [CodigoContacto], [Estado]) VALUES (1111, N'1111', N'1111', N'111', 2, 9, 0)
INSERT [dbo].[Proveedores] ([CodigoProveedor], [RazonSocial], [NumeroCUIT], [NombreFantasia], [CodigoCondicionIVA], [CodigoContacto], [Estado]) VALUES (222, N'222', N'222', N'222', 2, 10, 0)
INSERT [dbo].[Proveedores] ([CodigoProveedor], [RazonSocial], [NumeroCUIT], [NombreFantasia], [CodigoCondicionIVA], [CodigoContacto], [Estado]) VALUES (333, N'333', N'333', N'33', 1, 11, 0)
/****** Object:  Table [dbo].[Productos]    Script Date: 06/28/2019 18:26:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Productos](
	[CodigoProducto] [varchar](50) NOT NULL,
	[CodigoBulto] [varchar](50) NOT NULL,
	[NombreProducto] [varchar](50) NOT NULL,
	[CodigoTipoProducto] [int] NOT NULL,
	[Stock] [int] NULL,
	[StockCritico] [int] NOT NULL,
	[PrecioCosto] [decimal](18, 2) NULL,
	[PrecioCostoLista] [decimal](18, 2) NULL,
	[PrecioVentaMinorista] [decimal](18, 2) NULL,
	[PrecioVentaMayorista] [decimal](18, 2) NULL,
	[Rentabilidad] [int] NULL,
	[CantidadxBulto] [int] NOT NULL,
	[CodigoProveedor] [int] NOT NULL,
	[CodigoRubro] [int] NOT NULL,
	[Estado] [bit] NULL,
 CONSTRAINT [PK_Productos] PRIMARY KEY CLUSTERED 
(
	[CodigoProducto] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Productos] ([CodigoProducto], [CodigoBulto], [NombreProducto], [CodigoTipoProducto], [Stock], [StockCritico], [PrecioCosto], [PrecioCostoLista], [PrecioVentaMinorista], [PrecioVentaMayorista], [Rentabilidad], [CantidadxBulto], [CodigoProveedor], [CodigoRubro], [Estado]) VALUES (N'1', N'B1', N'Marlboro Box', 3, 200, 100, CAST(99.22 AS Decimal(18, 2)), CAST(89.30 AS Decimal(18, 2)), CAST(125.00 AS Decimal(18, 2)), CAST(112.50 AS Decimal(18, 2)), 25, 10, 100, 1, 1)
INSERT [dbo].[Productos] ([CodigoProducto], [CodigoBulto], [NombreProducto], [CodigoTipoProducto], [Stock], [StockCritico], [PrecioCosto], [PrecioCostoLista], [PrecioVentaMinorista], [PrecioVentaMayorista], [Rentabilidad], [CantidadxBulto], [CodigoProveedor], [CodigoRubro], [Estado]) VALUES (N'10', N'B10', N'Sprite x 600 ml', 8, 0, 24, CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 100, 12, 300, 1, 1)
INSERT [dbo].[Productos] ([CodigoProducto], [CodigoBulto], [NombreProducto], [CodigoTipoProducto], [Stock], [StockCritico], [PrecioCosto], [PrecioCostoLista], [PrecioVentaMinorista], [PrecioVentaMayorista], [Rentabilidad], [CantidadxBulto], [CodigoProveedor], [CodigoRubro], [Estado]) VALUES (N'11', N'B11', N'Coca Cola x 1.5 L', 8, 0, 16, CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 100, 8, 300, 1, 1)
INSERT [dbo].[Productos] ([CodigoProducto], [CodigoBulto], [NombreProducto], [CodigoTipoProducto], [Stock], [StockCritico], [PrecioCosto], [PrecioCostoLista], [PrecioVentaMinorista], [PrecioVentaMayorista], [Rentabilidad], [CantidadxBulto], [CodigoProveedor], [CodigoRubro], [Estado]) VALUES (N'111', N'B111', N'11', 1, 0, 111, CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 11, 111, 300, 5, 0)
INSERT [dbo].[Productos] ([CodigoProducto], [CodigoBulto], [NombreProducto], [CodigoTipoProducto], [Stock], [StockCritico], [PrecioCosto], [PrecioCostoLista], [PrecioVentaMinorista], [PrecioVentaMayorista], [Rentabilidad], [CantidadxBulto], [CodigoProveedor], [CodigoRubro], [Estado]) VALUES (N'12', N'B12', N'Coca Cola x 2.25 L', 8, 0, 40, CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 100, 8, 300, 1, 1)
INSERT [dbo].[Productos] ([CodigoProducto], [CodigoBulto], [NombreProducto], [CodigoTipoProducto], [Stock], [StockCritico], [PrecioCosto], [PrecioCostoLista], [PrecioVentaMinorista], [PrecioVentaMayorista], [Rentabilidad], [CantidadxBulto], [CodigoProveedor], [CodigoRubro], [Estado]) VALUES (N'13', N'B13', N'Pepsi x 600 ml', 8, 0, 12, CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 80, 12, 400, 1, 1)
INSERT [dbo].[Productos] ([CodigoProducto], [CodigoBulto], [NombreProducto], [CodigoTipoProducto], [Stock], [StockCritico], [PrecioCosto], [PrecioCostoLista], [PrecioVentaMinorista], [PrecioVentaMayorista], [Rentabilidad], [CantidadxBulto], [CodigoProveedor], [CodigoRubro], [Estado]) VALUES (N'14', N'B14', N'7 up x600 ml', 8, 0, 12, CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 80, 12, 400, 1, 1)
INSERT [dbo].[Productos] ([CodigoProducto], [CodigoBulto], [NombreProducto], [CodigoTipoProducto], [Stock], [StockCritico], [PrecioCosto], [PrecioCostoLista], [PrecioVentaMinorista], [PrecioVentaMayorista], [Rentabilidad], [CantidadxBulto], [CodigoProveedor], [CodigoRubro], [Estado]) VALUES (N'15', N'B15', N'Pepsi x 1.5 L', 8, 0, 6, CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 80, 6, 400, 1, 1)
INSERT [dbo].[Productos] ([CodigoProducto], [CodigoBulto], [NombreProducto], [CodigoTipoProducto], [Stock], [StockCritico], [PrecioCosto], [PrecioCostoLista], [PrecioVentaMinorista], [PrecioVentaMayorista], [Rentabilidad], [CantidadxBulto], [CodigoProveedor], [CodigoRubro], [Estado]) VALUES (N'16', N'B16', N'7 up x 1.5 L', 8, 0, 12, CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 80, 6, 400, 1, 1)
INSERT [dbo].[Productos] ([CodigoProducto], [CodigoBulto], [NombreProducto], [CodigoTipoProducto], [Stock], [StockCritico], [PrecioCosto], [PrecioCostoLista], [PrecioVentaMinorista], [PrecioVentaMayorista], [Rentabilidad], [CantidadxBulto], [CodigoProveedor], [CodigoRubro], [Estado]) VALUES (N'17', N'B17', N'Cofler x 25grs Leche', 6, 0, 30, CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 100, 10, 500, 1, 1)
INSERT [dbo].[Productos] ([CodigoProducto], [CodigoBulto], [NombreProducto], [CodigoTipoProducto], [Stock], [StockCritico], [PrecioCosto], [PrecioCostoLista], [PrecioVentaMinorista], [PrecioVentaMayorista], [Rentabilidad], [CantidadxBulto], [CodigoProveedor], [CodigoRubro], [Estado]) VALUES (N'18', N'B18', N'Rocklets x 20grs', 6, 0, 32, CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 100, 16, 500, 1, 1)
INSERT [dbo].[Productos] ([CodigoProducto], [CodigoBulto], [NombreProducto], [CodigoTipoProducto], [Stock], [StockCritico], [PrecioCosto], [PrecioCostoLista], [PrecioVentaMinorista], [PrecioVentaMayorista], [Rentabilidad], [CantidadxBulto], [CodigoProveedor], [CodigoRubro], [Estado]) VALUES (N'19', N'B19', N'Aguila Minitorta Alfajor', 2, 0, 42, CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 100, 21, 500, 1, 1)
INSERT [dbo].[Productos] ([CodigoProducto], [CodigoBulto], [NombreProducto], [CodigoTipoProducto], [Stock], [StockCritico], [PrecioCosto], [PrecioCostoLista], [PrecioVentaMinorista], [PrecioVentaMayorista], [Rentabilidad], [CantidadxBulto], [CodigoProveedor], [CodigoRubro], [Estado]) VALUES (N'2', N'B2', N'Marlboro KS', 3, 200, 100, CAST(93.02 AS Decimal(18, 2)), CAST(83.72 AS Decimal(18, 2)), CAST(120.00 AS Decimal(18, 2)), CAST(108.00 AS Decimal(18, 2)), 25, 10, 100, 1, 1)
INSERT [dbo].[Productos] ([CodigoProducto], [CodigoBulto], [NombreProducto], [CodigoTipoProducto], [Stock], [StockCritico], [PrecioCosto], [PrecioCostoLista], [PrecioVentaMinorista], [PrecioVentaMayorista], [Rentabilidad], [CantidadxBulto], [CodigoProveedor], [CodigoRubro], [Estado]) VALUES (N'20', N'B20', N'Block Alfajor', 2, 0, 21, CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 100, 21, 500, 1, 1)
INSERT [dbo].[Productos] ([CodigoProducto], [CodigoBulto], [NombreProducto], [CodigoTipoProducto], [Stock], [StockCritico], [PrecioCosto], [PrecioCostoLista], [PrecioVentaMinorista], [PrecioVentaMayorista], [Rentabilidad], [CantidadxBulto], [CodigoProveedor], [CodigoRubro], [Estado]) VALUES (N'21', N'B21', N'Topline 7 menta', 4, 0, 80, CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 100, 20, 500, 1, 1)
INSERT [dbo].[Productos] ([CodigoProducto], [CodigoBulto], [NombreProducto], [CodigoTipoProducto], [Stock], [StockCritico], [PrecioCosto], [PrecioCostoLista], [PrecioVentaMinorista], [PrecioVentaMayorista], [Rentabilidad], [CantidadxBulto], [CodigoProveedor], [CodigoRubro], [Estado]) VALUES (N'22', N'B22', N'Topline 7 Mandarina', 4, 0, 60, CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 100, 20, 500, 1, 1)
INSERT [dbo].[Productos] ([CodigoProducto], [CodigoBulto], [NombreProducto], [CodigoTipoProducto], [Stock], [StockCritico], [PrecioCosto], [PrecioCostoLista], [PrecioVentaMinorista], [PrecioVentaMayorista], [Rentabilidad], [CantidadxBulto], [CodigoProveedor], [CodigoRubro], [Estado]) VALUES (N'23', N'B23', N'Rumba', 1, 0, 24, CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 100, 24, 500, 1, 1)
INSERT [dbo].[Productos] ([CodigoProducto], [CodigoBulto], [NombreProducto], [CodigoTipoProducto], [Stock], [StockCritico], [PrecioCosto], [PrecioCostoLista], [PrecioVentaMinorista], [PrecioVentaMayorista], [Rentabilidad], [CantidadxBulto], [CodigoProveedor], [CodigoRubro], [Estado]) VALUES (N'24', N'B24', N'Diversión', 1, 0, 24, CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 100, 24, 500, 1, 1)
INSERT [dbo].[Productos] ([CodigoProducto], [CodigoBulto], [NombreProducto], [CodigoTipoProducto], [Stock], [StockCritico], [PrecioCosto], [PrecioCostoLista], [PrecioVentaMinorista], [PrecioVentaMayorista], [Rentabilidad], [CantidadxBulto], [CodigoProveedor], [CodigoRubro], [Estado]) VALUES (N'25', N'B25', N'Menthoplus Menta', 5, 0, 12, CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 100, 12, 500, 1, 1)
INSERT [dbo].[Productos] ([CodigoProducto], [CodigoBulto], [NombreProducto], [CodigoTipoProducto], [Stock], [StockCritico], [PrecioCosto], [PrecioCostoLista], [PrecioVentaMinorista], [PrecioVentaMayorista], [Rentabilidad], [CantidadxBulto], [CodigoProveedor], [CodigoRubro], [Estado]) VALUES (N'26', N'B26', N'Menthoplus Cherry', 5, 0, 12, CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 100, 12, 500, 1, 1)
INSERT [dbo].[Productos] ([CodigoProducto], [CodigoBulto], [NombreProducto], [CodigoTipoProducto], [Stock], [StockCritico], [PrecioCosto], [PrecioCostoLista], [PrecioVentaMinorista], [PrecioVentaMayorista], [Rentabilidad], [CantidadxBulto], [CodigoProveedor], [CodigoRubro], [Estado]) VALUES (N'27', N'B27', N'Milka Leger x 25 grs Leche', 6, 0, 24, CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 80, 12, 600, 1, 1)
INSERT [dbo].[Productos] ([CodigoProducto], [CodigoBulto], [NombreProducto], [CodigoTipoProducto], [Stock], [StockCritico], [PrecioCosto], [PrecioCostoLista], [PrecioVentaMinorista], [PrecioVentaMayorista], [Rentabilidad], [CantidadxBulto], [CodigoProveedor], [CodigoRubro], [Estado]) VALUES (N'3', N'B3', N'Philip Morris Box', 3, 197, 100, CAST(99.22 AS Decimal(18, 2)), CAST(89.30 AS Decimal(18, 2)), CAST(125.00 AS Decimal(18, 2)), CAST(112.50 AS Decimal(18, 2)), 25, 10, 100, 1, 1)
INSERT [dbo].[Productos] ([CodigoProducto], [CodigoBulto], [NombreProducto], [CodigoTipoProducto], [Stock], [StockCritico], [PrecioCosto], [PrecioCostoLista], [PrecioVentaMinorista], [PrecioVentaMayorista], [Rentabilidad], [CantidadxBulto], [CodigoProveedor], [CodigoRubro], [Estado]) VALUES (N'4', N'B4', N'Philip Morris KS', 3, 0, 100, CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 25, 10, 100, 1, 1)
INSERT [dbo].[Productos] ([CodigoProducto], [CodigoBulto], [NombreProducto], [CodigoTipoProducto], [Stock], [StockCritico], [PrecioCosto], [PrecioCostoLista], [PrecioVentaMinorista], [PrecioVentaMayorista], [Rentabilidad], [CantidadxBulto], [CodigoProveedor], [CodigoRubro], [Estado]) VALUES (N'5', N'B5', N'Lucky Strike Box', 3, 0, 50, CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 25, 10, 200, 1, 1)
INSERT [dbo].[Productos] ([CodigoProducto], [CodigoBulto], [NombreProducto], [CodigoTipoProducto], [Stock], [StockCritico], [PrecioCosto], [PrecioCostoLista], [PrecioVentaMinorista], [PrecioVentaMayorista], [Rentabilidad], [CantidadxBulto], [CodigoProveedor], [CodigoRubro], [Estado]) VALUES (N'6', N'B6', N'Lucky Strike KS', 3, 0, 30, CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 25, 10, 200, 1, 1)
INSERT [dbo].[Productos] ([CodigoProducto], [CodigoBulto], [NombreProducto], [CodigoTipoProducto], [Stock], [StockCritico], [PrecioCosto], [PrecioCostoLista], [PrecioVentaMinorista], [PrecioVentaMayorista], [Rentabilidad], [CantidadxBulto], [CodigoProveedor], [CodigoRubro], [Estado]) VALUES (N'7', N'B7', N'Camel Box', 3, 0, 20, CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 25, 10, 200, 1, 1)
INSERT [dbo].[Productos] ([CodigoProducto], [CodigoBulto], [NombreProducto], [CodigoTipoProducto], [Stock], [StockCritico], [PrecioCosto], [PrecioCostoLista], [PrecioVentaMinorista], [PrecioVentaMayorista], [Rentabilidad], [CantidadxBulto], [CodigoProveedor], [CodigoRubro], [Estado]) VALUES (N'8', N'B8', N'Camel KS', 3, 0, 20, CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 25, 10, 200, 1, 1)
INSERT [dbo].[Productos] ([CodigoProducto], [CodigoBulto], [NombreProducto], [CodigoTipoProducto], [Stock], [StockCritico], [PrecioCosto], [PrecioCostoLista], [PrecioVentaMinorista], [PrecioVentaMayorista], [Rentabilidad], [CantidadxBulto], [CodigoProveedor], [CodigoRubro], [Estado]) VALUES (N'9', N'B9', N'Coca Cola x 600 ml', 8, 0, 48, CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), 100, 12, 300, 1, 1)
/****** Object:  Table [dbo].[Empleados]    Script Date: 06/28/2019 18:26:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Empleados](
	[CodigoEmpleado] [int] NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Apellido] [varchar](50) NULL,
	[Cargo] [varchar](20) NOT NULL,
	[CodigoUsuario] [int] NULL,
	[Estado] [bit] NULL,
 CONSTRAINT [PK_Empleados] PRIMARY KEY CLUSTERED 
(
	[CodigoEmpleado] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Empleados] ([CodigoEmpleado], [Nombre], [Apellido], [Cargo], [CodigoUsuario], [Estado]) VALUES (1, NULL, NULL, N'Vendedor', 2, 1)
INSERT [dbo].[Empleados] ([CodigoEmpleado], [Nombre], [Apellido], [Cargo], [CodigoUsuario], [Estado]) VALUES (2, NULL, NULL, N'Administrador', 1, 1)
/****** Object:  Table [dbo].[Clientes]    Script Date: 06/28/2019 18:26:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Clientes](
	[CodigoCliente] [int] NOT NULL,
	[NombreCliente] [varchar](50) NULL,
	[Apellido] [varchar](50) NULL,
	[CodigoCuentaCorriente] [int] NOT NULL,
	[CodigoDescuento] [int] NOT NULL,
	[CodigoContacto] [int] NULL,
	[Estado] [bit] NULL,
 CONSTRAINT [PK_Clientes] PRIMARY KEY CLUSTERED 
(
	[CodigoCliente] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Clientes] ([CodigoCliente], [NombreCliente], [Apellido], [CodigoCuentaCorriente], [CodigoDescuento], [CodigoContacto], [Estado]) VALUES (0, N'Consumidor Final', N'Consumidor Final', 0, 0, 0, 1)
INSERT [dbo].[Clientes] ([CodigoCliente], [NombreCliente], [Apellido], [CodigoCuentaCorriente], [CodigoDescuento], [CodigoContacto], [Estado]) VALUES (1, N'Alejandra', N'Barrachina', 1, 1, 12, 1)
INSERT [dbo].[Clientes] ([CodigoCliente], [NombreCliente], [Apellido], [CodigoCuentaCorriente], [CodigoDescuento], [CodigoContacto], [Estado]) VALUES (2, N'Federico', N'Lamas', 2, 1, 13, 1)
INSERT [dbo].[Clientes] ([CodigoCliente], [NombreCliente], [Apellido], [CodigoCuentaCorriente], [CodigoDescuento], [CodigoContacto], [Estado]) VALUES (3, N'Martina', N'Barrachina', 3, 2, 14, 1)
INSERT [dbo].[Clientes] ([CodigoCliente], [NombreCliente], [Apellido], [CodigoCuentaCorriente], [CodigoDescuento], [CodigoContacto], [Estado]) VALUES (4, N'Marina', N'Mansilla', 4, 1, 15, 1)
INSERT [dbo].[Clientes] ([CodigoCliente], [NombreCliente], [Apellido], [CodigoCuentaCorriente], [CodigoDescuento], [CodigoContacto], [Estado]) VALUES (1111, N'111', N'111', 5, 3, 16, 0)
/****** Object:  Table [dbo].[ProveedorXImpuesto]    Script Date: 06/28/2019 18:26:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProveedorXImpuesto](
	[CodigoImpuesto] [int] NOT NULL,
	[CodigoProveedor] [int] NOT NULL,
	[Alicuota] [decimal](18, 2) NULL,
	[Estado] [bit] NULL,
 CONSTRAINT [PK_ProveedorXImpuesto] PRIMARY KEY CLUSTERED 
(
	[CodigoImpuesto] ASC,
	[CodigoProveedor] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[ProveedorXImpuesto] ([CodigoImpuesto], [CodigoProveedor], [Alicuota], [Estado]) VALUES (1, 100, CAST(21.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[ProveedorXImpuesto] ([CodigoImpuesto], [CodigoProveedor], [Alicuota], [Estado]) VALUES (1, 200, CAST(21.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[ProveedorXImpuesto] ([CodigoImpuesto], [CodigoProveedor], [Alicuota], [Estado]) VALUES (1, 300, CAST(21.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[ProveedorXImpuesto] ([CodigoImpuesto], [CodigoProveedor], [Alicuota], [Estado]) VALUES (1, 400, CAST(21.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[ProveedorXImpuesto] ([CodigoImpuesto], [CodigoProveedor], [Alicuota], [Estado]) VALUES (1, 500, CAST(21.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[ProveedorXImpuesto] ([CodigoImpuesto], [CodigoProveedor], [Alicuota], [Estado]) VALUES (1, 600, CAST(21.00 AS Decimal(18, 2)), 0)
INSERT [dbo].[ProveedorXImpuesto] ([CodigoImpuesto], [CodigoProveedor], [Alicuota], [Estado]) VALUES (1, 700, CAST(21.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[ProveedorXImpuesto] ([CodigoImpuesto], [CodigoProveedor], [Alicuota], [Estado]) VALUES (1, 800, CAST(21.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[ProveedorXImpuesto] ([CodigoImpuesto], [CodigoProveedor], [Alicuota], [Estado]) VALUES (2, 100, CAST(2.50 AS Decimal(18, 2)), 1)
INSERT [dbo].[ProveedorXImpuesto] ([CodigoImpuesto], [CodigoProveedor], [Alicuota], [Estado]) VALUES (2, 200, CAST(5.50 AS Decimal(18, 2)), 1)
INSERT [dbo].[ProveedorXImpuesto] ([CodigoImpuesto], [CodigoProveedor], [Alicuota], [Estado]) VALUES (2, 300, CAST(3.50 AS Decimal(18, 2)), 1)
INSERT [dbo].[ProveedorXImpuesto] ([CodigoImpuesto], [CodigoProveedor], [Alicuota], [Estado]) VALUES (2, 400, CAST(3.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[ProveedorXImpuesto] ([CodigoImpuesto], [CodigoProveedor], [Alicuota], [Estado]) VALUES (2, 500, CAST(8.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[ProveedorXImpuesto] ([CodigoImpuesto], [CodigoProveedor], [Alicuota], [Estado]) VALUES (2, 600, CAST(3.00 AS Decimal(18, 2)), 0)
INSERT [dbo].[ProveedorXImpuesto] ([CodigoImpuesto], [CodigoProveedor], [Alicuota], [Estado]) VALUES (2, 700, CAST(2.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[ProveedorXImpuesto] ([CodigoImpuesto], [CodigoProveedor], [Alicuota], [Estado]) VALUES (2, 800, CAST(3.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[ProveedorXImpuesto] ([CodigoImpuesto], [CodigoProveedor], [Alicuota], [Estado]) VALUES (3, 300, CAST(5.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[ProveedorXImpuesto] ([CodigoImpuesto], [CodigoProveedor], [Alicuota], [Estado]) VALUES (3, 400, CAST(3.30 AS Decimal(18, 2)), 1)
INSERT [dbo].[ProveedorXImpuesto] ([CodigoImpuesto], [CodigoProveedor], [Alicuota], [Estado]) VALUES (3, 600, CAST(5.00 AS Decimal(18, 2)), 0)
INSERT [dbo].[ProveedorXImpuesto] ([CodigoImpuesto], [CodigoProveedor], [Alicuota], [Estado]) VALUES (3, 1111, CAST(1.00 AS Decimal(18, 2)), 0)
INSERT [dbo].[ProveedorXImpuesto] ([CodigoImpuesto], [CodigoProveedor], [Alicuota], [Estado]) VALUES (4, 300, CAST(1.50 AS Decimal(18, 2)), 1)
INSERT [dbo].[ProveedorXImpuesto] ([CodigoImpuesto], [CodigoProveedor], [Alicuota], [Estado]) VALUES (4, 400, CAST(2.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[ProveedorXImpuesto] ([CodigoImpuesto], [CodigoProveedor], [Alicuota], [Estado]) VALUES (4, 600, CAST(8.00 AS Decimal(18, 2)), 0)
INSERT [dbo].[ProveedorXImpuesto] ([CodigoImpuesto], [CodigoProveedor], [Alicuota], [Estado]) VALUES (4, 1111, CAST(6.00 AS Decimal(18, 2)), 0)
/****** Object:  StoredProcedure [dbo].[SP_CargarDetalleVenta]    Script Date: 06/28/2019 18:26:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_CargarDetalleVenta]
@NumeroFactura int,
@NumeroLinea int,
@CodigoProducto varchar(50),
@Unidad int,
@PrecioCosto decimal(18, 2),
@PrecioVentaMinorista decimal(18, 2),
@PrecioVentaMayorista decimal(18, 2),
@CantidadxBulto int,
@Bulto int
AS 
BEGIN 
INSERT INTO DetalleVentas(NumeroFactura,NumeroLinea,CodigoProducto,Unidad,PrecioCosto,PrecioVentaMinorista,PrecioVentaMayorista,CantidadxBulto,Bulto)
SELECT @NumeroFactura, @NumeroLinea, @CodigoProducto, @Unidad, @PrecioCosto, @PrecioVentaMinorista, @PrecioVentaMayorista, @CantidadxBulto, @Bulto 
END
GO
/****** Object:  StoredProcedure [dbo].[SP_CargarDetalleNotaDevolucion]    Script Date: 06/28/2019 18:26:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_CargarDetalleNotaDevolucion]
@NumeroFactura int,
@NumeroLinea int,
@CodigoProducto varchar(50),
@Unidad int,
@PrecioCosto decimal(18, 2),
@PrecioVentaMinorista decimal(18, 2),
@PrecioVentaMayorista decimal(18, 2),
@CantidadxBulto int,
@Bulto int
AS 
BEGIN 
INSERT INTO DetalleNotaDevolucion(NumeroFactura,NumeroLinea,CodigoProducto,Unidad,PrecioCosto,PrecioVentaMinorista,PrecioVentaMayorista,CantidadxBulto,Bulto)  
SELECT @NumeroFactura,@NumeroLinea,@CodigoProducto,@Unidad,@PrecioCosto,@PrecioVentaMinorista,@PrecioVentaMayorista n,@CantidadxBulto,@Bulto END
GO
/****** Object:  StoredProcedure [dbo].[SP_CargarDetallaCompra]    Script Date: 06/28/2019 18:26:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_CargarDetallaCompra]

@NumeroFactura int, 
@NumeroLinea int, 
@CodigoProducto varchar(50), 
@Cantidad int, 
@PrecioCosto decimal(18, 2), 
@PrecioVentaMinorista decimal(18, 2), 
@PrecioVentaMayorista decimal(18, 2), 
@Rentabilidad decimal(18, 2)

AS  BEGIN  INSERT INTO DetalleCompras (NumeroFactura,NumeroLinea,CodigoProducto,Cantidad,PrecioCosto,PrecioVentaMayorista,PrecioVentaMinorista,Rentabilidad)  
SELECT @NumeroFactura,@NumeroLinea,@CodigoProducto,@Cantidad,@PrecioCosto,@PrecioVentaMayorista, @PrecioVentaMinorista,@Rentabilidad END
GO
/****** Object:  StoredProcedure [dbo].[SP_ModificarImpuestoXProveedor]    Script Date: 06/28/2019 18:26:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_ModificarImpuestoXProveedor]
@CodigoProveedor int,
@CodigoImpuesto int,
@Alicuota decimal(18,2)
AS 
BEGIN  
UPDATE ProveedorXImpuesto SET 
Estado= 1,
Alicuota = @Alicuota
WHERE CodigoImpuesto=@CodigoImpuesto AND CodigoProveedor=@CodigoProveedor
END
GO
/****** Object:  StoredProcedure [dbo].[SP_ListarVentas]    Script Date: 06/28/2019 18:26:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_ListarVentas]
as
begin
Select NumeroVenta,Usuarios.Nombre,Clientes.NombreCliente,Fecha, Total, MetodoPago from Ventas INNER JOIN Usuarios ON Usuarios.CodigoUsuario = Ventas.Usuario INNER JOIN
Clientes ON Ventas.Cliente = Clientes.CodigoCliente
end
GO
/****** Object:  StoredProcedure [dbo].[SP_FiltrarProductoxProveedor]    Script Date: 06/28/2019 18:26:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_FiltrarProductoxProveedor]
@CodigoProveedor int
AS 
BEGIN 
SELECT * from Productos where CodigoProveedor = @CodigoProveedor
END
GO
/****** Object:  StoredProcedure [dbo].[SP_EliminarProducto]    Script Date: 06/28/2019 18:26:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_EliminarProducto] @CodigoProducto int
as
begin
update Productos set Estado = 0 where CodigoProducto= @CodigoProducto
end
GO
/****** Object:  StoredProcedure [dbo].[SP_BajaStock]    Script Date: 06/28/2019 18:26:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_BajaStock]
@CodigoProducto varchar(50),
@Cantidad int
AS 
BEGIN 
UPDATE Productos SET Stock = (select SUM(Productos.Stock- @Cantidad)from Productos WHERE CodigoProducto = @CodigoProducto) where CodigoProducto=@CodigoProducto
END
GO
/****** Object:  StoredProcedure [dbo].[SP_BajaImpuestosXProveedor]    Script Date: 06/28/2019 18:26:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_BajaImpuestosXProveedor] 
@CodigoProveedor int
AS 
BEGIN  
UPDATE ProveedorXImpuesto SET Estado= 0 WHERE CodigoProveedor=@CodigoProveedor END
GO
/****** Object:  StoredProcedure [dbo].[SP_AltaStock]    Script Date: 06/28/2019 18:26:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_AltaStock]
@CodigoProducto varchar(50),
@Cantidad int
AS 
BEGIN 
UPDATE Productos SET Stock = (select SUM(Productos.Stock+ @Cantidad)from Productos WHERE CodigoProducto = @CodigoProducto) where CodigoProducto=@CodigoProducto
END
GO
/****** Object:  StoredProcedure [dbo].[SP_ActualizarPrecio]    Script Date: 06/28/2019 18:26:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_ActualizarPrecio]
@CodigoProducto varchar(50),
@PrecioVentaMayorista decimal(18,2),
@PrecioVentaMinorista decimal(18,2),
@PrecioCostoLista decimal(18,2),
@PrecioCosto decimal(18,2)
AS
BEGIN
UPDATE Productos SET 
PrecioVentaMayorista = @PrecioVentaMayorista,
PrecioVentaMinorista = @PrecioVentaMinorista,
PrecioCostoLista = @PrecioCostoLista,
PrecioCosto = @PrecioCosto
WHERE CodigoProducto = @CodigoProducto
END
GO
/****** Object:  Default [DF__Clientes__Estado__1ED998B2]    Script Date: 06/28/2019 18:26:32 ******/
ALTER TABLE [dbo].[Clientes] ADD  CONSTRAINT [DF__Clientes__Estado__1ED998B2]  DEFAULT ((1)) FOR [Estado]
GO
/****** Object:  Default [DF_Compras_Fecha]    Script Date: 06/28/2019 18:26:32 ******/
ALTER TABLE [dbo].[Compras] ADD  CONSTRAINT [DF_Compras_Fecha]  DEFAULT (getdate()) FOR [Fecha]
GO
/****** Object:  Default [DF__Condicion__Estad__49C3F6B7]    Script Date: 06/28/2019 18:26:32 ******/
ALTER TABLE [dbo].[CondicionesIVA] ADD  DEFAULT ((1)) FOR [Estado]
GO
/****** Object:  Default [DF_Contactos_Estado]    Script Date: 06/28/2019 18:26:32 ******/
ALTER TABLE [dbo].[Contactos] ADD  CONSTRAINT [DF_Contactos_Estado]  DEFAULT ((1)) FOR [Estado]
GO
/****** Object:  Default [DF__CuentaCor__Saldo__1920BF5C]    Script Date: 06/28/2019 18:26:32 ******/
ALTER TABLE [dbo].[CuentaCorrientes] ADD  CONSTRAINT [DF__CuentaCor__Saldo__1920BF5C]  DEFAULT ((0)) FOR [Saldo]
GO
/****** Object:  Default [DF__CuentaCor__Limit__1A14E395]    Script Date: 06/28/2019 18:26:32 ******/
ALTER TABLE [dbo].[CuentaCorrientes] ADD  CONSTRAINT [DF__CuentaCor__Limit__1A14E395]  DEFAULT ((2000)) FOR [LimiteCuenta]
GO
/****** Object:  Default [DF_CuentaCorrientes_Estado]    Script Date: 06/28/2019 18:26:32 ******/
ALTER TABLE [dbo].[CuentaCorrientes] ADD  CONSTRAINT [DF_CuentaCorrientes_Estado]  DEFAULT ((1)) FOR [Estado]
GO
/****** Object:  Default [DF__Descuento__Estad__0425A276]    Script Date: 06/28/2019 18:26:32 ******/
ALTER TABLE [dbo].[Descuentos] ADD  CONSTRAINT [DF__Descuento__Estad__0425A276]  DEFAULT ((1)) FOR [Estado]
GO
/****** Object:  Default [DF_Direcciones_Estado]    Script Date: 06/28/2019 18:26:32 ******/
ALTER TABLE [dbo].[Direcciones] ADD  CONSTRAINT [DF_Direcciones_Estado]  DEFAULT ((1)) FOR [Estado]
GO
/****** Object:  Default [DF__Empleados__Estad__145C0A3F]    Script Date: 06/28/2019 18:26:32 ******/
ALTER TABLE [dbo].[Empleados] ADD  CONSTRAINT [DF__Empleados__Estad__145C0A3F]  DEFAULT ((1)) FOR [Estado]
GO
/****** Object:  Default [DF__FormasPag__Estad__1273C1CD]    Script Date: 06/28/2019 18:26:32 ******/
ALTER TABLE [dbo].[FormasPago] ADD  CONSTRAINT [DF__FormasPag__Estad__1273C1CD]  DEFAULT ((1)) FOR [Estado]
GO
/****** Object:  Default [DF__Impuestos__Estad__108B795B]    Script Date: 06/28/2019 18:26:32 ******/
ALTER TABLE [dbo].[Impuestos] ADD  CONSTRAINT [DF__Impuestos__Estad__108B795B]  DEFAULT ((1)) FOR [Estado]
GO
/****** Object:  Default [DF__Productos__Stock__24927208]    Script Date: 06/28/2019 18:26:32 ******/
ALTER TABLE [dbo].[Productos] ADD  CONSTRAINT [DF__Productos__Stock__24927208]  DEFAULT ((0)) FOR [Stock]
GO
/****** Object:  Default [DF__Productos__Preci__25869641]    Script Date: 06/28/2019 18:26:32 ******/
ALTER TABLE [dbo].[Productos] ADD  CONSTRAINT [DF__Productos__Preci__25869641]  DEFAULT ((0)) FOR [PrecioCosto]
GO
/****** Object:  Default [DF__Productos__Preci__267ABA7A]    Script Date: 06/28/2019 18:26:32 ******/
ALTER TABLE [dbo].[Productos] ADD  CONSTRAINT [DF__Productos__Preci__267ABA7A]  DEFAULT ((0)) FOR [PrecioCostoLista]
GO
/****** Object:  Default [DF__Productos__Preci__276EDEB3]    Script Date: 06/28/2019 18:26:32 ******/
ALTER TABLE [dbo].[Productos] ADD  CONSTRAINT [DF__Productos__Preci__276EDEB3]  DEFAULT ((0)) FOR [PrecioVentaMinorista]
GO
/****** Object:  Default [DF__Productos__Preci__286302EC]    Script Date: 06/28/2019 18:26:32 ******/
ALTER TABLE [dbo].[Productos] ADD  CONSTRAINT [DF__Productos__Preci__286302EC]  DEFAULT ((0)) FOR [PrecioVentaMayorista]
GO
/****** Object:  Default [DF__Productos__Estad__29572725]    Script Date: 06/28/2019 18:26:32 ******/
ALTER TABLE [dbo].[Productos] ADD  CONSTRAINT [DF__Productos__Estad__29572725]  DEFAULT ((1)) FOR [Estado]
GO
/****** Object:  Default [DF__Proveedor__Estad__0BC6C43E]    Script Date: 06/28/2019 18:26:32 ******/
ALTER TABLE [dbo].[Proveedores] ADD  CONSTRAINT [DF__Proveedor__Estad__0BC6C43E]  DEFAULT ((1)) FOR [Estado]
GO
/****** Object:  Default [DF_ProveedorXImpuesto_Estado]    Script Date: 06/28/2019 18:26:32 ******/
ALTER TABLE [dbo].[ProveedorXImpuesto] ADD  CONSTRAINT [DF_ProveedorXImpuesto_Estado]  DEFAULT ((1)) FOR [Estado]
GO
/****** Object:  Default [DF__Rubros__Estado__09DE7BCC]    Script Date: 06/28/2019 18:26:32 ******/
ALTER TABLE [dbo].[Rubros] ADD  CONSTRAINT [DF__Rubros__Estado__09DE7BCC]  DEFAULT ((1)) FOR [Estado]
GO
/****** Object:  Default [DF__TipoProdu__Estad__023D5A04]    Script Date: 06/28/2019 18:26:32 ******/
ALTER TABLE [dbo].[TipoProductos] ADD  CONSTRAINT [DF__TipoProdu__Estad__023D5A04]  DEFAULT ((1)) FOR [Estado]
GO
/****** Object:  Default [DF__Usuarios__Estado__00551192]    Script Date: 06/28/2019 18:26:32 ******/
ALTER TABLE [dbo].[Usuarios] ADD  CONSTRAINT [DF__Usuarios__Estado__00551192]  DEFAULT ((1)) FOR [Estado]
GO
/****** Object:  Default [DF_Ventas_Usuario]    Script Date: 06/28/2019 18:26:32 ******/
ALTER TABLE [dbo].[Ventas] ADD  CONSTRAINT [DF_Ventas_Usuario]  DEFAULT ((0)) FOR [Usuario]
GO
/****** Object:  Default [DF_Ventas_Fecha]    Script Date: 06/28/2019 18:26:32 ******/
ALTER TABLE [dbo].[Ventas] ADD  CONSTRAINT [DF_Ventas_Fecha]  DEFAULT (getdate()) FOR [Fecha]
GO
/****** Object:  ForeignKey [FK_Clientes_Descuentos]    Script Date: 06/28/2019 18:26:32 ******/
ALTER TABLE [dbo].[Clientes]  WITH CHECK ADD  CONSTRAINT [FK_Clientes_Descuentos] FOREIGN KEY([CodigoDescuento])
REFERENCES [dbo].[Descuentos] ([CodigoDescuento])
GO
ALTER TABLE [dbo].[Clientes] CHECK CONSTRAINT [FK_Clientes_Descuentos]
GO
/****** Object:  ForeignKey [FK_Empleados_Usuarios]    Script Date: 06/28/2019 18:26:32 ******/
ALTER TABLE [dbo].[Empleados]  WITH CHECK ADD  CONSTRAINT [FK_Empleados_Usuarios] FOREIGN KEY([CodigoUsuario])
REFERENCES [dbo].[Usuarios] ([CodigoUsuario])
GO
ALTER TABLE [dbo].[Empleados] CHECK CONSTRAINT [FK_Empleados_Usuarios]
GO
/****** Object:  ForeignKey [FK_Productos_Rubros]    Script Date: 06/28/2019 18:26:32 ******/
ALTER TABLE [dbo].[Productos]  WITH CHECK ADD  CONSTRAINT [FK_Productos_Rubros] FOREIGN KEY([CodigoRubro])
REFERENCES [dbo].[Rubros] ([CodigoRubro])
GO
ALTER TABLE [dbo].[Productos] CHECK CONSTRAINT [FK_Productos_Rubros]
GO
/****** Object:  ForeignKey [FK_Productos_TipoProductos]    Script Date: 06/28/2019 18:26:32 ******/
ALTER TABLE [dbo].[Productos]  WITH CHECK ADD  CONSTRAINT [FK_Productos_TipoProductos] FOREIGN KEY([CodigoTipoProducto])
REFERENCES [dbo].[TipoProductos] ([CodigoTipoProducto])
GO
ALTER TABLE [dbo].[Productos] CHECK CONSTRAINT [FK_Productos_TipoProductos]
GO
/****** Object:  ForeignKey [FK_ProveedorXImpuesto_Impuestos]    Script Date: 06/28/2019 18:26:32 ******/
ALTER TABLE [dbo].[ProveedorXImpuesto]  WITH CHECK ADD  CONSTRAINT [FK_ProveedorXImpuesto_Impuestos] FOREIGN KEY([CodigoImpuesto])
REFERENCES [dbo].[Impuestos] ([CodigoImpuesto])
GO
ALTER TABLE [dbo].[ProveedorXImpuesto] CHECK CONSTRAINT [FK_ProveedorXImpuesto_Impuestos]
GO
