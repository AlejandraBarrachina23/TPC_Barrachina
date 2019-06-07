USE [BARRACHINA_DB]
GO
/****** Object:  Table [dbo].[TipoProductos]    Script Date: 06/07/2019 01:42:40 ******/
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
/****** Object:  Table [dbo].[Proveedores]    Script Date: 06/07/2019 01:42:40 ******/
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
INSERT [dbo].[Proveedores] ([CodigoProveedor], [RazonSocial], [NumeroCUIT], [NombreFantasia], [CodigoCondicionIVA], [CodigoContacto], [Estado]) VALUES (100, N'Marta Barrachina', N'2700000', N'Sam', 2, 3, 0)
INSERT [dbo].[Proveedores] ([CodigoProveedor], [RazonSocial], [NumeroCUIT], [NombreFantasia], [CodigoCondicionIVA], [CodigoContacto], [Estado]) VALUES (200, N'Federrico Lamas', N'275484849446', N'Barba Dragon', 2, 4, 0)
/****** Object:  Table [dbo].[Sectores]    Script Date: 06/07/2019 01:42:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Sectores](
	[CodigoSector] [int] NOT NULL,
	[Nombre] [varchar](20) NOT NULL,
	[Estado] [bit] NULL,
 CONSTRAINT [PK_Sectores] PRIMARY KEY CLUSTERED 
(
	[CodigoSector] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Sectores] ([CodigoSector], [Nombre], [Estado]) VALUES (1, N'Compra', 1)
INSERT [dbo].[Sectores] ([CodigoSector], [Nombre], [Estado]) VALUES (2, N'Venta', 1)
INSERT [dbo].[Sectores] ([CodigoSector], [Nombre], [Estado]) VALUES (3, N'Deposito', 0)
INSERT [dbo].[Sectores] ([CodigoSector], [Nombre], [Estado]) VALUES (4, N'Administracion', 1)
/****** Object:  Table [dbo].[Rubros]    Script Date: 06/07/2019 01:42:40 ******/
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
INSERT [dbo].[Rubros] ([CodigoRubro], [NombreRubro], [Estado]) VALUES (1, N'Kiosco', 0)
INSERT [dbo].[Rubros] ([CodigoRubro], [NombreRubro], [Estado]) VALUES (2, N'Almacen Comestible', 0)
INSERT [dbo].[Rubros] ([CodigoRubro], [NombreRubro], [Estado]) VALUES (3, N'Almacen Limpieza', 1)
INSERT [dbo].[Rubros] ([CodigoRubro], [NombreRubro], [Estado]) VALUES (4, N'Perfumeria', 0)
INSERT [dbo].[Rubros] ([CodigoRubro], [NombreRubro], [Estado]) VALUES (9, N'Cyber', 1)
INSERT [dbo].[Rubros] ([CodigoRubro], [NombreRubro], [Estado]) VALUES (12, N'Almacen', 1)
/****** Object:  Table [dbo].[MotivosDevolucion]    Script Date: 06/07/2019 01:42:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MotivosDevolucion](
	[CodigoMotivoDevolucion] [int] NOT NULL,
	[Nombre] [varchar](30) NOT NULL,
	[Descripcion] [text] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Impuestos]    Script Date: 06/07/2019 01:42:40 ******/
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
INSERT [dbo].[Impuestos] ([CodigoImpuesto], [Nombre], [Descripcion], [Estado]) VALUES (2, N'IB', N'Ingresos Brutos', 0)
INSERT [dbo].[Impuestos] ([CodigoImpuesto], [Nombre], [Descripcion], [Estado]) VALUES (3, N'IVA RES 3337', N'Agentes de Retención IVA', 1)
INSERT [dbo].[Impuestos] ([CodigoImpuesto], [Nombre], [Descripcion], [Estado]) VALUES (8, N'II', N'Impuesto Interno', 1)
/****** Object:  Table [dbo].[FormasPago]    Script Date: 06/07/2019 01:42:40 ******/
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
/****** Object:  Table [dbo].[Direcciones]    Script Date: 06/07/2019 01:42:40 ******/
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
INSERT [dbo].[Direcciones] ([CodigoDireccion], [Calle], [Numero], [CodigoPostal], [Localidad], [Provincia], [Estado]) VALUES (1, N'Gral peyrredon', 20, 222, N'222', N'2222', 0)
INSERT [dbo].[Direcciones] ([CodigoDireccion], [Calle], [Numero], [CodigoPostal], [Localidad], [Provincia], [Estado]) VALUES (2, N'Almundo', 44564, 54, N'San Fernando', N'Buenos Aires', 0)
INSERT [dbo].[Direcciones] ([CodigoDireccion], [Calle], [Numero], [CodigoPostal], [Localidad], [Provincia], [Estado]) VALUES (3, N'Maipu', 2045, 16467, N'San Fernandos', N'Buenos Aires', 0)
INSERT [dbo].[Direcciones] ([CodigoDireccion], [Calle], [Numero], [CodigoPostal], [Localidad], [Provincia], [Estado]) VALUES (4, N'Av Salvador del Carril', 2281, 7505, N'Villa Pueyrredon', N'Buenos Aires', 0)
INSERT [dbo].[Direcciones] ([CodigoDireccion], [Calle], [Numero], [CodigoPostal], [Localidad], [Provincia], [Estado]) VALUES (5, N'Maipu 4000', 400, 400, N'40000', N'400000', 1)
SET IDENTITY_INSERT [dbo].[Direcciones] OFF
/****** Object:  Table [dbo].[Descuentos]    Script Date: 06/07/2019 01:42:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Descuentos](
	[CodigoDescuento] [int] NOT NULL,
	[NombreDescuento] [varchar](50) NOT NULL,
	[Porcentaje] [decimal](18, 0) NOT NULL,
	[Estado] [bit] NULL,
 CONSTRAINT [PK_Descuentos] PRIMARY KEY CLUSTERED 
(
	[CodigoDescuento] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Descuentos] ([CodigoDescuento], [NombreDescuento], [Porcentaje], [Estado]) VALUES (1, N'ClienteBasico', CAST(23 AS Decimal(18, 0)), 1)
INSERT [dbo].[Descuentos] ([CodigoDescuento], [NombreDescuento], [Porcentaje], [Estado]) VALUES (2, N'ClientePremium', CAST(10 AS Decimal(18, 0)), 0)
INSERT [dbo].[Descuentos] ([CodigoDescuento], [NombreDescuento], [Porcentaje], [Estado]) VALUES (3, N'ClienteDistribuidora', CAST(15 AS Decimal(18, 0)), 1)
INSERT [dbo].[Descuentos] ([CodigoDescuento], [NombreDescuento], [Porcentaje], [Estado]) VALUES (8, N'ClienteBasicoIntermedio', CAST(25 AS Decimal(18, 0)), 1)
INSERT [dbo].[Descuentos] ([CodigoDescuento], [NombreDescuento], [Porcentaje], [Estado]) VALUES (555, N'ClientePocoHabitual', CAST(35 AS Decimal(18, 0)), 1)
/****** Object:  Table [dbo].[CuentaCorrientes]    Script Date: 06/07/2019 01:42:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CuentaCorrientes](
	[CodigoCuentaCorriente] [int] IDENTITY(1,1) NOT NULL,
	[Saldo] [decimal](18, 0) NULL,
	[LimiteCuenta] [decimal](18, 0) NULL,
	[Estado] [bit] NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[CuentaCorrientes] ON
INSERT [dbo].[CuentaCorrientes] ([CodigoCuentaCorriente], [Saldo], [LimiteCuenta], [Estado]) VALUES (1, CAST(0 AS Decimal(18, 0)), CAST(3000 AS Decimal(18, 0)), 0)
INSERT [dbo].[CuentaCorrientes] ([CodigoCuentaCorriente], [Saldo], [LimiteCuenta], [Estado]) VALUES (2, CAST(0 AS Decimal(18, 0)), CAST(2000 AS Decimal(18, 0)), 0)
INSERT [dbo].[CuentaCorrientes] ([CodigoCuentaCorriente], [Saldo], [LimiteCuenta], [Estado]) VALUES (3, CAST(0 AS Decimal(18, 0)), CAST(4000 AS Decimal(18, 0)), 1)
SET IDENTITY_INSERT [dbo].[CuentaCorrientes] OFF
/****** Object:  Table [dbo].[Contactos]    Script Date: 06/07/2019 01:42:40 ******/
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
INSERT [dbo].[Contactos] ([CodigoContacto], [Telefono], [Celular], [Mail], [CodigoDireccion], [Estado]) VALUES (1, N'1147464132', N'1130380444', N'alejandrabarrachina23@gmail.com', 1, 0)
INSERT [dbo].[Contactos] ([CodigoContacto], [Telefono], [Celular], [Mail], [CodigoDireccion], [Estado]) VALUES (2, N'114756324', N'114578648', N'elena.magallanes@gmail.com', 2, 0)
INSERT [dbo].[Contactos] ([CodigoContacto], [Telefono], [Celular], [Mail], [CodigoDireccion], [Estado]) VALUES (3, N'11111', N'22222', N'martina.barrachina23@gmail.com', 3, 0)
INSERT [dbo].[Contactos] ([CodigoContacto], [Telefono], [Celular], [Mail], [CodigoDireccion], [Estado]) VALUES (4, N'1147463244', N'1130384455', N'federico.lamas@gmail.com', 4, 0)
INSERT [dbo].[Contactos] ([CodigoContacto], [Telefono], [Celular], [Mail], [CodigoDireccion], [Estado]) VALUES (5, N'40000', N'40000', N'Martina.Rama400@gmail.com', 5, 1)
SET IDENTITY_INSERT [dbo].[Contactos] OFF
/****** Object:  Table [dbo].[CondicionesIVA]    Script Date: 06/07/2019 01:42:40 ******/
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
SET IDENTITY_INSERT [dbo].[CondicionesIVA] OFF
/****** Object:  Table [dbo].[Usuarios]    Script Date: 06/07/2019 01:42:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Usuarios](
	[CodigoUsuario] [int] NOT NULL,
	[Nombre] [varchar](30) NOT NULL,
	[Constrasenia] [varchar](30) NOT NULL,
	[CodigoSector] [int] NOT NULL,
	[Estado] [bit] NULL,
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[CodigoUsuario] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Usuarios] ([CodigoUsuario], [Nombre], [Constrasenia], [CodigoSector], [Estado]) VALUES (1, N'Alejandra', N'1234', 4, 1)
INSERT [dbo].[Usuarios] ([CodigoUsuario], [Nombre], [Constrasenia], [CodigoSector], [Estado]) VALUES (2, N'Federico', N'4321', 1, 1)
INSERT [dbo].[Usuarios] ([CodigoUsuario], [Nombre], [Constrasenia], [CodigoSector], [Estado]) VALUES (3, N'Pedro', N'1111', 2, 1)
/****** Object:  Table [dbo].[Clientes]    Script Date: 06/07/2019 01:42:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Clientes](
	[CodigoCliente] [int] NOT NULL,
	[Nombre] [varchar](50) NULL,
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
INSERT [dbo].[Clientes] ([CodigoCliente], [Nombre], [Apellido], [CodigoCuentaCorriente], [CodigoDescuento], [CodigoContacto], [Estado]) VALUES (1000, N'Maria Antonieta', N'De las Nieves', 1, 2, 1, 0)
INSERT [dbo].[Clientes] ([CodigoCliente], [Nombre], [Apellido], [CodigoCuentaCorriente], [CodigoDescuento], [CodigoContacto], [Estado]) VALUES (1002, N'Elena', N'Magallanes', 2, 1, 2, 0)
INSERT [dbo].[Clientes] ([CodigoCliente], [Nombre], [Apellido], [CodigoCuentaCorriente], [CodigoDescuento], [CodigoContacto], [Estado]) VALUES (3000, N'Martina Florencia', N'Ramas', 3, 1, 5, 1)
/****** Object:  Table [dbo].[ProveedorXImpuesto]    Script Date: 06/07/2019 01:42:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProveedorXImpuesto](
	[CodigoImpuesto] [int] NOT NULL,
	[CodigoProveedor] [int] NOT NULL,
	[Alicuota] [decimal](18, 0) NULL,
 CONSTRAINT [PK_ProveedorXImpuesto] PRIMARY KEY CLUSTERED 
(
	[CodigoImpuesto] ASC,
	[CodigoProveedor] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[ProveedorXImpuesto] ([CodigoImpuesto], [CodigoProveedor], [Alicuota]) VALUES (1, 100, CAST(21 AS Decimal(18, 0)))
INSERT [dbo].[ProveedorXImpuesto] ([CodigoImpuesto], [CodigoProveedor], [Alicuota]) VALUES (1, 200, CAST(21 AS Decimal(18, 0)))
INSERT [dbo].[ProveedorXImpuesto] ([CodigoImpuesto], [CodigoProveedor], [Alicuota]) VALUES (2, 100, CAST(5 AS Decimal(18, 0)))
INSERT [dbo].[ProveedorXImpuesto] ([CodigoImpuesto], [CodigoProveedor], [Alicuota]) VALUES (2, 200, CAST(5 AS Decimal(18, 0)))
INSERT [dbo].[ProveedorXImpuesto] ([CodigoImpuesto], [CodigoProveedor], [Alicuota]) VALUES (3, 200, CAST(2 AS Decimal(18, 0)))
/****** Object:  Table [dbo].[Productos]    Script Date: 06/07/2019 01:42:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Productos](
	[CodigoProducto] [varchar](50) NOT NULL,
	[CodigoBulto] [varchar](50) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[CodigoTipoProducto] [int] NOT NULL,
	[Stock] [int] NULL,
	[StockCritico] [int] NOT NULL,
	[PrecioCosto] [decimal](18, 0) NULL,
	[PrecioCostoLista] [decimal](18, 0) NULL,
	[PrecioVentaMinorista] [decimal](18, 0) NULL,
	[PrecioVentaMayorista] [decimal](18, 0) NULL,
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
INSERT [dbo].[Productos] ([CodigoProducto], [CodigoBulto], [Nombre], [CodigoTipoProducto], [Stock], [StockCritico], [PrecioCosto], [PrecioCostoLista], [PrecioVentaMinorista], [PrecioVentaMayorista], [CantidadxBulto], [CodigoProveedor], [CodigoRubro], [Estado]) VALUES (N'10', N'110', N'Beldent chicle globo', 4, 0, 40, CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), 20, 100, 1, 0)
INSERT [dbo].[Productos] ([CodigoProducto], [CodigoBulto], [Nombre], [CodigoTipoProducto], [Stock], [StockCritico], [PrecioCosto], [PrecioCostoLista], [PrecioVentaMinorista], [PrecioVentaMayorista], [CantidadxBulto], [CodigoProveedor], [CodigoRubro], [Estado]) VALUES (N'2', N'20', N'Beldent', 4, 0, 100, CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), 20, 100, 1, 0)
INSERT [dbo].[Productos] ([CodigoProducto], [CodigoBulto], [Nombre], [CodigoTipoProducto], [Stock], [StockCritico], [PrecioCosto], [PrecioCostoLista], [PrecioVentaMinorista], [PrecioVentaMayorista], [CantidadxBulto], [CodigoProveedor], [CodigoRubro], [Estado]) VALUES (N'3', N'30', N'Beldent tutti-fruttiss', 4, 0, 60, CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), 20, 100, 1, 1)
INSERT [dbo].[Productos] ([CodigoProducto], [CodigoBulto], [Nombre], [CodigoTipoProducto], [Stock], [StockCritico], [PrecioCosto], [PrecioCostoLista], [PrecioVentaMinorista], [PrecioVentaMayorista], [CantidadxBulto], [CodigoProveedor], [CodigoRubro], [Estado]) VALUES (N'4', N'100', N'Beldent mix', 4, 0, 20, CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), 20, 100, 1, 1)
INSERT [dbo].[Productos] ([CodigoProducto], [CodigoBulto], [Nombre], [CodigoTipoProducto], [Stock], [StockCritico], [PrecioCosto], [PrecioCostoLista], [PrecioVentaMinorista], [PrecioVentaMayorista], [CantidadxBulto], [CodigoProveedor], [CodigoRubro], [Estado]) VALUES (N'5', N'50', N'Beldent frutilla', 4, 0, 20, CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), 20, 200, 1, 1)
INSERT [dbo].[Productos] ([CodigoProducto], [CodigoBulto], [Nombre], [CodigoTipoProducto], [Stock], [StockCritico], [PrecioCosto], [PrecioCostoLista], [PrecioVentaMinorista], [PrecioVentaMayorista], [CantidadxBulto], [CodigoProveedor], [CodigoRubro], [Estado]) VALUES (N'6', N'60', N'Beldent mento turbo', 3, 0, 20, CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), 20, 200, 1, 1)
INSERT [dbo].[Productos] ([CodigoProducto], [CodigoBulto], [Nombre], [CodigoTipoProducto], [Stock], [StockCritico], [PrecioCosto], [PrecioCostoLista], [PrecioVentaMinorista], [PrecioVentaMayorista], [CantidadxBulto], [CodigoProveedor], [CodigoRubro], [Estado]) VALUES (N'7', N'70', N'Beldent menta fuerte', 4, 0, 60, CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), 20, 200, 1, 1)
INSERT [dbo].[Productos] ([CodigoProducto], [CodigoBulto], [Nombre], [CodigoTipoProducto], [Stock], [StockCritico], [PrecioCosto], [PrecioCostoLista], [PrecioVentaMinorista], [PrecioVentaMayorista], [CantidadxBulto], [CodigoProveedor], [CodigoRubro], [Estado]) VALUES (N'7790580222109', N'10', N'Beldent menta', 4, 0, 60, CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), 20, 100, 1, 0)
INSERT [dbo].[Productos] ([CodigoProducto], [CodigoBulto], [Nombre], [CodigoTipoProducto], [Stock], [StockCritico], [PrecioCosto], [PrecioCostoLista], [PrecioVentaMinorista], [PrecioVentaMayorista], [CantidadxBulto], [CodigoProveedor], [CodigoRubro], [Estado]) VALUES (N'8', N'80', N'Beldent mentol', 4, 0, 20, CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), 20, 200, 1, 1)
INSERT [dbo].[Productos] ([CodigoProducto], [CodigoBulto], [Nombre], [CodigoTipoProducto], [Stock], [StockCritico], [PrecioCosto], [PrecioCostoLista], [PrecioVentaMinorista], [PrecioVentaMayorista], [CantidadxBulto], [CodigoProveedor], [CodigoRubro], [Estado]) VALUES (N'9', N'90', N'Beldent citrus', 4, 0, 20, CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), 20, 100, 1, 1)
/****** Object:  StoredProcedure [dbo].[SP_EliminarProducto]    Script Date: 06/07/2019 01:42:40 ******/
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
/****** Object:  Table [dbo].[Empleados]    Script Date: 06/07/2019 01:42:40 ******/
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
/****** Object:  Default [DF__Clientes__Estado__1ED998B2]    Script Date: 06/07/2019 01:42:40 ******/
ALTER TABLE [dbo].[Clientes] ADD  CONSTRAINT [DF__Clientes__Estado__1ED998B2]  DEFAULT ((1)) FOR [Estado]
GO
/****** Object:  Default [DF__Condicion__Estad__49C3F6B7]    Script Date: 06/07/2019 01:42:40 ******/
ALTER TABLE [dbo].[CondicionesIVA] ADD  DEFAULT ((1)) FOR [Estado]
GO
/****** Object:  Default [DF_Contactos_Estado]    Script Date: 06/07/2019 01:42:40 ******/
ALTER TABLE [dbo].[Contactos] ADD  CONSTRAINT [DF_Contactos_Estado]  DEFAULT ((1)) FOR [Estado]
GO
/****** Object:  Default [DF__CuentaCor__Saldo__1920BF5C]    Script Date: 06/07/2019 01:42:40 ******/
ALTER TABLE [dbo].[CuentaCorrientes] ADD  CONSTRAINT [DF__CuentaCor__Saldo__1920BF5C]  DEFAULT ((0)) FOR [Saldo]
GO
/****** Object:  Default [DF__CuentaCor__Limit__1A14E395]    Script Date: 06/07/2019 01:42:40 ******/
ALTER TABLE [dbo].[CuentaCorrientes] ADD  CONSTRAINT [DF__CuentaCor__Limit__1A14E395]  DEFAULT ((2000)) FOR [LimiteCuenta]
GO
/****** Object:  Default [DF_CuentaCorrientes_Estado]    Script Date: 06/07/2019 01:42:40 ******/
ALTER TABLE [dbo].[CuentaCorrientes] ADD  CONSTRAINT [DF_CuentaCorrientes_Estado]  DEFAULT ((1)) FOR [Estado]
GO
/****** Object:  Default [DF__Descuento__Estad__0425A276]    Script Date: 06/07/2019 01:42:40 ******/
ALTER TABLE [dbo].[Descuentos] ADD  CONSTRAINT [DF__Descuento__Estad__0425A276]  DEFAULT ((1)) FOR [Estado]
GO
/****** Object:  Default [DF_Direcciones_Estado]    Script Date: 06/07/2019 01:42:40 ******/
ALTER TABLE [dbo].[Direcciones] ADD  CONSTRAINT [DF_Direcciones_Estado]  DEFAULT ((1)) FOR [Estado]
GO
/****** Object:  Default [DF__Empleados__Estad__145C0A3F]    Script Date: 06/07/2019 01:42:40 ******/
ALTER TABLE [dbo].[Empleados] ADD  CONSTRAINT [DF__Empleados__Estad__145C0A3F]  DEFAULT ((1)) FOR [Estado]
GO
/****** Object:  Default [DF__FormasPag__Estad__1273C1CD]    Script Date: 06/07/2019 01:42:40 ******/
ALTER TABLE [dbo].[FormasPago] ADD  CONSTRAINT [DF__FormasPag__Estad__1273C1CD]  DEFAULT ((1)) FOR [Estado]
GO
/****** Object:  Default [DF__Impuestos__Estad__108B795B]    Script Date: 06/07/2019 01:42:40 ******/
ALTER TABLE [dbo].[Impuestos] ADD  CONSTRAINT [DF__Impuestos__Estad__108B795B]  DEFAULT ((1)) FOR [Estado]
GO
/****** Object:  Default [DF__Productos__Stock__24927208]    Script Date: 06/07/2019 01:42:40 ******/
ALTER TABLE [dbo].[Productos] ADD  CONSTRAINT [DF__Productos__Stock__24927208]  DEFAULT ((0)) FOR [Stock]
GO
/****** Object:  Default [DF__Productos__Preci__25869641]    Script Date: 06/07/2019 01:42:40 ******/
ALTER TABLE [dbo].[Productos] ADD  CONSTRAINT [DF__Productos__Preci__25869641]  DEFAULT ((0)) FOR [PrecioCosto]
GO
/****** Object:  Default [DF__Productos__Preci__267ABA7A]    Script Date: 06/07/2019 01:42:40 ******/
ALTER TABLE [dbo].[Productos] ADD  CONSTRAINT [DF__Productos__Preci__267ABA7A]  DEFAULT ((0)) FOR [PrecioCostoLista]
GO
/****** Object:  Default [DF__Productos__Preci__276EDEB3]    Script Date: 06/07/2019 01:42:40 ******/
ALTER TABLE [dbo].[Productos] ADD  CONSTRAINT [DF__Productos__Preci__276EDEB3]  DEFAULT ((0)) FOR [PrecioVentaMinorista]
GO
/****** Object:  Default [DF__Productos__Preci__286302EC]    Script Date: 06/07/2019 01:42:40 ******/
ALTER TABLE [dbo].[Productos] ADD  CONSTRAINT [DF__Productos__Preci__286302EC]  DEFAULT ((0)) FOR [PrecioVentaMayorista]
GO
/****** Object:  Default [DF__Productos__Estad__29572725]    Script Date: 06/07/2019 01:42:40 ******/
ALTER TABLE [dbo].[Productos] ADD  CONSTRAINT [DF__Productos__Estad__29572725]  DEFAULT ((1)) FOR [Estado]
GO
/****** Object:  Default [DF__Proveedor__Estad__0BC6C43E]    Script Date: 06/07/2019 01:42:40 ******/
ALTER TABLE [dbo].[Proveedores] ADD  CONSTRAINT [DF__Proveedor__Estad__0BC6C43E]  DEFAULT ((1)) FOR [Estado]
GO
/****** Object:  Default [DF__Rubros__Estado__09DE7BCC]    Script Date: 06/07/2019 01:42:40 ******/
ALTER TABLE [dbo].[Rubros] ADD  CONSTRAINT [DF__Rubros__Estado__09DE7BCC]  DEFAULT ((1)) FOR [Estado]
GO
/****** Object:  Default [DF__Sectores__Estado__07F6335A]    Script Date: 06/07/2019 01:42:40 ******/
ALTER TABLE [dbo].[Sectores] ADD  CONSTRAINT [DF__Sectores__Estado__07F6335A]  DEFAULT ((1)) FOR [Estado]
GO
/****** Object:  Default [DF__TipoProdu__Estad__023D5A04]    Script Date: 06/07/2019 01:42:40 ******/
ALTER TABLE [dbo].[TipoProductos] ADD  CONSTRAINT [DF__TipoProdu__Estad__023D5A04]  DEFAULT ((1)) FOR [Estado]
GO
/****** Object:  Default [DF__Usuarios__Estado__00551192]    Script Date: 06/07/2019 01:42:40 ******/
ALTER TABLE [dbo].[Usuarios] ADD  CONSTRAINT [DF__Usuarios__Estado__00551192]  DEFAULT ((1)) FOR [Estado]
GO
/****** Object:  ForeignKey [FK_Clientes_Descuentos]    Script Date: 06/07/2019 01:42:40 ******/
ALTER TABLE [dbo].[Clientes]  WITH CHECK ADD  CONSTRAINT [FK_Clientes_Descuentos] FOREIGN KEY([CodigoDescuento])
REFERENCES [dbo].[Descuentos] ([CodigoDescuento])
GO
ALTER TABLE [dbo].[Clientes] CHECK CONSTRAINT [FK_Clientes_Descuentos]
GO
/****** Object:  ForeignKey [FK_Empleados_Usuarios]    Script Date: 06/07/2019 01:42:40 ******/
ALTER TABLE [dbo].[Empleados]  WITH CHECK ADD  CONSTRAINT [FK_Empleados_Usuarios] FOREIGN KEY([CodigoUsuario])
REFERENCES [dbo].[Usuarios] ([CodigoUsuario])
GO
ALTER TABLE [dbo].[Empleados] CHECK CONSTRAINT [FK_Empleados_Usuarios]
GO
/****** Object:  ForeignKey [FK_Productos_Rubros]    Script Date: 06/07/2019 01:42:40 ******/
ALTER TABLE [dbo].[Productos]  WITH CHECK ADD  CONSTRAINT [FK_Productos_Rubros] FOREIGN KEY([CodigoRubro])
REFERENCES [dbo].[Rubros] ([CodigoRubro])
GO
ALTER TABLE [dbo].[Productos] CHECK CONSTRAINT [FK_Productos_Rubros]
GO
/****** Object:  ForeignKey [FK_Productos_TipoProductos]    Script Date: 06/07/2019 01:42:40 ******/
ALTER TABLE [dbo].[Productos]  WITH CHECK ADD  CONSTRAINT [FK_Productos_TipoProductos] FOREIGN KEY([CodigoTipoProducto])
REFERENCES [dbo].[TipoProductos] ([CodigoTipoProducto])
GO
ALTER TABLE [dbo].[Productos] CHECK CONSTRAINT [FK_Productos_TipoProductos]
GO
/****** Object:  ForeignKey [FK_ProveedorXImpuesto_Impuestos]    Script Date: 06/07/2019 01:42:40 ******/
ALTER TABLE [dbo].[ProveedorXImpuesto]  WITH CHECK ADD  CONSTRAINT [FK_ProveedorXImpuesto_Impuestos] FOREIGN KEY([CodigoImpuesto])
REFERENCES [dbo].[Impuestos] ([CodigoImpuesto])
GO
ALTER TABLE [dbo].[ProveedorXImpuesto] CHECK CONSTRAINT [FK_ProveedorXImpuesto_Impuestos]
GO
/****** Object:  ForeignKey [FK_Usuarios_Sectores]    Script Date: 06/07/2019 01:42:40 ******/
ALTER TABLE [dbo].[Usuarios]  WITH CHECK ADD  CONSTRAINT [FK_Usuarios_Sectores] FOREIGN KEY([CodigoSector])
REFERENCES [dbo].[Sectores] ([CodigoSector])
GO
ALTER TABLE [dbo].[Usuarios] CHECK CONSTRAINT [FK_Usuarios_Sectores]
GO
