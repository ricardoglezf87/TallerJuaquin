USE [master]
GO
/****** Object:  Database [DatosTaller]    Script Date: 19/08/2021 13:21:51 ******/
CREATE DATABASE [DatosTaller]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DatosTaller', FILENAME = N'F:\BBDD\DATA\DatosTaller.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DatosTaller_log', FILENAME = N'F:\BBDD\DATA\DatosTaller_log.ldf' , SIZE = 73728KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [DatosTaller] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DatosTaller].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DatosTaller] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DatosTaller] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DatosTaller] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DatosTaller] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DatosTaller] SET ARITHABORT OFF 
GO
ALTER DATABASE [DatosTaller] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DatosTaller] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DatosTaller] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DatosTaller] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DatosTaller] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DatosTaller] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DatosTaller] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DatosTaller] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DatosTaller] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DatosTaller] SET  ENABLE_BROKER 
GO
ALTER DATABASE [DatosTaller] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DatosTaller] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DatosTaller] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DatosTaller] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DatosTaller] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DatosTaller] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DatosTaller] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DatosTaller] SET RECOVERY FULL 
GO
ALTER DATABASE [DatosTaller] SET  MULTI_USER 
GO
ALTER DATABASE [DatosTaller] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DatosTaller] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DatosTaller] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DatosTaller] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [DatosTaller] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [DatosTaller] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'DatosTaller', N'ON'
GO
ALTER DATABASE [DatosTaller] SET QUERY_STORE = OFF
GO
USE [DatosTaller]
GO
/****** Object:  User [tortilla]    Script Date: 19/08/2021 13:21:51 ******/
CREATE USER [tortilla] FOR LOGIN [tortilla] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [mail]    Script Date: 19/08/2021 13:21:51 ******/
CREATE USER [mail] FOR LOGIN [mail] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [348SERVICIOS\rgonzalez]    Script Date: 19/08/2021 13:21:51 ******/
CREATE USER [348SERVICIOS\rgonzalez] FOR LOGIN [348SERVICIOS\rgonzalez] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [tortilla]
GO
/****** Object:  UserDefinedFunction [dbo].[fn_diagramobjects]    Script Date: 19/08/2021 13:21:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[fn_diagramobjects]() 
	RETURNS int
	WITH EXECUTE AS N'dbo'
	AS
	BEGIN
		declare @id_upgraddiagrams		int
		declare @id_sysdiagrams			int
		declare @id_helpdiagrams		int
		declare @id_helpdiagramdefinition	int
		declare @id_creatediagram	int
		declare @id_renamediagram	int
		declare @id_alterdiagram 	int 
		declare @id_dropdiagram		int
		declare @InstalledObjects	int

		select @InstalledObjects = 0

		select 	@id_upgraddiagrams = object_id(N'dbo.sp_upgraddiagrams'),
			@id_sysdiagrams = object_id(N'dbo.sysdiagrams'),
			@id_helpdiagrams = object_id(N'dbo.sp_helpdiagrams'),
			@id_helpdiagramdefinition = object_id(N'dbo.sp_helpdiagramdefinition'),
			@id_creatediagram = object_id(N'dbo.sp_creatediagram'),
			@id_renamediagram = object_id(N'dbo.sp_renamediagram'),
			@id_alterdiagram = object_id(N'dbo.sp_alterdiagram'), 
			@id_dropdiagram = object_id(N'dbo.sp_dropdiagram')

		if @id_upgraddiagrams is not null
			select @InstalledObjects = @InstalledObjects + 1
		if @id_sysdiagrams is not null
			select @InstalledObjects = @InstalledObjects + 2
		if @id_helpdiagrams is not null
			select @InstalledObjects = @InstalledObjects + 4
		if @id_helpdiagramdefinition is not null
			select @InstalledObjects = @InstalledObjects + 8
		if @id_creatediagram is not null
			select @InstalledObjects = @InstalledObjects + 16
		if @id_renamediagram is not null
			select @InstalledObjects = @InstalledObjects + 32
		if @id_alterdiagram  is not null
			select @InstalledObjects = @InstalledObjects + 64
		if @id_dropdiagram is not null
			select @InstalledObjects = @InstalledObjects + 128
		
		return @InstalledObjects 
	END
GO
/****** Object:  Table [dbo].[POF]    Script Date: 19/08/2021 13:21:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[POF](
	[IDHistorial] [int] NOT NULL,
	[TipoPOF] [int] NULL,
	[Fecha] [datetime] NULL,
	[IVA] [int] NULL,
	[Franquicia] [real] NULL,
	[Total] [real] NULL,
 CONSTRAINT [PK_POF] PRIMARY KEY CLUSTERED 
(
	[IDHistorial] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ArticuloPOF]    Script Date: 19/08/2021 13:21:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ArticuloPOF](
	[IDArticuloPOF] [int] IDENTITY(1,1) NOT NULL,
	[IDHistorial] [int] NOT NULL,
	[Concepto] [varchar](100) NULL,
	[Horas] [int] NULL,
	[Costo] [real] NULL,
	[PVP] [real] NULL,
	[Cantidad] [int] NULL,
 CONSTRAINT [PK_ArticuloPOF] PRIMARY KEY CLUSTERED 
(
	[IDArticuloPOF] ASC,
	[IDHistorial] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[Balance]    Script Date: 19/08/2021 13:21:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Balance]
AS
SELECT        dbo.POF.IDHistorial, dbo.POF.TipoPOF, dbo.POF.Fecha, dbo.POF.IVA, dbo.POF.Franquicia, dbo.POF.Total, dbo.ArticuloPOF.Cantidad, 
                         dbo.ArticuloPOF.PVP * dbo.ArticuloPOF.Cantidad AS PVP, dbo.ArticuloPOF.Costo * dbo.ArticuloPOF.Cantidad AS Costo, dbo.ArticuloPOF.Horas, 
                         dbo.ArticuloPOF.Concepto, (dbo.ArticuloPOF.PVP - dbo.ArticuloPOF.Costo) * dbo.ArticuloPOF.Cantidad AS Ganancia
FROM            dbo.POF INNER JOIN
                         dbo.ArticuloPOF ON dbo.POF.IDHistorial = dbo.ArticuloPOF.IDHistorial


GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 19/08/2021 13:21:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[IDCliente] [int] IDENTITY(1,1) NOT NULL,
	[NombreCliente] [varchar](100) NULL,
	[NombreComercial] [varchar](100) NULL,
	[Direccion] [varchar](255) NULL,
	[CP] [varchar](12) NULL,
	[Poblacion] [varchar](100) NULL,
	[Provincia] [varchar](100) NULL,
	[DNI] [varchar](12) NULL,
	[Email] [varchar](100) NULL,
	[Comentario] [varchar](500) NULL,
	[Aseguradora] [bit] NULL,
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[IDCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Coche]    Script Date: 19/08/2021 13:21:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Coche](
	[IDCoche] [int] IDENTITY(1,1) NOT NULL,
	[IDCliente] [int] NOT NULL,
	[Matricula] [varchar](20) NULL,
	[Marca] [varchar](100) NULL,
	[Modelo] [varchar](100) NULL,
	[Color] [varchar](100) NULL,
 CONSTRAINT [PK_Coche] PRIMARY KEY CLUSTERED 
(
	[IDCoche] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[ClienteCoche]    Script Date: 19/08/2021 13:21:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[ClienteCoche]
AS
SELECT        dbo.Cliente.NombreCliente, dbo.Cliente.NombreComercial, dbo.Cliente.Direccion, dbo.Cliente.CP, dbo.Cliente.Poblacion, dbo.Cliente.Provincia, dbo.Cliente.DNI, 
                         dbo.Coche.Matricula, dbo.Coche.Marca, dbo.Coche.Modelo, dbo.Coche.Color, dbo.Coche.IDCoche, dbo.Coche.IDCliente
FROM            dbo.Cliente INNER JOIN
                         dbo.Coche ON dbo.Cliente.IDCliente = dbo.Coche.IDCliente
GO
/****** Object:  Table [dbo].[AgendaTrabajo]    Script Date: 19/08/2021 13:21:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AgendaTrabajo](
	[IDAgendaTrabajo] [int] NOT NULL,
	[Fecha] [datetime] NULL,
	[Nota] [varchar](500) NULL,
 CONSTRAINT [PK_AgendaTrabajo] PRIMARY KEY CLUSTERED 
(
	[IDAgendaTrabajo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Blanco]    Script Date: 19/08/2021 13:21:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Blanco](
	[Blanco] [text] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Compras]    Script Date: 19/08/2021 13:21:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Compras](
	[IDCompras] [int] IDENTITY(1,1) NOT NULL,
	[Fecha] [datetime] NULL,
	[Concepto] [varchar](255) NULL,
	[Precio] [real] NULL,
 CONSTRAINT [PK_Compras] PRIMARY KEY CLUSTERED 
(
	[IDCompras] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Historial]    Script Date: 19/08/2021 13:21:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Historial](
	[IDHistorial] [int] IDENTITY(1,1) NOT NULL,
	[IDCoche] [int] NOT NULL,
	[FechaEntrada] [datetime] NULL,
	[FechaSalida] [datetime] NULL,
	[Observaciones] [varchar](300) NULL,
	[Kilometros] [varchar](50) NULL,
 CONSTRAINT [PK_Historial] PRIMARY KEY CLUSTERED 
(
	[IDHistorial] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Opciones]    Script Date: 19/08/2021 13:21:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Opciones](
	[RutaPredeterminada] [text] NULL,
	[RutaFondoPantalla] [text] NULL,
	[TamañoFondoPantalla] [text] NULL,
	[Telefono] [text] NULL,
	[Movil] [text] NULL,
	[Email] [text] NULL,
	[WEB] [text] NULL,
	[RutaBaseDatosFotos] [text] NULL,
	[anMatricula] [bigint] NULL,
	[anMarca] [bigint] NULL,
	[anModelo] [int] NULL,
	[anColor] [int] NULL,
	[anFechaEntrada] [int] NULL,
	[anFechaSalida] [int] NULL,
	[anObservaciones] [int] NULL,
	[anTotal] [int] NULL,
	[anNombreCliente] [int] NULL,
	[anNombreComercial] [int] NULL,
	[anCP] [int] NULL,
	[anPoblacion] [int] NULL,
	[anProvincia] [int] NULL,
	[anDNI] [int] NULL,
	[anEmail] [int] NULL,
	[anComentario] [int] NULL,
	[anAseguradora] [int] NULL,
	[TamTit] [text] NULL,
	[TamFactPresu] [text] NULL,
	[TamCabecera] [text] NULL,
	[TamCliDet] [text] NULL,
	[TamCliTit] [text] NULL,
	[TamDetDatos] [text] NULL,
	[TamTitDatos] [text] NULL,
	[TamBlanco] [text] NULL,
	[anConcepto] [int] NULL,
	[anCantidad] [int] NULL,
	[anCosto] [int] NULL,
	[anPVP] [int] NULL,
	[Porcentaje] [int] NULL,
	[anHoras] [int] NULL,
	[anTipoPOF] [int] NULL,
	[Obervaciones] [text] NULL,
	[tamGrande] [real] NULL,
	[tamMediana] [real] NULL,
	[tamPequeña] [real] NULL,
	[anIDHistorial] [text] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TelefonoCliente]    Script Date: 19/08/2021 13:21:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TelefonoCliente](
	[IDTelefonoCliente] [int] NOT NULL,
	[IDCliente] [int] NOT NULL,
	[Numero] [varchar](50) NULL,
 CONSTRAINT [PK_TelefonoCliente] PRIMARY KEY CLUSTERED 
(
	[IDTelefonoCliente] ASC,
	[IDCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[BorrarArticuloPOF]    Script Date: 19/08/2021 13:21:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[BorrarArticuloPOF]
(
	@IDArticuloPOF int
)
AS
	SET NOCOUNT OFF;
DELETE from ArticuloPOF
where IDArticuloPOF=@IDArticuloPOF      	

GO
/****** Object:  StoredProcedure [dbo].[BorrarCliente]    Script Date: 19/08/2021 13:21:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[BorrarCliente]
(
	@IDCliente int
)
as
	SET NOCOUNT OFF;
	DELETE from Cliente
	where IDCliente=@IDCliente 
GO
/****** Object:  StoredProcedure [dbo].[BorrarCoche]    Script Date: 19/08/2021 13:21:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BorrarCoche]
(
	@IDCoche int
)
AS
	SET NOCOUNT OFF;
DELETE from Coche
where IDCoche=@IDCoche
GO
/****** Object:  StoredProcedure [dbo].[BorrarHistorial]    Script Date: 19/08/2021 13:21:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[BorrarHistorial]
(
	@IDHistorial int
)
AS
	SET NOCOUNT OFF;
DELETE from Historial
where IDHistorial=@IDHistorial      	
GO
/****** Object:  StoredProcedure [dbo].[BorrarImagenHistorial]    Script Date: 19/08/2021 13:21:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BorrarImagenHistorial]
(
	@IDImagenHistorial int
)
AS
	SET NOCOUNT OFF;
DELETE from ImagenHistorial
where IDImagenHistorial=@IDImagenHistorial  
GO
/****** Object:  StoredProcedure [dbo].[BorrarPOF]    Script Date: 19/08/2021 13:21:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[BorrarPOF]
(
	@IDPOF int
)
AS
	SET NOCOUNT OFF;
DELETE from POF
where IDHistorial=@IDPOF      	
GO
/****** Object:  StoredProcedure [dbo].[BorrarTelefonoCliente]    Script Date: 19/08/2021 13:21:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BorrarTelefonoCliente]
(
	@IDTelefonoCliente int
)
AS
	SET NOCOUNT OFF;
DELETE from TelefonoCliente
where IDTelefonoCliente=@IDTelefonoCliente      	
GO
/****** Object:  StoredProcedure [dbo].[BorrarTelefonosVacios]    Script Date: 19/08/2021 13:21:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BorrarTelefonosVacios]
AS
	SET NOCOUNT OFF;
DELETE FROM TelefonoCliente
WHERE        (Numero = '') OR
                         (Numero = ' ') OR
                         (Numero = NULL) OR
                         (Numero = '""') OR
                         (Numero = N'" "')   
GO
/****** Object:  StoredProcedure [dbo].[ClientebyIDCoche]    Script Date: 19/08/2021 13:21:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ClientebyIDCoche]
(
	@IDCoche int
)
AS
	SET NOCOUNT ON;
SELECT        IDCliente
FROM            Coche
WHERE        (IDCoche = @IDCoche) 
GO
/****** Object:  StoredProcedure [dbo].[FillByCoche]    Script Date: 19/08/2021 13:21:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[FillByCoche]
(
	@IDCoche int
)
AS
	SET NOCOUNT ON;
SELECT IDHistorial, IDCoche, FechaEntrada, FechaSalida, Observaciones,Kilometros FROM dbo.Historial where IDCoche=@IDCoche    
GO
/****** Object:  StoredProcedure [dbo].[FillByIDHistorial]    Script Date: 19/08/2021 13:21:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[FillByIDHistorial]
(
	@IDHistorial int
)
AS
	SET NOCOUNT ON;
SELECT IDImagenHistorial, IDHistorial, Imagen FROM dbo.ImagenHistorial where IDHistorial=@IDHistorial 
GO
/****** Object:  StoredProcedure [dbo].[sp_alterdiagram]    Script Date: 19/08/2021 13:21:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_alterdiagram]
	(
		@diagramname 	sysname,
		@owner_id	int	= null,
		@version 	int,
		@definition 	varbinary(max)
	)
	WITH EXECUTE AS 'dbo'
	AS
	BEGIN
		set nocount on
	
		declare @theId 			int
		declare @retval 		int
		declare @IsDbo 			int
		
		declare @UIDFound 		int
		declare @DiagId			int
		declare @ShouldChangeUID	int
	
		if(@diagramname is null)
		begin
			RAISERROR ('Invalid ARG', 16, 1)
			return -1
		end
	
		execute as caller;
		select @theId = DATABASE_PRINCIPAL_ID();	 
		select @IsDbo = IS_MEMBER(N'db_owner'); 
		if(@owner_id is null)
			select @owner_id = @theId;
		revert;
	
		select @ShouldChangeUID = 0
		select @DiagId = diagram_id, @UIDFound = principal_id from dbo.sysdiagrams where principal_id = @owner_id and name = @diagramname 
		
		if(@DiagId IS NULL or (@IsDbo = 0 and @theId <> @UIDFound))
		begin
			RAISERROR ('Diagram does not exist or you do not have permission.', 16, 1);
			return -3
		end
	
		if(@IsDbo <> 0)
		begin
			if(@UIDFound is null or USER_NAME(@UIDFound) is null) -- invalid principal_id
			begin
				select @ShouldChangeUID = 1 ;
			end
		end

		-- update dds data			
		update dbo.sysdiagrams set definition = @definition where diagram_id = @DiagId ;

		-- change owner
		if(@ShouldChangeUID = 1)
			update dbo.sysdiagrams set principal_id = @theId where diagram_id = @DiagId ;

		-- update dds version
		if(@version is not null)
			update dbo.sysdiagrams set version = @version where diagram_id = @DiagId ;

		return 0
	END
GO
/****** Object:  StoredProcedure [dbo].[sp_creatediagram]    Script Date: 19/08/2021 13:21:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_creatediagram]
	(
		@diagramname 	sysname,
		@owner_id		int	= null, 	
		@version 		int,
		@definition 	varbinary(max)
	)
	WITH EXECUTE AS 'dbo'
	AS
	BEGIN
		set nocount on
	
		declare @theId int
		declare @retval int
		declare @IsDbo	int
		declare @userName sysname
		if(@version is null or @diagramname is null)
		begin
			RAISERROR (N'E_INVALIDARG', 16, 1);
			return -1
		end
	
		execute as caller;
		select @theId = DATABASE_PRINCIPAL_ID(); 
		select @IsDbo = IS_MEMBER(N'db_owner');
		revert; 
		
		if @owner_id is null
		begin
			select @owner_id = @theId;
		end
		else
		begin
			if @theId <> @owner_id
			begin
				if @IsDbo = 0
				begin
					RAISERROR (N'E_INVALIDARG', 16, 1);
					return -1
				end
				select @theId = @owner_id
			end
		end
		-- next 2 line only for test, will be removed after define name unique
		if EXISTS(select diagram_id from dbo.sysdiagrams where principal_id = @theId and name = @diagramname)
		begin
			RAISERROR ('The name is already used.', 16, 1);
			return -2
		end
	
		insert into dbo.sysdiagrams(name, principal_id , version, definition)
				VALUES(@diagramname, @theId, @version, @definition) ;
		
		select @retval = @@IDENTITY 
		return @retval
	END
GO
/****** Object:  StoredProcedure [dbo].[sp_dropdiagram]    Script Date: 19/08/2021 13:21:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
	CREATE PROCEDURE [dbo].[sp_dropdiagram]
	(
		@diagramname 	sysname,
		@owner_id	int	= null
	)
	WITH EXECUTE AS 'dbo'
	AS
	BEGIN
		set nocount on
		declare @theId 			int
		declare @IsDbo 			int
		
		declare @UIDFound 		int
		declare @DiagId			int
	
		if(@diagramname is null)
		begin
			RAISERROR ('Invalid value', 16, 1);
			return -1
		end
	
		EXECUTE AS CALLER;
		select @theId = DATABASE_PRINCIPAL_ID();
		select @IsDbo = IS_MEMBER(N'db_owner'); 
		if(@owner_id is null)
			select @owner_id = @theId;
		REVERT; 
		
		select @DiagId = diagram_id, @UIDFound = principal_id from dbo.sysdiagrams where principal_id = @owner_id and name = @diagramname 
		if(@DiagId IS NULL or (@IsDbo = 0 and @UIDFound <> @theId))
		begin
			RAISERROR ('Diagram does not exist or you do not have permission.', 16, 1)
			return -3
		end
	
		delete from dbo.sysdiagrams where diagram_id = @DiagId;
	
		return 0;
	END
GO
/****** Object:  StoredProcedure [dbo].[sp_helpdiagramdefinition]    Script Date: 19/08/2021 13:21:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_helpdiagramdefinition]
	(
		@diagramname 	sysname,
		@owner_id	int	= null 		
	)
	WITH EXECUTE AS N'dbo'
	AS
	BEGIN
		set nocount on

		declare @theId 		int
		declare @IsDbo 		int
		declare @DiagId		int
		declare @UIDFound	int
	
		if(@diagramname is null)
		begin
			RAISERROR (N'E_INVALIDARG', 16, 1);
			return -1
		end
	
		execute as caller;
		select @theId = DATABASE_PRINCIPAL_ID();
		select @IsDbo = IS_MEMBER(N'db_owner');
		if(@owner_id is null)
			select @owner_id = @theId;
		revert; 
	
		select @DiagId = diagram_id, @UIDFound = principal_id from dbo.sysdiagrams where principal_id = @owner_id and name = @diagramname;
		if(@DiagId IS NULL or (@IsDbo = 0 and @UIDFound <> @theId ))
		begin
			RAISERROR ('Diagram does not exist or you do not have permission.', 16, 1);
			return -3
		end

		select version, definition FROM dbo.sysdiagrams where diagram_id = @DiagId ; 
		return 0
	END
GO
/****** Object:  StoredProcedure [dbo].[sp_helpdiagrams]    Script Date: 19/08/2021 13:21:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
	CREATE PROCEDURE [dbo].[sp_helpdiagrams]
	(
		@diagramname sysname = NULL,
		@owner_id int = NULL
	)
	WITH EXECUTE AS N'dbo'
	AS
	BEGIN
		DECLARE @user sysname
		DECLARE @dboLogin bit
		EXECUTE AS CALLER;
			SET @user = USER_NAME();
			SET @dboLogin = CONVERT(bit,IS_MEMBER('db_owner'));
		REVERT;
		SELECT
			[Database] = DB_NAME(),
			[Name] = name,
			[ID] = diagram_id,
			[Owner] = USER_NAME(principal_id),
			[OwnerID] = principal_id
		FROM
			sysdiagrams
		WHERE
			(@dboLogin = 1 OR USER_NAME(principal_id) = @user) AND
			(@diagramname IS NULL OR name = @diagramname) AND
			(@owner_id IS NULL OR principal_id = @owner_id)
		ORDER BY
			4, 5, 1
	END
GO
/****** Object:  StoredProcedure [dbo].[sp_renamediagram]    Script Date: 19/08/2021 13:21:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_renamediagram]
	(
		@diagramname 		sysname,
		@owner_id		int	= null,
		@new_diagramname	sysname
	
	)
	WITH EXECUTE AS 'dbo'
	AS
	BEGIN
		set nocount on
		declare @theId 			int
		declare @IsDbo 			int
		
		declare @UIDFound 		int
		declare @DiagId			int
		declare @DiagIdTarg		int
		declare @u_name			sysname
		if((@diagramname is null) or (@new_diagramname is null))
		begin
			RAISERROR ('Invalid value', 16, 1);
			return -1
		end
	
		EXECUTE AS CALLER;
		select @theId = DATABASE_PRINCIPAL_ID();
		select @IsDbo = IS_MEMBER(N'db_owner'); 
		if(@owner_id is null)
			select @owner_id = @theId;
		REVERT;
	
		select @u_name = USER_NAME(@owner_id)
	
		select @DiagId = diagram_id, @UIDFound = principal_id from dbo.sysdiagrams where principal_id = @owner_id and name = @diagramname 
		if(@DiagId IS NULL or (@IsDbo = 0 and @UIDFound <> @theId))
		begin
			RAISERROR ('Diagram does not exist or you do not have permission.', 16, 1)
			return -3
		end
	
		-- if((@u_name is not null) and (@new_diagramname = @diagramname))	-- nothing will change
		--	return 0;
	
		if(@u_name is null)
			select @DiagIdTarg = diagram_id from dbo.sysdiagrams where principal_id = @theId and name = @new_diagramname
		else
			select @DiagIdTarg = diagram_id from dbo.sysdiagrams where principal_id = @owner_id and name = @new_diagramname
	
		if((@DiagIdTarg is not null) and  @DiagId <> @DiagIdTarg)
		begin
			RAISERROR ('The name is already used.', 16, 1);
			return -2
		end		
	
		if(@u_name is null)
			update dbo.sysdiagrams set [name] = @new_diagramname, principal_id = @theId where diagram_id = @DiagId
		else
			update dbo.sysdiagrams set [name] = @new_diagramname where diagram_id = @DiagId
		return 0
	END
GO
/****** Object:  StoredProcedure [dbo].[sp_upgraddiagrams]    Script Date: 19/08/2021 13:21:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
	CREATE PROCEDURE [dbo].[sp_upgraddiagrams]
	AS
	BEGIN
		IF OBJECT_ID(N'dbo.sysdiagrams') IS NOT NULL
			return 0;
	
		CREATE TABLE dbo.sysdiagrams
		(
			name sysname NOT NULL,
			principal_id int NOT NULL,	-- we may change it to varbinary(85)
			diagram_id int PRIMARY KEY IDENTITY,
			version int,
	
			definition varbinary(max)
			CONSTRAINT UK_principal_name UNIQUE
			(
				principal_id,
				name
			)
		);


		/* Add this if we need to have some form of extended properties for diagrams */
		/*
		IF OBJECT_ID(N'dbo.sysdiagram_properties') IS NULL
		BEGIN
			CREATE TABLE dbo.sysdiagram_properties
			(
				diagram_id int,
				name sysname,
				value varbinary(max) NOT NULL
			)
		END
		*/

		IF OBJECT_ID(N'dbo.dtproperties') IS NOT NULL
		begin
			insert into dbo.sysdiagrams
			(
				[name],
				[principal_id],
				[version],
				[definition]
			)
			select	 
				convert(sysname, dgnm.[uvalue]),
				DATABASE_PRINCIPAL_ID(N'dbo'),			-- will change to the sid of sa
				0,							-- zero for old format, dgdef.[version],
				dgdef.[lvalue]
			from dbo.[dtproperties] dgnm
				inner join dbo.[dtproperties] dggd on dggd.[property] = 'DtgSchemaGUID' and dggd.[objectid] = dgnm.[objectid]	
				inner join dbo.[dtproperties] dgdef on dgdef.[property] = 'DtgSchemaDATA' and dgdef.[objectid] = dgnm.[objectid]
				
			where dgnm.[property] = 'DtgSchemaNAME' and dggd.[uvalue] like N'_EA3E6268-D998-11CE-9454-00AA00A3F36E_' 
			return 2;
		end
		return 1;
	END
GO
USE [master]
GO
ALTER DATABASE [DatosTaller] SET  READ_WRITE 
GO
