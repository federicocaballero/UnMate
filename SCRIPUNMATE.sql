USE [master]
GO
/****** Object:  Database [UnMate]    Script Date: 12/11/2023 02:23:58 ******/
CREATE DATABASE [UnMate]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'UnMate', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\UnMate.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'UnMate_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\UnMate_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [UnMate] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [UnMate].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [UnMate] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [UnMate] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [UnMate] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [UnMate] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [UnMate] SET ARITHABORT OFF 
GO
ALTER DATABASE [UnMate] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [UnMate] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [UnMate] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [UnMate] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [UnMate] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [UnMate] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [UnMate] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [UnMate] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [UnMate] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [UnMate] SET  ENABLE_BROKER 
GO
ALTER DATABASE [UnMate] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [UnMate] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [UnMate] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [UnMate] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [UnMate] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [UnMate] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [UnMate] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [UnMate] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [UnMate] SET  MULTI_USER 
GO
ALTER DATABASE [UnMate] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [UnMate] SET DB_CHAINING OFF 
GO
ALTER DATABASE [UnMate] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [UnMate] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [UnMate] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [UnMate] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [UnMate] SET QUERY_STORE = ON
GO
ALTER DATABASE [UnMate] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [UnMate]
GO
/****** Object:  Table [dbo].[Categoria]    Script Date: 12/11/2023 02:23:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categoria](
	[ID_Categoria] [int] NOT NULL,
	[Descripcion] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Categoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 12/11/2023 02:23:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[Cod_Cliente] [int] IDENTITY(1,1) NOT NULL,
	[DNI_Cliente] [varchar](80) NULL,
	[Nombre] [varchar](100) NULL,
	[Apellido] [varchar](100) NULL,
	[Email] [varchar](100) NULL,
	[Telefono] [varchar](100) NULL,
	[Alta] [int] NULL,
	[Estado] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Cod_Cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DetalleVenta]    Script Date: 12/11/2023 02:23:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetalleVenta](
	[Cod_Detalle] [int] IDENTITY(1,1) NOT NULL,
	[Cod_Producto] [int] NULL,
	[Cod_Venta] [int] NULL,
	[Precio] [decimal](10, 2) NULL,
	[Cantidad] [int] NULL,
	[Total] [decimal](10, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[Cod_Detalle] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Empleado]    Script Date: 12/11/2023 02:23:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleado](
	[Cod_Empleado] [int] IDENTITY(1,1) NOT NULL,
	[DNI] [varchar](80) NULL,
	[Nombre] [varchar](200) NULL,
	[Apellido] [varchar](100) NULL,
	[Email] [varchar](100) NULL,
	[Contraseña] [varchar](120) NULL,
	[Telefono] [varchar](100) NULL,
	[ID_perfil] [int] NULL,
	[Estado] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Cod_Empleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PedidoProveedor]    Script Date: 12/11/2023 02:23:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PedidoProveedor](
	[Cod_Pedido] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](600) NULL,
	[Cantidad] [bigint] NULL,
	[Cod_Producto] [int] NULL,
	[Cod_Proveedor] [int] NULL,
	[Fecha] [date] NULL,
	[Total] [decimal](18, 2) NULL,
	[Estado] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Cod_Pedido] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Perfil]    Script Date: 12/11/2023 02:23:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Perfil](
	[ID_perfil] [int] NOT NULL,
	[Descripcion] [varchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_perfil] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Producto]    Script Date: 12/11/2023 02:23:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Producto](
	[Cod_producto] [int] IDENTITY(1,1) NOT NULL,
	[Titulo] [varchar](400) NULL,
	[Precio] [decimal](18, 2) NULL,
	[Estado] [int] NULL,
	[Stock] [int] NULL,
	[Descripcion] [varchar](900) NULL,
	[Color] [varchar](30) NULL,
	[ID_Categoria] [int] NULL,
	[Cod_Proveedor] [int] NULL,
	[Imagen] [varbinary](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[Cod_producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Proveedor]    Script Date: 12/11/2023 02:23:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Proveedor](
	[Cod_Proveedor] [int] IDENTITY(1,1) NOT NULL,
	[CUIT] [varchar](80) NULL,
	[Nombre] [varchar](100) NULL,
	[Direccion] [varchar](160) NULL,
	[Email] [varchar](100) NULL,
	[Telefono] [varchar](100) NULL,
	[IVA] [int] NULL,
	[Estado] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Cod_Proveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoIva]    Script Date: 12/11/2023 02:23:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoIva](
	[IVA] [int] NOT NULL,
	[Descripcion] [varchar](80) NULL,
PRIMARY KEY CLUSTERED 
(
	[IVA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoPago]    Script Date: 12/11/2023 02:23:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoPago](
	[Cod_TipoPago] [int] NOT NULL,
	[Descripcion] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[Cod_TipoPago] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Venta]    Script Date: 12/11/2023 02:23:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Venta](
	[Cod_Venta] [int] IDENTITY(1,1) NOT NULL,
	[Fecha] [date] NULL,
	[Total] [decimal](10, 2) NULL,
	[Cod_Cliente] [int] NULL,
	[Cod_Empleado] [int] NULL,
	[Cod_TipoPago] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Cod_Venta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Categoria] ([ID_Categoria], [Descripcion]) VALUES (1, N'Madera')
INSERT [dbo].[Categoria] ([ID_Categoria], [Descripcion]) VALUES (2, N'Calabaza')
INSERT [dbo].[Categoria] ([ID_Categoria], [Descripcion]) VALUES (3, N'Caña')
INSERT [dbo].[Categoria] ([ID_Categoria], [Descripcion]) VALUES (4, N'Cuero')
GO
SET IDENTITY_INSERT [dbo].[Cliente] ON 

INSERT [dbo].[Cliente] ([Cod_Cliente], [DNI_Cliente], [Nombre], [Apellido], [Email], [Telefono], [Alta], [Estado]) VALUES (1, N'1111', N'Cliente1', N'Apellido1', N'cliente1@example.com', N'111111', 20231112, 1)
INSERT [dbo].[Cliente] ([Cod_Cliente], [DNI_Cliente], [Nombre], [Apellido], [Email], [Telefono], [Alta], [Estado]) VALUES (2, N'2222', N'Cliente2', N'Apellido2', N'cliente2@example.com', N'222222', 20231112, 1)
INSERT [dbo].[Cliente] ([Cod_Cliente], [DNI_Cliente], [Nombre], [Apellido], [Email], [Telefono], [Alta], [Estado]) VALUES (3, N'3333', N'Cliente3', N'Apellido3', N'cliente3@example.com', N'333333', 20231112, 1)
SET IDENTITY_INSERT [dbo].[Cliente] OFF
GO
SET IDENTITY_INSERT [dbo].[Empleado] ON 

INSERT [dbo].[Empleado] ([Cod_Empleado], [DNI], [Nombre], [Apellido], [Email], [Contraseña], [Telefono], [ID_perfil], [Estado]) VALUES (1, N'1111', N'Admin', N'Admin', N'admin@example.com', N'1234', N'123456789', 1, 1)
INSERT [dbo].[Empleado] ([Cod_Empleado], [DNI], [Nombre], [Apellido], [Email], [Contraseña], [Telefono], [ID_perfil], [Estado]) VALUES (2, N'2222', N'Vendedor', N'Vende', N'vendedor@example.com', N'1234', N'987654321', 2, 1)
INSERT [dbo].[Empleado] ([Cod_Empleado], [DNI], [Nombre], [Apellido], [Email], [Contraseña], [Telefono], [ID_perfil], [Estado]) VALUES (3, N'3333', N'Supervisor', N'Super', N'supervisor@example.com', N'1234', N'555555555', 3, 1)
SET IDENTITY_INSERT [dbo].[Empleado] OFF
GO
INSERT [dbo].[Perfil] ([ID_perfil], [Descripcion]) VALUES (1, N'Administrador')
INSERT [dbo].[Perfil] ([ID_perfil], [Descripcion]) VALUES (2, N'Vendedor')
INSERT [dbo].[Perfil] ([ID_perfil], [Descripcion]) VALUES (3, N'Supervisor')
GO
SET IDENTITY_INSERT [dbo].[Proveedor] ON 

INSERT [dbo].[Proveedor] ([Cod_Proveedor], [CUIT], [Nombre], [Direccion], [Email], [Telefono], [IVA], [Estado]) VALUES (1, N'1111', N'Proveedor1', N'Dirección1', N'proveedor1@example.com', N'111111', 1, 1)
INSERT [dbo].[Proveedor] ([Cod_Proveedor], [CUIT], [Nombre], [Direccion], [Email], [Telefono], [IVA], [Estado]) VALUES (2, N'2222', N'Proveedor2', N'Dirección2', N'proveedor2@example.com', N'22222', 2, 1)
INSERT [dbo].[Proveedor] ([Cod_Proveedor], [CUIT], [Nombre], [Direccion], [Email], [Telefono], [IVA], [Estado]) VALUES (3, N'3333', N'Proveedor3', N'Dirección3', N'proveedor3@example.com', N'33333', 3, 1)
SET IDENTITY_INSERT [dbo].[Proveedor] OFF
GO
INSERT [dbo].[TipoIva] ([IVA], [Descripcion]) VALUES (1, N'Responsable Inscripto')
INSERT [dbo].[TipoIva] ([IVA], [Descripcion]) VALUES (2, N'Responsable no Inscripto')
INSERT [dbo].[TipoIva] ([IVA], [Descripcion]) VALUES (3, N'Consumidor Final')
GO
INSERT [dbo].[TipoPago] ([Cod_TipoPago], [Descripcion]) VALUES (1, N'Mercado Pago')
INSERT [dbo].[TipoPago] ([Cod_TipoPago], [Descripcion]) VALUES (2, N'Tarjeta de Credito')
GO
ALTER TABLE [dbo].[PedidoProveedor] ADD  DEFAULT ((1)) FOR [Estado]
GO
ALTER TABLE [dbo].[DetalleVenta]  WITH CHECK ADD  CONSTRAINT [FK_Cod_Detalle_Producto_Venta] FOREIGN KEY([Cod_Producto])
REFERENCES [dbo].[Producto] ([Cod_producto])
GO
ALTER TABLE [dbo].[DetalleVenta] CHECK CONSTRAINT [FK_Cod_Detalle_Producto_Venta]
GO
ALTER TABLE [dbo].[DetalleVenta]  WITH CHECK ADD  CONSTRAINT [FK_Cod_Venta] FOREIGN KEY([Cod_Venta])
REFERENCES [dbo].[Venta] ([Cod_Venta])
GO
ALTER TABLE [dbo].[DetalleVenta] CHECK CONSTRAINT [FK_Cod_Venta]
GO
ALTER TABLE [dbo].[Empleado]  WITH CHECK ADD  CONSTRAINT [FK_id_perfil] FOREIGN KEY([ID_perfil])
REFERENCES [dbo].[Perfil] ([ID_perfil])
GO
ALTER TABLE [dbo].[Empleado] CHECK CONSTRAINT [FK_id_perfil]
GO
ALTER TABLE [dbo].[PedidoProveedor]  WITH CHECK ADD  CONSTRAINT [FK_Cod_Producto] FOREIGN KEY([Cod_Producto])
REFERENCES [dbo].[Producto] ([Cod_producto])
GO
ALTER TABLE [dbo].[PedidoProveedor] CHECK CONSTRAINT [FK_Cod_Producto]
GO
ALTER TABLE [dbo].[PedidoProveedor]  WITH CHECK ADD  CONSTRAINT [FK_Cod_Proveedor] FOREIGN KEY([Cod_Proveedor])
REFERENCES [dbo].[Proveedor] ([Cod_Proveedor])
GO
ALTER TABLE [dbo].[PedidoProveedor] CHECK CONSTRAINT [FK_Cod_Proveedor]
GO
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD  CONSTRAINT [FK_ID_Categoria] FOREIGN KEY([ID_Categoria])
REFERENCES [dbo].[Categoria] ([ID_Categoria])
GO
ALTER TABLE [dbo].[Producto] CHECK CONSTRAINT [FK_ID_Categoria]
GO
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD  CONSTRAINT [FK_Proveedor] FOREIGN KEY([Cod_Proveedor])
REFERENCES [dbo].[Proveedor] ([Cod_Proveedor])
GO
ALTER TABLE [dbo].[Producto] CHECK CONSTRAINT [FK_Proveedor]
GO
ALTER TABLE [dbo].[Proveedor]  WITH CHECK ADD  CONSTRAINT [FK_IVA] FOREIGN KEY([IVA])
REFERENCES [dbo].[TipoIva] ([IVA])
GO
ALTER TABLE [dbo].[Proveedor] CHECK CONSTRAINT [FK_IVA]
GO
ALTER TABLE [dbo].[Venta]  WITH CHECK ADD  CONSTRAINT [FK_Cod_Cliente_Venta] FOREIGN KEY([Cod_Cliente])
REFERENCES [dbo].[Cliente] ([Cod_Cliente])
GO
ALTER TABLE [dbo].[Venta] CHECK CONSTRAINT [FK_Cod_Cliente_Venta]
GO
ALTER TABLE [dbo].[Venta]  WITH CHECK ADD  CONSTRAINT [FK_Cod_Empleado_Venta] FOREIGN KEY([Cod_Empleado])
REFERENCES [dbo].[Empleado] ([Cod_Empleado])
GO
ALTER TABLE [dbo].[Venta] CHECK CONSTRAINT [FK_Cod_Empleado_Venta]
GO
ALTER TABLE [dbo].[Venta]  WITH CHECK ADD  CONSTRAINT [FK_Cod_Venta_TipoPago] FOREIGN KEY([Cod_TipoPago])
REFERENCES [dbo].[TipoPago] ([Cod_TipoPago])
GO
ALTER TABLE [dbo].[Venta] CHECK CONSTRAINT [FK_Cod_Venta_TipoPago]
GO
ALTER TABLE [dbo].[Cliente]  WITH CHECK ADD CHECK  (([Estado]=(1) OR [Estado]=(0)))
GO
ALTER TABLE [dbo].[Empleado]  WITH CHECK ADD CHECK  (([Estado]=(1) OR [Estado]=(0)))
GO
ALTER TABLE [dbo].[PedidoProveedor]  WITH CHECK ADD CHECK  (([Estado]=(2) OR [Estado]=(1) OR [Estado]=(0)))
GO
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD CHECK  (([Color]='Gris' OR [Color]='Blanco' OR [Color]='Negro' OR [Color]='Marron'))
GO
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD CHECK  (([Estado]=(1) OR [Estado]=(0)))
GO
ALTER TABLE [dbo].[Proveedor]  WITH CHECK ADD CHECK  (([Estado]=(1) OR [Estado]=(0)))
GO
USE [master]
GO
ALTER DATABASE [UnMate] SET  READ_WRITE 
GO
